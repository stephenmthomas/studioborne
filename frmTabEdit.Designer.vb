<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabEdit
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
        Me.cmdAddChord = New System.Windows.Forms.Button()
        Me.cmdDraw = New System.Windows.Forms.Button()
        Me.txtTab = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkOnTop = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdAddChord
        '
        Me.cmdAddChord.Location = New System.Drawing.Point(726, 5)
        Me.cmdAddChord.Name = "cmdAddChord"
        Me.cmdAddChord.Size = New System.Drawing.Size(88, 20)
        Me.cmdAddChord.TabIndex = 60
        Me.cmdAddChord.Text = "Add Chord"
        Me.cmdAddChord.UseVisualStyleBackColor = True
        '
        'cmdDraw
        '
        Me.cmdDraw.Location = New System.Drawing.Point(820, 5)
        Me.cmdDraw.Name = "cmdDraw"
        Me.cmdDraw.Size = New System.Drawing.Size(137, 20)
        Me.cmdDraw.TabIndex = 59
        Me.cmdDraw.Text = "Generate Tab"
        Me.cmdDraw.UseVisualStyleBackColor = True
        '
        'txtTab
        '
        Me.txtTab.Location = New System.Drawing.Point(6, 31)
        Me.txtTab.Multiline = True
        Me.txtTab.Name = "txtTab"
        Me.txtTab.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTab.Size = New System.Drawing.Size(951, 475)
        Me.txtTab.TabIndex = 58
        Me.txtTab.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "TABLATURE:"
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(910, 507)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(47, 18)
        Me.chkOnTop.TabIndex = 61
        Me.chkOnTop.Text = "Top"
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'frmTabEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(961, 525)
        Me.Controls.Add(Me.chkOnTop)
        Me.Controls.Add(Me.cmdAddChord)
        Me.Controls.Add(Me.cmdDraw)
        Me.Controls.Add(Me.txtTab)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTabEdit"
        Me.Text = "Tab Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdAddChord As Button
    Friend WithEvents cmdDraw As Button
    Friend WithEvents txtTab As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkOnTop As CheckBox
End Class
