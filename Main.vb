Imports System.Diagnostics
Imports System.IO
Public Class Main

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'This auto sets the dropdown bar to selet the chosen value on start up
        If ComboBox1.SelectedIndex = -1 Then
            ComboBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button_Submit_Click(sender As System.Object, e As System.EventArgs) Handles Button_Submit.Click
        'This is the ComboBox showing your options in the dropdown.

        'IO.File.WriteAllBytes("7800GDCheat.exe", My.Resources._7800GDCheat)

        If Me.ComboBox1.Text = "Parse 7800GD.CHT File" Then
            Try
                CheatParse.Show(Me)
                Me.Hide()
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace.ToString())
            End Try
        End If

        If Me.ComboBox1.Text = "ROM Information" Then
            With OpenFileDialog1
                .FileName = ""
                .Filter = "Atari 7800 GD Rom | *.a78"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim tCRC As CRC_A78 = New CRC_A78()
                    tCRC.GenerateA78CRC(.FileName, RomInfo.GameName_TextBox.Text, RomInfo.CRC_TextBox.Text)
                    RomInfo.Show()
                    Me.Hide()
                End If
            End With

        End If

        If Me.ComboBox1.Text = "Cheat Management" Then
            CheatManage.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AboutBox.Show()
        Me.Hide()
    End Sub


    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.retrohq.co.uk/products/atari-7800-gamedrive-flash-cartridge")
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("https://github.com/TheGent/Retro-HQ-7800-GD-Cheat-Tool")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://github.com/TheGent/Retro-HQ-7800-GD-Cheat-Tool/tree/main/7800GD.CHT%20File")
    End Sub

    Private Sub Parse7800GDCHTFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Parse7800GDCHTFileToolStripMenuItem.Click
        Try
            CheatParse.Show(Me)
            Me.Hide()
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
        End Try
    End Sub

    Private Sub RomInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RomInformationToolStripMenuItem.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "Atari 7800 GD Rom | *.a78"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim tCRC As CRC_A78 = New CRC_A78()
                tCRC.GenerateA78CRC(.FileName, RomInfo.GameName_TextBox.Text, RomInfo.CRC_TextBox.Text)
                RomInfo.Show()
                Me.Hide()
            End If
        End With
    End Sub

    Private Sub OpenAtariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenAtariToolStripMenuItem.Click
        CheatManage.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        CheatManage.Close()
        AboutBox.Close()
        Close()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Process.Start("https://github.com/TheGent/Retro-HQ-7800-GD-Cheat-Tool")
    End Sub

    Private Sub UserManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManualToolStripMenuItem.Click
        Process.Start("https://github.com/TheGent/Retro-HQ-7800-GD-Cheat-Tool/wiki")
    End Sub

    Private Sub Latest7800GDCHTFIleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Latest7800GDCHTFIleToolStripMenuItem.Click
        Process.Start("https://github.com/TheGent/Retro-HQ-7800-GD-Cheat-Tool/tree/main/7800GD.CHT%20File")
    End Sub

    Private Sub RetroHQ7800GDProductLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetroHQ7800GDProductLinkToolStripMenuItem.Click
        Process.Start("https://www.retrohq.co.uk/products/atari-7800-gamedrive-flash-cartridge")
    End Sub
End Class
