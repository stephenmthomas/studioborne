Public Class frmTabEdit
    Private Sub frmTabEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub GenerateTabScale(WhatNotes As String)
        'First, split string text in to notes
        'Grab last note and add tab line first
        'process through 24 semitones, placing tab/fret values when they apply


        Dim ScaleNotes(), TuningNotes() As String
        Dim CurString, CurNote As Integer
        Dim StringTuning, FretPitch As String

        ScaleNotes = Split(WhatNotes, ",")
        TuningNotes = Split(Tuning, ",")
        StringNo = UBound(TuningNotes) + 1

        For CurString = 1 To StringNo 'For each string on instrument
            StringTuning = TuningNotes(StringNo - CurString) 'Current Tuning of String
            StringTuning = Replace(StringTuning, vbNewLine, "")

            If Len(StringTuning) > 1 Then
                txtTab.Text = txtTab.Text & Trim(StringTuning) & "|-"
            Else
                txtTab.Text = txtTab.Text & Trim(StringTuning) & "-|-"
            End If

            For CurFret = FretMin To FretMax 'Search each fret open to 24
                FretPitch = Fret2Note(StringTuning, CurFret) 'Current pitch of current fret

                If CurFret > 9 Then
                    txtTab.Text += "--"
                Else
                    txtTab.Text += "-"
                End If

                If oTabroot = True And Not FretPitch = RootNote Then
                    txtTab.Text += "-"
                End If

                For CurNote = LBound(ScaleNotes) To UBound(ScaleNotes) '- 1 'Search each note of the scale to see if it matches the fret
                    'ScaleNote(CurNote) = note in scale to look for
                    If FretPitch = ScaleNotes(CurNote) Then 'If the current note is in the scale [GUITAR MONEY MAKER]
                        If CurFret > 9 Then
                            txtTab.Text = Mid(txtTab.Text, 1, Len(txtTab.Text) - 2)
                        Else
                            txtTab.Text = Mid(txtTab.Text, 1, Len(txtTab.Text) - 1)
                        End If

                        If oTabroot = True And FretPitch = RootNote Then
                            txtTab.Text += "[" & Replace(Str(CurFret), " ", "") & "]" 'Add the Fret
                        Else
                            txtTab.Text += Replace(Str(CurFret), " ", "") 'Add the Fret
                        End If

                    End If
                Next CurNote

                If CurFret > 9 Then
                    txtTab.Text += "--"
                Else
                    txtTab.Text += "-"
                End If

                If oTabroot = True And Not FretPitch = RootNote Then
                    txtTab.Text += "-"
                End If

            Next CurFret

            txtTab.Text += vbNewLine

        Next CurString

        txtTab.Text += vbNewLine

    End Sub

    Private Sub cmdDraw_Click(sender As Object, e As EventArgs) Handles cmdDraw.Click
        txtTab.Text += "Generating " & CurrentKey & " " & CurrentMode & " as tab:" & vbNewLine
        GenerateTabScale(CurrentNotes)
    End Sub

    Private Sub cmdAddChord_Click(sender As Object, e As EventArgs) Handles cmdAddChord.Click
        Dim TempRoot() As String

        TempRoot = Split(CurrentChord, ",")
        RootNote = TempRoot(0)
        txtTab.Text += "Generating " & CurrentKey & " " & CurrentMode & " degree " & Str(LastChord) & " chord:" & vbNewLine
        GenerateTabScale(CurrentChord)
        RootNote = CurrentKey
    End Sub
End Class