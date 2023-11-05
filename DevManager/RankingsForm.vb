Imports MySql.Data.MySqlClient

Public Class RankingsForm
    Private Sub RankingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTopTasksReported(GlobalVariables.currentProject.ProjectID)
        LoadTopBugsReported(GlobalVariables.currentProject.ProjectID)
        LoadFastestResolvers(GlobalVariables.currentProject.ProjectID)
    End Sub

    Private Sub LoadTopTasksReported(projectID As Integer)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT u.username, COUNT(c.ContributionID) as TasksReported " &
                  "FROM Contributions c " &
                  "JOIN Users u ON c.UserID = u.UserID " &
                  "WHERE c.TaskID IN (SELECT TaskID FROM Tasks WHERE ProjectID = @selectedProjectID) AND c.Type = 'Task' " &
                  "GROUP BY u.username " &
                  "ORDER BY TasksReported DESC " &
                  "LIMIT 5"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@selectedProjectID", projectID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    lstTopTasksReported.Items.Clear()
                    While reader.Read()
                        lstTopTasksReported.Items.Add($"{reader("username")} - {reader("TasksReported")} tasks")
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub LoadTopBugsReported(projectID As Integer)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT u.username, COUNT(r.ReportID) as BugsReported " &
                  "FROM issuereports r " &
                  "JOIN Users u ON r.ReporterID = u.UserID " &
                  "WHERE r.ProjectID = @selectedProjectID " &
                  "GROUP BY u.username " &
                  "ORDER BY BugsReported DESC " &
                  "LIMIT 5"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@selectedProjectID", projectID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    lstTopBugsReported.Items.Clear()
                    While reader.Read()
                        lstTopBugsReported.Items.Add($"{reader("username")} - {reader("BugsReported")} bugs")
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub LoadFastestResolvers(projectID As Integer)

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "SELECT u.username, AVG(TIMESTAMPDIFF(SECOND, t.DueDate, c.Date)) as AvgResolutionTime " &
                              "FROM Contributions c " &
                              "JOIN Users u ON c.UserID = u.UserID " &
                              "JOIN Tasks t ON t.TaskID = c.TaskID " &
                              "WHERE t.ProjectID = @selectedProjectID AND c.Type = 'Task' " &
                              "GROUP BY u.username " &
                              "ORDER BY AvgResolutionTime ASC " &
                              "LIMIT 5"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@selectedProjectID", projectID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    lstFastestResolvers.Items.Clear()
                    While reader.Read()
                        lstFastestResolvers.Items.Add($"{reader("username")} - Avg: {reader("AvgResolutionTime")} seconds")
                    End While
                End Using
            End Using
        End Using
    End Sub


End Class