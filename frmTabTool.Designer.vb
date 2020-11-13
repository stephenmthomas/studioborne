<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTabTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTabTool))
        Me.cbKey = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbInt = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtVals = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTuning = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTab = New System.Windows.Forms.TextBox()
        Me.cmdDraw = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdChord1 = New System.Windows.Forms.Button()
        Me.cmdChord2 = New System.Windows.Forms.Button()
        Me.cmdChord3 = New System.Windows.Forms.Button()
        Me.cmdChord4 = New System.Windows.Forms.Button()
        Me.cmdChord7 = New System.Windows.Forms.Button()
        Me.cmdChord6 = New System.Windows.Forms.Button()
        Me.cmdChord5 = New System.Windows.Forms.Button()
        Me.txtChord = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chk7 = New System.Windows.Forms.CheckBox()
        Me.chk9 = New System.Windows.Forms.CheckBox()
        Me.chk11 = New System.Windows.Forms.CheckBox()
        Me.cmdAddChord = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdFretboard = New System.Windows.Forms.Button()
        Me.cmdKeyboard = New System.Windows.Forms.Button()
        Me.cmdMaximize = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFretMax = New System.Windows.Forms.TextBox()
        Me.txtFretMin = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkTones = New System.Windows.Forms.CheckBox()
        Me.chkTransparency = New System.Windows.Forms.CheckBox()
        Me.chkOnTop = New System.Windows.Forms.CheckBox()
        Me.chkTabRoot = New System.Windows.Forms.CheckBox()
        Me.chkNoteIcon = New System.Windows.Forms.CheckBox()
        Me.chkNoteText = New System.Windows.Forms.CheckBox()
        Me.chkAutoChord = New System.Windows.Forms.CheckBox()
        Me.chkDim = New System.Windows.Forms.CheckBox()
        Me.chkSus2 = New System.Windows.Forms.CheckBox()
        Me.chkSus4 = New System.Windows.Forms.CheckBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkDim7 = New System.Windows.Forms.CheckBox()
        Me.chkAug = New System.Windows.Forms.CheckBox()
        Me.chkAug7 = New System.Windows.Forms.CheckBox()
        Me.chkMin = New System.Windows.Forms.CheckBox()
        Me.cmdBuilder = New System.Windows.Forms.Button()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.cmdTriadView = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbProgressions = New System.Windows.Forms.ComboBox()
        Me.cbProgList = New System.Windows.Forms.ComboBox()
        Me.cmdHideTab = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbKey
        '
        Me.cbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKey.FormattingEnabled = True
        Me.cbKey.Items.AddRange(New Object() {"A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"})
        Me.cbKey.Location = New System.Drawing.Point(13, 25)
        Me.cbKey.Name = "cbKey"
        Me.cbKey.Size = New System.Drawing.Size(141, 22)
        Me.cbKey.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KEY:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MODE/SCALE:"
        '
        'cbMode
        '
        Me.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMode.FormattingEnabled = True
        Me.cbMode.Items.AddRange(New Object() {"Major (Ionian)", "Dorian", "Phrygian", "Phrygian Dominant", "Lydian", "Mixolydian", "Minor (Aeolian)", "Locrian", "Melodic Minor", "Harmonic Minor", "Super Locrian", "Major Pentatonic*", "Minor Pentatonic*", "Blues Scale*", "Chromatic*"})
        Me.cbMode.Location = New System.Drawing.Point(160, 25)
        Me.cbMode.Name = "cbMode"
        Me.cbMode.Size = New System.Drawing.Size(141, 22)
        Me.cbMode.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "INTERVALS:"
        '
        'cbInt
        '
        Me.cbInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInt.FormattingEnabled = True
        Me.cbInt.Items.AddRange(New Object() {"2,2,1,2,2,2,1", "2,1,2,2,2,1,2", "1,2,2,2,1,2,2", "1,3,1,2,1,2,2", "2,2,2,1,2,2,1", "2,2,1,2,2,1,2", "2,1,2,2,1,2,2", "1,2,2,1,2,2,2", "2,1,2,2,2,2,1", "2,1,2,2,1,3,1", "1,2,1,2,2,2,2", "2,2,3,2,3", "3,2,2,3,2", "3,2,1,1,3,2", "1,1,1,1,1,1,1,1,1,1,1,1"})
        Me.cbInt.Location = New System.Drawing.Point(307, 25)
        Me.cbInt.Name = "cbInt"
        Me.cbInt.Size = New System.Drawing.Size(141, 22)
        Me.cbInt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NOTES:"
        '
        'txtNotes
        '
        Me.txtNotes.Enabled = False
        Me.txtNotes.Location = New System.Drawing.Point(307, 53)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(141, 20)
        Me.txtNotes.TabIndex = 7
        '
        'txtVals
        '
        Me.txtVals.Enabled = False
        Me.txtVals.Location = New System.Drawing.Point(678, 25)
        Me.txtVals.Name = "txtVals"
        Me.txtVals.Size = New System.Drawing.Size(146, 20)
        Me.txtVals.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(675, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RELATIVE SEMITONES:"
        '
        'txtTuning
        '
        Me.txtTuning.Location = New System.Drawing.Point(68, 150)
        Me.txtTuning.Name = "txtTuning"
        Me.txtTuning.Size = New System.Drawing.Size(90, 20)
        Me.txtTuning.TabIndex = 11
        Me.txtTuning.Text = "E,A,D,G,B,E"
        Me.ToolTip.SetToolTip(Me.txtTuning, "Sets the tuning for the fretboard.  Must be CSV format or else the program will c" &
        "rash.")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "TUNING:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "TABLATURE:"
        '
        'txtTab
        '
        Me.txtTab.Location = New System.Drawing.Point(12, 247)
        Me.txtTab.Multiline = True
        Me.txtTab.Name = "txtTab"
        Me.txtTab.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTab.Size = New System.Drawing.Size(873, 565)
        Me.txtTab.TabIndex = 13
        Me.txtTab.WordWrap = False
        '
        'cmdDraw
        '
        Me.cmdDraw.Location = New System.Drawing.Point(13, 186)
        Me.cmdDraw.Name = "cmdDraw"
        Me.cmdDraw.Size = New System.Drawing.Size(137, 20)
        Me.cmdDraw.TabIndex = 14
        Me.cmdDraw.Text = "Generate Tab"
        Me.cmdDraw.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 14)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "QUICK CHORDS:"
        '
        'cmdChord1
        '
        Me.cmdChord1.Location = New System.Drawing.Point(13, 88)
        Me.cmdChord1.Name = "cmdChord1"
        Me.cmdChord1.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord1.TabIndex = 16
        Me.cmdChord1.Text = "I"
        Me.cmdChord1.UseVisualStyleBackColor = True
        '
        'cmdChord2
        '
        Me.cmdChord2.Location = New System.Drawing.Point(59, 88)
        Me.cmdChord2.Name = "cmdChord2"
        Me.cmdChord2.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord2.TabIndex = 17
        Me.cmdChord2.Text = "II"
        Me.cmdChord2.UseVisualStyleBackColor = True
        '
        'cmdChord3
        '
        Me.cmdChord3.Location = New System.Drawing.Point(105, 88)
        Me.cmdChord3.Name = "cmdChord3"
        Me.cmdChord3.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord3.TabIndex = 18
        Me.cmdChord3.Text = "III"
        Me.cmdChord3.UseVisualStyleBackColor = True
        '
        'cmdChord4
        '
        Me.cmdChord4.Location = New System.Drawing.Point(151, 88)
        Me.cmdChord4.Name = "cmdChord4"
        Me.cmdChord4.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord4.TabIndex = 19
        Me.cmdChord4.Text = "IV"
        Me.cmdChord4.UseVisualStyleBackColor = True
        '
        'cmdChord7
        '
        Me.cmdChord7.Location = New System.Drawing.Point(289, 88)
        Me.cmdChord7.Name = "cmdChord7"
        Me.cmdChord7.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord7.TabIndex = 22
        Me.cmdChord7.Text = "VII"
        Me.cmdChord7.UseVisualStyleBackColor = True
        '
        'cmdChord6
        '
        Me.cmdChord6.Location = New System.Drawing.Point(243, 88)
        Me.cmdChord6.Name = "cmdChord6"
        Me.cmdChord6.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord6.TabIndex = 21
        Me.cmdChord6.Text = "VI"
        Me.cmdChord6.UseVisualStyleBackColor = True
        '
        'cmdChord5
        '
        Me.cmdChord5.Location = New System.Drawing.Point(197, 88)
        Me.cmdChord5.Name = "cmdChord5"
        Me.cmdChord5.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord5.TabIndex = 20
        Me.cmdChord5.Text = "V"
        Me.cmdChord5.UseVisualStyleBackColor = True
        '
        'txtChord
        '
        Me.txtChord.Enabled = False
        Me.txtChord.Location = New System.Drawing.Point(527, 25)
        Me.txtChord.Name = "txtChord"
        Me.txtChord.Size = New System.Drawing.Size(145, 20)
        Me.txtChord.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(524, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 14)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "CHORD OUTPUT:"
        '
        'chk7
        '
        Me.chk7.AutoSize = True
        Me.chk7.Location = New System.Drawing.Point(13, 114)
        Me.chk7.Name = "chk7"
        Me.chk7.Size = New System.Drawing.Size(40, 18)
        Me.chk7.TabIndex = 25
        Me.chk7.Text = "M7"
        Me.chk7.UseVisualStyleBackColor = True
        '
        'chk9
        '
        Me.chk9.AutoSize = True
        Me.chk9.Location = New System.Drawing.Point(50, 114)
        Me.chk9.Name = "chk9"
        Me.chk9.Size = New System.Drawing.Size(40, 18)
        Me.chk9.TabIndex = 26
        Me.chk9.Text = "M9"
        Me.chk9.UseVisualStyleBackColor = True
        '
        'chk11
        '
        Me.chk11.AutoSize = True
        Me.chk11.Location = New System.Drawing.Point(87, 113)
        Me.chk11.Name = "chk11"
        Me.chk11.Size = New System.Drawing.Size(47, 18)
        Me.chk11.TabIndex = 27
        Me.chk11.Text = "M11"
        Me.chk11.UseVisualStyleBackColor = True
        '
        'cmdAddChord
        '
        Me.cmdAddChord.Location = New System.Drawing.Point(527, 46)
        Me.cmdAddChord.Name = "cmdAddChord"
        Me.cmdAddChord.Size = New System.Drawing.Size(97, 20)
        Me.cmdAddChord.TabIndex = 28
        Me.cmdAddChord.Text = "Push to Tab"
        Me.cmdAddChord.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(139, 221)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(88, 20)
        Me.cmdClear.TabIndex = 29
        Me.cmdClear.Text = "Clear Tab"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdFretboard
        '
        Me.cmdFretboard.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmdFretboard.Location = New System.Drawing.Point(164, 149)
        Me.cmdFretboard.Name = "cmdFretboard"
        Me.cmdFretboard.Size = New System.Drawing.Size(81, 21)
        Me.cmdFretboard.TabIndex = 30
        Me.cmdFretboard.Text = "Fretboard"
        Me.cmdFretboard.UseVisualStyleBackColor = True
        '
        'cmdKeyboard
        '
        Me.cmdKeyboard.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmdKeyboard.Location = New System.Drawing.Point(251, 149)
        Me.cmdKeyboard.Name = "cmdKeyboard"
        Me.cmdKeyboard.Size = New System.Drawing.Size(81, 21)
        Me.cmdKeyboard.TabIndex = 31
        Me.cmdKeyboard.Text = "Keyboard"
        Me.cmdKeyboard.UseVisualStyleBackColor = True
        '
        'cmdMaximize
        '
        Me.cmdMaximize.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMaximize.ForeColor = System.Drawing.Color.Green
        Me.cmdMaximize.Location = New System.Drawing.Point(417, 149)
        Me.cmdMaximize.Name = "cmdMaximize"
        Me.cmdMaximize.Size = New System.Drawing.Size(81, 21)
        Me.cmdMaximize.TabIndex = 33
        Me.cmdMaximize.Text = "Expand"
        Me.ToolTip.SetToolTip(Me.cmdMaximize, "Show/Hide Options")
        Me.cmdMaximize.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtFretMax)
        Me.GroupBox1.Controls.Add(Me.txtFretMin)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.chkTones)
        Me.GroupBox1.Controls.Add(Me.chkTransparency)
        Me.GroupBox1.Controls.Add(Me.chkOnTop)
        Me.GroupBox1.Controls.Add(Me.chkTabRoot)
        Me.GroupBox1.Controls.Add(Me.chkNoteIcon)
        Me.GroupBox1.Controls.Add(Me.chkNoteText)
        Me.GroupBox1.Controls.Add(Me.chkAutoChord)
        Me.GroupBox1.Location = New System.Drawing.Point(602, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 104)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(134, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 14)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "to"
        '
        'txtFretMax
        '
        Me.txtFretMax.Location = New System.Drawing.Point(159, 78)
        Me.txtFretMax.Name = "txtFretMax"
        Me.txtFretMax.Size = New System.Drawing.Size(29, 20)
        Me.txtFretMax.TabIndex = 44
        Me.txtFretMax.Text = "24"
        Me.txtFretMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFretMin
        '
        Me.txtFretMin.Location = New System.Drawing.Point(101, 78)
        Me.txtFretMin.Name = "txtFretMin"
        Me.txtFretMin.Size = New System.Drawing.Size(29, 20)
        Me.txtFretMin.TabIndex = 43
        Me.txtFretMin.Text = "0"
        Me.txtFretMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 14)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "FRET RANGE:"
        '
        'chkTones
        '
        Me.chkTones.AutoSize = True
        Me.chkTones.Location = New System.Drawing.Point(16, 44)
        Me.chkTones.Name = "chkTones"
        Me.chkTones.Size = New System.Drawing.Size(110, 18)
        Me.chkTones.TabIndex = 41
        Me.chkTones.Text = "Tone Overlay"
        Me.ToolTip.SetToolTip(Me.chkTones, "Shows relative semitone on displays.")
        Me.chkTones.UseVisualStyleBackColor = True
        '
        'chkTransparency
        '
        Me.chkTransparency.AutoSize = True
        Me.chkTransparency.Location = New System.Drawing.Point(159, 44)
        Me.chkTransparency.Name = "chkTransparency"
        Me.chkTransparency.Size = New System.Drawing.Size(110, 18)
        Me.chkTransparency.TabIndex = 40
        Me.chkTransparency.Text = "Transparency"
        Me.ToolTip.SetToolTip(Me.chkTransparency, "Windows will be transparent.")
        Me.chkTransparency.UseVisualStyleBackColor = True
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(159, 30)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(117, 18)
        Me.chkOnTop.TabIndex = 39
        Me.chkOnTop.Text = "Always on Top"
        Me.ToolTip.SetToolTip(Me.chkOnTop, "Windows will always be on top.")
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'chkTabRoot
        '
        Me.chkTabRoot.AutoSize = True
        Me.chkTabRoot.Location = New System.Drawing.Point(16, 59)
        Me.chkTabRoot.Name = "chkTabRoot"
        Me.chkTabRoot.Size = New System.Drawing.Size(89, 18)
        Me.chkTabRoot.TabIndex = 38
        Me.chkTabRoot.Text = "Tab Roots"
        Me.ToolTip.SetToolTip(Me.chkTabRoot, "The root note in the tab is highlighted.")
        Me.chkTabRoot.UseVisualStyleBackColor = True
        '
        'chkNoteIcon
        '
        Me.chkNoteIcon.AutoSize = True
        Me.chkNoteIcon.Checked = True
        Me.chkNoteIcon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoteIcon.Location = New System.Drawing.Point(159, 16)
        Me.chkNoteIcon.Name = "chkNoteIcon"
        Me.chkNoteIcon.Size = New System.Drawing.Size(96, 18)
        Me.chkNoteIcon.TabIndex = 37
        Me.chkNoteIcon.Text = "Note Icons"
        Me.chkNoteIcon.UseVisualStyleBackColor = True
        '
        'chkNoteText
        '
        Me.chkNoteText.AutoSize = True
        Me.chkNoteText.Location = New System.Drawing.Point(16, 30)
        Me.chkNoteText.Name = "chkNoteText"
        Me.chkNoteText.Size = New System.Drawing.Size(110, 18)
        Me.chkNoteText.TabIndex = 36
        Me.chkNoteText.Text = "Note Overlay"
        Me.ToolTip.SetToolTip(Me.chkNoteText, "Shows notes on displays.")
        Me.chkNoteText.UseVisualStyleBackColor = True
        '
        'chkAutoChord
        '
        Me.chkAutoChord.AutoSize = True
        Me.chkAutoChord.Checked = True
        Me.chkAutoChord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoChord.Location = New System.Drawing.Point(16, 16)
        Me.chkAutoChord.Name = "chkAutoChord"
        Me.chkAutoChord.Size = New System.Drawing.Size(138, 18)
        Me.chkAutoChord.TabIndex = 35
        Me.chkAutoChord.Text = "Auto Show Chords"
        Me.chkAutoChord.UseVisualStyleBackColor = True
        '
        'chkDim
        '
        Me.chkDim.AutoSize = True
        Me.chkDim.Location = New System.Drawing.Point(276, 111)
        Me.chkDim.Name = "chkDim"
        Me.chkDim.Size = New System.Drawing.Size(47, 18)
        Me.chkDim.TabIndex = 36
        Me.chkDim.Text = "dim"
        Me.ToolTip.SetToolTip(Me.chkDim, "Diminished: Root, Flat Third, Flat Fifth")
        Me.chkDim.UseVisualStyleBackColor = True
        '
        'chkSus2
        '
        Me.chkSus2.AutoSize = True
        Me.chkSus2.Location = New System.Drawing.Point(177, 113)
        Me.chkSus2.Name = "chkSus2"
        Me.chkSus2.Size = New System.Drawing.Size(54, 18)
        Me.chkSus2.TabIndex = 37
        Me.chkSus2.Text = "sus2"
        Me.ToolTip.SetToolTip(Me.chkSus2, "Suspended Second: Double Flat Third")
        Me.chkSus2.UseVisualStyleBackColor = True
        '
        'chkSus4
        '
        Me.chkSus4.AutoSize = True
        Me.chkSus4.Location = New System.Drawing.Point(225, 113)
        Me.chkSus4.Name = "chkSus4"
        Me.chkSus4.Size = New System.Drawing.Size(54, 18)
        Me.chkSus4.TabIndex = 38
        Me.chkSus4.Text = "sus4"
        Me.ToolTip.SetToolTip(Me.chkSus4, "Suspended 4th: Sharp Third")
        Me.chkSus4.UseVisualStyleBackColor = True
        '
        'chkDim7
        '
        Me.chkDim7.AutoSize = True
        Me.chkDim7.Location = New System.Drawing.Point(319, 111)
        Me.chkDim7.Name = "chkDim7"
        Me.chkDim7.Size = New System.Drawing.Size(54, 18)
        Me.chkDim7.TabIndex = 42
        Me.chkDim7.Text = "dim7"
        Me.ToolTip.SetToolTip(Me.chkDim7, "Diminished 7th: Root, Flat 3rd, Flat 5th, Double Flat 7th")
        Me.chkDim7.UseVisualStyleBackColor = True
        '
        'chkAug
        '
        Me.chkAug.AutoSize = True
        Me.chkAug.Location = New System.Drawing.Point(368, 111)
        Me.chkAug.Name = "chkAug"
        Me.chkAug.Size = New System.Drawing.Size(47, 18)
        Me.chkAug.TabIndex = 43
        Me.chkAug.Text = "aug"
        Me.ToolTip.SetToolTip(Me.chkAug, "Augmented Chord: Root, 3rd, Sharp 5th")
        Me.chkAug.UseVisualStyleBackColor = True
        '
        'chkAug7
        '
        Me.chkAug7.AutoSize = True
        Me.chkAug7.Location = New System.Drawing.Point(412, 111)
        Me.chkAug7.Name = "chkAug7"
        Me.chkAug7.Size = New System.Drawing.Size(54, 18)
        Me.chkAug7.TabIndex = 44
        Me.chkAug7.Text = "aug7"
        Me.ToolTip.SetToolTip(Me.chkAug7, "Sharp Fifth, Flat Seventh")
        Me.chkAug7.UseVisualStyleBackColor = True
        '
        'chkMin
        '
        Me.chkMin.AutoSize = True
        Me.chkMin.Location = New System.Drawing.Point(131, 113)
        Me.chkMin.Name = "chkMin"
        Me.chkMin.Size = New System.Drawing.Size(47, 18)
        Me.chkMin.TabIndex = 45
        Me.chkMin.Text = "min"
        Me.ToolTip.SetToolTip(Me.chkMin, "Diminished: Root, Flat Third, Flat Fifth")
        Me.chkMin.UseVisualStyleBackColor = True
        '
        'cmdBuilder
        '
        Me.cmdBuilder.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmdBuilder.Location = New System.Drawing.Point(338, 149)
        Me.cmdBuilder.Name = "cmdBuilder"
        Me.cmdBuilder.Size = New System.Drawing.Size(73, 21)
        Me.cmdBuilder.TabIndex = 57
        Me.cmdBuilder.Text = "Chorder"
        Me.ToolTip.SetToolTip(Me.cmdBuilder, "A tool to build chords.")
        Me.cmdBuilder.UseVisualStyleBackColor = True
        '
        'cmdAbout
        '
        Me.cmdAbout.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.Color.Red
        Me.cmdAbout.Location = New System.Drawing.Point(841, 18)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(32, 27)
        Me.cmdAbout.TabIndex = 58
        Me.cmdAbout.Text = "Ω"
        Me.ToolTip.SetToolTip(Me.cmdAbout, "Information")
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'cmdTriadView
        '
        Me.cmdTriadView.ForeColor = System.Drawing.Color.Purple
        Me.cmdTriadView.Location = New System.Drawing.Point(345, 88)
        Me.cmdTriadView.Name = "cmdTriadView"
        Me.cmdTriadView.Size = New System.Drawing.Size(103, 21)
        Me.cmdTriadView.TabIndex = 59
        Me.cmdTriadView.Text = "Triad Viewer"
        Me.ToolTip.SetToolTip(Me.cmdTriadView, "Shows all chord degree triads on a single form.")
        Me.cmdTriadView.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(526, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 14)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "POPULAR PROGRESSIONS:"
        '
        'cbProgressions
        '
        Me.cbProgressions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgressions.FormattingEnabled = True
        Me.cbProgressions.Items.AddRange(New Object() {"Popular Kid", "Sensitive One", "Stirring Hope", "Drama Resolution", "Jazz Cat", "The Canon", "Chris Issac - Wicked Game", "Coldplay - Clocks", "Doo Wop Progression (very popular)", "Oasis - Don't Look Back", "The Cure - A Letter to Elise"})
        Me.cbProgressions.Location = New System.Drawing.Point(527, 83)
        Me.cbProgressions.Name = "cbProgressions"
        Me.cbProgressions.Size = New System.Drawing.Size(358, 22)
        Me.cbProgressions.TabIndex = 53
        '
        'cbProgList
        '
        Me.cbProgList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgList.FormattingEnabled = True
        Me.cbProgList.Items.AddRange(New Object() {"I,IV,V", "I,V,vi,IV", "vi,V,IV,V", "i,VII,III,VI", "ii,V,I", "I,V,vi,iii,IV,I,IV,V", "i,VII,IV,IV", "I,v,v,ii", "I,vi,IV,V", "IV,I,IV,V", "I,V,vi,IV"})
        Me.cbProgList.Location = New System.Drawing.Point(527, 109)
        Me.cbProgList.Name = "cbProgList"
        Me.cbProgList.Size = New System.Drawing.Size(358, 22)
        Me.cbProgList.TabIndex = 55
        '
        'cmdHideTab
        '
        Me.cmdHideTab.Location = New System.Drawing.Point(156, 186)
        Me.cmdHideTab.Name = "cmdHideTab"
        Me.cmdHideTab.Size = New System.Drawing.Size(71, 20)
        Me.cmdHideTab.TabIndex = 56
        Me.cmdHideTab.Text = "Hide Tab"
        Me.cmdHideTab.UseVisualStyleBackColor = True
        '
        'frmTabTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 824)
        Me.Controls.Add(Me.cmdTriadView)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.cmdBuilder)
        Me.Controls.Add(Me.cmdHideTab)
        Me.Controls.Add(Me.cbProgList)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbProgressions)
        Me.Controls.Add(Me.chkMin)
        Me.Controls.Add(Me.chkAug7)
        Me.Controls.Add(Me.chkAug)
        Me.Controls.Add(Me.chkDim7)
        Me.Controls.Add(Me.chkSus4)
        Me.Controls.Add(Me.chkSus2)
        Me.Controls.Add(Me.chkDim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdMaximize)
        Me.Controls.Add(Me.cmdKeyboard)
        Me.Controls.Add(Me.cmdFretboard)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdAddChord)
        Me.Controls.Add(Me.chk11)
        Me.Controls.Add(Me.chk9)
        Me.Controls.Add(Me.chk7)
        Me.Controls.Add(Me.txtChord)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdChord7)
        Me.Controls.Add(Me.cmdChord6)
        Me.Controls.Add(Me.cmdChord5)
        Me.Controls.Add(Me.cmdChord4)
        Me.Controls.Add(Me.cmdChord3)
        Me.Controls.Add(Me.cmdChord2)
        Me.Controls.Add(Me.cmdChord1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdDraw)
        Me.Controls.Add(Me.txtTab)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTuning)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVals)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbInt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbMode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbKey)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTabTool"
        Me.Text = "Studioborne"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbKey As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMode As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbInt As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtVals As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTuning As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTab As TextBox
    Friend WithEvents cmdDraw As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdChord1 As Button
    Friend WithEvents cmdChord2 As Button
    Friend WithEvents cmdChord3 As Button
    Friend WithEvents cmdChord4 As Button
    Friend WithEvents cmdChord7 As Button
    Friend WithEvents cmdChord6 As Button
    Friend WithEvents cmdChord5 As Button
    Friend WithEvents txtChord As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk9 As CheckBox
    Friend WithEvents chk11 As CheckBox
    Friend WithEvents cmdAddChord As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdFretboard As Button
    Friend WithEvents cmdKeyboard As Button
    Friend WithEvents cmdMaximize As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkNoteText As CheckBox
    Friend WithEvents chkAutoChord As CheckBox
    Friend WithEvents chkNoteIcon As CheckBox
    Friend WithEvents chkDim As CheckBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents chkSus2 As CheckBox
    Friend WithEvents chkSus4 As CheckBox
    Friend WithEvents chkTabRoot As CheckBox
    Friend WithEvents chkDim7 As CheckBox
    Friend WithEvents chkAug As CheckBox
    Friend WithEvents chkAug7 As CheckBox
    Friend WithEvents chkMin As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbProgressions As ComboBox
    Friend WithEvents cbProgList As ComboBox
    Friend WithEvents cmdHideTab As Button
    Friend WithEvents chkOnTop As CheckBox
    Friend WithEvents chkTransparency As CheckBox
    Friend WithEvents cmdBuilder As Button
    Friend WithEvents cmdAbout As Button
    Friend WithEvents chkTones As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFretMax As TextBox
    Friend WithEvents txtFretMin As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdTriadView As Button
End Class
