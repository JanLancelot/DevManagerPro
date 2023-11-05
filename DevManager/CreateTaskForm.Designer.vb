<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTaskForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAssignedMember = New System.Windows.Forms.ComboBox()
        Me.txtTaskDescription = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCreateTask = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTaskTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Assignee:"
        '
        'cboAssignedMember
        '
        Me.cboAssignedMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssignedMember.FormattingEnabled = True
        Me.cboAssignedMember.Location = New System.Drawing.Point(109, 354)
        Me.cboAssignedMember.Name = "cboAssignedMember"
        Me.cboAssignedMember.Size = New System.Drawing.Size(264, 21)
        Me.cboAssignedMember.TabIndex = 39
        '
        'txtTaskDescription
        '
        Me.txtTaskDescription.Location = New System.Drawing.Point(109, 173)
        Me.txtTaskDescription.Name = "txtTaskDescription"
        Me.txtTaskDescription.Size = New System.Drawing.Size(264, 84)
        Me.txtTaskDescription.TabIndex = 38
        Me.txtTaskDescription.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Create Task"
        '
        'btnCreateTask
        '
        Me.btnCreateTask.Location = New System.Drawing.Point(109, 391)
        Me.btnCreateTask.Name = "btnCreateTask"
        Me.btnCreateTask.Size = New System.Drawing.Size(264, 23)
        Me.btnCreateTask.TabIndex = 36
        Me.btnCreateTask.Text = "Create Task"
        Me.btnCreateTask.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Task Name:"
        '
        'txtTaskTitle
        '
        Me.txtTaskTitle.Location = New System.Drawing.Point(109, 108)
        Me.txtTaskTitle.Name = "txtTaskTitle"
        Me.txtTaskTitle.Size = New System.Drawing.Size(264, 20)
        Me.txtTaskTitle.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Due Date:"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Location = New System.Drawing.Point(109, 295)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(264, 20)
        Me.dtpDueDate.TabIndex = 43
        '
        'CreateTaskForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboAssignedMember)
        Me.Controls.Add(Me.txtTaskDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCreateTask)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTaskTitle)
        Me.Name = "CreateTaskForm"
        Me.Text = "CreateTaskForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cboAssignedMember As ComboBox
    Friend WithEvents txtTaskDescription As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCreateTask As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTaskTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpDueDate As DateTimePicker
End Class
