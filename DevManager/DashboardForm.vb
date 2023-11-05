Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.currentUserRole = "Project Manager" Then
            btnUpdate.Visible = True
            btnDelete.Visible = True
        End If
        LoadProjects()
        UpdateNotificationLabel()
    End Sub

    Private Sub LoadProjects()
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM Projects", conn)
            Dim dt As New DataTable()

            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)

            dgvProjects.DataSource = dt

            dgvProjects.Columns("ProjectID").Visible = False
            dgvProjects.Columns("ProjectName").HeaderText = "Project"
            dgvProjects.Columns("Description").HeaderText = "Description"
            dgvProjects.Columns("CreatedBy").HeaderText = "Creator"
            dgvProjects.Columns("CreationDate").HeaderText = "Date Created"
        End Using
    End Sub


    Public Sub DeleteProject(ByVal projectId As Integer)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this project?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(GlobalVariables.connectionString)
                    conn.Open()

                    Dim cmd As New MySqlCommand("DELETE FROM Projects WHERE ProjectID = @projectId", conn)
                    cmd.Parameters.AddWithValue("@projectId", projectId)

                    Dim numberOfRowsAffected As Integer = cmd.ExecuteNonQuery()

                    If numberOfRowsAffected > 0 Then
                        MessageBox.Show("Project deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Error occurred while deleting the project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function GetUnviewedTaskCount() As Integer
        Dim count As Integer = 0
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM Tasks WHERE AssignedMemberID = @UserID AND Viewed = 0"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            conn.Close()
        End Using
        Return count
    End Function

    Private Sub UpdateNotificationLabel()
        Dim unviewedTasks As Integer = GetUnviewedTaskCount()
        NotificationLabel.Text = unviewedTasks.ToString()
    End Sub

    Private Sub MarkTasksAsViewed()
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "UPDATE Tasks SET Viewed = 1 WHERE AssignedMemberID = @UserID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
        End Using
    End Sub

    Private Sub btnCreateProject_Click(sender As Object, e As EventArgs) Handles btnCreateProject.Click
        Dim createProjectForm As New CreateProjectForm()
        createProjectForm.ShowDialog()

        LoadProjects()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        MarkTasksAsViewed()
        UpdateNotificationLabel()

        Dim profileForm As New ProfileForm()
        profileForm.ShowDialog()
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs)
        Dim notificationsForm As New NotificationsForm()
        notificationsForm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub btnViewProject_Click(sender As Object, e As EventArgs) Handles btnViewProject.Click
        If dgvProjects.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvProjects.SelectedRows(0)

            GlobalVariables.currentProject.ProjectID = Convert.ToInt32(selectedRow.Cells("ProjectID").Value)
            GlobalVariables.currentProject.ProjectName = Convert.ToString(selectedRow.Cells("ProjectName").Value)
            GlobalVariables.currentProject.Description = Convert.ToString(selectedRow.Cells("Description").Value)

            UpdateNotificationLabel()
            Dim viewProject As New TaskManagementForm()
            If viewProject.ShowDialog() = DialogResult.OK Then
                UpdateNotificationLabel()
            End If
        Else
            MessageBox.Show("Please select a project to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProjects.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvProjects.SelectedRows(0)

            GlobalVariables.currentProject.ProjectID = Convert.ToInt32(selectedRow.Cells("ProjectID").Value)
            DeleteProject(GlobalVariables.currentProject.ProjectID)
            LoadProjects()
        Else
            MessageBox.Show("Please select a project to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvProjects.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvProjects.SelectedRows(0)

            GlobalVariables.currentProject.ProjectID = Convert.ToInt32(selectedRow.Cells("ProjectID").Value)
            GlobalVariables.currentProject.ProjectName = Convert.ToString(selectedRow.Cells("ProjectName").Value)
            GlobalVariables.currentProject.Description = Convert.ToString(selectedRow.Cells("Description").Value)

            Dim updateProject As New UpdateProjectForm()
            If updateProject.ShowDialog() = DialogResult.OK Then
                LoadProjects()
            End If
        Else
            MessageBox.Show("Please select a project to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class