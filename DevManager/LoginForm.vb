Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Me.Hide()
        RegisterForm.Show()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = txtLoginUsername.Text
        Dim password As String = txtLoginPassword.Text

        Dim hashedPassword As String = GetHashedPassword(password)

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT Role FROM Users WHERE Username=@Username AND Password=@Password", conn)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", hashedPassword)

            Dim role As Object = cmd.ExecuteScalar()
            If role IsNot Nothing Then
                MessageBox.Show($"Login successful! Welcome, {username}. Your role is: {role.ToString()}")
                GlobalVariables.currentUsername = username
                GlobalVariables.currentUserId = GetUserIDByUsername(username)
                GlobalVariables.currentUserRole = role

                Me.Hide()
                DashboardForm.Show()
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        End Using
    End Sub
    Function GetUserIDByUsername(ByVal username As String) As Integer
        Dim userID As Integer = -1

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT UserID FROM Users WHERE username = @username"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    userID = Convert.ToInt32(result)
                End If
            End Using

            conn.Close()
        End Using

        Return userID
    End Function


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class