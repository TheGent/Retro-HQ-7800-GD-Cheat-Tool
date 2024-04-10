Public Class CheatEdit
    Private newtext As String

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        Dim iSave As New SaveFileDialog
        iSave.Filter = "Atari 7800 GD CHT | *.cht"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, ReportRichTextBox.Text)
        End If
    End Sub
End Class



