Public Class frmKeyboard
    Public Const KeyWidth = 46 'pixels
    Public Const Key_x = 12 'where does image start?
    Public Const Key_y = 12 'where does image start?

    Dim r_image As Image = My.Resources.ind_r
    Dim g_image As Image = My.Resources.ind_g
    Dim y_image As Image = My.Resources.ind_y
    Dim b_image As Image = My.Resources.ind_b

    Public Sub KeyDraw(WhatNote As String, WutColor As Color, Optional ByVal WhatText As String = "")
        Dim Oct1Dot, Oct2Dot As New Label

        If oNotes = False And oTones = False Then
            WhatText = ""
        End If

        With Oct1Dot
            .Text = WhatText
            .BackColor = WutColor
            .Location = New Point(Note2X(WhatNote), Note2Y(WhatNote))
            .Height = 25
            .Width = 25
            .Font = New Font("Verdana", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.Black
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

        With Oct2Dot
            .Text = WhatText
            .BackColor = WutColor
            .Location = New Point(320 + Note2X(WhatNote), Note2Y(WhatNote))
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

        Me.Controls.Add(Oct1Dot)
        Me.Controls.Add(Oct2Dot)
        Me.pbKeys.SendToBack()

    End Sub
    Public Function Note2X(WhatNote As String) As Long
        Note2X = 0
        If WhatNote = "C" Then Note2X = KeyWidth * 0.5
        If WhatNote = "C#" Then Note2X = KeyWidth * 1
        If WhatNote = "D" Then Note2X = KeyWidth * 1.5
        If WhatNote = "D#" Then Note2X = KeyWidth * 2
        If WhatNote = "E" Then Note2X = KeyWidth * 2.5
        If WhatNote = "F" Then Note2X = KeyWidth * 3.5
        If WhatNote = "F#" Then Note2X = KeyWidth * 4
        If WhatNote = "G" Then Note2X = KeyWidth * 4.5
        If WhatNote = "G#" Then Note2X = KeyWidth * 5
        If WhatNote = "A" Then Note2X = KeyWidth * 5.5
        If WhatNote = "A#" Then Note2X = KeyWidth * 6
        If WhatNote = "B" Then Note2X = KeyWidth * 6.5
    End Function
    Public Function Note2Y(WhatNote As String) As Long
        Note2Y = 180
        If WhatNote = "C#" Then Note2Y = 100
        If WhatNote = "D#" Then Note2Y = 100
        If WhatNote = "F#" Then Note2Y = 100
        If WhatNote = "G#" Then Note2Y = 100
        If WhatNote = "A#" Then Note2Y = 100


    End Function
    Sub KeyClearAll()
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
    Sub DrawAll()
        KeyDraw("A", Color.Red)
        KeyDraw("A#", Color.Blue)
        KeyDraw("B", Color.Red)
        KeyDraw("C", Color.Pink)
        KeyDraw("C#", Color.Green)
        KeyDraw("D", Color.Yellow)
        KeyDraw("D#", Color.Azure)
        KeyDraw("E", Color.Magenta)
        KeyDraw("F", Color.Green, "P")
        KeyDraw("F#", Color.White)
        KeyDraw("G", Color.Black)
        KeyDraw("G#", Color.Red, "G#")


    End Sub
    Private Sub frmKeyboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmKeyboard_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        KeyClearAll()

    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
    End Sub
End Class