﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheatParse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheatParse))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Refresh_Button = New System.Windows.Forms.Button()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Open_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.ReportRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 291)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 50)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Refresh_Button)
        Me.Panel1.Controls.Add(Me.Save_Button)
        Me.Panel1.Controls.Add(Me.Open_Button)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 46)
        Me.Panel1.TabIndex = 2
        '
        'Refresh_Button
        '
        Me.Refresh_Button.Location = New System.Drawing.Point(239, 13)
        Me.Refresh_Button.Name = "Refresh_Button"
        Me.Refresh_Button.Size = New System.Drawing.Size(100, 23)
        Me.Refresh_Button.TabIndex = 17
        Me.Refresh_Button.Text = "Parse Refresh"
        Me.Refresh_Button.UseVisualStyleBackColor = True
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(123, 13)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(110, 23)
        Me.Save_Button.TabIndex = 16
        Me.Save_Button.Text = "Save File"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Open_Button
        '
        Me.Open_Button.Location = New System.Drawing.Point(7, 13)
        Me.Open_Button.Name = "Open_Button"
        Me.Open_Button.Size = New System.Drawing.Size(110, 23)
        Me.Open_Button.TabIndex = 15
        Me.Open_Button.Text = "Edit 7800GD.CHT "
        Me.Open_Button.UseVisualStyleBackColor = True
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
        'ReportRichTextBox
        '
        Me.ReportRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportRichTextBox.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.ReportRichTextBox.Name = "ReportRichTextBox"
        Me.ReportRichTextBox.Size = New System.Drawing.Size(464, 291)
        Me.ReportRichTextBox.TabIndex = 3
        Me.ReportRichTextBox.Text = ""
        Me.ReportRichTextBox.WordWrap = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CheatParse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 341)
        Me.Controls.Add(Me.ReportRichTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(480, 380)
        Me.Name = "CheatParse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "7800GD.CHT Parse"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Open_Button As Button
    Friend WithEvents Close_Button As Button
    Friend WithEvents ReportRichTextBox As RichTextBox
    Friend WithEvents Refresh_Button As Button
    Friend WithEvents Save_Button As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class