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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.ClearText = New System.Windows.Forms.Button()
        Me.Open_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Add Cheat Code 3?"
        Me.ToolTip1.SetToolTip(Me.Label6, "This is for a cheat entry with a third address and value")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Add Cheat Code 2?"
        Me.ToolTip1.SetToolTip(Me.Label5, "This is for a cheat entry with a second address and value")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Select ROM"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Save_Button)
        Me.Panel1.Controls.Add(Me.ClearText)
        Me.Panel1.Controls.Add(Me.Open_Button)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(209, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 398)
        Me.Panel1.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(43, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(354, 333)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = ""
        Me.TextBox1.WordWrap = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(203, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Parse  7800GD.CHT "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(4, 371)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(127, 23)
        Me.Save_Button.TabIndex = 17
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'ClearText
        '
        Me.ClearText.Location = New System.Drawing.Point(137, 371)
        Me.ClearText.Name = "ClearText"
        Me.ClearText.Size = New System.Drawing.Size(127, 23)
        Me.ClearText.TabIndex = 18
        Me.ClearText.Text = "Clear"
        Me.ClearText.UseVisualStyleBackColor = True
        '
        'Open_Button
        '
        Me.Open_Button.Location = New System.Drawing.Point(27, 5)
        Me.Open_Button.Name = "Open_Button"
        Me.Open_Button.Size = New System.Drawing.Size(170, 23)
        Me.Open_Button.TabIndex = 20
        Me.Open_Button.Text = "Open  7800GD.CHT "
        Me.Open_Button.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(270, 371)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(127, 23)
        Me.Close_Button.TabIndex = 19
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(58, 333)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 392)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Game"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 34)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Clear All Fields"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SUBMIT_BTN
        '
        Me.SUBMIT_BTN.Location = New System.Drawing.Point(9, 348)
        Me.SUBMIT_BTN.Name = "SUBMIT_BTN"
        Me.SUBMIT_BTN.Size = New System.Drawing.Size(84, 34)
        Me.SUBMIT_BTN.TabIndex = 31
        Me.SUBMIT_BTN.Text = "Submit"
        Me.SUBMIT_BTN.UseVisualStyleBackColor = True
        '
        'Value_3
        '
        Me.Value_3.Location = New System.Drawing.Point(99, 315)
        Me.Value_3.Name = "Value_3"
        Me.Value_3.Size = New System.Drawing.Size(84, 20)
        Me.Value_3.TabIndex = 30
        '
        'Address_3
        '
        Me.Address_3.Location = New System.Drawing.Point(9, 315)
        Me.Address_3.Name = "Address_3"
        Me.Address_3.Size = New System.Drawing.Size(84, 20)
        Me.Address_3.TabIndex = 29
        '
        'Value_2
        '
        Me.Value_2.Location = New System.Drawing.Point(99, 265)
        Me.Value_2.Name = "Value_2"
        Me.Value_2.Size = New System.Drawing.Size(84, 20)
        Me.Value_2.TabIndex = 28
        '
        'Address_2
        '
        Me.Address_2.Location = New System.Drawing.Point(9, 265)
        Me.Address_2.Name = "Address_2"
        Me.Address_2.Size = New System.Drawing.Size(84, 20)
        Me.Address_2.TabIndex = 27
        '
        'Value_1
        '
        Me.Value_1.Location = New System.Drawing.Point(99, 215)
        Me.Value_1.Name = "Value_1"
        Me.Value_1.Size = New System.Drawing.Size(84, 20)
        Me.Value_1.TabIndex = 26
        '
        'Address_1
        '
        Me.Address_1.Location = New System.Drawing.Point(9, 215)
        Me.Address_1.Name = "Address_1"
        Me.Address_1.Size = New System.Drawing.Size(84, 20)
        Me.Address_1.TabIndex = 25
        '
        'CheatName_TextBox
        '
        Me.CheatName_TextBox.Location = New System.Drawing.Point(9, 167)
        Me.CheatName_TextBox.Name = "CheatName_TextBox"
        Me.CheatName_TextBox.Size = New System.Drawing.Size(174, 20)
        Me.CheatName_TextBox.TabIndex = 24
        '
        'GameName_TextBox
        '
        Me.GameName_TextBox.Location = New System.Drawing.Point(9, 119)
        Me.GameName_TextBox.Name = "GameName_TextBox"
        Me.GameName_TextBox.Size = New System.Drawing.Size(175, 20)
        Me.GameName_TextBox.TabIndex = 23
        '
        'CRC_TextBox
        '
        Me.CRC_TextBox.Location = New System.Drawing.Point(9, 66)
        Me.CRC_TextBox.Name = "CRC_TextBox"
        Me.CRC_TextBox.Size = New System.Drawing.Size(174, 20)
        Me.CRC_TextBox.TabIndex = 22
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
        'CheatManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(621, 420)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "CheatManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "7800 GD Cheat Management"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As RichTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Save_Button As Button
    Friend WithEvents ClearText As Button
    Friend WithEvents Open_Button As Button
    Friend WithEvents Close_Button As Button
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
