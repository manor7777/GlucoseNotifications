<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSSLMode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDBHostname = New System.Windows.Forms.TextBox()
        Me.txtDBName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numberDataCheck = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numberGracePeriod = New System.Windows.Forms.NumericUpDown()
        Me.ButtonResetSetttings = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonTestNotification = New System.Windows.Forms.Button()
        Me.SoundSelect = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClearImage = New System.Windows.Forms.Button()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.txtAlertText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AlertPicBox = New System.Windows.Forms.PictureBox()
        Me.LockExit = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextDismissURL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ButtonGeneratePHP = New System.Windows.Forms.Button()
        Me.TextHealthCheckURL = New System.Windows.Forms.TextBox()
        Me.CheckHealthCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numberDataCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberGracePeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AlertPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(10, 36)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(187, 20)
        Me.txtUsername.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSSLMode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDBHostname)
        Me.GroupBox1.Controls.Add(Me.txtDBName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database Connection Details"
        '
        'txtSSLMode
        '
        Me.txtSSLMode.Enabled = False
        Me.txtSSLMode.Location = New System.Drawing.Point(11, 196)
        Me.txtSSLMode.Name = "txtSSLMode"
        Me.txtSSLMode.Size = New System.Drawing.Size(187, 20)
        Me.txtSSLMode.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SSL Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Database Server Hostname"
        '
        'txtDBHostname
        '
        Me.txtDBHostname.Location = New System.Drawing.Point(10, 157)
        Me.txtDBHostname.Name = "txtDBHostname"
        Me.txtDBHostname.Size = New System.Drawing.Size(187, 20)
        Me.txtDBHostname.TabIndex = 5
        '
        'txtDBName
        '
        Me.txtDBName.Location = New System.Drawing.Point(10, 118)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(187, 20)
        Me.txtDBName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Database Name"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(10, 79)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(187, 20)
        Me.txtPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(324, 501)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(405, 501)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numberDataCheck)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.numberGracePeriod)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 72)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Timing Setup"
        '
        'numberDataCheck
        '
        Me.numberDataCheck.Location = New System.Drawing.Point(132, 42)
        Me.numberDataCheck.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numberDataCheck.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numberDataCheck.Name = "numberDataCheck"
        Me.numberDataCheck.Size = New System.Drawing.Size(64, 20)
        Me.numberDataCheck.TabIndex = 3
        Me.numberDataCheck.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Data Check (Seconds):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Grace Period (Minutes):"
        '
        'numberGracePeriod
        '
        Me.numberGracePeriod.Location = New System.Drawing.Point(132, 19)
        Me.numberGracePeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numberGracePeriod.Name = "numberGracePeriod"
        Me.numberGracePeriod.Size = New System.Drawing.Size(65, 20)
        Me.numberGracePeriod.TabIndex = 0
        Me.numberGracePeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ButtonResetSetttings
        '
        Me.ButtonResetSetttings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonResetSetttings.Location = New System.Drawing.Point(12, 501)
        Me.ButtonResetSetttings.Name = "ButtonResetSetttings"
        Me.ButtonResetSetttings.Size = New System.Drawing.Size(189, 23)
        Me.ButtonResetSetttings.TabIndex = 4
        Me.ButtonResetSetttings.Text = "Reset All Settings to Default"
        Me.ButtonResetSetttings.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonTestNotification)
        Me.GroupBox3.Controls.Add(Me.SoundSelect)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btnClearImage)
        Me.GroupBox3.Controls.Add(Me.btnChooseImage)
        Me.GroupBox3.Controls.Add(Me.txtAlertText)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(226, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 165)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alert Customisation"
        '
        'ButtonTestNotification
        '
        Me.ButtonTestNotification.Location = New System.Drawing.Point(180, 133)
        Me.ButtonTestNotification.Name = "ButtonTestNotification"
        Me.ButtonTestNotification.Size = New System.Drawing.Size(68, 21)
        Me.ButtonTestNotification.TabIndex = 14
        Me.ButtonTestNotification.Text = "Test"
        Me.ButtonTestNotification.UseVisualStyleBackColor = True
        '
        'SoundSelect
        '
        Me.SoundSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SoundSelect.FormattingEnabled = True
        Me.SoundSelect.Items.AddRange(New Object() {"Alert Sound 1", "Alert Sound 2", "Alert Sound 3", "Alert Sound 4", "Alert Sound 5"})
        Me.SoundSelect.Location = New System.Drawing.Point(9, 133)
        Me.SoundSelect.Name = "SoundSelect"
        Me.SoundSelect.Size = New System.Drawing.Size(164, 21)
        Me.SoundSelect.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Alert Sound"
        '
        'btnClearImage
        '
        Me.btnClearImage.Location = New System.Drawing.Point(9, 88)
        Me.btnClearImage.Name = "btnClearImage"
        Me.btnClearImage.Size = New System.Drawing.Size(239, 23)
        Me.btnClearImage.TabIndex = 11
        Me.btnClearImage.Text = "Clear Image"
        Me.btnClearImage.UseVisualStyleBackColor = True
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Location = New System.Drawing.Point(9, 59)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(239, 23)
        Me.btnChooseImage.TabIndex = 10
        Me.btnChooseImage.Text = "Choose Image"
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'txtAlertText
        '
        Me.txtAlertText.Location = New System.Drawing.Point(9, 32)
        Me.txtAlertText.Name = "txtAlertText"
        Me.txtAlertText.Size = New System.Drawing.Size(239, 20)
        Me.txtAlertText.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Alert Text"
        '
        'AlertPicBox
        '
        Me.AlertPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlertPicBox.Location = New System.Drawing.Point(254, 12)
        Me.AlertPicBox.Name = "AlertPicBox"
        Me.AlertPicBox.Size = New System.Drawing.Size(200, 200)
        Me.AlertPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AlertPicBox.TabIndex = 5
        Me.AlertPicBox.TabStop = False
        '
        'LockExit
        '
        Me.LockExit.AutoSize = True
        Me.LockExit.Location = New System.Drawing.Point(9, 19)
        Me.LockExit.Name = "LockExit"
        Me.LockExit.Size = New System.Drawing.Size(150, 17)
        Me.LockExit.TabIndex = 7
        Me.LockExit.Text = "Disable Exiting Application"
        Me.LockExit.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextDismissURL)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 63)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Webhook URLs"
        '
        'TextDismissURL
        '
        Me.TextDismissURL.Location = New System.Drawing.Point(10, 34)
        Me.TextDismissURL.Name = "TextDismissURL"
        Me.TextDismissURL.Size = New System.Drawing.Size(179, 20)
        Me.TextDismissURL.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Dismiss All Notification's URL"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ButtonGeneratePHP)
        Me.GroupBox5.Controls.Add(Me.TextHealthCheckURL)
        Me.GroupBox5.Controls.Add(Me.CheckHealthCheck)
        Me.GroupBox5.Controls.Add(Me.LockExit)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 398)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(467, 96)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Special Settings"
        '
        'ButtonGeneratePHP
        '
        Me.ButtonGeneratePHP.Location = New System.Drawing.Point(343, 13)
        Me.ButtonGeneratePHP.Name = "ButtonGeneratePHP"
        Me.ButtonGeneratePHP.Size = New System.Drawing.Size(118, 23)
        Me.ButtonGeneratePHP.TabIndex = 10
        Me.ButtonGeneratePHP.Text = "Generate Webhook"
        Me.ButtonGeneratePHP.UseVisualStyleBackColor = True
        '
        'TextHealthCheckURL
        '
        Me.TextHealthCheckURL.Location = New System.Drawing.Point(9, 67)
        Me.TextHealthCheckURL.Name = "TextHealthCheckURL"
        Me.TextHealthCheckURL.Size = New System.Drawing.Size(452, 20)
        Me.TextHealthCheckURL.TabIndex = 9
        '
        'CheckHealthCheck
        '
        Me.CheckHealthCheck.AutoSize = True
        Me.CheckHealthCheck.Location = New System.Drawing.Point(9, 43)
        Me.CheckHealthCheck.Name = "CheckHealthCheck"
        Me.CheckHealthCheck.Size = New System.Drawing.Size(417, 17)
        Me.CheckHealthCheck.TabIndex = 8
        Me.CheckHealthCheck.Text = "Enable Health Check (Can be any Webhook URL below, we use HealthChecks.io)"
        Me.CheckHealthCheck.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(488, 536)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ButtonResetSetttings)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.AlertPicBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GlucoseNotifications Setup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numberDataCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberGracePeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AlertPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDBName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSSLMode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDBHostname As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents numberGracePeriod As NumericUpDown
    Friend WithEvents numberDataCheck As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents AlertPicBox As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtAlertText As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnChooseImage As Button
    Friend WithEvents btnClearImage As Button
    Friend WithEvents ButtonResetSetttings As Button
    Friend WithEvents LockExit As CheckBox
    Friend WithEvents SoundSelect As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonTestNotification As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextDismissURL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextHealthCheckURL As TextBox
    Friend WithEvents CheckHealthCheck As CheckBox
    Friend WithEvents ButtonGeneratePHP As Button
End Class
