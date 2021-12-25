<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PluginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PluginForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.About = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbM6Prompt = New System.Windows.Forms.CheckBox()
        Me.cbToolChange = New System.Windows.Forms.CheckBox()
        Me.ProbeTriggeredCheck = New System.Windows.Forms.CheckBox()
        Me.lblTouchOffs = New System.Windows.Forms.Label()
        Me.tbXTouchInputID = New System.Windows.Forms.TextBox()
        Me.btnTouchXID = New System.Windows.Forms.Button()
        Me.cbToolNumUpdate = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSetOffsets = New System.Windows.Forms.Button()
        Me.btnLoadTable = New System.Windows.Forms.Button()
        Me.btnSaveTable = New System.Windows.Forms.Button()
        Me.tbZTouchInput = New System.Windows.Forms.TextBox()
        Me.tbXTouchInput = New System.Windows.Forms.TextBox()
        Me.btnTouchZ = New System.Windows.Forms.Button()
        Me.btnTouchX = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudActiveTool = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cbUseWear = New System.Windows.Forms.CheckBox()
        Me.cbViewerSet = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGetSteps = New System.Windows.Forms.Button()
        Me.tbStepUnitRadius = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbDiamMode = New System.Windows.Forms.RadioButton()
        Me.rbRadiusMode = New System.Windows.Forms.RadioButton()
        Me.cbShowMessages = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblAppVersion = New System.Windows.Forms.Label()
        Me.linkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.btnEStop = New System.Windows.Forms.Button()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.btnJSP = New System.Windows.Forms.Button()
        Me.nudJogStep = New System.Windows.Forms.NumericUpDown()
        Me.nudJogVel = New System.Windows.Forms.NumericUpDown()
        Me.btnjogZdown = New System.Windows.Forms.Button()
        Me.btnjogZup = New System.Windows.Forms.Button()
        Me.cbJogEnab = New System.Windows.Forms.CheckBox()
        Me.btnJogDn = New System.Windows.Forms.Button()
        Me.lblJogVel = New System.Windows.Forms.Label()
        Me.lblStepSize = New System.Windows.Forms.Label()
        Me.btnJogRight = New System.Windows.Forms.Button()
        Me.btnJogLeft = New System.Windows.Forms.Button()
        Me.btnJogUp = New System.Windows.Forms.Button()
        Me.rbJogCont = New System.Windows.Forms.RadioButton()
        Me.rbJogStep = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRadDiam = New System.Windows.Forms.Label()
        Me.btnZZero = New System.Windows.Forms.Button()
        Me.btnXZero = New System.Windows.Forms.Button()
        Me.LabelZAxis = New System.Windows.Forms.Label()
        Me.LabelXAxis = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowPluginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbOnTop = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblG92Z = New System.Windows.Forms.Label()
        Me.lblG92X = New System.Windows.Forms.Label()
        Me.btnFeedHold = New System.Windows.Forms.Button()
        Me.btnCycleStart = New System.Windows.Forms.Button()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.btnG59 = New System.Windows.Forms.Button()
        Me.btnG54 = New System.Windows.Forms.Button()
        Me.btng55 = New System.Windows.Forms.Button()
        Me.btnG57 = New System.Windows.Forms.Button()
        Me.btnG58 = New System.Windows.Forms.Button()
        Me.btnG56 = New System.Windows.Forms.Button()
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.About.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.nudActiveTool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox25.SuspendLayout()
        CType(Me.nudJogStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudJogVel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox29.SuspendLayout()
        Me.SuspendLayout()
        '
        'About
        '
        Me.About.Controls.Add(Me.TabPage1)
        Me.About.Controls.Add(Me.TabPage2)
        Me.About.Controls.Add(Me.TabPage3)
        Me.About.Dock = System.Windows.Forms.DockStyle.Fill
        Me.About.Location = New System.Drawing.Point(0, 0)
        Me.About.Name = "About"
        Me.About.SelectedIndex = 0
        Me.About.Size = New System.Drawing.Size(587, 480)
        Me.About.TabIndex = 80
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.cbM6Prompt)
        Me.TabPage1.Controls.Add(Me.cbToolChange)
        Me.TabPage1.Controls.Add(Me.ProbeTriggeredCheck)
        Me.TabPage1.Controls.Add(Me.lblTouchOffs)
        Me.TabPage1.Controls.Add(Me.tbXTouchInputID)
        Me.TabPage1.Controls.Add(Me.btnTouchXID)
        Me.TabPage1.Controls.Add(Me.cbToolNumUpdate)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnSetOffsets)
        Me.TabPage1.Controls.Add(Me.btnLoadTable)
        Me.TabPage1.Controls.Add(Me.btnSaveTable)
        Me.TabPage1.Controls.Add(Me.tbZTouchInput)
        Me.TabPage1.Controls.Add(Me.tbXTouchInput)
        Me.TabPage1.Controls.Add(Me.btnTouchZ)
        Me.TabPage1.Controls.Add(Me.btnTouchX)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.nudActiveTool)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(579, 454)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Lathe Tool Table"
        '
        'cbM6Prompt
        '
        Me.cbM6Prompt.AutoSize = True
        Me.cbM6Prompt.Location = New System.Drawing.Point(386, 67)
        Me.cbM6Prompt.Name = "cbM6Prompt"
        Me.cbM6Prompt.Size = New System.Drawing.Size(149, 17)
        Me.cbM6Prompt.TabIndex = 191
        Me.cbM6Prompt.Text = "Prompt to accept M6 run?"
        Me.cbM6Prompt.UseVisualStyleBackColor = True
        '
        'cbToolChange
        '
        Me.cbToolChange.AutoSize = True
        Me.cbToolChange.Location = New System.Drawing.Point(370, 38)
        Me.cbToolChange.Name = "cbToolChange"
        Me.cbToolChange.Size = New System.Drawing.Size(160, 30)
        Me.cbToolChange.TabIndex = 190
        Me.cbToolChange.Text = "Run Tool Change M6 macro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on Set offset?"
        Me.cbToolChange.UseVisualStyleBackColor = True
        '
        'ProbeTriggeredCheck
        '
        Me.ProbeTriggeredCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.ProbeTriggeredCheck.AutoCheck = False
        Me.ProbeTriggeredCheck.BackgroundImage = CType(resources.GetObject("ProbeTriggeredCheck.BackgroundImage"), System.Drawing.Image)
        Me.ProbeTriggeredCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProbeTriggeredCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProbeTriggeredCheck.Location = New System.Drawing.Point(386, 105)
        Me.ProbeTriggeredCheck.Name = "ProbeTriggeredCheck"
        Me.ProbeTriggeredCheck.Size = New System.Drawing.Size(160, 42)
        Me.ProbeTriggeredCheck.TabIndex = 189
        Me.ProbeTriggeredCheck.UseVisualStyleBackColor = True
        '
        'lblTouchOffs
        '
        Me.lblTouchOffs.AutoSize = True
        Me.lblTouchOffs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTouchOffs.Location = New System.Drawing.Point(14, 85)
        Me.lblTouchOffs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTouchOffs.Name = "lblTouchOffs"
        Me.lblTouchOffs.Size = New System.Drawing.Size(205, 16)
        Me.lblTouchOffs.TabIndex = 188
        Me.lblTouchOffs.Text = "Touch-off values. Enter as a "
        '
        'tbXTouchInputID
        '
        Me.tbXTouchInputID.Location = New System.Drawing.Point(13, 104)
        Me.tbXTouchInputID.Name = "tbXTouchInputID"
        Me.tbXTouchInputID.Size = New System.Drawing.Size(75, 20)
        Me.tbXTouchInputID.TabIndex = 187
        '
        'btnTouchXID
        '
        Me.btnTouchXID.Location = New System.Drawing.Point(13, 130)
        Me.btnTouchXID.Name = "btnTouchXID"
        Me.btnTouchXID.Size = New System.Drawing.Size(75, 23)
        Me.btnTouchXID.TabIndex = 186
        Me.btnTouchXID.Text = "TouchX ID"
        Me.btnTouchXID.UseVisualStyleBackColor = True
        '
        'cbToolNumUpdate
        '
        Me.cbToolNumUpdate.AutoSize = True
        Me.cbToolNumUpdate.Location = New System.Drawing.Point(370, 7)
        Me.cbToolNumUpdate.Name = "cbToolNumUpdate"
        Me.cbToolNumUpdate.Size = New System.Drawing.Size(132, 30)
        Me.cbToolNumUpdate.TabIndex = 185
        Me.cbToolNumUpdate.Text = "Auto Apply Offsets " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "On GCode Execution?"
        Me.cbToolNumUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 405)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "Tool # Found:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 427)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "Active Code Line:"
        '
        'btnSetOffsets
        '
        Me.btnSetOffsets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetOffsets.Location = New System.Drawing.Point(222, 6)
        Me.btnSetOffsets.Name = "btnSetOffsets"
        Me.btnSetOffsets.Size = New System.Drawing.Size(142, 49)
        Me.btnSetOffsets.TabIndex = 182
        Me.btnSetOffsets.Text = "Set offset for selected tool"
        Me.btnSetOffsets.UseVisualStyleBackColor = True
        '
        'btnLoadTable
        '
        Me.btnLoadTable.Location = New System.Drawing.Point(123, 370)
        Me.btnLoadTable.Name = "btnLoadTable"
        Me.btnLoadTable.Size = New System.Drawing.Size(106, 23)
        Me.btnLoadTable.TabIndex = 181
        Me.btnLoadTable.Text = "Load Tool Table"
        Me.btnLoadTable.UseVisualStyleBackColor = True
        '
        'btnSaveTable
        '
        Me.btnSaveTable.Location = New System.Drawing.Point(11, 370)
        Me.btnSaveTable.Name = "btnSaveTable"
        Me.btnSaveTable.Size = New System.Drawing.Size(106, 23)
        Me.btnSaveTable.TabIndex = 180
        Me.btnSaveTable.Text = "Save Tool Table"
        Me.btnSaveTable.UseVisualStyleBackColor = True
        '
        'tbZTouchInput
        '
        Me.tbZTouchInput.Location = New System.Drawing.Point(175, 104)
        Me.tbZTouchInput.Name = "tbZTouchInput"
        Me.tbZTouchInput.Size = New System.Drawing.Size(75, 20)
        Me.tbZTouchInput.TabIndex = 179
        '
        'tbXTouchInput
        '
        Me.tbXTouchInput.Location = New System.Drawing.Point(94, 104)
        Me.tbXTouchInput.Name = "tbXTouchInput"
        Me.tbXTouchInput.Size = New System.Drawing.Size(75, 20)
        Me.tbXTouchInput.TabIndex = 178
        '
        'btnTouchZ
        '
        Me.btnTouchZ.Location = New System.Drawing.Point(175, 130)
        Me.btnTouchZ.Name = "btnTouchZ"
        Me.btnTouchZ.Size = New System.Drawing.Size(75, 23)
        Me.btnTouchZ.TabIndex = 177
        Me.btnTouchZ.Text = "TouchZ"
        Me.btnTouchZ.UseVisualStyleBackColor = True
        '
        'btnTouchX
        '
        Me.btnTouchX.Location = New System.Drawing.Point(94, 130)
        Me.btnTouchX.Name = "btnTouchX"
        Me.btnTouchX.Size = New System.Drawing.Size(75, 23)
        Me.btnTouchX.TabIndex = 176
        Me.btnTouchX.Text = "TouchX OD"
        Me.btnTouchX.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Active Tool"
        '
        'nudActiveTool
        '
        Me.nudActiveTool.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudActiveTool.Location = New System.Drawing.Point(136, 8)
        Me.nudActiveTool.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudActiveTool.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudActiveTool.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudActiveTool.Name = "nudActiveTool"
        Me.nudActiveTool.Size = New System.Drawing.Size(80, 47)
        Me.nudActiveTool.TabIndex = 172
        Me.nudActiveTool.TabStop = False
        Me.nudActiveTool.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(551, 205)
        Me.DataGridView1.TabIndex = 170
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(115, 407)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "---"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(141, 429)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "---"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.cbUseWear)
        Me.TabPage2.Controls.Add(Me.cbViewerSet)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.cbShowMessages)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(564, 454)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Setup"
        '
        'cbUseWear
        '
        Me.cbUseWear.AutoSize = True
        Me.cbUseWear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUseWear.Location = New System.Drawing.Point(8, 346)
        Me.cbUseWear.Name = "cbUseWear"
        Me.cbUseWear.Size = New System.Drawing.Size(233, 24)
        Me.cbUseWear.TabIndex = 191
        Me.cbUseWear.Text = "Use Wear Values in Offsets?"
        Me.cbUseWear.UseVisualStyleBackColor = True
        '
        'cbViewerSet
        '
        Me.cbViewerSet.AutoSize = True
        Me.cbViewerSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbViewerSet.Location = New System.Drawing.Point(8, 316)
        Me.cbViewerSet.Name = "cbViewerSet"
        Me.cbViewerSet.Size = New System.Drawing.Size(269, 24)
        Me.cbViewerSet.TabIndex = 190
        Me.cbViewerSet.Text = "Force ToolPath view to X/Z plane?"
        Me.cbViewerSet.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGetSteps)
        Me.GroupBox1.Controls.Add(Me.tbStepUnitRadius)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbDiamMode)
        Me.GroupBox1.Controls.Add(Me.rbRadiusMode)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(339, 104)
        Me.GroupBox1.TabIndex = 189
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Radius / Diameter Mode for X"
        '
        'btnGetSteps
        '
        Me.btnGetSteps.Location = New System.Drawing.Point(226, 39)
        Me.btnGetSteps.Name = "btnGetSteps"
        Me.btnGetSteps.Size = New System.Drawing.Size(100, 51)
        Me.btnGetSteps.TabIndex = 5
        Me.btnGetSteps.Text = "Gex X Step/Unit from UCCNC"
        Me.btnGetSteps.UseVisualStyleBackColor = True
        '
        'tbStepUnitRadius
        '
        Me.tbStepUnitRadius.Location = New System.Drawing.Point(226, 13)
        Me.tbStepUnitRadius.Name = "tbStepUnitRadius"
        Me.tbStepUnitRadius.Size = New System.Drawing.Size(100, 20)
        Me.tbStepUnitRadius.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Radial Steps / Unit for X Axis"
        '
        'rbDiamMode
        '
        Me.rbDiamMode.AutoSize = True
        Me.rbDiamMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDiamMode.Location = New System.Drawing.Point(17, 66)
        Me.rbDiamMode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbDiamMode.Name = "rbDiamMode"
        Me.rbDiamMode.Size = New System.Drawing.Size(151, 24)
        Me.rbDiamMode.TabIndex = 1
        Me.rbDiamMode.TabStop = True
        Me.rbDiamMode.Text = "Diameter Mode X"
        Me.rbDiamMode.UseVisualStyleBackColor = True
        '
        'rbRadiusMode
        '
        Me.rbRadiusMode.AutoSize = True
        Me.rbRadiusMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRadiusMode.Location = New System.Drawing.Point(17, 37)
        Me.rbRadiusMode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbRadiusMode.Name = "rbRadiusMode"
        Me.rbRadiusMode.Size = New System.Drawing.Size(136, 24)
        Me.rbRadiusMode.TabIndex = 0
        Me.rbRadiusMode.TabStop = True
        Me.rbRadiusMode.Text = "Radius Mode X"
        Me.rbRadiusMode.UseVisualStyleBackColor = True
        '
        'cbShowMessages
        '
        Me.cbShowMessages.AutoSize = True
        Me.cbShowMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowMessages.Location = New System.Drawing.Point(8, 289)
        Me.cbShowMessages.Name = "cbShowMessages"
        Me.cbShowMessages.Size = New System.Drawing.Size(186, 24)
        Me.cbShowMessages.TabIndex = 187
        Me.cbShowMessages.Text = "Show Info Messages?"
        Me.cbShowMessages.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.lblAppVersion)
        Me.TabPage3.Controls.Add(Me.linkLabel2)
        Me.TabPage3.Controls.Add(Me.pictureBox1)
        Me.TabPage3.Controls.Add(Me.linkLabel1)
        Me.TabPage3.Controls.Add(Me.TextBox13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage3.Size = New System.Drawing.Size(564, 454)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        '
        'lblAppVersion
        '
        Me.lblAppVersion.AutoSize = True
        Me.lblAppVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAppVersion.Location = New System.Drawing.Point(16, 169)
        Me.lblAppVersion.Name = "lblAppVersion"
        Me.lblAppVersion.Size = New System.Drawing.Size(131, 16)
        Me.lblAppVersion.TabIndex = 44
        Me.lblAppVersion.Text = "Plugin Version: 1.000"
        Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'linkLabel2
        '
        Me.linkLabel2.AutoSize = True
        Me.linkLabel2.Location = New System.Drawing.Point(304, 130)
        Me.linkLabel2.Name = "linkLabel2"
        Me.linkLabel2.Size = New System.Drawing.Size(101, 13)
        Me.linkLabel2.TabIndex = 43
        Me.linkLabel2.TabStop = True
        Me.linkLabel2.Text = "www.craftycnc.com"
        '
        'pictureBox1
        '
        Me.pictureBox1.ErrorImage = CType(resources.GetObject("pictureBox1.ErrorImage"), System.Drawing.Image)
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.InitialImage = CType(resources.GetObject("pictureBox1.InitialImage"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(19, 16)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(265, 150)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 42
        Me.pictureBox1.TabStop = False
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Location = New System.Drawing.Point(304, 153)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(120, 13)
        Me.linkLabel1.TabIndex = 41
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Tag = "mailto:eabrust@craftycnc.com"
        Me.linkLabel1.Text = "eabrust@craftycnc.com"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(19, 188)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox13.Size = New System.Drawing.Size(405, 163)
        Me.TextBox13.TabIndex = 40
        Me.TextBox13.Text = resources.GetString("TextBox13.Text")
        '
        'btnEStop
        '
        Me.btnEStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEStop.BackgroundImage = CType(resources.GetObject("btnEStop.BackgroundImage"), System.Drawing.Image)
        Me.btnEStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEStop.Location = New System.Drawing.Point(750, 498)
        Me.btnEStop.Name = "btnEStop"
        Me.btnEStop.Size = New System.Drawing.Size(97, 90)
        Me.btnEStop.TabIndex = 168
        Me.btnEStop.TabStop = False
        Me.btnEStop.UseVisualStyleBackColor = True
        '
        'GroupBox25
        '
        Me.GroupBox25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox25.Controls.Add(Me.btnJSP)
        Me.GroupBox25.Controls.Add(Me.nudJogStep)
        Me.GroupBox25.Controls.Add(Me.nudJogVel)
        Me.GroupBox25.Controls.Add(Me.btnjogZdown)
        Me.GroupBox25.Controls.Add(Me.btnjogZup)
        Me.GroupBox25.Controls.Add(Me.cbJogEnab)
        Me.GroupBox25.Controls.Add(Me.btnJogDn)
        Me.GroupBox25.Controls.Add(Me.lblJogVel)
        Me.GroupBox25.Controls.Add(Me.lblStepSize)
        Me.GroupBox25.Controls.Add(Me.btnJogRight)
        Me.GroupBox25.Controls.Add(Me.btnJogLeft)
        Me.GroupBox25.Controls.Add(Me.btnJogUp)
        Me.GroupBox25.Controls.Add(Me.rbJogCont)
        Me.GroupBox25.Controls.Add(Me.rbJogStep)
        Me.GroupBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox25.Location = New System.Drawing.Point(17, 148)
        Me.GroupBox25.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox25.Size = New System.Drawing.Size(234, 230)
        Me.GroupBox25.TabIndex = 167
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Jogging"
        '
        'btnJSP
        '
        Me.btnJSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJSP.Location = New System.Drawing.Point(31, 195)
        Me.btnJSP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJSP.Name = "btnJSP"
        Me.btnJSP.Size = New System.Drawing.Size(180, 24)
        Me.btnJSP.TabIndex = 181
        Me.btnJSP.TabStop = False
        Me.btnJSP.Text = "Jog Safe Probe - OFF"
        Me.btnJSP.UseVisualStyleBackColor = True
        '
        'nudJogStep
        '
        Me.nudJogStep.DecimalPlaces = 3
        Me.nudJogStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudJogStep.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.nudJogStep.Location = New System.Drawing.Point(5, 66)
        Me.nudJogStep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudJogStep.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudJogStep.Name = "nudJogStep"
        Me.nudJogStep.Size = New System.Drawing.Size(92, 24)
        Me.nudJogStep.TabIndex = 171
        Me.nudJogStep.TabStop = False
        '
        'nudJogVel
        '
        Me.nudJogVel.DecimalPlaces = 1
        Me.nudJogVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudJogVel.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudJogVel.Location = New System.Drawing.Point(5, 66)
        Me.nudJogVel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudJogVel.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudJogVel.Name = "nudJogVel"
        Me.nudJogVel.Size = New System.Drawing.Size(92, 24)
        Me.nudJogVel.TabIndex = 170
        '
        'btnjogZdown
        '
        Me.btnjogZdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjogZdown.Location = New System.Drawing.Point(47, 119)
        Me.btnjogZdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnjogZdown.Name = "btnjogZdown"
        Me.btnjogZdown.Size = New System.Drawing.Size(50, 34)
        Me.btnjogZdown.TabIndex = 169
        Me.btnjogZdown.TabStop = False
        Me.btnjogZdown.Text = "-Z"
        Me.btnjogZdown.UseVisualStyleBackColor = True
        '
        'btnjogZup
        '
        Me.btnjogZup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjogZup.Location = New System.Drawing.Point(151, 119)
        Me.btnjogZup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnjogZup.Name = "btnjogZup"
        Me.btnjogZup.Size = New System.Drawing.Size(50, 34)
        Me.btnjogZup.TabIndex = 168
        Me.btnjogZup.TabStop = False
        Me.btnjogZup.Text = "+Z"
        Me.btnjogZup.UseVisualStyleBackColor = True
        '
        'cbJogEnab
        '
        Me.cbJogEnab.AutoSize = True
        Me.cbJogEnab.Location = New System.Drawing.Point(73, 0)
        Me.cbJogEnab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbJogEnab.Name = "cbJogEnab"
        Me.cbJogEnab.Size = New System.Drawing.Size(108, 21)
        Me.cbJogEnab.TabIndex = 167
        Me.cbJogEnab.TabStop = False
        Me.cbJogEnab.Text = "Enable Jog"
        Me.cbJogEnab.UseVisualStyleBackColor = True
        '
        'btnJogDn
        '
        Me.btnJogDn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogDn.Location = New System.Drawing.Point(181, 65)
        Me.btnJogDn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogDn.Name = "btnJogDn"
        Me.btnJogDn.Size = New System.Drawing.Size(45, 34)
        Me.btnJogDn.TabIndex = 160
        Me.btnJogDn.TabStop = False
        Me.btnJogDn.Text = "-Y"
        Me.btnJogDn.UseVisualStyleBackColor = True
        Me.btnJogDn.Visible = False
        '
        'lblJogVel
        '
        Me.lblJogVel.AutoSize = True
        Me.lblJogVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJogVel.Location = New System.Drawing.Point(6, 45)
        Me.lblJogVel.Name = "lblJogVel"
        Me.lblJogVel.Size = New System.Drawing.Size(126, 18)
        Me.lblJogVel.TabIndex = 166
        Me.lblJogVel.Text = "JogVel (units/min)"
        '
        'lblStepSize
        '
        Me.lblStepSize.AutoSize = True
        Me.lblStepSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStepSize.Location = New System.Drawing.Point(6, 46)
        Me.lblStepSize.Name = "lblStepSize"
        Me.lblStepSize.Size = New System.Drawing.Size(116, 18)
        Me.lblStepSize.TabIndex = 165
        Me.lblStepSize.Text = "Step Size (units)"
        '
        'btnJogRight
        '
        Me.btnJogRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogRight.Location = New System.Drawing.Point(100, 153)
        Me.btnJogRight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogRight.Name = "btnJogRight"
        Me.btnJogRight.Size = New System.Drawing.Size(45, 34)
        Me.btnJogRight.TabIndex = 162
        Me.btnJogRight.TabStop = False
        Me.btnJogRight.Text = "+X"
        Me.btnJogRight.UseVisualStyleBackColor = True
        '
        'btnJogLeft
        '
        Me.btnJogLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogLeft.Location = New System.Drawing.Point(100, 84)
        Me.btnJogLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogLeft.Name = "btnJogLeft"
        Me.btnJogLeft.Size = New System.Drawing.Size(45, 34)
        Me.btnJogLeft.TabIndex = 161
        Me.btnJogLeft.TabStop = False
        Me.btnJogLeft.Text = "-X"
        Me.btnJogLeft.UseVisualStyleBackColor = True
        '
        'btnJogUp
        '
        Me.btnJogUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogUp.Location = New System.Drawing.Point(181, 30)
        Me.btnJogUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogUp.Name = "btnJogUp"
        Me.btnJogUp.Size = New System.Drawing.Size(45, 34)
        Me.btnJogUp.TabIndex = 159
        Me.btnJogUp.TabStop = False
        Me.btnJogUp.Text = "+Y"
        Me.btnJogUp.UseVisualStyleBackColor = True
        Me.btnJogUp.Visible = False
        '
        'rbJogCont
        '
        Me.rbJogCont.AutoSize = True
        Me.rbJogCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbJogCont.Location = New System.Drawing.Point(73, 23)
        Me.rbJogCont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbJogCont.Name = "rbJogCont"
        Me.rbJogCont.Size = New System.Drawing.Size(102, 22)
        Me.rbJogCont.TabIndex = 158
        Me.rbJogCont.Text = "Continuous"
        Me.rbJogCont.UseVisualStyleBackColor = True
        '
        'rbJogStep
        '
        Me.rbJogStep.AutoSize = True
        Me.rbJogStep.Checked = True
        Me.rbJogStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbJogStep.Location = New System.Drawing.Point(9, 23)
        Me.rbJogStep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbJogStep.Name = "rbJogStep"
        Me.rbJogStep.Size = New System.Drawing.Size(56, 22)
        Me.rbJogStep.TabIndex = 157
        Me.rbJogStep.TabStop = True
        Me.rbJogStep.Text = "Step"
        Me.rbJogStep.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Controls.Add(Me.lblRadDiam)
        Me.GroupBox2.Controls.Add(Me.btnZZero)
        Me.GroupBox2.Controls.Add(Me.btnXZero)
        Me.GroupBox2.Controls.Add(Me.LabelZAxis)
        Me.GroupBox2.Controls.Add(Me.LabelXAxis)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 120)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AXIS DROs"
        '
        'lblRadDiam
        '
        Me.lblRadDiam.AutoSize = True
        Me.lblRadDiam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadDiam.Location = New System.Drawing.Point(77, 48)
        Me.lblRadDiam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRadDiam.Name = "lblRadDiam"
        Me.lblRadDiam.Size = New System.Drawing.Size(54, 13)
        Me.lblRadDiam.TabIndex = 175
        Me.lblRadDiam.Text = "RADIUS"
        '
        'btnZZero
        '
        Me.btnZZero.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnZZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnZZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZZero.Location = New System.Drawing.Point(6, 70)
        Me.btnZZero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnZZero.Name = "btnZZero"
        Me.btnZZero.Size = New System.Drawing.Size(66, 31)
        Me.btnZZero.TabIndex = 174
        Me.btnZZero.TabStop = False
        Me.btnZZero.Text = "Z_zero"
        Me.btnZZero.UseVisualStyleBackColor = False
        '
        'btnXZero
        '
        Me.btnXZero.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnXZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXZero.Location = New System.Drawing.Point(6, 16)
        Me.btnXZero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnXZero.Name = "btnXZero"
        Me.btnXZero.Size = New System.Drawing.Size(66, 34)
        Me.btnXZero.TabIndex = 172
        Me.btnXZero.TabStop = False
        Me.btnXZero.Text = "X_zero"
        Me.btnXZero.UseVisualStyleBackColor = False
        '
        'LabelZAxis
        '
        Me.LabelZAxis.AutoSize = True
        Me.LabelZAxis.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZAxis.Location = New System.Drawing.Point(70, 70)
        Me.LabelZAxis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelZAxis.Name = "LabelZAxis"
        Me.LabelZAxis.Size = New System.Drawing.Size(117, 31)
        Me.LabelZAxis.TabIndex = 69
        Me.LabelZAxis.Text = "Label18"
        '
        'LabelXAxis
        '
        Me.LabelXAxis.AutoSize = True
        Me.LabelXAxis.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelXAxis.Location = New System.Drawing.Point(70, 17)
        Me.LabelXAxis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelXAxis.Name = "LabelXAxis"
        Me.LabelXAxis.Size = New System.Drawing.Size(117, 31)
        Me.LabelXAxis.TabIndex = 67
        Me.LabelXAxis.Text = "Label16"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(10, 78)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(105, 23)
        Me.btnSaveSettings.TabIndex = 91
        Me.btnSaveSettings.Text = "save settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ShowPluginToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 48)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShowPluginToolStripMenuItem
        '
        Me.ShowPluginToolStripMenuItem.Name = "ShowPluginToolStripMenuItem"
        Me.ShowPluginToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ShowPluginToolStripMenuItem.Text = "Show Plugin"
        '
        'cbOnTop
        '
        Me.cbOnTop.AutoSize = True
        Me.cbOnTop.Location = New System.Drawing.Point(10, 28)
        Me.cbOnTop.Name = "cbOnTop"
        Me.cbOnTop.Size = New System.Drawing.Size(96, 17)
        Me.cbOnTop.TabIndex = 189
        Me.cbOnTop.Text = "Always on Top"
        Me.cbOnTop.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.About)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox25)
        Me.SplitContainer1.Size = New System.Drawing.Size(859, 480)
        Me.SplitContainer1.SplitterDistance = 587
        Me.SplitContainer1.TabIndex = 190
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnFeedHold)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnCycleStart)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnSaveSettings)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cbOnTop)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox29)
        Me.SplitContainer2.Size = New System.Drawing.Size(859, 600)
        Me.SplitContainer2.SplitterDistance = 480
        Me.SplitContainer2.TabIndex = 191
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblG92Z)
        Me.GroupBox3.Controls.Add(Me.lblG92X)
        Me.GroupBox3.Location = New System.Drawing.Point(318, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(117, 82)
        Me.GroupBox3.TabIndex = 188
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Active G92 Offsets"
        '
        'lblG92Z
        '
        Me.lblG92Z.AutoSize = True
        Me.lblG92Z.Location = New System.Drawing.Point(7, 51)
        Me.lblG92Z.Name = "lblG92Z"
        Me.lblG92Z.Size = New System.Drawing.Size(39, 13)
        Me.lblG92Z.TabIndex = 1
        Me.lblG92Z.Text = "Label6"
        '
        'lblG92X
        '
        Me.lblG92X.AutoSize = True
        Me.lblG92X.Location = New System.Drawing.Point(7, 22)
        Me.lblG92X.Name = "lblG92X"
        Me.lblG92X.Size = New System.Drawing.Size(39, 13)
        Me.lblG92X.TabIndex = 0
        Me.lblG92X.Text = "Label5"
        '
        'btnFeedHold
        '
        Me.btnFeedHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFeedHold.Location = New System.Drawing.Point(606, 51)
        Me.btnFeedHold.Name = "btnFeedHold"
        Me.btnFeedHold.Size = New System.Drawing.Size(125, 31)
        Me.btnFeedHold.TabIndex = 189
        Me.btnFeedHold.Text = "Feed Hold"
        Me.btnFeedHold.UseVisualStyleBackColor = True
        '
        'btnCycleStart
        '
        Me.btnCycleStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCycleStart.Location = New System.Drawing.Point(606, 12)
        Me.btnCycleStart.Name = "btnCycleStart"
        Me.btnCycleStart.Size = New System.Drawing.Size(125, 31)
        Me.btnCycleStart.TabIndex = 188
        Me.btnCycleStart.Text = "Cycle Start"
        Me.btnCycleStart.UseVisualStyleBackColor = True
        '
        'GroupBox29
        '
        Me.GroupBox29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox29.Controls.Add(Me.btnG59)
        Me.GroupBox29.Controls.Add(Me.btnG54)
        Me.GroupBox29.Controls.Add(Me.btng55)
        Me.GroupBox29.Controls.Add(Me.btnG57)
        Me.GroupBox29.Controls.Add(Me.btnG58)
        Me.GroupBox29.Controls.Add(Me.btnG56)
        Me.GroupBox29.Location = New System.Drawing.Point(137, 17)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(175, 82)
        Me.GroupBox29.TabIndex = 169
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "WorkCoords"
        '
        'btnG59
        '
        Me.btnG59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnG59.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG59.Location = New System.Drawing.Point(108, 47)
        Me.btnG59.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnG59.Name = "btnG59"
        Me.btnG59.Size = New System.Drawing.Size(42, 24)
        Me.btnG59.TabIndex = 180
        Me.btnG59.TabStop = False
        Me.btnG59.Text = "G59"
        Me.btnG59.UseVisualStyleBackColor = True
        '
        'btnG54
        '
        Me.btnG54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnG54.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG54.Location = New System.Drawing.Point(12, 19)
        Me.btnG54.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnG54.Name = "btnG54"
        Me.btnG54.Size = New System.Drawing.Size(42, 24)
        Me.btnG54.TabIndex = 175
        Me.btnG54.TabStop = False
        Me.btnG54.Text = "G54"
        Me.btnG54.UseVisualStyleBackColor = True
        '
        'btng55
        '
        Me.btng55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btng55.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btng55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btng55.Location = New System.Drawing.Point(60, 19)
        Me.btng55.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btng55.Name = "btng55"
        Me.btng55.Size = New System.Drawing.Size(42, 24)
        Me.btng55.TabIndex = 176
        Me.btng55.TabStop = False
        Me.btng55.Text = "G55"
        Me.btng55.UseVisualStyleBackColor = True
        '
        'btnG57
        '
        Me.btnG57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnG57.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG57.Location = New System.Drawing.Point(12, 47)
        Me.btnG57.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnG57.Name = "btnG57"
        Me.btnG57.Size = New System.Drawing.Size(42, 24)
        Me.btnG57.TabIndex = 178
        Me.btnG57.TabStop = False
        Me.btnG57.Text = "G57"
        Me.btnG57.UseVisualStyleBackColor = True
        '
        'btnG58
        '
        Me.btnG58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnG58.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG58.Location = New System.Drawing.Point(60, 47)
        Me.btnG58.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnG58.Name = "btnG58"
        Me.btnG58.Size = New System.Drawing.Size(42, 24)
        Me.btnG58.TabIndex = 179
        Me.btnG58.TabStop = False
        Me.btnG58.Text = "G58"
        Me.btnG58.UseVisualStyleBackColor = True
        '
        'btnG56
        '
        Me.btnG56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnG56.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG56.Location = New System.Drawing.Point(108, 19)
        Me.btnG56.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnG56.Name = "btnG56"
        Me.btnG56.Size = New System.Drawing.Size(42, 24)
        Me.btnG56.TabIndex = 177
        Me.btnG56.TabStop = False
        Me.btnG56.Text = "G56"
        Me.btnG56.UseVisualStyleBackColor = True
        '
        'updateTimer
        '
        '
        'PluginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(859, 600)
        Me.Controls.Add(Me.btnEStop)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PluginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TurnTable - UCCNC Lathe Addon"
        Me.About.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.nudActiveTool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        CType(Me.nudJogStep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudJogVel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox29.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents About As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents lblAppVersion As System.Windows.Forms.Label
    Private WithEvents linkLabel2 As System.Windows.Forms.LinkLabel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowPluginToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEStop As Windows.Forms.Button
    Friend WithEvents GroupBox25 As Windows.Forms.GroupBox
    Friend WithEvents nudJogStep As Windows.Forms.NumericUpDown
    Friend WithEvents nudJogVel As Windows.Forms.NumericUpDown
    Friend WithEvents btnjogZdown As Windows.Forms.Button
    Friend WithEvents btnjogZup As Windows.Forms.Button
    Friend WithEvents cbJogEnab As Windows.Forms.CheckBox
    Friend WithEvents btnJogDn As Windows.Forms.Button
    Friend WithEvents lblJogVel As Windows.Forms.Label
    Friend WithEvents lblStepSize As Windows.Forms.Label
    Friend WithEvents btnJogRight As Windows.Forms.Button
    Friend WithEvents btnJogLeft As Windows.Forms.Button
    Friend WithEvents btnJogUp As Windows.Forms.Button
    Friend WithEvents rbJogCont As Windows.Forms.RadioButton
    Friend WithEvents rbJogStep As Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents btnZZero As Windows.Forms.Button
    Friend WithEvents btnXZero As Windows.Forms.Button
    Friend WithEvents LabelZAxis As Windows.Forms.Label
    Friend WithEvents LabelXAxis As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnGetSteps As Windows.Forms.Button
    Friend WithEvents tbStepUnitRadius As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents rbDiamMode As Windows.Forms.RadioButton
    Friend WithEvents rbRadiusMode As Windows.Forms.RadioButton
    Friend WithEvents cbShowMessages As Windows.Forms.CheckBox
    Friend WithEvents cbOnTop As Windows.Forms.CheckBox
    Friend WithEvents cbViewerSet As Windows.Forms.CheckBox
    Friend WithEvents lblRadDiam As Windows.Forms.Label
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents tbXTouchInputID As Windows.Forms.TextBox
    Friend WithEvents btnTouchXID As Windows.Forms.Button
    Friend WithEvents cbToolNumUpdate As Windows.Forms.CheckBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btnSetOffsets As Windows.Forms.Button
    Friend WithEvents btnLoadTable As Windows.Forms.Button
    Friend WithEvents btnSaveTable As Windows.Forms.Button
    Friend WithEvents tbZTouchInput As Windows.Forms.TextBox
    Friend WithEvents tbXTouchInput As Windows.Forms.TextBox
    Friend WithEvents btnTouchZ As Windows.Forms.Button
    Friend WithEvents btnTouchX As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents nudActiveTool As Windows.Forms.NumericUpDown
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As Windows.Forms.SplitContainer
    Friend WithEvents btnFeedHold As Windows.Forms.Button
    Friend WithEvents btnCycleStart As Windows.Forms.Button
    Friend WithEvents GroupBox29 As Windows.Forms.GroupBox
    Friend WithEvents btnG59 As Windows.Forms.Button
    Friend WithEvents btnG54 As Windows.Forms.Button
    Friend WithEvents btng55 As Windows.Forms.Button
    Friend WithEvents btnG57 As Windows.Forms.Button
    Friend WithEvents btnG58 As Windows.Forms.Button
    Friend WithEvents btnG56 As Windows.Forms.Button
    Friend WithEvents btnJSP As Windows.Forms.Button
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents lblG92Z As Windows.Forms.Label
    Friend WithEvents lblG92X As Windows.Forms.Label
    Friend WithEvents cbUseWear As Windows.Forms.CheckBox
    Friend WithEvents lblTouchOffs As Windows.Forms.Label
    Private WithEvents TextBox13 As Windows.Forms.TextBox
    Friend WithEvents ProbeTriggeredCheck As Windows.Forms.CheckBox
    Friend WithEvents updateTimer As Windows.Forms.Timer
    Friend WithEvents cbM6Prompt As Windows.Forms.CheckBox
    Friend WithEvents cbToolChange As Windows.Forms.CheckBox
End Class
