Public Class eAdicional
    Private _A_ID As Integer
    Private _C_ID As Integer
    Private _P_ID As Integer
    Private _A_NRO As Integer
    Private _A_Rut As String
    Private _A_Dv As String
    Private _A_Nombre As String
    Private _A_Paterno As String
    Private _A_Materno As String
    Private _A_TipoBeneficiario As Int16
    Private _A_FechaNacimiento As String
    Private _A_Sexo As String
    Private _A_Isapre As String
    Private _A_Peso As String
    Private _A_Estatura As String
    Private _A_DPS As String


    Public Sub New(a_ID As Integer, c_ID As Integer, P_ID As Integer, a_NRO As Integer, a_Rut As String, a_Dv As String, a_Nombre As String, a_Paterno As String, a_Materno As String, a_TipoBeneficiario As Int16, a_FechaNacimiento As String, a_Sexo As String, a_Isapre As String, a_Peso As String, a_Estatura As String, a_Dps As String)

        _A_ID = a_ID
        _C_ID = c_ID
        _P_ID = P_ID
        _A_NRO = a_NRO
        _A_Rut = a_Rut
        _A_Dv = a_Dv
        _A_Nombre = a_Nombre
        _A_Paterno = a_Paterno
        _A_Materno = a_Materno
        _A_TipoBeneficiario = a_TipoBeneficiario
        _A_FechaNacimiento = a_FechaNacimiento
        _A_Sexo = a_Sexo
        _A_Isapre = a_Isapre
        _A_Peso = a_Peso
        _A_Estatura = a_Estatura
        _A_DPS = a_Dps
    End Sub

    Public Sub New()
        _A_ID = 0
        _C_ID = 0
        _P_ID = 0
        _A_NRO = 0
        _A_Rut = ""
        _A_Dv = ""
        _A_Nombre = ""
        _A_Paterno = ""
        _A_Materno = ""
        _A_TipoBeneficiario = 0
        _A_FechaNacimiento = ""
        _A_Sexo = ""
        _A_Isapre = ""
        _A_Peso = ""
        _A_Estatura = ""
        _A_DPS = ""
    End Sub

    Public Property A_ID As Integer
        Get
            Return _A_ID
        End Get
        Set(value As Integer)
            _A_ID = value
        End Set
    End Property

    Public Property C_ID As Integer
        Get
            Return _C_ID
        End Get
        Set(value As Integer)
            _C_ID = value
        End Set
    End Property

    Public Property P_ID As Integer
        Get
            Return _P_ID
        End Get
        Set(value As Integer)
            _P_ID = value
        End Set
    End Property

    Public Property A_NRO As Integer
        Get
            Return _A_NRO
        End Get
        Set(value As Integer)
            _A_NRO = value
        End Set
    End Property

    Public Property A_Rut As String
        Get
            Return _A_Rut
        End Get
        Set(value As String)
            _A_Rut = value
        End Set
    End Property

    Public Property A_Dv As String
        Get
            Return _A_Dv
        End Get
        Set(value As String)
            _A_Dv = value
        End Set
    End Property

    Public Property A_Nombre As String
        Get
            Return _A_Nombre
        End Get
        Set(value As String)
            _A_Nombre = value
        End Set
    End Property

    Public Property A_Paterno As String
        Get
            Return _A_Paterno
        End Get
        Set(value As String)
            _A_Paterno = value
        End Set
    End Property

    Public Property A_Materno As String
        Get
            Return _A_Materno
        End Get
        Set(value As String)
            _A_Materno = value
        End Set
    End Property

    Public Property A_TipoBeneficiario As Short
        Get
            Return _A_TipoBeneficiario
        End Get
        Set(value As Short)
            _A_TipoBeneficiario = value
        End Set
    End Property

    Public Property A_FechaNacimiento As String
        Get
            Return _A_FechaNacimiento
        End Get
        Set(value As String)
            _A_FechaNacimiento = value
        End Set
    End Property

    Public Property A_Sexo As String
        Get
            Return _A_Sexo
        End Get
        Set(value As String)
            _A_Sexo = value
        End Set
    End Property

    Public Property A_Isapre As String
        Get
            Return _A_Isapre
        End Get
        Set(value As String)
            _A_Isapre = value
        End Set
    End Property

    Public Property A_Peso As String
        Get
            Return _A_Peso
        End Get
        Set(value As String)
            _A_Peso = value
        End Set
    End Property

    Public Property A_Estatura As String
        Get
            Return _A_Estatura
        End Get
        Set(value As String)
            _A_Estatura = value
        End Set
    End Property

    Public Property A_DPS As String
        Get
            Return _A_DPS
        End Get
        Set(value As String)
            _A_DPS = value
        End Set
    End Property

End Class
