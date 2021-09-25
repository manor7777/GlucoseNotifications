Public Class AlertDialog
    Public soundnumber As Integer = My.Settings.soundnumber
    Public notification = New Media.SoundPlayer
    Private Sub AlertDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BigSound.Start()
        LoadSettings()
    End Sub

    Private Sub ButtonDismissAll_Click(sender As Object, e As EventArgs) Handles ButtonDismissAll.Click
        If GCMainForm.ResultsCount = 0 Then
            'Do Nothing
        Else
            Try
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
                GCMainForm.RefreshData()
            Catch ex As Exception
                MsgBox("Failed to connect to server to dismiss notifications. Try again later or check your internet connection", vbInformation, "Error Dismissing")
            End Try
        End If
        Me.Close()
    End Sub
    Public Sub LoadSettings()
        If My.Settings.GC_Optional_Image = "" Then
            AlertImage.Image = My.Resources.warning_33_512
        Else
            AlertImage.ImageLocation = My.Settings.GC_Optional_Image
        End If
        If My.Settings.GC_Warning_Text = "" Then
            AlertText.Text = "GLUCOSE ALERT"
            My.Settings.GC_Warning_Text = "GLUCOSE ALERT"
            My.Settings.Save()
        Else
            AlertText.Text = My.Settings.GC_Warning_Text
        End If
        Me.TopMost = True
        Me.Focus()
        Me.BringToFront()
        Me.Activate()
    End Sub
    Private Sub BigSound_Tick(sender As Object, e As EventArgs) Handles BigSound.Tick
        Select Case soundnumber
            Case 1
                notification = New Media.SoundPlayer(My.Resources.notification1)
                notification.Play()
            Case 2
                notification = New Media.SoundPlayer(My.Resources.notification2)
                notification.Play()
            Case 3
                notification = New Media.SoundPlayer(My.Resources.notification3)
                notification.Play()
            Case 4
                notification = New Media.SoundPlayer(My.Resources.notification4)
                notification.Play()
            Case 5
                notification = New Media.SoundPlayer(My.Resources.notification5)
                notification.Play()
            Case 6
                Dim notification = New Media.SoundPlayer(My.Settings.GC_Custom_Sound)
                notification.Play()
        End Select
    End Sub

    Private Sub AlertDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BigSound.Stop()
        notification.Stop()
        Me.Dispose()
    End Sub
End Class