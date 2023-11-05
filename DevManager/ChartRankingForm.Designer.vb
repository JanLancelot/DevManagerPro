<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChartRankingForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chartTopTasksReported = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartTopBugsReported = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartFastestResolvers = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartTopTasksReported, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartTopBugsReported, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartFastestResolvers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartTopTasksReported
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartTopTasksReported.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartTopTasksReported.Legends.Add(Legend1)
        Me.chartTopTasksReported.Location = New System.Drawing.Point(24, 30)
        Me.chartTopTasksReported.Name = "chartTopTasksReported"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartTopTasksReported.Series.Add(Series1)
        Me.chartTopTasksReported.Size = New System.Drawing.Size(310, 391)
        Me.chartTopTasksReported.TabIndex = 0
        Me.chartTopTasksReported.Text = "Chart1"
        '
        'chartTopBugsReported
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartTopBugsReported.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartTopBugsReported.Legends.Add(Legend2)
        Me.chartTopBugsReported.Location = New System.Drawing.Point(340, 30)
        Me.chartTopBugsReported.Name = "chartTopBugsReported"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartTopBugsReported.Series.Add(Series2)
        Me.chartTopBugsReported.Size = New System.Drawing.Size(310, 391)
        Me.chartTopBugsReported.TabIndex = 1
        Me.chartTopBugsReported.Text = "Chart2"
        '
        'chartFastestResolvers
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartFastestResolvers.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartFastestResolvers.Legends.Add(Legend3)
        Me.chartFastestResolvers.Location = New System.Drawing.Point(656, 30)
        Me.chartFastestResolvers.Name = "chartFastestResolvers"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chartFastestResolvers.Series.Add(Series3)
        Me.chartFastestResolvers.Size = New System.Drawing.Size(310, 391)
        Me.chartFastestResolvers.TabIndex = 2
        Me.chartFastestResolvers.Text = "Chart3"
        '
        'ChartRankingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 450)
        Me.Controls.Add(Me.chartFastestResolvers)
        Me.Controls.Add(Me.chartTopBugsReported)
        Me.Controls.Add(Me.chartTopTasksReported)
        Me.Name = "ChartRankingForm"
        Me.Text = "ChartRankingForm"
        CType(Me.chartTopTasksReported, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartTopBugsReported, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartFastestResolvers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chartTopTasksReported As DataVisualization.Charting.Chart
    Friend WithEvents chartTopBugsReported As DataVisualization.Charting.Chart
    Friend WithEvents chartFastestResolvers As DataVisualization.Charting.Chart
End Class
