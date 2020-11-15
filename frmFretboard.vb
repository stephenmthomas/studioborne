Public Class frmFretboard

    Public Const FretOrigin_x = 43 'What x pixel is the 1st fret of the 1st string on
    Public Const FretOrigin_y = 12 'What y pixel is the 1st fret of the 1st string on
    Public Const FretSpace_x = 51 'Constant for misc x spacing between frets
    Public Const FretSpace_y = 35 'constant for misc y spacing between strings
    Dim r_image As Image = My.Resources.ind_r
    Dim g_image As Image = My.Resources.ind_g
    Dim y_image As Image = My.Resources.ind_y
    Dim b_image As Image = My.Resources.ind_b

    Public Sub FretDraw(WutString As Integer, WutFret As Integer, WutColor As Color, Optional ByVal WhatText As String = "")
        Dim NewDot As New Label
        Dim StringMod As Integer 'Fine Tune for placing dots

        'JUST HARDCODE THE Y POSITION FOR THE STRING
        If WutString = 1 Then StringMod = 2
        If WutString = 2 Then StringMod = 38
        If WutString = 3 Then StringMod = 75
        If WutString = 4 Then StringMod = 111
        If WutString = 5 Then StringMod = 147
        If WutString = 6 Then StringMod = 182

        If oNotes = False And oTones = False Then
            WhatText = ""
        End If

        With NewDot
            .Text = WhatText
            .BackColor = WutColor
            .Location = New Point(FretOrigin_x + (FretSpace_x * (WutFret - 1)) - (WutFret * 0.3), StringMod)
            .Height = 25
            .Width = 25
            .Font = New Font("Verdana", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            If oIcon = True Then
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