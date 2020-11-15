<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgressor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgressor))
        Me.cbProgList = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbProgressions = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtProg = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.chkFret = New System.Windows.Forms.CheckBox()
        Me.chkKey = New System.Windows.Forms.CheckBox()
        Me.txtCycles = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbProgList
        '
        Me.cbProgList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgList.FormattingEnabled = True
        Me.cbProgList.Items.AddRange(New Object() {"I,IV,V", "I,V,vi,IV", "vi,V,IV,V", "i,VII,III,VI", "ii,V,I", "I,V,vi,iii,IV,I,IV,V", "i,VII,IV,IV", "I,v,v,ii", "I,vi,IV,V", "IV,I,IV,V", "I,V,vi,IV"})
        Me.cbProgList.Location = New System.Drawing.Point(6, 111)
        Me.cbProgList.Name = "cbProgList"
        Me.cbProgList.Size = New System.Drawing.Size(298, 22)
        Me.cbProgList.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(301, 14)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "POPULAR PROGRESSIONS: (For reference only)"
        '
        'cbProgressions
        '
        Me.cbProgressions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgressions.FormattingEnabled = True
        Me.cbProgressions.Items.AddRange(New Object() {"Popular Kid", "Sensitive One", "Stirring Hope", "Drama Resolution", "Jazz Cat", "The Canon", "Chris Issac - Wicked Game", "Coldplay - Clocks", "Doo Wop Progression (very popular)", "Oasis - Don't Look Back", "The Cure - A Letter to Elise"})
        Me.cbProgressions.Location = New System.Drawing.Point(6, 139)
        Me.cbProgressions.Name = "cbProgressions"
        Me.cbProgressions.Size = New System.Drawing.Size(298, 22)
        Me.cbProgressions.TabIndex = 59
        '
        'Timer1
        '
        '
        'txtProg
        '
        Me.txtProg.Location = New System.Drawing.Point(6, 23)
        Me.txtProg.Name = "txtProg"
        Me.txtProg.Size = New System.Drawing.Size(136, 20)
        Me.txtProg.TabIndex = 68
        Me.txtProg.Text = "1,4,5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 14)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "CHORD PROGRESSION:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "SPEED (BPM):"
        '
        'txtSpeed
        '
        Me.txtSpeed.Location = New System.Drawing.Point(148, 23)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(88, 20)
        Me.txtSpeed.TabIndex = 70
        Me.txtSpeed.Text = "100"
        '
        'chkFret
        '
        Me.chkFret.AutoSize = True
        Me.chkFret.Checked = True
        Me.chkFret.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFret.Location = New System.Drawing.Point(6, 49)
        Me.chkFret.Name = "chkFret"
        Me.chkFret.Size = New System.Drawing.Size(145, 18)
        Me.chkFret.TabIndex = 71
        Me.chkFret.Text = "Show on Fretboard"
        Me.chkFret.UseVisualStyleBackColor = True
        '
        'chkKey
        '
        Me.chkKey.AutoSize = True
        Me.chkKey.Checked = True
        Me.chkKey.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKey.Location = New System.Drawing.Point(6, 63)
        Me.chkKey.Name = "chkKey"
        Me.chkKey.Size = New System.Drawing.Size(138, 18)
        Me.chkKey.TabIndex = 72
        Me.chkKey.Text = "Show on Keyboard"
        Me.chkKey.UseVisualStyleBackColor = True
        '
        'txtCycles
        '
        Me.txtCycles.Location = New System.Drawing.Point(242, 23)
        Me.txtCycles.Name = "txtCycles"
        Me.txtCycles.Size = New System.Drawing.Size(62, 20)
        Me.txtCycles.TabIndex = 74
        Me.txtCycles.Text = "2500"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "CYCLES:"
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(241, 53)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(63, 24)
        Me.cmdStop.TabIndex = 75
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(172, 53)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(63, 24)
        Me.cmdStart.TabIndex = 76
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'frmProgressor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(310, 169)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.txtCycles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkKey)
        Me.Controls.Add(Me.chkFret)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbProgList)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbProgressions)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProgressor"
        Me.Text = "Progressor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbProgList As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbProgressions As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtProg As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSpeed As TextBox
    Friend WithEvents chkFret As CheckBox
    Friend WithEvents chkKey As CheckBox
    Friend WithEvents txtCycles As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdStop As Button
    Friend WithEvents cmdStart As Button
End Class
