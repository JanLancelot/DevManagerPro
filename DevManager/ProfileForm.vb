Imports MySql.Data.MySqlClient

Public Class ProfileForm

    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = GlobalVariables.currentUsername
        PopulateProfileData()
        LoadTasksAssignedToCurrentUser()
    End Sub

    Private Sub PopulateProfileData()
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT Type, COUNT(*) as Count FROM Contributions WHERE UserID = @UserID GROUP BY Type"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim type = reader.GetString("Type")
                        Dim count = reader.GetInt32("Count")

                        Select Case type
                            Case "Task"
                                lblTasksCompleted.Text = $"Total Tasks Completed: {count}"
                            Case "Issue"
                                lblIssuesResolved.Text = $"Total Issues Resolved: {count}"
                        End Select
                    End While
                End Using
            End Using

            Dim projectQuery As String = "SELECT COUNT(*) as Count FROM ProjectMembers WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(projectQuery, conn)
                cmd.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                lblProjectsJoined.Text = $"Projects Joined: {count}"
            End Using

            conn.Close()
        End Using
    End Sub

    Private Sub LoadTasksAssignedToCurrentUser()
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT TaskID, Title, Description, DueDate FROM Tasks WHERE AssignedMemberID = @UserID AND Status <> 'Complete'"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)

                Dim dt As New DataTable()
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                dgvTasks.DataSource = dt
            End Using

            conn.Close()
        End Using

        dgvTasks.Columns("TaskID").Visible = False
        dgvTasks.Columns("Title").HeaderText = "Task Title"
        dgvTasks.Columns("Description").HeaderText = "Description"
        dgvTasks.Columns("DueDate").HeaderText = "Due Date"
    End Sub


End Class
