Module MusicFunctions
    Public SBVersion As String = "version 0.99"
    Public DefaultOpts As String = "autoshow=True,notes=False,tones=False,fretblips=False,tabroots=False,icons=True,rootcolor=0,notecolor=1,ontop=True,transparency=.5,transparent=False,fretmin=0,fretmax=17,expanded=False,fretload=False,keyload=False,infoload=False,mode=0,key=3,frettune=E-A-D-G-B-E"

    'OPTIONS/CONFIGURATION VARIABLES: (in order of config file)
    Public oAutoshow As Boolean = True      'Auto-Show Chords Option
    Public oNotes As Boolean = False        'Note blips show Notes (A,A#,B,etc.)
    Public oTones As Boolean = False        'Note blips show scale interval
    Public oFretBlips As Boolean = False    'Does Fretboard blip show fret number?
    Public oTabroot As Boolean = False      'Do generated tabs highlight the root note?
    Public oIcon As Boolean = True          'Show graphics in note blips
    Public RootColor As Integer = 0         'Red = 0, Green = 1, Yellow = 2, Blue = 3 - to correspond with the option boxes
    Public NoteColor As Integer = 1
    Public oOnTop As Boolean = True         'Do forms stay on top?
    Public Transparency As Single = 0.5     'Transparency value
    Public oTransparent As Boolean = False
    Public FretMin As Integer = 0           'Red = 0, Green = 1, Yellow = 2, Blue = 3 - to correspond with the option boxes
    Public FretMax As Integer = 17
    Public oExpanded As Boolean             'Does the certain forms start expanded?
    Public oFretLoad As Boolean             'Does the Fretboard load automatically?
    Public oKeyLoad As Boolean              'Does the keyboard load automatically?
    Public oInfoLoad As Boolean             'Does the info panel load automatically?

    'OPERATIONAL VARIABLES:
    Public CurrentMode As String
    Public CurrentKey As String = "C"
    Public CurrentChord As String           'Takes the place of an old "Chord" textbox which showed the output of the chord functions
    Public CurrentSemitones As String       'Holds the value that used to be stored by in the semitone textbox 'txtVals'
    Public CurrentNotes As String           'The notes of the selected mode
    Public ScaleInt As String               'Holds the value that used to be held by the interval combobox 'cbInt'

    Public RootNote As String               'The Key
    Public RootDiff As Integer              'Difference between the root note and "A", which is considered 0
    Public Tuning As String = "E,A,D,G,B,E" 'What tuning is the fretboard in
    Public StringNo As Integer              'How many strings does it have?
    Public LastChord As Integer             'What chord degree is in the box?

    Public Sub AddInfo(WhatInfo As String, Optional ByVal NewParagraph As Boolean = False)
        'Adds info the frmInfo.txtInfo box
        frmInfo.txtInfo.Text += WhatInfo & vbNewLine

        If NewParagraph = True Then frmInfo.txtInfo.Text += vbNewLine

        frmInfo.txtInfo.SelectionStart = frmInfo.txtInfo.Text.Length
        frmInfo.txtInfo.ScrollToCaret()

    End Sub
    Public Sub AddLog(WhatLog As String, Optional ByVal NewParagraph As Boolean = False, Optional ByVal PrintToDebug As Boolean = True)
        'Adds info the frmInfo.txtInfo box
        frmInfo.txtLog.Text += WhatLog & vbNewLine

        If PrintToDebug = True Then Debug.Print(WhatLog)
        If NewParagraph = True Then frmInfo.txtInfo.Text += vbNewLine

        frmInfo.txtLog.SelectionStart = frmInfo.txtLog.Text.Length
        frmInfo.txtLog.ScrollToCaret()

    End Sub
    Public Function KeyboardStep(WhatNote As String) As Integer
        'Determines what key position a note is in
        KeyboardStep = 99
        WhatNote = UCase(WhatNote)
        WhatNote = Trim(WhatNote)

        If WhatNote = "C" Then KeyboardStep = 0
        If WhatNote = "C#" Then KeyboardStep = 1
        If WhatNote = "D" Then KeyboardStep = 2
        If WhatNote = "D#" Then KeyboardStep = 3
        If WhatNote = "E" Then KeyboardStep = 4
        If WhatNote = "F" Then KeyboardStep = 5
        If WhatNote = "F#" Then KeyboardStep = 6
        If WhatNote = "G" Then KeyboardStep = 7
        If WhatNote = "G#" Then KeyboardStep = 8
        If WhatNote = "A" Then KeyboardStep = 9
        If WhatNote = "A#" Then KeyboardStep = 10
        If WhatNote = "B" Then KeyboardStep = 11

    End Function
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
            CurVal += Str(Val(HSteps(i)))
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
    Public Function GenIntFromNotes(Note1 As String, Note2 As String, Optional ByVal WithInOctave As Boolean = False) As Integer
        'Generates the interval between two notes.  Can be used to show relative semitones from root.
        'ie in Key of C, C is 0 - but in code C is 3.
        'So Root(C) = 3, Note(C) = 3, diff = 0

        'GenIntFromNotes("C","D") = 2

        'If WithInOctave = True, then it will generate a relative interval from Note1
        'ie GenIntFromNotes("D","C#",True) = -1

        If Note2Value(Note2) < Note2Value(Note1) Then
            If WithInOctave = True Then
                GenIntFromNotes = Note2Value(Note2) - Note2Value(Note1)
            Else
                GenIntFromNotes = 12 - Math.Abs(Note2Value(Note2) - Note2Value(Note1))
            End If
        Else
            GenIntFromNotes = Math.Abs(Note2Value(Note2) - Note2Value(Note1))
        End If

    End Function
    Public Function GenIntsFromNotes(NoteCSV As String) As String
        'Giving a CSV of notes, generates the interval formula
        'ie GenIntsFromNotes("C,E,G") = "0,4,7"  -  the c major chord

        'Assumes ascending notes, so C MAJ 13 = "C,E,G,B,D,F,A" should return "0,4,7,11,14,17,21"

        Dim SplitCSV() As String
        Dim OutputStr As String = ""
        Dim NoteScan As Integer = 0
        Dim IntTotal As Integer = 0

        SplitCSV = Split(NoteCSV, ",")
        GenIntsFromNotes = "Error"

        OutputStr = "0,"

        For NoteScan = 1 To UBound(SplitCSV)
            IntTotal += GenIntFromNotes(SplitCSV(NoteScan - 1), SplitCSV(NoteScan))
            OutputStr += Trim(Str(IntTotal) & ",")
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
        'Gets the chord name from the intervals
        Debug.Print("ChordTypeFromCSV:-" & ChordCSV & "-")
        ChordTypeFromCSV = "[?]" 'unknown chord type
        If ChordCSV = "0,1,5,6,10,12,15,17" Then ChordTypeFromCSV = "mag"
        If ChordCSV = "0,2,4,7" Then ChordTypeFromCSV = "mu"
        If ChordCSV = "0,2,7" Then ChordTypeFromCSV = "sus2"
        If ChordCSV = "0,3,6" Then ChordTypeFromCSV = "dim"
        If ChordCSV = "0,3,6,10" Then ChordTypeFromCSV = "°7/m7b5"
        If ChordCSV = "0,3,6,11" Then ChordTypeFromCSV = "°M7"
        If ChordCSV = "0,3,6,9" Then ChordTypeFromCSV = "dim7"
        If ChordCSV = "0,3,7" Then ChordTypeFromCSV = "min"
        If ChordCSV = "0,3,7,10" Then ChordTypeFromCSV = "m7"
        If ChordCSV = "0,3,7,10,13,17" Then ChordTypeFromCSV = "m7b9(add11)"
        If ChordCSV = "0,3,7,10,14,17" Then ChordTypeFromCSV = "m11"
        If ChordCSV = "0,3,7,10,14,17,21" Then ChordTypeFromCSV = "m13"
        If ChordCSV = "0,3,7,11" Then ChordTypeFromCSV = "min/maj7"
        If ChordCSV = "0,3,7,11,14" Then ChordTypeFromCSV = "m9"
        If ChordCSV = "0,3,7,9" Then ChordTypeFromCSV = "m6"
        If ChordCSV = "0,3,8,10" Then ChordTypeFromCSV = "m7#5"
        If ChordCSV = "0,4,5" Then ChordTypeFromCSV = "b5"
        If ChordCSV = "0,4,6,10" Then ChordTypeFromCSV = "7b5"
        If ChordCSV = "0,4,6,10,14" Then ChordTypeFromCSV = "9b5"
        If ChordCSV = "0,4,6,11" Then ChordTypeFromCSV = "M7b5"
        If ChordCSV = "0,4,7" Then ChordTypeFromCSV = "Δ/maj"
        If ChordCSV = "0,4,7,10" Then ChordTypeFromCSV = "dom7/7th"
        If ChordCSV = "0,4,7,10,13" Then ChordTypeFromCSV = "7b9"
        If ChordCSV = "0,4,7,10,14" Then ChordTypeFromCSV = "9"
        If ChordCSV = "0,4,7,10,14,17" Then ChordTypeFromCSV = "11"
        If ChordCSV = "0,4,7,10,14,17,21" Then ChordTypeFromCSV = "13"
        If ChordCSV = "0,4,7,10,14,18" Then ChordTypeFromCSV = "aug11"
        If ChordCSV = "0,4,7,10,15" Then ChordTypeFromCSV = "7#9"
        If ChordCSV = "0,4,7,10,15,18" Then ChordTypeFromCSV = "7#9#11"
        If ChordCSV = "0,4,7,11" Then ChordTypeFromCSV = "M7"
        If ChordCSV = "0,4,7,11,14" Then ChordTypeFromCSV = "M9"
        If ChordCSV = "0,4,7,11,14,17" Then ChordTypeFromCSV = "M11"
        If ChordCSV = "0,4,7,11,14,18" Then ChordTypeFromCSV = "maj9#11"
        If ChordCSV = "0,4,7,11,14,17,21" Then ChordTypeFromCSV = "M13"
        If ChordCSV = "0,4,7,11,18" Then ChordTypeFromCSV = "#11"
        If ChordCSV = "0,4,7,14" Then ChordTypeFromCSV = "add9"
        If ChordCSV = "0,4,7,9" Then ChordTypeFromCSV = "M6"
        If ChordCSV = "0,4,7,9,10" Then ChordTypeFromCSV = "7/6"
        If ChordCSV = "0,4,8" Then ChordTypeFromCSV = "aug"
        If ChordCSV = "0,4,8,10" Then ChordTypeFromCSV = "aug7"
        If ChordCSV = "0,4,8,11" Then ChordTypeFromCSV = "M7#5"
        If ChordCSV = "0,4,8,11,18" Then ChordTypeFromCSV = "M7#11"
        If ChordCSV = "0,5,10,15,19" Then ChordTypeFromCSV = "sw"
        If ChordCSV = "0,5,6,7" Then ChordTypeFromCSV = "drm"
        If ChordCSV = "0,5,7" Then ChordTypeFromCSV = "sus4"
        If ChordCSV = "0,5,7,10" Then ChordTypeFromCSV = "7sus4"
        If ChordCSV = "0,6,10" Then ChordTypeFromCSV = "It+6"
        If ChordCSV = "0,7" Then ChordTypeFromCSV = "5"
        If ChordCSV = "0,7,9,13,16" Then ChordTypeFromCSV = "ekt"
        If ChordCSV = "0,8,11,16,21" Then ChordTypeFromCSV = "frb"
        If ChordCSV = "1,5,8" Then ChordTypeFromCSV = "neo"
    End Function

    Public Function ChordDegButton(ChordCSV As String, WhatDeg As String) As String
        'Used to set quick chord button text
        ChordDegButton = WhatDeg

        If ChordCSV = "0,3,6" Then ChordDegButton = LCase(WhatDeg) & "°" 'Diminished Triad
        If ChordCSV = "0,3,7" Then ChordDegButton = LCase(WhatDeg)
        If ChordCSV = "0,4,7" Then ChordDegButton = UCase(WhatDeg)
        If ChordCSV = "0,4,8" Then ChordDegButton = UCase(WhatDeg) & "+" 'Augmented Triad

    End Function
    Public Sub RefreshAllForms()
        'Refreshes all forms
        If frmKeyboard.Visible = True Then
            frmTabTool.DrawKeyboard(CurrentNotes)
            frmKeyboard.Text = "Keyboard - " & RootNote & " " & CurrentMode
        End If

        If frmFretboard.Visible = True Then
            frmTabTool.DrawFretBoard(CurrentNotes)
            frmFretboard.Text = "Fretboard - " & RootNote & " " & CurrentMode
        End If

        If frmKeyTriad.Visible = True Then
            frmTabTool.DrawTriadForm()
            frmKeyTriad.Text = "Triads - " & RootNote & " " & CurrentMode
        End If

        frmInfo.txtChord.Text = CurrentChord
        frmInfo.txtVals.Text = CurrentSemitones
        frmInfo.txtNotes.Text = CurrentNotes
        frmInfo.cbInt.SelectedIndex = frmTabTool.cbInt.SelectedIndex
        frmInfo.cbKey.SelectedIndex = frmTabTool.cbKey.SelectedIndex
        frmInfo.cbMode.SelectedIndex = frmTabTool.cbMode.SelectedIndex
        frmInfo.txtChord.Text = CurrentChord
        frmInfo.txtVals.Text = CurrentSemitones
        frmInfo.txtNotes.Text = CurrentNotes

        AddLog("-Updated All Forms.")

        'TRANSPARENCIES [only applies to primary forms]
        If oTransparent = True Then
            frmProgressor.Opacity = Transparency
            frmInfo.Opacity = Transparency
            frmTabEdit.Opacity = Transparency
            frmTabTool.Opacity = Transparency
            frmKeyboard.Opacity = Transparency
            frmFretboard.Opacity = Transparency
            frmChordBuilder.Opacity = Transparency
            frmKeyTriad.Opacity = Transparency
        ElseIf oTransparent = False Then
            frmProgressor.Opacity = 1
            frmInfo.Opacity = 1
            frmTabEdit.Opacity = 1
            frmTabTool.Opacity = 1
            frmKeyboard.Opacity = 1
            frmFretboard.Opacity = 1
            frmChordBuilder.Opacity = 1
            frmKeyTriad.Opacity = 1
        End If

        AddLog("-Updated All Forms.")
    End Sub
    Sub OnTopAllForms()
        'Places all forms on top or not

        frmChordBuilder.chkOnTop.Checked = oOnTop
        frmFretboard.chkOnTop.Checked = oOnTop
        frmInfo.chkOnTop.Checked = oOnTop
        frmKeyboard.chkOnTop.Checked = oOnTop
        frmKeyTriad.chkOnTop.Checked = oOnTop
        frmProgressor.chkOnTop.Checked = oOnTop
        frmTabEdit.chkOnTop.Checked = oOnTop
        frmTabTool.chkOnTop.Checked = oOnTop
    End Sub
    Sub CloseAllForms()
        'Closes all forms except the main Window
        frmAbout.Close()
        frmChordBuilder.Close()
        frmFretboard.Close()
        frmGtrTune.Close()
        frmInfo.Close()
        frmKeyboard.Close()
        frmKeyTriad.Close()
        frmOptions.Close()
        frmProgressor.Close()
        frmTabEdit.Close()

    End Sub
    Function SetNoteClipColor(IsRoot As Boolean) As Color
        Dim ColDex As Integer

        If IsRoot = True Then
            ColDex = RootColor
        Else
            ColDex = NoteColor
        End If

        If ColDex = 0 Then 'RED
            SetNoteClipColor = Color.Red
        ElseIf ColDex = 1 Then 'GREEN
            SetNoteClipColor = Color.Green
        ElseIf ColDex = 2 Then 'YELLOW
            SetNoteClipColor = Color.Yellow
        ElseIf ColDex = 3 Then 'BLUE
            SetNoteClipColor = Color.Blue
        Else
            SetNoteClipColor = Color.Green
        End If
    End Function
End Module
