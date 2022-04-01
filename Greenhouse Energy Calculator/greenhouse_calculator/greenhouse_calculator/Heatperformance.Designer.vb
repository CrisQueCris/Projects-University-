<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Heatperformance
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Heatperformance))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_outsidetemp = New System.Windows.Forms.TextBox()
        Me.TB_savetytemp = New System.Windows.Forms.TextBox()
        Me.TB_insidetemp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.L_shp_s = New System.Windows.Forms.Label()
        Me.L_shp_wos = New System.Windows.Forms.Label()
        Me.L_hp_s = New System.Windows.Forms.Label()
        Me.L_hp_wos = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.L_hl_sw_s = New System.Windows.Forms.Label()
        Me.L_hl_sw_wos = New System.Windows.Forms.Label()
        Me.L_hl_ga_s = New System.Windows.Forms.Label()
        Me.L_hl_ga_wos = New System.Windows.Forms.Label()
        Me.L_hl_rz_s = New System.Windows.Forms.Label()
        Me.L_hi_rz_wos = New System.Windows.Forms.Label()
        Me.B_CalculateHP = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TB_outsidetemp)
        Me.GroupBox1.Controls.Add(Me.TB_savetytemp)
        Me.GroupBox1.Controls.Add(Me.TB_insidetemp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'TB_outsidetemp
        '
        resources.ApplyResources(Me.TB_outsidetemp, "TB_outsidetemp")
        Me.TB_outsidetemp.Name = "TB_outsidetemp"
        '
        'TB_savetytemp
        '
        resources.ApplyResources(Me.TB_savetytemp, "TB_savetytemp")
        Me.TB_savetytemp.Name = "TB_savetytemp"
        '
        'TB_insidetemp
        '
        resources.ApplyResources(Me.TB_insidetemp, "TB_insidetemp")
        Me.TB_insidetemp.Name = "TB_insidetemp"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.B_CalculateHP)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'L_shp_s
        '
        resources.ApplyResources(Me.L_shp_s, "L_shp_s")
        Me.L_shp_s.Name = "L_shp_s"
        '
        'L_shp_wos
        '
        resources.ApplyResources(Me.L_shp_wos, "L_shp_wos")
        Me.L_shp_wos.Name = "L_shp_wos"
        '
        'L_hp_s
        '
        resources.ApplyResources(Me.L_hp_s, "L_hp_s")
        Me.L_hp_s.Name = "L_hp_s"
        '
        'L_hp_wos
        '
        resources.ApplyResources(Me.L_hp_wos, "L_hp_wos")
        Me.L_hp_wos.Name = "L_hp_wos"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'L_hl_sw_s
        '
        resources.ApplyResources(Me.L_hl_sw_s, "L_hl_sw_s")
        Me.L_hl_sw_s.Name = "L_hl_sw_s"
        '
        'L_hl_sw_wos
        '
        resources.ApplyResources(Me.L_hl_sw_wos, "L_hl_sw_wos")
        Me.L_hl_sw_wos.Name = "L_hl_sw_wos"
        '
        'L_hl_ga_s
        '
        resources.ApplyResources(Me.L_hl_ga_s, "L_hl_ga_s")
        Me.L_hl_ga_s.Name = "L_hl_ga_s"
        '
        'L_hl_ga_wos
        '
        resources.ApplyResources(Me.L_hl_ga_wos, "L_hl_ga_wos")
        Me.L_hl_ga_wos.Name = "L_hl_ga_wos"
        '
        'L_hl_rz_s
        '
        resources.ApplyResources(Me.L_hl_rz_s, "L_hl_rz_s")
        Me.L_hl_rz_s.Name = "L_hl_rz_s"
        '
        'L_hi_rz_wos
        '
        resources.ApplyResources(Me.L_hi_rz_wos, "L_hi_rz_wos")
        Me.L_hi_rz_wos.Name = "L_hi_rz_wos"
        '
        'B_CalculateHP
        '
        resources.ApplyResources(Me.B_CalculateHP, "B_CalculateHP")
        Me.B_CalculateHP.Name = "B_CalculateHP"
        Me.B_CalculateHP.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.L_hp_wos)
        Me.GroupBox3.Controls.Add(Me.L_hi_rz_wos)
        Me.GroupBox3.Controls.Add(Me.L_shp_wos)
        Me.GroupBox3.Controls.Add(Me.L_hl_ga_wos)
        Me.GroupBox3.Controls.Add(Me.L_hl_sw_wos)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.L_hl_rz_s)
        Me.GroupBox4.Controls.Add(Me.L_hl_ga_s)
        Me.GroupBox4.Controls.Add(Me.L_shp_s)
        Me.GroupBox4.Controls.Add(Me.L_hl_sw_s)
        Me.GroupBox4.Controls.Add(Me.L_hp_s)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'Heatperformance
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Heatperformance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents L_hl_sw_s As System.Windows.Forms.Label
    Friend WithEvents L_hl_sw_wos As System.Windows.Forms.Label
    Friend WithEvents L_hl_ga_s As System.Windows.Forms.Label
    Friend WithEvents L_hl_ga_wos As System.Windows.Forms.Label
    Friend WithEvents L_hl_rz_s As System.Windows.Forms.Label
    Friend WithEvents L_hi_rz_wos As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_outsidetemp As System.Windows.Forms.TextBox
    Friend WithEvents TB_savetytemp As System.Windows.Forms.TextBox
    Friend WithEvents TB_insidetemp As System.Windows.Forms.TextBox
    Friend WithEvents L_shp_s As System.Windows.Forms.Label
    Friend WithEvents L_shp_wos As System.Windows.Forms.Label
    Friend WithEvents L_hp_s As System.Windows.Forms.Label
    Friend WithEvents L_hp_wos As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents B_CalculateHP As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
