Imports MySql.Data.MySqlClient

Public Class ViewIssueForm

    Private Sub ViewIssueForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIssueTitle.Text = GlobalVariables.currentIssue.Title
        txtIssueDescription.Text = GlobalVariables.currentIssue.Description
        cmbIssueStatus.Text = GlobalVariables.currentIssue.Status
        cmbIssueSeverity.Text = GlobalVariables.currentIssue.Severity

        cmbIssueStatus.Items.AddRange(New String() {"Open", "Complete"})
        cmbIssueSeverity.Items.AddRange(New String() {"Low", "Medium", "High", "Critical"})

        If GlobalVariables.currentUserRole = "Project Manager" Then
            btnUpdate.Visible = True
        End If
    End Sub

    Private Sub btnMarkComplete_Click(sender As Object, e As EventArgs) Handles btnMarkComplete.Click
        UpdateIssueStatus(GlobalVariables.currentIssue.ReportID, "Complete")

        AddContribution(GlobalVariables.currentUserId, GlobalVariables.currentIssue.ReportID, "Issue")

        MessageBox.Show("Issue marked as complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmbIssueStatus.Text = "Complete"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AddContribution(userId As Integer, reportId As Integer, type As String)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "INSERT INTO Contributions (UserID, TaskID, Type, Date) VALUES (@UserID, @ReportID, @Type, CURRENT_TIMESTAMP)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.Parameters.AddWithValue("@ReportID", reportId)
                cmd.Parameters.AddWithValue("@Type", type)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
        End Using
    End Sub


    Private Sub UpdateIssueStatus(reportId As Integer, status As String)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "UPDATE issuereports SET Status = @Status WHERE ReportID = @ReportID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@ReportID", reportId)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Complete Update"

            txtIssueTitle.ReadOnly = False
            cmbIssueStatus.Enabled = True
            txtIssueDescription.ReadOnly = False
            cmbIssueSeverity.Enabled = True
        Else
            UpdateIssueDetails(
                GlobalVariables.currentIssue.ReportID,
                txtIssueTitle.Text.Trim(),
                cmbIssueStatus.Text.Trim(),
                txtIssueDescription.Text.Trim(),
                cmbIssueSeverity.Text.Trim()
            )

            MessageBox.Show("Issue details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Text = "Update"
            txtIssueTitle.ReadOnly = True
            cmbIssueStatus.Enabled = False
            txtIssueDescription.ReadOnly = True
            cmbIssueSeverity.Enabled = False
        End If
    End Sub

    Private Sub UpdateIssueDetails(reportId As Integer, title As String, status As String, description As String, severity As String)
        Using conn As New MySqlConnection(GlobalVariables.connectionString)
            conn.Open()

            Dim query As String = "UPDATE issuereports SET Title = @Title, Status = @Status, Description = @Description, Severity = @Severity WHERE ReportID = @ReportID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Title", title)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.Parameters.AddWithValue("@Severity", severity)
                cmd.Parameters.AddWithValue("@ReportID", reportId)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Using
    End Sub

End Class
