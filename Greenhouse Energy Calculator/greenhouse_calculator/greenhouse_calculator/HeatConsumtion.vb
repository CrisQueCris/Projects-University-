Imports System.IO
Imports System.Globalization
Public Class HeatConsumtion
    Dim Oilprice, Coalprice, Gasprice, Woodprice As Double
    Dim Oilcost, Coalcost, Gascost, Woodcost As Double
    Dim total_oil, total_wood, total_coal, total_gas As Double

    Private Sub B_Close_Click(sender As System.Object, e As System.EventArgs) Handles B_Close.Click
        Me.Hide()

    End Sub

    Private Sub HeatConsumtion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With DG_consumption
            .ColumnCount = 9
            .RowCount = 365

            .Columns(0).HeaderText = "Date"
            .Columns(1).HeaderText = "Inside temperature"
            .Columns(2).HeaderText = "Outside temperature"
            .Columns(3).HeaderText = "Heat consumption"
            .Columns(4).HeaderText = "Heat consumption with screen"
            .Columns(5).HeaderText = "Oil"
            .Columns(6).HeaderText = "Gas"
            .Columns(7).HeaderText = "Hard coal amount"
            .Columns(8).HeaderText = "Wood"
            .RowHeadersWidth = (80)



            For i = 0 To 364
                .Rows(i).HeaderCell.Value = (i + 1).ToString
            Next

        End With
        B_ReadOtemp.PerformClick()
        B_loadprices.PerformClick()
        B_SetTemp.PerformClick()
        b_Calculation.PerformClick()
        B_Calculatecost.PerformClick()
        'B_Diagram.PerformClick()


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles B_SetTemp.Click
        For i = 0 To 364
            DG_consumption(1, i).Value = TB_Setpoint.Text



        Next
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles B_ReadOtemp.Click
        'Load Database Outside Temperature
        Dim pathname As String
        Dim t_sum, t_number, t_average As Double
        Dim part As String()
        Dim t_line As String


        For i = 0 To 364
            t_sum = 0
            'Double.Parse(t_sum, CultureInfo.InvariantCulture)
            t_number = 0
            pathname = "C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\climate\outside temperature\" + (i + 9498).ToString
            DG_consumption(0, i).Value = FileDateTime(pathname)

            Dim sr As StreamReader = New StreamReader(pathname)

            Do Until sr.Peek() = -1
                'read the line
                t_line = sr.ReadLine()
                'split the line with ";"
                part = t_line.Split(";")
                ' Double.Parse(part(1), CultureInfo.InvariantCulture)

                t_sum = t_sum + Double.Parse(part(1), CultureInfo.InvariantCulture)

                't_number = t_number + 1
                t_number += 1
            Loop

            t_average = t_sum / t_number
            DG_consumption(2, i).Value = t_average
            sr.Close()
        Next


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles b_Calculation.Click
        Dim hcgh As New GHHeat
        Dim u_value_roof, u_value_gable, u_value_sidewall As Double
        Dim perc_roof, perc_gable, perc_sidewall As Double
        Dim hp_reduced_roof, hp_reduced_gable, hp_reduced_sidewall, hp_reduced As Double
        Dim u_value_oil, u_value_wood, u_value_coal, u_value_gas As Double
        Dim amount_oil, amount_wood, amount_coal, amount_gas As Double


       



        hcgh.GH_length = CDbl(A_Form.TB_GHlength.Text)
        hcgh.GH_gablenumber = CDbl(A_Form.TB_GHgablenumber.Text)
        hcgh.GH_gablewidth = CDbl(A_Form.TB_GHgablewidth.Text)
        hcgh.GH_roofinclination = CDbl(A_Form.TB_GHroofinclination.Text)
        hcgh.GH_sidewallheight = CDbl(A_Form.TB_GHsidewallheight.Text)

        For i = 0 To 364


            'hcgh.outsidetemperature = Val(Me.TB_outsidetemp.Text)
            hcgh.outsidetemperature = DG_consumption(2, i).Value
            hcgh.insidetemperature = DG_consumption(1, i).Value
            'hcgh.insidetemperature = Val(Me.TB_insidetemp.Text)

            Call search_U("cover", "roof", u_value_roof)
            hcgh.u_roof = u_value_roof

            Call search_U("cover", "sidewall", u_value_sidewall)
            hcgh.u_sidewall = u_value_sidewall

            Call search_U("cover", "gable", u_value_gable)
            hcgh.u_gable = u_value_gable

            'L_hi_rz_wos.Text = Format(hcgh.hp_roof / 1000, "####0 kW")
            'L_hl_ga_wos.Text = Format(hcgh.hp_gable / 1000, "####0 kW")
            'L_hl_sw_wos.Text = Format(hcgh.hp_sidewall / 1000, "####0 kW")

            'L_hp_wos.Text = Format(hcgh.heatperformance / 1000, "####0 kW")

            DG_consumption(3, i).Value = hcgh.heatperformance / 1000 * 24

            Call search_U("screen", "roof", perc_roof)

            Call search_U("screen", "gable", perc_gable)

            Call search_U("screen", "sidewall", perc_sidewall)

            hp_reduced_roof = (hcgh.hp_roof - (hcgh.hp_roof * perc_roof / 100))
            hp_reduced_gable = (hcgh.hp_gable - (hcgh.hp_gable * perc_gable / 100))
            hp_reduced_sidewall = (hcgh.hp_sidewall - (hcgh.hp_sidewall * perc_sidewall / 100))

            'L_hl_rz_s.Text = Format(hp_reduced_roof / 1000, "####0 kW")
            'L_hl_ga_s.Text = Format(hp_reduced_gable / 1000, "####0 kW")
            'L_hl_sw_s.Text = Format(hp_reduced_sidewall / 1000, "####0 kW")

            hp_reduced = hp_reduced_gable + hp_reduced_roof + hp_reduced_sidewall

            DG_consumption(4, i).Value = hp_reduced / 1000 * 24

            'L_hp_s.Text = Format(hp_reduced / 1000, "####0 kW")

            'Calculate Oil consumtion

            'DG_burningmaterial.Rows(linecounter2).Cells(0).Value = part(0)
            'DG_burningmaterial.Rows(linecounter2).Cells(1).Value = part(1)

            For j = 0 To 49
                Select Case Database.DG_burningmaterial(0, j).Value
                    Case "oil"
                        u_value_oil = Double.Parse(Database.DG_burningmaterial(1, j).Value, CultureInfo.InvariantCulture)
                    Case "gas"
                        u_value_gas = Double.Parse(Database.DG_burningmaterial(1, j).Value, CultureInfo.InvariantCulture)
                    Case "wood"
                        u_value_wood = Double.Parse(Database.DG_burningmaterial(1, j).Value, CultureInfo.InvariantCulture)
                    Case "coal"
                        u_value_coal = Double.Parse(Database.DG_burningmaterial(1, j).Value, CultureInfo.InvariantCulture)
                End Select
            Next
            amount_oil = (hp_reduced * 3.6 / (u_value_oil * 1000 * 24))
            DG_consumption(5, i).Value = Format(amount_oil, "## ##0.0 kg")
            amount_gas = (0.15 * hp_reduced / (u_value_gas * 1000))
            DG_consumption(6, i).Value = Format(amount_gas, "## ##0.0 kg")
            amount_wood = (0.15 * hp_reduced / (u_value_wood * 1000))
            DG_consumption(8, i).Value = Format(amount_wood, "## ##0.0 kg")
            amount_coal = (0.15 * hp_reduced / (u_value_coal * 1000))
            DG_consumption(7, i).Value = Format(amount_coal, "## ##0.0 kg")
            total_coal = total_coal + amount_coal
            total_gas = total_gas + amount_gas
            total_wood = total_wood + amount_wood
            total_oil = total_oil + amount_oil
            TB_coal.Text = Format(total_coal, "####0.00")
            TB_Gas.Text = Format(total_gas, "####0.00")
            TB_wood.Text = Format(total_wood, "####0.00")
            TB_oil.Text = Format(total_oil, "####0.00")
        Next


    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles B_Diagram.Click
        Consumption_diagram.Show()

    End Sub

    Private Sub DG_consumption_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_consumption.CellContentClick

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub B_Saveprices_Click(sender As System.Object, e As System.EventArgs) Handles B_Saveprices.Click
        Dim sw As StreamWriter = New StreamWriter("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\prices.inf")

        'save prices
        sw.WriteLine(TB_Oilprice.Text)
        sw.WriteLine(TB_Coalprice.Text)
        sw.WriteLine(TB_Gasprice.Text)
        sw.WriteLine(TB_WoodPrice.Text)
        sw.Close()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles B_loadprices.Click
        Dim sw As StreamReader = New StreamReader("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\prices.inf", FileMode.Open)


        'read geometry
        TB_Oilprice.Text = sw.ReadLine()
        TB_Coalprice.Text = sw.ReadLine()
        TB_Gasprice.Text = sw.ReadLine()
        TB_WoodPrice.Text = sw.ReadLine()
        sw.Close()
    End Sub

    Private Sub B_Calculatecost_Click(sender As System.Object, e As System.EventArgs) Handles B_Calculatecost.Click
       
        

        Oilprice = Double.Parse(TB_Oilprice.Text, CultureInfo.InvariantCulture)
        Coalprice = Double.Parse(TB_Coalprice.Text, CultureInfo.InvariantCulture)
        Gasprice = Double.Parse(TB_Gasprice.Text, CultureInfo.InvariantCulture)
        Woodprice = Double.Parse(TB_Oilprice.Text, CultureInfo.InvariantCulture)

        'Calculate Fuel Cost with amounts and price
        Oilcost = (Oilprice * total_oil / (100 * 0.86))
        Coalcost = Coalprice * total_coal / 1000
        Gascost = Gasprice * total_gas
        Woodcost = Woodprice * total_wood / 500

        TB_Oilcost.Text = Format(Oilcost, "####0.00")
        TB_Coalcost.Text = Format(Coalcost, "####0.00")
        TB_Gascost.Text = Format(Gascost, "####0.00")
        TB_woodcost.Text = Format(Woodcost, "####0.00")


      
    End Sub

    Private Sub TB_Coalprice_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_Coalprice.TextChanged

    End Sub

    Private Sub TB_Oilprice_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_Oilprice.TextChanged

    End Sub

    Private Sub GB_fuelprices_Enter(sender As System.Object, e As System.EventArgs) Handles GB_fuelprices.Enter

    End Sub
End Class