<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.tTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.txtTrans = New System.Windows.Forms.TextBox()
        Me.chkTabRoot = New System.Windows.Forms.CheckBox()
        Me.chkTones = New System.Windows.Forms.CheckBox()
        Me.chkNoteIcon = New System.Windows.Forms.CheckBox()
        Me.chkNoteText = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkExpanded = New System.Windows.Forms.CheckBox()
        Me.chkFretload = New System.Windows.Forms.CheckBox()
        Me.chkKeyload = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTransparency = New System.Windows.Forms.CheckBox()
        Me.chkOnTop = New System.Windows.Forms.CheckBox()
        Me.chkAutoChord = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbColNote = New System.Windows.Forms.ComboBox()
        Me.cbColRoot = New System.Windows.Forms.ComboBox()
        Me.txtTuning = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFretMax = New System.Windows.Forms.TextBox()
        Me.txtFretMin = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Amount:"
        Me.tTip.SetToolTip(Me.Label1, "Setting the guitar fret range limits the area where notes will be drawn on the fr" &
        "etboard.")
        '
        'cmdAbout
        '
        Me.cmdAbout.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.Color.Red
        Me.cmdAbout.Location = New System.Drawing.Point(7, 325)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(32, 27)
        Me.cmdAbout.TabIndex = 59
        Me.cmdAbout.Text = "Ω"
        Me.tTip.SetToolTip(Me.cmdAbout, "About Studioborne")
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'txtTrans
        '
        Me.txtTrans.Location = New System.Drawing.Point(177, 44)
        Me.txtTrans.Name = "txtTrans"
        Me.txtTrans.Size = New System.Drawing.Size(43, 20)
        Me.txtTrans.TabIndex = 60
        Me.txtTrans.Text = "0.5"
        Me.txtTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tTip.SetToolTip(Me.txtTrans, "Transparency Value")
        '
        'chkTabRoot
        '
        Me.chkTabRoot.AutoSize = True
        Me.chkTabRoot.Location = New System.Drawing.Point(6, 62)
        Me.chkTabRoot.Name = "chkTabRoot"
        Me.chkTabRoot.Size = New System.Drawing.Size(89, 18)
        Me.chkTabRoot.TabIndex = 64
        Me.chkTabRoot.Text = "Tab Roots"
        Me.tTip.SetToolTip(Me.chkTabRoot, "If selected, generate tabs will highlight the root note.")
        Me.chkTabRoot.UseVisualStyleBackColor = True
        '
        'chkTones
        '
        Me.chkTones.AutoSize = True
        Me.chkTones.Location = New System.Drawing.Point(6, 90)
        Me.chkTones.Name = "chkTones"
        Me.chkTones.Size = New System.Drawing.Size(110, 18)
        Me.chkTones.TabIndex = 76
        Me.chkTones.Text = "Tone Overlay"
        Me.tTip.SetToolTip(Me.chkTones, "Shows semitone relative to the root inside note blips.")
        Me.chkTones.UseVisualStyleBackColor = True
        '
        'chkNoteIcon
        '
        Me.chkNoteIcon.AutoSize = True
        Me.chkNoteIcon.Checked = True
        Me.chkNoteIcon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoteIcon.Location = New System.Drawing.Point(6, 19)
        Me.chkNoteIcon.Name = "chkNoteIcon"
        Me.chkNoteIcon.Size = New System.Drawing.Size(152, 18)
        Me.chkNoteIcon.TabIndex = 75
        Me.chkNoteIcon.Text = "Note Blip Graphics"
        Me.tTip.SetToolTip(Me.chkNoteIcon, "Displays a graphic for note blips instead of a solid square.  Not sure why this i" &
        "s even an option. . .")
        Me.chkNoteIcon.UseVisualStyleBackColor = True
        '
        'chkNoteText
        '
        Me.chkNoteText.AutoSize = True
        Me.chkNoteText.Location = New System.Drawing.Point(6, 75)
        Me.chkNoteText.Name = "chkNoteText"
        Me.chkNoteText.Size = New System.Drawing.Size(110, 18)
        Me.chkNoteText.TabIndex = 74
        Me.chkNoteText.Text = "Note Overlay"
        Me.tTip.SetToolTip(Me.chkNoteText, "Shows notes (A, A#, etc.) inside note blips.")
        Me.chkNoteText.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Root Color:"
        Me.tTip.SetToolTip(Me.Label2, "Setting the guitar fret range limits the area where notes will be drawn on the fr" &
        "etboard.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(122, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Note Color:"
        Me.tTip.SetToolTip(Me.Label3, "Setting the guitar fret range limits the area where notes will be drawn on the fr" &
        "etboard.")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(122, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 14)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "FRET RANGE:"
        Me.tTip.SetToolTip(Me.Label11, "Setting the fret range limits the area where notes will be drawn on the fretboard" &
        ".")
        '
        'chkExpanded
        '
        Me.chkExpanded.AutoSize = True
        Me.chkExpanded.Location = New System.Drawing.Point(6, 77)
        Me.chkExpanded.Name = "chkExpanded"
        Me.chkExpanded.Size = New System.Drawing.Size(124, 18)
        Me.chkExpanded.TabIndex = 65
        Me.chkExpanded.Text = "Start Expanded"
        Me.tTip.SetToolTip(Me.chkExpanded, "Sets if the main form will start in the expanded state or not.")
        Me.chkExpanded.UseVisualStyleBackColor = True
        '
        'chkFretload
        '
        Me.chkFretload.AutoSize = True
        Me.chkFretload.Location = New System.Drawing.Point(6, 91)
        Me.chkFretload.Name = "chkFretload"
        Me.chkFretload.Size = New System.Drawing.Size(159, 18)
        Me.chkFretload.TabIndex = 66
        Me.chkFretload.Text = "Auto Load Fretboard"
        Me.tTip.SetToolTip(Me.chkFretload, "Sets if the main form will start in the expanded state or not.")
        Me.chkFretload.UseVisualStyleBackColor = True
        '
        'chkKeyload
        '
        Me.chkKeyload.AutoSize = True
        Me.chkKeyload.Location = New System.Drawing.Point(6, 105)
        Me.chkKeyload.Name = "chkKeyload"
        Me.chkKeyload.Size = New System.Drawing.Size(152, 18)
        Me.chkKeyload.TabIndex = 67
        Me.chkKeyload.Text = "Auto Load Keyboard"
        Me.tTip.SetToolTip(Me.chkKeyload, "Sets if the main form will start in the expanded state or not.")
        Me.chkKeyload.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkKeyload)
        Me.GroupBox1.Controls.Add(Me.chkFretload)
        Me.GroupBox1.Controls.Add(Me.chkExpanded)
        Me.GroupBox1.Controls.Add(Me.chkTabRoot)
        Me.GroupBox1.Controls.Add(Me.txtTrans)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkTransparency)
        Me.GroupBox1.Controls.Add(Me.chkOnTop)
        Me.GroupBox1.Controls.Add(Me.chkAutoChord)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 127)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General Options"
        '
        'chkTransparency
        '
        Me.chkTransparency.AutoSize = True
        Me.chkTransparency.Location = New System.Drawing.Point(6, 47)
        Me.chkTransparency.Name = "chkTransparency"
        Me.chkTransparency.Size = New System.Drawing.Size(110, 18)
        Me.chkTransparency.TabIndex = 53
        Me.chkTransparency.Text = "Transparency"
        Me.chkTransparency.UseVisualStyleBackColor = True
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(6, 33)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(117, 18)
        Me.chkOnTop.TabIndex = 52
        Me.chkOnTop.Text = "Always on Top"
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'chkAutoChord
        '
        Me.chkAutoChord.AutoSize = True
        Me.chkAutoChord.Checked = True
        Me.chkAutoChord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoChord.Location = New System.Drawing.Point(6, 19)
        Me.chkAutoChord.Name = "chkAutoChord"
        Me.chkAutoChord.Size = New System.Drawing.Size(138, 18)
        Me.chkAutoChord.TabIndex = 47
        Me.chkAutoChord.Text = "Auto Show Chords"
        Me.chkAutoChord.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbColNote)
        Me.GroupBox2.Controls.Add(Me.cbColRoot)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkTones)
        Me.GroupBox2.Controls.Add(Me.chkNoteIcon)
        Me.GroupBox2.Controls.Add(Me.chkNoteText)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 114)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display Options"
        '
        'cbColNote
        '
        Me.cbColNote.FormattingEnabled = True
        Me.cbColNote.Items.AddRange(New Object() {"Red", "Green", "Yellow", "Blue"})
        Me.cbColNote.Location = New System.Drawing.Point(125, 52)
        Me.cbColNote.Name = "cbColNote"
        Me.cbColNote.Size = New System.Drawing.Size(81, 22)
        Me.cbColNote.TabIndex = 81
        '
        'cbColRoot
        '
        Me.cbColRoot.FormattingEnabled = True
        Me.cbColRoot.Items.AddRange(New Object() {"Red", "Green", "Yellow", "Blue"})
        Me.cbColRoot.Location = New System.Drawing.Point(28, 52)
        Me.cbColRoot.Name = "cbColRoot"
        Me.cbColRoot.Size = New System.Drawing.Size(81, 22)
        Me.cbColRoot.TabIndex = 80
        '
        'txtTuning
        '
        Me.txtTuning.Location = New System.Drawing.Point(10, 32)
        Me.txtTuning.Name = "txtTuning"
        Me.txtTuning.Size = New System.Drawing.Size(90, 20)
        Me.txtTuning.TabIndex = 66
        Me.txtTuning.Text = "E,A,D,G,B,E"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "TUNING:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtFretMax)
        Me.GroupBox3.Controls.Add(Me.txtFretMin)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtTuning)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 63)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fretboard Options"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(158, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 14)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "to"
        '
        'txtFretMax
        '
        Me.txtFretMax.Location = New System.Drawing.Point(183, 33)
        Me.txtFretMax.Name = "txtFretMax"
        Me.txtFretMax.Size = New System.Drawing.Size(29, 20)
        Me.txtFretMax.TabIndex = 73
        Me.txtFretMax.Text = "24"
        Me.txtFretMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFretMin
        '
        Me.txtFretMin.Location = New System.Drawing.Point(125, 33)
        Me.txtFretMin.Name = "txtFretMin"
        Me.txtFretMin.Size = New System.Drawing.Size(29, 20)
        Me.txtFretMin.TabIndex = 72
        Me.txtFretMin.Text = "0"
        Me.txtFretMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(241, 363)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tTip As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkTransparency As CheckBox
    Friend WithEvents chkOnTop As CheckBox
    Friend WithEvents chkAutoChord As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTrans As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdAbout As Button
    Friend WithEvents chkTabRoot As CheckBox
    Friend WithEvents cbColRoot As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkTones As CheckBox
    Friend WithEvents chkNoteIcon As CheckBox
    Friend WithEvents chkNoteText As CheckBox
    Friend WithEvents txtTuning As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbColNote As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFretMax As TextBox
    Friend WithEvents txtFretMin As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkExpanded As CheckBox
    Friend WithEvents chkKeyload As CheckBox
    Friend WithEvents chkFretload As CheckBox
End Class
