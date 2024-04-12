<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheatManage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheatManage))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SUBMIT_BTN = New System.Windows.Forms.Button()
        Me.Value_3 = New System.Windows.Forms.TextBox()
        Me.Address_3 = New System.Windows.Forms.TextBox()
        Me.Value_2 = New System.Windows.Forms.TextBox()
        Me.Address_2 = New System.Windows.Forms.TextBox()
        Me.Value_1 = New System.Windows.Forms.TextBox()
        Me.Address_1 = New System.Windows.Forms.TextBox()
        Me.CheatName_TextBox = New System.Windows.Forms.TextBox()
        Me.GameName_TextBox = New System.Windows.Forms.TextBox()
        Me.CRC_TextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.ClearText = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Open_Button = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RichTextBox1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(55, 335)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = ""
        Me.ToolTip1.SetToolTip(Me.RichTextBox1, "Press Ctrl +G to go to an address  line.")
        Me.RichTextBox1.WordWrap = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Select ROM"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(211, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 335)
        Me.Panel1.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(55, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 335)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = ""
        Me.TextBox1.WordWrap = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 414)
        Me.Panel2.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.SUBMIT_BTN)
        Me.GroupBox1.Controls.Add(Me.Value_3)
        Me.GroupBox1.Controls.Add(Me.Address_3)
        Me.GroupBox1.Controls.Add(Me.Value_2)
        Me.GroupBox1.Controls.Add(Me.Address_2)
        Me.GroupBox1.Controls.Add(Me.Value_1)
        Me.GroupBox1.Controls.Add(Me.Address_1)
        Me.GroupBox1.Controls.Add(Me.CheatName_TextBox)
        Me.GroupBox1.Controls.Add(Me.GameName_TextBox)
        Me.GroupBox1.Controls.Add(Me.CRC_TextBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(10, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 392)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Game"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Add Cheat Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Add Cheat Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 34)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Clear All Fields"
        Me.ToolTip1.SetToolTip(Me.Button1, "Clear all above fields to become blank once more")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SUBMIT_BTN
        '
        Me.SUBMIT_BTN.Location = New System.Drawing.Point(9, 348)
        Me.SUBMIT_BTN.Name = "SUBMIT_BTN"
        Me.SUBMIT_BTN.Size = New System.Drawing.Size(84, 34)
        Me.SUBMIT_BTN.TabIndex = 31
        Me.SUBMIT_BTN.Text = "Submit"
        Me.ToolTip1.SetToolTip(Me.SUBMIT_BTN, "Add new cheat to the 7800GD.cht file")
        Me.SUBMIT_BTN.UseVisualStyleBackColor = True
        '
        'Value_3
        '
        Me.Value_3.Location = New System.Drawing.Point(99, 315)
        Me.Value_3.Name = "Value_3"
        Me.Value_3.Size = New System.Drawing.Size(84, 20)
        Me.Value_3.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.Value_3, "Add your 3rd cheat value here if you have one")
        '
        'Address_3
        '
        Me.Address_3.Location = New System.Drawing.Point(9, 315)
        Me.Address_3.Name = "Address_3"
        Me.Address_3.Size = New System.Drawing.Size(84, 20)
        Me.Address_3.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.Address_3, "Add your 3rd cheat address here if you have one")
        '
        'Value_2
        '
        Me.Value_2.Location = New System.Drawing.Point(99, 265)
        Me.Value_2.Name = "Value_2"
        Me.Value_2.Size = New System.Drawing.Size(84, 20)
        Me.Value_2.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.Value_2, "Add your 2nd cheat value here if you have one")
        '
        'Address_2
        '
        Me.Address_2.Location = New System.Drawing.Point(9, 265)
        Me.Address_2.Name = "Address_2"
        Me.Address_2.Size = New System.Drawing.Size(84, 20)
        Me.Address_2.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.Address_2, "Add your 2nd cheat address here if you have one")
        '
        'Value_1
        '
        Me.Value_1.Location = New System.Drawing.Point(99, 215)
        Me.Value_1.Name = "Value_1"
        Me.Value_1.Size = New System.Drawing.Size(84, 20)
        Me.Value_1.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.Value_1, "Add your cheat value here. Clear and use this field for the next cheat if you hav" &
        "e one.")
        '
        'Address_1
        '
        Me.Address_1.Location = New System.Drawing.Point(9, 215)
        Me.Address_1.Name = "Address_1"
        Me.Address_1.Size = New System.Drawing.Size(84, 20)
        Me.Address_1.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.Address_1, "Add your cheat address here. Clear and use this field for the next cheat if you h" &
        "ave one.")
        '
        'CheatName_TextBox
        '
        Me.CheatName_TextBox.Location = New System.Drawing.Point(9, 167)
        Me.CheatName_TextBox.Name = "CheatName_TextBox"
        Me.CheatName_TextBox.Size = New System.Drawing.Size(174, 20)
        Me.CheatName_TextBox.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.CheatName_TextBox, "Add your cheat name here. Clear and use this field for the next cheat if you have" &
        " one.")
        '
        'GameName_TextBox
        '
        Me.GameName_TextBox.Location = New System.Drawing.Point(9, 119)
        Me.GameName_TextBox.Name = "GameName_TextBox"
        Me.GameName_TextBox.Size = New System.Drawing.Size(175, 20)
        Me.GameName_TextBox.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.GameName_TextBox, "The game name gets inserted here from rom load.. Clear this field if you are goin" &
        "g to add another cheat to the same game" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'CRC_TextBox
        '
        Me.CRC_TextBox.Location = New System.Drawing.Point(9, 66)
        Me.CRC_TextBox.Name = "CRC_TextBox"
        Me.CRC_TextBox.Size = New System.Drawing.Size(174, 20)
        Me.CRC_TextBox.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.CRC_TextBox, "The game crc gets inserted here from rom load. Clear this field if you are going " &
        "to add another cheat to the same game")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 41)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Insert CRC and Name"
        Me.ToolTip1.SetToolTip(Me.Button2, "Insert Game CRC & Name into the Text Boxes")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Add Game CRC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Add Game Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Add Cheat Code 3?"
        Me.ToolTip1.SetToolTip(Me.Label6, "This is for a cheat entry with a third address and value")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Add Cheat Code 2?"
        Me.ToolTip1.SetToolTip(Me.Label5, "This is for a cheat entry with a second address and value")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Save_Button)
        Me.Panel3.Controls.Add(Me.ClearText)
        Me.Panel3.Controls.Add(Me.Close_Button)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(211, 371)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(420, 43)
        Me.Panel3.TabIndex = 17
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(10, 10)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(127, 23)
        Me.Save_Button.TabIndex = 20
        Me.Save_Button.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.Save_Button, "This will allow you to save your newly added cheats or edited ones to the 7800GD." &
        "cht file..")
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'ClearText
        '
        Me.ClearText.Location = New System.Drawing.Point(143, 10)
        Me.ClearText.Name = "ClearText"
        Me.ClearText.Size = New System.Drawing.Size(127, 23)
        Me.ClearText.TabIndex = 21
        Me.ClearText.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearText, "This will clear / remove your 7800GD.cht file")
        Me.ClearText.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(276, 10)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(127, 23)
        Me.Close_Button.TabIndex = 22
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Open_Button)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(211, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(420, 36)
        Me.Panel4.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(194, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Parse  7800GD.CHT "
        Me.ToolTip1.SetToolTip(Me.Button3, "This will insert and perform the parse information. Handy if you have added a new" &
        " cheat or editied the file and wish to check it is correct.")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Open_Button
        '
        Me.Open_Button.Location = New System.Drawing.Point(18, 7)
        Me.Open_Button.Name = "Open_Button"
        Me.Open_Button.Size = New System.Drawing.Size(170, 23)
        Me.Open_Button.TabIndex = 22
        Me.Open_Button.Text = "Open  7800GD.CHT "
        Me.ToolTip1.SetToolTip(Me.Open_Button, "This will allow you to load, edit, and use the ability to add new cheats to your " &
        "7800GD.cht file.")
        Me.Open_Button.UseVisualStyleBackColor = True
        '
        'CheatManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(627, 410)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(647, 453)
        Me.Name = "CheatManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "7800 GD Cheat Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SUBMIT_BTN As Button
    Friend WithEvents Value_3 As TextBox
    Friend WithEvents Address_3 As TextBox
    Friend WithEvents Value_2 As TextBox
    Friend WithEvents Address_2 As TextBox
    Friend WithEvents Value_1 As TextBox
    Friend WithEvents Address_1 As TextBox
    Friend WithEvents CheatName_TextBox As TextBox
    Friend WithEvents GameName_TextBox As TextBox
    Friend WithEvents CRC_TextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Save_Button As Button
    Friend WithEvents ClearText As Button
    Friend WithEvents Close_Button As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Open_Button As Button
End Class
