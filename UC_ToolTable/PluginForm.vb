Option Explicit Off

Imports System.Threading
Imports System.Windows.Forms
Imports System.Text
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports System
Imports System.Net.Mail
Imports System.Net

Imports System.Reflection
Imports System.Xml
Imports System.Xml.Serialization

Imports System.Diagnostics

Public Class PluginForm





#Region "Declarations"


    Friend uccncplugin

    Public UC As Plugininterface.Entry
    Dim PluginMain As UCCNCplugin
    Dim MustClose As Boolean = False

    'Dim IsMovingFlag As Boolean = False ' Add 4-6-19, test threading
    'Dim abortflag As Boolean = False

    'Dim t As New Thread(AddressOf Me.BackgroundProcess)
    'Dim thrMyProc As New Thread(Sub() MyProbeGridThread())
    'Dim thrMyProc As Thread
    'Public enablemail As Boolean
    'Public LEDState(0 To 5) As Boolean




    Private goingtoclose As Boolean = False
    Private res As DialogResult



    Dim ds As DataSet

    Dim xmaxVel, ymaxVel, zmaxVel As Double

    Dim toolnum As Integer

    Friend thrMyProc As Thread


    'Flags to kill threads
    Dim IsMovingFlag As Boolean = False ' Add 4-6-19, test threading
    Friend abortflag As Boolean = False


#End Region





    Public Sub New(CallerPluginMain As UCCNCplugin)
        Me.UC = CallerPluginMain.UC
        Me.PluginMain = CallerPluginMain
        InitializeComponent()
    End Sub

    Private Sub PluginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Try

            lblAppVersion.Text = Me.UC.Plugproperties.pluginname & ", v " & Me.UC.Plugproperties.pluginversion


        Catch ex As Exception
            MsgBox("Version error")
        End Try


        '===================

        Dim xmlpath1 As String = Application.StartupPath & "\plugins\TurnTableTools.xml"


        ds = CreateDataset()
        'Set DataGridView1 
        DataGridView1.DataSource = ds.Tables("Tools")

        If File.Exists(xmlpath1) Then
            LoadFromXMLfile(xmlpath1)
        End If


        ''================Tool Tray Icon
        'NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        'NotifyIcon1.BalloonTipText = "UC_Emailer"
        'NotifyIcon1.BalloonTipTitle = "UC Emailer is running"
        'NotifyIcon1.ShowBalloonTip(2000)

        ''====================



        '======= over-ride by loading saved settings
        Try
            Dim xmlpath2 As String = Application.StartupPath & "\plugins\TurnTable.xml"

            Dim FS As New FormSerialisor
            FS.Deserialise(Me, xmlpath2)
        Catch ex As Exception
            MsgBox("Error loading saved settings from XML file.")
        End Try



        ' ==== Setup buttons/LEDs


        If UC.GetLED(246) Then

            btnJSP.BackColor = Color.LightGreen
            btnJSP.Text = "Jog Safe Probe ON"
        Else

            btnJSP.BackColor = Color.DarkGray
            btnJSP.Text = "Jog Safe Probe OFF"
        End If






        ''================================================


        xmaxVel = UC.Getfielddouble(True, 9)
        'ymaxVel = UC.Getfielddouble(True, 24)
        zmaxVel = UC.Getfielddouble(True, 39)

        If xmaxVel = 0 Or zmaxVel = 0 Then
            MsgBox("Error loading maximum axis velocity values from UCCNC.")
        End If



        Dim modalWorkCordTest As Int16
        modalWorkCordTest = UC.Getactualmodalcode(12)

        Try ' Get the current G90/G91 state
            If modalWorkCordTest = 54 Then
                btnG54.PerformClick()
            ElseIf modalWorkCordTest = 55 Then
                btng55.PerformClick()
            ElseIf modalWorkCordTest = 56 Then
                btnG56.PerformClick()
            ElseIf modalWorkCordTest = 57 Then
                btnG57.PerformClick()
            ElseIf modalWorkCordTest = 58 Then
                btnG58.PerformClick()
            ElseIf modalWorkCordTest = 59 Then
                btnG59.PerformClick()
            End If
        Catch ex As Exception
            MsgBox("Failed to get modal for woork coordinate system")
        End Try

    End Sub

    Private Sub PluginForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Do not close the form when the red X button is pressed
        ' But start a Thread which will stop the Loop call from the UCCNC
        ' to prevent the form closing while there is a GUI update in the Loop event

        If goingtoclose = False Then

            res = MessageBox.Show("OK to close, Cancel to minimize to taskbar.", "Close?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        End If

        If res = DialogResult.Cancel Then

            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized

        Else

            If Not MustClose Then
                goingtoclose = True
                e.Cancel = True
                Dim thrClose As New Thread(Sub() Closeform())
                thrClose.CurrentCulture = Thread.CurrentThread.CurrentCulture ' Preserve regional settings
                thrClose.Start()
            Else
                ' Form is closing here...

            End If

        End If


    End Sub

    Public Sub Closeform()
        ' Stop the Loop event to update the GUI
        PluginMain.LoopStop = True
        ' Wait until the loop exited
        While (PluginMain.LoopWorking)
            Thread.Sleep(10)
        End While
        ' Set the mustclose variable to true and call the .Close() function to close the Form
        MustClose = True
        Me.Close()
    End Sub





    'Public Sub StatMsg(count As Integer, x As String, y As String, z As String)
    '    'i = count
    '    'x1 = x
    '    'y1 = y
    '    'z1 = z

    '    UC.AddStatusmessage("Point " & i & " recorded = " & fn(x1) & ", " & fn(y1) & ", " & fn(z1))
    'End Sub



    Public Function fn(ByRef val As Double)
        Return String.Format("{0:F4}", val)
        'Return String.Format("f6", val)
    End Function

    '    '  Optional way:  exec.Code("G0 X" + val.ToString("F6")); // Back away from edge

    '    'End Module










#Region "TextBoxes & Form stuff"
    '=================================== Text Box input filtering =====================

    'Private Sub TextBox12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If (Not Char.IsControl(e.KeyChar) _
    '                 AndAlso (Not Char.IsDigit(e.KeyChar) _
    '                 AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
    '        e.Handled = True
    '    End If
    'End Sub







    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F2
                ' Do something 

            Case Keys.F3
                ' Do more

            Case Keys.Escape
                ' Crap

            Case Keys.F12
                'RecordPoint()

                'Case Keys.Space
                'Button10.PerformClick()


            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)



        End Select

        Return True
    End Function

#End Region

#Region "Buttons"

    '




    ' Zero X/Y DROs
    Private Sub btnXZero_Click(sender As Object, e As EventArgs) Handles btnXZero.Click
        UC.Setfield(True, 0, 226)
        UC.Validatefield(True, 226)

    End Sub



    Private Sub btnYZero_Click(sender As Object, e As EventArgs)

        UC.Setfield(True, 0, 227)
        UC.Validatefield(True, 227)
    End Sub

    Private Sub btnZZero_Click(sender As Object, e As EventArgs) Handles btnZZero.Click

        UC.Setfield(True, 0, 228)
        UC.Validatefield(True, 228)
    End Sub




    Private Sub btnG54_Click(sender As Object, e As EventArgs) Handles btnG54.Click
        UC.Callbutton(118)
        workcoordbuttonOff()
        btnG54.BackColor = Color.LightGreen
    End Sub

    Private Sub btng55_Click(sender As Object, e As EventArgs) Handles btng55.Click
        UC.Callbutton(119)
        workcoordbuttonOff()
        btng55.BackColor = Color.LightGreen

    End Sub

    Private Sub btnG56_Click(sender As Object, e As EventArgs) Handles btnG56.Click
        UC.Callbutton(120)
        workcoordbuttonOff()
        btnG56.BackColor = Color.LightGreen

    End Sub

    Private Sub btnG57_Click(sender As Object, e As EventArgs) Handles btnG57.Click
        UC.Callbutton(121)
        workcoordbuttonOff()
        btnG57.BackColor = Color.LightGreen

    End Sub

    Private Sub btnG58_Click(sender As Object, e As EventArgs) Handles btnG58.Click
        UC.Callbutton(122)
        workcoordbuttonOff()
        btnG58.BackColor = Color.LightGreen

    End Sub

    Private Sub btnG59_Click(sender As Object, e As EventArgs) Handles btnG59.Click
        UC.Callbutton(123)
        workcoordbuttonOff()
        btnG59.BackColor = Color.LightGreen

    End Sub

    Sub workcoordbuttonOff()

        btnG54.BackColor = Color.Gray
        btng55.BackColor = Color.Gray
        btnG56.BackColor = Color.Gray
        btnG57.BackColor = Color.Gray
        btnG58.BackColor = Color.Gray
        btnG59.BackColor = Color.Gray
    End Sub




    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        formsave()
    End Sub







#End Region


#Region "Checkbox toggles"


    Private Sub button4_Click(sender As Object, e As EventArgs)
        linkLabel1.LinkVisited = True
        ' //Call the Process.Start method to open the default browser 
        ' //with a URL:
        System.Diagnostics.Process.Start(Application.StartupPath & "\documentation\LEDs_by_number.htm")
    End Sub



#End Region




#Region "Jog Buttons"



#Region "JOGGING ENABLE"



    Private Sub cbJogEnab_CheckedChanged(sender As Object, e As EventArgs) Handles cbJogEnab.CheckedChanged
        jogenabchangecheck()
    End Sub



    Sub jogenabchangecheck()
        If cbJogEnab.Checked = True Then
            rbJogCont.Enabled = True
            rbJogStep.Enabled = True
            btnJogDn.Enabled = True
            btnJogUp.Enabled = True
            btnJogRight.Enabled = True
            btnJogLeft.Enabled = True
            btnjogZup.Enabled = True
            btnjogZdown.Enabled = True
        Else
            rbJogCont.Enabled = False
            rbJogStep.Enabled = False
            btnJogDn.Enabled = False
            btnJogUp.Enabled = False
            btnJogRight.Enabled = False
            btnJogLeft.Enabled = False
            btnjogZup.Enabled = False
            btnjogZdown.Enabled = False
        End If
    End Sub

#End Region


    ' X and Y Jogs
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnJogUp.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(1, False, yvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(1, nudJogStep.Value, 1, yvelPCT(nudJogVel.Value), False)
        End If
    End Sub
    Private Sub Button1_Click_1a(sender As Object, e As EventArgs) Handles btnJogUp.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(1, False, 0)
        End If
    End Sub

    Private Sub btnJogLeft_Click(sender As Object, e As EventArgs) Handles btnJogLeft.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, xvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(0, nudJogStep.Value, 1, xvelPCT(nudJogVel.Value), True)
        End If
    End Sub
    Private Sub btnJogLeft_Click1(sender As Object, e As EventArgs) Handles btnJogLeft.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, 0)
        End If
    End Sub

    Private Sub btnJogRight_Click(sender As Object, e As EventArgs) Handles btnJogRight.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, False, xvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(0, nudJogStep.Value, 1, xvelPCT(nudJogVel.Value), False)
        End If
    End Sub
    Private Sub btnJogRight_Click1(sender As Object, e As EventArgs) Handles btnJogRight.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, False, 0)
        End If

    End Sub
    Private Sub btnJogDn_Click(sender As Object, e As EventArgs) Handles btnJogDn.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(1, True, yvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(1, nudJogStep.Value, 1, yvelPCT(nudJogVel.Value), True)
        End If
    End Sub
    Private Sub btnJogDn_Click1(sender As Object, e As EventArgs) Handles btnJogDn.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(1, True, 0)
        End If

    End Sub

    ' Z Jogs
    Private Sub btnjogZup_Click(sender As Object, e As EventArgs) Handles btnjogZup.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(2, False, zvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(2, nudJogStep.Value, 1, zvelPCT(nudJogVel.Value), False)
        End If
    End Sub
    Private Sub btnjogZup_Click2(sender As Object, e As EventArgs) Handles btnjogZup.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(2, False, 0)
        End If
    End Sub

    Private Sub btnjogZdown_Click(sender As Object, e As EventArgs) Handles btnjogZdown.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(2, True, zvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(2, nudJogStep.Value, 1, zvelPCT(nudJogVel.Value), True)
        End If
    End Sub

    Private Sub btnjogZdown_Click2(sender As Object, e As EventArgs) Handles btnjogZdown.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(2, True, 0)
        End If
    End Sub


    Private Sub rbJogStep_CheckedChanged(sender As Object, e As EventArgs) Handles rbJogStep.CheckedChanged
        If rbJogCont.Checked Then


            nudJogStep.Visible = False
            nudJogVel.Visible = True
            'tbJogStepSize.Visible = False
            'tbJogVel.Visible = True
            lblStepSize.Visible = False
            lblJogVel.Visible = True
        Else

            nudJogStep.Visible = True
            nudJogVel.Visible = False
            'tbJogStepSize.Visible = True
            'tbJogVel.Visible = False
            lblStepSize.Visible = True
            lblJogVel.Visible = False
        End If
    End Sub




    Private Function xvelPCT(ByVal xvel As Double) As Double

        'Convert speed in 'unit/min' to 'Jog %'
        If xmaxVel = 0 And ymaxVel = 0 Then
            xmaxVel = UC.Getfielddouble(True, 9)
            ymaxVel = UC.Getfielddouble(True, 24)
            zmaxVel = UC.Getfielddouble(True, 39)

        End If

        xvelPCT = xvel / xmaxVel * 100 ' Define velocity as a % of max axis velocity, as input to JogOnSpeed command.
        Return xvelPCT
    End Function

    Private Function yvelPCT(ByVal yvel As Double) As Double

        'Convert speed in 'unit/min' to 'Jog %'
        If xmaxVel = 0 And ymaxVel = 0 Then
            xmaxVel = UC.Getfielddouble(True, 9)
            ymaxVel = UC.Getfielddouble(True, 24)
            zmaxVel = UC.Getfielddouble(True, 39)

        End If

        yvelPCT = yvel / ymaxVel * 100 ' Define velocity as a % of max axis velocity, as input to JogOnSpeed command.
        Return yvelPCT
    End Function

    Private Function zvelPCT(ByVal zvel As Double) As Double

        'Convert speed in 'unit/min' to 'Jog %'
        If xmaxVel = 0 And ymaxVel = 0 Then
            xmaxVel = UC.Getfielddouble(True, 9)
            ymaxVel = UC.Getfielddouble(True, 24)
            zmaxVel = UC.Getfielddouble(True, 39)
        End If

        zvelPCT = zvel / zmaxVel * 100 ' Define velocity as a % of max axis velocity, as input to JogOnSpeed command.
        Return zvelPCT
    End Function


#End Region


    Public Sub formsave()

        Try
            Dim xmlpath As String = Application.StartupPath & "\plugins\TurnTable.xml"
            Dim FS As New FormSerialisor

            FS.Serialise(Me, xmlpath)

        Catch ex As Exception
            MsgBox("Error saving settings to XML file.")

        End Try


    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ShowPluginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowPluginToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub



    Private Sub PluginForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If (Me.WindowState = FormWindowState.Minimized) Then
            NotifyIcon1.Visible = True
            Me.Hide()
        End If

    End Sub








    Private Sub cbOnTop_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbOnTop.CheckedChanged
        If cbOnTop.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub rbRadiusMode_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbRadiusMode.CheckedChanged

        RadDiamChange()

    End Sub

    Private Sub rbDiamMode_CheckedChanged(sender As Object, e As EventArgs) Handles rbDiamMode.CheckedChanged

        RadDiamChange()

    End Sub


    Private Sub RadDiamChange()
        ' Get the X Axis steps per value that is current
        'Dim XStepsPer As Double = UC.Getfield(True, 8)
        Dim XStepsPer As Double


        Try



            If tbStepUnitRadius.Text = "" Then
                MsgBox("Need to enter your X Axis Steps per Unit for radius moves.  Click the 'get steps' button to auto populate from UCCNC settings")
            Else

                XStepsPer = Convert.ToDouble(tbStepUnitRadius.Text)



                ' Get the X Axis curent pos
                Dim XCurPos As Double = UC.GetXpos



                If cbShowMessages.Checked Then

                    MsgBox(XStepsPer & ", " & XCurPos)

                End If




                Dim XStepsPerReal As Double = UC.Getfield(True, 8)

                If rbRadiusMode.Checked Then ' Radius Mode

                    'XStepsPer = XStepsPer * 2

                    If Convert.ToDouble(tbStepUnitRadius.Text) <> XStepsPerReal Then
                        XCurPos = XCurPos / 2

                        UC.Setfield(True, XStepsPer, 8)  ' Update steps/unit if required
                        UC.Validatefield(True, 8)


                        UC.Callbutton(167)
                        UC.Callbutton(168)


                        UC.Setfield(True, XCurPos, 226) ' Update DRO to radius
                        UC.Validatefield(True, 226)


                        lblTouchOffs.Text = "Touch-off values. Enter as a RADIAL value:"
                        lblTouchOffs.ForeColor = Color.Black


                    Else
                        ' if it matches radius units, do nothing
                        lblTouchOffs.Text = "Touch-off values. Enter as a RADIAL value:"
                        lblTouchOffs.ForeColor = Color.Black
                    End If



                Else ' Diameter mode

                    If (Convert.ToDouble(tbStepUnitRadius.Text) * 2) <> XStepsPerReal Then
                        XStepsPer = XStepsPer / 2

                        XCurPos = XCurPos * 2

                        UC.Setfield(True, XStepsPer, 8)
                        UC.Validatefield(True, 8)


                        UC.Callbutton(167)
                        UC.Callbutton(168)

                        UC.Setfield(True, XCurPos, 226)
                        UC.Validatefield(True, 226)

                        lblTouchOffs.Text = "Touch-off values. Enter as a DIAMETRAL value:"
                        lblTouchOffs.ForeColor = Color.Red


                    Else
                        ' if it matches diam units, do nothing
                        lblTouchOffs.Text = "Touch-off values. Enter as a DIAMETRAL value:"
                        lblTouchOffs.ForeColor = Color.Red
                    End If





                End If



            End If


        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnEStop_Click_1(sender As Object, e As EventArgs) Handles btnEStop.Click
        UC.Callbutton(144)

    End Sub






#Region "ToolTable"

    Private Sub btnTouchXID_Click(sender As Object, e As EventArgs) Handles btnTouchXID.Click
        If tbXTouchInputID.Text = "" Then
            MsgBox("Enter an X Touch Diameter/Radius into the text box above")
            Return
        ElseIf UC.Getactualmodalcode(12) <> 54 Then

            MsgBox("Please switch to G54 for doing touchoff of tool offsets")
            Return


        Else


            Dim ToolNum As Int16
            ToolNum = nudActiveTool.Value

            Dim touchX As Double ' offsetting value
            Dim machX As Double ' Machine coord
            Dim posX As Double ' current X DRO
            Dim workX As Double ' current work offset (G54, etc)

            Dim offsetXcalctxt As String ' calculated offset to store to table

            touchX = Convert.ToDouble(tbXTouchInputID.Text)
            machX = UC.GetXmachpos
            posX = UC.GetXpos
            workX = UC.Getfielddouble(True, 133) ' 133. is x offset, 135 is z offset


            If rbDiamMode.Checked = True Then ' diameter mode

                'set G92 to zero first!
                UC.Setfield(True, 0, 500)
                UC.Validatefield(True, 500)

                'calc offset
                offsetXcalctxt = fn(machX - workX - touchX) / 2 'Store the offeset as a radius

                ''Set G92 based on the measured offset
                'UC.Setfield(True, offsetXcalc, 500)
                'UC.Validatefield(True, 500)

            Else

                'set G92 to zero first!
                UC.Setfield(True, 0, 500)
                UC.Validatefield(True, 500)

                'calc offset
                offsetXcalctxt = fn(machX - workX - touchX)   'Store the offeset as a radius

                ''Set G92 based on the measured offset
                'UC.Setfield(True, offsetXcalc, 500)
                'UC.Validatefield(True, 500)

            End If


            DataGridView1.Rows(nudActiveTool.Value - 1).Cells(2).Value = offsetXcalctxt

            ApplyOffset()

        End If

    End Sub


    Private Sub btnTouchX_Click(sender As Object, e As EventArgs) Handles btnTouchX.Click

        If tbXTouchInput.Text = "" Then
            MsgBox("Enter an X Touch Diameter/Radius into the text box above")
            Return
        ElseIf UC.Getactualmodalcode(12) <> 54 Then

            MsgBox("Please switch to G54 for doing touchoff of tool offsets")
            Return


        Else


            Dim ToolNum As Int16
            ToolNum = nudActiveTool.Value

            Dim touchX As Double ' offsetting value
            Dim machX As Double ' Machine coord
            Dim posX As Double ' current X DRO
            Dim workX As Double ' current work offset (G54, etc)

            Dim offsetXcalctxt As String ' calculated offset to store to table

            touchX = Convert.ToDouble(tbXTouchInput.Text)
            machX = UC.GetXmachpos
            posX = UC.GetXpos
            workX = UC.Getfielddouble(True, 133) ' 133. is x offset, 135 is z offset


            If rbDiamMode.Checked = True Then ' diameter mode

                'set G92 to zero first!
                UC.Setfield(True, 0, 500)
                UC.Validatefield(True, 500)

                'calc offset
                offsetXcalctxt = fn(machX - workX - touchX) / 2 'Store the offeset as a radius

                ''Set G92 based on the measured offset
                'UC.Setfield(True, offsetXcalc, 500)
                'UC.Validatefield(True, 500)

            Else

                'set G92 to zero first!
                UC.Setfield(True, 0, 500)
                UC.Validatefield(True, 500)

                'calc offset
                offsetXcalctxt = fn(machX - workX - touchX)   'Store the offeset as a radius

                ''Set G92 based on the measured offset
                'UC.Setfield(True, offsetXcalc, 500)
                'UC.Validatefield(True, 500)

            End If


            DataGridView1.Rows(nudActiveTool.Value - 1).Cells(2).Value = offsetXcalctxt

            ApplyOffset()

        End If

    End Sub


    Private Sub btnTouchZ_Click(sender As Object, e As EventArgs) Handles btnTouchZ.Click
        If tbZTouchInput.Text = "" Then
            MsgBox("Enter an Z Touch Value into the text box above")
            Return
        ElseIf UC.Getactualmodalcode(12) <> 54 Then

            MsgBox("Please switch to G54 for doing touchoff of tool offsets")
            Return


        Else


            Dim ToolNum As Int16
            ToolNum = nudActiveTool.Value

            Dim touchZ As Double ' offsetting value
            Dim machZ As Double ' Machine coord
            Dim posZ As Double ' current X DRO
            Dim workZ As Double ' current work offset (G54, etc)

            Dim offsetZcalctxt As String ' calculated offset to store to table

            touchZ = Convert.ToDouble(tbZTouchInput.Text)
            machZ = UC.GetZmachpos
            posZ = UC.GetZpos
            workZ = UC.Getfielddouble(True, 135) ' 133. is x offset, 135 is z offset


            'If rbDiamMode.Checked = True Then ' diameter mode

            '    'set G92 to zero first!
            '    UC.Setfield(True, 0, 500)
            '    UC.Validatefield(True, 500)

            '    'calc offset
            '    offsetXcalc = (machX - workX - touchX) '/ 2 'Store the offeset as a radius

            '    'Set G92 based on the measured offset
            '    UC.Setfield(True, offsetXcalc, 500)
            '    UC.Validatefield(True, 500)

            'Else

            'set G92 to zero first!
            UC.Setfield(True, 0, 502)
            UC.Validatefield(True, 502)

            'calc offset
            offsetZcalctxt = fn(machZ - workZ - touchZ)  'Store the offeset as a radius

            ''Set G92 based on the measured offset
            'UC.Setfield(True, offsetZcalc, 502)
            'UC.Validatefield(True, 502)


            'End If

            DataGridView1.Rows(nudActiveTool.Value - 1).Cells(3).Value = offsetZcalctxt

            ApplyOffset()


        End If
    End Sub








    Private Sub btnSaveTable_Click(sender As Object, e As EventArgs) Handles btnSaveTable.Click
        '            
        Dim xmltooltablepath As String = Application.StartupPath & "\plugins\TurnTableTools.xml"

        Try
            SaveToXMLFile(xmltooltablepath, ds)
        Catch ex As Exception

        End Try


        'SaveToXMLFile("c:\temp\tools.xml", ds)
    End Sub



    Private Sub btnLoadTable_Click(sender As Object, e As EventArgs) Handles btnLoadTable.Click
        Dim xmltablepath As String = Application.StartupPath & "\plugins\TurnTableTools.xml"
        Try
            LoadFromXMLfile(xmltablepath)

        Catch ex As Exception

        End Try


        'LoadFromXMLfile("c:\temp\tools.xml")
    End Sub


    Private Sub SaveToXMLFile(filename As String, d As DataSet)
        Dim ser As XmlSerializer = New XmlSerializer(GetType(DataSet))
        Dim writer As TextWriter = New StreamWriter(filename)
        ser.Serialize(writer, d)
        writer.Close()
    End Sub

    Private Sub LoadFromXMLfile(filename As String)

        Try
            If System.IO.File.Exists(filename) Then
                Dim xmlSerializer As XmlSerializer = New XmlSerializer(ds.GetType)
                Dim readStream As FileStream = New FileStream(filename, FileMode.Open)
                ds = CType(xmlSerializer.Deserialize(readStream), DataSet)
                readStream.Close()
                DataGridView1.DataSource = ds.Tables("Tools")
            Else
                MsgBox("file not found! add data and press save button first.", MsgBoxStyle.Exclamation, "")
            End If


            For i = 2 To 5
                For j = 0 To 98
                    If IsNumeric(DataGridView1.Rows(j).Cells(i).Value) Then

                        DataGridView1.Rows(j).Cells(i).Value = fn(DataGridView1.Rows(j).Cells(i).Value)

                    End If
                Next
            Next
        Catch ex As Exception

        End Try


    End Sub


    Private Function CreateDataset() As DataSet
        Dim dataset1 As New DataSet("Tools")
        Dim table1 As New DataTable("Tools")
        table1.Columns.Add("Id/#")
        table1.Columns.Add("Description")
        table1.Columns.Add("X Offset")
        table1.Columns.Add("Z Offset")
        table1.Columns.Add("X Wear")
        table1.Columns.Add("Z Wear")
        '...

        For i = 1 To 99
            If i < 10 Then
                table1.Rows.Add("0" & i)
                table1.Columns(1).DefaultValue = "---"
                table1.Columns(2).DefaultValue = "0.000"
                table1.Columns(3).DefaultValue = "0.000"
                table1.Columns(4).DefaultValue = "0.000"
                table1.Columns(5).DefaultValue = "0.000"
            Else
                table1.Rows.Add(i)

            End If

        Next


        dataset1.Tables.Add(table1)




        Return dataset1
    End Function




    Private Sub nudActiveTool_ValueChanged(sender As Object, e As EventArgs) Handles nudActiveTool.ValueChanged
        Try

            DataGridView1.ClearSelection()
            DataGridView1.Rows(nudActiveTool.Value - 1).Selected = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Try
            nudActiveTool.Value = Convert.ToDecimal(DataGridView1.SelectedRows)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSetOffsets.Click

        ApplyOffset()


    End Sub

    Private Sub CheckIsMoving()
        IsMovingFlag = UC.IsMoving
    End Sub

    Private Function IsMoving() As Boolean
        Dim thrIsMoving As New Thread(Sub() CheckIsMoving())
        thrIsMoving.CurrentCulture = Thread.CurrentThread.CurrentCulture ' Maradjon angol!
        thrIsMoving.Start()
        While thrIsMoving.IsAlive
            Thread.Sleep(1)
        End While
        Return IsMovingFlag
    End Function

    Sub TChange()


        UC.AddStatusmessage("Running tool change to tool " & toolnum)


        Try


            strMoveCode = "M6 T" & toolnum

            UC.Codesync(strMoveCode)

            While IsMoving()
                Thread.Sleep(5)
            End While

            thrMyProc = Nothing

        Catch ex As Exception

            MsgBox("Error in Tool Change")
            thrMyProc = Nothing

        End Try



    End Sub

    Sub ApplyOffset() ' Applies offsets for the 'active tool' immediately


        ' checkbox # 76:  ignore tool change
        'checkbox #77, stop and wait for start on tool change
        'CheckBox #78, run M6 macro

        If UC.Getcheckboxstate(True, 78) AndAlso nudActiveTool.Value <> UC.Getfield(True, 897) Then

            If cbToolChange.Checked Then


                If cbM6Prompt.Checked Then ' run w/ prompt

                    ans = MsgBox("Run toolchange of turret?", vbYesNo)

                    If ans = vbYes Then

                        If thrMyProc IsNot Nothing Then
                            MsgBox("Already Running A Turret Change")

                            Exit Sub
                        Else

                            toolnum = nudActiveTool.Value

                            Try



                                If thrMyProc Is Nothing Then

                                    abortflag = False

                                    thrMyProc = New Thread(AddressOf TChange)
                                    thrMyProc.CurrentCulture = Thread.CurrentThread.CurrentCulture
                                    thrMyProc.Start()

                                Else

                                End If
                            Catch ex As Exception
                                MsgBox("Didn't work....")
                                thrMyProc = Nothing
                            End Try
                        End If


                    Else

                        Return

                    End If

                Else ' Run w/out prompt



                    toolnum = nudActiveTool.Value

                    Try



                        If thrMyProc Is Nothing Then

                            abortflag = False

                            thrMyProc = New Thread(AddressOf TChange)
                            thrMyProc.CurrentCulture = Thread.CurrentThread.CurrentCulture
                            thrMyProc.Start()

                        Else

                        End If
                    Catch ex As Exception
                        MsgBox("Didn't work....")
                        thrMyProc = Nothing
                    End Try


                End If

            End If





        End If

        ActiveToolIndex = nudActiveTool.Value - 1

        Dim xoffset, zoffset, xwear, zwear As Double


        Try
            xoffset = Convert.ToDouble(DataGridView1.Rows(ActiveToolIndex).Cells(2).Value)
            zoffset = Convert.ToDouble(DataGridView1.Rows(ActiveToolIndex).Cells(3).Value)
            xwear = Convert.ToDouble(DataGridView1.Rows(ActiveToolIndex).Cells(4).Value)
            zwear = Convert.ToDouble(DataGridView1.Rows(ActiveToolIndex).Cells(5).Value)

            If cbUseWear.Checked Then
                xoffset = xoffset + xwear
                zoffset = zoffset + zwear

            End If

            If rbDiamMode.Checked Then
                xoffset = xoffset * 2
            End If

            If cbShowMessages.Checked Then

                MsgBox(xoffset & ", " & zoffset & ", " & xwear & ", " & zwear)

            End If



            'Set G92 based on the measured offset
            UC.Setfield(True, Convert.ToDouble(fn(xoffset)), 500)
            UC.Validatefield(True, 500)

            UC.Setfield(True, Convert.ToDouble(fn(zoffset)), 502)
            UC.Validatefield(True, 502)

        Catch ex As Exception

        End Try
    End Sub



    Private Sub DataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            nudActiveTool.Value = DataGridView1.CurrentCell.RowIndex + 1 'Convert.ToDecimal(DataGridView1.SelectedRows)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCycleStart_Click(sender As Object, e As EventArgs) Handles btnCycleStart.Click
        UC.Callbutton(128)
    End Sub

    Private Sub btnJSP_Click(sender As Object, e As EventArgs) Handles btnJSP.Click

        UC.Callbutton(554)

    End Sub

    Private Sub LabelXAxis_Click(sender As Object, e As EventArgs) Handles LabelXAxis.Click
        newX = InputBox("Enter new X value", "Axis Value Change", "0.000")
        If newX = "" Then
            Exit Sub

        Else
            Try
                newX = Convert.ToDouble(newX)
                UC.Setfield(True, newX, 226)
                UC.Validatefield(True, 226)
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub LabelZAxis_Click(sender As Object, e As EventArgs) Handles LabelZAxis.Click
        newZ = InputBox("Enter new Z value", "Axis Value Change", "0.000")
        If newZ = "" Then
            Exit Sub

        Else
            Try
                newZ = Convert.ToDouble(newZ)
                UC.Setfield(True, newZ, 228)
                UC.Validatefield(True, 228)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick

    End Sub

    Private Sub ProbeTriggeredCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ProbeTriggeredCheck.CheckedChanged
        If ProbeTriggeredCheck.Checked Then

            ProbeTriggeredCheck.BackgroundImage = My.Resources.ResourceManager.GetObject("ProbeActive_Small")
        Else
            ProbeTriggeredCheck.BackgroundImage = My.Resources.ResourceManager.GetObject("ProbeInactive_Small")
        End If

    End Sub



    Private Sub btnFeedHold_Click(sender As Object, e As EventArgs) Handles btnFeedHold.Click
        UC.Callbutton(522)
    End Sub



    Private Sub btnGetSteps_Click(sender As Object, e As EventArgs) Handles btnGetSteps.Click
        ' Get the X Axis steps per value that is current
        Dim XStepsPer As Double = UC.Getfield(True, 8)
        tbStepUnitRadius.Text = XStepsPer
    End Sub






#End Region

    'Private Sub chkboxAutoEnable_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoEnable.CheckedChanged
    '    If chkboxAutoEnable.Checked Then
    '        NumericUpDown1.Enabled = True
    '    Else
    '        NumericUpDown1.Enabled = False
    '    End If
    'End Sub
End Class

' THIS WORKS



Public Class FormSerialisor
    Sub Serialise(ByVal c As Control, ByVal XmlFileName As String)
        Dim xmlSerialisedForm As XmlTextWriter = New XmlTextWriter(XmlFileName, System.Text.Encoding.[Default])
        xmlSerialisedForm.Formatting = Formatting.Indented
        xmlSerialisedForm.WriteStartDocument()
        xmlSerialisedForm.WriteStartElement("ChildForm")
        AddChildControls(xmlSerialisedForm, c)
        xmlSerialisedForm.WriteEndElement()
        xmlSerialisedForm.WriteEndDocument()
        xmlSerialisedForm.Flush()
        xmlSerialisedForm.Close()
    End Sub

    Private Sub AddChildControls(ByVal xmlSerialisedForm As XmlTextWriter, ByVal c As Control)
        For Each childCtrl As Control In c.Controls

            If Not (TypeOf childCtrl Is Label) Then
                xmlSerialisedForm.WriteStartElement("Control")
                xmlSerialisedForm.WriteAttributeString("Type", childCtrl.[GetType]().ToString())
                xmlSerialisedForm.WriteAttributeString("Name", childCtrl.Name)

                If TypeOf childCtrl Is TextBox Then
                    xmlSerialisedForm.WriteElementString("Text", (CType(childCtrl, TextBox)).Text)
                ElseIf TypeOf childCtrl Is ComboBox Then
                    xmlSerialisedForm.WriteElementString("Text", (CType(childCtrl, ComboBox)).Text)
                    xmlSerialisedForm.WriteElementString("SelectedIndex", (CType(childCtrl, ComboBox)).SelectedIndex.ToString())
                ElseIf TypeOf childCtrl Is ListBox Then
                    Dim lst As ListBox = CType(childCtrl, ListBox)

                    If lst.SelectedIndex = -1 Then
                        xmlSerialisedForm.WriteElementString("SelectedIndex", "-1")
                    Else

                        For i As Integer = 0 To lst.SelectedIndices.Count - 1
                            xmlSerialisedForm.WriteElementString("SelectedIndex", (lst.SelectedIndices(i).ToString()))
                        Next
                    End If
                ElseIf TypeOf childCtrl Is CheckBox Then
                    xmlSerialisedForm.WriteElementString("Checked", (CType(childCtrl, CheckBox)).Checked.ToString())
                ElseIf TypeOf childCtrl Is NumericUpDown Then
                    xmlSerialisedForm.WriteElementString("Value", (CType(childCtrl, NumericUpDown)).Value.ToString())
                ElseIf TypeOf childCtrl Is RadioButton Then
                    xmlSerialisedForm.WriteElementString("Checked", (CType(childCtrl, RadioButton)).Checked.ToString())
                ElseIf TypeOf childCtrl Is DataGridView Then
                    'do nothing
                End If

                Dim visible As Boolean = CBool(GetType(Control).GetMethod("GetState", BindingFlags.Instance Or BindingFlags.NonPublic).Invoke(childCtrl, New Object() {2}))
                xmlSerialisedForm.WriteElementString("Visible", visible.ToString())

                If childCtrl.HasChildren Then
                    If Not TypeOf childCtrl Is NumericUpDown Then
                        If TypeOf childCtrl Is SplitContainer Then
                            AddChildControls(xmlSerialisedForm, (CType(childCtrl, SplitContainer)).Panel1)
                            AddChildControls(xmlSerialisedForm, (CType(childCtrl, SplitContainer)).Panel2)
                        ElseIf TypeOf childCtrl Is DataGridView Then
                            'do nothing
                        Else
                            AddChildControls(xmlSerialisedForm, childCtrl)
                        End If
                    End If
                End If

                xmlSerialisedForm.WriteEndElement()
            End If
        Next
    End Sub

    Sub Deserialise(ByVal c As Control, ByVal XmlFileName As String)
        If File.Exists(XmlFileName) Then
            Dim xmlSerialisedForm As XmlDocument = New XmlDocument()
            xmlSerialisedForm.Load(XmlFileName)
            Dim topLevel As XmlNode = xmlSerialisedForm.ChildNodes(1)

            For Each n As XmlNode In topLevel.ChildNodes

                Try
                    SetControlProperties(CType(c, Control), n)
                Catch
                End Try
            Next
        End If
    End Sub

    Private Sub SetControlProperties(ByVal currentCtrl As Control, ByVal n As XmlNode)
        Dim controlName As String = n.Attributes("Name").Value
        Dim controlType As String = n.Attributes("Type").Value
        Dim ctrl As Control() = currentCtrl.Controls.Find(controlName, True)

        If ctrl.Length = 0 Then
            MessageBox.Show("can't find control")
        Else
            Dim ctrlToSet As Control = GetImmediateChildControl(ctrl, currentCtrl)

            If ctrlToSet IsNot Nothing Then

                If ctrlToSet.[GetType]().ToString() = controlType Then

                    Select Case controlType
                        Case "System.Windows.Forms.TextBox"
                            CType(ctrlToSet, System.Windows.Forms.TextBox).Text = n("Text").InnerText
                        Case "System.Windows.Forms.ComboBox"
                            CType(ctrlToSet, System.Windows.Forms.ComboBox).Text = n("Text").InnerText
                        Case "System.Windows.Forms.ListBox"
                            Dim lst As ListBox = CType(ctrlToSet, ListBox)
                            Dim xnlSelectedIndex As XmlNodeList = n.SelectNodes("SelectedIndex")

                            For i As Integer = 0 To xnlSelectedIndex.Count - 1
                                lst.SelectedIndex = Convert.ToInt32(xnlSelectedIndex(i).InnerText)
                            Next

                        Case "System.Windows.Forms.CheckBox"
                            CType(ctrlToSet, System.Windows.Forms.CheckBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
                        Case "System.Windows.Forms.NumericUpDown"
                            CType(ctrlToSet, System.Windows.Forms.NumericUpDown).Value = Convert.ToDecimal(n("Value").InnerText)
                        Case "System.Windows.Forms.RadioButton"
                            CType(ctrlToSet, System.Windows.Forms.RadioButton).Checked = Convert.ToBoolean(n("Checked").InnerText)

                            'Case "System.Windows.Forms.DataGridView"
                            '    CType(ctrlToSet, System.Windows.Forms.RadioButton).Checked = Convert.ToBoolean(n("Checked").InnerText)

                    End Select

                    ctrlToSet.Visible = Convert.ToBoolean(n("Visible").InnerText)

                    If n.HasChildNodes AndAlso ctrlToSet.HasChildren Then
                        Dim xnlControls As XmlNodeList = n.SelectNodes("Control")

                        For Each n2 As XmlNode In xnlControls
                            SetControlProperties(ctrlToSet, n2)
                        Next
                    End If
                Else
                    MessageBox.Show("wrong type")
                End If
            Else
                MessageBox.Show("can't find")
            End If
        End If
    End Sub

    Private Function GetImmediateChildControl(ByVal ctrl As Control(), ByVal currentCtrl As Control) As Control
        Dim c As Control = Nothing

        For i As Integer = 0 To ctrl.Length - 1

            If (ctrl(i).Parent.Name = currentCtrl.Name) OrElse (TypeOf currentCtrl Is SplitContainer AndAlso ctrl(i).Parent.Parent.Name = currentCtrl.Name) Then
                c = ctrl(i)
                Exit For
            End If
        Next

        Return c
    End Function
End Class