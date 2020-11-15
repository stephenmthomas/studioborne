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
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "MODE/SCALE:"
        '
        'cbMode
        '
        Me.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMode.FormattingEnabled = True
        Me.cbMode.Items.AddRange(New Object() {"Major (Ionian)", "Dorian", "Phrygian", "Phrygian Dominant", "Lydian", "Mixolydian", "Minor (Aeolian)", "Locrian", "Melodic Minor", "Harmonic Minor", "Super Locrian", "Major Pentatonic*", "Minor Pentatonic*", "Blues Scale*", "Chromatic*"})
        Me.cbMode.Location = New System.Drawing.Point(152, 20)
        Me.cbMode.Name = "cbMode"
        Me.cbMode.Size = New System.Drawing.Size(141, 22)
        Me.cbMode.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "KEY:"
        '
        'cbKey
        '
        Me.cbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKey.FormattingEnabled = True
        Me.cbKey.Items.AddRange(New Object() {"A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"})
        Me.cbKey.Location = New System.Drawing.Point(5, 20)
        Me.cbKey.Name = "cbKey"
        Me.cbKey.Size = New System.Drawing.Size(141, 22)
        Me.cbKey.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "INTERVALS:"
        '
        'cbInt
        '
        Me.cbInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInt.FormattingEnabled = True
        Me.cbInt.Items.AddRange(New Object() {"2,2,1,2,2,2,1", "2,1,2,2,2,1,2", "1,2,2,2,1,2,2", "1,3,1,2,1,2,2", "2,2,2,1,2,2,1", "2,2,1,2,2,1,2", "2,1,2,2,1,2,2", "1,2,2,1,2,2,2", "2,1,2,2,2,2,1", "2,1,2,2,1,3,1", "1,2,1,2,2,2,2", "2,2,3,2,3", "3,2,2,3,2", "3,2,1,1,3,2", "1,1,1,1,1,1,1,1,1,1,1,1"})
        Me.cbInt.Location = New System.Drawing.Point(299, 20)
        Me.cbInt.Name = "cbInt"
        Me.cbInt.Size = New System.Drawing.Size(141, 22)
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
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SCALE NOTES:"
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
        Me.Label9.Location = New System.Drawing.Point(153, 44)
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
        Me.txtVals.Size = New System.Drawing.Size(141, 20)
        Me.txtVals.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 14)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "RELATIVE SEMITONES:"
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(446, 90)
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
End Class
