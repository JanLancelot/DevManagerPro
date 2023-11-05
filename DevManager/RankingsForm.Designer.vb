<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RankingsForm
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
        Me.lstTopTasksReported = New System.Windows.Forms.ListBox()
        Me.lstTopBugsReported = New System.Windows.Forms.ListBox()
        Me.lstFastestResolvers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstTopTasksReported
        '
        Me.lstTopTasksReported.FormattingEnabled = True
        Me.lstTopTasksReported.Location = New System.Drawing.Point(28, 31)
        Me.lstTopTasksReported.Name = "lstTopTasksReported"
        Me.lstTopTasksReported.Size = New System.Drawing.Size(231, 381)
        Me.lstTopTasksReported.TabIndex = 0
        '
        'lstTopBugsReported
        '
        Me.lstTopBugsReported.FormattingEnabled = True
        Me.lstTopBugsReported.Location = New System.Drawing.Point(285, 35)
        Me.lstTopBugsReported.Name = "lstTopBugsReported"
        Me.lstTopBugsReported.Size = New System.Drawing.Size(231, 381)
        Me.lstTopBugsReported.TabIndex = 1
        '
        'lstFastestResolvers
        '
        Me.lstFastestResolvers.FormattingEnabled = True
        Me.lstFastestResolvers.Location = New System.Drawing.Point(539, 35)
        Me.lstFastestResolvers.Name = "lstFastestResolvers"
        Me.lstFastestResolvers.Size = New System.Drawing.Size(231, 381)
        Me.lstFastestResolvers.TabIndex = 2
        '
        'RankingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstFastestResolvers)
        Me.Controls.Add(Me.lstTopBugsReported)
        Me.Controls.Add(Me.lstTopTasksReported)
        Me.Name = "RankingsForm"
        Me.Text = "RankingsForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstTopTasksReported As ListBox
    Friend WithEvents lstTopBugsReported As ListBox
    Friend WithEvents lstFastestResolvers As ListBox
End Class
