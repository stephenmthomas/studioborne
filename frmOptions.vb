Public Class frmOptions
    Private Sub chkTransparency_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransparency.CheckedChanged
        Dim tVal As Single = 0.5
        If chkTransparency.Checked = True Then
            oTransparent = True
            If IsNumeric(txtTrans.Text) = True Then
                If Val(txtTrans.Text) < 0.2 Then
                    tVal = 0.2
                    txtTrans.Text = tVal
                Else
                    tVal = txtTrans.Text
                End If
            Else
                txtTrans.Text = "0.5"
            End If
            Transparency = tVal
            RefreshAllForms()
        ElseIf chkTransparency.Checked = False Then
            oTransparent = False
            Me.Opacity = 1
            RefreshAllForms()
        End If
    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        oOnTop = chkOnTop.Checked

        Me.TopMost = chkOnTop.Checked
        frmTabTool.TopMost = chkOnTop.Checked
        frmProgressor.TopMost = chkOnTop.Checked
        frmInfo.TopMost = chkOnTop.Checked
        frmKeyboard.chkOnTop.Checked = chkOnTop.Checked
        frmFretboard.chkOnTop.Checked = chkOnTop.Checked
        frmChordBuilder.chkOnTop.Checked = chkOnTop.Checked
        frmKeyTriad.chkOnTop.Checked = chkOnTop.Checked


    End Sub

    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkOnTop.Checked = oOnTop
        txtTrans.Text = Transparency
        chkTransparency.Checked = oTransparent
        chkTabRoot.Checked = oTabroot
        chkNoteText.Checked = oNotes
        chkTones.Checked = oTones
        chkNoteIcon.Checked = oIcon
        cbColRoot.SelectedIndex = RootColor
        cbColNote.SelectedIndex = NoteColor
        txtFretMax.Text = FretMax
        txtFretMin.Text = FretMin
        chkExpanded.Checked = oExpanded
        chkFretload.Checked = oFretLoad
        chkKeyload.Checked = oKeyLoad
        txtTuning.Text = Tuning
    End Sub

    Private Sub txtFretMin_TextChanged(sender As Object, e As EventArgs)
        FretMin = Val(txtFretMin.Text)
    End Sub


    Private Sub txtFretMin_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Ensures only numbers can be entered in to text box:
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        '44 = comma

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFretMax_TextChanged(sender As Object, e As EventArgs)
        FretMax = Val(txtFretMax.Text)
    End Sub

    Private Sub txtFretMax_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Ensures only numbers can be entered in to text box:
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub txtTuning_TextChanged(sender As Object, e As EventArgs) Handles txtTuning.TextChanged
        Tuning = txtTuning.Text
    End Sub

    Private Sub chkTabRoot_CheckedChanged(sender As Object, e As EventArgs) Handles chkTabRoot.CheckedChanged
        oTabroot = chkTabRoot.Checked
    End Sub

    Private Sub chkNoteText_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoteText.CheckedChanged
        oNotes = chkNoteText.Checked
    End Sub

    Private Sub chkTones_CheckedChanged(sender As Object, e As EventArgs) Handles chkTones.CheckedChanged
        oTones = chkTones.Checked
    End Sub

    Private Sub chkExpanded_CheckedChanged(sender As Object, e As EventArgs) Handles chkExpanded.CheckedChanged
        oExpanded = chkExpanded.Checked
    End Sub

    Private Sub chkFretload_CheckedChanged(sender As Object, e As EventArgs) Handles chkFretload.CheckedChanged
        oFretLoad = chkFretload.Checked
    End Sub

    Private Sub chkKeyload_CheckedChanged(sender As Object, e As EventArgs) Handles chkKeyload.CheckedChanged
        oKeyLoad = chkKeyload.Checked
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtTuning_Click(sender As Object, e As EventArgs) Handles txtTuning.Click

    End Sub

    Private Sub cbColRoot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColRoot.SelectedIndexChanged
        RootColor = cbColRoot.SelectedIndex

    End Sub

    Private Sub cbColNote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColNote.SelectedIndexChanged
        NoteColor = cbColNote.SelectedIndex
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub chkNoteIcon_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoteIcon.CheckedChanged
        oIcon = chkNoteIcon.Checked
    End Sub
End Class