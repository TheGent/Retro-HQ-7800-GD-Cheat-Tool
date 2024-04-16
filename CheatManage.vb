Imports System.IO
Imports System.Text

Public Class CheatManage

    Dim CRCL1 As String = "#"           ' This is the start Hash for the CRC entry
    Dim CRCNo As String = Nothing       ' No Hash for the CRC entry
    Dim GNStart As String = "; "        ' This is the start semi-colan and space for the Name note
    Dim GNNO As String = Nothing        ' No semi-colan and space for the Name note
    Dim CNStart As String = "["         ' This is the start Open Bracket for the Name note
    Dim CNSNo As String = Nothing       ' No start Open Bracket for the Name note
    Dim CNEnd As String = "]"           ' This is the End Bracket for the Name note
    Dim CNENo As String = Nothing       ' No End Bracket for the Name note
    Dim CNFRAME As String = ":FRAME"    ' This is the :FRAME for the next line after the Name note
    Dim CNFNo As String = Nothing       ' No :FRAME for the next line after the Name note
    Dim AddressStart As String = "@<$"  ' This is the @<$ for the Ram, Address Start
    Dim ASNo As String = Nothing        ' No @<$ for the Ram, Address Start
    Dim ValueStart As String = "="      ' This is the = for the Value Start
    Dim VSNo As String = Nothing        ' No = for the Value Start
    Dim Value2Plus As String = "$"      ' This is the $ insert before more than 2 values for the Value input
    Dim V2PNo As String = Nothing       ' No $ for the next line after the Name note

    Private Declare Auto Function RtfScroll _
                Lib "user32.dll" Alias "SendMessage" (
                ByVal hWnd As IntPtr,
                ByVal Msg As Integer,
                ByVal wParam As IntPtr,
                ByRef lParam As System.Drawing.Point) As Integer

    Private Const WM_USER = &H400
    Private Const EM_GETSCROLLPOS = WM_USER + 221
    Private Const EM_SETSCROLLPOS = WM_USER + 222

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "Atari 7800 GD Rom | *.a78"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim tCRC As CRC_A78 = New CRC_A78()
                tCRC.GenerateA78CRC(.FileName, GameName_TextBox.Text, CRC_TextBox.Text)
                If TextBox1.Lines.Length > 0 Then
                    Dim MatchCRC As String = CRC_TextBox.Text.ToLower()
                    For I = 0 To TextBox1.Lines.Length - 1
                        Dim tLine As String = TextBox1.Lines(I).ToLower()
                        If tLine.Contains(MatchCRC) Then
                            TextBox1.SelectionStart = TextBox1.Find(TextBox1.Lines(I))
                            TextBox1.SelectionLength = MatchCRC.Length + 1
                            TextBox1.ScrollToCaret()
                            Dim pt As New System.Drawing.Point()
                            RtfScroll(RichTextBox1.Handle, EM_GETSCROLLPOS, 0, pt)
                            RtfScroll(TextBox1.Handle, EM_SETSCROLLPOS, 0, pt)
                            TextBox1.Select()
                            Exit For
                        End If
                    Next
                End If
            End If
        End With
    End Sub

    Private Sub Open_Button_Click(sender As System.Object, e As System.EventArgs) Handles Open_Button.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "Atari 7800 GD CHT | *.cht"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim spath As String = .FileName
                Dim SR As New IO.StreamReader(spath)
                Dim data As String = SR.ReadToEnd
                SR.Close()
                TextBox1.Text = data

            End If
        End With
    End Sub

    Private Sub Close_Button_Click(sender As System.Object, e As System.EventArgs) Handles Close_Button.Click
        Close()
    End Sub

    Private Sub ClearText_Click(sender As System.Object, e As System.EventArgs) Handles ClearText.Click
        TextBox1.Text = Nothing
        Address_2.Enabled = True
        Value_2.Enabled = True
        Address_3.Enabled = True
        Value_3.Enabled = True
    End Sub

    Private Sub Save_Button_Click(sender As System.Object, e As System.EventArgs) Handles Save_Button.Click
        Dim iSave As New SaveFileDialog
        iSave.Filter = "Atari 7800 GD CHT | *.cht"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub SUBMIT_BTN_Click(sender As System.Object, e As System.EventArgs) Handles SUBMIT_BTN.Click
        Dim startPos As Integer = 0
        Dim endPos As Integer = 0
        Dim AddNew As Boolean = False

        startPos = TextBox1.Text.IndexOf(CRC_TextBox.Text, StringComparison.InvariantCultureIgnoreCase) - 1
        If startPos < -1 Then
            startPos = TextBox1.TextLength
            endPos = startPos
            AddNew = True
        Else
            endPos = TextBox1.Text.IndexOf("#", startPos + 1) - 1
            If endPos < 0 Then
                endPos = TextBox1.TextLength
            End If
        End If

        If startPos < 0 Then startPos = 0
        If endPos < 0 Then endPos = 0

        TextBox1.SelectionStart = startPos
        TextBox1.SelectionLength = endPos - startPos
        TextBox1.ScrollToCaret()
        TextBox1.Select()

        Dim CheatText As New StringBuilder()
        CheatText.Append(TextBox1.SelectedText)
        Dim slctLen As Integer = endPos - startPos

        If CRC_TextBox.Text = "" Then
            CheatText.Append(CRCNo + "")
            MessageBox.Show("Please enter Game CRC before continuing", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub
        End If

        If GameName_TextBox.Text = "" Then
            CheatText.Append(CRCNo + "")
            MessageBox.Show("Please enter Game Name before continuing", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(CheatName_TextBox.Text) Then
            CheatText.Append(CNSNo + "" + CNENo + CNFNo)
            MessageBox.Show("Please enter Cheat Name before continuing", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub
        End If

        If AddNew Then
            CheatText.Append(vbNewLine & vbNewLine)
            CheatText.Append(CRCL1 + "" + CRC_TextBox.Text)
            CheatText.Append(vbTab + vbTab & GNStart + "" + GameName_TextBox.Text + vbNewLine)
        Else
            If Not (CheatText.ToString().EndsWith(vbCr) OrElse CheatText.ToString().EndsWith(vbLf)) Then
                CheatText.Append(vbCr)
            End If
        End If

        If (String.IsNullOrEmpty(Address_1.Text & Value_1.Text & Address_2.Text & Value_2.Text & Address_3.Text & Value_3.Text)) Then
            MessageBox.Show("Please enter a minimum of one Address and Value to create cheat", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub
        End If

        CheatText.Append(CNStart + "" + CheatName_TextBox.Text + CNEnd + vbNewLine + CNFRAME + vbNewLine)

        If (String.IsNullOrEmpty(Address_1.Text) And String.IsNullOrEmpty(Value_1.Text)) Then
            'CheatText.Append(ASNo + "" + VSNo + "")
            'MessageBox.Show("Please enter an Address and Value before continuing", "Press OK to continue",
            'MessageBoxButtons.OK,
            'MessageBoxIcon.Error)
        Else
            CheatText.Append(AddressStart + "" + Address_1.Text)
            Dim values1 As String = String.Join(",$", Value_1.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            CheatText.Append(ValueStart & "$" & values1 + vbNewLine)
        End If

        If (String.IsNullOrEmpty(Address_2.Text) And String.IsNullOrEmpty(Value_2.Text)) Then
            CheatText.Append(ASNo + "" + VSNo + "")
            'MessageBox.Show("Please enter Address 2 and Value 2 if you have any", "Press OK to continue",
            'MessageBoxButtons.OK,
            'MessageBoxIcon.Error)

            'If Value_2.Text >= 2 Then
            '    CheatText.Append(ValueStart + "" + Value2Plus + Value_2.Text + vbNewLine)
            'End If
        Else
            CheatText.Append(AddressStart + "" + Address_2.Text)
            Dim values2 As String = String.Join(",$", Value_2.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            CheatText.Append(ValueStart & "$" & values2 + vbNewLine)
        End If

        If (String.IsNullOrEmpty(Address_3.Text) And String.IsNullOrEmpty(Value_3.Text)) Then
            CheatText.Append(ASNo + "" + VSNo + "")
            'MessageBox.Show("Please enter an Address 3 and Value 3 if you have any", "Press OK to continue",
            'MessageBoxButtons.OK,
            'MessageBoxIcon.Error)
        Else
            CheatText.Append(AddressStart + "" + Address_3.Text)
            Dim values3 As String = String.Join(",$", Value_3.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            CheatText.Append(ValueStart & "$" & values3 + vbNewLine)
        End If

        TextBox1.SelectedText = CheatText.ToString()

        TextBox1.SelectionStart = endPos
        TextBox1.SelectionLength = CheatText.ToString().Replace(vbCr, "").Length - slctLen

        TextBox1.ScrollToCaret()
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CRC_TextBox.Text = ""
        GameName_TextBox.Text = ""
        CheatName_TextBox.Text = ""
        Address_1.Text = ""
        Value_1.Text = ""
        Address_2.Text = ""
        Value_2.Text = ""
        Address_3.Text = ""
        Value_3.Text = ""
        MessageBox.Show("All Data has been cleared!", "Press OK to continue",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheatParse2.Show()
    End Sub

    Private Sub CheatManage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CheatParse2.Close()
        Main.Show()
    End Sub

    Private Sub CheatManage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(7) Then
            Dim maxLine As Integer = TextBox1.Lines.Length
            If maxLine = 0 Then Return
            Dim GotoLine As Integer = Convert.ToInt32(InputBox("1 - " & maxLine, "Goto Line?", 0))
            If GotoLine < 1 Or GotoLine > maxLine Then
                MessageBox.Show(Me, "Select line from 1 to " & maxLine, "Go to line", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            RichTextBox1.SelectionStart = RichTextBox1.Find(GotoLine.ToString())
            RichTextBox1.ScrollToCaret()
            Dim pt As New System.Drawing.Point()
            RtfScroll(RichTextBox1.Handle, EM_GETSCROLLPOS, 0, pt)
            RtfScroll(TextBox1.Handle, EM_SETSCROLLPOS, 0, pt)
        End If
    End Sub

    Private Sub CheatManage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CRC_TextBox.Select()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim lineNo(TextBox1.Lines.Length()) As String
        For I = 1 To lineNo.Length - 1
            lineNo(I - 1) = I.ToString().PadLeft(5)
        Next I

        RichTextBox1.Lines = lineNo

    End Sub

    Private Sub TextBox1_VScroll(sender As Object, e As EventArgs) Handles TextBox1.VScroll
        Dim pt As New System.Drawing.Point()
        RtfScroll(TextBox1.Handle, EM_GETSCROLLPOS, 0, pt)
        RtfScroll(RichTextBox1.Handle, EM_SETSCROLLPOS, 0, pt)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class