<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ModePan = New System.Windows.Forms.FlowLayoutPanel()
        Me.ModeON = New System.Windows.Forms.RadioButton()
        Me.ModeOFF = New System.Windows.Forms.RadioButton()
        Me.ModeLabel = New System.Windows.Forms.Label()
        Me.SSIDLabel = New System.Windows.Forms.Label()
        Me.SSID = New System.Windows.Forms.TextBox()
        Me.PasswdLabel = New System.Windows.Forms.Label()
        Me.Passwd = New System.Windows.Forms.TextBox()
        Me.SetHosted = New System.Windows.Forms.Button()
        Me.SwitchHosted = New System.Windows.Forms.Button()
        Me.CmdOut = New System.Windows.Forms.TextBox()
        Me.ModePan.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModePan
        '
        Me.ModePan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ModePan.Controls.Add(Me.ModeON)
        Me.ModePan.Controls.Add(Me.ModeOFF)
        Me.ModePan.Location = New System.Drawing.Point(86, 12)
        Me.ModePan.Margin = New System.Windows.Forms.Padding(0)
        Me.ModePan.Name = "ModePan"
        Me.ModePan.Size = New System.Drawing.Size(89, 19)
        Me.ModePan.TabIndex = 1
        '
        'ModeON
        '
        Me.ModeON.AutoSize = True
        Me.ModeON.Location = New System.Drawing.Point(3, 3)
        Me.ModeON.Name = "ModeON"
        Me.ModeON.Size = New System.Drawing.Size(35, 16)
        Me.ModeON.TabIndex = 0
        Me.ModeON.TabStop = True
        Me.ModeON.Text = "ON"
        Me.ModeON.UseVisualStyleBackColor = True
        '
        'ModeOFF
        '
        Me.ModeOFF.AutoSize = True
        Me.ModeOFF.Location = New System.Drawing.Point(44, 3)
        Me.ModeOFF.Name = "ModeOFF"
        Me.ModeOFF.Size = New System.Drawing.Size(41, 16)
        Me.ModeOFF.TabIndex = 1
        Me.ModeOFF.TabStop = True
        Me.ModeOFF.Text = "OFF"
        Me.ModeOFF.UseVisualStyleBackColor = True
        '
        'ModeLabel
        '
        Me.ModeLabel.AutoSize = True
        Me.ModeLabel.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.ModeLabel.Location = New System.Drawing.Point(12, 17)
        Me.ModeLabel.Name = "ModeLabel"
        Me.ModeLabel.Size = New System.Drawing.Size(71, 12)
        Me.ModeLabel.TabIndex = 3
        Me.ModeLabel.Text = "Hosted Mode"
        Me.ModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SSIDLabel
        '
        Me.SSIDLabel.AutoSize = True
        Me.SSIDLabel.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.SSIDLabel.Location = New System.Drawing.Point(12, 39)
        Me.SSIDLabel.Name = "SSIDLabel"
        Me.SSIDLabel.Size = New System.Drawing.Size(29, 12)
        Me.SSIDLabel.TabIndex = 4
        Me.SSIDLabel.Text = "SSID"
        Me.SSIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SSID
        '
        Me.SSID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SSID.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.SSID.Location = New System.Drawing.Point(47, 37)
        Me.SSID.MaxLength = 32
        Me.SSID.Name = "SSID"
        Me.SSID.Size = New System.Drawing.Size(128, 21)
        Me.SSID.TabIndex = 5
        '
        'PasswdLabel
        '
        Me.PasswdLabel.AutoSize = True
        Me.PasswdLabel.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.PasswdLabel.Location = New System.Drawing.Point(12, 66)
        Me.PasswdLabel.Name = "PasswdLabel"
        Me.PasswdLabel.Size = New System.Drawing.Size(29, 12)
        Me.PasswdLabel.TabIndex = 6
        Me.PasswdLabel.Text = "Pswd"
        Me.PasswdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Passwd
        '
        Me.Passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Passwd.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.Passwd.Location = New System.Drawing.Point(47, 64)
        Me.Passwd.MaxLength = 128
        Me.Passwd.Name = "Passwd"
        Me.Passwd.Size = New System.Drawing.Size(128, 21)
        Me.Passwd.TabIndex = 7
        Me.Passwd.UseSystemPasswordChar = True
        '
        'SetHosted
        '
        Me.SetHosted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.SetHosted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SetHosted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetHosted.Location = New System.Drawing.Point(14, 91)
        Me.SetHosted.Name = "SetHosted"
        Me.SetHosted.Size = New System.Drawing.Size(161, 26)
        Me.SetHosted.TabIndex = 8
        Me.SetHosted.Text = "Set"
        Me.SetHosted.UseVisualStyleBackColor = True
        '
        'SwitchHosted
        '
        Me.SwitchHosted.Enabled = False
        Me.SwitchHosted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.SwitchHosted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SwitchHosted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SwitchHosted.Location = New System.Drawing.Point(14, 123)
        Me.SwitchHosted.Name = "SwitchHosted"
        Me.SwitchHosted.Size = New System.Drawing.Size(161, 26)
        Me.SwitchHosted.TabIndex = 9
        Me.SwitchHosted.UseVisualStyleBackColor = True
        '
        'CmdOut
        '
        Me.CmdOut.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.CmdOut.Location = New System.Drawing.Point(14, 164)
        Me.CmdOut.Multiline = True
        Me.CmdOut.Name = "CmdOut"
        Me.CmdOut.ReadOnly = True
        Me.CmdOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CmdOut.Size = New System.Drawing.Size(161, 188)
        Me.CmdOut.TabIndex = 10
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 161)
        Me.Controls.Add(Me.CmdOut)
        Me.Controls.Add(Me.SwitchHosted)
        Me.Controls.Add(Me.SetHosted)
        Me.Controls.Add(Me.Passwd)
        Me.Controls.Add(Me.PasswdLabel)
        Me.Controls.Add(Me.SSID)
        Me.Controls.Add(Me.SSIDLabel)
        Me.Controls.Add(Me.ModeLabel)
        Me.Controls.Add(Me.ModePan)
        Me.MaximumSize = New System.Drawing.Size(200, 400)
        Me.MinimumSize = New System.Drawing.Size(200, 200)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HSwitcher"
        Me.ModePan.ResumeLayout(False)
        Me.ModePan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModePan As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ModeLabel As System.Windows.Forms.Label
    Friend WithEvents ModeON As System.Windows.Forms.RadioButton
    Friend WithEvents ModeOFF As System.Windows.Forms.RadioButton
    Friend WithEvents SSIDLabel As System.Windows.Forms.Label
    Friend WithEvents SSID As System.Windows.Forms.TextBox
    Friend WithEvents PasswdLabel As System.Windows.Forms.Label
    Friend WithEvents Passwd As System.Windows.Forms.TextBox
    Friend WithEvents SetHosted As System.Windows.Forms.Button
    Friend WithEvents SwitchHosted As System.Windows.Forms.Button
    Friend WithEvents CmdOut As System.Windows.Forms.TextBox

End Class
