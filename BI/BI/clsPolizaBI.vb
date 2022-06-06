Imports Dato
Imports Entidad

Public Class clsPolizabBI
    Public Function BuscarCotizacion(ByVal _edad As Integer, ByVal _nombrePlan As String, ByVal _tipoContrato As Integer, ByVal _crm As String) As DataTable
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.BuscarCotizacion(_edad, _nombrePlan, _tipoContrato, _crm)
    End Function

    Public Function IngresarCotizacion(ByVal id As Integer, ByVal edad As Integer, ByVal nombrePlan As String, ByVal tipoContrato As Integer, ByVal fechaNacimiento As String) As Boolean
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.IngresarCotizacion(id, edad, nombrePlan, tipoContrato, fechaNacimiento)
    End Function

    Public Function cargaCotizacionesCliente(ByVal id As Integer) As DataTable
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.cargaCotizacionesCLiente(id)
    End Function

    Public Function guardaPolizas(ByVal _Gestion As eGestion, ByVal _cliente As eCliente) As Integer
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.IngresaPoliza(_Gestion, _cliente)

    End Function

    Public Function actualizaDatosPoliza(ByVal _Gestion As eGestion, ByVal _cliente As eCliente) As Boolean
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.ActualizaPoliza(_Gestion, _cliente)
    End Function

    Public Function eliminaPoliza(ByVal _idPoliza As Integer) As Boolean
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.eliminaPoliza(_idPoliza)
    End Function


    Public Function actualizaMedioPago(ByVal _poliza As ePoliza, ByVal idPoliza As Integer) As Boolean
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.actualizaMedioPago(_poliza, idPoliza)

    End Function

    Public Function ListaPolizas(ByVal id As Integer) As DataTable
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.ListaPolizas(id)
    End Function

    Public Function ValidarPoliza(ByVal Rut As Integer, ByVal id As Integer) As DataTable
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.validarPoliza(Rut, id)
    End Function

    Public Function ListaPolizasPago(ByVal id As Integer) As DataTable
        Dim biPoliza As New clsPolizaDA
        Return biPoliza.ListaPolizasPago(id)
    End Function

End Class
