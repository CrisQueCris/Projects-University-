Imports System.Globalization
Public Class Consumption_diagram
    Public total_oil, total_wood, total_coal, total_gas As Double
    Public Oilprice, Coalprice, Gasprice, Woodprice As Double
    Public Oilcost, Coalcost, Gascost, Woodcost As Double
    Private Sub Consumption_diagram_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With Chart_Heatconsumption
            '---type of diagram
            .Series("S_withoutScree").ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Series("S_withScreen").ChartType = DataVisualization.Charting.SeriesChartType.Line
            '.Series("FuelCost").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            '---marker size
            .Series("S_withoutScree").MarkerSize = 2
            .Series("S_withoutScree").MarkerSize = DataVisualization.Charting.MarkerStyle.Cross

            .Series("S_withScreen").MarkerSize = 2
            .Series("S_withScreen").MarkerSize = DataVisualization.Charting.MarkerStyle.Star4

            '-------marker color
            .Series("S_withoutScree").Color = Color.Red
            .Series("S_withScreen").Color = Color.Blue
        End With
        With HeatConsumtion
            .B_ReadOtemp.PerformClick()
            .B_loadprices.PerformClick()
            .B_SetTemp.PerformClick()
            .b_Calculation.PerformClick()
            .B_Calculatecost.PerformClick()
        End With

        Dim yvalue_without(365), yvalue_with(365), y_amount_oil(1), y_amount_wood(1), y_amount_gas(1) As Double
        Dim xvalue(365) As Double


        For i = 0 To 364
            yvalue_without(i) = HeatConsumtion.DG_consumption(3, i).Value
            If yvalue_without(i) > 0 Then
                Chart_Heatconsumption.Series(0).Points.AddXY(xvalue(i), yvalue_without(i))
            Else
                Chart_Heatconsumption.Series(0).Points.AddXY(xvalue(i), 0)
            End If
        Next
        For i = 0 To 364
            yvalue_with(i) = HeatConsumtion.DG_consumption(4, i).Value
            If yvalue_with(i) > 0 Then
                Chart_Heatconsumption.Series(1).Points.AddXY(xvalue(i), yvalue_with(i))
            Else
                Chart_Heatconsumption.Series(1).Points.AddXY(xvalue(i), 0)
            End If
        Next

        With Me.Chart_Heatconsumption.Series("FuelAmount").Points
            .AddXY("Oil", Format(HeatConsumtion.TB_oil.Text / 100))
            .AddXY("Coal", Format(HeatConsumtion.TB_coal.Text / 100))
            .AddXY("Gas", Format(HeatConsumtion.TB_Gas.Text / 100))
            .AddXY("Wood", Format(HeatConsumtion.TB_wood.Text / 100))
        End With

        With Me.Chart_Heatconsumption.Series("FuelCost").Points
            .AddXY("Oil", Format(HeatConsumtion.TB_Oilcost.Text / 100))
            .AddXY("Coal", Format(HeatConsumtion.TB_Coalcost.Text / 100))
            .AddXY("Gas", Format(HeatConsumtion.TB_Gascost.Text / 100))
            .AddXY("Wood", Format(HeatConsumtion.TB_woodcost.Text / 100))
        End With
        'y_amount_oil(0) = Format(HeatConsumtion.TB_oil.Text, "##,##")
        'Diagram.Series(2).Points.AddXY(1, y_amount_oil(0))


    End Sub

    Private Sub B_Drawdiagram_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub Chart_Heatconsumption_Click(sender As System.Object, e As System.EventArgs) Handles Chart_Heatconsumption.Click

    End Sub
End Class