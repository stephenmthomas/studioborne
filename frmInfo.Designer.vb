<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInfo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbKey = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbInt = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtChord = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVals = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkOnTop = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdMaximize = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "MODE/SCALE:"
        '
        'cbMode
        '
        Me.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMode.Enabled = False
        Me.cbMode.FormattingEnabled = True
        Me.cbMode.Items.AddRange(New Object() {"Major (Ionian)", "Dorian", "Phrygian", "Phrygian Dominant", "Lydian", "Mixolydian", "Minor (Aeolian)", "Locrian", "Melodic Minor", "Harmonic Minor", "Super Locrian", "Major Pentatonic*", "Minor Pentatonic*", "Blues Scale*", "Chromatic*"})
        Me.cbMode.Location = New System.Drawing.Point(80, 20)
        Me.cbMode.Name = "cbMode"
        Me.cbMode.Size = New System.Drawing.Size(141, 22)
        Me.cbMode.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "KEY:"
        '
        'cbKey
        '
        Me.cbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKey.Enabled = False
        Me.cbKey.FormattingEnabled = True
        Me.cbKey.Items.AddRange(New Object() {"A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"})
        Me.cbKey.Location = New System.Drawing.Point(5, 20)
        Me.cbKey.Name = "cbKey"
        Me.cbKey.Size = New System.Drawing.Size(69, 22)
        Me.cbKey.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "INTERVALS:"
        '
        'cbInt
        '
        Me.cbInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInt.Enabled = False
        Me.cbInt.FormattingEnabled = True
        Me.cbInt.Items.AddRange(New Object() {"2,2,1,2,2,2,1", "2,1,2,2,2,1,2", "1,2,2,2,1,2,2", "1,3,1,2,1,2,2", "2,2,2,1,2,2,1", "2,2,1,2,2,1,2", "2,1,2,2,1,2,2", "1,2,2,1,2,2,2", "2,1,2,2,2,2,1", "2,1,2,2,1,3,1", "1,2,1,2,2,2,2", "2,2,3,2,3", "3,2,2,3,2", "3,2,1,1,3,2", "1,1,1,1,1,1,1,1,1,1,1,1"})
        Me.cbInt.Location = New System.Drawing.Point(227, 20)
        Me.cbInt.Name = "cbInt"
        Me.cbInt.Size = New System.Drawing.Size(134, 22)
        Me.cbInt.TabIndex = 8
        '
        'txtNotes
        '
        Me.txtNotes.Enabled = False
        Me.txtNotes.Location = New System.Drawing.Point(5, 60)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(141, 20)
        Me.txtNotes.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "NOTES:"
        '
        'txtChord
        '
        Me.txtChord.Enabled = False
        Me.txtChord.Location = New System.Drawing.Point(152, 60)
        Me.txtChord.Name = "txtChord"
        Me.txtChord.Size = New System.Drawing.Size(141, 20)
        Me.txtChord.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(149, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 14)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "LAST CHORD:"
        '
        'txtVals
        '
        Me.txtVals.Enabled = False
        Me.txtVals.Location = New System.Drawing.Point(299, 60)
        Me.txtVals.Name = "txtVals"
        Me.txtVals.Size = New System.Drawing.Size(135, 20)
        Me.txtVals.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 14)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "LAST SEMITONES:"
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(394, 1)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(47, 18)
        Me.chkOnTop.TabIndex = 42
        Me.chkOnTop.Text = "Top"
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(2, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 14)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "INFORMATION:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(2, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 14)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "LOG:"
        '
        'cmdMaximize
        '
        Me.cmdMaximize.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMaximize.ForeColor = System.Drawing.Color.Green
        Me.cmdMaximize.Location = New System.Drawing.Point(366, 20)
        Me.cmdMaximize.Name = "cmdMaximize"
        Me.cmdMaximize.Size = New System.Drawing.Size(66, 21)
        Me.cmdMaximize.TabIndex = 47
        Me.cmdMaximize.Text = "Expand"
        Me.cmdMaximize.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(4, 222)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(428, 130)
        Me.txtLog.TabIndex = 48
        Me.txtLog.WordWrap = False
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(5, 98)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInfo.Size = New System.Drawing.Size(429, 114)
        Me.txtInfo.TabIndex = 49
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 358)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.cmdMaximize)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkOnTop)
        Me.Controls.Add(Me.txtChord)
        Me.Controls.Add(Me.Label9)
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
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmInfo"
        Me.Text = "Info Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents cbMode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbKey As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbInt As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtChord As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVals As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkOnTop As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdMaximize As Button
    Friend WithEvents txtLog As TextBox
    Friend WithEvents txtInfo As TextBox
End Class
