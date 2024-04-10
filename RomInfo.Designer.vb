<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RomInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RomInfo))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Copy_Button = New System.Windows.Forms.Button()
        Me.CRC_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GameName_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Close_Button)
        Me.GroupBox1.Controls.Add(Me.Copy_Button)
        Me.GroupBox1.Controls.Add(Me.CRC_TextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GameName_TextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rom Info"
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(193, 88)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(110, 23)
        Me.Close_Button.TabIndex = 5
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Copy_Button
        '
        Me.Copy_Button.Location = New System.Drawing.Point(27, 88)
        Me.Copy_Button.Name = "Copy_Button"
        Me.Copy_Button.Size = New System.Drawing.Size(151, 23)
        Me.Copy_Button.TabIndex = 4
        Me.Copy_Button.Text = "Copy to clipboard"
        Me.Copy_Button.UseVisualStyleBackColor = True
        '
        'CRC_TextBox
        '
        Me.CRC_TextBox.Location = New System.Drawing.Point(228, 50)
        Me.CRC_TextBox.Name = "CRC_TextBox"
        Me.CRC_TextBox.Size = New System.Drawing.Size(96, 20)
        Me.CRC_TextBox.TabIndex = 3
        Me.CRC_TextBox.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CRC Info:"
        '
        'GameName_TextBox
        '
        Me.GameName_TextBox.Location = New System.Drawing.Point(9, 50)
        Me.GameName_TextBox.Name = "GameName_TextBox"
        Me.GameName_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GameName_TextBox.Size = New System.Drawing.Size(213, 20)
        Me.GameName_TextBox.TabIndex = 1
        Me.GameName_TextBox.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game Name:"
        '
        'RomInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(360, 157)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RomInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rom and CRC Informatiuon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents Copy_Button As System.Windows.Forms.Button
    Friend WithEvents CRC_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GameName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
