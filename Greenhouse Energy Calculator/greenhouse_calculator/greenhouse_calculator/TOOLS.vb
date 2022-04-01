Imports System.Globalization

Module TOOLS
    Sub gable_width(ByVal GHgablenumber, ByVal GHgablewidth, ByRef GHwidth)
        'Dim GHwidth As Double
        'Dim GHgablenumber As Double
        'Dim GHgablewidth As Double
        'GHgablewidth = Val(A_Form.TB_GHgablewidth.Text)
        'GHgablenumber = Val(A_Form.TB_GHgablenumber.Text)
        GHwidth = GHgablenumber * GHgablewidth
        'A_Form.L_GHwidth.Text = GHwidth
    End Sub
 
    Sub search_U(ByVal layer, ByVal area, ByRef u_value)
        ' layer: covermaterial or screen material or isolation materials
        ' area: greenhouse surface like roof, sidewall, gable
        ' u-value: result of the search
        Dim i As Int16

        For i = 0 To 49
            Select Case layer
                Case "cover"
                    Select Case area
                        Case "gable"
                            If A_Form.CB_gable_material.Text = Database.DG_Material(0, i).Value Then
                                u_value = Double.Parse(Database.DG_Material(1, i).Value, CultureInfo.InvariantCulture)
                            End If
                        Case "sidewall"
                            If A_Form.CB_sidewall_material.Text = Database.DG_Material.Rows(i).Cells(0).Value Then
                                u_value = Double.Parse(Database.DG_Material(1, i).Value, CultureInfo.InvariantCulture)
                            End If
                        Case "roof"
                            If A_Form.CB_Roof_material.Text = Database.DG_Material(0, i).Value Then
                                u_value = Double.Parse(Database.DG_Material(1, i).Value, CultureInfo.InvariantCulture)
                            End If
                            '                Case Else
                            '                    MsgBox("material is not know! Please insert in Database", MsgBoxStyle.OkCancel, "Attention")
                    End Select
                Case "screen"
                    Select Case area
                        Case "sidewall"
                            If A_Form.CB_sidewall_screen.Text = Database.DG_screen(0, i).Value Then
                                u_value = Double.Parse(Database.DG_screen(1, i).Value, CultureInfo.InvariantCulture)
                            End If
                        Case "gable"
                            If A_Form.CB_gable_screen.Text = Database.DG_screen(0, i).Value Then
                                u_value = Double.Parse(Database.DG_screen(1, i).Value, CultureInfo.InvariantCulture)
                            End If

                        Case "roof"
                            If A_Form.CB_roof_screen.Text = Database.DG_screen(0, i).Value Then
                                u_value = Double.Parse(Database.DG_screen(1, i).Value, CultureInfo.InvariantCulture)
                            End If
                            'Case Else
                            '    MsgBox("material is not know! Please insert in Database", MsgBoxStyle.OkCancel, "Attention")
                    End Select
            End Select

        Next
        i = 0



    End Sub
End Module
