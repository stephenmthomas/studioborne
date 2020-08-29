Public Class frmFretboard

    Public Const FretOrigin_x = 30
    Public Const FretOrigin_y = 12
    Dim r_image As Image = My.Resources.ind_r
    Dim g_image As Image = My.Resources.ind_g
    Dim y_image As Image = My.Resources.ind_y
    Dim b_image As Image = My.Resources.ind_b

    Public Sub FretDraw(WutString As Integer, WutFret As Integer, WutColor As Color, Optional ByVal WhatText As String = "")
        Dim NewDot As New Label


        If frmTabTool.chkNoteText.Checked = False And frmTabTool.chkTones.Checked = False Then
            WhatText = ""
        End If

        With NewDot
            .Text = WhatText
            .BackColor = WutColor
            .Location = New Point(FretOrigin_x + (50 * (WutFret - 1)) + 19, FretOrigin_y + (35 * WutString) - 38)
            .Height = 25
            .Width = 25
            .Font = New Font("Verdana", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            If frmTabTool.chkNoteIcon.Checked = True Then
                If WutColor = Color.Red Then
                    .Image = r_image
                ElseIf WutColor = Color.Blue Then
                    .Image = b_image
                ElseIf WutColor = Color.Yellow Then
                    .Image = y_image
                Else
                    .Image = g_image
                End If
            End If
        End With

        Me.Controls.Add(NewDot)
        'NewDot.Font = New Font(Me.Font, FontStyle.Bold)
        Me.pbFretboard.SendToBack()

    End Sub
    Sub FretClearAll()
        Dim Labels As New List(Of Label)
        Dim Stack As New Stack(Of Control)
        Stack.Push(Me)
        While Stack.Count > 0
            Dim Ctrl As Control = Stack.Pop()
            Labels.Add(TryCast(Ctrl, Label))
            For Each C As Control In Ctrl.Controls
                Stack.Push(C)
            Next
        End While
        For Each L As Label In Labels
            If Not IsNothing(L) Then L.Dispose()
        Next
    End Sub
    Private Sub frmFretboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Sub TestFullDraw()
        For x = 0 To 17
            FretDraw(1, x, Color.Red)
            FretDraw(2, x, Color.Green)
            FretDraw(3, x, Color.Blue)
            FretDraw(4, x, Color.Yellow)
            FretDraw(5, x, Color.Purple)
            FretDraw(6, x, Color.Orange)
        Next
    End Sub

    Private Sub frmFretboard_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        FretClearAll()
    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
    End Sub
End Class