Imports MySql.Data.MySqlClient

Public Class CreateProjectForm
    Private Sub btnCreateProject_Click(sender As Object, e As EventArgs) Handles btnCreateProject.Click
        Dim projectName As String = txtProjectName.Text
        Dim description As String = txtDescription.Text

        If String.IsNullOrEmpty(projectName) OrElse String.IsNullOrEmpty(description) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(GlobalVariables.connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Projects (ProjectName, Description, CreatedBy) VALUES (@name, @desc, @creator); SELECT LAST_INSERT_ID();"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", projectName)
                    cmd.Parameters.AddWithValue("@desc", description)
                    cmd.Parameters.AddWithValue("@creator", GlobalVariables.currentUsername)

                    Dim newlyCreatedProjectID As Object = cmd.ExecuteScalar()
                    If newlyCreatedProjectID IsNot Nothing AndAlso Int32.TryParse(newlyCreatedProjectID.ToString(), newlyCreatedProjectID) Then
                        MessageBox.Show("Project created successfully!")

                        Dim cmdInsertMember As New MySqlCommand("INSERT INTO ProjectMembers (ProjectID, UserID) VALUES (@ProjectID, @UserID)", conn)
                        cmdInsertMember.Parameters.AddWithValue("@ProjectID", newlyCreatedProjectID)
                        cmdInsertMember.Parameters.AddWithValue("@UserID", GlobalVariables.currentUserId)
                        cmdInsertMember.ExecuteNonQuery()

                        cmdInsertMember.Parameters.Clear()
                        cmdInsertMember.Parameters.AddWithValue("@ProjectID", newlyCreatedProjectID)
                        cmdInsertMember.Parameters.AddWithValue("@UserID", 4)
                        cmdInsertMember.ExecuteNonQuery()

                    Else
                        MessageBox.Show("Failed to create project. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub CreateProjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
