Public Class frmOptions
    Dim ChangesMade As Boolean = False
    Private Sub chkTransparency_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransparency.CheckedChanged
        Dim tVal As Single = 0.5
        If chkTransparency.Checked = True Then
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
            Me.Opacity = 1
            RefreshAllForms()
        End If

        ChangesMade = True
    End Sub
    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        ChangesMade = True
    End Sub
    Private Sub txtFretMin_TextChanged(sender As Object, e As EventArgs)
        ChangesMade = True
    End Sub
    Private Sub txtFretMax_TextChanged(sender As Object, e As EventArgs)
        ChangesMade = True
    End Sub
    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
    End Sub
    Private Sub chkAutoChord_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoChord.CheckedChanged
        ChangesMade = True
    End Sub
    Private Sub txtTrans_TextChanged(sender As Object, e As EventArgs) Handles txtTrans.TextChanged
        ChangesMade = True
    End Sub
    Private Sub txtTuning_TextChanged(sender As Object, e As EventArgs) Handles txtTuning.TextChanged
        ChangesMade = True
    End Sub
    Private Sub chkTabRoot_CheckedChanged(sender As Object, e As EventArgs) Handles chkTabRoot.CheckedChanged
        ChangesMade = True
    End Sub
    Private Sub chkNoteText_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoteText.CheckedChanged
        ChangesMade = True
    End Sub
    Private Sub chkTones_CheckedChanged(sender As Object, e As EventArgs) Handles chkTones.CheckedChanged
        ChangesMade = True
    End Sub
    Private Sub chkExpanded_CheckedChanged(sender As Object, e As EventArgs) Handles chkExpanded.CheckedChanged
        ChangesMade = True
    End Sub
    Private Sub chkFretload_CheckedChanged(sender As Object, e As EventArgs) Handles chkFretload.CheckedChanged
        ChangesMade = True
    End Sub
    Private Sub chkKeyload_CheckedChanged(sender As Object, e As EventArgs) Handles chkKeyload.CheckedChanged
        ChangesMade = True
    End Sub
    Private Sub cbColRoot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColRoot.SelectedIndexChanged
        ChangesMade = True
    End Sub
    Private Sub cbColNote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColNote.SelectedIndexChanged
        ChangesMade = True
    End Sub
    Private Sub chkNoteIcon_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoteIcon.CheckedChanged
        ChangesMade = True
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


    Private Sub lblTuning_Click(sender As Object, e As EventArgs) Handles lblTuning.Click
        frmGtrTune.Show()
    End Sub

    Private Sub txtTuning_DoubleClick(sender As Object, e As EventArgs) Handles txtTuning.DoubleClick
        frmGtrTune.Show()
    End Sub
    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkOnTop.Checked = oOnTop
        txtTrans.Text = Transparency
        chkTransparency.Checked = oTransparent
        chkTabRoot.Checked = oTabroot
        chkNoteText.Checked = oNotes
        chkTones.Checked = oTones
        chkFretBlip.Checked = oFretBlips
        chkNoteIcon.Checked = oIcon
        cbColRoot.SelectedIndex = RootColor
        cbColNote.SelectedIndex = NoteColor
        txtFretMax.Text = FretMax
        txtFretMin.Text = FretMin
        chkExpanded.Checked = oExpanded
        chkFretload.Checked = oFretLoad
        chkKeyload.Checked = oKeyLoad
        chkInfoLoad.Checked = oInfoLoad
        txtTuning.Text = Tuning
        chkAutoChord.Checked = oAutoshow

    End Sub
    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click

        If ChangesMade = True Then
            oOnTop = chkOnTop.Checked
            Transparency = Val(txtTrans.Text)
            oTransparent = chkTransparency.Checked
            oTabroot = chkTabRoot.Checked
            oNotes = chkNoteText.Checked
            oTones = chkTones.Checked
            oFretBlips = chkFretBlip.Checked
            oIcon = chkNoteIcon.Checked
            RootColor = cbColRoot.SelectedIndex
            NoteColor = cbColNote.SelectedIndex
            FretMin = Val(txtFretMin.Text)
            FretMax = Val(txtFretMax.Text)
            oExpanded = chkExpanded.Checked
            oFretLoad = chkFretload.Checked
            oKeyLoad = chkKeyload.Checked
            oInfoLoad = chkInfoLoad.Checked
            Tuning = txtTuning.Text
            oAutoshow = chkAutoChord.Checked

            Tuning = Trim(Replace(Tuning, vbNewLine, ""))

            If chkOnTop.Checked = True Then
                Me.TopMost = chkOnTop.Checked
                frmTabTool.TopMost = chkOnTop.Checked
                frmProgressor.TopMost = chkOnTop.Checked
                frmInfo.TopMost = chkOnTop.Checked
                frmKeyboard.chkOnTop.Checked = chkOnTop.Checked
                frmFretboard.chkOnTop.Checked = chkOnTop.Checked
                frmChordBuilder.chkOnTop.Checked = chkOnTop.Checked
                frmKeyTriad.chkOnTop.Checked = chkOnTop.Checked
            End If

            frmTabTool.SaveOptions()
            RefreshAllForms()
            OnTopAllForms()
        End If

        AddLog("-Updated Settings")

        Me.Close()

    End Sub

    Private Sub cmdRestoreDefault_Click(sender As Object, e As EventArgs) Handles cmdRestoreDefault.Click
        Dim ConfigFile As System.IO.StreamWriter
        Dim MBYesNo As Integer

        MBYesNo = MsgBox("Are you sure you want to restore the default settings?", vbYesNo, "Restore Settings?")

        If MBYesNo = 6 Then 'Yes
            ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
            ConfigFile.WriteLine(DefaultOpts)
            ConfigFile.Close()
            frmTabTool.LoadOptions(True)
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Dim MBYesNo As Integer

        If ChangesMade = True Then
            MBYesNo = MsgBox("Are you sure you want to exit without applying changes?", vbYesNo, "Exit?")

            If MBYesNo = 6 Then
                Me.Close()
            Else
                Exit Sub
            End If
        End If

        Me.Close()

    End Sub
End Class