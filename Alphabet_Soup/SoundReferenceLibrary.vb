Module SoundReferenceLibrary

    Public Const TITLE = "TITLE"
    Public Const INSTRUCTION = "INSTRUCTION"
    Public Const LETTER = "LETTER"
    Public Const WORD = "WORD"
    Public Const CORRECT = "CORRECT"
    Public Const WRONG = "WRONG"
    Public Const WRONG_LONG = "WRONGL"

    Function GetLetterSoundFile(letter As Char) As IO.UnmanagedMemoryStream

        Select Case letter
            Case "A"
                Return My.Resources.A
            Case "B"
                Return My.Resources.B
            Case "C"
                Return My.Resources.C
            Case "D"
                Return My.Resources.D
            Case "E"
                Return My.Resources.E
            Case "F"
                Return My.Resources.F
            Case "G"
                Return My.Resources.G
            Case "H"
                Return My.Resources.H
            Case "I"
                Return My.Resources.I
            Case "J"
                Return My.Resources.J
            Case "K"
                Return My.Resources.K
            Case "L"
                Return My.Resources.L
            Case "M"
                Return My.Resources.M
            Case "N"
                Return My.Resources.N
            Case "O"
                Return My.Resources.O
            Case "P"
                Return My.Resources.P
            Case "Q"
                Return My.Resources.Q
            Case "R"
                Return My.Resources.R
            Case "S"
                Return My.Resources.S
            Case "T"
                Return My.Resources.T
            Case "U"
                Return My.Resources.U
            Case "V"
                Return My.Resources.V
            Case "W"
                Return My.Resources.W
            Case "X"
                Return My.Resources.X
            Case "Y"
                Return My.Resources.Y
            Case "Z"
                Return My.Resources.Z
        End Select

        Return Nothing

    End Function

    Function GetWordSoundFile(word As String) As IO.UnmanagedMemoryStream

        Select Case word.ToUpper()
            Case "ANT"
                Return My.Resources.Ant
            Case "BOOK"
                Return My.Resources.Book
            Case "CAT"
                Return My.Resources.Cat
            Case "DOG"
                Return My.Resources.Dog
            Case "FLOWER"
                Return My.Resources.Flower
            Case "HOUSE"
                Return My.Resources.House
            Case "MOUSE"
                Return My.Resources.Mouse
            Case "TELEPHONE"
                Return My.Resources.Telephone
            Case "VIOLIN"
                Return My.Resources.Violin
            Case "WATERMELON"
                Return My.Resources.Watermelon
            Case "APPLE"
                Return My.Resources.Apple
            Case "BAT"
                Return My.Resources.Bat
            Case "CAR"
                Return My.Resources.Car
            Case "EAT"
                Return My.Resources.Eat
            Case "FAT"
                Return My.Resources.Fat
            Case "GAME"
                Return My.Resources.Game
            Case "HAT"
                Return My.Resources.Hat
            Case "ICE"
                Return My.Resources.Ice
        End Select

        Return Nothing

    End Function

    Function GetGameTitleSound(title As String) As IO.UnmanagedMemoryStream

        Select Case title
            Case "SOUND OFF"
                Return My.Resources.Title_Sound_Off
            Case "GRADE BOOK"
                Return My.Resources.Title_Grade_Book
            Case "ALPHABET SKETCH"
                Return My.Resources.Title_Alphabet_Sketch
            Case "WHAT AM I"
                Return My.Resources.Title_What_Am_I
            Case "FIND ME"
                Return My.Resources.Title_Find_Me
        End Select

        Return Nothing

    End Function


    Function GetGameTitleInstructions(title As String) As IO.UnmanagedMemoryStream

        Select Case title
            Case "SOUND OFF"
                Return My.Resources.Instruction_Tap_Speaker_Type_Keyboard
            Case "ALPHABET SKETCH"
                Return My.Resources.Instruction_Trace_Outline
            Case "WHAT AM I"
                Return My.Resources.Instruction_Drag_Letter_Word
            Case "FIND ME"
                Return My.Resources.Instruction_Drag_Letter_Toybox
        End Select

        Return Nothing

    End Function

    Function GetMistakeSound() As IO.UnmanagedMemoryStream

        Return My.Resources.Instruction_Try_Again_Short

    End Function

    Function GetMistakeSoundLong() As IO.UnmanagedMemoryStream

        Return My.Resources.Instruction_Try_Again

    End Function

    Function GetCorrectSound() As IO.UnmanagedMemoryStream

        Return My.Resources.Correct_Answer

    End Function

    Sub PlayAudio(value As String, keyWord As String)
        Select Case keyWord.ToUpper()
            Case TITLE
                'playSoundEffect(GetGameTitleSound(value))
                My.Computer.Audio.Play(GetGameTitleSound(value), AudioPlayMode.Background)
            Case INSTRUCTION
                If value.ToUpper() <> "GRADE BOOK" Then
                    'playSoundEffect(GetGameTitleInstructions(value))
                    My.Computer.Audio.Play(GetGameTitleInstructions(value), AudioPlayMode.Background)
                End If
            Case LETTER
                'playSoundEffect(GetLetterSoundFile(value))
                My.Computer.Audio.Play(GetLetterSoundFile(value), AudioPlayMode.Background)
            Case WORD
                'playSoundEffect(GetWordSoundFile(value))
                My.Computer.Audio.Play(GetWordSoundFile(value), AudioPlayMode.Background)
            Case CORRECT
                'playSoundEffect(GetCorrectSound())
                My.Computer.Audio.Play(GetCorrectSound(), AudioPlayMode.Background)
            Case WRONG
                'playSoundEffect(GetMistakeSound())
                My.Computer.Audio.Play(GetMistakeSound(), AudioPlayMode.Background)
            Case WRONG_LONG
                ' playSoundEffect(GetMistakeSoundLong())
                My.Computer.Audio.Play(GetMistakeSoundLong(), AudioPlayMode.Background)
        End Select
    End Sub

    Public Sub playSoundEffect(soundEffect As System.IO.UnmanagedMemoryStream)
        Dim tempPath = IO.Path.Combine(IO.Path.GetTempPath, "AlphaBooksSoundEffect.wav")

        Dim soundEffectMemStream As New System.IO.MemoryStream
        soundEffect.CopyTo(soundEffectMemStream)
        Dim soundEffectBytes() As Byte = soundEffectMemStream.ToArray

        Form1.mciSendString("close SoundEffect", String.Empty, 0, 0)
        IO.File.WriteAllBytes(tempPath, soundEffectBytes)

        Form1.mciSendString(String.Format("open ""{0}"" type mpegvideo alias SoundEffect", tempPath), String.Empty, 0, 0)
        Form1.mciSendString("play SoundEffect repeat", String.Empty, 0, 0)
        SetBackgroundAudio(150)
    End Sub

    Public Sub SetBackgroundAudio(volumeLevel As Integer)
        'Dim tempPath = IO.Path.Combine(IO.Path.GetTempPath, "AlphaBooksSoundEffect.wav")
        Form1.mciSendString("setaudio SoundEffect volume to " + volumeLevel.ToString(), String.Empty, 0, 0)
    End Sub


End Module
