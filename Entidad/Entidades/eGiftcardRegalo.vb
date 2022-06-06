Public Class eGiftcardRegalo
    Private _idGiftcardRegalo As Int16
    Public Property idGiftcardRegalo() As Int16
        Get
            Return _idGiftcardRegalo
        End Get
        Set(ByVal value As Int16)
            _idGiftcardRegalo = value
        End Set
    End Property

    Private _cantidadPolizas As Int16
    Public Property cantidadPolizas() As Int16
        Get
            Return _cantidadPolizas
        End Get
        Set(ByVal value As Int16)
            _cantidadPolizas = value
        End Set
    End Property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
End Class
