Public Class frmTabTool

    Public Sub GenRootDiff(WhatNote)
        RootDiff = Note2Value(WhatNote) - 0
    End Sub
    Public Sub GenValues()
        CurrentSemitones = GenSemiCSV(cbInt.Text)
        txtVals.Text = CurrentSemitones
    End Sub
    Sub SaveOptions()
        Dim ConfigFile As System.IO.StreamWriter
        Dim NewOpts As String

        NewOpts = ""

        NewOpts += "autoshow=" & oAutoshow & ","
        NewOpts += "notes=" & oNotes & ","
        NewOpts += "tones=" & oTones & ","
        NewOpts += "fretblips=" & oFretBlips & ","
        NewOpts += "tabroots=" & oTabroot & ","
        NewOpts += "icons=" & oIcon & ","
        NewOpts += "rootcolor=" & Trim(Str(RootColor)) & ","
        NewOpts += "notecolor=" & Trim(Str(NoteColor)) & ","
        NewOpts += "ontop=" & oOnTop & ","
        NewOpts += "transparency=" & Trim(Str(Transparency)) & ","
        NewOpts += "transparent=" & oTransparent & ","
        NewOpts += "fretmin=" & FretMin & ","
        NewOpts += "fretmax=" & FretMax & ","
        NewOpts += "expanded=" & oExpanded & ","
        NewOpts += "fretload=" & oFretLoad & ","
        NewOpts += "keyload=" & oKeyLoad & ","
        NewOpts += "infoload=" & oInfoLoad & ","
        NewOpts += "mode=" & cbMode.SelectedIndex & ","
        NewOpts += "key=" & cbKey.SelectedIndex & ","
        NewOpts += "frettune=" & Replace(Tuning, ",", "-")

        ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
        ConfigFile.WriteLine(NewOpts)
        ConfigFile.Close()
    End Sub
    Sub LoadOptions(Optional ByVal DefaultRestore As Boolean = False)
        Dim ConfigFile As System.IO.StreamWriter
        Dim SBOptions As String
        Dim Opts(), CurOpt() As String
        Dim LdError As Integer

        On Error GoTo LoadError

        If DefaultRestore = True Then
            CloseAllForms()
        End If

LoadConfig:
        'IF THE CONFIGURATION FILE EXISTS:
        If System.IO.File.Exists(Application.StartupPath & "\settings.cfg") Then
            SBOptions = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\settings.cfg")
            Opts = Split(SBOptions, ",")

            For Each opt In Opts
                CurOpt = Split(opt, "=")
                If CurOpt(0) = "autoshow" Then oAutoshow = CurOpt(1)
                If CurOpt(0) = "notes" Then oNotes = CurOpt(1)
                If CurOpt(0) = "tones" Then oTones = CurOpt(1)
                If CurOpt(0) = "fretblips" Then oFretBlips = CurOpt(1)
                If CurOpt(0) = "tabroots" Then oTabroot = CurOpt(1)
                If CurOpt(0) = "icons" Then oIcon = CurOpt(1)
                If CurOpt(0) = "rootcolor" Then RootColor = Val(CurOpt(1))
                If CurOpt(0) = "notecolor" Then NoteColor = Val(CurOpt(1))
                If CurOpt(0) = "ontop" Then oOnTop = CurOpt(1)
                If CurOpt(0) = "transparency" Then Transparency = Val(CurOpt(1))
                If CurOpt(0) = "transparent" Then oTransparent = CurOpt(1)
                If CurOpt(0) = "fretmin" Then FretMin = CurOpt(1)
                If CurOpt(0) = "fretmax" Then FretMax = CurOpt(1)
                If CurOpt(0) = "expanded" Then oExpanded = CurOpt(1)
                If CurOpt(0) = "fretload" Then oFretLoad = CurOpt(1)
                If CurOpt(0) = "keyload" Then oKeyLoad = CurOpt(1)
                If CurOpt(0) = "infoload" Then oInfoLoad = CurOpt(1)
                If CurOpt(0) = "mode" Then cbMode.SelectedIndex = CurOpt(1)
                If CurOpt(0) = "key" Then cbKey.SelectedIndex = CurOpt(1)
                If CurOpt(0) = "frettune" Then
                    Tuning = Replace(CurOpt(1), "-", ",")
                    Tuning = Trim(Replace(Tuning, vbNewLine, ""))
                End If

            Next

        Else 'NO CONFIGURATION FILE PRESENT
            ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
            ConfigFile.WriteLine(DefaultOpts)
            ConfigFile.Close()
            GoTo LoadConfig
        End If

        'SET OPTIONS
        CurrentKey = cbKey.Text
        CurrentMode = cbMode.Text
        RootNote = CurrentKey


        Me.Text = Me.Text & " - " & SBVersion
        If oExpanded = True Then
            cmdMaximize.Text = "Shrink"
            Me.Height = 227
            Me.Width = 504
        Else
            cmdMaximize.Text = "Expand"
            Me.Height = 113
            Me.Width = 367
        End If

        GenValues()

        If oFretLoad = True Then frmFretboard.Show()
        If oKeyLoad = True Then frmKeyboard.Show()
        If oInfoLoad = True Then frmInfo.Visible = True

        If DefaultRestore = True Then
            frmOptions.Show()
        End If

        RefreshAllForms()

        Exit Sub

LoadError: 'ERROR HANDLER; 6 = yes, 7 = no
        AddLog("Load Settings Error: " & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
        LdError = MsgBox("There appears to be an error loading the configuration file.  Would you like to reset the configuration file and try again? (Recommended!)", vbYesNo, "Load Error!")
        If LdError = 6 Then
            ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
            ConfigFile.WriteLine(DefaultOpts)
            ConfigFile.Close()
            cbKey.SelectedIndex = 3
            cbMode.SelectedIndex = 0
            CurrentNotes = GenNotesCSV(cbInt.Text)
            FretMin = 0
            FretMax = 17
            GoTo LoadConfig
        ElseIf LdError = 7 Then
            MsgBox("You should probably reset the configuration file, or close the program and delete it manually.  Studioborne will continue to run, but may encounter bugs.", vbOKOnly, "Well...")
        End If

    End Sub
    Private Sub frmTabTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmInfo.Show()
        frmInfo.Visible = False
        AddLog("Initialize: " & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))

        LoadOptions()
        OnTopAllForms()

        If oExpanded = True Then
            frmInfo.Height = 397
            frmInfo.Width = 454
            frmInfo.cmdMaximize.Text = "Shrink"
        Else
            frmInfo.Height = 125
            frmInfo.Width = 454
            frmInfo.cmdMaximize.Text = "Expand"
        End If

        AddLog("Successfully Loaded: " & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))

    End Sub


    Private Sub cbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMode.SelectedIndexChanged
        cbInt.SelectedIndex = cbMode.SelectedIndex
        CurrentMode = cbMode.Text

        AddLog("-CurrentMode=" & CurrentMode)

        CurrentNotes = GenNotesCSV(cbInt.Text)
        frmInfo.txtNotes.Text = CurrentNotes
        GenValues()

        cmdChord1.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 1), "I")
        cmdChord2.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 2), "II")
        cmdChord3.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 3), "III")
        cmdChord4.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 4), "IV")
        cmdChord5.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 5), "V")
        cmdChord6.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 6), "VI")
        cmdChord7.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 7), "VII")

        If frmKeyTriad.Visible = True Then
            frmKeyTriad.cb1.Text = cmdChord1.Text
            frmKeyTriad.cb2.Text = cmdChord2.Text
            frmKeyTriad.cb3.Text = cmdChord3.Text
            frmKeyTriad.cb4.Text = cmdChord4.Text
            frmKeyTriad.cb5.Text = cmdChord5.Text
            frmKeyTriad.cb6.Text = cmdChord6.Text
            frmKeyTriad.cb7.Text = cmdChord7.Text
        End If

        RefreshAllForms()

    End Sub

    Private Sub cbInt_SelectedIndexChanged(sender As Object, e As EventArgs)
        cbMode.SelectedIndex = cbInt.SelectedIndex
    End Sub
    Private Sub cbInt_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbInt.SelectedIndexChanged
        cbMode.SelectedIndex = cbInt.SelectedIndex
    End Sub
    Private Sub cbKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKey.SelectedIndexChanged
        CurrentKey = cbKey.Text
        RootNote = CurrentKey

        GenRootDiff(CurrentKey)
        CurrentNotes = GenNotesCSV(cbInt.Text)
        GenValues()

        AddLog("-CurrentKey=" & CurrentKey)

        RefreshAllForms()

    End Sub

    Public Sub DrawFretBoard(WhatNotes As String)
        'Modified version of 'GenerateTabScale' which draws on Guitar Fretboard

        'First, split string text in to notes
        'Grab last note and add tab line first
        'process through 24 semitones, placing tab/fret values when they apply

        AddLog("-DrawFretBoard=" & WhatNotes & ";Intervals:" & GenIntsFromNotes(WhatNotes))

        Dim ScaleNotes(), TuningNotes() As String
        Dim CurString, CurNote As Integer
        Dim StringTuning, FretPitch As String

        ScaleNotes = Split(WhatNotes, ",")
        TuningNotes = Split(Tuning, ",")
        StringNo = UBound(TuningNotes) + 1

        frmFretboard.FretClearAll() 'Clear Fretboard

        For CurString = 1 To StringNo 'For each string on instrument
            StringTuning = TuningNotes(StringNo - CurString) 'Current Tuning of String
            For CurFret = FretMin To FretMax 'Search each fret with in range
                FretPitch = Fret2Note(StringTuning, CurFret) 'Current pitch of current fret
                For CurNote = LBound(ScaleNotes) To UBound(ScaleNotes) '- 1 'Search each note of the scale to see if it matches the fret
                    'ScaleNote(CurNote) = note in scale to look for
                    If FretPitch = ScaleNotes(CurNote) Then 'If the current note is in the scale [GUITAR MONEY MAKER]
                        If frmFretboard.Visible = True Then
                            If FretPitch = ScaleNotes(0) Then 'IF THE NOTE IS THE ROOT, PASS RED (functional, but bad technique written after the fact)
                                If oTones = True Then 'Note will have the scale degree drawn on it
                                    frmFretboard.FretDraw(CurString, CurFret, SetNoteClipColor(True), Trim(Str(CurNote + 1)), True)
                                Else
                                    frmFretboard.FretDraw(CurString, CurFret, SetNoteClipColor(True), ScaleNotes(CurNote), True)
                                End If
                            Else
                                If oTones = True Then
                                    frmFretboard.FretDraw(CurString, CurFret, SetNoteClipColor(False), Trim(Str(CurNote + 1)))
                                Else
                                    frmFretboard.FretDraw(CurString, CurFret, SetNoteClipColor(False), ScaleNotes(CurNote))
                                End If
                            End If
                        End If
                    End If
                Next CurNote
            Next CurFret
        Next CurString



    End Sub
    Sub DrawKeyboard(WhatNotes As String, Optional ByVal IsChord As Boolean = False)
        'Accepts CSV string - uses NOTES not INTERVALS

        AddLog("-DrawKeyboard=" & WhatNotes & ";Intervals:" & GenIntsFromNotes(WhatNotes))

        Dim AddNotes() As String
        Dim NoteStep As Integer = 0
        Dim NoteIntervals() As String
        Dim KeysInterval As Integer 'Determines if a key comes BEFORE the root on the keyboard
        Dim StepsFromC As Integer
        Dim DrawOct1, DrawOct2 As Boolean
        Dim OverOctave As Boolean = False



        frmKeyboard.KeyClearAll()
        NoteIntervals = Split(GenIntsFromNotes(WhatNotes), ",")
        If IsChord = True Then
            For Each NoteInt In NoteIntervals
                If NoteInt >= 12 Then
                    OverOctave = True
                End If
            Next
        End If
        AddNotes = Split(WhatNotes, ",") 'Splits the input notes in to individual notes, assuming 0 is the Root

        If frmKeyboard.Visible = True Then 'Only draw keys if the keyboard is visible

            For Each Note In AddNotes
                DrawOct1 = True
                DrawOct2 = True
                KeysInterval = KeyboardStep(Note) - KeyboardStep(AddNotes(0))
                StepsFromC = GenIntFromNotes("C", Note)
                'AddLog("-Drawing Note=" & Note & ";Step=" & (NoteStep + 1) & ";Int=" & NoteIntervals(NoteStep) & ";KeysInterval=" & KeysInterval & ";StepsFromC=" & StepsFromC)

                If OverOctave = True Then
                    If NoteIntervals(NoteStep) >= 12 Then
                        DrawOct1 = False
                        If KeysInterval < 0 And StepsFromC < 12 Then
                            DrawOct1 = True
                            DrawOct2 = False
                        End If
                    ElseIf NoteIntervals(NoteStep) < 12 And StepsFromC < 12 Then
                        DrawOct2 = False
                        If KeysInterval < 0 Then
                            DrawOct1 = False
                            DrawOct2 = True
                        End If
                    ElseIf NoteIntervals(NoteStep) >= 12 And StepsFromC >= 12 Then
                        DrawOct1 = True
                        DrawOct2 = False
                        If KeysInterval < 0 Then
                            DrawOct1 = False
                            DrawOct2 = True
                        End If
                    End If
                End If



                If Note = AddNotes(0) Then
                    If oTones = True Then
                        frmKeyboard.KeyDraw(Note, SetNoteClipColor(True), Trim(Str(NoteStep + 1)), True, DrawOct1, DrawOct2)
                    Else
                        frmKeyboard.KeyDraw(Note, SetNoteClipColor(True), Note, True, DrawOct1, DrawOct2)
                    End If
                Else
                    If oTones = True Then
                        frmKeyboard.KeyDraw(Note, SetNoteClipColor(False), Trim(Str(NoteStep + 1)),, DrawOct1, DrawOct2)
                    Else
                        frmKeyboard.KeyDraw(Note, SetNoteClipColor(False), Note,, DrawOct1, DrawOct2)
                    End If
                End If
                NoteStep += 1
            Next

        End If

    End Sub
    Sub DrawTriadForm()
        'Draws triads on the triad viewer
        frmKeyTriad.KeyClearAll()
        AddLog("-DrawTriadForm")
        For DegreeX = 1 To 7
            DrawTriad(DegreeX)
        Next

    End Sub
    Sub DrawTriad(WhatDegree As Integer)
        'Draws the triad chords on the triad viewer
        Dim CurNotes() As String 'Notes of current mode
        Dim ChordStr As String 'Chords generated from the current notes
        Dim nRoot, nThird, nFifth As String

        CurNotes = Split(CurrentNotes & "," & CurrentNotes & "," & CurrentNotes & "," & CurrentNotes, ",")

        nRoot = CurNotes(2 * 0 + (WhatDegree - 1)) 'Add the Root
        nThird = CurNotes(2 * 1 + (WhatDegree - 1)) 'Add the Third Scale Degree
        nFifth = CurNotes(2 * 2 + (WhatDegree - 1)) 'Add the Fifth Scale Degree

        ChordStr = nRoot & "," & nThird & "," & nFifth

        CurNotes = Split(ChordStr, ",")

        For Each Note In CurNotes
            If frmKeyTriad.Visible = True Then
                If Note = CurNotes(0) Then 'THIS CHECKS FOR ROOT NOTE
                    frmKeyTriad.KeyDraw(Note, Color.Red, WhatDegree)
                Else
                    frmKeyTriad.KeyDraw(Note, Color.Green, WhatDegree)
                End If
            End If
        Next

    End Sub
    Public Function GenerateChord(WhatDegree As Integer) As String
        'Generates basic chords from the notes list, output as CSV data
        Dim ScaleNotes() As String '
        Dim ChordStr As String 'Used multiple times throughout for various purposes
        Dim nRoot, nThird, nFifth, nSeventh, nNinth, nEleventh, n13th As String
        Dim TempRoot() As String
        Dim i As Integer 'WhatDegree

        Dim Temp7 As Boolean = False

        AddLog("-GeneratingChord:WhatDegree=" & WhatDegree)

        i = WhatDegree - 1

        ChordStr = CurrentNotes & "," & CurrentNotes & "," & CurrentNotes & "," & CurrentNotes

        ScaleNotes = Split(ChordStr, ",")
        ChordStr = ""

        nRoot = ScaleNotes(2 * 0 + i) 'Add the Root
        nThird = ScaleNotes(2 * 1 + i) 'Add the Third Scale Degree
        nFifth = ScaleNotes(2 * 2 + i) 'Add the Fifth Scale Degree
        nSeventh = ScaleNotes(2 * 3 + i) 'Get the seventh
        nNinth = ScaleNotes(2 * 4 + i) 'Get the ninth
        nEleventh = ScaleNotes(2 * 5 + i) 'Get the eleventh
        n13th = ScaleNotes(2 * 6 + i) 'Get the 13th

        'Check Third Degree Options (sus2, 4)
        If chkSus2.Checked = True Then
            nThird = ChangePitch(nRoot, 2)
        ElseIf chkMin.Checked = True Then
            nThird = ChangePitch(nRoot, 3)
        ElseIf chkMaj.Checked = True Then
            nThird = ChangePitch(nRoot, 4)
        ElseIf chkSus4.Checked = True Then
            nThird = ChangePitch(nRoot, 5)
        End If

        'Check Fifth Degree Options
        If chkDim.Checked = True Then
            'nFifth = ChangePitch(nFifth, -1)
            nThird = ChangePitch(nRoot, 3)
            nFifth = ChangePitch(nRoot, 6)
        ElseIf chkAug.Checked = True Then
            'nFifth = ChangePitch(nFifth, 1)
            nThird = ChangePitch(nRoot, 4)
            nFifth = ChangePitch(nRoot, 8)
        ElseIf chkAug7.Checked = True Then
            Temp7 = True
            nThird = ChangePitch(nRoot, 4)
            nFifth = ChangePitch(nRoot, 8)
            nSeventh = ChangePitch(nRoot, 10)
        ElseIf chkDim7.Checked = True Then
            Temp7 = True
            nThird = ChangePitch(nRoot, 3)
            nFifth = ChangePitch(nRoot, 6)
            nSeventh = ChangePitch(nRoot, 9)
        End If

        ChordStr = nRoot & "," & nThird & "," & nFifth

        'Check Extended Chord
        If chk7.Checked = True Then 'MAJOR 7TH
            nThird = ChangePitch(nRoot, 4)
            nFifth = ChangePitch(nRoot, 7)
            nSeventh = ChangePitch(nRoot, 11)
            ChordStr = nRoot & "," & nThird & "," & nFifth & "," & nSeventh
        ElseIf chkm7.Checked = True Then 'MINOR 7TH
            nThird = ChangePitch(nRoot, 3)
            nFifth = ChangePitch(nRoot, 7)
            nSeventh = ChangePitch(nRoot, 10)
            ChordStr = nRoot & "," & nThird & "," & nFifth & "," & nSeventh
        ElseIf Temp7 = True Then
            ChordStr += "," & nSeventh
        End If

        If chk9.Checked = True Then 'major 9th
            nThird = ChangePitch(nRoot, 4)
            nFifth = ChangePitch(nRoot, 7)
            nSeventh = ChangePitch(nRoot, 11)
            nNinth = ChangePitch(nRoot, 14)
            ChordStr = nRoot & "," & nThird & "," & nFifth & "," & nSeventh & "," & nNinth
        ElseIf chkm9.Checked = True Then 'minor 9th
            nThird = ChangePitch(nRoot, 3)
            nFifth = ChangePitch(nRoot, 7)
            nSeventh = ChangePitch(nRoot, 11)
            nNinth = ChangePitch(nRoot, 14)
            ChordStr = nRoot & "," & nThird & "," & nFifth & "," & nSeventh & "," & nNinth
        End If

        If chk11.Checked = True Then 'major 11th
            nThird = ChangePitch(nRoot, 4)
            nFifth = ChangePitch(nRoot, 7)
            nSeventh = ChangePitch(nRoot, 11)
            nNinth = ChangePitch(nRoot, 14)
            nEleventh = ChangePitch(nRoot, 17)
            ChordStr = nRoot & "," & nThird & "," & nFifth & "," & nSeventh & "," & nNinth & "," & nEleventh
        ElseIf chkm11.Checked = True Then 'minor 11th
            nThird = ChangePitch(nRoot, 3)
            nFifth = ChangePitch(nRoot, 7)
            nSeventh = ChangePitch(nRoot, 10)
            nNinth = ChangePitch(nRoot, 14)
            nEleventh = ChangePitch(nRoot, 17)
            ChordStr = nRoot & "," & nThird & "," & nFifth & "," & nSeventh & "," & nNinth & "," & nEleventh
        End If

        If chk13.Checked = True Then 'major 13th
            nThird = ChangePitch(nRoot, 4)
            nFifth = ChangePitch(nRoot, 7)
            nSeventh = ChangePitch(nRoot, 11)
            nNinth = ChangePitch(nRoot, 14)
            nEleventh = ChangePitch(nRoot, 17)
            n13th = ChangePitch(nRoot, 21)
            ChordStr = nRoot & "," & nThird & "," & nFifth & "," & nSeventh & "," & nNinth & "," & nEleventh & "," & n13th
        ElseIf chkm13.Checked = True Then 'minor 13th
            nThird = ChangePitch(nRoot, 3)
            nFifth = ChangePitch(nRoot, 7)
            nSeventh = ChangePitch(nRoot, 10)
            nNinth = ChangePitch(nRoot, 14)
            nEleventh = ChangePitch(nRoot, 17)
            n13th = ChangePitch(nRoot, 21)
            ChordStr = nRoot & "," & nThird & "," & nFifth & "," & nSeventh & "," & nNinth & "," & nEleventh & "," & n13th
        End If


        TempRoot = Split(ChordStr, ",") 'So that TempRoot(0) is the 'root' of the chord, ie the 0 note
        LastChord = WhatDegree
        CurrentSemitones = GenIntsFromNotes(ChordStr)

        If frmInfo.Visible = True Then
            frmInfo.txtChord.Text = ChordStr
            frmInfo.txtVals.Text = CurrentSemitones
        End If


        If oAutoshow = True Then
            DrawKeyboard(ChordStr, True)
            DrawFretBoard(ChordStr)
            frmKeyboard.Text = "Keyboard - " & TempRoot(0) & " " & ChordTypeFromCSV(CurrentSemitones)
            frmFretboard.Text = "Fretboard - " & TempRoot(0) & " " & ChordTypeFromCSV(CurrentSemitones)
        End If

        If frmProgressor.Timer1.Enabled = True Then
            If frmProgressor.chkKey.Checked = True Then
                DrawKeyboard(ChordStr, True)
                frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " - " & TempRoot(0) & " " & ChordTypeFromCSV(CurrentSemitones) & " Chord"
            End If
            If frmProgressor.chkFret.Checked = True Then
                DrawFretBoard(ChordStr)
                frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " - " & TempRoot(0) & " " & ChordTypeFromCSV(CurrentSemitones) & " Chord"
            End If
        End If

        Temp7 = False

        GenerateChord = ChordStr

    End Function
    Private Sub cmdChord1_Click(sender As Object, e As EventArgs) Handles cmdChord1.Click
        CurrentChord = GenerateChord(1)
        frmInfo.txtChord.Text = CurrentChord

    End Sub
    Private Sub cmdChord2_Click(sender As Object, e As EventArgs) Handles cmdChord2.Click
        CurrentChord = GenerateChord(2)
        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord3_Click(sender As Object, e As EventArgs) Handles cmdChord3.Click
        CurrentChord = GenerateChord(3)
        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord4_Click(sender As Object, e As EventArgs) Handles cmdChord4.Click
        CurrentChord = GenerateChord(4)
        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord5_Click(sender As Object, e As EventArgs) Handles cmdChord5.Click
        CurrentChord = GenerateChord(5)
        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord6_Click(sender As Object, e As EventArgs) Handles cmdChord6.Click
        CurrentChord = GenerateChord(6)
        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord7_Click(sender As Object, e As EventArgs) Handles cmdChord7.Click
        CurrentChord = GenerateChord(7)
        frmInfo.txtChord.Text = CurrentChord
    End Sub



    Private Sub cmdFretboard_Click(sender As Object, e As EventArgs) Handles cmdFretboard.Click
        frmFretboard.Show()
        RefreshAllForms()
    End Sub

    Private Sub cmdKeyboard_Click(sender As Object, e As EventArgs) Handles cmdKeyboard.Click
        frmKeyboard.Show()
        RefreshAllForms()
    End Sub

    Private Sub cmdMaximize_Click(sender As Object, e As EventArgs) Handles cmdMaximize.Click
        If cmdMaximize.Text = "Expand" Then
            Me.Height = 227
            Me.Width = 504
            cmdMaximize.Text = "Shrink"
        ElseIf cmdMaximize.Text = "Shrink" Then
            Me.Height = 113
            Me.Width = 367
            cmdMaximize.Text = "Expand"
        End If
    End Sub
    Private Sub cmdBuilder_Click(sender As Object, e As EventArgs) Handles cmdBuilder.Click
        frmChordBuilder.Show()
    End Sub
    Private Sub cmdTriadView_Click(sender As Object, e As EventArgs) Handles cmdTriadView.Click
        frmKeyTriad.Show()
        RefreshAllForms()
        frmKeyTriad.cb1.Text = cmdChord1.Text
        frmKeyTriad.cb2.Text = cmdChord2.Text
        frmKeyTriad.cb3.Text = cmdChord3.Text
        frmKeyTriad.cb4.Text = cmdChord4.Text
        frmKeyTriad.cb5.Text = cmdChord5.Text
        frmKeyTriad.cb6.Text = cmdChord6.Text
        frmKeyTriad.cb7.Text = cmdChord7.Text
    End Sub

    Private Sub frmTabTool_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveOptions()
        frmInfo.Close()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        frmOptions.Show()

    End Sub

    Private Sub cmdInfo_Click(sender As Object, e As EventArgs) Handles cmdInfo.Click
        frmInfo.Visible = True
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub cmdTabEditor_Click(sender As Object, e As EventArgs) Handles cmdTabEditor.Click
        frmTabEdit.Show()
    End Sub

    Private Sub cmdProgressor_Click(sender As Object, e As EventArgs) Handles cmdProgressor.Click
        frmProgressor.Show()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
    End Sub

    Private Sub txtVals_TextChanged(sender As Object, e As EventArgs) Handles txtVals.TextChanged
        frmInfo.txtVals.Text = txtVals.Text
    End Sub
End Class
