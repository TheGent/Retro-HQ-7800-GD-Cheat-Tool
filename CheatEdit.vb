Public Class CheatEdit
    Private newtext As String

    Private Declare Auto Function RtfScroll _
                Lib "user32.dll" Alias "SendMessage" (
                ByVal hWnd As IntPtr,
                ByVal Msg As Integer,
                ByVal wParam As IntPtr,
                ByRef lParam As System.Drawing.Point) As Integer

    Private Const WM_USER = &H400
    Private Const EM_GETSCROLLPOS = WM_USER + 221
    Private Const EM_SETSCROLLPOS = WM_USER + 222

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub
    Private Sub CheatEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(7) Then
            Me.TopMost = False
            Dim maxLine As Integer = ReportRichTextBox.Lines.Length
            If maxLine = 0 Then Return
            Dim GotoLine As Integer = Convert.ToInt32(InputBox("1 - " & maxLine, "Goto Line?", 0))
            If GotoLine < 1 Or GotoLine > maxLine Then
                MessageBox.Show(Me, "Select line from 1 to " & maxLine, "Go to line", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.TopMost = True
                Return
            End If

            Me.TopMost = True
            LineNoRichTextBox.SelectionStart = LineNoRichTextBox.Find(GotoLine.ToString())
            LineNoRichTextBox.ScrollToCaret()
            Dim pt As New System.Drawing.Point()
            RtfScroll(LineNoRichTextBox.Handle, EM_GETSCROLLPOS, 0, pt)
            RtfScroll(ReportRichTextBox.Handle, EM_SETSCROLLPOS, 0, pt)
        End If
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

    Private Sub ReportRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReportRichTextBox.TextChanged
        Dim LineNo(ReportRichTextBox.Lines.Length) As String
        For I = 1 To LineNo.Length - 1
            LineNo(I - 1) = I.ToString().PadLeft(5)
        Next
        LineNoRichTextBox.Lines = LineNo
    End Sub

    Private Sub ReportRichTextBox_VScroll(sender As Object, e As EventArgs) Handles ReportRichTextBox.VScroll
        Dim pt As New System.Drawing.Point()
        RtfScroll(ReportRichTextBox.Handle, EM_GETSCROLLPOS, 0, pt)
        RtfScroll(LineNoRichTextBox.Handle, EM_SETSCROLLPOS, 0, pt)
    End Sub

    Private Sub CheatEdit_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ReportRichTextBox_TextChanged(sender, New EventArgs())
    End Sub
End Class



