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
        Me.cbQuick.Items.AddRange(New Object() {"Major Triad", "Major Sixth", "Dominant Seventh", "Major Seventh", "Augmented Triad", "Augmented Seventh", "Minor Triad", "Minor Sixth", "Minor Seventh", "Minor-Major Seventh", "Diminished Triad", "Diminished Seventh", "Half-Diminished Seventh", "Suspended Fourth", "Suspended Second"})
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
        Me.cbSymbol.Items.AddRange(New Object() {"Δ", "maj6", "dom7", "maj7", "aug", "aug7", "min", "min6", "min7", "min/maj7", "dim", "dim7", "°7", "sus4", "sus2"})
        Me.cbSymbol.Location = New System.Drawing.Point(252, 21)
        Me.cbSymbol.Name = "cbSymbol"
        Me.cbSymbol.Size = New System.Drawing.Size(74, 22)
        Me.cbSymbol.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "INTERVALS:"
        '
        'cbIntervals
        '
        Me.cbIntervals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntervals.FormattingEnabled = True
        Me.cbIntervals.Items.AddRange(New Object() {"0,4,7", "0,4,7,9", "0,4,7,10", "0,4,7,11", "0,4,8", "0,4,8,10", "0,3,7", "0,3,7,9", "0,3,7,10", "0,3,7,11", "0,3,6", "0,3,6,9", "0,3,6,10", "0,5,7", "0,2,7"})
        Me.cbIntervals.Location = New System.Drawing.Point(332, 21)
        Me.cbIntervals.Name = "cbIntervals"
        Me.cbIntervals.Size = New System.Drawing.Size(78, 22)
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
        Me.chkAutoDisplay.Location = New System.Drawing.Point(314, 66)
        Me.chkAutoDisplay.Name = "chkAutoDisplay"
        Me.chkAutoDisplay.Size = New System.Drawing.Size(89, 18)
        Me.chkAutoDisplay.TabIndex = 30
        Me.chkAutoDisplay.Text = "Auto Show"
        Me.chkAutoDisplay.UseVisualStyleBackColor = True
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(368, 82)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(47, 18)
        Me.chkOnTop.TabIndex = 42
        Me.chkOnTop.Text = "Top"
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'frmChordBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 101)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmChordBuilder"
        Me.Text = "Chord Builder"
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
End Class
