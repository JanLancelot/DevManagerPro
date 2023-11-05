<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIssueDescription = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCreateIssueReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIssueTitle = New System.Windows.Forms.TextBox()
        Me.cboSeverity = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtIssueDescription
        '
        Me.txtIssueDescription.Location = New System.Drawing.Point(105, 175)
        Me.txtIssueDescription.Name = "txtIssueDescription"
        Me.txtIssueDescription.Size = New System.Drawing.Size(264, 143)
        Me.txtIssueDescription.TabIndex = 30
        Me.txtIssueDescription.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Create Issue Report"
        '
        'btnCreateIssueReport
        '
        Me.btnCreateIssueReport.Location = New System.Drawing.Point(105, 393)
        Me.btnCreateIssueReport.Name = "btnCreateIssueReport"
        Me.btnCreateIssueReport.Size = New System.Drawing.Size(264, 23)
        Me.btnCreateIssueReport.TabIndex = 28
        Me.btnCreateIssueReport.Text = "Register"
        Me.btnCreateIssueReport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Issue Name:"
        '
        'txtIssueTitle
        '
        Me.txtIssueTitle.Location = New System.Drawing.Point(105, 110)
        Me.txtIssueTitle.Name = "txtIssueTitle"
        Me.txtIssueTitle.Size = New System.Drawing.Size(264, 20)
        Me.txtIssueTitle.TabIndex = 25
        '
        'cboSeverity
        '
        Me.cboSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeverity.FormattingEnabled = True
        Me.cboSeverity.Items.AddRange(New Object() {"Low", "Medium", "High", "Critical"})
        Me.cboSeverity.Location = New System.Drawing.Point(105, 356)
        Me.cboSeverity.Name = "cboSeverity"
        Me.cboSeverity.Size = New System.Drawing.Size(264, 21)
        Me.cboSeverity.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Severity:"
        '
        'IssueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSeverity)
        Me.Controls.Add(Me.txtIssueDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCreateIssueReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIssueTitle)
        Me.Name = "IssueForm"
        Me.Text = "IssueForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIssueDescription As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCreateIssueReport As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIssueTitle As TextBox
    Friend WithEvents cboSeverity As ComboBox
    Friend WithEvents Label3 As Label
End Class
