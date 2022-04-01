<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadInputsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveInputsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoverMeterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeatConsumptionDiagramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeatConsumtionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeatPerformanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Load_Inputs = New System.Windows.Forms.Button()
        Me.B_Save_Inputs = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.L_C2G = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.B_Calculate = New System.Windows.Forms.Button()
        Me.L_GHcoverarea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_GHroofarea = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.L_GHgablearea = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.L_GHsidewallarea = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.L_GHgroundarea = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.L_GHwidth = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_gable_screen = New System.Windows.Forms.ComboBox()
        Me.CB_gable_material = New System.Windows.Forms.ComboBox()
        Me.TB_GHroofinclination = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_GHgablewidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_GHgablenumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_sidewall_screen = New System.Windows.Forms.ComboBox()
        Me.CB_sidewall_material = New System.Windows.Forms.ComboBox()
        Me.TB_GHsidewallheight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_GHlength = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CB_roof_screen = New System.Windows.Forms.ComboBox()
        Me.CB_Roof_material = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.CalculationToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadInputsToolStripMenuItem, Me.SaveInputsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'LoadInputsToolStripMenuItem
        '
        Me.LoadInputsToolStripMenuItem.Name = "LoadInputsToolStripMenuItem"
        resources.ApplyResources(Me.LoadInputsToolStripMenuItem, "LoadInputsToolStripMenuItem")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'SaveInputsToolStripMenuItem
        '
        Me.SaveInputsToolStripMenuItem.Name = "SaveInputsToolStripMenuItem"
        resources.ApplyResources(Me.SaveInputsToolStripMenuItem, "SaveInputsToolStripMenuItem")
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoverMeterialToolStripMenuItem, Me.HeatConsumptionDiagramToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        resources.ApplyResources(Me.ViewToolStripMenuItem, "ViewToolStripMenuItem")
        '
        'CoverMeterialToolStripMenuItem
        '
        Me.CoverMeterialToolStripMenuItem.Name = "CoverMeterialToolStripMenuItem"
        resources.ApplyResources(Me.CoverMeterialToolStripMenuItem, "CoverMeterialToolStripMenuItem")
        '
        'HeatConsumptionDiagramToolStripMenuItem
        '
        Me.HeatConsumptionDiagramToolStripMenuItem.Name = "HeatConsumptionDiagramToolStripMenuItem"
        resources.ApplyResources(Me.HeatConsumptionDiagramToolStripMenuItem, "HeatConsumptionDiagramToolStripMenuItem")
        '
        'CalculationToolStripMenuItem
        '
        Me.CalculationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeatPerformanceToolStripMenuItem, Me.HeatConsumtionToolStripMenuItem})
        Me.CalculationToolStripMenuItem.Name = "CalculationToolStripMenuItem"
        resources.ApplyResources(Me.CalculationToolStripMenuItem, "CalculationToolStripMenuItem")
        '
        'HeatConsumtionToolStripMenuItem
        '
        Me.HeatConsumtionToolStripMenuItem.Name = "HeatConsumtionToolStripMenuItem"
        resources.ApplyResources(Me.HeatConsumtionToolStripMenuItem, "HeatConsumtionToolStripMenuItem")
        '
        'HeatPerformanceToolStripMenuItem
        '
        Me.HeatPerformanceToolStripMenuItem.Name = "HeatPerformanceToolStripMenuItem"
        resources.ApplyResources(Me.HeatPerformanceToolStripMenuItem, "HeatPerformanceToolStripMenuItem")
        '
        'B_Load_Inputs
        '
        resources.ApplyResources(Me.B_Load_Inputs, "B_Load_Inputs")
        Me.B_Load_Inputs.Name = "B_Load_Inputs"
        Me.B_Load_Inputs.UseVisualStyleBackColor = True
        '
        'B_Save_Inputs
        '
        resources.ApplyResources(Me.B_Save_Inputs, "B_Save_Inputs")
        Me.B_Save_Inputs.Name = "B_Save_Inputs"
        Me.B_Save_Inputs.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.L_C2G)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.B_Calculate)
        Me.GroupBox4.Controls.Add(Me.L_GHcoverarea)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.L_GHroofarea)
        Me.GroupBox4.Controls.Add(Me.label22)
        Me.GroupBox4.Controls.Add(Me.L_GHgablearea)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.L_GHsidewallarea)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.L_GHgroundarea)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.L_GHwidth)
        Me.GroupBox4.Controls.Add(Me.Label6)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'L_C2G
        '
        Me.L_C2G.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.L_C2G, "L_C2G")
        Me.L_C2G.Name = "L_C2G"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'B_Calculate
        '
        resources.ApplyResources(Me.B_Calculate, "B_Calculate")
        Me.B_Calculate.Name = "B_Calculate"
        Me.B_Calculate.UseVisualStyleBackColor = True
        '
        'L_GHcoverarea
        '
        Me.L_GHcoverarea.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.L_GHcoverarea, "L_GHcoverarea")
        Me.L_GHcoverarea.Name = "L_GHcoverarea"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'L_GHroofarea
        '
        Me.L_GHroofarea.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.L_GHroofarea, "L_GHroofarea")
        Me.L_GHroofarea.Name = "L_GHroofarea"
        '
        'label22
        '
        resources.ApplyResources(Me.label22, "label22")
        Me.label22.Name = "label22"
        '
        'L_GHgablearea
        '
        Me.L_GHgablearea.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.L_GHgablearea, "L_GHgablearea")
        Me.L_GHgablearea.Name = "L_GHgablearea"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'L_GHsidewallarea
        '
        Me.L_GHsidewallarea.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.L_GHsidewallarea, "L_GHsidewallarea")
        Me.L_GHsidewallarea.Name = "L_GHsidewallarea"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'L_GHgroundarea
        '
        Me.L_GHgroundarea.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.L_GHgroundarea, "L_GHgroundarea")
        Me.L_GHgroundarea.Name = "L_GHgroundarea"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'L_GHwidth
        '
        Me.L_GHwidth.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.L_GHwidth, "L_GHwidth")
        Me.L_GHwidth.Name = "L_GHwidth"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.CB_gable_screen)
        Me.GroupBox3.Controls.Add(Me.CB_gable_material)
        Me.GroupBox3.Controls.Add(Me.TB_GHroofinclination)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TB_GHgablewidth)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TB_GHgablenumber)
        Me.GroupBox3.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'CB_gable_screen
        '
        Me.CB_gable_screen.FormattingEnabled = True
        resources.ApplyResources(Me.CB_gable_screen, "CB_gable_screen")
        Me.CB_gable_screen.Name = "CB_gable_screen"
        '
        'CB_gable_material
        '
        Me.CB_gable_material.FormattingEnabled = True
        resources.ApplyResources(Me.CB_gable_material, "CB_gable_material")
        Me.CB_gable_material.Name = "CB_gable_material"
        '
        'TB_GHroofinclination
        '
        resources.ApplyResources(Me.TB_GHroofinclination, "TB_GHroofinclination")
        Me.TB_GHroofinclination.Name = "TB_GHroofinclination"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'TB_GHgablewidth
        '
        resources.ApplyResources(Me.TB_GHgablewidth, "TB_GHgablewidth")
        Me.TB_GHgablewidth.Name = "TB_GHgablewidth"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'TB_GHgablenumber
        '
        resources.ApplyResources(Me.TB_GHgablenumber, "TB_GHgablenumber")
        Me.TB_GHgablenumber.Name = "TB_GHgablenumber"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.CB_sidewall_screen)
        Me.GroupBox2.Controls.Add(Me.CB_sidewall_material)
        Me.GroupBox2.Controls.Add(Me.TB_GHsidewallheight)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TB_GHlength)
        Me.GroupBox2.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'CB_sidewall_screen
        '
        Me.CB_sidewall_screen.FormattingEnabled = True
        resources.ApplyResources(Me.CB_sidewall_screen, "CB_sidewall_screen")
        Me.CB_sidewall_screen.Name = "CB_sidewall_screen"
        '
        'CB_sidewall_material
        '
        Me.CB_sidewall_material.FormattingEnabled = True
        resources.ApplyResources(Me.CB_sidewall_material, "CB_sidewall_material")
        Me.CB_sidewall_material.Name = "CB_sidewall_material"
        '
        'TB_GHsidewallheight
        '
        resources.ApplyResources(Me.TB_GHsidewallheight, "TB_GHsidewallheight")
        Me.TB_GHsidewallheight.Name = "TB_GHsidewallheight"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TB_GHlength
        '
        resources.ApplyResources(Me.TB_GHlength, "TB_GHlength")
        Me.TB_GHlength.Name = "TB_GHlength"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CB_roof_screen)
        Me.GroupBox1.Controls.Add(Me.CB_Roof_material)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'CB_roof_screen
        '
        Me.CB_roof_screen.FormattingEnabled = True
        resources.ApplyResources(Me.CB_roof_screen, "CB_roof_screen")
        Me.CB_roof_screen.Name = "CB_roof_screen"
        '
        'CB_Roof_material
        '
        Me.CB_Roof_material.FormattingEnabled = True
        resources.ApplyResources(Me.CB_Roof_material, "CB_Roof_material")
        Me.CB_Roof_material.Name = "CB_Roof_material"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'A_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.B_Load_Inputs)
        Me.Controls.Add(Me.B_Save_Inputs)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "A_Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoverMeterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeatPerformanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeatConsumtionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadInputsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveInputsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B_Load_Inputs As Button
    Friend WithEvents B_Save_Inputs As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents L_C2G As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents B_Calculate As Button
    Friend WithEvents L_GHcoverarea As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L_GHroofarea As Label
    Friend WithEvents label22 As Label
    Friend WithEvents L_GHgablearea As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents L_GHsidewallarea As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents L_GHgroundarea As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents L_GHwidth As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CB_gable_screen As ComboBox
    Friend WithEvents CB_gable_material As ComboBox
    Friend WithEvents TB_GHroofinclination As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_GHgablewidth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_GHgablenumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CB_sidewall_screen As ComboBox
    Friend WithEvents CB_sidewall_material As ComboBox
    Friend WithEvents TB_GHsidewallheight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_GHlength As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CB_roof_screen As ComboBox
    Friend WithEvents CB_Roof_material As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HeatConsumptionDiagramToolStripMenuItem As ToolStripMenuItem
End Class
