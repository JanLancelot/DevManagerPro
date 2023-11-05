Imports MySql.Data.MySqlClient

Public Class ChatForm
    Private Sub ChatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayChatMessages(GlobalVariables.currentProject.ProjectID)
    End Sub
    Private Sub SendChatMessage(projectId As Integer, userId As Integer, message As String)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "INSERT INTO ProjectChats (ProjectID, UserID, Message) VALUES (@ProjectID, @UserID, @Message)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProjectID", projectId)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.Parameters.AddWithValue("@Message", message)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
        End Using
    End Sub

    Private Function GetProjectChatMessages(projectId As Integer) As DataTable
        Dim dt As New DataTable()

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT Users.Username, Message, Timestamp FROM ProjectChats INNER JOIN Users ON ProjectChats.UserID = Users.UserID WHERE ProjectID = @ProjectID ORDER BY Timestamp ASC"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProjectID", projectId)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            conn.Close()
        End Using

        Return dt
    End Function


    Private Sub DisplayChatMessages(projectId As Integer)
        Dim dt As DataTable = GetProjectChatMessages(projectId)

        lstChatMessages.Items.Clear()

        For Each row As DataRow In dt.Rows
            Dim username As String = row("Username").ToString()
            Dim message As String = row("Message").ToString()
            Dim timestamp As DateTime = CType(row("Timestamp"), DateTime)

            lstChatMessages.Items.Add($"[{timestamp:HH:mm}] {username}: {message}")
        Next
    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        SendChatMessage(GlobalVariables.currentProject.ProjectID, GlobalVariables.currentUserId, txtMessage.Text)
        DisplayChatMessages(GlobalVariables.currentProject.ProjectID)
    End Sub
End Class