Public Class GHHeat
    Inherits GHgeometry
    Private m_insidetemperature, m_outsidetemperature, m_savetytemperature As Double
    Private m_heatperformance, m_hp_roof, m_hp_gable, m_hp_sidewall, m_savetyperformance As Double
    Private m_u_roof, m_u_gable, m_u_sidewall As Double

    Property insidetemperature As Double
        Get
            Return m_insidetemperature
        End Get
        Set(value As Double)
            m_insidetemperature = value
        End Set
    End Property

    Property outsidetemperature As Double
        Get
            Return m_outsidetemperature
        End Get
        Set(value As Double)
            m_outsidetemperature = value
        End Set
    End Property
    Property savetytemperature As Double
        Get
            Return m_savetytemperature
        End Get
        Set(value As Double)
            m_savetytemperature = value
        End Set
    End Property
    Property u_roof As Double
        Get
            Return m_u_roof
        End Get
        Set(value As Double)
            m_u_roof = value
        End Set
    End Property
    Property u_gable As Double
        Get
            Return m_u_gable
        End Get
        Set(value As Double)
            m_u_gable = value
        End Set
    End Property
    Property u_sidewall As Double
        Get
            Return m_u_sidewall
        End Get
        Set(value As Double)
            m_u_sidewall = value
        End Set
    End Property
    ReadOnly Property heatperformance
        Get
            heatcalc()
            Return m_heatperformance
        End Get
    End Property
    ReadOnly Property savetyperformance
        Get
            heatcalc()
            Return m_savetyperformance
        End Get
    End Property
    ReadOnly Property hp_roof
        Get
            heatcalc()
            Return m_hp_roof
        End Get
    End Property
    ReadOnly Property hp_gable
        Get
            heatcalc()
            Return m_hp_gable
        End Get
    End Property
    ReadOnly Property hp_sidewall
        Get
            heatcalc()
            Return m_hp_sidewall
        End Get
    End Property
    Sub heatcalc()

        'first calculation with safety temperature
        m_hp_roof = m_u_roof * (m_savetytemperature - m_outsidetemperature) * GH_roofarea
        m_hp_gable = m_u_gable * (m_savetytemperature - m_outsidetemperature) * GH_gablearea
        m_hp_sidewall = m_u_sidewall * (m_savetytemperature - m_outsidetemperature) * GH_sidewallarea
        m_savetyperformance = m_hp_roof + m_hp_gable + m_hp_sidewall


        'second calculation with inside temperature
        m_hp_roof = m_u_roof * (m_insidetemperature - m_outsidetemperature) * GH_roofarea
        m_hp_gable = m_u_gable * (m_insidetemperature - m_outsidetemperature) * GH_gablearea
        m_hp_sidewall = m_u_sidewall * (m_insidetemperature - m_outsidetemperature) * GH_sidewallarea
        m_heatperformance = m_hp_roof + m_hp_gable + m_hp_sidewall



    End Sub
End Class
