Imports MySql.Data.MySqlClient

Public Class TaskManagementForm
    Private Sub TaskManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProjectName.Text = GlobalVariables.currentProject.ProjectName
        lblDescription.Text = GlobalVariables.currentProject.Description
        MessageBox.Show(GlobalVariables.currentProject.ProjectName)

        If GlobalVariables.currentUserRole = "Project Manager" Then
            btnDelete.Visible = True
        End If

        If GlobalVariables.currentUserRole = "Project Manager" Then
            btnCreateTask.Visible = True
        End If

        If IsUserAMemberOfProject(GlobalVariables.currentUserId, GlobalVariables.currentProject.ProjectID) Then
            btnJoin.Text = "Leave"
        Else
            btnJoin.Text = "Join"
        End If

        btnChat.Visible = IsUserAMemberOfProject(GlobalVariables.currentUserId, GlobalVariables.currentProject.ProjectID)


        LoadMembers()
        LoadTasksToDataGridView()
        LoadIssuesToDataGridView()
        dgvIssues.ClearSelection()
        dgvTasks.ClearSelection()
    End Sub

    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            If btnJoin.Text = "Join" Then
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM ProjectMembers WHERE ProjectID = @ProjectID AND UserID = @UserID", conn)
                checkCmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)
                checkCmd.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count = 0 Then
                    Dim cmd As New MySqlCommand("INSERT INTO ProjectMembers (ProjectID, UserID) VALUES (@ProjectID, @UserID)", conn)
                    cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)
                    cmd.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)
                    cmd.ExecuteNonQuery()

                    LoadMembers()
                Else
                    MessageBox.Show("You're already a member of this project!")
                End If

                conn.Close()
                btnJoin.Text = "Leave"

            ElseIf btnJoin.Text = "Leave" Then
                Dim cmd As New MySqlCommand("DELETE FROM ProjectMembers WHERE ProjectID = @ProjectID AND UserID = @UserID", conn)
                cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)
                cmd.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)
                cmd.ExecuteNonQuery()

                LoadMembers()
                HandleUserDeparture(GlobalVariables.currentUserId)
                btnJoin.Text = "Join"

            End If

            conn.Close()
        End Using
    End Sub

    Private Sub HandleUserDeparture(userId As Integer)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()
            Dim query As String = "UPDATE Tasks SET AssignedMemberID = @NullUserID WHERE AssignedMemberID = @UserID AND ProjectID = @ProjectID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.Parameters.AddWithValue("@NullUserID", 4)
                cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Private Sub LoadMembers()
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT u.username " &
                              "FROM ProjectMembers pm " &
                              "JOIN Users u ON pm.UserID = u.UserID " &
                              "WHERE pm.ProjectID = @projectID AND u.UserID <> 4"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@projectID", GlobalVariables.currentProject.ProjectID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    lstMembers.Items.Clear()
                    While reader.Read()
                        lstMembers.Items.Add(reader("username").ToString())
                    End While
                End Using
            End Using

            conn.Close()
        End Using
    End Sub


    Private Sub LoadTasksToDataGridView()
        Dim dtTasks As New DataTable()

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT TaskID, Title, Description, DueDate, Status FROM Tasks WHERE ProjectID = @ProjectID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dtTasks)
                End Using
            End Using
        End Using

        dgvTasks.DataSource = dtTasks
        dgvTasks.Columns("TaskID").Visible = False
    End Sub

    Private Sub LoadIssuesToDataGridView()
        Dim dtIssues As New DataTable()

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT ReportID, Title, Description, Severity, Status FROM issuereports WHERE ProjectID = @ProjectID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dtIssues)
                End Using
            End Using
        End Using

        dgvIssues.DataSource = dtIssues
        dgvIssues.Columns("ReportID").Visible = False
    End Sub

    Private Function IsUserAMemberOfProject(userId As Integer, projectId As Integer) As Boolean
        Dim isMember As Boolean = False

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM ProjectMembers WHERE UserID = @UserID AND ProjectID = @ProjectID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.Parameters.AddWithValue("@ProjectID", projectId)

                If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                    isMember = True
                End If
            End Using

            conn.Close()
        End Using

        Return isMember
    End Function

    Private Sub btnCreateTask_Click(sender As Object, e As EventArgs) Handles btnCreateTask.Click
        Dim taskForm As New CreateTaskForm()
        If taskForm.ShowDialog() = DialogResult.OK Then
            LoadTasksToDataGridView()
        End If
    End Sub

    Private Sub btnCreateIssue_Click(sender As Object, e As EventArgs) Handles btnCreateIssue.Click
        Dim issueForm As New IssueForm()
        If issueForm.ShowDialog() = DialogResult.OK Then
            LoadIssuesToDataGridView()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If dgvTasks.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvTasks.SelectedRows(0)
            Dim taskID As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

            Using conn As New MySqlConnection(GlobalVariables.connectionString)
                conn.Open()

                Dim query As String = "SELECT * FROM Tasks WHERE TaskID = @TaskID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TaskID", taskID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            GlobalVariables.currentTask.TaskID = reader.GetInt32("TaskID")
                            GlobalVariables.currentTask.ProjectIDRef = reader.GetInt32("ProjectID")
                            GlobalVariables.currentTask.AssignedMemberID = reader.GetInt32("AssignedMemberID")
                            GlobalVariables.currentTask.Title = reader.GetString("Title")
                            GlobalVariables.currentTask.Description = reader.GetString("Description")
                            GlobalVariables.currentTask.DueDate = reader.GetDateTime("DueDate")
                            GlobalVariables.currentTask.Status = reader.GetString("Status")
                        Else
                            MessageBox.Show("Task not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using
                End Using

                conn.Close()
            End Using

            Dim viewTask As New ViewTaskForm()
            If viewTask.ShowDialog() = DialogResult.OK Then
                LoadTasksToDataGridView()
            End If
        ElseIf dgvIssues.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvIssues.SelectedRows(0)
            Dim reportID As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

            Using conn As New MySqlConnection(GlobalVariables.connectionString)
                conn.Open()

                Dim query As String = "SELECT * FROM issuereports WHERE ReportID = @ReportID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ReportID", reportID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            GlobalVariables.currentIssue.ReportID = reader.GetInt32("ReportID")
                            GlobalVariables.currentIssue.ProjectID = reader.GetInt32("ProjectID")
                            GlobalVariables.currentIssue.ReporterID = reader.GetInt32("ReporterID")
                            GlobalVariables.currentIssue.Title = reader.GetString("Title")
                            GlobalVariables.currentIssue.Description = reader.GetString("Description")
                            GlobalVariables.currentIssue.Severity = reader.GetString("Severity")
                            GlobalVariables.currentIssue.Status = reader.GetString("Status")
                        Else
                            MessageBox.Show("Issue not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using
                End Using

                conn.Close()
            End Using

            Dim viewIssue As New ViewIssueForm()
            If viewIssue.ShowDialog() = DialogResult.OK Then
                LoadIssuesToDataGridView()
            End If
        Else
            MessageBox.Show("Please select a task or an issue to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvTasks.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvTasks.SelectedRows(0)
            Dim taskID As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

            Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete the selected task?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dialogResult = DialogResult.Yes Then
                Using conn As New MySqlConnection(GlobalVariables.connectionString)
                    conn.Open()

                    Dim query As String = "DELETE FROM Tasks WHERE TaskID = @TaskID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@TaskID", taskID)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Task deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to delete the task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using

                    conn.Close()
                End Using

                LoadTasksToDataGridView()
            End If
        Else
            MessageBox.Show("Please select a task to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvIssues_SelectionChanged(sender As Object, e As EventArgs) Handles dgvIssues.SelectionChanged
        dgvTasks.ClearSelection()
    End Sub

    Private Sub dgvTasks_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTasks.SelectionChanged
        dgvIssues.ClearSelection()
    End Sub

    Private Sub TaskManagementForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        Dim newChat As New ChatForm()
        newChat.ShowDialog()
    End Sub

    Private Sub btnViewRankings_Click(sender As Object, e As EventArgs) Handles btnViewRankings.Click
        Dim rankingsForm As New ChartRankingForm()
        rankingsForm.ShowDialog()
    End Sub
End Class