Module MusicFunctions
    Public SBVersion As String = "version 0.6"
    Public FretNo As Integer = 24
    Public RootNote As String 'The Key
    Public RootDiff As Integer 'Difference between the root note and "A", which is considered 0
    Public Tuning As String 'What tuning is the guitar in
    Public StringNo As Integer 'How many strings does it have?
    Public LastChord As Integer 'What chord degree is in the box?
    Public CurrentNotes As String 'The notes of the selected mode


    Public Function Note2Value(WhatNote As String) As Integer
        Note2Value = 99
        WhatNote = UCase(WhatNote)
        If WhatNote = "A" Then Note2Value = 0
        If WhatNote = "A#" Then Note2Value = 1
        If WhatNote = "B" Then Note2Value = 2
        If WhatNote = "C" Then Note2Value = 3
        If WhatNote = "C#" Then Note2Value = 4
        If WhatNote = "D" Then Note2Value = 5
        If WhatNote = "D#" Then Note2Value = 6
        If WhatNote = "E" Then Note2Value = 7
        If WhatNote = "F" Then Note2Value = 8
        If WhatNote = "F#" Then Note2Value = 9
        If WhatNote = "G" Then Note2Value = 10
        If WhatNote = "G#" Then Note2Value = 11

    End Function
    Public Function Value2Note(WhatValue As Integer) As String
        Value2Note = "Error"

Starter:
        If WhatValue > 11 Then
            WhatValue -= 12
            GoTo Starter
        End If

        If WhatValue < -12 Then
            WhatValue += 13
            GoTo Starter
        End If

        If WhatValue = -12 Then Value2Note = "A"
        If WhatValue = -11 Then Value2Note = "A#"
        If WhatValue = -10 Then Value2Note = "B"
        If WhatValue = -9 Then Value2Note = "C"
        If WhatValue = -8 Then Value2Note = "C#"
        If WhatValue = -7 Then Value2Note = "D"
        If WhatValue = -6 Then Value2Note = "D#"
        If WhatValue = -5 Then Value2Note = "E"
        If WhatValue = -4 Then Value2Note = "F"
        If WhatValue = -3 Then Value2Note = "F#"
        If WhatValue = -2 Then Value2Note = "G"
        If WhatValue = -1 Then Value2Note = "G#"
        If WhatValue = 0 Then Value2Note = "A"
        If WhatValue = 1 Then Value2Note = "A#"
        If WhatValue = 2 Then Value2Note = "B"
        If WhatValue = 3 Then Value2Note = "C"
        If WhatValue = 4 Then Value2Note = "C#"
        If WhatValue = 5 Then Value2Note = "D"
        If WhatValue = 6 Then Value2Note = "D#"
        If WhatValue = 7 Then Value2Note = "E"
        If WhatValue = 8 Then Value2Note = "F"
        If WhatValue = 9 Then Value2Note = "F#"
        If WhatValue = 10 Then Value2Note = "G"
        If WhatValue = 11 Then Value2Note = "G#"

    End Function
    Public Function ChangePitch(StartNote As String, ByAmount As Integer) As String
        ChangePitch = Value2Note(Note2Value(StartNote) + ByAmount)
    End Function
    Public Function Note2Fret(StringTune As String, Note As String) As Integer
        'converts a note to a fret on a givin string tuning
        'ie Note2Fret(E,A) = 5 [you can add 12 to this value to get the next octave]
        '   Note2Fret(D,E) = 14
        'If value > 11, value -= 12
        'Add 12 to value to get second octave half of fretboard

        Dim StringVal, NoteVal, OutVal As Integer

        StringVal = Note2Value(StringTune)
        NoteVal = Note2Value(Note)

        OutVal = 12 - StringVal + NoteVal

        If OutVal > 11 Then
            OutVal -= 12
        End If

        Note2Fret = OutVal

    End Function
    Public Function Fret2Note(StringTune As String, Fret As Integer) As String
        'converts integer fret value to corresponding note
        'ie Fret2Note(E, 5) = A

        Fret2Note = Value2Note(Note2Value(StringTune) + Fret)

    End Function
    Public Function GenNotesCSV(WhatIntervalCSV As String) As String
        'Generates the notes of a  scale based on semitones
        'The semitones generation relies on intervals
        'This function needs to be written and deleted

        Dim sSteps() As String

        Dim i As Integer
        Dim CurString As String

        CurString = ""
        sSteps = Split(GenSemiCSV(WhatIntervalCSV), ",")

        For i = 0 To UBound(sSteps) - 1
            CurString = CurString & Value2Note(sSteps(i) + RootDiff) & ","
        Next i

        CurString = Mid(CurString, 1, Len(CurString) - 1)

        GenNotesCSV = CurString

    End Function
    Public Function GenSemiCSV(WhatIntervalCSV As String) As String
        'Generates a string of the semitones of the selected scale
        'Output is a CSV string

        Dim HSteps() As String
        Dim CurString As String
        Dim CurVal, i As Integer

        CurVal = 0
        CurString = "0"

        HSteps = Split(WhatIntervalCSV, ",")

        For i = 0 To UBound(HSteps)
            CurVal += Str(HSteps(i))
            CurString = CurString & "," & Replace(Str(CurVal), " ", "")
        Next i

        GenSemiCSV = CurString

    End Function
    Public Function GenChordFromCSV(Root As String, IntervalCSV As String) As String
        'Generates a chord based on intervals/semitones
        'Outputs to CSV

        Dim SplitCSV() As String
        Dim OutputCSV As String

        OutputCSV = ""

        SplitCSV = Split(IntervalCSV, ",")

        For Each Semitone In SplitCSV
            OutputCSV += ChangePitch(Root, Semitone) & ","
        Next

        GenChordFromCSV = Mid(OutputCSV, 1, Len(OutputCSV) - 1)

    End Function
End Module
