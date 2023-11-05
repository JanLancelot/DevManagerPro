<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTaskForm
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
        Me.txtTaskDescription = New System.Windows.Forms.RichTextBox()
        Me.lblViewTask = New System.Windows.Forms.Label()
        Me.btnMarkComplete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTaskTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtDueDate = New System.Windows.Forms.TextBox()
        Me.cmbTaskStatus = New System.Windows.Forms.ComboBox()
        Me.cmbAssignee = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtTaskDescription
        '
        Me.txtTaskDescription.Location = New System.Drawing.Point(98, 163)
        Me.txtTaskDescription.Name = "txtTaskDescription"
        Me.txtTaskDescription.ReadOnly = True
        Me.txtTaskDescription.Size = New System.Drawing.Size(264, 72)
        Me.txtTaskDescription.TabIndex = 36
        Me.txtTaskDescription.Text = ""
        '
        'lblViewTask
        '
        Me.lblViewTask.AutoSize = True
        Me.lblViewTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewTask.Location = New System.Drawing.Point(180, 31)
        Me.lblViewTask.Name = "lblViewTask"
        Me.lblViewTask.Size = New System.Drawing.Size(106, 24)
        Me.lblViewTask.TabIndex = 35
        Me.lblViewTask.Text = "View Task"
        '
        'btnMarkComplete
        '
        Me.btnMarkComplete.Location = New System.Drawing.Point(98, 358)
        Me.btnMarkComplete.Name = "btnMarkComplete"
        Me.btnMarkComplete.Size = New System.Drawing.Size(264, 23)
        Me.btnMarkComplete.TabIndex = 34
        Me.btnMarkComplete.Text = "Mark as Complete"
        Me.btnMarkComplete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Task Name:"
        '
        'txtTaskTitle
        '
        Me.txtTaskTitle.Location = New System.Drawing.Point(98, 98)
        Me.txtTaskTitle.Name = "txtTaskTitle"
        Me.txtTaskTitle.ReadOnly = True
        Me.txtTaskTitle.Size = New System.Drawing.Size(264, 20)
        Me.txtTaskTitle.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Assigned to:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Due Date:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 387)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(264, 23)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'txtDueDate
        '
        Me.txtDueDate.Location = New System.Drawing.Point(98, 332)
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.ReadOnly = True
        Me.txtDueDate.Size = New System.Drawing.Size(264, 20)
        Me.txtDueDate.TabIndex = 47
        '
        'cmbTaskStatus
        '
        Me.cmbTaskStatus.Enabled = False
        Me.cmbTaskStatus.FormattingEnabled = True
        Me.cmbTaskStatus.Items.AddRange(New Object() {"Pending", "Complete"})
        Me.cmbTaskStatus.Location = New System.Drawing.Point(98, 274)
        Me.cmbTaskStatus.Name = "cmbTaskStatus"
        Me.cmbTaskStatus.Size = New System.Drawing.Size(128, 21)
        Me.cmbTaskStatus.TabIndex = 48
        '
        'cmbAssignee
        '
        Me.cmbAssignee.Enabled = False
        Me.cmbAssignee.FormattingEnabled = True
        Me.cmbAssignee.Location = New System.Drawing.Point(232, 274)
        Me.cmbAssignee.Name = "cmbAssignee"
        Me.cmbAssignee.Size = New System.Drawing.Size(130, 21)
        Me.cmbAssignee.TabIndex = 49
        '
        'ViewTaskForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.cmbAssignee)
        Me.Controls.Add(Me.cmbTaskStatus)
        Me.Controls.Add(Me.txtDueDate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTaskDescription)
        Me.Controls.Add(Me.lblViewTask)
        Me.Controls.Add(Me.btnMarkComplete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTaskTitle)
        Me.Name = "ViewTaskForm"
        Me.Text = "ViewTaskForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTaskDescription As RichTextBox
    Friend WithEvents lblViewTask As Label
    Friend WithEvents btnMarkComplete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTaskTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtDueDate As TextBox
    Friend WithEvents cmbTaskStatus As ComboBox
    Friend WithEvents cmbAssignee As ComboBox
End Class
