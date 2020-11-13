Module MusicFunctions
    Public SBVersion As String = "version 0.95"
    Public DefaultOpts As String = "autoshow=true,notes=false,tones=false,tabroots=false,icons=true,ontop=false,transparency=0.5,transparent=false,fretmin=0,fretmax=24,key=3,mode=0"
    Public FretMin As Integer = 0
    Public FretMax As Integer = 24
    Public Transparency As Single = 0.5
    Public RootNote As String 'The Key
    Public RootDiff As Integer 'Difference between the root note and "A", which is considered 0
    Public Tuning As String 'What tuning is the guitar in
    Public StringNo As Integer 'How many strings does it have?
    Public LastChord As Integer 'What chord degree is in the box?
    Public CurrentNotes As String 'The notes of the selected mode


    Public Function Note2Value(WhatNote As String) As Integer
        Note2Value = 99
        WhatNote = UCase(WhatNote)
        WhatNote = Trim(WhatNote)
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
        'Generates the notes of a  scale based on intervals (CALC ROOT DIFF BEFORE USING)


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
    Public Function GenNotesFromSemitones(WhatRoot As String, WhatTonesCSV As String) As String
        'Generates the notes based on semitones from root (CALC ROOT DIFF BEFORE USING)

        '0,2,7 in C should yield C,D,G, but yields C,C#,D

        Dim sSteps() As String

        Dim i As Integer
        Dim CurString As String

        CurString = ""
        sSteps = Split(GenSemiCSV(WhatTonesCSV), ",")

        For i = 0 To UBound(sSteps) - 1
            CurString = CurString & Value2Note(sSteps(i + 1) + RootDiff) & ","
        Next i

        CurString = Mid(CurString, 1, Len(CurString) - 1)

        GenNotesFromSemitones = CurString

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
    Public Function GenIntFromNotes(Note1 As String, Note2 As String) As Integer
        'Generates the interval between two notes.  Can be used to show relative semitones from root.
        'ie in Key of C, C is 0 - but in code C is 3.
        'So Root(C) = 3, Note(C) = 3, diff = 0

        'GenIntFromNotes("C","D") = 2

        If Note2Value(Note2) < Note2Value(Note1) Then
            GenIntFromNotes = 12 - Math.Abs(Note2Value(Note2) - Note2Value(Note1))
        Else
            GenIntFromNotes = Math.Abs(Note2Value(Note2) - Note2Value(Note1))
        End If

    End Function
    Public Function GenIntsFromNotes(NoteCSV As String) As String
        'Giving a CSV of notes, generates the interval formula
        'ie GenIntFromCSV("C,E,G") = "0,4,7"  -  the c major chord

        Dim SplitCSV() As String
        Dim OutputStr As String

        SplitCSV = Split(NoteCSV, ",")
        OutputStr = ""
        GenIntsFromNotes = "Error"

        For Each Note In SplitCSV
            OutputStr = OutputStr & Trim(Str(GenIntFromNotes(SplitCSV(0), Note)) & ",")
        Next

        GenIntsFromNotes = Mid(OutputStr, 1, Len(OutputStr) - 1)

    End Function
    Public Function ScaleDegIntFromNotes(WhatNotes As String, WhatDegree As Integer) As String
        'Outputs the intervals, in CSV, of a particular scale degree from a set of notes (should be a diatonic scale!)
        'ie feed C Major as 'WhatNotes' and '3' as WhatDegree and output is '0,3,7'

        Dim ScaleNotes() As String
        Dim ChordDeg As String
        Dim NoteX As Integer

        ScaleNotes = Split(WhatNotes & "," & WhatNotes, ",")
        NoteX = 0

        ScaleDegIntFromNotes = "Error"

        For NoteX = 0 To 6
            ChordDeg = "0," & GenIntFromNotes(ScaleNotes(NoteX), ScaleNotes(NoteX + 2)) & "," & GenIntFromNotes(ScaleNotes(NoteX), ScaleNotes(NoteX + 4))
            If NoteX + 1 = WhatDegree Then
                ScaleDegIntFromNotes = ChordDeg
            End If
        Next

    End Function
    Public Function ChordTypeFromCSV(ChordCSV As String) As String
        ChordTypeFromCSV = "" 'unknown chord type
        If ChordCSV = "0,2,7" Then ChordTypeFromCSV = "sus2"
        If ChordCSV = "0,3,6" Then ChordTypeFromCSV = "dim"
        If ChordCSV = "0,3,6,9" Then ChordTypeFromCSV = "dim7"
        If ChordCSV = "0,3,6,10" Then ChordTypeFromCSV = "°7/m7b5"
        If ChordCSV = "0,3,7" Then ChordTypeFromCSV = "min"
        If ChordCSV = "0,3,7,10" Then ChordTypeFromCSV = "min7/m7"
        If ChordCSV = "0,3,7,11" Then ChordTypeFromCSV = "min/maj7"
        If ChordCSV = "0,3,7,9" Then ChordTypeFromCSV = "min6/m6"
        If ChordCSV = "0,3,8,10" Then ChordTypeFromCSV = "m7#5"
        If ChordCSV = "0,4,5" Then ChordTypeFromCSV = "flat5"
        If ChordCSV = "0,4,6,10" Then ChordTypeFromCSV = "7b5"
        If ChordCSV = "0,4,6,11" Then ChordTypeFromCSV = "maj7b5"
        If ChordCSV = "0,4,7" Then ChordTypeFromCSV = "Δ/maj"
        If ChordCSV = "0,4,7,10" Then ChordTypeFromCSV = "dom7/7th"
        If ChordCSV = "0,4,7,11" Then ChordTypeFromCSV = "maj7"
        If ChordCSV = "0,4,7,9" Then ChordTypeFromCSV = "maj6/6th"
        If ChordCSV = "0,4,8" Then ChordTypeFromCSV = "aug"
        If ChordCSV = "0,4,8,10" Then ChordTypeFromCSV = "aug7"
        If ChordCSV = "0,4,8,10" Then ChordTypeFromCSV = "7#5"
        If ChordCSV = "0,4,8,11" Then ChordTypeFromCSV = "maj7#5"
        If ChordCSV = "0,5,7" Then ChordTypeFromCSV = "sus4"
        If ChordCSV = "0,5,7,10" Then ChordTypeFromCSV = "7sus4"
        If ChordCSV = "0,7" Then ChordTypeFromCSV = "5"
    End Function

    Public Function ChordDegButton(ChordCSV As String, WhatDeg As String) As String
        'Used to set quick chord button text
        ChordDegButton = WhatDeg

        If ChordCSV = "0,3,6" Then ChordDegButton = LCase(WhatDeg) & "°" 'Diminished Triad
        If ChordCSV = "0,3,7" Then ChordDegButton = LCase(WhatDeg)
        If ChordCSV = "0,4,7" Then ChordDegButton = UCase(WhatDeg)
        If ChordCSV = "0,4,8" Then ChordDegButton = UCase(WhatDeg) & "+" 'Augmented Triad

    End Function
End Module
