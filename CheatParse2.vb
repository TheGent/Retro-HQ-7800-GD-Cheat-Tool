Public Class CheatParse2
    Dim CheatParseClass As New CheatParseClass()

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Open_Button_Click(sender As Object, e As EventArgs)
        With OpenFileDialog1
            .FileName = ""
            .Filter = "Atari 7800 GD CHT | *.cht"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim spath As String = .FileName
                Dim SR As New IO.StreamReader(spath)
                Dim data As String = SR.ReadToEnd
                SR.Close()
                ReportRichTextBox.Text = data
            End If
        End With
    End Sub

    Private Sub CheatParse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportRichTextBox.Text = CheatParseClass.ParseCheatFile("7800GD.CHT")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReportRichTextBox.Text = CheatParseClass.ParseCheatFile("7800GD.CHT")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim iSave As New SaveFileDialog
        iSave.Filter = "Atari 7800 GD CHT | *.cht"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, ReportRichTextBox.Text)
        End If
    End Sub

    Private Sub CheatParse2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'CheatEdit.Close()
        'Main.Show()
    End Sub
End Class



