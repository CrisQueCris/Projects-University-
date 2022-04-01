Imports System.Globalization
Public Class Heatperformance

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles B_CalculateHP.Click
        'Calculates Heatperformance

        Dim hpgh As New GHHeat
        Dim u_value_roof, u_value_gable, u_value_sidewall As Double
        Dim perc_roof, perc_gable, perc_sidewall As Double
        Dim hp_reduced_roof, hp_reduced_gable, hp_reduced_sidewall, hp_reduced As Double

        'Receives Greenhouse Geometry from Start Screen
        hpgh.GH_length = Double.Parse(A_Form.TB_GHlength.Text, CultureInfo.InvariantCulture)
        hpgh.GH_gablenumber = Double.Parse(A_Form.TB_GHgablenumber.Text, CultureInfo.InvariantCulture)
        hpgh.GH_gablewidth = Double.Parse(A_Form.TB_GHgablewidth.Text, CultureInfo.InvariantCulture)
        hpgh.GH_roofinclination = Double.Parse(A_Form.TB_GHroofinclination.Text, CultureInfo.InvariantCulture)
        hpgh.GH_sidewallheight = Double.Parse(A_Form.TB_GHsidewallheight.Text, CultureInfo.InvariantCulture)

        hpgh.outsidetemperature = Double.Parse(Me.TB_outsidetemp.Text, CultureInfo.InvariantCulture)
        hpgh.insidetemperature = Double.Parse(Me.TB_insidetemp.Text, CultureInfo.InvariantCulture)
        hpgh.savetytemperature = Double.Parse(Me.TB_savetytemp.Text, CultureInfo.InvariantCulture)


        'receive u_values from Tools/search_U from Database DG_screen/DG_material Without Screen

        Call search_U("cover", "sidewall", u_value_sidewall)
        hpgh.u_sidewall = u_value_sidewall

        Call search_U("cover", "gable", u_value_gable)
        hpgh.u_gable = u_value_gable

        Call search_U("cover", "roof", u_value_roof)
        hpgh.u_roof = u_value_roof

        'Calculating values using ghheat and Transfering variables to labels Without Screen

        L_hi_rz_wos.Text = Format(hpgh.hp_roof / 1000, "####0 kW")
        L_hl_ga_wos.Text = Format(hpgh.hp_gable / 1000, "####0 kW")
        L_hl_sw_wos.Text = Format(hpgh.hp_sidewall / 1000, "####0 kW")
        L_hp_wos.Text = Format(hpgh.heatperformance / 1000, "####0 kW")
        L_shp_wos.Text = Format(hpgh.savetyperformance / 1000, "####0 kW")


        'receiving u_values for with screen and calculating perfomances with screan


        Call search_U("screen", "sidewall", perc_sidewall)
        hp_reduced_sidewall = (hpgh.hp_sidewall - ((hpgh.hp_sidewall * perc_sidewall) / 100))

        Call search_U("screen", "gable", perc_gable)
        hp_reduced_gable = (hpgh.hp_gable - ((hpgh.hp_gable * perc_gable) / 100))

        Call search_U("screen", "roof", perc_roof)
        hp_reduced_roof = (hpgh.hp_roof - (hpgh.hp_roof * perc_roof / 100))
        hp_reduced = hp_reduced_gable + hp_reduced_roof + hp_reduced_sidewall
        'Transfering Variables to Labels
        L_hl_rz_s.Text = Format(hp_reduced_roof / 1000, "####0 kW")
        L_hl_ga_s.Text = Format(hp_reduced_gable / 1000, "####0 kW")
        L_hl_sw_s.Text = Format(hp_reduced_sidewall / 1000, "####0 kW")
        L_hp_s.Text = Format(hp_reduced / 1000, "####0 kW")


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub L_hp_s_Click(sender As System.Object, e As System.EventArgs) Handles L_hp_s.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'B_CalculateHP.PerformClick()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class