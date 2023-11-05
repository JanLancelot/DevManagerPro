Imports MySql.Data.MySqlClient

Public Class IssueForm
    Private Sub btnCreateIssueReport_Click(sender As Object, e As EventArgs) Handles btnCreateIssueReport.Click
        Dim title As String = txtIssueTitle.Text
        Dim description As String = txtIssueDescription.Text
        Dim severity As String = cboSeverity.SelectedItem.ToString()

        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO IssueReports (ProjectID, ReporterID, Title, Description, Severity) VALUES (@ProjectID, @ReporterID, @Title, @Description, @Severity)", conn)
            cmd.Parameters.AddWithValue("@ProjectID", GlobalVariables.currentProject.ProjectID)
            cmd.Parameters.AddWithValue("@ReporterID", GlobalVariables.currentUserId)
            cmd.Parameters.AddWithValue("@Title", title)
            cmd.Parameters.AddWithValue("@Description", description)
            cmd.Parameters.AddWithValue("@Severity", severity)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Issue reported successfully!")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to report the issue.")
            End If
        End Using
    End Sub

    Private Sub IssueForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class