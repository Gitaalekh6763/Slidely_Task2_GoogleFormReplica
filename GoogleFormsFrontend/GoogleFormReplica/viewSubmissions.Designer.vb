<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewSubmissions
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
        Label1 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubRepo = New TextBox()
        txtStopwatch = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnUpdate = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(216, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 21)
        Label1.TabIndex = 0
        Label1.Text = "Aalekh Prasad, Slidely Task 2 - View Submissons"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ActiveBorder
        txtName.Location = New Point(311, 140)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(301, 29)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ActiveBorder
        txtEmail.Location = New Point(311, 196)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(301, 29)
        txtEmail.TabIndex = 2
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = SystemColors.ActiveBorder
        txtPhoneNumber.Location = New Point(311, 252)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(301, 29)
        txtPhoneNumber.TabIndex = 3
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.BackColor = SystemColors.ActiveBorder
        txtGitHubRepo.Location = New Point(311, 308)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.ReadOnly = True
        txtGitHubRepo.Size = New Size(301, 29)
        txtGitHubRepo.TabIndex = 4
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.BackColor = SystemColors.ActiveBorder
        txtStopwatch.Location = New Point(311, 364)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(301, 29)
        txtStopwatch.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(182, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 6
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(182, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 21)
        Label3.TabIndex = 7
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(182, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 21)
        Label4.TabIndex = 8
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(182, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 42)
        Label5.TabIndex = 9
        Label5.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(182, 364)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 42)
        Label6.TabIndex = 10
        Label6.Text = "Stopwatch" & vbCrLf & "   time" & vbCrLf
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Gold
        btnPrevious.Location = New Point(91, 468)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(278, 60)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.Location = New Point(391, 468)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(278, 60)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Location = New Point(690, 110)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(63, 38)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnEdit.Location = New Point(219, 426)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(83, 33)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.GradientActiveCaption
        btnUpdate.Location = New Point(465, 429)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(102, 33)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Bisque
        txtSearch.Location = New Point(229, 77)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(264, 29)
        txtSearch.TabIndex = 16
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Salmon
        btnSearch.Location = New Point(504, 77)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(128, 33)
        btnSearch.TabIndex = 17
        btnSearch.Text = "Search by Email"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' viewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 557)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnUpdate)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGitHubRepo)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "viewSubmissions"
        Text = "viewSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
