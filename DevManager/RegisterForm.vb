Imports System.Text
Imports MySql.Data.MySqlClient

Public Class RegisterForm

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = cmbRole.SelectedItem.ToString()

        Dim hashedPassword As String = GetHashedPassword(password)

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)", conn)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", hashedPassword)
            cmd.Parameters.AddWithValue("@Role", role)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registration successful!")
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class