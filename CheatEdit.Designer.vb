﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheatEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheatEdit))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LineNoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ReportRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LineNoRichTextBox
        '
        Me.LineNoRichTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.LineNoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LineNoRichTextBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LineNoRichTextBox.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineNoRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.LineNoRichTextBox.Name = "LineNoRichTextBox"
        Me.LineNoRichTextBox.ReadOnly = True
        Me.LineNoRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.LineNoRichTextBox.Size = New System.Drawing.Size(59, 391)
        Me.LineNoRichTextBox.TabIndex = 26
        Me.LineNoRichTextBox.Text = ""
        Me.ToolTip1.SetToolTip(Me.LineNoRichTextBox, "Press Ctrl +G to go to an address  line.")
        Me.LineNoRichTextBox.WordWrap = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 391)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 50)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Save_Button)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(136, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 46)
        Me.Panel1.TabIndex = 2
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(231, 13)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(110, 23)
        Me.Save_Button.TabIndex = 18
        Me.Save_Button.Text = "Save File"
        Me.ToolTip1.SetToolTip(Me.Save_Button, "This will allow you to load and edit your 7800GD.cht file.. Handy if yoiu previou" &
        "sly had an error and need to fixed it!")
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(347, 13)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(100, 23)
        Me.Close_Button.TabIndex = 14
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ReportRichTextBox
        '
        Me.ReportRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportRichTextBox.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportRichTextBox.Location = New System.Drawing.Point(59, 0)
        Me.ReportRichTextBox.Name = "ReportRichTextBox"
        Me.ReportRichTextBox.Size = New System.Drawing.Size(538, 391)
        Me.ReportRichTextBox.TabIndex = 25
        Me.ReportRichTextBox.Text = ""
        Me.ReportRichTextBox.WordWrap = False
        '
        'CheatEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 441)
        Me.Controls.Add(Me.ReportRichTextBox)
        Me.Controls.Add(Me.LineNoRichTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(420, 320)
        Me.Name = "CheatEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "7800GD.CHT Edit."
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Close_Button As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Save_Button As Button
    Friend WithEvents ReportRichTextBox As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LineNoRichTextBox As RichTextBox
End Class
