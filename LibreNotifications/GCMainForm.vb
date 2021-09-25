Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class GCMainForm
    ' Public con As New MySqlConnection("server=vdevelopments.co.uk;user id=np_LibreLink;password=p08cZq4%;database=np_LibreLink;sslmode=none")
    ' <section name="system.diagnostics" type="System.Diagnostics.DiagnosticsConfigurationHandler"/>
    ' https://www.iconsdb.com/red-icons/warning-33-icon.html

    Public ResultsCount As Integer
    Public GraceActive As Boolean
    Public AlertActive As Boolean
    Public ChkHideOnStart As Boolean
    Public con As New MySqlConnection("server=" + My.Settings.DB_Hostname + ";user id=" + My.Settings.DB_User + ";password=" + My.Settings.DB_Pass + ";database=" + My.Settings.DB_Database + ";sslmode=" + My.Settings.SSL_Mode)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If My.Settings.First_Run = True Then
                Dim settings As New FormSettings
                settings.ShowDialog(Me)
            Else
                Try
                    con.Open()
                    If con.State = ConnectionState.Open Then
                        System.Diagnostics.Debug.WriteLine("Database Opened")
                    Else
                        System.Diagnostics.Debug.WriteLine("Database FAILED to open")
                        MsgBox("Failed to open Database. Please check the console for more information", vbExclamation, "Critical Error")
                    End If
                    con.Close()
                    RefreshData()
                Catch ex As Exception
                    MsgBox("Unable to connect to database. Please check your credentials and your internet Connection. If you allow access through a firewall, you will have to re-open the application.", vbExclamation, "Unable to Connect")
                    'Application.Exit()
                End Try
                'Update Timer Interval with Settings Config
                DateUpdateTimer.Interval = My.Settings.Check_Interval
                ChkHideOnStart = True
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Form Load had a problem - Error Ahead:" + ex.ToString)
        End Try
    End Sub

    Public Function RefreshData()
        Try
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            Dim sql As String
            Try
                con.Open()

                sql = "SELECT 
                    ParamID
                    ,Date
                    ,Time
                    ,Title
                    ,Message
                   FROM Data 
                   WHERE Resolved = 0
                   Order by 1"
                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                da.SelectCommand = cmd

                da.Fill(dt)
                DataGridView1.DataSource = dt

                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)


            End Try
            ResultsCount = dt.Rows.Count
            'End If
            If AlertActive = True And ResultsCount = 0 Then
                GCIcon.Visible = False
                GCIcon.Visible = True
                AlertActive = False
            End If
            DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Refresh Data Failed - Error Ahead:" + ex.ToString)
        End Try
    End Function
    Public Function GracePeriod()
        GCIcon.BalloonTipTitle = "GlucoseNotifications - Alert"
        GCIcon.BalloonTipText = "Glucose Warning(s) Detected, Starting Alarm Countdown"
        GCIcon.ShowBalloonTip(5000)
        System.Diagnostics.Debug.WriteLine("Starting Grace Period")
        'Give time to dismiss
        Dim dteFutureDate = Date.Now().AddMinutes(My.Settings.Grace_Period)
        Do Until Date.Now() > dteFutureDate
            Windows.Forms.Application.DoEvents()
        Loop
        System.Diagnostics.Debug.WriteLine("Grace Period FInished - Check for results again.")

        'after time, has been dismissed?
        RefreshData()

        'Check results,  if values exists make noise
        If ResultsCount >= 1 Then
            System.Diagnostics.Debug.WriteLine("Results still greater than 1, making noise")
            'Make Noise
            Scream()
        End If

        System.Diagnostics.Debug.WriteLine("Grace Period Over - Notifications Dismissed.")
        GraceActive = False

    End Function
    Public Function Scream()

        AlertActive = True
        'This will make your computer scream
        If AlertDialog.Visible = True Then
            'Do Nothing
        Else
            Dim AlertBox As New AlertDialog
            AlertDialog.Show()
        End If
    End Function

    Private Sub LibreNotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GCIcon.MouseDoubleClick
        If Me.Visible = True Then
            Me.Visible = False
        Else
            Me.Visible = True
            Me.Activate()
        End If
    End Sub

    Private Sub DateUpdateTimer_Tick(sender As Object, e As EventArgs) Handles DateUpdateTimer.Tick
        Try
            If My.Settings.First_Run = True Then

            Else
                If GraceActive = True Then
                    RefreshData()

                Else
                    System.Diagnostics.Debug.WriteLine("Data Update Timer Started")
                    RefreshData()

                    If ResultsCount >= 1 Then
                        System.Diagnostics.Debug.WriteLine("Results greater than 1, giving grace period")
                        AlertActive = True
                        GraceActive = True
                        GracePeriod()

                    End If

                End If
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Data Update Timer failed - Error Ahead:" + ex.ToString)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        Me.Dispose()
        End
    End Sub

    Private Sub HideOnStart_Tick(sender As Object, e As EventArgs) Handles HideOnStart.Tick
        System.Diagnostics.Debug.WriteLine("Hiding form on start!")
        Me.Hide()
        HideOnStart.Stop()
    End Sub

    Private Sub TestAlert_Click(sender As Object, e As EventArgs) Handles TestAlert.Click
        Dim Alert As New AlertDialog
        Alert.Show()
    End Sub

    Private Sub DismissAll_Click(sender As Object, e As EventArgs) Handles DismissAll.Click
        Try
            If ResultsCount = 0 Then
                'Do Nothing
            Else
                If My.Settings.Dismiss_Web_Hook_URL = "" Then
                    MsgBox("Unable to Dismiss All, Please configure a webhook URL in settings to enable this feature", MsgBoxStyle.Critical, "Whoops!")
                Else
                    Try
                        Dim webClient As New System.Net.WebClient
                        Dim result As String = webClient.DownloadString(My.Settings.Dismiss_Web_Hook_URL)
                    Catch ex As Exception
                        MsgBox("An Error Has occured, the details are below. Please report them to @MLGMelon on Twitter!" + vbNewLine + vbNewLine + ex.ToString)
                    End Try
                End If
                RefreshData()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Dismiss All Failed - Error Ahead:" + ex.ToString)
        End Try
    End Sub

    Private Sub ReloadData_Click(sender As Object, e As EventArgs) Handles ReloadData.Click
        Try
            RefreshData()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Reload Data Failed - Error Ahead:" + ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim settings As New FormSettings
        settings.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim about As New FormAbout
        about.ShowDialog(Me)
    End Sub

    Private Sub GCMainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Settings.LockExit = True Then
            e.Cancel = True
            Me.Hide()
        Else
            Application.Exit()
            Me.Dispose()
            End
        End If
    End Sub

    Private Sub LockExit_Tick(sender As Object, e As EventArgs) Handles LockExit.Tick
        If My.Settings.LockExit = True Then
            ExitToolStripMenuItem.Enabled = False
        Else
            ExitToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub GCMainForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If ChkHideOnStart = True Then
            HideOnStart.Start()
            ChkHideOnStart = False
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim settings As New FormSettings
        settings.ShowDialog(Me)
    End Sub

    Private Sub HealthCheck_Tick(sender As Object, e As EventArgs) Handles HealthCheck.Tick
        If My.Settings.Health_Check_Enabled = True Then
            Try
                Dim webClient As New System.Net.WebClient
                webClient.Headers("User-Agent") = "Win32/GlucoseNotifications Version " + Application.ProductVersion
                Dim result As String = webClient.DownloadString(My.Settings.Health_Check_URL)
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Healtheck Failed - Error Ahead:" + ex.ToString)
            End Try
        End If
    End Sub
End Class
