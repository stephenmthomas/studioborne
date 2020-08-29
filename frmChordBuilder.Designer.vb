<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChordBuilder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChordBuilder))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbRoot = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbQuick = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSymbol = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbIntervals = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.chkAutoDisplay = New System.Windows.Forms.CheckBox()
        Me.chkOnTop = New System.Windows.Forms.CheckBox()
        Me.cmdSize = New System.Windows.Forms.Button()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb8 = New System.Windows.Forms.CheckBox()
        Me.cb7 = New System.Windows.Forms.CheckBox()
        Me.cb6 = New System.Windows.Forms.CheckBox()
        Me.cb5 = New System.Windows.Forms.CheckBox()
        Me.cb12 = New System.Windows.Forms.CheckBox()
        Me.cb11 = New System.Windows.Forms.CheckBox()
        Me.cb10 = New System.Windows.Forms.CheckBox()
        Me.cb9 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblShort = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.lblSpec = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.cb0 = New System.Windows.Forms.CheckBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.cmdShowChord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ROOT:"
        '
        'cbRoot
        '
        Me.cbRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoot.FormattingEnabled = True
        Me.cbRoot.Items.AddRange(New Object() {"A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"})
        Me.cbRoot.Location = New System.Drawing.Point(6, 21)
        Me.cbRoot.Name = "cbRoot"
        Me.cbRoot.Size = New System.Drawing.Size(43, 22)
        Me.cbRoot.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CHORD TYPE:"
        '
        'cbQuick
        '
        Me.cbQuick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbQuick.FormattingEnabled = True
        Me.cbQuick.Items.AddRange(New Object() {"Suspended Second", "Diminished Triad", "Diminished Seventh", "Half-Diminished Seventh", "Minor Triad", "Minor Seventh", "Minor-Major Seventh", "Minor Sixth", "Minor 7th Sharp 5th", "Flat Five", "Dom 7th Flat Five", "Major 7th Flat Five", "Major Triad", "Dominant Seventh", "Major Seventh", "Major Sixth", "Augmented Triad", "Augmented Seventh", "Dom 7th Sharp 5th", "Major 7th Sharp 5th", "Suspended Fourth", "Dominant Sus 4th", "Five"})
        Me.cbQuick.Location = New System.Drawing.Point(55, 21)
        Me.cbQuick.Name = "cbQuick"
        Me.cbQuick.Size = New System.Drawing.Size(191, 22)
        Me.cbQuick.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SYMBOL:"
        '
        'cbSymbol
        '
        Me.cbSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSymbol.FormattingEnabled = True
        Me.cbSymbol.Items.AddRange(New Object() {"sus2", "dim", "dim7", "°7/m7b5", "min", "min7/m7", "min/maj7", "min6/m6", "m7#5", "flat5", "7b5", "maj7b5", "Δ/maj", "dom7/7th", "maj7", "maj6/6th", "aug", "aug7", "7#5", "maj7#5", "sus4", "7sus4", "5"})
        Me.cbSymbol.Location = New System.Drawing.Point(252, 21)
        Me.cbSymbol.Name = "cbSymbol"
        Me.cbSymbol.Size = New System.Drawing.Size(110, 22)
        Me.cbSymbol.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "INTERVALS:"
        '
        'cbIntervals
        '
        Me.cbIntervals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntervals.FormattingEnabled = True
        Me.cbIntervals.Items.AddRange(New Object() {"0,2,7", "0,3,6", "0,3,6,9", "0,3,6,10", "0,3,7", "0,3,7,10", "0,3,7,11", "0,3,7,9", "0,3,8,10", "0,4,5", "0,4,6,10", "0,4,6,11", "0,4,7", "0,4,7,10", "0,4,7,11", "0,4,7,9", "0,4,8", "0,4,8,10", "0,4,8,10", "0,4,8,11", "0,5,7", "0,5,7,10", "0,7"})
        Me.cbIntervals.Location = New System.Drawing.Point(368, 21)
        Me.cbIntervals.Name = "cbIntervals"
        Me.cbIntervals.Size = New System.Drawing.Size(84, 22)
        Me.cbIntervals.TabIndex = 8
        '
        'txtNotes
        '
        Me.txtNotes.Enabled = False
        Me.txtNotes.Location = New System.Drawing.Point(117, 65)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(129, 20)
        Me.txtNotes.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(114, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 14)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "NOTES:"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(6, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(105, 20)
        Me.txtName.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "CHORD NAME:"
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(255, 65)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(50, 20)
        Me.cmdShow.TabIndex = 29
        Me.cmdShow.Text = "Show"
        Me.cmdShow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'chkAutoDisplay
        '
        Me.chkAutoDisplay.AutoSize = True
        Me.chkAutoDisplay.Checked = True
        Me.chkAutoDisplay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoDisplay.Location = New System.Drawing.Point(307, 66)
        Me.chkAutoDisplay.Name = "chkAutoDisplay"
        Me.chkAutoDisplay.Size = New System.Drawing.Size(89, 18)
        Me.chkAutoDisplay.TabIndex = 30
        Me.chkAutoDisplay.Text = "Auto Show"
        Me.chkAutoDisplay.UseVisualStyleBackColor = True
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(406, 84)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(47, 18)
        Me.chkOnTop.TabIndex = 42
        Me.chkOnTop.Text = "Top"
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'cmdSize
        '
        Me.cmdSize.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSize.Location = New System.Drawing.Point(392, 65)
        Me.cmdSize.Name = "cmdSize"
        Me.cmdSize.Size = New System.Drawing.Size(60, 20)
        Me.cmdSize.TabIndex = 43
        Me.cmdSize.Text = "More"
        Me.cmdSize.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(204, 141)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(40, 18)
        Me.cb1.TabIndex = 44
        Me.cb1.Text = "01"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(204, 165)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(40, 18)
        Me.cb2.TabIndex = 45
        Me.cb2.Text = "02"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Location = New System.Drawing.Point(204, 213)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(40, 18)
        Me.cb4.TabIndex = 47
        Me.cb4.Text = "04"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(204, 189)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(40, 18)
        Me.cb3.TabIndex = 46
        Me.cb3.Text = "03"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb8
        '
        Me.cb8.AutoSize = True
        Me.cb8.Location = New System.Drawing.Point(204, 307)
        Me.cb8.Name = "cb8"
        Me.cb8.Size = New System.Drawing.Size(40, 18)
        Me.cb8.TabIndex = 51
        Me.cb8.Text = "08"
        Me.cb8.UseVisualStyleBackColor = True
        '
        'cb7
        '
        Me.cb7.AutoSize = True
        Me.cb7.Location = New System.Drawing.Point(204, 283)
        Me.cb7.Name = "cb7"
        Me.cb7.Size = New System.Drawing.Size(40, 18)
        Me.cb7.TabIndex = 50
        Me.cb7.Text = "07"
        Me.cb7.UseVisualStyleBackColor = True
        '
        'cb6
        '
        Me.cb6.AutoSize = True
        Me.cb6.Location = New System.Drawing.Point(204, 259)
        Me.cb6.Name = "cb6"
        Me.cb6.Size = New System.Drawing.Size(40, 18)
        Me.cb6.TabIndex = 49
        Me.cb6.Text = "06"
        Me.cb6.UseVisualStyleBackColor = True
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.Location = New System.Drawing.Point(204, 235)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(40, 18)
        Me.cb5.TabIndex = 48
        Me.cb5.Text = "05"
        Me.cb5.UseVisualStyleBackColor = True
        '
        'cb12
        '
        Me.cb12.AutoSize = True
        Me.cb12.Location = New System.Drawing.Point(204, 403)
        Me.cb12.Name = "cb12"
        Me.cb12.Size = New System.Drawing.Size(40, 18)
        Me.cb12.TabIndex = 55
        Me.cb12.Text = "12"
        Me.cb12.UseVisualStyleBackColor = True
        '
        'cb11
        '
        Me.cb11.AutoSize = True
        Me.cb11.Location = New System.Drawing.Point(204, 379)
        Me.cb11.Name = "cb11"
        Me.cb11.Size = New System.Drawing.Size(40, 18)
        Me.cb11.TabIndex = 54
        Me.cb11.Text = "11"
        Me.cb11.UseVisualStyleBackColor = True
        '
        'cb10
        '
        Me.cb10.AutoSize = True
        Me.cb10.Location = New System.Drawing.Point(204, 355)
        Me.cb10.Name = "cb10"
        Me.cb10.Size = New System.Drawing.Size(40, 18)
        Me.cb10.TabIndex = 53
        Me.cb10.Text = "10"
        Me.cb10.UseVisualStyleBackColor = True
        '
        'cb9
        '
        Me.cb9.AutoSize = True
        Me.cb9.Location = New System.Drawing.Point(204, 331)
        Me.cb9.Name = "cb9"
        Me.cb9.Size = New System.Drawing.Size(40, 18)
        Me.cb9.TabIndex = 52
        Me.cb9.Text = "09"
        Me.cb9.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(185, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Semitone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Perfect Interval"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(292, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Diminished/Augmented"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(19, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 14)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Unison"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(134, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 14)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "P1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(134, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 14)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "m2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(19, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 14)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Minor Second"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(134, 167)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 14)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "M2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(19, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 14)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Major Second"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Teal
        Me.Label16.Location = New System.Drawing.Point(134, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 14)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "m3"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(19, 191)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 14)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Minor Third"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Teal
        Me.Label18.Location = New System.Drawing.Point(134, 213)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 14)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "M3"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(19, 213)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 14)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Major Third"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Teal
        Me.Label20.Location = New System.Drawing.Point(134, 237)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 14)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "P4"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(19, 237)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 14)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Perfect Fourth"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Teal
        Me.Label22.Location = New System.Drawing.Point(134, 261)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 14)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "A4"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(19, 261)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 14)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Tritone"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Teal
        Me.Label24.Location = New System.Drawing.Point(134, 308)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(21, 14)
        Me.Label24.TabIndex = 74
        Me.Label24.Text = "m6"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(19, 308)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 14)
        Me.Label25.TabIndex = 73
        Me.Label25.Text = "Minor Sixth"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Teal
        Me.Label26.Location = New System.Drawing.Point(134, 332)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(21, 14)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "M6"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(19, 332)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 14)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "Major Sixth"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Teal
        Me.Label28.Location = New System.Drawing.Point(134, 356)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(21, 14)
        Me.Label28.TabIndex = 78
        Me.Label28.Text = "m7"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(19, 356)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(98, 14)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "Minor Seventh"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Teal
        Me.Label30.Location = New System.Drawing.Point(134, 380)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(21, 14)
        Me.Label30.TabIndex = 80
        Me.Label30.Text = "M7"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(19, 380)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 14)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "Major Seventh"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Teal
        Me.Label32.Location = New System.Drawing.Point(134, 404)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(21, 14)
        Me.Label32.TabIndex = 82
        Me.Label32.Text = "P8"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(19, 404)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(105, 14)
        Me.Label33.TabIndex = 81
        Me.Label33.Text = "Perfect Octave"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Olive
        Me.Label34.Location = New System.Drawing.Point(292, 381)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(21, 14)
        Me.Label34.TabIndex = 94
        Me.Label34.Text = "d8"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Olive
        Me.Label35.Location = New System.Drawing.Point(292, 357)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(21, 14)
        Me.Label35.TabIndex = 93
        Me.Label35.Text = "A6"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Olive
        Me.Label36.Location = New System.Drawing.Point(292, 333)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(21, 14)
        Me.Label36.TabIndex = 92
        Me.Label36.Text = "d7"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.Olive
        Me.Label37.Location = New System.Drawing.Point(292, 309)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(21, 14)
        Me.Label37.TabIndex = 91
        Me.Label37.Text = "A5"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Olive
        Me.Label38.Location = New System.Drawing.Point(292, 285)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(21, 14)
        Me.Label38.TabIndex = 90
        Me.Label38.Text = "d6"
        '
        'lblShort
        '
        Me.lblShort.AutoSize = True
        Me.lblShort.ForeColor = System.Drawing.Color.Olive
        Me.lblShort.Location = New System.Drawing.Point(292, 261)
        Me.lblShort.Name = "lblShort"
        Me.lblShort.Size = New System.Drawing.Size(21, 14)
        Me.lblShort.TabIndex = 89
        Me.lblShort.Text = "d5"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.Olive
        Me.Label40.Location = New System.Drawing.Point(292, 237)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(21, 14)
        Me.Label40.TabIndex = 88
        Me.Label40.Text = "A3"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.Olive
        Me.Label41.Location = New System.Drawing.Point(292, 213)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(21, 14)
        Me.Label41.TabIndex = 87
        Me.Label41.Text = "d4"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.Olive
        Me.Label42.Location = New System.Drawing.Point(292, 191)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(21, 14)
        Me.Label42.TabIndex = 86
        Me.Label42.Text = "A2"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.Olive
        Me.Label43.Location = New System.Drawing.Point(292, 167)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(21, 14)
        Me.Label43.TabIndex = 85
        Me.Label43.Text = "d3"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.Olive
        Me.Label44.Location = New System.Drawing.Point(292, 143)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(21, 14)
        Me.Label44.TabIndex = 84
        Me.Label44.Text = "A1"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Olive
        Me.Label45.Location = New System.Drawing.Point(292, 119)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(21, 14)
        Me.Label45.TabIndex = 83
        Me.Label45.Text = "d2"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(319, 381)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(126, 14)
        Me.Label46.TabIndex = 106
        Me.Label46.Text = "Diminished Octave"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(319, 357)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(112, 14)
        Me.Label47.TabIndex = 105
        Me.Label47.Text = "Augmented Sixth"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(319, 333)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(133, 14)
        Me.Label48.TabIndex = 104
        Me.Label48.Text = "Diminished Seventh"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(319, 309)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(112, 14)
        Me.Label49.TabIndex = 103
        Me.Label49.Text = "Augmented Fifth"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(319, 285)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(119, 14)
        Me.Label50.TabIndex = 102
        Me.Label50.Text = "Diminished Sixth"
        '
        'lblSpec
        '
        Me.lblSpec.AutoSize = True
        Me.lblSpec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpec.Location = New System.Drawing.Point(319, 261)
        Me.lblSpec.Name = "lblSpec"
        Me.lblSpec.Size = New System.Drawing.Size(119, 14)
        Me.lblSpec.TabIndex = 101
        Me.lblSpec.Text = "Diminished Fifth"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(319, 237)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(112, 14)
        Me.Label52.TabIndex = 100
        Me.Label52.Text = "Augmented Third"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(319, 213)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(126, 14)
        Me.Label53.TabIndex = 99
        Me.Label53.Text = "Diminished Fourth"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label54.Location = New System.Drawing.Point(319, 191)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(119, 14)
        Me.Label54.TabIndex = 98
        Me.Label54.Text = "Augmented Second"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label55.Location = New System.Drawing.Point(319, 167)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(119, 14)
        Me.Label55.TabIndex = 97
        Me.Label55.Text = "Diminished Third"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label56.Location = New System.Drawing.Point(319, 143)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(119, 14)
        Me.Label56.TabIndex = 96
        Me.Label56.Text = "Augmented Unison"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label57.Location = New System.Drawing.Point(319, 119)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(126, 14)
        Me.Label57.TabIndex = 95
        Me.Label57.Text = "Diminished Second"
        '
        'cb0
        '
        Me.cb0.AutoSize = True
        Me.cb0.Location = New System.Drawing.Point(204, 118)
        Me.cb0.Name = "cb0"
        Me.cb0.Size = New System.Drawing.Size(40, 18)
        Me.cb0.TabIndex = 107
        Me.cb0.Text = "00"
        Me.cb0.UseVisualStyleBackColor = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.ForeColor = System.Drawing.Color.Teal
        Me.Label58.Location = New System.Drawing.Point(134, 285)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(21, 14)
        Me.Label58.TabIndex = 109
        Me.Label58.Text = "P5"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label59.Location = New System.Drawing.Point(19, 285)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(98, 14)
        Me.Label59.TabIndex = 108
        Me.Label59.Text = "Perfect Fifth"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label60.Location = New System.Drawing.Point(319, 404)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(126, 14)
        Me.Label60.TabIndex = 111
        Me.Label60.Text = "Augmented Seventh"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ForeColor = System.Drawing.Color.Olive
        Me.Label61.Location = New System.Drawing.Point(292, 404)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(21, 14)
        Me.Label61.TabIndex = 110
        Me.Label61.Text = "A7"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 5000
        '
        'cmdShowChord
        '
        Me.cmdShowChord.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdShowChord.Location = New System.Drawing.Point(162, 428)
        Me.cmdShowChord.Name = "cmdShowChord"
        Me.cmdShowChord.Size = New System.Drawing.Size(116, 21)
        Me.cmdShowChord.TabIndex = 112
        Me.cmdShowChord.Text = "Show Chord"
        Me.cmdShowChord.UseVisualStyleBackColor = True
        '
        'frmChordBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 457)
        Me.Controls.Add(Me.cmdShowChord)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.cb0)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.lblSpec)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.lblShort)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cb12)
        Me.Controls.Add(Me.cb11)
        Me.Controls.Add(Me.cb10)
        Me.Controls.Add(Me.cb9)
        Me.Controls.Add(Me.cb8)
        Me.Controls.Add(Me.cb7)
        Me.Controls.Add(Me.cb6)
        Me.Controls.Add(Me.cb5)
        Me.Controls.Add(Me.cb4)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.cmdSize)
        Me.Controls.Add(Me.chkOnTop)
        Me.Controls.Add(Me.chkAutoDisplay)
        Me.Controls.Add(Me.cmdShow)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbIntervals)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSymbol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbQuick)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbRoot)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChordBuilder"
        Me.Text = "Chorder - Chord Builder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbRoot As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbQuick As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSymbol As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbIntervals As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdShow As Button
    Friend WithEvents chkAutoDisplay As CheckBox
    Friend WithEvents chkOnTop As CheckBox
    Friend WithEvents cmdSize As Button
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb8 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb12 As CheckBox
    Friend WithEvents cb11 As CheckBox
    Friend WithEvents cb10 As CheckBox
    Friend WithEvents cb9 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents lblShort As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents lblSpec As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents cb0 As CheckBox
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents cmdShowChord As Button
End Class
