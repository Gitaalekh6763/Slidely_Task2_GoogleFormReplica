Imports System.Net.Http
Imports System.Reflection.Metadata
Imports System.Text
Imports Newtonsoft.Json
Public Class createSubmission
    Private stopwatch As New Stopwatch()
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission = New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhoneNumber.Text,
            .github_link = txtGitHubRepo.Text,
            .stopwatch_time = lblStopWatch.Text
        }

        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        SubmitDataAsync(content)


    End Sub

    Private Async Sub SubmitDataAsync(content)
        Using client As New HttpClient()
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful")
                Me.Close()
            Else
                MessageBox.Show("Submission failed")
            End If
        End Using
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggle.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub createSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch.Start()
        UpdateStopwatchLabel()
    End Sub
End Class