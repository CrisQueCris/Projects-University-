Public Class GHgeometry
    Private V_GH_gablenumber, V_GH_gablewidth, V_GH_width, V_GH_length, V_GH_groundarea
    Private V_GH_sidewallheight, V_GH_roofinclination, V_GH_gablearea, V_GH_sidewallarea
    Private V_GH_roofsidelength, V_GH_roofarea, V_GH_coverarea, V_GH_Cover2ground


    'input properties



    Property GH_roofinclination
        Get
            Return V_GH_roofinclination
        End Get
        Set(value)
            V_GH_roofinclination = value
        End Set
    End Property


    Property GH_sidewallheight
        Get
            Return V_GH_sidewallheight
        End Get
        Set(value)
            V_GH_sidewallheight = value
        End Set
    End Property

    Property GH_gablenumber
        Get
            Return V_GH_gablenumber
        End Get
        Set(value)
            V_GH_gablenumber = value
        End Set
    End Property
    Property GH_gablewidth
        Get
            Return V_GH_gablewidth
        End Get
        Set(value)
            V_GH_gablewidth = value
        End Set
    End Property

    Property GH_length
        Get
            Return V_GH_length
        End Get
        Set(value)
            V_GH_length = value
        End Set
    End Property
    ' output-properties
    ReadOnly Property GH_width
        Get
            areacalculation()
            Return V_GH_width
        End Get
    End Property
    ReadOnly Property GH_groundarea
        Get
            areacalculation()
            Return V_GH_groundarea
        End Get
    End Property
    ReadOnly Property GH_gablearea
        Get
            areacalculation()
            Return V_GH_gablearea
        End Get
    End Property
    ReadOnly Property GH_sidewallarea
        Get
            areacalculation()
            Return V_GH_sidewallarea
        End Get
    End Property
    ReadOnly Property GH_roofsidelength
        Get
            areacalculation()
            Return V_GH_roofsidelength
        End Get
    End Property
    ReadOnly Property GH_roofarea
        Get
            areacalculation()
            Return V_GH_roofarea
        End Get
    End Property
    ReadOnly Property GH_coverarea
        Get
            areacalculation()
            Return V_GH_coverarea
        End Get
    End Property
    ReadOnly Property GH_cover2ground
        Get
            areacalculation()
            Return V_GH_Cover2ground
        End Get
    End Property



    Public Sub areacalculation()
        V_GH_width = V_GH_gablenumber * V_GH_gablewidth
        V_GH_groundarea = V_GH_width * V_GH_length
        V_GH_gablearea = 2 * V_GH_gablenumber * V_GH_gablewidth * V_GH_sidewallheight + 2 * V_GH_gablenumber * V_GH_gablewidth ^ 2 / 4 * Math.Tan(V_GH_roofinclination * Math.PI / 180)
        V_GH_sidewallarea = 2 * V_GH_length * V_GH_sidewallheight
        V_GH_roofsidelength = V_GH_gablewidth / (2 * Math.Cos(V_GH_roofinclination * Math.PI / 180))
        V_GH_roofarea = 2 * V_GH_roofsidelength * V_GH_length * V_GH_gablenumber
        V_GH_coverarea = V_GH_gablearea + V_GH_sidewallarea + V_GH_roofarea
        V_GH_Cover2ground = V_GH_coverarea / V_GH_groundarea

    End Sub






End Class
