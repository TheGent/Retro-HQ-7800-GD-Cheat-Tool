Imports System.IO
Imports System.Text

Public Class CheatParseClass

    Public Enum ECheatOptionType
        ECheatOptionType_UnsignedByte = 0
        ECheatOptionType_SignedByte
        ECheatOptionType_Enum
        ECheatOptionType_INVALID
    End Enum

    Public Enum EProgramType
        EProgramType_Off = 0
        EProgramType_On
        EProgramType_Frame
        EProgramType_INVALID
    End Enum

    Dim sbConsole As StringBuilder = New StringBuilder()

    Function ReadCheatLine(ByRef [out] As String, ByVal maxRead As UInteger, ByVal file As StreamReader, ByRef errorPos As UInteger) As Boolean
        Dim comment As Boolean = False
        Dim instring As Boolean = False
        Dim c As Char
        Dim linePos As UInteger = 0
        maxRead -= 1

        ' read a character at a time
        While True
            c = ChrW(file.Read())
            If file.EndOfStream Then
                Exit While
            End If
            linePos += 1

            ' ignore space (outside of strings) cr and tab
            If (Not instring AndAlso c = " "c) OrElse c = ChrW(13) OrElse c = ChrW(9) Then
                Continue While
            End If

            ' start / end of string
            If c = "["c Then
                If instring Then
                    errorPos = linePos
                    Return False
                End If
                instring = True
            End If
            If c = "]"c Then
                If Not instring Then
                    errorPos = linePos
                    Return False
                End If
                instring = False
            End If

            ' if we find a semicolon then ignore the rest of the line
            If c = ";"c Then
                comment = True
                Continue While
            End If

            ' lf terminates the line read
            If c = ChrW(10) Then
                Exit While
            End If

            ' keep character we want
            If Not comment AndAlso maxRead > 0 Then
                [out] += c
                maxRead -= 1
            End If
        End While

        errorPos = 0

        Return maxRead <> 0 AndAlso Not instring
    End Function

    Function ParseNumber(ByRef [out] As UInteger, ByVal [in] As String) As Integer
        Dim val As UInteger = 0
        Dim base As UInteger = 10
        Dim pos As Integer = 0
        If [in].Length = 0 Then
            [out] = 0
            Return pos
        End If
        ' first character can be $ or % to set base
        Dim c As Char = [in](0)
        If c = "$"c OrElse c = "%"c Then
            pos = pos + 1
            If c = "$"c Then
                base = 16
            Else
                base = 2
            End If
        End If

        'For Each ch As Char In [in]
        While (pos < [in].Length)
            ' get character and force lowercase
            Dim ch As Char = [in](pos)
            c = Char.ToLower(ch)


            Dim tVal As Integer = "0123456789abcdef".IndexOf(c)
            ' valid hex characters
            If tVal < 0 Then
                Exit While
            End If

            pos += 1
            val = (val * base) + tVal
        End While


        [out] = val

        Return pos
    End Function

    Function GetStringLength(ByVal p As String) As UInteger
        If p(0) <> "["c Then
            Return 0
        End If
        Dim len As UInteger = 0
        For Each c As Char In p.Substring(1)
            If c = "]"c Then
                Exit For
            End If
            len += 1
        Next

        Return len
    End Function

    Function FindParamType(ByRef pType As ECheatOptionType, ByVal pStr As String) As Integer
        Dim nType As ECheatOptionType = ECheatOptionType.ECheatOptionType_INVALID
        Dim c As Char = Char.ToLower(pStr(0))
        Dim p As Integer = 1
        Dim nSigned As Byte = &HFF
        If c = "u"c OrElse c = "s"c Then
            nSigned = If(c = "s"c, 1, 0)
            c = Char.ToLower(pStr(1))
            p += 1
        End If

        Select Case c
            'Case "e"c
            '    If nSigned <> &HFF Then
            '        nType = ECheatOptionType_Enum
            '    End If
            '    Exit Select

            Case "b"c
                nType = If(nSigned = 1, ECheatOptionType.ECheatOptionType_SignedByte, ECheatOptionType.ECheatOptionType_UnsignedByte)
                Exit Select
        End Select

        pType = nType

        Return p
    End Function

    Function FindParamRange(ByRef pMin As Byte, ByRef pMax As Byte, ByRef pError As Boolean, ByVal pStr As String) As Integer
        Dim bError As Boolean = False
        Dim min As UInteger = 0, max As UInteger = &HFF
        Dim p As Integer = 0

        If pStr(0) = "{"c Then
            p += 1

            Dim num1, num2 As UInteger
            p += ParseNumber(num1, pStr.Substring(p))
            bError = pStr(p) <> "-"c
            p += 1
            If Not bError Then
                p += ParseNumber(num2, pStr.Substring(p))
                'p += 1
                bError = pStr(p) <> "}"c

                If Not bError Then
                    If num1 < num2 Then
                        min = num1
                        max = num2
                    Else
                        min = num2
                        max = num1
                    End If
                End If
            End If
        End If

        pMin = min
        pMax = max
        pError = bError

        Return p
    End Function

    Function GetProgramType(ByVal pStr As String) As EProgramType
        ' these match EProgramType in order
        Dim aType() As String = {"OFF", "ON", "FRAME"}
        For n As UInteger = 0 To aType.Length '\ 4 - 1
            If String.Compare(aType(n), pStr, True) = 0 Then
                Return CType(n, EProgramType)
            End If
        Next
        Return EProgramType.EProgramType_INVALID
    End Function

    Sub ShowErrorContext(ByVal pLine As String, ByVal nChar As Integer)
        ' show upto 16 characters before the bad character
        Dim start As Integer = nChar - 16
        If start < 0 Then
            start = 0
        End If

        ' show a max of 32 characters
        sbConsole.AppendLine(pLine.Substring(start, Math.Min(32, pLine.Length - start - 1)))

        ' mark the bad character
        For i As Integer = 1 To nChar - 1
            sbConsole.AppendFormat(" ")
        Next
        sbConsole.AppendLine(String.Format("^"))
    End Sub

    Function ParseCheats(ByVal pFilename As String, ByRef pCheats As UInteger) As UInteger
        Dim file As StreamReader
        Dim szLine As String = String.Empty
        Dim linePos As UInteger = 0
        Dim inCheat As Boolean = False
        Dim inProgram As Boolean = False
        Dim nCheatDefined As UInteger = 0
        Dim nErrors As UInteger = 0
        Dim nCheats As UInteger = 0

        sbConsole.Clear()

        Try
            file = New StreamReader(pFilename)
        Catch ex As Exception
            sbConsole.AppendLine(String.Format("Unable to open '{0}' for reading.", pFilename))
            pCheats = 0
            Return 0
        End Try

        While Not file.EndOfStream
            Dim errorPos As UInteger
            linePos += 1
            szLine = String.Empty

            ' read one line stripping whitespace
            If Not ReadCheatLine(szLine, 256, file, errorPos) Then
                If errorPos <> 0 Then
                    sbConsole.AppendLine(String.Format("Line({0}:{1}): unexpected character, line skipped.", linePos, errorPos))

                    szLine = szLine.Substring(0, errorPos)
                    ShowErrorContext(szLine, errorPos)
                    nErrors += 1
                Else
                    sbConsole.AppendLine(String.Format("Line({0}): too long or missing ], line skipped.", linePos))
                End If

                Continue While
            End If

            ' skip blank lines
            If szLine.Length = 0 Then
                Continue While
            End If

            ' different things valid in a cheat definition block
            If inProgram Then
                ' on next option, program or cheat start, exit parsing program
                If szLine(0) = "["c OrElse szLine(0) = ":"c OrElse szLine(0) = "#"c Then
                    inProgram = False
                Else
                    ' process line
                    'Dim p As String = szLine
                    Dim p As Integer = 0
                    'For Each c As Char In p
                    While (p < szLine.Length)
                        Dim c As Char = szLine(p)
                        p += 1
                        ' get character
                        Dim ch As Char = c

                        ' set address
                        If ch = "@"c Then
                            ' check for low RAM writes, these are in 7800 address space
                            If szLine(p) = "<"c Then
                                p = p + 1
                            End If

                            Dim addr As UInteger
                            p += ParseNumber(addr, szLine.Substring(p)) ' + 1
                            'End If

                            ' write to current address pointer
                            ' can be multiple writes with comma separated list
                        ElseIf ch = "="c Then
                            Dim expectingData As Boolean = True
                            'For Each ch2 As Char In p
                            While (p < szLine.Length)
                                Dim ch2 As Char = szLine(p)
                                Dim bUnexpected As Boolean = False

                                ' parameter write
                                If ch2 = "["c Then
                                    bUnexpected = Not expectingData
                                    errorPos = p + 1

                                    Dim len As UInteger = GetStringLength(szLine.Substring(szLine.IndexOf(ch2, p)))
                                    p += len + 2
                                    expectingData = False
                                ElseIf ch2 = ","c Then
                                    bUnexpected = expectingData
                                    errorPos = p + 1 'szLine.IndexOf(ch2, p) + 1
                                    p += 1
                                    expectingData = True
                                Else
                                    ' otherwise assume constant write
                                    bUnexpected = Not expectingData
                                    errorPos = p + 1 'szLine.IndexOf(ch2, p) + 1

                                    Dim val As UInteger
                                    p += ParseNumber(val, szLine.Substring(p)) ' + 1
                                    expectingData = False
                                End If

                                If bUnexpected Then
                                    errorPos = p
                                    sbConsole.AppendLine(String.Format("Line({0}:{1}): unexpected character in data list.", linePos, errorPos))
                                    ShowErrorContext(szLine, errorPos)
                                    nErrors += 1
                                End If
                            End While
                            'Next
                        Else
                            ' invalid chatacter
                            errorPos = p 'szLine.IndexOf(ch, p)
                            sbConsole.AppendLine(String.Format("Line({0}:{1}): unexpected character in cheat block.", linePos, errorPos))
                            ShowErrorContext(szLine, errorPos)
                            nErrors += 1
                        End If
                    End While

                    Continue While
                End If
            End If

            ' cheat start
            If szLine(0) = "#"c Then
                ' check the CRC(s) are OK
                Dim numcrc As UInteger = 0
                Dim crc As Integer = 0 + 1
                While (crc < szLine.Length)
                    Dim crcno As UInteger
                    crc += ParseNumber(crcno, szLine.Substring(crc)) '+ 1
                    If crc < szLine.Length Then
                        If szLine(crc) <> ","c Then
                            errorPos = crc + 1
                            sbConsole.AppendLine(String.Format("Line({0}:{1}): unexpected character in CRC list.", linePos, errorPos))
                            ShowErrorContext(szLine, errorPos)
                            nErrors += 1
                            Exit While
                        End If
                        crc += 1
                    End If
                    numcrc += 1
                End While
                If numcrc = 0 Then
                    errorPos = 2
                    sbConsole.AppendLine(String.Format("Line({0}:{1}): CRC list empty.", linePos, errorPos))
                    ShowErrorContext(szLine, errorPos)
                    nErrors += 1
                End If
                nCheats += 1
                'End If

                ' cheat option
            ElseIf szLine(0) = "["c Then
                ' check the option line is not malformed
                Dim len As UInteger = GetStringLength(szLine)
                'If szLine(len + 2) <> ChrW(0) Then
                '    errorPos = len + 3
                '    sbConsole.AppendLine(String.Format("Line({0}:{1}): unexpected character.", linePos, errorPos))
                '    ShowErrorContext(szLine, errorPos)
                '    nErrors += 1
                'End If
                nCheatDefined = 0
                'End If

                ' parameter
            ElseIf szLine(0) = "?"c Then
                ' check parameter string is ok
                Dim len As UInteger = GetStringLength(szLine.Substring(1))
                If szLine(1) <> "["c Then
                    errorPos = 2
                    sbConsole.AppendLine(String.Format("Line({0}:{1}): option name missing ?[...], line skipped.", linePos, errorPos))
                    ShowErrorContext(szLine, errorPos)
                    nErrors += 1
                    Continue While
                End If

                ' next is the type details, requires = first
                'Dim p As String = szLine.Substring(len + 3)
                Dim p As Integer = len + 3
                If szLine(p) <> "="c Then
                    errorPos = len + 4
                    sbConsole.AppendLine(String.Format("Line({0}:{1}): parameter type missing.", linePos, errorPos))
                    ShowErrorContext(szLine, errorPos)
                    nErrors += 1
                    Continue While
                End If
                p += 1
                ' now actual type, can be --
                ' [U/S]B	[un]signed byte
                ' E		enum

                errorPos = p + 1 ' possible error pos
                Dim eType As ECheatOptionType
                p += FindParamType(eType, szLine.Substring(p))
                If eType = ECheatOptionType.ECheatOptionType_INVALID Then
                    sbConsole.AppendLine(String.Format("Line({0}:{1}): invalid parameter type.", linePos, errorPos))
                    ShowErrorContext(szLine, errorPos)
                    nErrors += 1
                    Continue While
                End If

                ' if type is valid then check for further details
                Select Case eType
                    ' signed and unsigned bytes can have a range
                    Case ECheatOptionType.ECheatOptionType_UnsignedByte, ECheatOptionType.ECheatOptionType_SignedByte
                        Dim min, max As Byte
                        Dim bError As Boolean = False
                        p += FindParamRange(min, max, bError, szLine.Substring(p))
                        errorPos = p

                        If Not bError AndAlso p < szLine.Length > 0 Then
                            If bError OrElse szLine(p) <> ":"c Then
                                errorPos = szLine.IndexOf("="c, p) + 1
                            Else
                                Dim num As UInteger
                                p += ParseNumber(num, szLine.Substring(p))

                                If p < szLine.Length Then
                                    errorPos = szLine.IndexOf("="c, p) + 1
                                End If
                            End If
                        End If
                        If bError Then
                            sbConsole.AppendLine(String.Format("Line({0}:{1}): invalid character in parameter range.", linePos, errorPos))
                            ShowErrorContext(szLine, errorPos)
                            nErrors += 1
                        End If
                End Select
                'End If

                ' actions
            ElseIf szLine(0) = ":"c Then
                ' see if we have a valid cheat type
                Dim eProgType As EProgramType = GetProgramType(szLine.Substring(1))
                If eProgType = EProgramType.EProgramType_INVALID Then
                    errorPos = 2
                    sbConsole.AppendLine(String.Format("Line({0}:{1}): invalid cheat type.", linePos, errorPos))
                    ShowErrorContext(szLine, errorPos)
                    nErrors += 1
                    Continue While
                End If

                inProgram = True

                ' check it's not already defined
                If (nCheatDefined And (1 << CInt(eProgType))) <> 0 Then
                    errorPos = 1
                    sbConsole.AppendLine(String.Format("Line({0}:{1}): cheat type is already defined for this option.", linePos, errorPos))
                    ShowErrorContext(szLine, errorPos)
                    nErrors += 1
                    Continue While
                End If
                nCheatDefined = nCheatDefined Or (1 << CInt(eProgType))
            Else
                errorPos = 1
                sbConsole.AppendLine(String.Format("Line({0}:{1}): unexpected character.", linePos, errorPos))
                ShowErrorContext(szLine, errorPos)
                nErrors += 1
            End If
        End While
        pCheats = nCheats
        file.Close()
        Return nErrors
    End Function

    Function ParseCheatFile(CheatFileName As String) As String
        Dim pCheats As UInteger
        Dim nErrors As UInteger = ParseCheats(CheatFileName, pCheats)
        sbConsole.AppendLine(String.Format("Number of cheats: {0}", pCheats))
        sbConsole.AppendLine(String.Format("Number of errors: {0}", nErrors))
        Return sbConsole.ToString()
    End Function

End Class
