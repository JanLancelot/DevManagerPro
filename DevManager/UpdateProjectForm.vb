Imports MySql.Data.MySqlClient

Public Class UpdateProjectForm
    Private Sub btnUpdateProject_Click(sender As Object, e As EventArgs) Handles btnUpdateProject.Click
        If String.IsNullOrWhiteSpace(txtUpdateTitle.Text) Or String.IsNullOrWhiteSpace(txtUpdateTitle.Text) Then
            MessageBox.Show("Both title and description fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE Projects SET ProjectName = @ProjectName, Description = @Description WHERE ProjectID = @ProjectID", conn)
            cmd.Parameters.AddWithValue("@ProjectName", txtUpdateTitle.Text)
            cmd.Parameters.AddWithValue("@Description", txtUpdateTitle.Text)
            cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Project updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()
        End Using
    End Sub

    Private Sub UpdateProjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUpdateTitle.Text = GlobalVariables.currentProject.ProjectName
        txtUpdateDescription.Text = GlobalVariables.currentProject.Description
    End Sub
End Class