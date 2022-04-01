<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consumption_diagram
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart_Heatconsumption = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart_Heatconsumption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart_Heatconsumption
        '
        ChartArea1.Name = "CA_TimeSeries"
        ChartArea2.Name = "CA_Totals"
        Me.Chart_Heatconsumption.ChartAreas.Add(ChartArea1)
        Me.Chart_Heatconsumption.ChartAreas.Add(ChartArea2)
        Legend1.Name = "Legend1"
        Me.Chart_Heatconsumption.Legends.Add(Legend1)
        Me.Chart_Heatconsumption.Location = New System.Drawing.Point(23, 28)
        Me.Chart_Heatconsumption.Name = "Chart_Heatconsumption"
        Series1.ChartArea = "CA_TimeSeries"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.LegendText = "kWh per Year without Screen"
        Series1.Name = "S_withoutScree"
        Series2.ChartArea = "CA_TimeSeries"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.LegendText = "kWh per Year with Screen"
        Series2.Name = "S_withScreen"
        Series3.ChartArea = "CA_Totals"
        Series3.Legend = "Legend1"
        Series3.LegendText = "Amount in kg/100"
        Series3.Name = "FuelAmount"
        Series4.ChartArea = "CA_Totals"
        Series4.Legend = "Legend1"
        Series4.LegendText = "Yearly Costs in Cents"
        Series4.Name = "FuelCost"
        Me.Chart_Heatconsumption.Series.Add(Series1)
        Me.Chart_Heatconsumption.Series.Add(Series2)
        Me.Chart_Heatconsumption.Series.Add(Series3)
        Me.Chart_Heatconsumption.Series.Add(Series4)
        Me.Chart_Heatconsumption.Size = New System.Drawing.Size(986, 539)
        Me.Chart_Heatconsumption.TabIndex = 0
        Me.Chart_Heatconsumption.Text = "Chart1"
        '
        'Consumption_diagram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 603)
        Me.Controls.Add(Me.Chart_Heatconsumption)
        Me.Name = "Consumption_diagram"
        Me.Text = "Consumption Diagram"
        CType(Me.Chart_Heatconsumption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart_Heatconsumption As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
