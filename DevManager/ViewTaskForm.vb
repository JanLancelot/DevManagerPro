Imports MySql.Data.MySqlClient

Public Class ViewTaskForm
    Private Sub ViewTaskForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTaskTitle.Text = GlobalVariables.currentTask.Title
        txtTaskDescription.Text = GlobalVariables.currentTask.Description
        cmbTaskStatus.SelectedItem = GlobalVariables.currentTask.Status

        PopulateAssigneeCombobox()

        btnMarkComplete.Visible = False

        If GlobalVariables.currentUserId = GlobalVariables.currentTask.AssignedMemberID.ToString() Then
            btnMarkComplete.Visible = True
        End If

        If GlobalVariables.currentUserRole = "Project Manager" Then
            btnUpdate.Visible = True
        End If

        For Each item As Object In cmbAssignee.Items
            Dim kvp As KeyValuePair(Of Integer, String) = DirectCast(item, KeyValuePair(Of Integer, String))
            If kvp.Key = GlobalVariables.currentTask.AssignedMemberID Then
                cmbAssignee.SelectedItem = kvp
                Exit For
            End If
        Next

        MessageBox.Show(GetUsernameById(GlobalVariables.currentTask.AssignedMemberID))
        txtDueDate.Text = GlobalVariables.currentTask.DueDate.ToString("MM/dd/yyyy")
    End Sub

    Private Sub PopulateAssigneeCombobox()
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT UserID, username FROM Users WHERE UserID IN (SELECT UserID FROM ProjectMembers WHERE ProjectID = @ProjectID)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbAssignee.Items.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32("UserID"), reader.GetString("username")))
                    End While
                End Using
            End Using

            conn.Close()
        End Using

        cmbAssignee.DisplayMember = "Value"
        cmbAssignee.ValueMember = "Key"
    End Sub

    Private Function GetUsernameById(userId As Integer) As String
        Dim username As String = String.Empty

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT username FROM Users WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", userId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        username = reader.GetString("username")
                    End If
                End Using
            End Using

            conn.Close()
        End Using

        Return username
    End Function

    Private Sub btnMarkComplete_Click(sender As Object, e As EventArgs) Handles btnMarkComplete.Click
        UpdateTaskStatus(GlobalVariables.currentTask.TaskID, "Complete")

        AddContribution(GlobalVariables.currentUserId, GlobalVariables.currentTask.TaskID, "Task")

        MessageBox.Show("Task marked as complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmbTaskStatus.SelectedItem = "Complete"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AddContribution(userId As Integer, taskId As Integer, type As String)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "INSERT INTO Contributions (UserID, TaskID, Type, Date) VALUES (@UserID, @TaskID, @Type, CURRENT_TIMESTAMP)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.Parameters.AddWithValue("@TaskID", taskId)
                cmd.Parameters.AddWithValue("@Type", type)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
        End Using
    End Sub

    Private Sub UpdateTaskStatus(taskId As Integer, status As String)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "UPDATE Tasks SET Status = @Status WHERE TaskID = @TaskID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@TaskID", taskId)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Complete Update"

            txtTaskTitle.ReadOnly = False
            cmbTaskStatus.Enabled = True
            txtTaskDescription.ReadOnly = False
            txtDueDate.ReadOnly = False
            cmbAssignee.Enabled = True
        Else
            UpdateTaskDetails(
                GlobalVariables.currentTask.TaskID,
                txtTaskTitle.Text.Trim(),
                cmbTaskStatus.SelectedItem.ToString().Trim(),
                txtTaskDescription.Text.Trim(),
                DateTime.Parse(txtDueDate.Text.Trim()),
                DirectCast(cmbAssignee.SelectedItem, KeyValuePair(Of Integer, String)).Key
            )

            MessageBox.Show("Task details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Text = "Update"
            txtTaskTitle.ReadOnly = True
            cmbTaskStatus.Enabled = False
            txtTaskDescription.ReadOnly = True
            txtDueDate.ReadOnly = True
            cmbAssignee.Enabled = False
        End If
    End Sub

    Private Sub UpdateTaskDetails(taskId As Integer, title As String, status As String, description As String, dueDate As DateTime, assignedUserId As Integer)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "UPDATE Tasks SET Title = @Title, Status = @Status, Description = @Description, DueDate = @DueDate, AssignedMemberID = @AssignedMemberID WHERE TaskID = @TaskID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Title", title)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.Parameters.AddWithValue("@DueDate", dueDate)
                cmd.Parameters.AddWithValue("@AssignedMemberID", assignedUserId)
                cmd.Parameters.AddWithValue("@TaskID", taskId)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Using
    End Sub

End Class