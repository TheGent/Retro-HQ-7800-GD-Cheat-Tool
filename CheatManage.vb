Imports System.IO
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) 
        With OpenFileDialog1
            .FileName = ""
            .Filter = "Atari 7800 GD Rom | *.a78"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim tCRC As CRC_A78 = New CRC_A78()
                tCRC.GenerateA78CRC(.FileName, GameName_TextBox.Text, CRC_TextBox.Text)
            End If
        End With
    End Sub

    Private Sub Open_Button_Click(sender As System.Object, e As System.EventArgs) 
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

    Private Sub Close_Button_Click(sender As System.Object, e As System.EventArgs) 
        Close()
    End Sub

    Private Sub ClearText_Click(sender As System.Object, e As System.EventArgs) 
        TextBox1.Text = Nothing
        Address_2.Enabled = True
        Value_2.Enabled = True
        Address_3.Enabled = True
        Value_3.Enabled = True
    End Sub

    Private Sub Save_Button_Click(sender As System.Object, e As System.EventArgs) 
        Dim iSave As New SaveFileDialog
        iSave.Filter = "Atari 7800 GD CHT | *.cht"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub SUBMIT_BTN_Click(sender As System.Object, e As System.EventArgs)
        TextBox1.AppendText(vbNewLine)
        If CRC_TextBox.Text = "" Then
            TextBox1.AppendText(CRCNo + "")
            MessageBox.Show("Please enter Game CRC before continuing", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        Else
            TextBox1.AppendText(CRCL1 + "" + CRC_TextBox.Text)
        End If

        If GameName_TextBox.Text = "" Then
            TextBox1.AppendText(CRCNo + "")
            MessageBox.Show("Please enter Game Name before continuing", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        Else
            TextBox1.AppendText(vbTab + vbTab & GNStart + "" + GameName_TextBox.Text + vbNewLine)
        End If

        If CheatName_TextBox.Text = "" Then
            TextBox1.AppendText(CNSNo + "" + CNENo + CNFNo)
            MessageBox.Show("Please enter Cheat Name before continuing", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        Else
            TextBox1.AppendText(CNStart + "" + CheatName_TextBox.Text + CNEnd + vbNewLine + CNFRAME + vbNewLine)
        End If

        If (String.IsNullOrEmpty(Address_1.Text) And String.IsNullOrEmpty(Value_1.Text)) Then
            TextBox1.AppendText(ASNo + "" + VSNo + "")
            MessageBox.Show("Please enter an Address and Value before continuing", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

            'If Value_1.Text >= 2 Then
            '    TextBox1.AppendText(ValueStart + "" + Value2Plus + Value_1.Text + vbNewLine)
            'End If
        Else
            TextBox1.AppendText(AddressStart + "" + Address_1.Text)

            If Value_1.Text.Length >= 2 Then
                TextBox1.AppendText(ValueStart & "$" & Value_1.Text + vbNewLine)
            Else
                TextBox1.AppendText(ValueStart & "" & Value_1.Text + vbNewLine)
            End If
        End If

        If (String.IsNullOrEmpty(Address_2.Text) And String.IsNullOrEmpty(Value_2.Text)) Then
            TextBox1.AppendText(ASNo + "" + VSNo + "")
            MessageBox.Show("Please enter Address 2 and Value 2 if you have any", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

            'If Value_2.Text >= 2 Then
            '    TextBox1.AppendText(ValueStart + "" + Value2Plus + Value_2.Text + vbNewLine)
            'End If
        Else
            TextBox1.AppendText(AddressStart + "" + Address_2.Text)

            If Value_2.Text.Length >= 2 Then
                TextBox1.AppendText(ValueStart & "$" & Value_2.Text + vbNewLine)
            Else
                TextBox1.AppendText(ValueStart & "" & Value_2.Text + vbNewLine)
            End If
        End If

        If (String.IsNullOrEmpty(Address_3.Text) And String.IsNullOrEmpty(Value_3.Text)) Then
            TextBox1.AppendText(ASNo + "" + VSNo + "")
            MessageBox.Show("Please enter an Address 3 and Value 3 if you have any", "Press OK to continue",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        Else
            TextBox1.AppendText(AddressStart + "" + Address_3.Text)

            If Value_3.Text.Length >= 2 Then
                TextBox1.AppendText(ValueStart & "$" & Value_3.Text + vbNewLine)
            Else
                TextBox1.AppendText(ValueStart & "" & Value_3.Text + vbNewLine)
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        CheatParse2.Show()
    End Sub

    Private Sub CheatManage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CheatParse2.Close()
        Main.Show()
    End Sub

    Private Sub CheatManage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(7) Then
            Dim maxLine As Integer = TextBox1.Lines.Length
            Dim curLine As Integer = 0 ' TextBox1.s
            Dim GotoLine As Integer = Convert.ToInt32(InputBox("1 - " & maxLine, "Goto Line?", curLine))

            TextBox1.SelectionStart = TextBox1.Find(TextBox1.Lines(GotoLine))
            TextBox1.ScrollToCaret()

        End If
    End Sub

    Private Sub CheatManage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CRC_TextBox.Select()
    End Sub
End Class