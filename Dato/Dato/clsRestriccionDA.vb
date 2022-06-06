﻿Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports Entidad

Public Class clsRestriccionDA
    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS
    Dim Tabla As New DataTable
    '*************METODO OARA BUSCAR LAS RESTRICCIONES POR ID DE PLAN*************************
    Public Function BuscarRestriccionPorIdPlan(ByVal _idPlan As Int64) As List(Of eRestriccion)
        Dim cmd As New SqlCommand
        Dim listaRestricciones As New List(Of eRestriccion)

        cmd.CommandType = CommandType.StoredProcedure

        tipoConexion = 2
        query = "dbo.pa_BuscarRestrccionPorIdPlan"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@idPlan", _idPlan)
        Tabla = con.TraeDatos(cmd, tipoConexion)

        For x As Int16 = 0 To Tabla.Rows.Count - 1
            Dim row As New eRestriccion
            row.idRestriccionPlan = IIf(IsDBNull(Tabla.Rows(x)("idRestriccionPlan")), Nothing, Tabla.Rows(x)("idRestriccionPlan"))
            row.idPlan = IIf(IsDBNull(Tabla.Rows(x)("idPlan")), Nothing, Tabla.Rows(x)("idPlan"))
            row.valorRestriccion = IIf(IsDBNull(Tabla.Rows(x)("valorRestriccion")), Nothing, Tabla.Rows(x)("valorRestriccion"))
            row.operacion = IIf(IsDBNull(Tabla.Rows(x)("operacion")), Nothing, Tabla.Rows(x)("operacion"))
            row.fechaCreacion = IIf(IsDBNull(Tabla.Rows(x)("fechaCreacion")), Nothing, Tabla.Rows(x)("fechaCreacion"))
            row.activo = IIf(IsDBNull(Tabla.Rows(x)("activo")), Nothing, Tabla.Rows(x)("activo"))

            listaRestricciones.Add(row)
        Next

        Return listaRestricciones

    End Function

End Class
