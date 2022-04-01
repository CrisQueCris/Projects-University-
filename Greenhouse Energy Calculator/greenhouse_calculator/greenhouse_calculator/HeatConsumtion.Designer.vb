<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeatConsumtion
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
        Me.DG_consumption = New System.Windows.Forms.DataGridView()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.b_Calculation = New System.Windows.Forms.Button()
        Me.B_SetTemp = New System.Windows.Forms.Button()
        Me.TB_Setpoint = New System.Windows.Forms.TextBox()
        Me.B_ReadOtemp = New System.Windows.Forms.Button()
        Me.B_Diagram = New System.Windows.Forms.Button()
        Me.GB_totalamounts = New System.Windows.Forms.GroupBox()
        Me.TB_wood = New System.Windows.Forms.TextBox()
        Me.TB_Gas = New System.Windows.Forms.TextBox()
        Me.TB_coal = New System.Windows.Forms.TextBox()
        Me.TB_oil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB_fuelprices = New System.Windows.Forms.GroupBox()
        Me.B_loadprices = New System.Windows.Forms.Button()
        Me.B_Calculatecost = New System.Windows.Forms.Button()
        Me.B_Saveprices = New System.Windows.Forms.Button()
        Me.TB_WoodPrice = New System.Windows.Forms.TextBox()
        Me.TB_Gasprice = New System.Windows.Forms.TextBox()
        Me.TB_Coalprice = New System.Windows.Forms.TextBox()
        Me.TB_Oilprice = New System.Windows.Forms.TextBox()
        Me.L_Wood = New System.Windows.Forms.Label()
        Me.L_Gas = New System.Windows.Forms.Label()
        Me.L_Coal = New System.Windows.Forms.Label()
        Me.L_Oil = New System.Windows.Forms.Label()
        Me.GB_fuelcost = New System.Windows.Forms.GroupBox()
        Me.TB_woodcost = New System.Windows.Forms.TextBox()
        Me.TB_Oilcost = New System.Windows.Forms.TextBox()
        Me.TB_Gascost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_Coalcost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DG_consumption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_totalamounts.SuspendLayout()
        Me.GB_fuelprices.SuspendLayout()
        Me.GB_fuelcost.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_consumption
        '
        Me.DG_consumption.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_consumption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_consumption.Location = New System.Drawing.Point(40, 36)
        Me.DG_consumption.Name = "DG_consumption"
        Me.DG_consumption.Size = New System.Drawing.Size(1089, 466)
        Me.DG_consumption.TabIndex = 0
        '
        'B_Close
        '
        Me.B_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_Close.Location = New System.Drawing.Point(1052, 607)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(77, 23)
        Me.B_Close.TabIndex = 1
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'b_Calculation
        '
        Me.b_Calculation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.b_Calculation.Location = New System.Drawing.Point(161, 565)
        Me.b_Calculation.Name = "b_Calculation"
        Me.b_Calculation.Size = New System.Drawing.Size(123, 23)
        Me.b_Calculation.TabIndex = 2
        Me.b_Calculation.Text = "Calculation"
        Me.b_Calculation.UseVisualStyleBackColor = True
        '
        'B_SetTemp
        '
        Me.B_SetTemp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_SetTemp.Location = New System.Drawing.Point(40, 522)
        Me.B_SetTemp.Name = "B_SetTemp"
        Me.B_SetTemp.Size = New System.Drawing.Size(115, 37)
        Me.B_SetTemp.TabIndex = 3
        Me.B_SetTemp.Text = "Set Temperature"
        Me.B_SetTemp.UseVisualStyleBackColor = True
        '
        'TB_Setpoint
        '
        Me.TB_Setpoint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_Setpoint.Location = New System.Drawing.Point(40, 565)
        Me.TB_Setpoint.Name = "TB_Setpoint"
        Me.TB_Setpoint.Size = New System.Drawing.Size(95, 20)
        Me.TB_Setpoint.TabIndex = 4
        Me.TB_Setpoint.Text = "20"
        '
        'B_ReadOtemp
        '
        Me.B_ReadOtemp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_ReadOtemp.Location = New System.Drawing.Point(161, 522)
        Me.B_ReadOtemp.Name = "B_ReadOtemp"
        Me.B_ReadOtemp.Size = New System.Drawing.Size(123, 37)
        Me.B_ReadOtemp.TabIndex = 5
        Me.B_ReadOtemp.Text = "Read Outside temperature"
        Me.B_ReadOtemp.UseVisualStyleBackColor = True
        '
        'B_Diagram
        '
        Me.B_Diagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_Diagram.Location = New System.Drawing.Point(1052, 577)
        Me.B_Diagram.Name = "B_Diagram"
        Me.B_Diagram.Size = New System.Drawing.Size(77, 23)
        Me.B_Diagram.TabIndex = 6
        Me.B_Diagram.Text = "Diagram"
        Me.B_Diagram.UseVisualStyleBackColor = True
        '
        'GB_totalamounts
        '
        Me.GB_totalamounts.Controls.Add(Me.TB_wood)
        Me.GB_totalamounts.Controls.Add(Me.TB_Gas)
        Me.GB_totalamounts.Controls.Add(Me.TB_coal)
        Me.GB_totalamounts.Controls.Add(Me.TB_oil)
        Me.GB_totalamounts.Controls.Add(Me.Label4)
        Me.GB_totalamounts.Controls.Add(Me.Label3)
        Me.GB_totalamounts.Controls.Add(Me.Label2)
        Me.GB_totalamounts.Controls.Add(Me.Label1)
        Me.GB_totalamounts.Location = New System.Drawing.Point(291, 509)
        Me.GB_totalamounts.Name = "GB_totalamounts"
        Me.GB_totalamounts.Size = New System.Drawing.Size(124, 130)
        Me.GB_totalamounts.TabIndex = 7
        Me.GB_totalamounts.TabStop = False
        Me.GB_totalamounts.Text = "Usage per Year in Kg"
        '
        'TB_wood
        '
        Me.TB_wood.Location = New System.Drawing.Point(47, 100)
        Me.TB_wood.Name = "TB_wood"
        Me.TB_wood.Size = New System.Drawing.Size(52, 20)
        Me.TB_wood.TabIndex = 7
        '
        'TB_Gas
        '
        Me.TB_Gas.Location = New System.Drawing.Point(47, 73)
        Me.TB_Gas.Name = "TB_Gas"
        Me.TB_Gas.Size = New System.Drawing.Size(52, 20)
        Me.TB_Gas.TabIndex = 6
        '
        'TB_coal
        '
        Me.TB_coal.Location = New System.Drawing.Point(47, 46)
        Me.TB_coal.Name = "TB_coal"
        Me.TB_coal.Size = New System.Drawing.Size(52, 20)
        Me.TB_coal.TabIndex = 5
        '
        'TB_oil
        '
        Me.TB_oil.Location = New System.Drawing.Point(47, 19)
        Me.TB_oil.Name = "TB_oil"
        Me.TB_oil.Size = New System.Drawing.Size(52, 20)
        Me.TB_oil.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Wood"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Oil"
        '
        'GB_fuelprices
        '
        Me.GB_fuelprices.Controls.Add(Me.B_loadprices)
        Me.GB_fuelprices.Controls.Add(Me.B_Calculatecost)
        Me.GB_fuelprices.Controls.Add(Me.B_Saveprices)
        Me.GB_fuelprices.Controls.Add(Me.TB_WoodPrice)
        Me.GB_fuelprices.Controls.Add(Me.TB_Gasprice)
        Me.GB_fuelprices.Controls.Add(Me.TB_Coalprice)
        Me.GB_fuelprices.Controls.Add(Me.TB_Oilprice)
        Me.GB_fuelprices.Controls.Add(Me.L_Wood)
        Me.GB_fuelprices.Controls.Add(Me.L_Gas)
        Me.GB_fuelprices.Controls.Add(Me.L_Coal)
        Me.GB_fuelprices.Controls.Add(Me.L_Oil)
        Me.GB_fuelprices.Location = New System.Drawing.Point(421, 509)
        Me.GB_fuelprices.Name = "GB_fuelprices"
        Me.GB_fuelprices.Size = New System.Drawing.Size(372, 130)
        Me.GB_fuelprices.TabIndex = 8
        Me.GB_fuelprices.TabStop = False
        Me.GB_fuelprices.Text = "Fuel Prices"
        '
        'B_loadprices
        '
        Me.B_loadprices.Location = New System.Drawing.Point(291, 20)
        Me.B_loadprices.Name = "B_loadprices"
        Me.B_loadprices.Size = New System.Drawing.Size(75, 23)
        Me.B_loadprices.TabIndex = 10
        Me.B_loadprices.Text = "Load Prices"
        Me.B_loadprices.UseVisualStyleBackColor = True
        '
        'B_Calculatecost
        '
        Me.B_Calculatecost.Location = New System.Drawing.Point(291, 80)
        Me.B_Calculatecost.Name = "B_Calculatecost"
        Me.B_Calculatecost.Size = New System.Drawing.Size(75, 40)
        Me.B_Calculatecost.TabIndex = 9
        Me.B_Calculatecost.Text = "Calculate Cost"
        Me.B_Calculatecost.UseVisualStyleBackColor = True
        '
        'B_Saveprices
        '
        Me.B_Saveprices.Location = New System.Drawing.Point(291, 52)
        Me.B_Saveprices.Name = "B_Saveprices"
        Me.B_Saveprices.Size = New System.Drawing.Size(75, 23)
        Me.B_Saveprices.TabIndex = 8
        Me.B_Saveprices.Text = "Save Prices"
        Me.B_Saveprices.UseVisualStyleBackColor = True
        '
        'TB_WoodPrice
        '
        Me.TB_WoodPrice.Location = New System.Drawing.Point(231, 100)
        Me.TB_WoodPrice.Name = "TB_WoodPrice"
        Me.TB_WoodPrice.Size = New System.Drawing.Size(53, 20)
        Me.TB_WoodPrice.TabIndex = 7
        '
        'TB_Gasprice
        '
        Me.TB_Gasprice.Location = New System.Drawing.Point(231, 76)
        Me.TB_Gasprice.Name = "TB_Gasprice"
        Me.TB_Gasprice.Size = New System.Drawing.Size(53, 20)
        Me.TB_Gasprice.TabIndex = 6
        '
        'TB_Coalprice
        '
        Me.TB_Coalprice.Location = New System.Drawing.Point(231, 52)
        Me.TB_Coalprice.Name = "TB_Coalprice"
        Me.TB_Coalprice.Size = New System.Drawing.Size(53, 20)
        Me.TB_Coalprice.TabIndex = 5
        '
        'TB_Oilprice
        '
        Me.TB_Oilprice.Location = New System.Drawing.Point(231, 28)
        Me.TB_Oilprice.Name = "TB_Oilprice"
        Me.TB_Oilprice.Size = New System.Drawing.Size(53, 20)
        Me.TB_Oilprice.TabIndex = 4
        '
        'L_Wood
        '
        Me.L_Wood.AutoSize = True
        Me.L_Wood.Location = New System.Drawing.Point(10, 104)
        Me.L_Wood.Name = "L_Wood"
        Me.L_Wood.Size = New System.Drawing.Size(224, 13)
        Me.L_Wood.TabIndex = 3
        Me.L_Wood.Text = "Wood (loosly packed cubic meter/ca. 500 kg)"
        '
        'L_Gas
        '
        Me.L_Gas.AutoSize = True
        Me.L_Gas.Location = New System.Drawing.Point(10, 77)
        Me.L_Gas.Name = "L_Gas"
        Me.L_Gas.Size = New System.Drawing.Size(65, 13)
        Me.L_Gas.TabIndex = 2
        Me.L_Gas.Text = "Gas (per kg)"
        '
        'L_Coal
        '
        Me.L_Coal.AutoSize = True
        Me.L_Coal.Location = New System.Drawing.Point(10, 50)
        Me.L_Coal.Name = "L_Coal"
        Me.L_Coal.Size = New System.Drawing.Size(94, 13)
        Me.L_Coal.TabIndex = 1
        Me.L_Coal.Text = "Coal (per 1000 kg)"
        '
        'L_Oil
        '
        Me.L_Oil.AutoSize = True
        Me.L_Oil.Location = New System.Drawing.Point(10, 23)
        Me.L_Oil.Name = "L_Oil"
        Me.L_Oil.Size = New System.Drawing.Size(87, 13)
        Me.L_Oil.TabIndex = 0
        Me.L_Oil.Text = "Oil (per 100 Liter)"
        '
        'GB_fuelcost
        '
        Me.GB_fuelcost.Controls.Add(Me.TB_woodcost)
        Me.GB_fuelcost.Controls.Add(Me.TB_Oilcost)
        Me.GB_fuelcost.Controls.Add(Me.TB_Gascost)
        Me.GB_fuelcost.Controls.Add(Me.Label8)
        Me.GB_fuelcost.Controls.Add(Me.TB_Coalcost)
        Me.GB_fuelcost.Controls.Add(Me.Label7)
        Me.GB_fuelcost.Controls.Add(Me.Label6)
        Me.GB_fuelcost.Controls.Add(Me.Label5)
        Me.GB_fuelcost.Location = New System.Drawing.Point(849, 509)
        Me.GB_fuelcost.Name = "GB_fuelcost"
        Me.GB_fuelcost.Size = New System.Drawing.Size(151, 129)
        Me.GB_fuelcost.TabIndex = 9
        Me.GB_fuelcost.TabStop = False
        Me.GB_fuelcost.Text = "Fuel Cost per Year in Euro"
        '
        'TB_woodcost
        '
        Me.TB_woodcost.Location = New System.Drawing.Point(53, 94)
        Me.TB_woodcost.Name = "TB_woodcost"
        Me.TB_woodcost.Size = New System.Drawing.Size(77, 20)
        Me.TB_woodcost.TabIndex = 16
        '
        'TB_Oilcost
        '
        Me.TB_Oilcost.Location = New System.Drawing.Point(53, 22)
        Me.TB_Oilcost.Name = "TB_Oilcost"
        Me.TB_Oilcost.Size = New System.Drawing.Size(77, 20)
        Me.TB_Oilcost.TabIndex = 13
        '
        'TB_Gascost
        '
        Me.TB_Gascost.Location = New System.Drawing.Point(53, 70)
        Me.TB_Gascost.Name = "TB_Gascost"
        Me.TB_Gascost.Size = New System.Drawing.Size(77, 20)
        Me.TB_Gascost.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Oil"
        '
        'TB_Coalcost
        '
        Me.TB_Coalcost.Location = New System.Drawing.Point(53, 46)
        Me.TB_Coalcost.Name = "TB_Coalcost"
        Me.TB_Coalcost.Size = New System.Drawing.Size(77, 20)
        Me.TB_Coalcost.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Coal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Gas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Wood"
        '
        'HeatConsumtion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 642)
        Me.Controls.Add(Me.GB_fuelcost)
        Me.Controls.Add(Me.GB_fuelprices)
        Me.Controls.Add(Me.GB_totalamounts)
        Me.Controls.Add(Me.B_Diagram)
        Me.Controls.Add(Me.B_ReadOtemp)
        Me.Controls.Add(Me.TB_Setpoint)
        Me.Controls.Add(Me.B_SetTemp)
        Me.Controls.Add(Me.b_Calculation)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.DG_consumption)
        Me.Name = "HeatConsumtion"
        Me.Text = "Heat Consumption"
        CType(Me.DG_consumption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_totalamounts.ResumeLayout(False)
        Me.GB_totalamounts.PerformLayout()
        Me.GB_fuelprices.ResumeLayout(False)
        Me.GB_fuelprices.PerformLayout()
        Me.GB_fuelcost.ResumeLayout(False)
        Me.GB_fuelcost.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_consumption As System.Windows.Forms.DataGridView
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents b_Calculation As System.Windows.Forms.Button
    Friend WithEvents B_SetTemp As System.Windows.Forms.Button
    Friend WithEvents TB_Setpoint As System.Windows.Forms.TextBox
    Friend WithEvents B_ReadOtemp As System.Windows.Forms.Button
    Friend WithEvents B_Diagram As System.Windows.Forms.Button
    Friend WithEvents GB_totalamounts As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_wood As TextBox
    Friend WithEvents TB_Gas As TextBox
    Friend WithEvents TB_coal As TextBox
    Friend WithEvents TB_oil As TextBox
    Friend WithEvents GB_fuelprices As System.Windows.Forms.GroupBox
    Friend WithEvents B_Calculatecost As System.Windows.Forms.Button
    Friend WithEvents B_Saveprices As System.Windows.Forms.Button
    Friend WithEvents TB_WoodPrice As System.Windows.Forms.TextBox
    Friend WithEvents TB_Gasprice As System.Windows.Forms.TextBox
    Friend WithEvents TB_Coalprice As System.Windows.Forms.TextBox
    Friend WithEvents TB_Oilprice As System.Windows.Forms.TextBox
    Friend WithEvents L_Wood As System.Windows.Forms.Label
    Friend WithEvents L_Gas As System.Windows.Forms.Label
    Friend WithEvents L_Coal As System.Windows.Forms.Label
    Friend WithEvents L_Oil As System.Windows.Forms.Label
    Friend WithEvents GB_fuelcost As System.Windows.Forms.GroupBox
    Friend WithEvents TB_woodcost As System.Windows.Forms.TextBox
    Friend WithEvents TB_Oilcost As System.Windows.Forms.TextBox
    Friend WithEvents TB_Gascost As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_Coalcost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents B_loadprices As System.Windows.Forms.Button
End Class
