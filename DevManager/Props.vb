Imports System.Text

Module Props
    Public Class GlobalVariables
        Public Shared connectionString As String = "server=127.0.0.1;userid=root;password=;database=devmanagerpro2;"
        Public Shared currentUsername As String = ""
        Public Shared currentUserId As String = ""
        Public Shared currentUserRole As String = ""
        Public Shared currentProject As New ProjectDetails()
        Public Shared currentTask As New TaskDetails()
        Public Shared currentIssue As New IssueDetails()
    End Class

    Public Class ProjectDetails
        Public Property ProjectID As Integer
        Public Property ProjectName As String
        Public Property Description As String
        Public Property DateCreated As DateTime
        Public Property Creator As String
    End Class

    Public Class TaskDetails
        Public Property TaskID As Integer
        Public Property ProjectIDRef As Integer
        Public Property AssignedMemberID As Integer
        Public Property Title As String
        Public Property Description As String
        Public Property DueDate As DateTime
        Public Property Status As String
    End Class

    Public Class IssueDetails
        Public Property ReportID As Integer
        Public Property ProjectID As Integer
        Public Property ReporterID As Integer
        Public Property Title As String
        Public Property Description As String
        Public Property Severity As String
        Public Property Status As String
    End Class
    Function GetHashedPassword(password As String) As String
        Return BitConverter.ToString(System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password)))
    End Function
End Module
