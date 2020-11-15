Public Class frmKeyTriad
    Public Const KeyWidth = 23 'pixels
    Public Const KeyShift = 8 'used to shift label dots left this many pixels
    Public Const Key_x = 0 'where does image start?
    Public Const Key_y = 0 'where does image start?

    Dim r_image As Image = My.Resources.ind_r
    Dim g_image As Image = My.Resources.ind_g
    Dim y_image As Image = My.Resources.ind_y
    Dim b_image As Image = My.Resources.ind_b
    Function SetNoteColor(IsRoot As Boolean) As Image
        Dim ColDex As Integer

        If IsRoot = True Then
            ColDex = RootColor
        Else
            ColDex = NoteColor
        End If

        If ColDex = 0 Then
            SetNoteColor = r_image
        ElseIf ColDex = 1 Then
            SetNoteColor = g_image
        ElseIf ColDex = 2 Then
            SetNoteColor = y_image
        ElseIf ColDex = 3 Then
            SetNoteColor = b_image
        Else
            SetNoteColor = g_image
        End If

    End Function
    Public Sub KeyDraw(WhatNote As String, WutColor As Color, WhatDegree As Integer)
        Dim Oct1Dot, Oct2Dot As New Label

        With Oct1Dot
            .BackColor = WutColor
            .Location = New Point(Note2X(WhatNote) - KeyShift, Note2Y(WhatNote) + (100 * (WhatDegree - 1)))
            .Height = 12
            .Width = 12
            .Font = New Font("Verdana", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.Black
            If oIcon = True Then
                If WutColor = Color.Red Then 'Need to fix this but it works; the Color.Red is only passed if its a root note!
                    .Image = SetNoteColor(True)
                Else
                    .Image = SetNoteColor(False)
                End If
            End If
        End With

        With Oct2Dot
            .BackColor = WutColor
            .Location = New Point(160 + Note2X(WhatNote) - KeyShift, Note2Y(WhatNote) + (100 * (WhatDegree - 1)))
            .Height = 12
            .Width = 12
            .Font = New Font("Verdana", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            If oIcon = True Then
                If WutColor = Color.Red Then
                    .Image = SetNoteColor(True)
                Else
                    .Image = SetNoteColor(False)
                End If
            End If
        End With

        Me.Controls.Add(Oct1Dot)
        Me.Controls.Add(Oct2Dot)
        Me.pb1.SendToBack()
        Me.pb2.SendToBack()
        Me.pb3.SendToBack()
        Me.pb4.SendToBack()
        Me.pb5.SendToBack()
        Me.pb6.SendToBack()
        Me.pb7.SendToBack()

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
        Note2Y = 85
        If InStr(WhatNote, "#") > 0 Then
            Note2Y = 45
        End If

    End Function
    Sub DrawAll()
        For x = 1 To 7
            KeyDraw("A", Color.Red, x)
            KeyDraw("A#", Color.Green, x)
            KeyDraw("B", Color.Red, x)
            KeyDraw("C", Color.Red, x)
            KeyDraw("C#", Color.Green, x)
            KeyDraw("D", Color.Red, x)
            KeyDraw("D#", Color.Blue, x)
            KeyDraw("E", Color.Red, x)
            KeyDraw("F", Color.Red, x)
            KeyDraw("F#", Color.Yellow, x)
            KeyDraw("G", Color.Red, x)
            KeyDraw("G#", Color.Red, x)
        Next
    End Sub
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
    Private Sub frmKeyTriad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmKeyTriad_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        KeyClearAll()
        DrawAll()
    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
    End Sub
End Class