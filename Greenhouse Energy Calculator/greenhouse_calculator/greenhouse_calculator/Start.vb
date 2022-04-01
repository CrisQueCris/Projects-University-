Imports System.IO
Public Class A_Form

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End



    End Sub

    Private Sub A_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Database.Show()
        Database.Hide()

        B_Load_Inputs.PerformClick()

        'CB_Roof_material.Text = Form2.DG_Material.Rows(0).Cells(0).Value
        For i = 0 To 49
            If Database.DG_Material(0, i).Value = "" Then Exit For
            CB_Roof_material.Items.Add(1)
            CB_Roof_material.Items(i) = Database.DG_Material(0, i).Value
        Next
        CB_sidewall_material.Text = Database.DG_Material.Rows(0).Cells(0).Value
        For i = 0 To 49
            If Database.DG_Material(0, i).Value = "" Then Exit For
            CB_sidewall_material.Items.Add(1)
            CB_sidewall_material.Items(i) = Database.DG_Material(0, i).Value
        Next
        For i = 0 To 49
            If Database.DG_Material(0, i).Value = "" Then Exit For
            CB_gable_material.Items.Add(1)
            CB_gable_material.Items(i) = Database.DG_Material(0, i).Value
        Next

        '------------------------ data from screen table to combo boxes ---------
        'CB_roof_screen.Text = Form2.DG_screen.Rows(0).Cells(0).Value
        'CB_sidewall_screen.Text = Form2.DG_screen.Rows(0).Cells(0).Value
        ' CB_gable_screen.Text = Form2.DG_screen.Rows(0).Cells(0).Value

        For i = 0 To 49
            If Database.DG_screen(0, i).Value = "" Then Exit For
            CB_roof_screen.Items.Add(1)
            CB_roof_screen.Items(i) = Database.DG_screen(0, i).Value
        Next
        CB_sidewall_material.Text = Database.DG_Material.Rows(0).Cells(0).Value
        For i = 0 To 49
            If Database.DG_screen(0, i).Value = "" Then Exit For
            CB_sidewall_screen.Items.Add(1)
            CB_sidewall_screen.Items(i) = Database.DG_screen(0, i).Value
        Next
        For i = 0 To 49
            If Database.DG_screen(0, i).Value = "" Then Exit For
            CB_gable_screen.Items.Add(1)
            CB_gable_screen.Items(i) = Database.DG_screen(0, i).Value
        Next










    End Sub

    Private Sub CoverMeterialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CoverMeterialToolStripMenuItem.Click
        Database.Show()

    End Sub

    Private Sub HeatPerformanceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HeatPerformanceToolStripMenuItem.Click
        Heatperformance.Show()

    End Sub

    Private Sub HeatConsumtionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HeatConsumtionToolStripMenuItem.Click
        HeatConsumtion.Show()
    End Sub

    Private Sub LoadInputsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadInputsToolStripMenuItem.Click
        B_Load_Inputs.PerformClick()
    End Sub

    Private Sub SaveInputsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveInputsToolStripMenuItem.Click
        B_Save_Inputs.PerformClick()
    End Sub

    Private Sub B_Save_Inputs_Click(sender As Object, e As EventArgs) Handles B_Save_Inputs.Click
        Dim sw As StreamWriter = New StreamWriter("C:\Users\Lenovo\Documents\GitHub\Projects-University-\Greenhouse Energy Calculator\greenhouse_calculator\_Energy\settings.inf")

        'save geometry
        sw.WriteLine(TB_GHlength.Text)
        sw.WriteLine(TB_GHsidewallheight.Text)
        sw.WriteLine(TB_GHgablenumber.Text)
        sw.WriteLine(TB_GHgablewidth.Text)
        sw.WriteLine(TB_GHroofinclination.Text)

        'save comboboxes
        'roof area
        sw.WriteLine(CB_Roof_material.Text)
        sw.WriteLine(CB_roof_screen.Text)

        'side wall
        sw.WriteLine(CB_sidewall_material.Text)
        sw.WriteLine(CB_sidewall_screen.Text)

        'gabel area
        sw.WriteLine(CB_gable_material.Text)
        sw.WriteLine(CB_gable_screen.Text)

        sw.Close()
    End Sub

    Private Sub B_Calculate_Click(sender As Object, e As EventArgs) Handles B_Calculate.Click
        'direct calculation behind the button
        'Dim GHwidth As Double
        'Dim GHgablenumber As Double
        'Dim GHgablewidth As Double
        'GHgablewidth = CDbl(TB_GHgablewidth.Text)
        'GHgablenumber = CDbl(TB_GHgablenumber.Text)
        'GHwidth = GHgablenumber * GHgablewidth
        'L_GHwidth.Text = GHwidth
        'Call gable_width(GHgablenumber, GHgablewidth, GHwidth)

        Dim GWH As New GHgeometry


        GWH.GH_gablenumber = CDbl(TB_GHgablenumber.Text)
        GWH.GH_gablewidth = CDbl(TB_GHgablewidth.Text)
        GWH.GH_length = CDbl(TB_GHlength.Text)
        GWH.GH_sidewallheight = CDbl(TB_GHsidewallheight.Text)
        GWH.GH_roofinclination = CDbl(TB_GHroofinclination.Text)


        L_GHwidth.Text = Format(GWH.GH_width, "#00.00 m")
        L_GHgroundarea.Text = Format(GWH.GH_groundarea, "#00.00 m²")
        L_GHgablearea.Text = Format(GWH.GH_gablearea, "#00.00 m²")
        L_GHsidewallarea.Text = Format(GWH.GH_sidewallarea, "#00.00 m²")
        L_GHroofarea.Text = Format(GWH.GH_roofarea, "#00.00 m²")
        L_GHcoverarea.Text = Format(GWH.GH_coverarea, "#00.00 m²")
        L_C2G.Text = Format(GWH.GH_cover2ground, "0.0")

    End Sub

    Private Sub B_Load_Inputs_Click(sender As Object, e As EventArgs) Handles B_Load_Inputs.Click
        Dim sw As StreamReader = New StreamReader("C:\Users\Lenovo\Documents\GitHub\Projects-University-\Greenhouse Energy Calculator\greenhouse_calculator\_Energy\settings.inf",
                                                  FileMode.Open)


        'read geometry
        TB_GHlength.Text = sw.ReadLine()
        TB_GHsidewallheight.Text = sw.ReadLine()
        TB_GHgablenumber.Text = sw.ReadLine()
        TB_GHgablewidth.Text = sw.ReadLine()
        TB_GHroofinclination.Text = sw.ReadLine()

        'read comboboxes
        'roof area
        CB_Roof_material.Text = sw.ReadLine()
        CB_roof_screen.Text = sw.ReadLine()

        'side wall
        CB_sidewall_material.Text = sw.ReadLine()
        CB_sidewall_screen.Text = sw.ReadLine()

        'gabel area
        CB_gable_material.Text = sw.ReadLine()
        CB_gable_screen.Text = sw.ReadLine()

        sw.Close()
    End Sub

    Private Sub HeatConsumptionDiagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeatConsumptionDiagramToolStripMenuItem.Click
        Consumption_diagram.Show()
    End Sub
End Class
