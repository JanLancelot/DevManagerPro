<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnViewProject = New System.Windows.Forms.Button()
        Me.btnCreateProject = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.NotificationLabel = New System.Windows.Forms.Label()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(672, 36)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(82, 23)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnViewProject
        '
        Me.btnViewProject.Location = New System.Drawing.Point(679, 405)
        Me.btnViewProject.Name = "btnViewProject"
        Me.btnViewProject.Size = New System.Drawing.Size(75, 23)
        Me.btnViewProject.TabIndex = 5
        Me.btnViewProject.Text = "View Project"
        Me.btnViewProject.UseVisualStyleBackColor = True
        '
        'btnCreateProject
        '
        Me.btnCreateProject.Location = New System.Drawing.Point(584, 36)
        Me.btnCreateProject.Name = "btnCreateProject"
        Me.btnCreateProject.Size = New System.Drawing.Size(82, 23)
        Me.btnCreateProject.TabIndex = 7
        Me.btnCreateProject.Text = "Create Project"
        Me.btnCreateProject.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(496, 36)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnProfile.Size = New System.Drawing.Size(82, 23)
        Me.btnProfile.TabIndex = 8
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "DevManagerPro"
        '
        'dgvProjects
        '
        Me.dgvProjects.AllowUserToAddRows = False
        Me.dgvProjects.AllowUserToDeleteRows = False
        Me.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Location = New System.Drawing.Point(44, 74)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.ReadOnly = True
        Me.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjects.Size = New System.Drawing.Size(710, 320)
        Me.dgvProjects.TabIndex = 10
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(598, 405)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(517, 405)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'NotificationLabel
        '
        Me.NotificationLabel.AutoSize = True
        Me.NotificationLabel.Location = New System.Drawing.Point(466, 41)
        Me.NotificationLabel.Name = "NotificationLabel"
        Me.NotificationLabel.Size = New System.Drawing.Size(24, 13)
        Me.NotificationLabel.TabIndex = 13
        Me.NotificationLabel.Text = "{...}"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NotificationLabel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvProjects)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnCreateProject)
        Me.Controls.Add(Me.btnViewProject)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnViewProject As Button
    Friend WithEvents btnCreateProject As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProjects As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents NotificationLabel As Label
End Class
