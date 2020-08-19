<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFretboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFretboard))
        Me.pbFretboard = New System.Windows.Forms.PictureBox()
        Me.chkOnTop = New System.Windows.Forms.CheckBox()
        CType(Me.pbFretboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbFretboard
        '
        Me.pbFretboard.Image = CType(resources.GetObject("pbFretboard.Image"), System.Drawing.Image)
        Me.pbFretboard.Location = New System.Drawing.Point(30, 12)
        Me.pbFretboard.Name = "pbFretboard"
        Me.pbFretboard.Size = New System.Drawing.Size(859, 186)
        Me.pbFretboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbFretboard.TabIndex = 0
        Me.pbFretboard.TabStop = False
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(872, 198)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(47, 18)
        Me.chkOnTop.TabIndex = 41
        Me.chkOnTop.Text = "Top"
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'frmFretboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(919, 216)
        Me.Controls.Add(Me.chkOnTop)
        Me.Controls.Add(Me.pbFretboard)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFretboard"
        Me.Text = "Fretboard"
        CType(Me.pbFretboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbFretboard As PictureBox
    Friend WithEvents chkOnTop As CheckBox
End Class
