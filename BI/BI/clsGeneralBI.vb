Imports System.Collections.Generic
Imports Dato
Imports Entidad

Public Class clsGeneralBI
    Dim dapGeneral As New clsGeneralDA

    'METODO PARA TRAER LA HORA DEL SERVIDOR
    Public Function BuscarFecha() As String
        Dim dapFecha As New clsGeneralDA
        Return dapFecha.FechaServidor
    End Function

    'METODO PARA LOGUEAR USUARIO AL INICIO
    Public Sub Loguear_Usuario(ByRef Usuario As String, ByRef estado As Short)
        Dim dapLoguear As New clsGeneralDA
        dapLoguear.Logear_Usuario(Usuario, estado)
    End Sub


    'METODO PARA INSERTAR GRABACION
    Public Sub InsertarGrabacion(ByVal _grabacion As eLlamada, ByVal tipo As UShort)
        dapGeneral.Insertar_Grabacion(_grabacion, tipo)
    End Sub

    'METODO PARA LLENAR FERIADOS
    Public Sub llenarferiados()
        'dapGeneral.llenarDiasFeriados()
    End Sub

    Public Sub IngresarDescanso(ByRef Usuario As String, ByRef tipoDescanso As Integer, ByRef descanso As Boolean)
        Dim dapDescanso As New clsGeneralDA
        dapDescanso.IngresarDescanso(Usuario, tipoDescanso, descanso)
    End Sub


End Class
