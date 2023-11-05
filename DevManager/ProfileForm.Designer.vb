<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblProjectsJoined = New System.Windows.Forms.Label()
        Me.lblTasksCompleted = New System.Windows.Forms.Label()
        Me.lblIssuesResolved = New System.Windows.Forms.Label()
        Me.dgvTasks = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(38, 38)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(117, 24)
        Me.lblUsername.TabIndex = 10
        Me.lblUsername.Text = "{username}"
        '
        'lblProjectsJoined
        '
        Me.lblProjectsJoined.AutoSize = True
        Me.lblProjectsJoined.Location = New System.Drawing.Point(39, 73)
        Me.lblProjectsJoined.Name = "lblProjectsJoined"
        Me.lblProjectsJoined.Size = New System.Drawing.Size(102, 13)
        Me.lblProjectsJoined.TabIndex = 11
        Me.lblProjectsJoined.Text = "Projects Joined: {...}"
        '
        'lblTasksCompleted
        '
        Me.lblTasksCompleted.AutoSize = True
        Me.lblTasksCompleted.Location = New System.Drawing.Point(39, 96)
        Me.lblTasksCompleted.Name = "lblTasksCompleted"
        Me.lblTasksCompleted.Size = New System.Drawing.Size(139, 13)
        Me.lblTasksCompleted.TabIndex = 13
        Me.lblTasksCompleted.Text = "Total Tasks Completed: {...}"
        '
        'lblIssuesResolved
        '
        Me.lblIssuesResolved.AutoSize = True
        Me.lblIssuesResolved.Location = New System.Drawing.Point(39, 120)
        Me.lblIssuesResolved.Name = "lblIssuesResolved"
        Me.lblIssuesResolved.Size = New System.Drawing.Size(135, 13)
        Me.lblIssuesResolved.TabIndex = 14
        Me.lblIssuesResolved.Text = "Total Issues Resolved: {...}"
        '
        'dgvTasks
        '
        Me.dgvTasks.AllowUserToAddRows = False
        Me.dgvTasks.AllowUserToDeleteRows = False
        Me.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTasks.Location = New System.Drawing.Point(228, 38)
        Me.dgvTasks.Name = "dgvTasks"
        Me.dgvTasks.ReadOnly = True
        Me.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTasks.Size = New System.Drawing.Size(539, 367)
        Me.dgvTasks.TabIndex = 26
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvTasks)
        Me.Controls.Add(Me.lblIssuesResolved)
        Me.Controls.Add(Me.lblTasksCompleted)
        Me.Controls.Add(Me.lblProjectsJoined)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "ProfileForm"
        Me.Text = "ProfileForm"
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblProjectsJoined As Label
    Friend WithEvents lblTasksCompleted As Label
    Friend WithEvents lblIssuesResolved As Label
    Friend WithEvents dgvTasks As DataGridView
End Class
