<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TaskManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.btnCreateIssue = New System.Windows.Forms.Button()
        Me.btnCreateTask = New System.Windows.Forms.Button()
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.dgvTasks = New System.Windows.Forms.DataGridView()
        Me.dgvIssues = New System.Windows.Forms.DataGridView()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.btnViewRankings = New System.Windows.Forms.Button()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIssues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(41, 74)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 14
        Me.lblDescription.Text = "Description"
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.Location = New System.Drawing.Point(40, 39)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(136, 24)
        Me.lblProjectName.TabIndex = 13
        Me.lblProjectName.Text = "Project Name"
        '
        'btnCreateIssue
        '
        Me.btnCreateIssue.Location = New System.Drawing.Point(44, 359)
        Me.btnCreateIssue.Name = "btnCreateIssue"
        Me.btnCreateIssue.Size = New System.Drawing.Size(167, 23)
        Me.btnCreateIssue.TabIndex = 16
        Me.btnCreateIssue.Text = "Create Issue Report"
        Me.btnCreateIssue.UseVisualStyleBackColor = True
        '
        'btnCreateTask
        '
        Me.btnCreateTask.Location = New System.Drawing.Point(44, 388)
        Me.btnCreateTask.Name = "btnCreateTask"
        Me.btnCreateTask.Size = New System.Drawing.Size(167, 23)
        Me.btnCreateTask.TabIndex = 18
        Me.btnCreateTask.Text = "Create Task"
        Me.btnCreateTask.UseVisualStyleBackColor = True
        Me.btnCreateTask.Visible = False
        '
        'btnJoin
        '
        Me.btnJoin.Location = New System.Drawing.Point(44, 330)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(167, 23)
        Me.btnJoin.TabIndex = 19
        Me.btnJoin.Text = "Join"
        Me.btnJoin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Members:"
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.Location = New System.Drawing.Point(44, 162)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(167, 160)
        Me.lstMembers.TabIndex = 22
        '
        'dgvTasks
        '
        Me.dgvTasks.AllowUserToAddRows = False
        Me.dgvTasks.AllowUserToDeleteRows = False
        Me.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTasks.Location = New System.Drawing.Point(244, 39)
        Me.dgvTasks.Name = "dgvTasks"
        Me.dgvTasks.ReadOnly = True
        Me.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTasks.Size = New System.Drawing.Size(523, 167)
        Me.dgvTasks.TabIndex = 25
        '
        'dgvIssues
        '
        Me.dgvIssues.AllowUserToAddRows = False
        Me.dgvIssues.AllowUserToDeleteRows = False
        Me.dgvIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvIssues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIssues.Location = New System.Drawing.Point(244, 215)
        Me.dgvIssues.Name = "dgvIssues"
        Me.dgvIssues.ReadOnly = True
        Me.dgvIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIssues.Size = New System.Drawing.Size(523, 167)
        Me.dgvIssues.TabIndex = 26
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(656, 388)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(111, 23)
        Me.btnView.TabIndex = 27
        Me.btnView.Text = "View Task or Issue"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(540, 388)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(52, 23)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnChat
        '
        Me.btnChat.Location = New System.Drawing.Point(598, 388)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(52, 23)
        Me.btnChat.TabIndex = 29
        Me.btnChat.Text = "Chat"
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'btnViewRankings
        '
        Me.btnViewRankings.Location = New System.Drawing.Point(448, 388)
        Me.btnViewRankings.Name = "btnViewRankings"
        Me.btnViewRankings.Size = New System.Drawing.Size(86, 23)
        Me.btnViewRankings.TabIndex = 30
        Me.btnViewRankings.Text = "View Rankings"
        Me.btnViewRankings.UseVisualStyleBackColor = True
        '
        'TaskManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnViewRankings)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.dgvIssues)
        Me.Controls.Add(Me.dgvTasks)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnJoin)
        Me.Controls.Add(Me.btnCreateTask)
        Me.Controls.Add(Me.btnCreateIssue)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblProjectName)
        Me.Name = "TaskManagementForm"
        Me.Text = "TaskManagementForm"
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIssues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblProjectName As Label
    Friend WithEvents btnCreateIssue As Button
    Friend WithEvents btnCreateTask As Button
    Friend WithEvents btnJoin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lstMembers As ListBox
    Friend WithEvents dgvTasks As DataGridView
    Friend WithEvents dgvIssues As DataGridView
    Friend WithEvents btnView As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnChat As Button
    Friend WithEvents btnViewRankings As Button
End Class
