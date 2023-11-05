<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewIssueForm
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIssueDescription = New System.Windows.Forms.RichTextBox()
        Me.lblViewTask = New System.Windows.Forms.Label()
        Me.btnMarkComplete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIssueTitle = New System.Windows.Forms.TextBox()
        Me.cmbIssueStatus = New System.Windows.Forms.ComboBox()
        Me.cmbIssueSeverity = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(112, 348)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(264, 23)
        Me.btnUpdate.TabIndex = 72
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Severity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Status:"
        '
        'txtIssueDescription
        '
        Me.txtIssueDescription.Location = New System.Drawing.Point(112, 173)
        Me.txtIssueDescription.Name = "txtIssueDescription"
        Me.txtIssueDescription.ReadOnly = True
        Me.txtIssueDescription.Size = New System.Drawing.Size(264, 72)
        Me.txtIssueDescription.TabIndex = 66
        Me.txtIssueDescription.Text = ""
        '
        'lblViewTask
        '
        Me.lblViewTask.AutoSize = True
        Me.lblViewTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewTask.Location = New System.Drawing.Point(194, 41)
        Me.lblViewTask.Name = "lblViewTask"
        Me.lblViewTask.Size = New System.Drawing.Size(111, 24)
        Me.lblViewTask.TabIndex = 65
        Me.lblViewTask.Text = "View Issue"
        '
        'btnMarkComplete
        '
        Me.btnMarkComplete.Location = New System.Drawing.Point(112, 319)
        Me.btnMarkComplete.Name = "btnMarkComplete"
        Me.btnMarkComplete.Size = New System.Drawing.Size(264, 23)
        Me.btnMarkComplete.TabIndex = 64
        Me.btnMarkComplete.Text = "Mark as Complete"
        Me.btnMarkComplete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Issue Name:"
        '
        'txtIssueTitle
        '
        Me.txtIssueTitle.Location = New System.Drawing.Point(112, 108)
        Me.txtIssueTitle.Name = "txtIssueTitle"
        Me.txtIssueTitle.ReadOnly = True
        Me.txtIssueTitle.Size = New System.Drawing.Size(264, 20)
        Me.txtIssueTitle.TabIndex = 61
        '
        'cmbIssueStatus
        '
        Me.cmbIssueStatus.Enabled = False
        Me.cmbIssueStatus.FormattingEnabled = True
        Me.cmbIssueStatus.Location = New System.Drawing.Point(112, 283)
        Me.cmbIssueStatus.Name = "cmbIssueStatus"
        Me.cmbIssueStatus.Size = New System.Drawing.Size(128, 21)
        Me.cmbIssueStatus.TabIndex = 73
        '
        'cmbIssueSeverity
        '
        Me.cmbIssueSeverity.Enabled = False
        Me.cmbIssueSeverity.FormattingEnabled = True
        Me.cmbIssueSeverity.Location = New System.Drawing.Point(246, 283)
        Me.cmbIssueSeverity.Name = "cmbIssueSeverity"
        Me.cmbIssueSeverity.Size = New System.Drawing.Size(130, 21)
        Me.cmbIssueSeverity.TabIndex = 74
        '
        'ViewIssueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.cmbIssueSeverity)
        Me.Controls.Add(Me.cmbIssueStatus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIssueDescription)
        Me.Controls.Add(Me.lblViewTask)
        Me.Controls.Add(Me.btnMarkComplete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIssueTitle)
        Me.Name = "ViewIssueForm"
        Me.Text = "ViewIssueForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIssueDescription As RichTextBox
    Friend WithEvents lblViewTask As Label
    Friend WithEvents btnMarkComplete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIssueTitle As TextBox
    Friend WithEvents cmbIssueStatus As ComboBox
    Friend WithEvents cmbIssueSeverity As ComboBox
End Class
