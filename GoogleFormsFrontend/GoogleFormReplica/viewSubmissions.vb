Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class viewSubmissions

    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Async Sub viewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions(currentIndex)
        DisplaySubmission(currentIndex)

    End Sub

    Private Async Function LoadSubmissions(index As Integer) As Task
        Try
            Using client As New HttpClient()
                Dim url As String = $"http://localhost:3000/read?index={index}"
                Dim response = Await client.GetStringAsync(url)
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(response)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            txtName.Text = submissions(index).Name
            txtEmail.Text = submissions(index).Email
            txtPhoneNumber.Text = submissions(index).Phone
            txtGitHubRepo.Text = submissions(index).github_link
            txtStopwatch.Text = submissions(index).Stopwatch_time

        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableEditing(True)
    End Sub
    Private Sub EnableEditing(enable As Boolean)
        txtName.ReadOnly = Not enable
        txtEmail.ReadOnly = Not enable
        txtPhoneNumber.ReadOnly = Not enable
        txtGitHubRepo.ReadOnly = Not enable
        txtStopwatch.ReadOnly = Not enable

        btnUpdate.Enabled = enable
        btnDelete.Enabled = enable


        btnNext.Enabled = Not enable
        btnPrevious.Enabled = Not enable
    End Sub
    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
                Try
                    Using client As New HttpClient()
                        Dim submissionId As Integer = currentIndex
                        Dim url As String = $"http://localhost:3000/delete?id={submissionId}"

                        Dim response = Await client.DeleteAsync(url)


                        submissions.RemoveAt(currentIndex)


                        If currentIndex >= submissions.Count Then
                            currentIndex = submissions.Count - 1
                        End If


                        DisplaySubmission(currentIndex)
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Error deleting submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Try
                Dim updatedSubmission As New Submission With {
                    .Name = txtName.Text,
                    .Email = txtEmail.Text,
                    .Phone = txtPhoneNumber.Text,
                    .github_link = txtGitHubRepo.Text,
                    .Stopwatch_time = txtStopwatch.Text
                }

                Using client As New HttpClient()
                    Dim submissionId As Integer = currentIndex
                    Dim url As String = $"http://localhost:3000/update?id={submissionId}"

                    Dim json = JsonConvert.SerializeObject(updatedSubmission)
                    Dim content = New StringContent(json, Encoding.UTF8, "application/json")

                    Dim response = Await client.PutAsync(url, content)
                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        submissions(currentIndex) = updatedSubmission
                        EnableEditing(False)
                    Else
                        MessageBox.Show("Failed to update submission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtSearch.Text.Trim()
        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter an email to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using client As New HttpClient()
                Dim url As String = $"http://localhost:3000/search?email={email}"
                Dim response = Await client.GetStringAsync(url)
                Console.WriteLine(response)


                Dim submission = JsonConvert.DeserializeObject(Of Submission)(response)

                If submission IsNot Nothing Then
                        txtName.Text = submission.Name
                        txtEmail.Text = submission.Email
                        txtPhoneNumber.Text = submission.Phone
                        txtGitHubRepo.Text = submission.github_link
                        txtStopwatch.Text = submission.Stopwatch_time
                    Else
                        MessageBox.Show("Submission not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If


            End Using
        Catch ex As Exception
            MessageBox.Show($"Error searching for submission, Please check your entered correct email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property github_link As String
    Public Property Stopwatch_time As String
End Class
