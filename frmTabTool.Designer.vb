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
        Me.cmdFretboard = New System.Windows.Forms.Button()
        Me.cmdKeyboard = New System.Windows.Forms.Button()
        Me.cmdMaximize = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdBuilder = New System.Windows.Forms.Button()
        Me.chkMin = New System.Windows.Forms.CheckBox()
        Me.chkAug = New System.Windows.Forms.CheckBox()
        Me.chkDim7 = New System.Windows.Forms.CheckBox()
        Me.chkSus4 = New System.Windows.Forms.CheckBox()
        Me.chkDim = New System.Windows.Forms.CheckBox()
        Me.chkAug7 = New System.Windows.Forms.CheckBox()
        Me.chkSus2 = New System.Windows.Forms.CheckBox()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.cmdTriadView = New System.Windows.Forms.Button()
        Me.cmdTabEditor = New System.Windows.Forms.Button()
        Me.cmdProgressor = New System.Windows.Forms.Button()
        Me.chkOnTop = New System.Windows.Forms.CheckBox()
        Me.chkMaj = New System.Windows.Forms.CheckBox()
        Me.DebugBox = New System.Windows.Forms.GroupBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVals = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbInt = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkm13 = New System.Windows.Forms.CheckBox()
        Me.chkm11 = New System.Windows.Forms.CheckBox()
        Me.chkm9 = New System.Windows.Forms.CheckBox()
        Me.chkm7 = New System.Windows.Forms.CheckBox()
        Me.chk13 = New System.Windows.Forms.CheckBox()
        Me.chk11 = New System.Windows.Forms.CheckBox()
        Me.chk9 = New System.Windows.Forms.CheckBox()
        Me.chk7 = New System.Windows.Forms.CheckBox()
        Me.cmdChord7 = New System.Windows.Forms.Button()
        Me.cmdChord6 = New System.Windows.Forms.Button()
        Me.cmdChord5 = New System.Windows.Forms.Button()
        Me.cmdChord4 = New System.Windows.Forms.Button()
        Me.cmdChord3 = New System.Windows.Forms.Button()
        Me.cmdChord2 = New System.Windows.Forms.Button()
        Me.cmdChord1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DebugBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbKey
        '
        Me.cbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKey.FormattingEnabled = True
        Me.cbKey.Items.AddRange(New Object() {"A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"})
        Me.cbKey.Location = New System.Drawing.Point(6, 20)
        Me.cbKey.Name = "cbKey"
        Me.cbKey.Size = New System.Drawing.Size(165, 22)
        Me.cbKey.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KEY:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 3)
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
        Me.cbMode.Location = New System.Drawing.Point(180, 20)
        Me.cbMode.Name = "cbMode"
        Me.cbMode.Size = New System.Drawing.Size(165, 22)
        Me.cbMode.TabIndex = 2
        '
        'cmdFretboard
        '
        Me.cmdFretboard.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmdFretboard.Location = New System.Drawing.Point(5, 47)
        Me.cmdFretboard.Name = "cmdFretboard"
        Me.cmdFretboard.Size = New System.Drawing.Size(82, 21)
        Me.cmdFretboard.TabIndex = 30
        Me.cmdFretboard.Text = "Fretboard"
        Me.cmdFretboard.UseVisualStyleBackColor = True
        '
        'cmdKeyboard
        '
        Me.cmdKeyboard.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmdKeyboard.Location = New System.Drawing.Point(89, 47)
        Me.cmdKeyboard.Name = "cmdKeyboard"
        Me.cmdKeyboard.Size = New System.Drawing.Size(82, 21)
        Me.cmdKeyboard.TabIndex = 31
        Me.cmdKeyboard.Text = "Keyboard"
        Me.cmdKeyboard.UseVisualStyleBackColor = True
        '
        'cmdMaximize
        '
        Me.cmdMaximize.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMaximize.ForeColor = System.Drawing.Color.Green
        Me.cmdMaximize.Location = New System.Drawing.Point(279, 47)
        Me.cmdMaximize.Name = "cmdMaximize"
        Me.cmdMaximize.Size = New System.Drawing.Size(66, 21)
        Me.cmdMaximize.TabIndex = 33
        Me.cmdMaximize.Text = "Expand"
        Me.ToolTip.SetToolTip(Me.cmdMaximize, "Show/Hide Options")
        Me.cmdMaximize.UseVisualStyleBackColor = True
        '
        'cmdBuilder
        '
        Me.cmdBuilder.ForeColor = System.Drawing.Color.Purple
        Me.cmdBuilder.Location = New System.Drawing.Point(180, 47)
        Me.cmdBuilder.Name = "cmdBuilder"
        Me.cmdBuilder.Size = New System.Drawing.Size(93, 21)
        Me.cmdBuilder.TabIndex = 57
        Me.cmdBuilder.Text = "Chord Tool"
        Me.ToolTip.SetToolTip(Me.cmdBuilder, "A tool to build chords.")
        Me.cmdBuilder.UseVisualStyleBackColor = True
        '
        'chkMin
        '
        Me.chkMin.AutoSize = True
        Me.chkMin.Location = New System.Drawing.Point(8, 28)
        Me.chkMin.Name = "chkMin"
        Me.chkMin.Size = New System.Drawing.Size(47, 18)
        Me.chkMin.TabIndex = 73
        Me.chkMin.Text = "min"
        Me.ToolTip.SetToolTip(Me.chkMin, "Diminished: Root, Flat Third, Flat Fifth")
        Me.chkMin.UseVisualStyleBackColor = True
        '
        'chkAug
        '
        Me.chkAug.AutoSize = True
        Me.chkAug.Location = New System.Drawing.Point(107, 44)
        Me.chkAug.Name = "chkAug"
        Me.chkAug.Size = New System.Drawing.Size(47, 18)
        Me.chkAug.TabIndex = 71
        Me.chkAug.Text = "aug"
        Me.ToolTip.SetToolTip(Me.chkAug, "Augmented Chord: Root, 3rd, Sharp 5th")
        Me.chkAug.UseVisualStyleBackColor = True
        '
        'chkDim7
        '
        Me.chkDim7.AutoSize = True
        Me.chkDim7.Location = New System.Drawing.Point(57, 44)
        Me.chkDim7.Name = "chkDim7"
        Me.chkDim7.Size = New System.Drawing.Size(54, 18)
        Me.chkDim7.TabIndex = 70
        Me.chkDim7.Text = "dim7"
        Me.ToolTip.SetToolTip(Me.chkDim7, "Diminished 7th: Root, Flat 3rd, Flat 5th, Double Flat 7th")
        Me.chkDim7.UseVisualStyleBackColor = True
        '
        'chkSus4
        '
        Me.chkSus4.AutoSize = True
        Me.chkSus4.Location = New System.Drawing.Point(259, 44)
        Me.chkSus4.Name = "chkSus4"
        Me.chkSus4.Size = New System.Drawing.Size(54, 18)
        Me.chkSus4.TabIndex = 69
        Me.chkSus4.Text = "sus4"
        Me.ToolTip.SetToolTip(Me.chkSus4, "Suspended 4th: Sharp Third")
        Me.chkSus4.UseVisualStyleBackColor = True
        '
        'chkDim
        '
        Me.chkDim.AutoSize = True
        Me.chkDim.Location = New System.Drawing.Point(8, 44)
        Me.chkDim.Name = "chkDim"
        Me.chkDim.Size = New System.Drawing.Size(47, 18)
        Me.chkDim.TabIndex = 67
        Me.chkDim.Text = "dim"
        Me.ToolTip.SetToolTip(Me.chkDim, "Diminished: Root, Flat Third, Flat Fifth")
        Me.chkDim.UseVisualStyleBackColor = True
        '
        'chkAug7
        '
        Me.chkAug7.AutoSize = True
        Me.chkAug7.Location = New System.Drawing.Point(150, 44)
        Me.chkAug7.Name = "chkAug7"
        Me.chkAug7.Size = New System.Drawing.Size(54, 18)
        Me.chkAug7.TabIndex = 74
        Me.chkAug7.Text = "aug7"
        Me.ToolTip.SetToolTip(Me.chkAug7, "Sharp Fifth, Flat Seventh")
        Me.chkAug7.UseVisualStyleBackColor = True
        '
        'chkSus2
        '
        Me.chkSus2.AutoSize = True
        Me.chkSus2.Location = New System.Drawing.Point(199, 44)
        Me.chkSus2.Name = "chkSus2"
        Me.chkSus2.Size = New System.Drawing.Size(54, 18)
        Me.chkSus2.TabIndex = 75
        Me.chkSus2.Text = "sus2"
        Me.ToolTip.SetToolTip(Me.chkSus2, "Suspended Second: Double Flat Third")
        Me.chkSus2.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOptions.ForeColor = System.Drawing.Color.Green
        Me.cmdOptions.Location = New System.Drawing.Point(6, 41)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(109, 21)
        Me.cmdOptions.TabIndex = 61
        Me.cmdOptions.Text = "Options"
        Me.ToolTip.SetToolTip(Me.cmdOptions, "Show/Hide Options")
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdInfo
        '
        Me.cmdInfo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInfo.ForeColor = System.Drawing.Color.Green
        Me.cmdInfo.Location = New System.Drawing.Point(6, 19)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(109, 21)
        Me.cmdInfo.TabIndex = 62
        Me.cmdInfo.Text = "Info Panel"
        Me.ToolTip.SetToolTip(Me.cmdInfo, "Show/Hide Options")
        Me.cmdInfo.UseVisualStyleBackColor = True
        '
        'cmdTriadView
        '
        Me.cmdTriadView.ForeColor = System.Drawing.Color.Purple
        Me.cmdTriadView.Location = New System.Drawing.Point(6, 101)
        Me.cmdTriadView.Name = "cmdTriadView"
        Me.cmdTriadView.Size = New System.Drawing.Size(109, 21)
        Me.cmdTriadView.TabIndex = 63
        Me.cmdTriadView.Text = "Triad Viewer"
        Me.ToolTip.SetToolTip(Me.cmdTriadView, "Shows all chord degree triads on a single form.")
        Me.cmdTriadView.UseVisualStyleBackColor = True
        '
        'cmdTabEditor
        '
        Me.cmdTabEditor.ForeColor = System.Drawing.Color.Blue
        Me.cmdTabEditor.Location = New System.Drawing.Point(6, 128)
        Me.cmdTabEditor.Name = "cmdTabEditor"
        Me.cmdTabEditor.Size = New System.Drawing.Size(109, 21)
        Me.cmdTabEditor.TabIndex = 64
        Me.cmdTabEditor.Text = "Tab Editor"
        Me.ToolTip.SetToolTip(Me.cmdTabEditor, "Shows all chord degree triads on a single form.")
        Me.cmdTabEditor.UseVisualStyleBackColor = True
        '
        'cmdProgressor
        '
        Me.cmdProgressor.ForeColor = System.Drawing.Color.Purple
        Me.cmdProgressor.Location = New System.Drawing.Point(6, 75)
        Me.cmdProgressor.Name = "cmdProgressor"
        Me.cmdProgressor.Size = New System.Drawing.Size(109, 21)
        Me.cmdProgressor.TabIndex = 65
        Me.cmdProgressor.Text = "Progressor"
        Me.ToolTip.SetToolTip(Me.cmdProgressor, "Shows all chord degree triads on a single form.")
        Me.cmdProgressor.UseVisualStyleBackColor = True
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(433, 166)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(47, 18)
        Me.chkOnTop.TabIndex = 65
        Me.chkOnTop.Text = "Top"
        Me.ToolTip.SetToolTip(Me.chkOnTop, "Keep this window on top of all others?")
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'chkMaj
        '
        Me.chkMaj.AutoSize = True
        Me.chkMaj.Location = New System.Drawing.Point(8, 12)
        Me.chkMaj.Name = "chkMaj"
        Me.chkMaj.Size = New System.Drawing.Size(47, 18)
        Me.chkMaj.TabIndex = 76
        Me.chkMaj.Text = "maj"
        Me.ToolTip.SetToolTip(Me.chkMaj, "Diminished: Root, Flat Third, Flat Fifth")
        Me.chkMaj.UseVisualStyleBackColor = True
        '
        'DebugBox
        '
        Me.DebugBox.Controls.Add(Me.txtNotes)
        Me.DebugBox.Controls.Add(Me.Label4)
        Me.DebugBox.Controls.Add(Me.txtVals)
        Me.DebugBox.Controls.Add(Me.Label5)
        Me.DebugBox.Controls.Add(Me.Label3)
        Me.DebugBox.Controls.Add(Me.cbInt)
        Me.DebugBox.Location = New System.Drawing.Point(7, 188)
        Me.DebugBox.Name = "DebugBox"
        Me.DebugBox.Size = New System.Drawing.Size(203, 168)
        Me.DebugBox.TabIndex = 62
        Me.DebugBox.TabStop = False
        Me.DebugBox.Text = "Debug Box (Hide @ Runtime)"
        '
        'txtNotes
        '
        Me.txtNotes.Enabled = False
        Me.txtNotes.Location = New System.Drawing.Point(6, 105)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(191, 20)
        Me.txtNotes.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "NOTES:"
        '
        'txtVals
        '
        Me.txtVals.Enabled = False
        Me.txtVals.Location = New System.Drawing.Point(6, 69)
        Me.txtVals.Name = "txtVals"
        Me.txtVals.Size = New System.Drawing.Size(191, 20)
        Me.txtVals.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "RELATIVE SEMITONES:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "INTERVALS:"
        '
        'cbInt
        '
        Me.cbInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInt.FormattingEnabled = True
        Me.cbInt.Items.AddRange(New Object() {"2,2,1,2,2,2,1", "2,1,2,2,2,1,2", "1,2,2,2,1,2,2", "1,3,1,2,1,2,2", "2,2,2,1,2,2,1", "2,2,1,2,2,1,2", "2,1,2,2,1,2,2", "1,2,2,1,2,2,2", "2,1,2,2,2,2,1", "2,1,2,2,1,3,1", "1,2,1,2,2,2,2", "2,2,3,2,3", "3,2,2,3,2", "3,2,1,1,3,2", "1,1,1,1,1,1,1,1,1,1,1,1"})
        Me.cbInt.Location = New System.Drawing.Point(6, 30)
        Me.cbInt.Name = "cbInt"
        Me.cbInt.Size = New System.Drawing.Size(191, 22)
        Me.cbInt.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdChord7)
        Me.GroupBox1.Controls.Add(Me.cmdChord6)
        Me.GroupBox1.Controls.Add(Me.cmdChord5)
        Me.GroupBox1.Controls.Add(Me.cmdChord4)
        Me.GroupBox1.Controls.Add(Me.cmdChord3)
        Me.GroupBox1.Controls.Add(Me.cmdChord2)
        Me.GroupBox1.Controls.Add(Me.cmdChord1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 108)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BASIC CHORDS:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkm13)
        Me.GroupBox2.Controls.Add(Me.chkm11)
        Me.GroupBox2.Controls.Add(Me.chkm9)
        Me.GroupBox2.Controls.Add(Me.chkm7)
        Me.GroupBox2.Controls.Add(Me.chk13)
        Me.GroupBox2.Controls.Add(Me.chkMaj)
        Me.GroupBox2.Controls.Add(Me.chkSus2)
        Me.GroupBox2.Controls.Add(Me.chkAug7)
        Me.GroupBox2.Controls.Add(Me.chkMin)
        Me.GroupBox2.Controls.Add(Me.chkAug)
        Me.GroupBox2.Controls.Add(Me.chkDim7)
        Me.GroupBox2.Controls.Add(Me.chkSus4)
        Me.GroupBox2.Controls.Add(Me.chkDim)
        Me.GroupBox2.Controls.Add(Me.chk11)
        Me.GroupBox2.Controls.Add(Me.chk9)
        Me.GroupBox2.Controls.Add(Me.chk7)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(11, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 65)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quick Chord Alteration:"
        '
        'chkm13
        '
        Me.chkm13.AutoSize = True
        Me.chkm13.Location = New System.Drawing.Point(199, 28)
        Me.chkm13.Name = "chkm13"
        Me.chkm13.Size = New System.Drawing.Size(47, 18)
        Me.chkm13.TabIndex = 81
        Me.chkm13.Text = "m13"
        Me.chkm13.UseVisualStyleBackColor = True
        '
        'chkm11
        '
        Me.chkm11.AutoSize = True
        Me.chkm11.Location = New System.Drawing.Point(150, 28)
        Me.chkm11.Name = "chkm11"
        Me.chkm11.Size = New System.Drawing.Size(47, 18)
        Me.chkm11.TabIndex = 80
        Me.chkm11.Text = "m11"
        Me.chkm11.UseVisualStyleBackColor = True
        '
        'chkm9
        '
        Me.chkm9.AutoSize = True
        Me.chkm9.Location = New System.Drawing.Point(107, 28)
        Me.chkm9.Name = "chkm9"
        Me.chkm9.Size = New System.Drawing.Size(40, 18)
        Me.chkm9.TabIndex = 79
        Me.chkm9.Text = "m9"
        Me.chkm9.UseVisualStyleBackColor = True
        '
        'chkm7
        '
        Me.chkm7.AutoSize = True
        Me.chkm7.Location = New System.Drawing.Point(57, 28)
        Me.chkm7.Name = "chkm7"
        Me.chkm7.Size = New System.Drawing.Size(40, 18)
        Me.chkm7.TabIndex = 78
        Me.chkm7.Text = "m7"
        Me.chkm7.UseVisualStyleBackColor = True
        '
        'chk13
        '
        Me.chk13.AutoSize = True
        Me.chk13.Location = New System.Drawing.Point(199, 12)
        Me.chk13.Name = "chk13"
        Me.chk13.Size = New System.Drawing.Size(47, 18)
        Me.chk13.TabIndex = 77
        Me.chk13.Text = "M13"
        Me.chk13.UseVisualStyleBackColor = True
        '
        'chk11
        '
        Me.chk11.AutoSize = True
        Me.chk11.Location = New System.Drawing.Point(150, 12)
        Me.chk11.Name = "chk11"
        Me.chk11.Size = New System.Drawing.Size(47, 18)
        Me.chk11.TabIndex = 66
        Me.chk11.Text = "M11"
        Me.chk11.UseVisualStyleBackColor = True
        '
        'chk9
        '
        Me.chk9.AutoSize = True
        Me.chk9.Location = New System.Drawing.Point(107, 12)
        Me.chk9.Name = "chk9"
        Me.chk9.Size = New System.Drawing.Size(40, 18)
        Me.chk9.TabIndex = 65
        Me.chk9.Text = "M9"
        Me.chk9.UseVisualStyleBackColor = True
        '
        'chk7
        '
        Me.chk7.AutoSize = True
        Me.chk7.Location = New System.Drawing.Point(57, 12)
        Me.chk7.Name = "chk7"
        Me.chk7.Size = New System.Drawing.Size(40, 18)
        Me.chk7.TabIndex = 64
        Me.chk7.Text = "M7"
        Me.chk7.UseVisualStyleBackColor = True
        '
        'cmdChord7
        '
        Me.cmdChord7.Location = New System.Drawing.Point(282, 15)
        Me.cmdChord7.Name = "cmdChord7"
        Me.cmdChord7.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord7.TabIndex = 53
        Me.cmdChord7.Text = "VII"
        Me.cmdChord7.UseVisualStyleBackColor = True
        '
        'cmdChord6
        '
        Me.cmdChord6.Location = New System.Drawing.Point(236, 15)
        Me.cmdChord6.Name = "cmdChord6"
        Me.cmdChord6.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord6.TabIndex = 52
        Me.cmdChord6.Text = "VI"
        Me.cmdChord6.UseVisualStyleBackColor = True
        '
        'cmdChord5
        '
        Me.cmdChord5.Location = New System.Drawing.Point(190, 15)
        Me.cmdChord5.Name = "cmdChord5"
        Me.cmdChord5.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord5.TabIndex = 51
        Me.cmdChord5.Text = "V"
        Me.cmdChord5.UseVisualStyleBackColor = True
        '
        'cmdChord4
        '
        Me.cmdChord4.Location = New System.Drawing.Point(144, 15)
        Me.cmdChord4.Name = "cmdChord4"
        Me.cmdChord4.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord4.TabIndex = 50
        Me.cmdChord4.Text = "IV"
        Me.cmdChord4.UseVisualStyleBackColor = True
        '
        'cmdChord3
        '
        Me.cmdChord3.Location = New System.Drawing.Point(98, 15)
        Me.cmdChord3.Name = "cmdChord3"
        Me.cmdChord3.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord3.TabIndex = 49
        Me.cmdChord3.Text = "III"
        Me.cmdChord3.UseVisualStyleBackColor = True
        '
        'cmdChord2
        '
        Me.cmdChord2.Location = New System.Drawing.Point(52, 15)
        Me.cmdChord2.Name = "cmdChord2"
        Me.cmdChord2.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord2.TabIndex = 48
        Me.cmdChord2.Text = "II"
        Me.cmdChord2.UseVisualStyleBackColor = True
        '
        'cmdChord1
        '
        Me.cmdChord1.Location = New System.Drawing.Point(6, 15)
        Me.cmdChord1.Name = "cmdChord1"
        Me.cmdChord1.Size = New System.Drawing.Size(47, 21)
        Me.cmdChord1.TabIndex = 47
        Me.cmdChord1.Text = "I"
        Me.cmdChord1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdProgressor)
        Me.GroupBox3.Controls.Add(Me.cmdTabEditor)
        Me.GroupBox3.Controls.Add(Me.cmdTriadView)
        Me.GroupBox3.Controls.Add(Me.cmdInfo)
        Me.GroupBox3.Controls.Add(Me.cmdOptions)
        Me.GroupBox3.Location = New System.Drawing.Point(358, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 158)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TOOLS:"
        '
        'frmTabTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 371)
        Me.Controls.Add(Me.chkOnTop)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DebugBox)
        Me.Controls.Add(Me.cmdBuilder)
        Me.Controls.Add(Me.cmdMaximize)
        Me.Controls.Add(Me.cmdKeyboard)
        Me.Controls.Add(Me.cmdFretboard)
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
        Me.DebugBox.ResumeLayout(False)
        Me.DebugBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbKey As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMode As ComboBox
    Friend WithEvents cmdFretboard As Button
    Friend WithEvents cmdKeyboard As Button
    Friend WithEvents cmdMaximize As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents cmdBuilder As Button
    Friend WithEvents DebugBox As GroupBox
    Friend WithEvents txtVals As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbInt As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdChord7 As Button
    Friend WithEvents cmdChord6 As Button
    Friend WithEvents cmdChord5 As Button
    Friend WithEvents cmdChord4 As Button
    Friend WithEvents cmdChord3 As Button
    Friend WithEvents cmdChord2 As Button
    Friend WithEvents cmdChord1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkSus2 As CheckBox
    Friend WithEvents chkAug7 As CheckBox
    Friend WithEvents chkMin As CheckBox
    Friend WithEvents chkAug As CheckBox
    Friend WithEvents chkDim7 As CheckBox
    Friend WithEvents chkSus4 As CheckBox
    Friend WithEvents chkDim As CheckBox
    Friend WithEvents chk11 As CheckBox
    Friend WithEvents chk9 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdTriadView As Button
    Friend WithEvents cmdInfo As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdTabEditor As Button
    Friend WithEvents cmdProgressor As Button
    Friend WithEvents chkOnTop As CheckBox
    Friend WithEvents chkMaj As CheckBox
    Friend WithEvents chk13 As CheckBox
    Friend WithEvents chkm13 As CheckBox
    Friend WithEvents chkm11 As CheckBox
    Friend WithEvents chkm9 As CheckBox
    Friend WithEvents chkm7 As CheckBox
End Class
