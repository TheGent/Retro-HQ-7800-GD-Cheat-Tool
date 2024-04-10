Public Class RomInfo

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Close_Button.Click
        Close()
        Main.Show()
    End Sub

    Private Sub Copy_Button_Click(sender As System.Object, e As System.EventArgs) Handles Copy_Button.Click
        If GameName_TextBox.TextLength + CRC_TextBox.TextLength > 0 Then Clipboard.SetText(Label1.Text + vbTab & GameName_TextBox.Text + vbNewLine + Label2.Text + vbTab & CRC_TextBox.Text)
        MessageBox.Show("Your information has been copied to clipboard", "Press OK to continue",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)
    End Sub
End Class