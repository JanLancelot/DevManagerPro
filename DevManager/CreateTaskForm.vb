Imports MySql.Data.MySqlClient

Public Class CreateTaskForm
    Private Sub btnCreateTask_Click(sender As Object, e As EventArgs) Handles btnCreateTask.Click
        Dim title As String = txtTaskTitle.Text
        Dim description As String = txtTaskDescription.Text
        Dim dueDate As Date = dtpDueDate.Value
        Dim assignedMemberID As Integer = CInt(cboAssignedMember.SelectedValue)

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO Tasks (ProjectID, AssignedMemberID, Title, Description, DueDate) VALUES (@ProjectID, @AssignedMemberID, @Title, @Description, @DueDate)", conn)
            cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)
            cmd.Parameters.AddWithValue("@AssignedMemberID", assignedMemberID)
            cmd.Parameters.AddWithValue("@Title", title)
            cmd.Parameters.AddWithValue("@Description", description)
            cmd.Parameters.AddWithValue("@DueDate", dueDate)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Task created successfully!")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to create task.")
            End If
        End Using
    End Sub

    Private Sub LoadProjectMembersToComboBox()
        Dim dtMembers As New DataTable()

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT u.UserID, u.Username FROM Users u INNER JOIN ProjectMembers pm ON u.UserID = pm.UserID WHERE pm.ProjectID = @ProjectID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dtMembers)
                End Using
            End Using
        End Using

        cboAssignedMember.DataSource = dtMembers
        cboAssignedMember.DisplayMember = "Username"
        cboAssignedMember.ValueMember = "UserID"
    End Sub

    Private Sub CreateTaskForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProjectMembersToComboBox()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cboAssignedMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAssignedMember.SelectedIndexChanged

    End Sub

    Private Sub txtTaskDescription_TextChanged(sender As Object, e As EventArgs) Handles txtTaskDescription.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub dtpDueDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDueDate.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtTaskTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTaskTitle.TextChanged

    End Sub
End Class