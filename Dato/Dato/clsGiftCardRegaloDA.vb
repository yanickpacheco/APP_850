Imports System.Data.SqlClient
Imports Entidad

Public Class clsGiftCardRegaloDA
    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS

    Public Function ListaGiftCard() As List(Of eGiftcardRegalo)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].[pa_ObtieneGiftCardRegalo]"
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 2)

        Dim list As New List(Of eGiftcardRegalo)
        Dim row As New eGiftcardRegalo
        row.idGiftcardRegalo = 0
        row.cantidadPolizas = 0
        row.descripcion = "-- Sin selección --"
        list.Add(row)

        For x As Int16 = 0 To dt.Rows.Count - 1
            row = New eGiftcardRegalo
            row.idGiftcardRegalo = IIf(IsDBNull(dt.Rows(x)("idGiftcardRegalo")), Nothing, dt.Rows(x)("idGiftcardRegalo"))
            row.descripcion = IIf(IsDBNull(dt.Rows(x)("descripcion")), Nothing, dt.Rows(x)("descripcion"))
            row.cantidadPolizas = IIf(IsDBNull(dt.Rows(x)("cantidadPolizas")), Nothing, dt.Rows(x)("cantidadPolizas"))
            list.Add(row)
        Next

        Return list

    End Function
End Class
