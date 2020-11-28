<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGtrTune
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTune = New System.Windows.Forms.ComboBox()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cbTuning = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurTune = New System.Windows.Forms.TextBox()
        Me.txtNewTune = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStrings = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Common Tunings:"
        '
        'cbTune
        '
        Me.cbTune.FormattingEnabled = True
        Me.cbTune.Items.AddRange(New Object() {"Guitar - Standard", "Bass - Standard", "Ajayu", "Akkordolia", "Baglamas", "Bajo Quinto", "Bajo Quinto [Alt]", "Balalaika", "Bandolin", "Banjo - Cumberland", "Banjo - Open C", "Banjo - Sawmill", "Banjo - Standard", "Bass - 5 String", "Bass - 6 String [Alt]", "Bass - 6 String [Common]", "Bass - Drop D", "Bass - Standard", "Bouzouki", "Bouzouki - Irish", "Cello", "Charango", "Charangón", "Cittern", "Cuk", "Cümbüş", "Daruan", "Double Bass - 5 String", "Double Bass - Standard", "Dulcimer", "Erhu", "Fiddle - Cajun", "Fiddle - Standard", "Guitar - 7 String", "Guitar - Dobro", "Guitar - Double Drop D", "Guitar - Drop C", "Guitar - Drop D", "Guitar - Irish [Dad-Gad]", "Guitar - José González", "Guitar - Lute", "Guitar - Open A", "Guitar - Open B", "Guitar - Open C", "Guitar - Open D", "Guitar - Open E", "Guitar - Open F", "Guitar - Open G", "Guitar - Portuguese", "Guitar - Standard", "Guitarrón", "Hardingfele", "Hurdy Gurdy", "Jarana Jarocha", "Jarana Jarocha [Alt]", "Kamancheh", "Komuz", "Laúd", "Laúd - Cuban", "Lili'u", "Lute", "Lute - Medieval", "Mandolin", "Oud", "Rajao", "Ronroco - Argentine", "Ronroco - Bolivian", "Ronroco - Chilean", "Setar", "Shamisen", "Sitar", "Tar", "Tres", "Ukulele - Baritone", "Ukulele - Bass", "Ukulele - Standard", "Vihuela", "Viola", "Violin", "Violin - Alternate"})
        Me.cbTune.Location = New System.Drawing.Point(4, 24)
        Me.cbTune.Name = "cbTune"
        Me.cbTune.Size = New System.Drawing.Size(251, 22)
        Me.cbTune.TabIndex = 8
        '
        'cmdHelp
        '
        Me.cmdHelp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.ForeColor = System.Drawing.Color.Red
        Me.cmdHelp.Location = New System.Drawing.Point(6, 136)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(32, 27)
        Me.cmdHelp.TabIndex = 60
        Me.cmdHelp.Text = "?"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cbTuning
        '
        Me.cbTuning.FormattingEnabled = True
        Me.cbTuning.Items.AddRange(New Object() {"E,A,D,G,B,E", "E,A,D,G", "A,E,A,C#,F#", "F,A,C,F", "D,A,D", "A,A,D,D,G", "G,C,C,F,F", "E,A,D,E,E,A", "E,A,D,F#,B", "G,E,A,D,E", "G,C,G,C,E", "G,D,G,C,D", "G,D,G,B,D", "B,E,A,D,G", "E,A,D,G,B,E", "B,E,A,D,G,C", "D,A,D,G", "E,A,D,G", "C,F,A,D", "G,D,A,E", "C,G,D,A", "G,C,E,A,E", "D,G,B,E,B", "C,G,C,G,C,G", "G,B,E", "A,B,E,A,D,G", "D,A,D,A", "C,E,A,D,G", "E,A,D,G", "A,A,D", "D,A", "F,C,G,D", "G,D,A,E", "B,E,A,D,G,B,E", "G,B,D,G,B,D", "D,A,D,G,B,D", "C,G,C,F,A,D", "D,A,D,G,B,E", "D,A,D,G,A,D", "D,A,D,F#,B,E", "E,A,D,F#,B,E", "E,A,E,A,C#,E", "B,F#,B,F#,B,D#", "C,G,C,G,C,E", "D,A,D,F#,A,D", "E,B,E,G#,B,E", "C,F,C,F,A,F", "D,G,D,G,B,D", "D,A,B,E,A,B", "E,A,D,G,B,E", "A,D,G,C,E,A", "A,D,A,E", "G,C,G,C,C", "A,D,G,B,E", "G,C,E,A,G", "D,A,D,A", "A,E,A", "G#,C#,F#,B,E,A", "D,A,E,B,F#,C#", "G,C,E,A", "E,A,D,G,B,E", "G,C,F,A,D,G", "G,D,A,E", "C,F,A,D,G,C", "D,G,C,E,A", "D,G,B,E,B", "C,F,A,D,A", "G,C,E,A,E", "C,C,G,C", "D,G,D", "C,G,C,F", "C,G,C", "G,C,E", "D,G,B,E", "E,A,D,G", "G,C,E,A", "A,D,G,B,E", "C,G,D,A", "G,D,A,E", "F,C,G,D"})
        Me.cbTuning.Location = New System.Drawing.Point(121, 4)
        Me.cbTuning.Name = "cbTuning"
        Me.cbTuning.Size = New System.Drawing.Size(134, 22)
        Me.cbTuning.TabIndex = 61
        Me.cbTuning.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 14)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Current Tuning:"
        '
        'txtCurTune
        '
        Me.txtCurTune.Location = New System.Drawing.Point(121, 58)
        Me.txtCurTune.Name = "txtCurTune"
        Me.txtCurTune.ReadOnly = True
        Me.txtCurTune.Size = New System.Drawing.Size(134, 20)
        Me.txtCurTune.TabIndex = 63
        '
        'txtNewTune
        '
        Me.txtNewTune.Location = New System.Drawing.Point(121, 81)
        Me.txtNewTune.Name = "txtNewTune"
        Me.txtNewTune.Size = New System.Drawing.Size(134, 20)
        Me.txtNewTune.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(31, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "New Tuning:"
        '
        'txtStrings
        '
        Me.txtStrings.Location = New System.Drawing.Point(214, 104)
        Me.txtStrings.Name = "txtStrings"
        Me.txtStrings.ReadOnly = True
        Me.txtStrings.Size = New System.Drawing.Size(41, 20)
        Me.txtStrings.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(124, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 14)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "No. Strings:"
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(177, 136)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(78, 27)
        Me.cmdAccept.TabIndex = 68
        Me.cmdAccept.Text = "Accept"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(93, 136)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(78, 27)
        Me.cmdCancel.TabIndex = 69
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmGtrTune
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(259, 168)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.txtStrings)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNewTune)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurTune)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbTuning)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cbTune)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGtrTune"
        Me.Text = "Fretboard Tuning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTune As ComboBox
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cbTuning As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurTune As TextBox
    Friend WithEvents txtNewTune As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStrings As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdAccept As Button
    Friend WithEvents cmdCancel As Button
End Class
