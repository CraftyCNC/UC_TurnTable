Option Explicit Off

Imports System.Threading
Imports System.Windows.Forms
Imports System.Text
Imports System.Drawing
Imports System.Data
Imports System.Text.RegularExpressions






'Public
Public Class UCCNCplugin
    Public UC As Plugininterface.Entry

    Friend LoopStop As Boolean
    Friend LoopWorking As Boolean

    Dim FirstRun As Boolean = True
    Dim MyForm As PluginForm

    Public running As Boolean
    Public idled As Boolean
    Public lastrunning As Boolean = False
    Public filefinished As Boolean = False

    Private _swenab As New Stopwatch
    Private _swdisab As New Stopwatch
    Private incycle As Boolean = False


    Private curtext As String
    Private curline As String


    Private lasttext As String
    Private curtool As String
    Private lasttool As String = ""

    Private curGloading As Boolean = False
    Private lastGloading As Boolean = False

    Private lastJSP As Boolean = False
    Private curJSP As Boolean = False

    Dim curWorkCoord, lastWorkCoord As Int16



    ' Called when the plugin is initialised.
    ' The parameter is the Plugin interface object which contains all functions prototypes for calls and callbacks.
    Public Sub Init_event(UC As Plugininterface.Entry)
        Me.UC = UC
        MyForm = New PluginForm(Me)

        LoopStop = False

    End Sub

    ' Called when the plugin is loaded, the author of the plugin should set the details of the plugin here.
    Public Function Getproperties_event(ByVal Properties As Plugininterface.Entry.Pluginproperties) As Plugininterface.Entry.Pluginproperties
        Properties.author = "E Brust / CraftyCNC"
        Properties.pluginname = "TurnTable"
        Properties.pluginversion = "1.001a"
        'Properties.pluginversion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString ' Get version from Assembly info
        Return Properties
    End Function

    ' Called from UCCNC when the user presses the Configuration button in the Plugin configuration menu.
    ' Typically the plugin configuration window is shown to the user.
    Public Sub Configure_event()
        Dim CForm As New ConfigForm(Me)
        CForm.Show()
    End Sub

    ' Called from UCCNC when the plugin is loaded and started.
    Public Sub Startup_event()
        If MyForm.IsDisposed Then
            MyForm = New PluginForm(Me)
        End If
        MyForm.Show()


    End Sub

    ' Called when the Pluginshowup(string Pluginfilename); function is executed in the UCCNC.
    Public Sub Showup_event()
        If MyForm.IsDisposed Then
            MyForm = New PluginForm(Me)
        End If
        MyForm.Show()
        MyForm.BringToFront()

        LoopStop = False

    End Sub

    ' Called when the UCCNC software is closing.
    Public Sub Shutdown_event()
        Try
            MyForm.Close()
        Catch ex As Exception

        End Try
    End Sub

    ' Called in a loop with a 25Hz interval.
    Public Sub Loop_event()
        If LoopStop Then
            Return
        End If
        LoopWorking = True
        If MyForm Is Nothing Or MyForm.IsDisposed Then
            Return
        End If
        If FirstRun Then
            FirstRun = False
            ' Write code here which has to be run on first cycle only...
        End If
        Try


            ' Set X & Z axis DRO data
            If MyForm.rbDiamMode.Checked Then

                MyForm.LabelXAxis.ForeColor = Color.Red
                MyForm.LabelXAxis.Text = "X: " + UC.Getfield(True, 226)

                MyForm.lblRadDiam.Text = "Diameter"
                MyForm.lblRadDiam.ForeColor = Color.Red

            Else

                MyForm.LabelXAxis.ForeColor = Color.Black
                MyForm.LabelXAxis.Text = "X: " + UC.Getfield(True, 226)

                MyForm.lblRadDiam.Text = "Radius"
                MyForm.lblRadDiam.ForeColor = Color.Black

            End If


            'MyForm.LabelYAxis.Text = "Y: " + UC.Getfield(True, 227)
            MyForm.LabelZAxis.Text = "Z: " + UC.Getfield(True, 228)


            ' G92 display
            MyForm.lblG92X.Text = "G92 X: " + UC.Getfield(True, 500)
            MyForm.lblG92Z.Text = "G92 Z: " + UC.Getfield(True, 502)



            'JSP button update

            curJSP = UC.GetLED(246)
            If curJSP <> lastJSP Then

                If UC.GetLED(246) Then

                    MyForm.btnJSP.BackColor = Color.LightGreen
                    MyForm.btnJSP.Text = "Jog Safe Probe - ON"
                Else

                    MyForm.btnJSP.BackColor = Color.DarkGray
                    MyForm.btnJSP.Text = "Jog Safe Probe - OFF"
                End If


            End If




            ' Work coorinates update
            curWorkCoord = UC.Getactualmodalcode(12)
            If curWorkCoord <> lastWorkCoord Then 'Woord Coordinates Changed in UCCNC side
                If curWorkCoord = 54 Then
                    MyForm.btnG54.PerformClick()

                ElseIf curWorkCoord = 55 Then
                    MyForm.btng55.PerformClick()

                ElseIf curWorkCoord = 56 Then
                    MyForm.btnG56.PerformClick()

                ElseIf curWorkCoord = 57 Then
                    MyForm.btnG57.PerformClick()

                ElseIf curWorkCoord = 58 Then
                    MyForm.btnG58.PerformClick()

                ElseIf curWorkCoord = 59 Then
                    MyForm.btnG59.PerformClick()
                End If
            End If

            lastWorkCoord = curWorkCoord



            ' Check file loading , set display after a load
            curGloading = UC.IsLoading
            'MyForm.TestLabel.Text = Convert.ToString(curGloading)

            If curGloading <> lastGloading Then

                If curGloading = False Then ' Just quit loading a file, went from tru to false
                    If MyForm.cbViewerSet.Checked Then

                        'Set the display to x/z 
                        UC.Callbutton(141)

                    End If

                End If


            End If




            ''Probe trigger LED
            MyForm.ProbeTriggeredCheck.Checked = UC.GetLED(37)

            'Reset button LED
            If UC.GetLED(25) Then
                MyForm.btnEStop.BackColor = Color.DarkSalmon
            Else
                MyForm.btnEStop.BackColor = Color.LightGreen
            End If





            'Tool tracking and updating
            lasttext = ""
            running = UC.GetLED(54)  ' The 'RUN' LED is on or off?
            idled = UC.GetLED(18)  ' The 'RUN' LED is on or off?



            If idled = True Or running = True Then
                'If running = True Then

                curtext = UC.Getcurrgcodelinetext
                curline = UC.Getcurrentgcodelinenumber
                MyForm.Label10.Text = curline & ":  " & curtext


                Try
                    curtool = UC.Getfield(True, 897)
                    curtool = ExtractAndOrderTool(curtool)
                Catch ex As Exception

                End Try




                If curtool <> "" And curtool <> "0" Then

                    MyForm.Label11.Text = curtool


                    If curtool <> lasttool Then


                        'While running = True ' Hold here until goes idle
                        '    Thread.Sleep(10)
                        'End While


                        MyForm.nudActiveTool.Value = Convert.ToDouble(curtool) ' THIS CHANGES ACTIVE TOOL HERE!

                        If MyForm.cbToolNumUpdate.Checked Then

                            MyForm.ApplyOffset() ' THIS APPLIES THE OFFSETS as G92 
                            Thread.Sleep(50)

                        End If

                    End If

                End If





                'curtext = UC.Getcurrgcodelinetext



                'If curtext <> lasttext Then

                '    MyForm.Label10.Text = curtext

                '    MyForm.Label11.Text = ExtractAndOrderXYZ(curtext)


                '    If ExtractAndOrderXYZ(curtext) <> "" Then

                '        curtool = MyForm.Label11.Text

                '        If curtool <> lasttool Then


                '            MyForm.nudActiveTool.Value = Convert.ToDouble(curtool) ' THIS CHANGES ACTIVE TOOL HERE!

                '            If MyForm.cbToolNumUpdate.Checked Then

                '                MyForm.ApplyOffset() ' THIS APPLIES THE OFFSETS as G92 
                '                Thread.Sleep(50)

                '            End If

                '        End If



                '    End If



                'End If


                'lasttool = curtool

                'lasttext = curtext




            End If



                ' Set triggers
                lasttool = curtool

            lastJSP = curJSP

            lastrunning = running

            lastGloading = curGloading

        Catch ex As Exception

        End Try
        LoopWorking = False
        ' Console.WriteLine("" + Convert.ToInt32("A"))
    End Sub


    Function ExtractAndOrderXYZ(s As String) As String
        'Dim num = "([+-]?[0-9.]+)" ' regex to match a number
        Dim num2 = "([0-9][0-9])" ' regex to match a 2 digit number
        Dim num1 = "([0-9])" ' regex to match a number

        'Dim xMatch = Regex.Match(s, "x" & num, RegexOptions.IgnoreCase)
        'Dim yMatch = Regex.Match(s, "y" & num, RegexOptions.IgnoreCase)
        'Dim zMatch = Regex.Match(s, "z" & num, RegexOptions.IgnoreCase)
        Dim tMatch2 = Regex.Match(s, "t" & num2, RegexOptions.IgnoreCase)
        Dim tmatch1 = Regex.Match(s, "t" & num1, RegexOptions.IgnoreCase)

        Dim orderedString = ""

        If tMatch2.Success Then
            orderedString = tMatch2.Captures(0).Value

            tMatch2 = Regex.Match(orderedString, num2, RegexOptions.IgnoreCase)
            orderedString = tMatch2.Captures(0).Value


        ElseIf tmatch1.Success Then
            orderedString = tmatch1.Captures(0).Value

            tmatch1 = Regex.Match(orderedString, num1, RegexOptions.IgnoreCase)
            orderedString = tmatch1.Captures(0).Value
        Else
            orderedString = ""
            'MsgBox("word problem getting tool num")
        End If

        'orderedString.Split("t")


        'If yMatch.Success Then
        '    orderedString &= yMatch.Captures(0).Value
        'End If

        'If zMatch.Success Then
        '    orderedString &= zMatch.Captures(0).Value
        'End If

        Return orderedString

    End Function


    Function ExtractAndOrderTool(s As String) As String

        Try
            Dim num4 = "([0-9][0-9][0-9][0-9])" ' regex to match a 4 digit number
            Dim num3 = "([0-9][0-9][0-9])" ' regex to match a 3 digit number

            Dim num2 = "([0-9][0-9])" ' regex to match a 2 digit number
            Dim num1 = "([0-9])" ' regex to match a number


            Dim tMatch4 = Regex.Match(s, num4, RegexOptions.IgnoreCase)

            Dim tMatch3 = Regex.Match(s, num3, RegexOptions.IgnoreCase)

            Dim tMatch2 = Regex.Match(s, num2, RegexOptions.IgnoreCase)

            Dim tmatch1 = Regex.Match(s, num1, RegexOptions.IgnoreCase)



            Dim orderedString = ""

            If tMatch4.Success Then '4 digits found

                orderedString = tMatch4.Captures(0).Value

                tMatch4 = Regex.Match(orderedString, num4, RegexOptions.IgnoreCase)


                ' Need to take only the first 2 of 4 (last two assumed junk or from lathe tool offset)


                orderedString = Left(tMatch2.Captures(0).Value, 2)


            ElseIf tMatch3.Success Then ' 3 digits found

                orderedString = tMatch3.Captures(0).Value

                tMatch3 = Regex.Match(orderedString, num3, RegexOptions.IgnoreCase)

                ' Need to take only the first 1 of 3 (last two assumed junk or from lathe tool offset)


                orderedString = Left(tMatch2.Captures(0).Value, 1)


            ElseIf tMatch2.Success Then ' 2 digits found

                orderedString = tMatch2.Captures(0).Value

                tMatch2 = Regex.Match(orderedString, num2, RegexOptions.IgnoreCase)

                'Use 2 digits as found
                orderedString = tMatch2.Captures(0).Value


            ElseIf tmatch1.Success Then ' 1 digit found

                orderedString = tmatch1.Captures(0).Value

                'Use 1 digit as found
                tmatch1 = Regex.Match(orderedString, num1, RegexOptions.IgnoreCase)
                orderedString = tmatch1.Captures(0).Value
            Else
                orderedString = ""
                'MsgBox("word problem getting tool num")
            End If


            Return orderedString
        Catch ex As Exception

        End Try




    End Function







    ' This is a direct function call addressed to this plugin dll
    ' The function can be called by macros or by another plugin
    ' The passed parameter is an object and the return value is also an object
    Public Function Informplugin_event(Message As Object) As Object
        If Not (MyForm Is Nothing Or MyForm.IsDisposed) Then
            If TypeOf Message Is String Then
                Dim receivedstr As String = Message
                MsgBox("Informplugin message received by Plugintest! Message was: " + receivedstr)
            End If
        End If
        Dim returnstr As String = "Return string by Plugintest"
        Return returnstr
    End Function

    ' This is a function call made to all plugin dll files
    ' The function can be called by macros or by another plugin
    ' The passed parameter is an object and there is no return value
    Public Sub Informplugins_event(Message As Object)
        If Not (MyForm Is Nothing Or MyForm.IsDisposed) Then
            If TypeOf Message Is String Then
                Dim receivedstr As String = Message
                MsgBox("Informplugins message received by Plugintest! Message was: " + receivedstr)
            End If
        End If
    End Sub

    ' Called when the user presses a button on the UCCNC GUI or if a Callbutton function is executed.
    ' The int buttonnumber parameter is the ID of the caller button.
    ' The bool onscreen parameter is true if the button was pressed on the GUI and is false if the Callbutton function was called.
    Public Sub Buttonpress_event(ByVal ButtonNumber As Integer, ByVal OnScreen As Boolean)
        If OnScreen Then
            If ButtonNumber = My.Settings.OpenCode Then

                UC.Pluginshowup("TurnTable.dll")

                'OR
                'This doesnt work well, issues with loop restart and things not working right afterwards....  Use above!

                'Dim thrShowForm As Thread = New Thread(New ThreadStart(AddressOf showform))
                'thrShowForm.CurrentCulture = Thread.CurrentThread.CurrentCulture
                'thrShowForm.Start()

                'LoopStop = False ' re-enable lo

            End If
        End If
    End Sub

    ' Called when the user clicks and enters a Textfield on the screen
    ' The labelnumber parameter is the ID of the accessed Textfield
    ' The bool Ismainscreen parameter is true is the Textfield is on the main screen and false if it is on the jog screen
    Public Sub Textfieldclick_event(labelnumber As Integer, Ismainscreen As Boolean)
        If Ismainscreen Then

        End If
    End Sub

    ' Called when the user enters text into the Textfield and it gets validated
    ' The labelnumber parameter is the ID of the accessed Textfield
    ' The bool Ismainscreen parameter is true is the Textfield is on the main screen and false if it is on the jog screen.
    ' The text parameter is the text entered and validated by the user
    Public Sub Textfieldtexttyped_event(labelnumber As Integer, Ismainscreen As Boolean, text As String)
        If Ismainscreen Then
            If labelnumber = 1000 Then
                ' Your code here...
            End If
        End If
    End Sub

    ' Called when the user presses the Cycle start button and before the Cycle starts
    ' This event may be used to show messages or do actions on Cycle start 
    ' For example to cancel the Cycle if a condition met before the Cycle starts with calling the Button code 130 Cycle stop
    Public Sub Cyclethreadstart_event()
        ' MsgBox("Cycle is starting...")
    End Sub

    Public Sub Cyclethreadstop_event()
        ' MsgBox("Cycle is stopping...")
    End Sub

    Public Sub Toolpathclick_event(X As Double, Y As Double, Istopview As Boolean)
        ' Toolpath clicked
    End Sub

    ' Public Function Get_event(pluginfilename As String, exec As Executer) As Boolean ---->>>> ?




End Class






