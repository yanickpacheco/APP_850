Public Class ePoliza
    Private _idCliente As Integer
    Private _nombre As String
    Private _paterno As String
    Private _materno As String
    Private _rut As Integer
    Private _dv As String
    Private _fecha_Nacimiento As String
    Private _fono_Venta As String
    Private _email As String
    Private _sistema_Salud As String
    Private _peso As String
    Private _estatura As String
    Private _plan As String
    Private _calle As String
    Private _numero As String
    Private _referencia As String
    Private _comuna As String
    Private _ciudad As String
    Private _firma_Mandato As String
    Private _primaUf As String
    Private _primaPesos As String
    Private _tipoContrato As String
    Private _DPS As String
    Private _medio_pago As String
    Private _banco As String
    Private _tipo_tarjeta As String
    Private _nro_Cuenta As String

    Public Sub New(idCliente As Integer, nombre As String, paterno As String, materno As String, rut As Integer, dv As String, fecha_Nacimiento As String, fono_Venta As String, email As String, sistema_salud As String, peso As String, estatura As String, plan As String, calle As String, numero As String, referencia As String, comuna As String, ciudad As String, firma_mandato As String, primaUf As String, primaPesos As String, tipoContrato As String, DPS As String, medio_pago As String, banco As String, tipo_tarjeta As String, nro_cuenta As String)
        _idCliente = idCliente
        _nombre = nombre
        _paterno = paterno
        _materno = materno
        _rut = rut
        _dv = dv
        _fecha_Nacimiento = fecha_Nacimiento
        _fono_Venta = fono_Venta
        _email = email
        _sistema_Salud = sistema_salud
        _peso = peso
        _estatura = estatura
        _plan = plan
        _calle = calle
        _numero = numero
        _referencia = referencia
        _comuna = comuna
        _ciudad = ciudad
        _firma_Mandato = firma_mandato
        _primaUf = primaUf
        _primaPesos = primaPesos
        _tipoContrato = tipoContrato
        _DPS = DPS
    End Sub

    Public Sub New()
        idCliente = 0
        nombre = ""
        paterno = ""
        materno = ""
        rut = 0
        dv = ""
        fecha_Nacimiento = ""
        fono_Venta = ""
        email = ""
        sistema_Salud = ""
        peso = ""
        estatura = ""
        plan = ""
        calle = ""
        numero = ""
        referencia = ""
        comuna = ""
        ciudad = ""
        firma_Mandato = ""
        primaUf = ""
        primaPesos = ""
        tipoContrato = ""
        DPS = ""

    End Sub

    Public Property DPS() As String
        Get
            Return _DPS
        End Get
        Set(ByVal value As String)
            _DPS = value
        End Set
    End Property
    Public Property nro_Cuenta() As String
        Get
            Return _nro_Cuenta
        End Get
        Set(ByVal value As String)
            _nro_Cuenta = value
        End Set
    End Property
    Public Property tipo_tarjeta() As String
        Get
            Return _tipo_tarjeta
        End Get
        Set(ByVal value As String)
            _tipo_tarjeta = value
        End Set
    End Property
    Public Property banco() As String
        Get
            Return _banco
        End Get
        Set(ByVal value As String)
            _banco = value
        End Set
    End Property

    Public Property medio_pago() As String
        Get
            Return _medio_pago
        End Get
        Set(ByVal value As String)
            _medio_pago = value
        End Set
    End Property

    Public Property idCliente() As String
        Get
            Return _idCliente
        End Get
        Set(ByVal value As String)
            _idCliente = value
        End Set
    End Property


    Public Property paterno() As String
        Get
            Return _paterno
        End Get
        Set(ByVal value As String)
            _paterno = value
        End Set
    End Property

    Public Property materno() As String
        Get
            Return _materno
        End Get
        Set(ByVal value As String)
            _materno = value
        End Set
    End Property

    Public Property rut() As Integer
        Get
            Return _rut
        End Get
        Set(ByVal value As Integer)
            _rut = value
        End Set
    End Property

    Public Property dv() As String
        Get
            Return _dv
        End Get
        Set(ByVal value As String)
            _dv = value
        End Set
    End Property

    Public Property fecha_Nacimiento() As String
        Get
            Return _fecha_Nacimiento
        End Get
        Set(ByVal value As String)
            _fecha_Nacimiento = value
        End Set
    End Property

    Public Property fono_Venta() As String
        Get
            Return _fono_Venta
        End Get
        Set(ByVal value As String)
            _fono_Venta = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property sistema_Salud() As String
        Get
            Return _sistema_Salud
        End Get
        Set(ByVal value As String)
            _sistema_Salud = value
        End Set
    End Property

    Public Property peso() As String
        Get
            Return _peso
        End Get
        Set(ByVal value As String)
            _peso = value
        End Set
    End Property

    Public Property estatura() As String
        Get
            Return _estatura
        End Get
        Set(ByVal value As String)
            _estatura = value
        End Set
    End Property

    Public Property plan() As String
        Get
            Return _plan
        End Get
        Set(ByVal value As String)
            _plan = value
        End Set
    End Property

    Public Property calle() As String
        Get
            Return _calle
        End Get
        Set(ByVal value As String)
            _calle = value
        End Set
    End Property

    Public Property numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Property referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
        End Set
    End Property

    Public Property comuna() As String
        Get
            Return _comuna
        End Get
        Set(ByVal value As String)
            _comuna = value
        End Set
    End Property

    Public Property ciudad() As String
        Get
            Return _ciudad
        End Get
        Set(ByVal value As String)
            _ciudad = value
        End Set
    End Property

    Public Property firma_Mandato() As String
        Get
            Return _firma_Mandato
        End Get
        Set(ByVal value As String)
            _firma_Mandato = value
        End Set
    End Property

    Public Property primaUf() As String
        Get
            Return _primaUf
        End Get
        Set(ByVal value As String)
            _primaUf = value
        End Set
    End Property

    Public Property primaPesos() As String
        Get
            Return _primaPesos
        End Get
        Set(ByVal value As String)
            _primaPesos = value
        End Set
    End Property

    Public Property tipoContrato() As String
        Get
            Return _tipoContrato
        End Get
        Set(ByVal value As String)
            _tipoContrato = value
        End Set
    End Property


    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property



End Class
