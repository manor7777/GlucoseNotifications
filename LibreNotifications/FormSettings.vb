Imports System.IO
Imports System.Text

Public Class FormSettings
    Private notification = New Media.SoundPlayer
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.First_Run = True Then
            MsgBox("Welcome to GlucoseNotifications. This app links to a MySQL data source to pull event data on Low/High Glucose Levels. Additional Setup is required on first run!", MsgBoxStyle.Information, "Welcome")
            LoadSettings()
        Else
            LoadSettings()
        End If
    End Sub
    Public Function LoadSettings()
        txtDBHostname.Text = My.Settings.DB_Hostname
        txtDBName.Text = My.Settings.DB_Database
        txtPassword.Text = My.Settings.DB_Pass
        txtSSLMode.Text = My.Settings.SSL_Mode
        txtUsername.Text = My.Settings.DB_User
        numberGracePeriod.Value = My.Settings.Grace_Period
        Dim datacheckinterval As Integer = My.Settings.Check_Interval
        datacheckinterval = datacheckinterval / 1000
        numberDataCheck.Value = datacheckinterval
        txtAlertText.Text = My.Settings.GC_Warning_Text
        TextDismissURL.Text = My.Settings.Dismiss_Web_Hook_URL
        LockExit.Checked = My.Settings.LockExit
        TextHealthCheckURL.Enabled = My.Settings.Health_Check_Enabled
        CheckHealthCheck.Checked = My.Settings.Health_Check_Enabled
        TextHealthCheckURL.Text = My.Settings.Health_Check_URL
        Dim selectednotificationsound As Integer = My.Settings.soundnumber
        Select Case selectednotificationsound
            Case 1
                SoundSelect.SelectedIndex = 0
            Case 2
                SoundSelect.SelectedIndex = 1
            Case 3
                SoundSelect.SelectedIndex = 2
            Case 4
                SoundSelect.SelectedIndex = 3
            Case 5
                SoundSelect.SelectedIndex = 4
        End Select
        If My.Settings.GC_Optional_Image = "" Then
            'do nothing
        Else
            AlertPicBox.ImageLocation = My.Settings.GC_Optional_Image
        End If
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.DB_Hostname = txtDBHostname.Text
        My.Settings.DB_Database = txtDBName.Text
        My.Settings.DB_Pass = txtPassword.Text
        My.Settings.SSL_Mode = txtSSLMode.Text
        My.Settings.DB_User = txtUsername.Text
        My.Settings.Grace_Period = numberGracePeriod.Value
        Dim checkinterval As Integer = numberDataCheck.Value
        checkinterval = checkinterval * 1000
        My.Settings.Check_Interval = checkinterval
        My.Settings.GC_Warning_Text = txtAlertText.Text
        My.Settings.First_Run = False
        My.Settings.LockExit = LockExit.Checked
        My.Settings.Health_Check_Enabled = CheckHealthCheck.CheckState
        My.Settings.Health_Check_URL = TextHealthCheckURL.Text
        Try
            My.Settings.Dismiss_Web_Hook_URL = TextDismissURL.Text
        Catch ex As Exception
            MsgBox("An Error Has occured, the details are below. Please report them to @MLGMelon on Twitter!" + vbNewLine + vbNewLine + ex.ToString)
        End Try
        Dim selectednotificationsound As Integer = SoundSelect.SelectedIndex
        Select Case selectednotificationsound
            Case 0
                My.Settings.soundnumber = 1
            Case 1
                My.Settings.soundnumber = 2
            Case 2
                My.Settings.soundnumber = 3
            Case 3
                My.Settings.soundnumber = 4
            Case 4
                My.Settings.soundnumber = 5
        End Select
        My.Settings.Save()
        GCMainForm.DateUpdateTimer.Interval = My.Settings.Check_Interval
        Me.Close()
    End Sub

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        fd.Filter = "Image files (*.jpg, *.gif, *.png)|*.jpg;*.gif;*.png"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
        AlertPicBox.ImageLocation = strFileName
        My.Settings.GC_Optional_Image = strFileName
        My.Settings.Save()
    End Sub

    Private Sub btnClearImage_Click(sender As Object, e As EventArgs) Handles btnClearImage.Click
        My.Settings.GC_Optional_Image = ""
        AlertPicBox.ImageLocation = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonResetSetttings.Click


        If My.Settings.LockExit = True Then
            My.Settings.LockExit = False
            My.Settings.Save()
            Dim result As DialogResult = MessageBox.Show("Are you sure you would like to reset settings to default?", "Reset all Settings", MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                MsgBox("Settings have been reset. Application will now Close", MsgBoxStyle.Information, "Done!")
                My.Settings.Reset()
                My.Settings.Save()
                Application.Exit()
                End
            End If
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you would like to reset settings to default?", "Reset all Settings", MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                MsgBox("Settings have been reset. Application will now Close", MsgBoxStyle.Information, "Done!")
                My.Settings.Reset()
                My.Settings.Save()
                Application.Restart()
                End
            End If
        End If

    End Sub

    Private Sub AlertPicBox_Click(sender As Object, e As EventArgs) Handles AlertPicBox.Click
        btnChooseImage.PerformClick()
    End Sub

    Private Sub ButtonTestNotification_Click(sender As Object, e As EventArgs) Handles ButtonTestNotification.Click
        Dim selectednotificationsound As Integer = SoundSelect.SelectedIndex
        Select Case selectednotificationsound
            Case 0
                notification = New Media.SoundPlayer(My.Resources.notification1)
                notification.Play()
            Case 1
                notification = New Media.SoundPlayer(My.Resources.notification2)
                notification.Play()
            Case 2
                notification = New Media.SoundPlayer(My.Resources.notification3)
                notification.Play()
            Case 3
                notification = New Media.SoundPlayer(My.Resources.notification4)
                notification.Play()
            Case 4
                notification = New Media.SoundPlayer(My.Resources.notification5)
                notification.Play()
        End Select
    End Sub

    Private Sub CheckHealthCheck_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckHealthCheck.CheckStateChanged
        TextHealthCheckURL.Enabled = CheckHealthCheck.CheckState
    End Sub

    Private Sub ButtonGeneratePHP_Click(sender As Object, e As EventArgs) Handles ButtonGeneratePHP.Click
        System.Diagnostics.Debug.WriteLine("Asking permission to generate a PHP file on the users desktop")
        Dim result As DialogResult = MessageBox.Show("This will generate a PHP file for you to upload to a Web Hosting Account in order to provide webhook functionality" + vbNewLine + vbNewLine + "The index.php file will be saved as: " + My.Computer.FileSystem.SpecialDirectories.Desktop + "\index.php" + vbNewLine + vbNewLine + "You will need a Web Hosting Account with PHP functionality, and a MySQL/MariaDB server (usually they come as one package) for this to work" + vbNewLine + vbNewLine + "Do you want to continue?", "Generate PHP File", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            System.Diagnostics.Debug.WriteLine("No PHP file was generated, as the user clicked No")
        ElseIf result = DialogResult.Yes Then
            System.Diagnostics.Debug.WriteLine("PHP File permission granted, saving to Desktop")
            Try
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(My.Computer.FileSystem.SpecialDirectories.Desktop + "\index.php", True)
                file.WriteLine(My.Resources.header)
                file.WriteLine(vbNewLine)
                file.WriteLine("$servername = " + Chr(34) + My.Settings.DB_Hostname + Chr(34) + ";")
                file.WriteLine("$username = " + Chr(34) + My.Settings.DB_User + Chr(34) + ";")
                file.WriteLine("$password = " + Chr(34) + My.Settings.DB_Pass + Chr(34) + ";")
                file.WriteLine("$dbname = " + Chr(34) + My.Settings.DB_Database + Chr(34) + ";")
                file.WriteLine(vbNewLine)
                file.WriteLine(My.Resources.footer)
                file.Close()
                MsgBox("File has saved as:" + vbNewLine + My.Computer.FileSystem.SpecialDirectories.Desktop + "\index.php", MsgBoxStyle.Information, "Done!")
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex)
            End Try
        End If
    End Sub

    Private Sub FormSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        notification.Stop()
    End Sub
End Class