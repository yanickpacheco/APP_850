Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports Entidad
Public Class clsPolizaDA


    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS
    Dim dt As New DataTable
    Public Function BuscarCotizacion(ByVal edad As Integer, ByVal nombrePlan As String, ByVal tipoContrato As Integer, ByVal crm As String) As DataTable

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].pa_obtieneCotizacion"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@edad", edad)
        cmd.Parameters.AddWithValue("@nombrePlan", nombrePlan)
        cmd.Parameters.AddWithValue("@tipoContrato", tipoContrato)
        cmd.Parameters.AddWithValue("@crm", crm)
        dt = con.TraeDatos(cmd, 1)

        Return dt


    End Function


    ''' <summary>
    ''' Ingresa una Nueva Cotizacion
    ''' </summary>
    ''' <param name="edad"></param>
    ''' <param name="nombrePlan"></param>
    ''' <param name="tipoContrato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IngresarCotizacion(ByVal id As Integer, ByVal edad As Integer, ByVal nombrePlan As String, ByVal tipoContrato As Integer, ByVal fechaNacimiento As String) As Boolean


        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].pa_ingresaCotizacion"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@edad", edad)
        cmd.Parameters.AddWithValue("@nombrePlan", nombrePlan)
        cmd.Parameters.AddWithValue("@tipoContrato", tipoContrato)
        cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento)
        con.Ejecutar(cmd, 2)

        Return True


    End Function

    ''' <summary>
    ''' Ingresa una Nueva Poliza
    ''' </summary>
    ''' <param name="_Gestion"></param>
    ''' <param name="_cliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IngresaPoliza(ByVal _Gestion As eGestion, ByVal _cliente As eCliente) As Integer


        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].pa_ingresaPoliza"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@C_ID", _cliente.C_Id)
        cmd.Parameters.AddWithValue("@P_NOMBRE", _Gestion.G_Nombre)
        cmd.Parameters.AddWithValue("@P_PATERNO", _Gestion.G_Paterno)
        cmd.Parameters.AddWithValue("@P_MATERNO", _Gestion.G_Materno)
        cmd.Parameters.AddWithValue("@P_RUT", _Gestion.G_Rut)
        cmd.Parameters.AddWithValue("@P_DV", _Gestion.G_Dv)
        cmd.Parameters.AddWithValue("@P_FECHANACIMIENTO", _Gestion.G_Fecha_Nacimiento)
        cmd.Parameters.AddWithValue("@P_FONO_VENTA", _Gestion.G_Fono_Contacto)
        cmd.Parameters.AddWithValue("@P_EMAIL", _Gestion.G_Email)
        cmd.Parameters.AddWithValue("@P_SISTEMA_SALUD", _Gestion.G_Dato3)
        cmd.Parameters.AddWithValue("@P_PESO", _Gestion.G_Dato1)
        cmd.Parameters.AddWithValue("@P_ESTATURA", _Gestion.G_Dato2)
        cmd.Parameters.AddWithValue("@P_PLAN", _Gestion.G_Plan)
        cmd.Parameters.AddWithValue("@P_CALLE", _Gestion.G_Calle)
        cmd.Parameters.AddWithValue("@P_NUMERO", _Gestion.G_Nro)
        cmd.Parameters.AddWithValue("@P_REFERENCIA", _Gestion.G_Referencia)
        cmd.Parameters.AddWithValue("@P_COMUNA", _Gestion.G_Comuna)
        cmd.Parameters.AddWithValue("@P_CIUDAD", _Gestion.G_Ciudad)
        cmd.Parameters.AddWithValue("@P_PRIMAUF", _Gestion.G_Prima_Uf)
        cmd.Parameters.AddWithValue("@P_PRIMAPESOS", _Gestion.G_Prima_Pesos)
        cmd.Parameters.AddWithValue("@P_TIPOCONTRATO", _Gestion.G_TipoContrato)
        cmd.Parameters.AddWithValue("@P_DPS", _Gestion.G_Dato6)
        cmd.Parameters.AddWithValue("@P_RUT_PAGADOR", _Gestion.G_Dato4)
        cmd.Parameters.AddWithValue("@P_NOMBRE_PAGADOR", _Gestion.G_Dato5)
        dt = con.TraeDatos(cmd, 2)

        Return dt.Rows(0)("Id_Poliza")


    End Function

    ''' <summary>
    '''Actualiza los datos de una nueva poliza en Recuperacion
    ''' </summary>
    ''' <param name="_Gestion"></param>
    ''' <param name="_cliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ActualizaPoliza(ByVal _Gestion As eGestion, ByVal _cliente As eCliente) As Boolean


        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].pa_actualizaPoliza"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@C_ID", _cliente.C_Id)
        cmd.Parameters.AddWithValue("@P_NOMBRE", _Gestion.G_Nombre)
        cmd.Parameters.AddWithValue("@P_PATERNO", _Gestion.G_Paterno)
        cmd.Parameters.AddWithValue("@P_MATERNO", _Gestion.G_Materno)
        cmd.Parameters.AddWithValue("@P_RUT", _Gestion.G_Rut)
        cmd.Parameters.AddWithValue("@P_FONO_VENTA", _Gestion.G_Fono_Contacto)
        cmd.Parameters.AddWithValue("@P_EMAIL", _Gestion.G_Email)
        cmd.Parameters.AddWithValue("@P_SISTEMA_SALUD", _Gestion.G_Dato3)
        cmd.Parameters.AddWithValue("@P_PESO", _Gestion.G_Dato1)
        cmd.Parameters.AddWithValue("@P_ESTATURA", _Gestion.G_Dato2)
        cmd.Parameters.AddWithValue("@P_CALLE", _Gestion.G_Calle)
        cmd.Parameters.AddWithValue("@P_NUMERO", _Gestion.G_Nro)
        cmd.Parameters.AddWithValue("@P_REFERENCIA", _Gestion.G_Referencia)
        cmd.Parameters.AddWithValue("@P_COMUNA", _Gestion.G_Comuna)
        cmd.Parameters.AddWithValue("@P_CIUDAD", _Gestion.G_Ciudad)
        cmd.Parameters.AddWithValue("@P_DPS", _Gestion.G_Dato6)
        cmd.Parameters.AddWithValue("@P_RUT_PAGADOR", _Gestion.G_Dato4)
        cmd.Parameters.AddWithValue("@P_NOMBRE_PAGADOR", _Gestion.G_Dato5)
        con.Ejecutar(cmd, 2)

        Return True

    End Function

    ''' <summary>
    '''Actualiza los datos de una nueva poliza en Recuperacion
    ''' </summary>
    ''' <param name="_RutPoliza"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function eliminaPoliza(ByVal _idPoliza As Integer) As Boolean


        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].pa_eliminaPoliza"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@P_ID", _idPoliza)
        con.Ejecutar(cmd, 2)

        Return True

    End Function



    ''' <summary>
    ''' Busca Cotizaciones Ingresadas por Cliente
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function cargaCotizacionesCliente(ByVal id As Integer) As DataTable

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].pa_buscaCotizacionCliente"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@id", id)
        dt = con.TraeDatos(cmd, 2)

        Return dt


    End Function

    ''' <summary>
    ''' Busca Polizas Ingresadas por Cliente
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaPolizas(ByVal id As Integer) As DataTable

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].[pa_ListaPolizas]"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@C_ID", id)
        dt = con.TraeDatos(cmd, 2)

        Return dt


    End Function


    Public Function validarPoliza(ByVal Rut As Integer, ByVal id As Integer) As DataTable

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].[pa_ValidarPolizaExistente]"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@Rut", Rut)
        cmd.Parameters.AddWithValue("@id", id)
        dt = con.TraeDatos(cmd, 2)

        Return dt


    End Function

    Public Function ListaPolizasPago(ByVal id As Integer) As DataTable

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].[pa_ListaPolizasMedioPago]"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@C_ID", id)
        dt = con.TraeDatos(cmd, 2)

        Return dt


    End Function


    Public Function actualizaMedioPago(ByVal _poliza As ePoliza, ByVal idPoliza As Integer) As Boolean


        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].[pa_ActualizaMedioPago]"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@P_ID", idPoliza)
        cmd.Parameters.AddWithValue("@P_MEDIO_PAGO", _poliza.medio_pago)
        cmd.Parameters.AddWithValue("@P_BANCO", _poliza.banco)
        cmd.Parameters.AddWithValue("@P_TIPO_TARJETA", _poliza.tipo_tarjeta)
        cmd.Parameters.AddWithValue("@P_NRO_CUENTA", _poliza.nro_Cuenta)
        con.Ejecutar(cmd, 2)

        MsgBox("Medio de Pago Actualizado", vbInformation, "CORDIALPHONE")

        Return 1


    End Function



End Class
