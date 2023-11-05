<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProjectForm
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
        Me.txtUpdateDescription = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdateProject = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUpdateTitle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtUpdateDescription
        '
        Me.txtUpdateDescription.Location = New System.Drawing.Point(107, 199)
        Me.txtUpdateDescription.Name = "txtUpdateDescription"
        Me.txtUpdateDescription.Size = New System.Drawing.Size(264, 143)
        Me.txtUpdateDescription.TabIndex = 30
        Me.txtUpdateDescription.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Update Project"
        '
        'btnUpdateProject
        '
        Me.btnUpdateProject.Location = New System.Drawing.Point(107, 357)
        Me.btnUpdateProject.Name = "btnUpdateProject"
        Me.btnUpdateProject.Size = New System.Drawing.Size(264, 23)
        Me.btnUpdateProject.TabIndex = 28
        Me.btnUpdateProject.Text = "Update Project"
        Me.btnUpdateProject.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Project Name:"
        '
        'txtUpdateTitle
        '
        Me.txtUpdateTitle.Location = New System.Drawing.Point(107, 134)
        Me.txtUpdateTitle.Name = "txtUpdateTitle"
        Me.txtUpdateTitle.Size = New System.Drawing.Size(264, 20)
        Me.txtUpdateTitle.TabIndex = 25
        '
        'UpdateProjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.txtUpdateDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUpdateProject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUpdateTitle)
        Me.Name = "UpdateProjectForm"
        Me.Text = "UpdateProjectForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUpdateDescription As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdateProject As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUpdateTitle As TextBox
End Class
