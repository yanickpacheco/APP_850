Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Imports Entidad
Imports BI

Friend Class frmVenta
    Inherits System.Windows.Forms.Form
    Public KeyAscii As Short
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BDD_847; User Id= cp; Password=Cordial.passs")

    Public FilaAgregar2 As Integer
    Public FilaElimina As Integer
    Public FilaElimina2 As Integer
    Public fila As Integer
    Public fila2 As Integer
    Public Col As Integer
    Public i As Integer
    Public ufAdic As Double = 0
    Public totalUfAdic As Double = 0
    Public idPlanAdic As Int64
    Public TpoContratoAdicional As eTipoContrato
    Public valorPesosUf As Integer = 0
    Public TotalPesos As Integer

    Dim biClsComuna As New clsComunaBI
    Dim biClsCiudad As New clsCiudadBI
    Dim biClsEdoFono As New clsEstadoFonosBI
    Dim biClsScript As New clsScriptBI
    Dim biClsTipoContrato As New clsTipoContratoBI
    Dim biClsPlan As New clsPlanBI
    Dim biCLSPoliza As New clsPolizabBI
    Dim biClsRestricion As New clsRestriccionBI
    Dim biClsParentesco As New clsParentescoBI
    Dim biClsParentescoCampania As New clsParentescoCampaniaBI
    Dim biClsBen As New clsBeneficiarioBI
    Dim biClsAdic As New clsAdicionalBI
    Dim biCorreoInv As New clsCorreoInvalidoBI
    Dim soap As New clsSoapNeo

    Dim clsScript As New eScript
    Dim vlUF As String

    Dim ListTipoContrato As New List(Of eTipoContrato)
    Dim tipoContrato As New eTipoContrato
    Dim listPlanes As New List(Of ePlan)
    Dim planE As New ePlan
    Dim ePlanGlobal As New ePlan
    Dim listRestricciones As New List(Of eRestriccion)
    Dim restricionE As New eRestriccion
    Dim listParentesco As List(Of eParentesco)
    Dim listaCorreoInvalido As New List(Of eCorreoInvalido)

    Private IsInitializing As Boolean = True

    Dim biCliente As New clsClienteBI
    Dim biGeneral As New clsGeneralBI
    Dim biScrisp As New clsScriptBI
    Dim biGesRes As New clsRegrabacionesBI
    Dim poliza As New ePoliza
    Dim planCotiza As Integer
    Dim tipoContratoCotiza As Integer
    Dim primaUfCotiza As String
    Dim primaPesosCotiza As String
    Dim fechaNacimientoCotiza As Date
    Dim nuevapoliza As Boolean
    Dim idPolizaParaPago As Integer = 0
    Dim idPolizaRegrabacion As Integer = 0

    Private Sub Botones(ByRef activo As Boolean)
        Select Case activo
            Case False
                CmdLlamar1.Enabled = False
                CmdLlamar2.Enabled = False
                CmdLlamar3.Enabled = False
                CmdLlamar4.Enabled = False
                CmdLlamar5.Enabled = False
                CmdLlamar6.Enabled = False
                CmdLlamarAlt.Enabled = False
            Case True
                CmdLlamar1.Enabled = Not esVacio((Txt_Fono1.Text)) 'True
                CmdLlamar2.Enabled = Not esVacio((Txt_Fono2.Text)) 'True
                CmdLlamar3.Enabled = Not esVacio((Txt_Fono3.Text)) 'True
                CmdLlamar4.Enabled = Not esVacio((Txt_Fono4.Text)) 'True
                CmdLlamar5.Enabled = Not esVacio((Txt_Fono5.Text)) 'True
                CmdLlamar6.Enabled = Not esVacio((Txt_Fono6.Text)) 'True
                CmdLlamarAlt.Enabled = Not esVacio((Txt_Fono_alt.Text)) 'True
                CmdLlamarAlt.Enabled = IIf(perfil = "Regrabador", True, Not esVacio((Txt_Fono_alt.Text)))  'True
                Txt_Fono_alt.ReadOnly = IIf(perfil = "Regrabador", False, True)
                CmdLlamarVent.Enabled = IIf(perfil = "Regrabador", True, Not esVacio((txt_FonoVenta.Text)))  'True
                txt_FonoVenta.ReadOnly = IIf(perfil = "Regrabador", False, True)

        End Select
    End Sub

    'UPGRADE_WARNING: El evento chkMute.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkMute_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMute.CheckStateChanged
        If chkMute.CheckState = 0 Then
            chkMute.Text = "Mute Desactivado"
        Else
            chkMute.Text = "Mute Activado"
            chkMute.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
        End If

        If CmdLlamar1.Text = "COLGAR" Or CmdLlamar2.Text = "COLGAR" Or CmdLlamar3.Text = "COLGAR" Or CmdLlamar4.Text = "COLGAR" Or CmdLlamar5.Text = "COLGAR" Or CmdLlamar6.Text = "COLGAR" Or CmdLlamarAlt.Text = "COLGAR" Then
            Datos = ""
            Mute()
        ElseIf chkMute.CheckState = 1 Then
            MsgBox("Debe llamar antes de pasar al estado MUTE")
            chkMute.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    Private Sub llamarProgresivoFijo()


        If flg_progresivo_activado Then

            If (flg_fonoVent) And Not flg_EsCeluVent Then
                'Comenzar (1)
                LlamarFono(CmdLlamarVent, txt_FonoVenta, flg_fonoVent)

            Else

                If (flg_fono1) And Not flg_EsCelu1 Then
                    'Comenzar (1)
                    LlamarFono(CmdLlamar1, Txt_Fono1, flg_fono1)

                Else
                    If (flg_fono2) And Not flg_EsCelu2 Then
                        'Comenzar (2)
                        LlamarFono(CmdLlamar2, Txt_Fono2, flg_fono2)

                    Else
                        If (flg_fono3) And Not flg_EsCelu3 Then
                            'Comenzar (3)
                            LlamarFono(CmdLlamar3, Txt_Fono3, flg_fono3)

                        Else
                            If (flg_fono4) And Not flg_EsCelu4 Then
                                'Comenzar (4)
                                LlamarFono(CmdLlamar4, Txt_Fono4, flg_fono4)

                            Else
                                If (flg_fono5) And Not flg_EsCelu5 Then
                                    'Comenzar (5)
                                    LlamarFono(CmdLlamar5, Txt_Fono5, flg_fono5)
                                Else
                                    If (flg_fono6) And Not flg_EsCelu6 Then
                                        'Comenzar (6)
                                        LlamarFono(CmdLlamar6, Txt_Fono6, flg_fono6)
                                    Else
                                        If (flg_fonoalt) And Not flg_EsCeluAlt Then
                                            LlamarFono(CmdLlamarAlt, Txt_Fono_alt, flg_fonoalt)
                                            If flg_progresivo_activado Then
                                                flg_progresivo_activado = False
                                            End If
                                        Else
                                            llamarProgresivoCelular()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            ' el progesivo se ha desactivado debido a que el ejecutivo
            ' ha marcado una llamada como contactada o la modalidad de la campaña no es progresiva
        End If

    End Sub

    Private Sub llamarProgresivoCelular()

        If flg_progresivo_activado Then
            If (flg_fonoVent) Then
                'Comenzar (1)
                LlamarFono(CmdLlamarVent, txt_FonoVenta, flg_fonoVent)
            Else

                If (flg_fono1) Then
                    'Comenzar (1)
                    LlamarFono(CmdLlamar1, Txt_Fono1, flg_fono1)
                Else
                    If (flg_fono2) Then
                        'Comenzar (2)
                        LlamarFono(CmdLlamar2, Txt_Fono2, flg_fono2)
                    Else
                        If (flg_fono3) Then
                            'Comenzar (3)
                            LlamarFono(CmdLlamar3, Txt_Fono3, flg_fono3)
                        Else
                            If (flg_fono4) Then
                                'Comenzar (4)
                                LlamarFono(CmdLlamar4, Txt_Fono4, flg_fono4)
                            Else
                                If (flg_fono5) Then
                                    'Comenzar (5)
                                    LlamarFono(CmdLlamar5, Txt_Fono5, flg_fono5)
                                Else
                                    If (flg_fono6) Then
                                        'Comenzar (6)
                                        LlamarFono(CmdLlamar6, Txt_Fono6, flg_fono6)
                                    Else
                                        If (flg_fonoalt) Then
                                            LlamarFono(CmdLlamarAlt, Txt_Fono_alt, flg_fonoalt)
                                            If flg_progresivo_activado Then
                                                flg_progresivo_activado = False
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            ' el progesivo se ha desactivado debido a que el ejecutivo
            ' ha marcado una llamada como contactada o la modalidad de la campaña no es progresiva
        End If

    End Sub

    Private Sub llamarProgresivo()

        If flg_progresivo_activado Then


            If (flg_fono1) Then
                'Comenzar (1)
                LlamarFono(CmdLlamar1, Txt_Fono1, flg_fono1)
            Else
                If (flg_fono2) Then
                    'Comenzar (2)
                    LlamarFono(CmdLlamar2, Txt_Fono2, flg_fono2)
                Else
                    If (flg_fono3) Then
                        'Comenzar (3)
                        LlamarFono(CmdLlamar3, Txt_Fono3, flg_fono3)
                    Else
                        If (flg_fono4) Then
                            'Comenzar (4)
                            LlamarFono(CmdLlamar4, Txt_Fono4, flg_fono4)
                        Else
                            If (flg_fono5) Then
                                'Comenzar (5)
                                LlamarFono(CmdLlamar5, Txt_Fono5, flg_fono5)
                            Else
                                If (flg_fono6) Then
                                    'Comenzar (6)
                                    LlamarFono(CmdLlamar6, Txt_Fono6, flg_fono6)
                                Else
                                    If (flg_fonoalt) Then
                                        LlamarFono(CmdLlamarAlt, Txt_Fono_alt, flg_fonoalt)
                                        If flg_progresivo_activado Then
                                            flg_progresivo_activado = False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    'pasamos como parametros el fono a llamar y el valor del telefono
    Public Sub LlamarFono(ByRef CmdLlamar As System.Windows.Forms.Button, ByRef txtFono As System.Windows.Forms.TextBox, ByRef fonoActivo As Boolean)
        Dim cmdFonos(6) As String
        Dim i As Short
        Dim f As Short
        If txtFono.Text <> "" Then
            If CmdLlamar.Text = "COLGAR" Then
                grabarCallId("CORTAR", WS_CALL_ID, (txtFono.Text), claveRegistroActual)
                'cortar llamada fonox
                cortarFonos(CmdLlamar, False)
                'desactivamos el mute
                If chkMute.CheckState = 1 Then chkMute.CheckState = System.Windows.Forms.CheckState.Unchecked
                'volvemos a llamar al fono
                fonoActivo = False
            Else
                Botones(True)
                cmdFonos(0) = CmdLlamar1.Name
                cmdFonos(1) = CmdLlamar2.Name
                cmdFonos(2) = CmdLlamar3.Name
                cmdFonos(3) = CmdLlamar4.Name
                cmdFonos(4) = CmdLlamar5.Name
                cmdFonos(5) = CmdLlamar6.Name
                cmdFonos(6) = CmdLlamarAlt.Name

                f = UBound(cmdFonos)

                For i = 0 To f
                    If cmdFonos(i) <> CmdLlamar.Name Then
                        'validamos que no existan otras llamadas activas
                        If i = 0 Then
                            If (CmdLlamar2.Text = "COLGAR" Or CmdLlamar3.Text = "COLGAR" Or CmdLlamar4.Text = "COLGAR" Or CmdLlamar5.Text = "COLGAR" Or CmdLlamar6.Text = "COLGAR" Or CmdLlamarAlt.Text = "COLGAR") Then
                                MsgBox("No puede realizar otra llamada mientras ya tenga una activa!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
                                Exit Sub
                            End If
                        End If

                        If i = 1 Then
                            If (CmdLlamar1.Text = "COLGAR" Or CmdLlamar3.Text = "COLGAR" Or CmdLlamar4.Text = "COLGAR" Or CmdLlamar5.Text = "COLGAR" Or CmdLlamar6.Text = "COLGAR" Or CmdLlamarAlt.Text = "COLGAR") Then
                                MsgBox("No puede realizar otra llamada mientras ya tenga una activa!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
                                Exit Sub
                            End If
                        End If

                        If i = 2 Then
                            If (CmdLlamar1.Text = "COLGAR" Or CmdLlamar2.Text = "COLGAR" Or CmdLlamar4.Text = "COLGAR" Or CmdLlamar5.Text = "COLGAR" Or CmdLlamar6.Text = "COLGAR" Or CmdLlamarAlt.Text = "COLGAR") Then
                                MsgBox("No puede realizar otra llamada mientras ya tenga una activa!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
                                Exit Sub
                            End If
                        End If

                        If i = 3 Then
                            If (CmdLlamar1.Text = "COLGAR" Or CmdLlamar2.Text = "COLGAR" Or CmdLlamar3.Text = "COLGAR" Or CmdLlamar5.Text = "COLGAR" Or CmdLlamar6.Text = "COLGAR" Or CmdLlamarAlt.Text = "COLGAR") Then
                                MsgBox("No puede realizar otra llamada mientras ya tenga una activa!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
                                Exit Sub
                            End If
                        End If

                        If i = 4 Then
                            If (CmdLlamar1.Text = "COLGAR" Or CmdLlamar2.Text = "COLGAR" Or CmdLlamar3.Text = "COLGAR" Or CmdLlamar4.Text = "COLGAR" Or CmdLlamar6.Text = "COLGAR" Or CmdLlamarAlt.Text = "COLGAR") Then
                                MsgBox("No puede realizar otra llamada mientras ya tenga una activa!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
                                Exit Sub
                            End If
                        End If

                        If i = 5 Then
                            If (CmdLlamar1.Text = "COLGAR" Or CmdLlamar2.Text = "COLGAR" Or CmdLlamar3.Text = "COLGAR" Or CmdLlamar4.Text = "COLGAR" Or CmdLlamar5.Text = "COLGAR" Or CmdLlamarAlt.Text = "COLGAR") Then
                                MsgBox("No puede realizar otra llamada mientras ya tenga una activa!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
                                Exit Sub
                            End If
                        End If

                        If i = 6 Then
                            If (CmdLlamar1.Text = "COLGAR" Or CmdLlamar2.Text = "COLGAR" Or CmdLlamar3.Text = "COLGAR" Or CmdLlamar4.Text = "COLGAR" Or CmdLlamar5.Text = "COLGAR" Or CmdLlamar6.Text = "COLGAR") Then
                                MsgBox("No puede realizar otra llamada mientras ya tenga una activa!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
                                Exit Sub
                            End If
                        End If

                    End If
                Next
                'sino hay otras llamadas activas entonces
                'llamamos al fonox
                If Not llamar((txtFono.Text)) Then
                    MsgBox("No puede realizar otra llamada mientras ya tenga una activa!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
                Else
                    grabarCallId("LLAMAR", WS_CALL_ID, (txtFono.Text), claveRegistroActual)
                    CmdLlamar.Text = "COLGAR"
                    CmdLlamar.BackColor = Color.Red
                    'CmdLlamar.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                    txtCallId.Text = WS_CALL_ID
                End If
            End If
        End If
    End Sub
    '******************Metodo al cambiar item de combobox cmbComunicaCon de tab Conexion****************************************************************
    Private Sub CmbComunicaCon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbComunicaCon.SelectedIndexChanged
        '0 [No Especificado]
        '1 COMUNICA CON CLIENTE
        '2 COMUNICA CON CLIENTE NO VIGENTE EN METLIFE
        '3 COMUNICA CON CONYUGE
        '4 COMUNICA CON TERCERO VALIDO
        '5 COMUNICA CON REGISTRO NO VALIDO (NO VIVE/NO TRABAJA AHI)

        Select Case CmbComunicaCon.SelectedIndex
            Case 1, 3, 4
                CmbComunicaTercero.SelectedIndex = -1
                Label12.Visible = True
                CmbComunicaTercero.Visible = False
                Label11.Visible = False
                Label13.Visible = False
            Case 2
                CmbComunicaTercero.SelectedIndex = -1
                Label12.Visible = True
                CmbComunicaTercero.Visible = True
                Label11.Visible = False
                Label13.Visible = True

        End Select
    End Sub
    '******************Metodo al cambiar item de combobox cmbConecta de tab Conexion****************************************************************
    Private Sub CmbConecta_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbConecta.SelectedIndexChanged
        If CmbConecta.SelectedIndex = 1 Then
            CmbNoConecta.SelectedIndex = 0
            CmbComunicaCon.SelectedIndex = 0
            CmbComunicaTercero.SelectedIndex = 0
            Label11.Visible = False
            CmbNoConecta.Visible = False
            FrmConex.Visible = True
            Label13.Visible = False
            CmbComunicaTercero.Visible = False

            clsScript = CargaScript(1)
            wbScriptBienvenida.DocumentText = clsScript.contenidoScript

        ElseIf CmbConecta.SelectedIndex = 2 Then
            CmbNoConecta.SelectedIndex = 0
            CmbComunicaCon.SelectedIndex = 0
            CmbComunicaTercero.SelectedIndex = 0
            Label11.Visible = True
            CmbNoConecta.Visible = True
            FrmConex.Visible = False
            Label13.Visible = False
            CmbComunicaTercero.Visible = False

        End If
    End Sub

    Private Sub CmbEstAgenda_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbEstAgenda.SelectedIndexChanged
        If CmbEstAgenda.SelectedIndex = 0 Or CmbEstAgenda.SelectedIndex = 1 Then
            FrmAgendamiento.Visible = True
            CmdSiguienteA.Visible = False
            CmdTerminarA.Visible = True
        Else
            FrmAgendamiento.Visible = False
            CmdSiguienteA.Visible = True
            CmdTerminarA.Visible = False
        End If
    End Sub

    Private Sub cmdAnexos_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        frmAnexos.ShowDialog()
    End Sub
    '************************metodo de boton atras ***************************************************************
    Private Sub CmdAtras_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdAtras.Click

        'If perfil <> "Regrabador" Then
        If MsgBox("Desea Retroceder?", MsgBoxStyle.YesNo, csNombreAplicacion) = MsgBoxResult.Yes Then
            ' reinicializa los controles y las variables que se modificaron
            ' al pasar de una pantalla a otra, al presionar el boton VOLVER
            ' se saca el ultimo elemento ingresado a la pila (pop). Este numero
            ' corresponde tambien al ultimo TAB visitado en el flujo. Sabiendo este dato
            ' podemos resetear lo que se hizo al pasar del tab anterior al actual
            Dim pantallaAnterior As Integer
            Dim pantallaActual As String


            ' saco el ultimo elemento en la pila (ultimo TAB que se visito)
            pantallaAnterior = pilaPop()
            ' guardo el TAB ACTUAL!
            pantallaActual = Cuerpo.TabPages.Item(Cuerpo.SelectedIndex).Name

            If pantallaActual = "_Cuerpo_Polizas" Then
                pantallaAnterior = 1
            End If

            Select Case pantallaActual
                Case "_Cuerpo_Conex"
                    CmbConecta.SelectedIndex = 0
                    CmbNoConecta.SelectedIndex = 0
                    CmbComunicaCon.SelectedIndex = 0
                    CmbComunicaTercero.SelectedIndex = 0
                    Label11.Visible = False
                    CmbNoConecta.Visible = False
                    FrmConex.Visible = False
                    Label13.Visible = False
                    CmbComunicaTercero.Visible = False

                Case "_Cuerpo_MtvoLL"

                    lblInteresa.Visible = True
                    CmbInteresa.SelectedIndex = 0
                    CmbInteresa.Visible = True

                Case "_Cuerpo_DatosCli"
                    txtNombreV.Text = Trim(UCase(CLIENTE.C_Nombre))
                    txtPaternoV.Text = Trim(UCase(CLIENTE.C_Paterno))
                    txtMaternoV.Text = Trim(UCase(CLIENTE.C_Materno))
                    txtRutV.Text = Mid(CLIENTE.C_Rut, 1, 4)
                    txtDvV.Text = ""
                    'txtEmail.Text = CLIENTE.C_Email
                    'txtCalleV.Text = CLIENTE.C_Direccion
                    'txtNroV.Text = ""
                    'txtReferenciaV.Text = ""
                    'cmbComuna.SelectedIndex = -1
                    'cmbComuna.Text = ""
                    'cmbCiudad.Text = ""
                    txtFonoVenta.Text = ""
                    'cmbPlan.SelectedIndex = 0
                    'cmbCiudad.DataSource = Nothing
                    'cmbCiudad.ValueMember = Nothing

                Case "_Cuerpo_MPago"

                Case "_Cuerpo_InfAdic"

                Case "_Cuerpo_Certifica"
                    cmbAceptaPrima.SelectedIndex = 0
                    cmbAceptaContrato.SelectedIndex = 0

                Case "_Cuerpo_UltInfo"



                Case "_Cuerpo_Adicionales"

                    insertaAdicionalesGrilla()
                    limpiaAdicionales()

                Case "_Cuerpo_Objeciones"
                    TxtObj.Text = ""
                    CmbObj.SelectedIndex = 0

                Case "_Cuerpo_Agendar"
                    CmbEstAgenda.SelectedIndex = -1
                    FrmAgendamiento.Visible = False
                    TxtObsA.Text = ""
                    DTAgenFecha2.Value = Today
                    cmbHora.SelectedIndex = -1
                    cmbMin.SelectedIndex = -1
                    CmdTerminarA.Visible = True
                    CmdSiguienteA.Visible = True


                Case "_Cuerpo_Agenda2"
                    TxtObsAgen2.Text = ""
                    DTAgenFecha2.Value = Today
                    CmbHora2.SelectedIndex = -1
                    CmbMin2.SelectedIndex = -1


                Case "_Cuerpo_FinNC"

                Case "_Cuerpo_Polizas"

            End Select

            ' ahora se resetea la pantalla anterior, y tambien
            ' TODOS los campos de usuario que se pudieron haber llenado
            Select Case pantallaAnterior
                Case 0 '_Cuerpo_IngresoCli
                    Cuerpo.TabPages.Add(_Cuerpo_IngresoCli)


                Case 1 ' _Cuerpo_Conex
                    Cuerpo.TabPages.Add(_Cuerpo_Conex)
                    GESTION.G_Contacto = ""
                    GESTION.G_Contacto_Con = ""
                    GESTION.G_No_Contacto = ""



                Case 2 '_Cuerpo_MtvoLL
                    Cuerpo.TabPages.Add(_Cuerpo_MtvoLL)
                    CmbInteresa.SelectedIndex = 0
                    GESTION.G_Contacto_Flujo = ""
                    GESTION.G_Motivo_No_Interesa = ""


                Case 3 '_Cuerpo_DatosCli
                    Cuerpo.TabPages.Add(_Cuerpo_DatosCli)
                    If perfil <> "Regrabador" Then

                        GESTION.G_Nombre = ""
                        GESTION.G_Paterno = ""
                        GESTION.G_Materno = ""
                        GESTION.G_Rut = 0
                        GESTION.G_Dv = ""
                        GESTION.G_Fecha_Nacimiento = ""
                        GESTION.G_Fono_Contacto = ""
                        GESTION.G_Email = ""
                        GESTION.G_Calle = ""
                        GESTION.G_Nro = ""
                        GESTION.G_Referencia = ""
                        GESTION.G_IdComuna = ""
                        GESTION.G_IdCiudad = ""
                        GESTION.G_Comuna = ""
                        GESTION.G_Ciudad = ""
                        GESTION.G_Plan = 0
                        GESTION.G_Prima_Uf = ""
                        GESTION.G_Prima_Pesos = 0
                        GESTION.G_IdComuna = ""
                        GESTION.G_IdComuna = ""
                    End If

                Case 4 '_Cuerpo_Mpago
                    Cuerpo.TabPages.Add(_Cuerpo_MPago)

                Case 5 '_Cuerpo_InfAdicional

                    Cuerpo.TabPages.Add(_Cuerpo_InfAdic)

                Case 6 '10 _Cuerpo_Certifica
                    Cuerpo.TabPages.Add(_Cuerpo_Certifica)
                    cmbAceptaPrima.SelectedIndex = 0
                    cmbAceptaContrato.SelectedIndex = 0


                Case 7 '_Cuerpo_InfLL
                    Cuerpo.TabPages.Add(_Cuerpo_UltInfo)

                Case 9 '_Cuerpo_Adicionales
                    limpiaAdicionales()
                    Cuerpo.TabPages.Add(_Cuerpo_Adicionales)

                Case 10 '5 _Cuerpo_Objeciones

                    Cuerpo.TabPages.Add(_Cuerpo_Objeciones)

                Case 11 '6 _Cuerpo_Agendar

                    Cuerpo.TabPages.Add(_Cuerpo_Agendar)

                Case 12 '9 _Cuerpo_Agenda2

                    Cuerpo.TabPages.Add(_Cuerpo_Agenda2)

                Case 13 '8 _Cuerpo_FinNC
                    Cuerpo.TabPages.Add(_Cuerpo_FinNC)

                Case 14 '8 _Cuerpo_Polizas
                    Cuerpo.TabPages.Add(_Cuerpo_Polizas)
                    RECUPERACION.R_Contacto_Flujo = ""
                    RECUPERACION.R_Reconoce = ""

            End Select
            Cuerpo.TabPages.Item(Cuerpo.SelectedIndex).Parent = Nothing
            ' bloquea el boton volver en caso de que este en la primera pantalla
            Me.CmdAtras.Enabled = pantallaAnterior > 1
            If pantallaAnterior = 0 Then
                Me.CmdAtras.Enabled = True
            End If
        End If

    End Sub

    Private Sub CmdLlamar1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdLlamar1.Click
        If CmdLlamar1.Text = "LLAMAR" And Trim$(Txt_Fono1.Text) <> "" Then
            txtCallId.Text = ""
            WS_CALL_ID = ""
        End If
        LlamarFono(CmdLlamar1, Txt_Fono1, flg_fono1)
        Fono_A_Llamar = Txt_Fono1.Text
        'lblNumero.Text = Txt_Fono1.Text
        'lblIdNumero.Text = "1"

    End Sub
    Private Sub CmdLlamar2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdLlamar2.Click
        If CmdLlamar2.Text = "LLAMAR" And Trim$(Txt_Fono2.Text) <> "" Then
            txtCallId.Text = ""
            WS_CALL_ID = ""
        End If
        LlamarFono(CmdLlamar2, Txt_Fono2, flg_fono2)
        Fono_A_Llamar = Txt_Fono2.Text
        'lblNumero.Text = Txt_Fono2.Text
        'lblIdNumero.Text = "2"
    End Sub
    Private Sub CmdLlamar3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdLlamar3.Click
        If CmdLlamar3.Text = "LLAMAR" And Trim$(Txt_Fono3.Text) <> "" Then
            txtCallId.Text = ""
            WS_CALL_ID = ""
        End If
        LlamarFono(CmdLlamar3, Txt_Fono3, flg_fono3)
        Fono_A_Llamar = Txt_Fono3.Text
        'lblNumero.Text = Txt_Fono3.Text
        'lblIdNumero.Text = "3"
    End Sub
    Private Sub CmdLlamar4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdLlamar4.Click
        If CmdLlamar4.Text = "LLAMAR" And Trim$(Txt_Fono4.Text) <> "" Then
            txtCallId.Text = ""
            WS_CALL_ID = ""
        End If
        LlamarFono(CmdLlamar4, Txt_Fono4, flg_fono4)
        Fono_A_Llamar = Txt_Fono4.Text
        'lblNumero.Text = Txt_Fono4.Text
        'lblIdNumero.Text = "4"
    End Sub
    Private Sub CmdLlamar5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdLlamar5.Click
        If CmdLlamar5.Text = "LLAMAR" And Trim$(Txt_Fono5.Text) <> "" Then
            txtCallId.Text = ""
            WS_CALL_ID = ""
        End If
        LlamarFono(CmdLlamar5, Txt_Fono5, flg_fono5)
        Fono_A_Llamar = Txt_Fono5.Text
        'lblNumero.Text = Txt_Fono5.Text
        'lblIdNumero.Text = "5"
    End Sub
    Private Sub CmdLlamar6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdLlamar6.Click
        If CmdLlamar6.Text = "LLAMAR" And Trim$(Txt_Fono6.Text) <> "" Then
            txtCallId.Text = ""
            WS_CALL_ID = ""
        End If
        LlamarFono(CmdLlamar6, Txt_Fono6, flg_fono6)
        Fono_A_Llamar = Txt_Fono6.Text
        'lblNumero.Text = Txt_Fono6.Text
        'lblIdNumero.Text = "6"
    End Sub
    Private Sub CmdLlamarAlt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdLlamarAlt.Click
        If CmdLlamarAlt.Text = "LLAMAR" And Trim$(Txt_Fono_alt.Text) <> "" Then
            txtCallId.Text = ""
            WS_CALL_ID = ""
        End If
        LlamarFono(CmdLlamarAlt, Txt_Fono_alt, flg_fonoalt)
        Fono_A_Llamar = Txt_Fono_alt.Text
        'lblNumero.Text = Txt_Fono_alt.Text
        'lblIdNumero.Text = "alt"
    End Sub
    Private Sub CmdLlamarVent_Click(sender As Object, e As EventArgs) Handles CmdLlamarVent.Click
        If CmdLlamarVent.Text = "LLAMAR" And Trim$(txt_FonoVenta.Text) <> "" Then
            txtCallId.Text = ""
            WS_CALL_ID = ""
        End If
        LlamarFono(CmdLlamarVent, txt_FonoVenta, flg_fonoVent)
        Fono_A_Llamar = txt_FonoVenta.Text
        'lblNumero.Text = txt_FonoVenta.Text
        'lblIdNumero.Text = "vent"
    End Sub


    Public Sub Corta_Anteriores()
        If CmdLlamar1.Text = "COLGAR" Then
            grabarCallId("CORTAR", WS_CALL_ID, (Txt_Fono1.Text), claveRegistroActual)
            cortarFonos(CmdLlamar1)

        End If
        If CmdLlamar2.Text = "COLGAR" Then
            grabarCallId("CORTAR", WS_CALL_ID, (Txt_Fono2.Text), claveRegistroActual)
            cortarFonos(CmdLlamar2)

        End If
        If CmdLlamar3.Text = "COLGAR" Then
            grabarCallId("CORTAR", WS_CALL_ID, (Txt_Fono3.Text), claveRegistroActual)
            cortarFonos(CmdLlamar3)

        End If
        If CmdLlamar4.Text = "COLGAR" Then
            grabarCallId("CORTAR", WS_CALL_ID, (Txt_Fono4.Text), claveRegistroActual)
            cortarFonos(CmdLlamar4)

        End If
        If CmdLlamar5.Text = "COLGAR" Then
            grabarCallId("CORTAR", WS_CALL_ID, (Txt_Fono5.Text), claveRegistroActual)
            cortarFonos(CmdLlamar5)

        End If
        If CmdLlamar6.Text = "COLGAR" Then
            grabarCallId("CORTAR", WS_CALL_ID, (Txt_Fono6.Text), claveRegistroActual)
            cortarFonos(CmdLlamar6)

        End If
        If CmdLlamarAlt.Text = "COLGAR" Then
            grabarCallId("CORTAR", WS_CALL_ID, (Txt_Fono_alt.Text), claveRegistroActual)
            cortarFonos(CmdLlamarAlt)

        End If
        If CmdLlamarVent.Text = "COLGAR" Then
            grabarCallId("CORTAR", WS_CALL_ID, (txt_FonoVenta.Text), claveRegistroActual)
            cortarFonos(CmdLlamarVent)

        End If

    End Sub
    ''' <summary>
    ''' procedimiento para buscar cliente en la tabla cli
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Buscar_Cliente()
        tmrPostview.Enabled = False
        Call Corta_Anteriores()
        Dim Tabla As New Data.DataTable

        Tabla = biCliente.Buscar_cliente(WS_IDUSUARIO) 'SI NO HAY NINGUN REGISTRO A EVALUAR SE TERMINA LA APLICACION
        If Tabla.Rows.Count <= 0 Then
            End
        End If

        For x As Integer = 0 To Tabla.Rows.Count - 1
            claveRegistroActual = Tabla.Rows(x)("C_ID")
        Next

        ' respaldar el estado en que venia el registro
        'strQueryUpdateBackupRs = generarQueryBackupRs(Tabla, claveRegistroActual)

        CLIENTE = inicializarCliente(Tabla.Rows(0))

        flg_progresivo_activado = True

        'lblEstadoLlamada.Text = ""
        WS_CALL_ID = ""
        txtCallId.Text = ""

        Txt_Fono1.Text = Trim(CLIENTE.C_Telefono1)
        flg_fono1 = Not esVacio(CLIENTE.C_Telefono1)
        flg_EsCelu1 = esCelular(CLIENTE.C_Telefono1)

        Txt_Fono2.Text = Trim(CLIENTE.C_Telefono2)
        flg_fono2 = Not esVacio(CLIENTE.C_Telefono2)
        flg_EsCelu2 = esCelular(CLIENTE.C_Telefono2)

        Txt_Fono3.Text = Trim(CLIENTE.C_Telefono3)
        flg_fono3 = Not esVacio(CLIENTE.C_Telefono3)
        flg_EsCelu3 = esCelular(CLIENTE.C_Telefono3)

        Txt_Fono4.Text = Trim(CLIENTE.C_Telefono4)
        flg_fono4 = Not esVacio(CLIENTE.C_Telefono4)
        flg_EsCelu4 = esCelular(CLIENTE.C_Telefono4)

        Txt_Fono5.Text = Trim(CLIENTE.C_Telefono5)
        flg_fono5 = Not esVacio(CLIENTE.C_Telefono5)
        flg_EsCelu5 = esCelular(CLIENTE.C_Telefono5)

        Txt_Fono6.Text = Trim(CLIENTE.C_Telefono6)
        flg_fono6 = Not esVacio(CLIENTE.C_Telefono6)
        flg_EsCelu6 = esCelular(CLIENTE.C_Telefono6)

        Txt_Fono_alt.Text = Trim(CLIENTE.C_Fono_Alternativo)
        flg_fonoalt = Not esVacio(CLIENTE.C_Fono_Alternativo)
        flg_EsCeluAlt = esCelular(CLIENTE.C_Fono_Alternativo)

        inicializarControles()
        'llamarProgresivoFijo()
        llamarProgresivo()
        tmrPostview.Enabled = True
        lblHora.Text = "0"
        lblMinutos.Text = "00"
        lblSegundos.Text = "00"
        cargaCamposAdic()

    End Sub

    Private Sub cargaCamposAdic()
        Dim ListaCamposAdic As New List(Of eCampoAdicional)
        Dim BiCampoAdic As New clsCampoAdicionalBI
        Dim style As New DataGridViewCellStyle

        ListaCamposAdic = BiCampoAdic.BuscaDatosCampoAdicional(vgCampania.idCRM, CLIENTE.C_Id)
        dtgCamposAdicionales.DataSource = ListaCamposAdic
        dtgCamposAdicionales.Columns(0).Visible = False
        dtgCamposAdicionales.Columns(3).Visible = False
        dtgCamposAdicionales.Columns(4).Visible = False
        dtgCamposAdicionales.Columns(5).Visible = False
        dtgCamposAdicionales.Columns(6).Visible = False

        dtgCamposAdicionales.ColumnHeadersVisible = False
        dtgCamposAdicionales.RowHeadersVisible = False

        dtgCamposAdicionales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dtgCamposAdicionales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        style.Font = New Font(dtgCamposAdicionales.Font, FontStyle.Bold)
        dtgCamposAdicionales.Columns(1).DefaultCellStyle = style
        dtgCamposAdicionales.BorderStyle = BorderStyle.Fixed3D
        dtgCamposAdicionales.BackgroundColor = Color.White

    End Sub

    Public Sub cortarFonos(ByRef cmdBoton As System.Windows.Forms.Button, Optional ByRef ConGestion As Boolean = True)
        Dim respuesta As Short
        If Not colgar(ConGestion) Then MsgBox("Se ha detectado un problema al intentar colgar los fonos activos!", MsgBoxStyle.Exclamation, "CORDIALPHONE")
        Select Case db_central
            Case 1, 3
                If txtCallId.Text <> "" Then
                    If ConGestion = False Then
                        respuesta = MsgBox("¿La llamada realizada fue venta?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Responder")
                        If respuesta = 6 Then
                            Botones(False)
                        End If
                    Else
                        If CDbl(GESTION.G_Venta) = 1 Then
                            respuesta = 6
                        End If
                    End If
                    Tiempo(respuesta)
                    cmdBoton.Text = "LLAMAR"
                    cmdBoton.BackColor = Color.LimeGreen

                    ' EstadoFono.lblNumero.Text = lblNumero.Text
                    ' EstadoFono.lblIdNumero.Text = lblIdNumero.Text
                    ' EstadoFono.ShowDialog()
                End If
            Case 2, 4
                cmdBoton.Text = "LLAMAR"
                cmdBoton.BackColor = Color.LimeGreen

                '  EstadoFono.lblNumero.Text = lblNumero.Text
                '  EstadoFono.lblIdNumero.Text = lblIdNumero.Text
                '  EstadoFono.ShowDialog()
        End Select

    End Sub
    '*******INICIALIZAMOS LOS CONTROLES PARA REGRABACION***********
    ''' <summary>
    ''' INICIALIZAMOS LOS CONTROLES PARA REGRABACION
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub inicializarControlesGes()

        Try

            TxtId.Text = Trim(CLIENTE.C_Id)
            TxtRut.Text = GESTION.G_Rut
            txtNombre.Text = GESTION.G_Nombre & " " & Trim(GESTION.G_Paterno) & " " & Trim(GESTION.G_Materno)

            If GESTION.G_Sexo = "M" Then
                CmbSexo.SelectedIndex = 1
            ElseIf GESTION.G_Sexo = "F" Then
                CmbSexo.SelectedIndex = 2
            Else
                CmbSexo.SelectedIndex = 0
            End If

            txtDireccion.Text = Trim(GESTION.G_Calle) & " " & Trim(GESTION.G_Nro) & " " & Trim(GESTION.G_Referencia)
            txtFechaNacimiento.Text = Format(Trim(GESTION.G_Fecha_Nacimiento), "Short Date")

            txtIntentos.Text = CStr(CShort(Val(RECUPERACION.R_Intento)))
            If (Len(Trim(IIf(IsDBNull(GESTION.G_Obs_Agen) = True, "", Trim(GESTION.G_Obs_Agen)))) > 0) Then
                txtObsAgen.Text = Trim(GESTION.G_Obs_Agen)
            End If

            If perfil = "Regrabador" Then
                Txt_Fono_alt.ReadOnly = False
            Else
                Txt_Fono_alt.ReadOnly = True
            End If

            '****inicializamos las variables con la fecha y hora actuales*******
            RECUPERACION.R_Fecha = Today.ToString("yyyyMMdd")
            RECUPERACION.R_Hora = TimeOfDay.ToString("HHmmss")
            RECUPERACION.R_Ejecutivo = WS_IDUSUARIO
            inicializar_controles_tab()


        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation, csNombreAplicacion)
        End Try

        tmLabelRegrabacion.Enabled = True
        lblRegrabacion.Visible = True

        cargaCamposAdic()

    End Sub

    '********* FIN CAMPO ADICIONALES ***********

    Public Sub AsiganaCamposAdicionales()

        'MUESTRA LOS CAMPOS ADICIONALES CONFIGURADOS EN LA CAMPAÑA

        Dim biCampoAdicional As New clsCampoAdicionalBI
        Dim listCampoAdicional As New List(Of eCampoAdicional)
        '  listCampoAdicional = biCampoAdicional.BuscaDatosCampoAdicional(vgCampania.calCodigo, CLIENTE.C_Id)

    End Sub


    '*******INICIALIZAMOS LOS CONTROLES VENTA***********
    ''' <summary>
    ''' INICIALIZAMOS LOS CONTROLES VENTA
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub inicializarControles()

        txtObsAgen.Text = "" : txtIntentos.Text = ""
        txtNombre.Text = ""
        TxtId.Text = Trim(CLIENTE.C_Id)
        TxtRut.Text = CLIENTE.C_Rut
        txtNombre.Text = CLIENTE.C_Nombre

        txtNombre.Text = CLIENTE.C_Nombre & " " & Trim(CLIENTE.C_Paterno) & " " & Trim(CLIENTE.C_Materno)

        If CLIENTE.C_Sexo = "M" Then
            CmbSexo.SelectedIndex = 1
        ElseIf CLIENTE.C_Sexo = "F" Then
            CmbSexo.SelectedIndex = 2
        Else
            CmbSexo.SelectedIndex = 0
        End If

        cmdFinVenta.Visible = False
        btnSiguientePoliza.Visible = False
        cmbNuevaPoliza.SelectedIndex = 0
        lstAdi.Clear()

        nuevapoliza = False
        btnGuardarPago.Visible = False
        dtgPolizasPago.Visible = False
        lblPolizasPago.Visible = False
        cmbIngresaMedioPago.Visible = False
        lblIngresoMedioPago.Visible = False
        cmbIngresaMedioPago.SelectedIndex = 0
        btnGuardarPago.Visible = False
        lblMedioPago.Visible = False
        cmbMedioPago.Visible = False




        txtDireccion.Text = Trim(CLIENTE.C_Direccion)
        txtFechaNacimiento.Text = Format(Trim(CLIENTE.C_Fecha_Nacimiento), "Short Date")
        txtPesoCliente.Text = ""
        mskEstaturaCliente.Text = ""
        cmbIsapreCliente.SelectedIndex = 0


        txtIntentos.Text = CStr(CShort(Val(GESTION.G_Intento)))
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If (Len(Trim(IIf(IsDBNull(GESTION.G_Obs_Agen) = True, "", Trim(GESTION.G_Obs_Agen)))) > 0) Then
            txtObsAgen.Text = Trim(GESTION.G_Obs_Agen)
        End If

        GESTION.G_Fecha = Today.ToString("yyyyMMdd")
        GESTION.G_Hora = TimeOfDay.ToString("HHmmss")

        GESTION.G_Ejecutivo = Trim(WS_IDUSUARIO)
        GESTION.G_Ip_Ejecutivo = Trim(usuario_actual.IP)
        Fono_A_Llamar = ""

        If Trim(CLIENTE.C_Fecha_Nacimiento) <> "" Then
            txtFechaNacimiento.Text = Mid(CLIENTE.C_Fecha_Nacimiento, 7, 2) & "-" & Mid(CLIENTE.C_Fecha_Nacimiento, 5, 2) & "-" & Mid(CLIENTE.C_Fecha_Nacimiento, 1, 4)
            ' CLIENTE.C_Edad = CStr(edad(CDate(Mid(CLIENTE.C_Fecha_Nacimiento, 7, 2) & "-" & Mid(CLIENTE.C_Fecha_Nacimiento, 5, 2) & "-" & Mid(CLIENTE.C_Fecha_Nacimiento, 1, 4))))
            dtFechaNacV.Value = CDate(Mid(CLIENTE.C_Fecha_Nacimiento, 7, 2) & "-" & Mid(CLIENTE.C_Fecha_Nacimiento, 5, 2) & "-" & Mid(CLIENTE.C_Fecha_Nacimiento, 1, 4))
        Else
            dtFechaNacV.Value = DateAdd(DateInterval.Year, -30, DateAdd(DateInterval.Day, 1, Now))
        End If
        'TxtEdad.Text = Trim(CLIENTE.c_Edad)
        txtObsAgen.Text = Trim(GESTION.G_Obs_Agen)

        If perfil = "Regrabador" Then
            Txt_Fono_alt.ReadOnly = False
        Else
            Txt_Fono_alt.ReadOnly = True
        End If


        GESTION.G_Contacto = ""
        GESTION.G_No_Contacto = ""
        GESTION.G_Contacto_Con = ""
        GESTION.G_Contacto_Flujo = ""
        GESTION.G_Motivo_No_Interesa = ""
        GESTION.G_Rut = ""
        GESTION.G_Dv = ""
        GESTION.G_Nombre = ""
        GESTION.G_Paterno = ""
        GESTION.G_Materno = ""
        GESTION.G_Fecha_Nacimiento = ""
        GESTION.G_Calle = ""
        GESTION.G_Nro = ""
        GESTION.G_Referencia = ""
        GESTION.G_Comuna = ""
        GESTION.G_Ciudad = ""
        GESTION.G_Email = ""

        GESTION.G_Fecha_Vta = ""
        GESTION.G_Hora_Vta = ""
        GESTION.G_Fecha_Agen = ""
        GESTION.G_Hora_Agen = ""
        GESTION.G_Obs_Agen = ""
        GESTION.G_Dato1 = ""
        GESTION.G_Dato2 = ""
        GESTION.G_Dato3 = ""
        GESTION.G_Dato4 = ""
        GESTION.G_Dato5 = ""
        GESTION.G_Dato6 = ""


        inicializar_controles_tab()
    End Sub
    ' inicializar controles de gestion en todos los tabs utilizados
    ''' <summary>
    ''' inicializar controles de gestion en todos los tabs utilizados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub inicializar_controles_tab()

        ' >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        'TAB 1
        CmbConecta.Focus()
        CmbConecta.SelectedIndex = 0
        CmbNoConecta.SelectedIndex = 0
        CmbComunicaCon.SelectedIndex = 0
        CmbComunicaTercero.SelectedIndex = 0
        Label11.Visible = False
        CmbNoConecta.Visible = False
        FrmConex.Visible = False
        Label13.Visible = False
        CmbComunicaTercero.Visible = False


        'TAB 2

        lblInteresa.Visible = True
        CmbInteresa.SelectedIndex = 0
        CmbInteresa.Visible = True

        'TAB 3

        txtNombreV.Text = ""
        txtPaternoV.Text = ""
        txtMaternoV.Text = ""
        txtRutV.Text = ""
        txtDvV.Text = ""
        txtEmail.Text = ""
        txtCalleV.Text = ""
        txtNroV.Text = ""
        txtReferenciaV.Text = ""
        txtFonoVenta.Text = ""

        'cmbTipoContrato.SelectedIndex = 0
        If perfil <> "Regrabador" Then

            If dtAdicional.Rows.Count > 0 Then
                dtAdicional.Rows.Clear()
            End If

        End If
        cmbComuna.SelectedIndex = -1
        cmbComuna.SelectedText = ""
        cmbCiudad.SelectedIndex = -1
        cmbCiudad.SelectedText = ""
        cmbCiudad.SelectedText = ""
        cmbCiudad.DataSource = Nothing
        cmbCiudad.ValueMember = Nothing

        'TAB 4
        txtNombreA.Text = ""
        txtPaternoA.Text = ""
        txtMaternoA.Text = ""
        txtRutA.Text = ""
        txtDvA.Text = ""
        cmbParentescoAdic.SelectedIndex = -1
        dtFechaNacAdic.Value = dtFechaNacV.MinDate
        dtFechaNacAdic.MaxDate = DateAdd(DateInterval.Day, -6, Now)




        'TAB 5
        CmbObj.SelectedIndex = 0
        FrmObj.Visible = False
        TxtObj.Text = ""
        If perfil = "Regrabador" Then
            Label26.Visible = False
            cmbNoIntereso.Visible = False
        End If


        'TAB 6
        CmbEstAgenda.SelectedIndex = -1
        FrmAgendamiento.Visible = False
        TxtObsA.Text = ""
        DTFechaAgen.Value = Today
        cmbHora.SelectedIndex = -1
        cmbMin.SelectedIndex = -1
        CmdTerminarA.Visible = True
        CmdSiguienteA.Visible = True



        'TAB 9
        TxtObsAgen2.Text = ""
        DTAgenFecha2.Value = Today
        CmbHora2.SelectedIndex = -1
        CmbMin2.SelectedIndex = -1

        'TAB 10
        cmbAceptaPrima.SelectedIndex = -1
        cmbAceptaContrato.SelectedIndex = -1
        lblCargoTarjeta.Visible = True
        lblAcepta.Visible = True
        cmbAceptaPrima.Visible = True
        cmbAceptaContrato.Visible = True
        Panelotro.Visible = False
        txtNumeroCuenta.Text = ""
        cmbMedioPago.SelectedIndex = -1


        ' inicializar pila para guardar pantallas visitadas
        ' >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        pilaInicializar()
        CmdAtras.Enabled = False
        ' (ocultar todos los tabs menos el del inicio)
        Dim i As Integer
        i = Cuerpo.TabCount - 1
        For i = i To 1 Step -1
            Cuerpo.TabPages.Item(i).Parent = Nothing
        Next i
        If Cuerpo.TabPages.Item(0).Name <> "_Cuerpo_Conex" Then
            Cuerpo.TabPages.Item(0).Parent = Nothing
            Cuerpo.TabPages.Add(_Cuerpo_Conex)
        End If


        Cuerpo.Visible = True

        tmLabelRegrabacion.Enabled = False
        lblRegrabacion.Visible = False
    End Sub
    '***********metodo de boton salir de la aplicacion****************
    Private Sub CmdSalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSalir.Click
        Try
            If MsgBox("¿Está seguro que desea salir de la aplicación?", MsgBoxStyle.YesNo, "CORDIALPHONE") = MsgBoxResult.Yes Then
                grabarCallId("CORTAR", WS_CALL_ID, Fono_A_Llamar, claveRegistroActual)


                If Cuerpo.TabPages.Item(0).Name <> "_Cuerpo_IngresoCli" Then
                    If perfil <> "Regrabador" Then
                        Dim x As UInteger
                        x = Convert.ToUInt32(claveRegistroActual)
                        'biGeneral.respladar_estado(strQueryUpdateBackupRs, x)
                    End If

                End If
                Logear_Usuario(WS_IDUSUARIO, 2)
                If db_central = 4 Then
                    vpPosicion.LogoutTelefonia((vpPosicion.Usuario))
                End If
                End
            End If

        Catch ex As Exception
            MsgBox(Err.Description & " " & " Error : al salir de la aplicación", MsgBoxStyle.Critical, Me.Text)
            Err.Clear()
        End Try

    End Sub
    ''' <summary>
    ''' Metodo para registrar una venta al cual al cliente no se ha contactado y se da por terminada la gestion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Terminar()

        GESTION.G_Estado = "T"
        GESTION.G_Venta = CStr(0)
        GESTION.G_Tiempo_PostView = lblHora.Text + ":" + lblMinutos.Text + ":" + lblSegundos.Text

        If perfil <> "Regrabador" Then

            GESTION.G_IdLlamada = WS_CALL_ID
            biCliente.GuardaDatosCliente(CLIENTE, GESTION)
            biCliente.GuardaDatosLog(claveRegistroActual)
            MsgBox("Fin de la gestión. Presione ACEPTAR para continuar con el siguiente registro.", MsgBoxStyle.Information, "CORDIALPHONE")
            limpiarPrimeraPantalla()
            Buscar_Cliente()
        Else
            RECUPERACION.R_Venta = 0
            RECUPERACION.R_Estado = "T"
            RECUPERACION.R_Fecha_Vta = ""
            RECUPERACION.R_Hora_Vta = ""
            RECUPERACION.R_IdLlamada = WS_CALL_ID
            biGesRes.GuardaClienteGes(CLIENTE, RECUPERACION, GESTION)

            MsgBox("Fin de la gestión. Presione ACEPTAR para salir del formulario.", MsgBoxStyle.Information, csNombreAplicacion)
            limpiarPrimeraPantalla()
            Me.Hide()
            frmRegrabaciones.ShowDialog()
            BuscaGes()

        End If
    End Sub
    '******************Metodo al presionar boton Siguiente de tab Conexion****************************************************************
    Private Sub CmdSiguiente_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSiguiente.Click

        If Trim$(txtCallId.Text) = "" Then
            vpPosicion.CargarPosicion(vpPosicion.Usuario)
            txtCallId.Text = vpPosicion.IDLLAMADA
            WS_CALL_ID = vpPosicion.IDLLAMADA
        End If

        Select Case CmbConecta.SelectedIndex
            Case -1, 0
                MsgBox("Debe selecionar opción si conecta llamada.", vbInformation, "CORDIALPHONE.")
                CmbConecta.Focus()
                Exit Sub

            Case 1

                Select Case CmbComunicaCon.SelectedIndex
                    '0 [No Especificado]
                    '1 COMUNICA CON CLIENTE
                    '2 COMUNICA CON TERCERO VALIDO
                    '3 COMUNICA CON REGISTRO NO VALIDO (NO VIVE/NO TRABAJA AHI)

                    Case -1, 0
                        MsgBox("debe seleccionar con quien se comunica.", vbExclamation, "CORDIALPHONE.")
                        CmbComunicaCon.Focus()
                        Exit Sub

                    Case 1
                        GESTION.G_Contacto = Trim$(CmbConecta.Text)
                        GESTION.G_Contacto_Con = Trim$(CmbComunicaCon.Text)

                        If perfil = "Regrabador" Then
                            Dim clsPoliza As New clsPolizabBI

                            dtgPolizasRegrabacion.DataSource = clsPoliza.ListaPolizas(CLIENTE.C_Id)
                            dtgPolizasRegrabacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                            cmbReconoce.Visible = True
                            Label36.Visible = True
                            CmbInteresa.Visible = False
                            lblInteresa.Visible = False
                            limpiaControlRegrabacion()

                            Cuerpo.TabPages.Add(_Cuerpo_Polizas)
                            'Cuerpo.TabPages.Add(_Cuerpo_MtvoLL)
                            Cuerpo.TabPages.Item(0).Parent = Nothing
                            guardarPantallaAnterior(1)
                        Else
                            Dim clsPoliza As New clsPolizabBI
                            Dim DT As New DataTable
                            DT = clsPoliza.ListaPolizas(CLIENTE.C_Id)

                            llenarTipoContrato()

                            If DT.Rows.Count <> 0 Then

                                MsgBox("Cliente ya cuenta con polizas inscritas, se pasara a la pantalla de polizas para el pago", vbInformation, "CordialPhone")

                                dtgPolizasVigentes.DataSource = DT
                                dtgPolizasVigentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                                For i As Integer = 0 To dtgPolizasVigentes.Rows.Count - 1
                                    If dtgPolizasVigentes.Rows(i).Cells(0).Value = "NO PAGADO" Then
                                        dtgPolizasVigentes.Rows(i).Cells(0).Style.ForeColor = Color.Red
                                    ElseIf dtgPolizasVigentes.Rows(i).Cells(0).Value = "POLIZA PAGADA" Then
                                        dtgPolizasVigentes.Rows(i).Cells(0).Style.ForeColor = Color.Green
                                    End If
                                Next

                                clsScript = CargaScript(6)
                                WebBrowsercierre.DocumentText = clsScript.contenidoScript

                                Cuerpo.TabPages.Add(_Cuerpo_UltInfo)
                                Cuerpo.TabPages.Item(0).Parent = Nothing
                                guardarPantallaAnterior(1)

                            Else

                                cmbReconoce.Visible = False
                                Label36.Visible = False
                                CmbInteresa.Visible = True
                                lblInteresa.Visible = True


                                clsScript = CargaScript(2)
                                wbScriptPresentacion.DocumentText = clsScript.contenidoScript

                                llenarTipoContrato()
                                dtCotizaciones.DataSource = biCLSPoliza.cargaCotizacionesCliente(CLIENTE.C_Id)
                                dtCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


                                Cuerpo.TabPages.Add(_Cuerpo_IngresoCli)
                                'Cuerpo.TabPages.Add(_Cuerpo_MtvoLL)
                                Cuerpo.TabPages.Item(0).Parent = Nothing
                                guardarPantallaAnterior(1)

                            End If




                        End If




                            Case 3
                        GESTION.G_Contacto = Trim$(CmbConecta.Text)
                        GESTION.G_Contacto_Con = Trim$(CmbComunicaCon.Text)

                        If perfil = "Regrabador" Then
                            'CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = 5 'no contactado para regrabacion                            
                        End If

                        LblFinNoC.Text = ScriptLblFinNoC()
                        Cuerpo.TabPages.Add(_Cuerpo_FinNC)
                        Cuerpo.TabPages.Item(0).Parent = Nothing
                        guardarPantallaAnterior(1)

                    Case 4

                        GESTION.G_Contacto = Trim$(CmbConecta.Text)
                        GESTION.G_Contacto_Con = Trim$(CmbComunicaCon.Text)

                        If perfil = "Regrabador" Then
                            Cuerpo.TabPages.Add(_Cuerpo_Agendar)
                        Else
                            Cuerpo.TabPages.Add(_Cuerpo_Agenda2)
                        End If

                        Cuerpo.TabPages.Item(0).Parent = Nothing
                        guardarPantallaAnterior(1)

                    Case 2

                        Select Case CmbComunicaTercero.SelectedIndex
                            '0  [No Especificado]
                            '1  TERCERO PIDE DEJAR PENDIENTE
                            '2  VIAJE
                            '3  FALLECIDO
                            '4  NO VIVE AHÍ
                            '5  PROBLEMA POR HORARIO
                            '6  NO DESEA CONTESTAR

                            Case -1, 0
                                MsgBox("Debe seleecionar motivo No comunica.", vbExclamation, "CORDIALPHONE.")
                                CmbComunicaTercero.Focus()
                                Exit Sub

                            Case 1, 2, 5
                                GESTION.G_Contacto = Trim$(CmbConecta.Text)
                                GESTION.G_Contacto_Con = Trim$(CmbComunicaCon.Text)
                                GESTION.G_Contacto_Flujo = Trim$(CmbComunicaTercero.Text)
                                Cuerpo.TabPages.Add(_Cuerpo_Agendar)
                                Cuerpo.TabPages.Item(0).Parent = Nothing
                                guardarPantallaAnterior(1)

                            Case 3, 4, 6
                                If perfil = "Regrabador" Then
                                    '   CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = 5 'no contactado para regrabacion                                    
                                End If
                                GESTION.G_Contacto = Trim$(CmbConecta.Text)
                                GESTION.G_Contacto_Con = Trim$(CmbComunicaCon.Text)
                                GESTION.G_Contacto_Flujo = Trim$(CmbComunicaTercero.Text)

                                LblFinNoC.Text = ScriptLblFinNoC()
                                Cuerpo.TabPages.Add(_Cuerpo_FinNC)
                                Cuerpo.TabPages.Item(0).Parent = Nothing
                                guardarPantallaAnterior(1)
                        End Select
                End Select

            Case 2
                '0[No Especificado]
                '1 OCUPADO
                '2 FUERA DE SERVICIO
                '3 BUZÓN DE VOZ
                '4 NÚMERO NO VÁLIDO
                '5 NO CONTESTA
                '6 FAX O MODEM
                '7 CONGESTIONADO
                '8 FUERA DE ÁEREA O APAGADO

                Select Case CmbNoConecta.SelectedIndex
                    Case -1, 0
                        MsgBox("Debe seleccionar el motivo por el cual No Conecta.", vbExclamation, "CORDIALPHONE.")
                        CmbNoConecta.Focus()
                        Exit Sub

                    'Case 1, 3, 5, 7, 8

                    '    GESTION.G_Contacto = Trim$(CmbConecta.Text)
                    '    GESTION.G_No_Contacto = Trim$(CmbNoConecta.Text)

                    '    If perfil = "Regrabador" Then
                    '        Cuerpo.TabPages.Add(_Cuerpo_Agendar)
                    '    Else
                    '        Cuerpo.TabPages.Add(_Cuerpo_Agenda2)
                    '    End If

                    '    Cuerpo.TabPages.Item(0).Parent = Nothing
                    '    guardarPantallaAnterior(1)

                    Case 2, 4, 6, 1, 3, 5, 7, 8, 9
                        GESTION.G_Contacto = Trim$(CmbConecta.Text)
                        GESTION.G_No_Contacto = Trim$(CmbNoConecta.Text)
                        Terminar()
                End Select
        End Select

    End Sub
    '************************************METODO DE BOTON SIGUIENTE TAB MOTIVO LLAMADO******************************
    Private Sub CmdSiguiente1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSiguiente1.Click

        If db_central = 4 And Trim(txtCallId.Text) = "" Then
            vpPosicion.CargarPosicion((vpPosicion.Usuario))
            txtCallId.Text = vpPosicion.IDLLAMADA
            WS_CALL_ID = vpPosicion.IDLLAMADA
        End If
        If perfil <> "Regrabador" Then

            '0 [No Especificado]
            '1 Interesa
            '2 No Interesa
            '3 Lo Pensara
            Select Case CmbInteresa.SelectedIndex
                Case 0, -1
                    MsgBox("Selecione opción si cliente interesa Seguro", MsgBoxStyle.Exclamation, csNombreAplicacion)
                    CmbInteresa.Focus()
                    Exit Sub
                Case 1

                    llenarTipoContrato()
                    dtCotizaciones.DataSource = biCLSPoliza.cargaCotizacionesCliente(CLIENTE.C_Id)
                    dtCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                    clsScript = CargaScript(2)
                    wbScriptPresentacion.DocumentText = clsScript.contenidoScript

                    Cuerpo.TabPages.Add(_Cuerpo_IngresoCli)
                    Cuerpo.TabPages.Item(0).Parent = Nothing
                    guardarPantallaAnterior(2)


                Case 2 ' NO
                    GESTION.G_Contacto_Flujo = Trim(CmbInteresa.Text)
                    Cuerpo.TabPages.Add(_Cuerpo_Objeciones)
                    Cuerpo.TabPages.Item(0).Parent = Nothing
                    guardarPantallaAnterior(2)

                Case 3 'lo pensara

                    GESTION.G_Contacto_Flujo = Trim(CmbInteresa.Text)
                    Cuerpo.TabPages.Add(_Cuerpo_Agenda2)
                    Cuerpo.TabPages.Item(0).Parent = Nothing
                    guardarPantallaAnterior(2)
            End Select
        Else

            Select Case cmbReconoce.SelectedIndex
                '0 [No Especificado]
                '1 Si
                '2 No
                Case -1, 0
                    MsgBox("Selecione si cliente reconoce la venta", vbExclamation, "CORDIALPHONE.")
                    cmbReconoce.Focus()
                    Exit Sub
                Case 1
                    RECUPERACION.R_Reconoce = cmbReconoce.Text

                    Select Case CmbInteresa.SelectedIndex
                        Case -1, 0
                            MsgBox("Selecione si cliente acepta seguro", vbExclamation, "CORDIALPHONE.")
                            CmbInteresa.Focus()
                            Exit Sub
                        Case 1
                            GESTION.G_Contacto_Flujo = CmbInteresa.Text
                            Cuerpo.TabPages.Add(_Cuerpo_DatosCli)
                            Cuerpo.TabPages.Item(0).Parent = Nothing
                            AsignadatosCliGes()
                            guardarPantallaAnterior(2)

                        Case 2 'no interesa
                            '   CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = 3
                            GESTION.G_Contacto_Flujo = CmbInteresa.Text
                            Cuerpo.TabPages.Add(_Cuerpo_Objeciones)
                            Cuerpo.TabPages.Item(0).Parent = Nothing
                            guardarPantallaAnterior(2)

                        Case 3 'Lo pensara
                            GESTION.G_Contacto_Flujo = CmbInteresa.Text
                            Cuerpo.TabPages.Add(_Cuerpo_Agenda2)
                            Cuerpo.TabPages.Item(0).Parent = Nothing
                            guardarPantallaAnterior(2)

                    End Select


                Case 2
                    RECUPERACION.R_Reconoce = cmbReconoce.Text
                    GESTION.G_Contacto_Flujo = ""
                    'CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = 7
                    'CLIENTE.CLI_RECONOCEVTA = ComboBoxReconoce.Text
                    Cuerpo.TabPages.Add(_Cuerpo_Objeciones)
                    Cuerpo.TabPages.Item(0).Parent = Nothing
                    guardarPantallaAnterior(2)

            End Select
        End If
    End Sub

    Private Sub llenarTipoContrato()

        vgListTipoContrato = biClsTipoContrato.ListaTipoContratoPorCampania(vgCampania.idCRM)
        vgFuncionComun.llenaComboBox(cmbTipoContratoCotiza, "nombreTipoContrato", "idTipoContrato", vgListTipoContrato.ToArray)

    End Sub

    ''' <summary>
    ''' metodo para hacer visible ciertos controles de el tab Motivo de llamado cuando el perfil sea de regrabador
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ocultar_cmbopcion()
        cmbReconoce.Visible = True
        Label36.Visible = True
    End Sub
    '******************metodo de boton siguiente tab manejo de objeciones ***************************************
    Private Sub CmdSiguiente11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSiguiente11.Click
        If perfil <> "Regrabador" Then
            If CmbObj.SelectedIndex <= 0 Then
                MsgBox("Seleccione porque el cliente No desea contratar seguro.", MsgBoxStyle.Exclamation, csNombreAplicacion)
                CmbObj.Focus()
                Exit Sub
            Else
                ' CLIENTE.cli_nointereso = cmbNoIntereso.Text
            End If

            If CmbObj.SelectedIndex <= 0 Then
                MsgBox("Debe ingresar observacion", MsgBoxStyle.Exclamation, csNombreAplicacion)
                CmbObj.Focus()
            Else
                ' CLIENTE.cli_aobsmtvo_nointeresa = TxtObj.Text
                GESTION.G_Motivo_No_Interesa = CmbObj.Text
                LblFinNoC.Text = ScriptLblFinNoC()
                Cuerpo.TabPages.Add(_Cuerpo_FinNC)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(10)
            End If
        Else

            If CmbObj.SelectedIndex <= 0 Then
                MsgBox("Debe ingresar observacion", MsgBoxStyle.Exclamation, csNombreAplicacion)
                CmbObj.Focus()
            Else
                'CLIENTE.CLI_OBSERVACION = TxtObj.Text
                RECUPERACION.R_Motivo_No_Interesa = CmbObj.Text
                LblFinNoC.Text = ScriptLblFinNoC()
                Cuerpo.TabPages.Add(_Cuerpo_FinNC)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(10)
            End If
        End If

    End Sub


    '********************metodo de boton siguiente de tab toma de datos********************************
    Private Sub CmdSiguiente2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSiguiente2.Click
        If db_central = 4 And Trim(txtCallId.Text) = "" Then
            vpPosicion.CargarPosicion((vpPosicion.Usuario))
            txtCallId.Text = vpPosicion.IDLLAMADA
            WS_CALL_ID = vpPosicion.IDLLAMADA
        End If

        Dim clsPoliza As New clsPolizabBI

        If ValidaInformacion() Then



            If perfil <> "Regrabador" Then


                Dim dt As New DataTable
                dt = clsPoliza.ValidarPoliza(txtRutV.Text, CLIENTE.C_Id)
                If dt.Rows.Count > 0 Then

                    MsgBox("Cliente ya se encuentra ingresado como poliza en la venta" & vbNewLine & "Puede avanzar sin ingresar la poliza si desea", vbInformation, "CordialPhone")
                    btnAvanzarSinIngresar.Visible = True
                    Exit Sub

                End If

                GESTION.G_Nombre = Trim(Replace(Trim(UCase(txtNombreV.Text)), "'", "´"))
                GESTION.G_Paterno = Trim(Replace(Trim(UCase(txtPaternoV.Text)), "'", "´"))
                GESTION.G_Materno = Trim(Replace(Trim(UCase(txtMaternoV.Text)), "'", "´"))

                GESTION.G_Rut = Trim(txtRutV.Text)
                GESTION.G_Dv = Trim(txtDvV.Text)
                GESTION.G_Fecha_Nacimiento = dtFechaNacV.Value.ToString("yyyyMMdd")
                GESTION.G_Fono_Contacto = Trim(txtFonoVenta.Text)

                If txtEmail.Text = "" Then

                    GESTION.G_Email = ""
                Else
                    GESTION.G_Email = Replace(Replace(Trim(txtEmail.Text), "'", "´"), " ", "")
                End If

                GESTION.G_Sexo = CmbSexo.Text

                GESTION.G_Calle = Trim(UCase(Replace(txtCalleV.Text, "'", "`")))
                GESTION.G_Nro = Trim(Replace(txtNroV.Text, "'", "`"))
                GESTION.G_Referencia = Trim$(Replace(txtReferenciaV.Text, "'", "`"))

                Dim daCiudad As New clsCiudadBI
                Dim eCiudad As New eCiudad
                GESTION.G_Comuna = Trim(cmbComuna.Text)
                GESTION.G_Ciudad = Trim(cmbCiudad.Text)

                GESTION.G_Prima_Uf = lblPrimaUF.Text
                GESTION.G_Prima_Pesos = lblPrimaPesos.Text

                GESTION.G_Dato1 = txtPesoCliente.Text
                GESTION.G_Dato2 = mskEstaturaCliente.Text
                GESTION.G_Dato3 = cmbIsapreCliente.Text
                GESTION.G_Dato4 = txtRutPagador.Text & "-" & txtDvPagador.Text
                GESTION.G_Dato5 = txtNombrePagador.Text
                GESTION.G_Dato6 = txtDPSCliente.Text.Trim


                GESTION.G_Plan = planCotiza
                GESTION.G_TipoContrato = tipoContratoCotiza



                Dim idPoliza As Integer
                idPoliza = clsPoliza.guardaPolizas(GESTION, CLIENTE)
                InsertaAdicionales(idPoliza)


                dtgPolizasVigentes.DataSource = clsPoliza.ListaPolizas(CLIENTE.C_Id)
                dtgPolizasVigentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                For i As Integer = 0 To dtgPolizasVigentes.Rows.Count - 1
                    If dtgPolizasVigentes.Rows(i).Cells(0).Value = "NO PAGADO" Then
                        dtgPolizasVigentes.Rows(i).Cells(0).Style.ForeColor = Color.Red
                    ElseIf dtgPolizasVigentes.Rows(i).Cells(0).Value = "POLIZA PAGADA" Then
                        dtgPolizasVigentes.Rows(i).Cells(0).Style.ForeColor = Color.Green
                    End If
                Next

                poblarComboboxGiftCard()

                clsScript = CargaScript(6)
                WebBrowsercierre.DocumentText = clsScript.contenidoScript

                Cuerpo.TabPages.Add(_Cuerpo_UltInfo)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(3)


            Else
                GESTION.G_Nombre = Replace(Trim(UCase(txtNombreV.Text)), "'", "´")
                GESTION.G_Paterno = Replace(Trim(UCase(txtPaternoV.Text)), "'", "`")
                GESTION.G_Paterno = Replace(Trim(UCase(txtMaternoV.Text)), "'", "`")
                GESTION.G_Rut = Trim(txtRutV.Text)
                GESTION.G_Sexo = Trim(CmbSexo.Text)
                GESTION.G_Calle = Trim(UCase(Replace(txtCalleV.Text, "'", "`")))
                GESTION.G_Nro = Trim(Replace(txtNroV.Text, "'", "`"))
                GESTION.G_Comuna = Trim(cmbComuna.Text)
                GESTION.G_Ciudad = Trim(cmbCiudad.Text)
                GESTION.G_IdComuna = cmbComuna.SelectedValue
                GESTION.G_IdCiudad = cmbCiudad.SelectedValue
                GESTION.G_Fono_Contacto = Trim(txtFonoVenta.Text)


                If txtEmail.Text = "" Then
                    GESTION.G_Email = ""
                Else
                    GESTION.G_Email = Replace(Trim(txtEmail.Text), "'", "´")
                End If

                If txtReferenciaV.Text = "" Then
                    GESTION.G_Referencia = ""
                Else
                    GESTION.G_Referencia = Trim$(Replace(txtReferenciaV.Text, "'", "`"))
                End If

                GESTION.G_Dato1 = txtPesoCliente.Text
                GESTION.G_Dato2 = mskEstaturaCliente.Text
                GESTION.G_Dato3 = cmbIsapreCliente.Text
                GESTION.G_Dato4 = txtRutPagador.Text & "-" & txtDvPagador.Text
                GESTION.G_Dato5 = txtNombrePagador.Text
                GESTION.G_Dato6 = txtDPSCliente.Text.Trim


                Dim correcto As Boolean
                correcto = clsPoliza.actualizaDatosPoliza(GESTION, CLIENTE)

                If correcto = True Then
                    MsgBox("Poliza Fue actualizada correctamente", vbInformation, "CORDIALPHONE")
                End If


                dtgPolizasRegrabacion.DataSource = clsPoliza.ListaPolizas(CLIENTE.C_Id)
                dtgPolizasRegrabacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                'poblarComboboxGiftCard()

                Cuerpo.TabPages.Add(_Cuerpo_Polizas)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(3)

            End If



        End If
    End Sub


    Private Sub CmdSiguienteA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSiguienteA.Click
        Select Case CmbEstAgenda.SelectedIndex
            Case -1
                MsgBox("Debe seleccionar una opción para el estado del agendamiento.", MsgBoxStyle.Information, csNombreAplicacion)
                CmbEstAgenda.Focus()
                Exit Sub

            Case 2
                If perfil = "Regrabador" Then
                    GESTION.G_Contacto_Flujo = Trim(CmbEstAgenda.Text)
                End If

                'CLIENTE.cli_agen_estado = Trim(CmbEstAgenda.Text)
                LblFinNoC.Text = ScriptLblFinNoC()
                Cuerpo.TabPages.Add(_Cuerpo_FinNC)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(11)
        End Select
    End Sub
    '************METODO DE BOTON TERMINAR DE TAB AGENDAR**********************************
    Private Sub CmdTerminarA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdTerminarA.Click
        If perfil <> "Regrabador" Then
            Select Case CmbEstAgenda.SelectedIndex
                Case -1
                    MsgBox("Debe seleccionar una opción para el estado del agendamiento.", MsgBoxStyle.Information, csNombreAplicacion)
                    CmbEstAgenda.Focus()
                    Exit Sub
                Case 0, 1
                    'UPGRADE_WARNING: El comportamiento de DateDiff puede ser diferente. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
                    If DateDiff(Microsoft.VisualBasic.DateInterval.Day, CDate(FechaServidor()), DTFechaAgen.Value) > 7 Then
                        MsgBox("La fecha de agendamiento debe ser menor o igual a 1 semana.", MsgBoxStyle.Information, csNombreAplicacion)
                        Exit Sub
                    End If

                    If cmbHora.SelectedIndex = -1 Or cmbMin.SelectedIndex = -1 Then
                        MsgBox("Ingrese hora para agendar nuevo llamado.", MsgBoxStyle.Information, csNombreAplicacion)
                        cmbHora.Focus()
                        Exit Sub
                    Else
                        'CLIENTE.cli_agen_estado = Trim(CmbEstAgenda.Text)
                        GESTION.G_Fecha_Agen = DTFechaAgen.Value.ToString("yyyyMMdd")
                        GESTION.G_Hora_Agen = cmbHora.Text & cmbMin.Text
                        GESTION.G_Obs_Agen = Trim(Replace(TxtObsA.Text, "'", "`"))
                        GESTION.G_IdLlamada = WS_CALL_ID
                        GESTION.G_Venta = 0
                        GESTION.G_Estado = IIf(GESTION.G_Intento >= CLIENTE.C_Intentos_Max, "T", "A")

                        biCliente.GuardaDatosCliente(CLIENTE, GESTION)
                        biCliente.GuardaDatosLog(claveRegistroActual)
                        MsgBox("Fin de la gestión. Presione ACEPTAR para continuar con el siguiente registro.", MsgBoxStyle.Information, csNombreAplicacion)
                        limpiarPrimeraPantalla()
                        Buscar_Cliente()
                    End If


            End Select
        Else
            Select Case CmbEstAgenda.SelectedIndex
                Case -1
                    MsgBox("Debe seleccionar una opción para el estado del agendamiento.", MsgBoxStyle.Information, csNombreAplicacion)
                    CmbEstAgenda.Focus()
                    Exit Sub
                Case 0, 1
                    'UPGRADE_WARNING: El comportamiento de DateDiff puede ser diferente. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
                    If DateDiff(Microsoft.VisualBasic.DateInterval.Day, CDate(FechaServidor()), DTFechaAgen.Value) > 7 Then
                        MsgBox("La fecha de agendamiento debe ser menor o igual a 1 semana.", MsgBoxStyle.Information, csNombreAplicacion)
                        Exit Sub
                    End If

                    If cmbHora.SelectedIndex = -1 Or cmbMin.SelectedIndex = -1 Then
                        MsgBox("Ingrese hora para agendar nuevo llamado.", MsgBoxStyle.Information, csNombreAplicacion)
                        cmbHora.Focus()
                        Exit Sub
                    Else
                        'CLIENTE.cli_agen_estado = Trim(CmbEstAgenda.Text)
                        RECUPERACION.R_Fecha_Agen = DTFechaAgen.Value.ToString("yyyyMMdd")
                        RECUPERACION.R_Hora_Agen = cmbHora.Text & cmbMin.Text
                        RECUPERACION.R_Obs_Agen = Trim(Replace(TxtObsA.Text, "'", "`"))
                        RECUPERACION.R_IdLlamada = WS_CALL_ID
                        RECUPERACION.R_Venta = 0
                        RECUPERACION.R_Estado = IIf(GESTION.G_Intento >= CLIENTE.C_Intentos_Max, "T", "A")
                        ' CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = "2"
                        RECUPERACION.R_Fecha_Vta = ""
                        RECUPERACION.R_Hora_Vta = ""

                        biGesRes.GuardaClienteGes(CLIENTE, RECUPERACION, GESTION)
                        ' biGesRes.ActualizaClienteAgen(CLIENTE.C_Id, CLIENTE.CLI_ESTADO_OBJECION_CALIDAD, CLIENTE.CLI_CALL_ID_CALIDAD)
                        MsgBox("Fin de la gestión. Presione ACEPTAR para salir del formulario.", MsgBoxStyle.Information, csNombreAplicacion)
                        limpiarPrimeraPantalla()
                        Me.Hide()
                        frmRegrabaciones.ShowDialog()
                        BuscaGes()
                    End If
                Case 2
                    'CLIENTE.cli_agen_estado = Trim$(CmbEstAgenda.Text)
                    Terminar()
            End Select
        End If

    End Sub
    'UPGRADE_WARNING: Form evento frmVenta.Activate tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmVenta_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        ' verifica si es la primera vez que se activa el formulario
        ' en este caso busca un cliente inmediatamente y luego baja el flag
        If flag_primeravez Then
            flag_primeravez = False
        End If
    End Sub

    Private Sub frmVenta_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        flag_primeravez = True
        ModGeneral.Main()
        ' Me.Text = vgCampania.calNombre & " " & perfil & "NEW Versión: " & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString _
        '  & "." & My.Application.Info.Version.Revision.ToString

        If perfil = "Regrabador" Then
            frmRegrabaciones.ShowDialog()
        End If

        'asignamos  la fecha maxima ingreso de fecha 
        'dtFechaNac.MaxDate = DateAdd(DateInterval.Year, -18, DateAdd(DateInterval.Day, 1, Now))
        'dtFechaNac.MaxDate = DateAdd(DateInterval.Year, -18, DateAdd(DateInterval.Day, 1, Now))

        'asignamos  la fecha minima ingreso de fecha
        dtFechaNacV.MinDate = dtFechaNacV.MinDate

        Fono_A_Llamar = ""
        vgListEdoFono = biClsEdoFono.listarEstadoFono

        Dim daComuna As New clsComunaBI
        Dim daCiudad As New clsCiudadBI
        vgListComuna = daComuna.listarComuna()
        vgListCiudad = daCiudad.ListaCiudad()
        vgFuncionComun.llenaComboBox(cmbComuna, "nombreComuna", "idComuna", vgListComuna.ToArray)
        cmbComuna.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbComuna.AutoCompleteSource = AutoCompleteSource.ListItems


        Dim listPatertescocontact As New List(Of eTipoParentesco)
        Dim parentesco As New clsParentescoCampaniaBI

        'listParentescoCampania = biClsParentescoCampania.BuscarParentescoPorId(vgCampania.calCodigo, 3)
        'vgFuncionComun.llenaComboBox(cmbParentesco, "nombreParentesco", "idParentesco", listParentescoCampania.ToArray)
        'vgListParentescoCampania = biClsParentescoCampania.BuscarParentescoPorId(vgCampania.calCodigo, 2)

        Dim listMotivoRechazo As New List(Of eMotivoRechazo)
        Dim biMotivoRechazo As New clsMotivoRechazoBI
        listMotivoRechazo = biMotivoRechazo.BuscarMotivoRechazoPorSponsor(vgCampania.idCRM)
        vgFuncionComun.llenaComboBox(CmbObj, "nombreMotivosObjecion", "idMotivosObjecion", listMotivoRechazo.ToArray)

        Dim listExclusion As New List(Of eExclusion)
        Dim biExclusion As New clsExclusionBI
        listExclusion = biExclusion.listarExclusiones(vgCampania.idCRM)
        vgFuncionComun.llenaCheckBox(frmExclusiones.chkListBoxExclusiones, listExclusion)

        listaCorreoInvalido.Clear()
        listaCorreoInvalido = biCorreoInv.listarCorreosInvalido


        If perfil = "Regrabador" Then
            CmbNoConecta.Items.Add("No contesta último intento")
            BuscaGes()
        ElseIf perfil = "Ejecutivo" Then
            Buscar_Cliente()

        End If

        System.Windows.Forms.Application.DoEvents()
    End Sub

    Public Sub BuscaGes()
        Dim dt As New DataTable
        dt = biCliente.Buscar_Gescliente(WS_IDUSUARIO, GesId)
        ''VALIDAR DATO
        flg_progresivo_activado = True

        ' lblEstadoLlamada.Text = ""
        WS_CALL_ID = ""
        txtCallId.Text = ""

        CLIENTE = inicializarClienteRecuperacion(dt.Rows(0))
        GESTION = inicializarGestionRecuperacion(dt.Rows(0))

        Rellenar_fonos_Regrabaciones()

        inicializarControlesGes()
        'llamarProgresivoFijo()
        llamarProgresivo()
    End Sub

    Public Sub Rellenar_fonos_Regrabaciones()
        Txt_Fono1.Text = Trim(CLIENTE.C_Telefono1)
        flg_fono1 = Not esVacio(CLIENTE.C_Telefono1)
        flg_EsCelu1 = esCelular(CLIENTE.C_Telefono1)

        Txt_Fono2.Text = Trim(CLIENTE.C_Telefono2)
        flg_fono2 = Not esVacio(CLIENTE.C_Telefono2)
        flg_EsCelu2 = esCelular(CLIENTE.C_Telefono2)

        Txt_Fono3.Text = Trim(CLIENTE.C_Telefono3)
        flg_fono3 = Not esVacio(CLIENTE.C_Telefono3)
        flg_EsCelu3 = esCelular(CLIENTE.C_Telefono3)

        Txt_Fono4.Text = Trim(CLIENTE.C_Telefono4)
        flg_fono4 = Not esVacio(CLIENTE.C_Telefono4)
        flg_EsCelu4 = esCelular(CLIENTE.C_Telefono4)

        Txt_Fono5.Text = Trim(CLIENTE.C_Telefono5)
        flg_fono5 = Not esVacio(CLIENTE.C_Telefono5)
        flg_EsCelu5 = esCelular(CLIENTE.C_Telefono5)

        Txt_Fono6.Text = Trim(CLIENTE.C_Telefono6)
        flg_fono6 = Not esVacio(CLIENTE.C_Telefono6)
        flg_EsCelu6 = esCelular(CLIENTE.C_Telefono6)

        Txt_Fono_alt.Text = Trim(CLIENTE.C_Fono_Alternativo)
        flg_fonoalt = Not esVacio(CLIENTE.C_Fono_Alternativo)
        flg_EsCeluAlt = esCelular(CLIENTE.C_Fono_Alternativo)

        txt_FonoVenta.Text = Trim(GESTION.G_Fono_Contacto)
        flg_fonoVent = Not esVacio(GESTION.G_Fono_Contacto)
        flg_EsCeluVent = esCelular(GESTION.G_Fono_Contacto)

    End Sub

    Private Sub llenaCombobox(ByVal cmbParCombo As ComboBox, ByVal dt As DataTable, ByVal strDisplay As String, ByVal strValue As String)

        With cmbParCombo
            .ValueMember = strValue
            .DisplayMember = strDisplay
            .DataSource = dt
        End With

    End Sub

    Private Function TipoDato(ByVal typTipoDato As System.Type) As SqlDbType
        Try

            Select Case typTipoDato.ToString
                Case "System.String"
                    Return SqlDbType.VarChar
                Case "System.Int32"
                    Return SqlDbType.Int
                Case "System.Int64"
                    Return SqlDbType.BigInt
                Case "System.Double"
                    Return SqlDbType.Decimal
                Case "System.DateTime"
                    Return SqlDbType.DateTime
                Case "System.Boolean"
                    Return SqlDbType.Bit
                Case "System.Char"
                    Return SqlDbType.Char
                Case "System.Decimal"
                    Return SqlDbType.Decimal
            End Select

        Catch ex As Exception

        End Try

    End Function

    Public Function fecha_yyyymmdd(ByRef dia As String, ByRef mes As String, ByRef ano As String) As String
        If Len(Trim(dia)) = 1 Then
            dia = "0" & dia
        End If
        If Len(Trim(mes)) = 1 Then
            mes = "0" & mes
        End If

        fecha_yyyymmdd = ano & mes & dia
    End Function
    Private Sub tmCallID_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If db_central = 4 Then
            If CmdLlamar1.Text = "Colgar" Or CmdLlamar2.Text = "Colgar" Or CmdLlamar3.Text = "Colgar" Or CmdLlamar4.Text = "Colgar" Or CmdLlamar5.Text = "Colgar" Or CmdLlamar6.Text = "Colgar" Or CmdLlamarAlt.Text = "Colgar" Then
                If Trim(txtCallId.Text) = "" Then
                    vpPosicion.CargarPosicion((vpPosicion.Usuario))
                    txtCallId.Text = vpPosicion.IDLLAMADA
                    WS_CALL_ID = vpPosicion.IDLLAMADA

                End If
            End If
        End If
    End Sub

    Private Sub tmrEstadoLlamada_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrEstadoLlamada.Tick
        On Error Resume Next
        'lblEstadoLlamada.Text = EstadoLLamada()
        If db_central = 4 Then
            If Not vpPosicion.EvaluaEstado((vpPosicion.Usuario)) Then
                Corta_Anteriores()
            End If
        End If
    End Sub


    Private Sub TxtObj_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtObj.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = CaracterValido(KeyAscii)
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TxtObsA_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtObsA.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = CaracterValido(KeyAscii)
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TxtObsAgen2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtObsAgen2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = CaracterValido(KeyAscii)
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Txt_Fono_alt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Fono_alt.TextChanged
        Try
            If Txt_Fono_alt.Text <> "" Then
                CLIENTE.C_Fono_Alternativo = Txt_Fono_alt.Text
            Else
                CLIENTE.C_Fono_Alternativo = ""
            End If
        Catch ex As Exception

        End Try

    End Sub
    '*******************METODO AL PRESIONAR BOTON TERMINAR DE TAB FIN NO CONTRATA**********************************
    Private Sub CmdTerminarNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTerminarNC.Click
        If perfil <> "Regrabador" Then
            GESTION.G_IdLlamada = WS_CALL_ID
            GESTION.G_Estado = "T"
            GESTION.G_Venta = "0"
            GESTION.G_Tiempo_PostView = lblHora.Text + ":" + lblMinutos.Text + ":" + lblSegundos.Text

            biCliente.GuardaDatosCliente(CLIENTE, GESTION)
            biCliente.GuardaDatosLog(claveRegistroActual)
            MsgBox("Fin de la gestión. Presione ACEPTAR para continuar con el siguiente registro.", MsgBoxStyle.Information, "CORDIALPHONE")
            limpiarPrimeraPantalla()
            Buscar_Cliente()
        Else

            RECUPERACION.R_Estado = "T"
            RECUPERACION.R_Fecha_Vta = ""
            RECUPERACION.R_Hora_Vta = ""
            RECUPERACION.R_IdLlamada = WS_CALL_ID
            RECUPERACION.R_Venta = 0
            ' CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = "2"

            biGesRes.GuardaClienteGes(CLIENTE, RECUPERACION, GESTION)
            ' biGesRes.ActualizaClienteAgen(CLIENTE.C_Id, CLIENTE.CLI_ESTADO_OBJECION_CALIDAD, CLIENTE.CLI_CALL_ID_CALIDAD)
            MsgBox("Fin de la gestión. Presione ACEPTAR para salir del formulario.", MsgBoxStyle.Information, csNombreAplicacion)
            limpiarPrimeraPantalla()
            Me.Hide()
            frmRegrabaciones.ShowDialog()
            BuscaGes()

        End If

    End Sub

    '*************METODO DE BOTON TERMINAR EN TAB AGENDAR 2********************************
    Private Sub CmdTerminarA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTerminarA2.Click
        If CmdLlamar1.Text = "COLGAR" Or CmdLlamar2.Text = "COLGAR" Or CmdLlamar3.Text = "COLGAR" Or CmdLlamar4.Text = "COLGAR" Or CmdLlamar5.Text = "COLGAR" Or CmdLlamar6.Text = "COLGAR" Or CmdLlamarAlt.Text = "COLGAR" Then
            MsgBox("Debe Colgar la llamada antes de terminar", vbExclamation, csNombreAplicacion)
            Exit Sub
        End If

        If perfil <> "Regrabador" Then
            If CmbHora2.SelectedIndex = -1 Or CmbMin2.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar FECHA y HORA ", vbInformation, "CORDIALPHONE")
                CmbHora2.Focus()
                Exit Sub
            Else
                GESTION.G_IdLlamada = WS_CALL_ID
                GESTION.G_Estado = IIf(GESTION.G_Intento >= CLIENTE.C_Intentos_Max, "T", "A")
                GESTION.G_Obs_Agen = Trim$(Replace(TxtObsAgen2.Text, "'", "´"))
                GESTION.G_Fecha_Agen = DTAgenFecha2.Value.ToString("yyyyMMdd")
                GESTION.G_Hora_Agen = Trim(CmbHora2.Text) & Trim(CmbMin2.Text)
                GESTION.G_Tiempo_PostView = lblHora.Text + ":" + lblMinutos.Text + ":" + lblSegundos.Text

                GESTION.G_Venta = 0
                Dim fecha_agendamiento As String
                fecha_agendamiento = Format(DTAgenFecha2.Value, "dd/MM/yyyy") & " a las " & CmbHora2.Text & ":" & CmbMin2.Text & " Hrs."

                biCliente.GuardaDatosCliente(CLIENTE, GESTION)
                'biCliente.GuardaDatosLog(claveRegistroActual)
                MsgBox("Fin de la gestión. Presione ACEPTAR para continuar con el siguiente registro.", vbInformation, "CORDIALPHONE")
                limpiarPrimeraPantalla()
                Buscar_Cliente()
                'Cuerpo.TabPages.Add(_Cuerpo_Conex)
                'Cuerpo.TabPages.Item(0).Parent = Nothing
            End If
        Else
            If CmbHora2.SelectedIndex = -1 Or CmbMin2.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar FECHA y HORA ", vbInformation, "CORDIALPHONE")
                CmbHora2.Focus()
                Exit Sub
            Else


                'CLIENTE.cli_agen_estado = ""
                'CLIENTE.CLI_CALL_ID_CALIDAD = WS_CALL_ID
                RECUPERACION.R_Fecha_Agen = DTFechaAgen.Value.ToString("yyyyMMdd")
                RECUPERACION.R_Hora_Agen = cmbHora.Text & cmbMin.Text
                RECUPERACION.R_Obs_Agen = Trim(Replace(TxtObsA.Text, "'", "`"))
                RECUPERACION.R_IdLlamada = WS_CALL_ID
                RECUPERACION.R_Venta = 0
                RECUPERACION.R_Estado = IIf(GESTION.G_Intento >= CLIENTE.C_Intentos_Max, "T", "A")
                ' CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = "2"
                RECUPERACION.R_Fecha_Vta = ""
                RECUPERACION.R_Hora_Vta = ""
                Dim fecha_agendamiento As String
                fecha_agendamiento = Format(DTAgenFecha2.Value, "dd/MM/yyyy") & " a las " & CmbHora2.Text & ":" & CmbMin2.Text & " Hrs."
                biGesRes.GuardaClienteGes(CLIENTE, RECUPERACION, GESTION)
                'biGesRes.ActualizaClienteAgen(CLIENTE.C_Id, CLIENTE.CLI_ESTADO_OBJECION_CALIDAD, CLIENTE.CLI_CALL_ID_CALIDAD)
                MsgBox("Fin de la gestión. Presione ACEPTAR para salir del formulario.", MsgBoxStyle.Information, csNombreAplicacion)
                limpiarPrimeraPantalla()
                Me.Hide()
                frmRegrabaciones.ShowDialog()
                BuscaGes()
            End If
        End If
    End Sub

    Private Sub TxtFechaN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'If LlenaParentescoCondicion() <> True Then
        '    Exit Sub
        'End If
        If ValAdicional(0) Then
            If paInsertaAdicional() Then
                'sumaUFAdicionales()
            End If
        End If
    End Sub

    Private Sub btnAdicionalSgt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionalSgt.Click
        Cuerpo.TabPages.Add(_Cuerpo_IngresoCli)

        If db_central = 4 And Trim(txtCallId.Text) = "" Then
            vpPosicion.CargarPosicion((vpPosicion.Usuario))
            txtCallId.Text = vpPosicion.IDLLAMADA
            WS_CALL_ID = vpPosicion.IDLLAMADA
        End If

        'sumaUFAdicionales()

        If perfil = "Regrabador" Then

            insertaAdicionalesGrilla()
            InsertaAdicionales(idPolizaRegrabacion)
            limpiaAdicionales()

        Else
            insertaAdicionalesGrilla()
            limpiaAdicionales()
        End If



        Cuerpo.TabPages.Item(0).Parent = Nothing
        guardarPantallaAnterior(9)

    End Sub

    Private Sub insertaAdicionalesGrilla()

        If perfil <> "Regrabador" Then

            Dim TpoContratoAdicional As New eTipoContrato
            TpoContratoAdicional = biClsTipoContrato.BuscarTipoContratoPorIdTipoContrato(tipoContrato.idTipoContrato)

            Dim entPlan As New ePlan
            Dim listaEntPlan As New List(Of ePlan)
            lstAdi.Clear()



            'GUARDO LOS DATOS DE LOS ADICIONALES EN UNA LISTA
            For I As Int16 = 0 To dtAdicional.Rows.Count - 1

                Dim adi As New eAdicional

                adi.A_Nombre = IIf(dtAdicional.Rows(I).Cells("nombre").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("nombre").Value)
                'adi.a_nombre2 = IIf(dtAdicional.Rows(I).Cells("nombre2").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("nombre2").Value)
                adi.A_Paterno = IIf(dtAdicional.Rows(I).Cells("paterno").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("paterno").Value)
                adi.A_Materno = IIf(dtAdicional.Rows(I).Cells("materno").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("materno").Value)
                adi.A_Rut = IIf(dtAdicional.Rows(I).Cells("rut").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("rut").Value)
                adi.A_Dv = IIf(dtAdicional.Rows(I).Cells("dv").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("dv").Value)
                adi.A_TipoBeneficiario = IIf(dtAdicional.Rows(I).Cells("idParentescoAdi").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("idParentescoAdi").Value)
                'adi.a_parentesco = IIf(dtAdicional.Rows(I).Cells("tipo_parentesco").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("tipo_parentesco").Value)
                adi.A_Sexo = IIf(dtAdicional.Rows(I).Cells("sexo").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("sexo").Value)
                adi.A_FechaNacimiento = IIf(dtAdicional.Rows(I).Cells("fechaNacimiento").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("fechaNacimiento").Value)
                adi.A_Isapre = IIf(dtAdicional.Rows(I).Cells("Isapre").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("Isapre").Value)
                adi.A_Peso = IIf(dtAdicional.Rows(I).Cells("peso").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("peso").Value)
                adi.A_Estatura = IIf(dtAdicional.Rows(I).Cells("estatura").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("estatura").Value)
                adi.A_DPS = IIf(dtAdicional.Rows(I).Cells("DPS").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("DPS").Value)
                'adi.a_primaUf = IIf(dtAdicional.Rows(I).Cells("ValorUf").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("ValorUf").Value)
                'adi.idPlanAdic = IIf(dtAdicional.Rows(I).Cells("idPlan").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("idPlan").Value)
                'adi.a_salud = IIf(dtAdicional.Rows(I).Cells("SistemaSalud").Value Is DBNull.Value, Nothing, dtAdicional.Rows(I).Cells("SistemaSalud").Value)

                lstAdi.Add(adi)

            Next I

        End If

    End Sub

    '****************Metodo para que se cargue ciudad al seleccionar comuna de combobox cmbComuna************************
    Private Sub cmbComuna_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComuna.SelectedIndexChanged
        Dim lstCiudad As New List(Of eCiudad)

        If cmbComuna.ValueMember Is Nothing Or cmbComuna.ValueMember = "" Then
            Exit Sub
        End If
        If cmbComuna.SelectedValue Is Nothing Then
            Exit Sub
        End If

        'actualiza el combo box de ciudad
        Dim Ciudad As New eCiudad
        Dim comuna As New eComuna

        comuna = vgListComuna.Find(Function(tmpC As eComuna) tmpC.idComuna = cmbComuna.SelectedValue)
        ' Ciudad = biClsCiudad.BuscaCiudadPorIdCiudad(comuna.idCiudad)
        Ciudad = vgListCiudad.Find(Function(tmc As eCiudad) tmc.idCiudad = comuna.idCiudad)
        lstCiudad.Add(Ciudad)
        vgFuncionComun.llenaComboBox(cmbCiudad, "nombreCiudad", "idCiudad", lstCiudad.ToArray)

    End Sub

    '**************metodo de boton siguiente de tab certificador********************************
    Private Sub cmdSiguienteFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiguienteFin.Click


        Select Case cmbAceptaPrima.SelectedIndex

            Case -1, 0
                MsgBox("Debe ingresar si acepta Cargo", MsgBoxStyle.Exclamation, csNombreAplicacion)
                cmbAceptaPrima.Focus()
                Exit Sub
            Case 1
                Select Case cmbAceptaContrato.SelectedIndex
                    Case 0, -1
                        MsgBox("Debe ingresar si acepta Contratación", MsgBoxStyle.Exclamation, csNombreAplicacion)
                        cmbAceptaContrato.Focus()
                        Exit Sub
                    Case 1
                        If perfil <> "Regrabador" Then
                            ' CLIENTE.cli_acepta_cargo = cmbAceptaPrima.Text
                            ' CLIENTE.cli_acepta_contrato = cmbAceptaContrato.Text
                        Else
                            'CLIENTE.CLI_ACEPTA_CONTRATACION = cmbAceptaContrato.Text
                            'CLIENTE.cli_acepta_prima = cmbAceptaPrima.Text
                        End If

                        clsScript = CargaScript(6)
                        WebBrowsercierre.DocumentText = clsScript.contenidoScript

                        Cuerpo.TabPages.Add(_Cuerpo_UltInfo)
                        Cuerpo.TabPages.Item(0).Parent = Nothing
                        guardarPantallaAnterior(6)
                    Case 2
                        If perfil <> "Regrabador" Then
                            ' CLIENTE.cli_acepta_contrato = cmbAceptaContrato.Text
                            ' CLIENTE.cli_acepta_prima = cmbAceptaPrima.Text
                        Else
                            ' CLIENTE.CLI_ACEPTA_CONTRATACION = cmbAceptaContrato.Text
                            ' CLIENTE.cli_acepta_prima = cmbAceptaPrima.Text
                        End If

                        Cuerpo.TabPages.Add(_Cuerpo_Objeciones)
                        Cuerpo.TabPages.Item(0).Parent = Nothing
                        guardarPantallaAnterior(6)

                End Select

            Case 2
                ' CLIENTE.cli_acepta_contrato = cmbAceptaContrato.Text
                ' CLIENTE.cli_acepta_prima = cmbAceptaPrima.Text
                Cuerpo.TabPages.Add(_Cuerpo_Objeciones)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(6)
        End Select

    End Sub

    Private Sub InsertaAdicionales(ByVal idPoliza As Integer)

        Dim J As Integer
        Dim TotalAdicional As Integer = lstAdi.Count

        Dim cli As String = CLIENTE.C_Id
        Dim aru As String = GESTION.G_Rut
        Dim biAsegurado As New clsAdicionalBI
        Dim adi As New eAdicional

        For J = 0 To TotalAdicional - 1
            adi.C_ID = cli
            adi.P_ID = idPoliza
            adi.A_NRO = J + 1
            adi.A_Rut = IIf(lstAdi(J).A_Rut.Trim = "", 0, lstAdi(J).A_Rut)
            adi.A_Dv = lstAdi(J).A_Dv
            adi.A_Nombre = lstAdi(J).A_Nombre
            adi.A_Paterno = lstAdi(J).A_Paterno
            adi.A_Materno = lstAdi(J).A_Materno
            adi.A_FechaNacimiento = Replace(lstAdi(J).A_FechaNacimiento, "-", "")
            adi.A_Sexo = lstAdi(J).A_Sexo
            adi.A_TipoBeneficiario = lstAdi(J).A_TipoBeneficiario
            adi.A_Isapre = lstAdi(J).A_Isapre
            adi.A_Peso = lstAdi(J).A_Peso
            adi.A_Estatura = lstAdi(J).A_Estatura
            adi.A_DPS = lstAdi(J).A_DPS

            biAsegurado.Insertar(adi)
        Next J


    End Sub

    Private Sub InsertaBeneficiarios()
        Dim J As Integer
        Dim TotalBenficiarios As Integer
        Dim cli As String
        Dim aru As String
        Dim clsBen As New clsBeneficiarioBI
        Dim be As New eBeneficiario

        TotalBenficiarios = lstBen.Count
        cli = CLIENTE.C_Id
        aru = GESTION.G_Rut
        If perfil = "Regrabador" Then
            Try
                clsBen.Eliminar(cli)
            Catch ex As Exception
                MsgBox(Err.Description & " " & " Error : En la Función EliminaBeneficiarios()", MsgBoxStyle.Critical, Me.Text)
            End Try
        End If
        Try
            For J = 0 To TotalBenficiarios - 1
                be.C_ID = cli
                be.B_Nro = J + 1
                be.B_Rut = IIf(lstBen(J).B_Rut.Trim = "", 0, lstBen(J).B_Rut)
                be.B_Dv = lstBen(J).B_Dv
                be.B_Nombre = lstBen(J).B_Nombre
                be.B_Paterno = lstBen(J).B_Paterno
                be.B_Materno = lstBen(J).B_Materno
                be.B_TipoBeneficiario = lstBen(J).B_TipoBeneficiario
                be.B_Porcentaje = lstBen(J).B_Porcentaje
                be.B_FechaNacimiento = lstBen(J).B_FechaNacimiento
                be.B_Sexo = lstBen(J).B_Sexo
                clsBen.Insertar(be)
            Next J

            '-------------------------------------------------------------------------------------
        Catch ex As Exception
            MsgBox(Err.Description & " " & " Error : En la Función InsertaBeneficiario()", MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

#Region "INGRESO CLIENTE"
    '*********metodo para cargar los datos en la toma de datos de regrabacion*******************
    ''' <summary>
    ''' carga los datos a los controles del tab toma de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AsignadatosCli()
        Dim TotalDigito As Integer

        TotalDigito = Len(Fono_A_Llamar)
        If TotalDigito = 9 Then
            txtFonoVenta.Text = Trim(Fono_A_Llamar)
        End If
        If TotalDigito > 9 Then
            txtFonoVenta.Text = Microsoft.VisualBasic.Right(Fono_A_Llamar, 9)
        End If

        'vgFuncionComun.LimpiaFormilarioBenAdi()

        Dim nombre = ""
        Dim apellido = ""
        Dim index As Integer = Trim(CLIENTE.C_Nombre).IndexOf(" "c)
        If (index = -1) Then
            ' No existe ningún espacio en blanco;
            nombre = Trim(CLIENTE.C_Nombre)
            apellido = String.Empty

        Else
            ' Obtenemos el nombre
            nombre = Trim(CLIENTE.C_Nombre).Substring(0, index)

            ' Obtenemos el apellido
            apellido = Trim(CLIENTE.C_Nombre).Substring(index + 1, Trim(CLIENTE.C_Nombre).Length - index - 1)

        End If

        cmbNuevaPoliza.SelectedIndex = 0
        cmbIngresaMedioPago.SelectedIndex = 0
        cmbMedioPago.SelectedIndex = 0

        If nuevapoliza = False Then

            txtNombreV.Text = nombre
            txtPaternoV.Text = Trim(UCase(CLIENTE.C_Paterno))
            txtMaternoV.Text = Trim(UCase(CLIENTE.C_Materno))

            txtRutV.Text = Mid(CLIENTE.C_Rut, 1, 4)
            txtDvV.Text = ""
            txtEmail.Text = CLIENTE.C_Email
            txtCalleV.Text = CLIENTE.C_Direccion

            rdbNoPagador.Checked = True

            dtFechaNacV.Value = fechaNacimientoCotiza
            dtFechaNacV.Enabled = False
            lblPrimaUF.Text = primaUfCotiza
            lblPrimaPesos.Text = primaPesosCotiza

        Else

            txtNombreV.Text = ""
            txtPaternoV.Text = ""
            txtMaternoV.Text = ""
            txtRutV.Text = ""
            txtDvV.Text = ""
            rdbSiPagador.Checked = True

            dtFechaNacV.Value = fechaNacimientoCotiza
            dtFechaNacV.Enabled = False
            lblPrimaUF.Text = primaUfCotiza
            lblPrimaPesos.Text = primaPesosCotiza


        End If




    End Sub

    Private Sub DatosMedioPago()

        'llena datos medio pago
        Dim biMedioPago As New clsMedioPagoBI
        Dim listMedioPago As New List(Of eMedioPago)
        'Dim medioPagoVacio As New eMedioPago
        Dim listMedioPagoVacio As New List(Of eMedioPago)

        'medioPagoVacio.MedioPago = "[No Especificado]"
        'medioPagoVacio.M_ID = "0"
        ' listMedioPagoVacio.Add(medioPagoVacio)

        ' listMedioPago = biMedioPago.BuscaDatosMedioPago(vgCampania.calCodigo, CLIENTE.C_Id)

        'For x As Int16 = 0 To listMedioPago.Count - 1

        '    Dim medioPago As New eMedioPago
        '    medioPago.nombreMedioPago = listMedioPago(x).nombreMedioPago
        '    medioPago.numeroTarjeta = listMedioPago(x).numeroTarjeta
        '    medioPago.idMedioPago = listMedioPago(x).idMedioPago
        '    medioPago.otroMedioPago = listMedioPago(x).otroMedioPago

        '    If (medioPago.otroMedioPago = True) Then
        '        medioPago.nombreMedioPago = medioPago.nombreMedioPago
        '    Else
        '        medioPago.nombreMedioPago = medioPago.nombreMedioPago & " - Nro: " & medioPago.numeroTarjeta
        '    End If

        '    listMedioPagoVacio.Add(medioPago)

        'Next

        ' vgFuncionComun.llenaComboBox(cmbMedioPago, "nombreMedioPago", "idMedioPago", listMedioPagoVacio.ToArray)

    End Sub

    ''' <summary>
    ''' metodo para cargar los datos en la toma de datos de regrabacion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AsignadatosCliGes()
        Dim comunaGes As New eComuna
        Dim CiudadGes As New eCiudad
        Dim tipocontrato As New eTipoContrato
        Dim biciudad As New clsCiudadBI
        Dim lstCiudad As New List(Of eCiudad)
        Dim plan As New ePlan

        txtNombreV.Text = Trim(UCase(GESTION.G_Nombre))
        txtPaternoV.Text = Trim(UCase(GESTION.G_Paterno))
        txtMaternoV.Text = Trim(UCase(GESTION.G_Materno))

        txtFonoVenta.Text = Trim(UCase(GESTION.G_Fono_Contacto))
        dtFechaNacV.Text = Trim(UCase(GESTION.G_Fecha_Nacimiento))

        txtRutV.Text = Trim(GESTION.G_Rut)
        txtDvV.Text = Trim(GESTION.G_Dv)
        txtEmail.Text = Trim(GESTION.G_Email)
        txtFonoVenta.Text = Trim(GESTION.G_Fono_Contacto)
        txtCalleV.Text = Trim(GESTION.G_Calle)
        txtNroV.Text = Trim(GESTION.G_Nro)
        txtReferenciaV.Text = Trim(GESTION.G_Referencia)


        comunaGes = vgListComuna.Find(Function(tmpC As eComuna) tmpC.nombreComuna = GESTION.G_Comuna)
        cmbComuna.SelectedValue = comunaGes.idComuna
        CiudadGes = biciudad.BuscaCiudadPorIdCiudad(comunaGes.idCiudad)
        lstCiudad.Add(CiudadGes)
        vgFuncionComun.llenaComboBox(cmbCiudad, "nombreCiudad", "idCiudad", lstCiudad.ToArray)
        cmbCiudad.SelectedValue = CiudadGes.idCiudad


        If GESTION.G_Sexo = "M" Then
            CmbSexo.SelectedIndex = 1
        ElseIf GESTION.G_Sexo = "F" Then
            CmbSexo.SelectedIndex = 2
        Else
            CmbSexo.SelectedIndex = 0
        End If




        'llenarTipoContrato()
        'tipocontrato = vgListTipoContrato.Find(Function(tmpC As eTipoContrato) tmpC.idTipoContrato = GESTION.G_TipoContrato)
        'cmbTipoContrato.SelectedValue = tipocontrato.idTipoContrato

        'llenar_planes()

        'plan = vgListPlanes.Find(Function(tmpC As ePlan) tmpC.idPlan = GESTION.G_Plan)
        'cmbPlan.SelectedValue = plan.idPlan

        'cmbTipoContrato.Enabled = False
        'cmbPlan.Enabled = False

        Carga_Beneficiarios()
        Carga_adicionales()



        'lblPrimaPesos.Text = GESTION.G_Prima_Pesos
        'lblPrimaUF.Text = GESTION.G_Prima_Uf
        'cmbPlan.Text = GESTION.G_Prima_Uf


    End Sub


    Private Sub limpiarPrimeraPantalla()
        TxtRut.Text = ""
        txtNombre.Text = ""
        TxtId.Text = ""
        txtDireccion.Text = ""
        txtIntentos.Text = ""
        txtObsAgen.Text = ""
        CmdAtras.Enabled = False
        'limpiaring()

        frmBeneficiario.dtBeneficiario.DataSource = Nothing
        frmBeneficiario.dtBeneficiario.Rows.Clear()

    End Sub




#End Region

#Region "VALIDACIONES"
    Function DevuelveDias(ByVal fechaTermino As Date) As Integer
        Dim cantDias As Integer
        Dim i As Integer
        Dim j As Integer
        Dim diaActual As Date
        Dim CantFeriados As Integer
        CantFeriados = 0
        cantDias = 0
        fechaTermino = fechaTermino.Date()
        cantDias = DateDiff(DateInterval.Day, Now.Date, fechaTermino)
        diaActual = Now.Date

        For i = 0 To cantDias
            For j = 0 To UBound(feriados)
                If diaActual = feriados(j) Then
                    CantFeriados = CantFeriados + 1
                End If
            Next
            diaActual = DateAdd(DateInterval.Day, 1, diaActual)
        Next

        DevuelveDias = cantDias - CantFeriados + 1
    End Function

    ''' <summary>
    ''' validamos la informacion en la toma de datos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidaInformacion() As Boolean

        ValidaInformacion = False

        '' Validar Nombre
        If Len(Trim(txtNombreV.Text)) < 3 Or
            Len(Trim(txtPaternoV.Text)) < 3 Or
            Len(Trim(txtMaternoV.Text)) < 3 Then
            MsgBox("Debe ingresar correctamente el NOMBRE COMPLETO del cliente ", vbInformation, "CORDIALPHONE.")
            txtNombreV.Focus()
            Exit Function
        End If

        If Not vgFuncionComun.edad(dtFechaNacV.Value, csEdadMinima, csEdadMaxima) Then
            MsgBox("La fecha de nacimiento no es válida.", vbInformation, "CORDIALPHONE.")
            Exit Function

        End If

        Select Case CmbSexo.SelectedIndex
            Case 0, -1
                MsgBox("Debe ingresar sexo del cliente.", MsgBoxStyle.Exclamation, csNombreAplicacion)
                CmbSexo.Focus()
                Exit Function
        End Select

        If txtRutV.Text.Length < 7 Then
            MsgBox("El RUT del cliente no es valido.", vbInformation, "Callsotuh.")
            txtRutV.Focus()
            Exit Function
        End If

        If Not vgFuncionComun.validarRut(Trim(txtRutV.Text) & "-" & Trim(txtDvV.Text)) Then
            MsgBox("El RUT del cliente no es valido.", vbInformation, "CORDIALPHONE.")
            txtRutV.Focus()
            Exit Function
        End If


        If txtFonoVenta.Text = "" Or txtFonoVenta.TextLength < 9 Then
            MsgBox("Debe ingresar fono venta valido 9 dígitos.", vbExclamation, csNombreAplicacion)
            txtFonoVenta.Focus()
            Exit Function
        End If

        If Trim(txtEmail.Text) <> "" Then
            If vgFuncionComun.ValidaEmail(Trim(txtEmail.Text)) = False Then
                MsgBox("Correo ingresado no es valido.", MsgBoxStyle.Exclamation, csNombreAplicacion)
                txtEmail.Focus()
                Exit Function
            End If
        End If

        Dim correo As New eCorreoInvalido
        If txtEmail.Text = "" Then
            If MsgBox("Pasara la venta sin correo, desea proseguir?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Function
        Else

            'correo = listaCorreoInvalido.Find(Function(x As eCorreoInvalido) x.correo = txtEmail.Text)
            'If Not correo Is Nothing Then
            '    MsgBox("El correo ingresado " + txtEmail.Text + " NO es válido, se eliminará el correo al momento de guardar.", MsgBoxStyle.Information)
            '    txtEmail.Text = ""
            '    Exit Function
            'End If

        End If


        Select Case CmbSexo.SelectedIndex
            Case 0, -1
                MsgBox("Debe ingresar sexo del cliente.", MsgBoxStyle.Exclamation, csNombreAplicacion)
                CmbSexo.Focus()
                Exit Function
        End Select

        If Trim(txtCalleV.Text) = "" Then
            MsgBox("El Campo calle es Obligatorio", vbExclamation, csNombreAplicacion)
            txtCalleV.Focus()
            Exit Function
        End If

        If Trim(txtNroV.Text) = "" Then
            MsgBox("El Campo Nº es obligatorio, si no tiene número ingrese S/N", vbExclamation, csNombreAplicacion)
            txtNroV.Focus()
            Exit Function
        End If

        If InStr(1, Trim(txtCalleV.Text), Trim(txtNroV.Text)) > 0 Then
            If MsgBox("El Campo Nº ya se encuentra en la calle, ¿Se debe corregir esto? " & vbNewLine & txtCalleV.Text & " " & txtNroV.Text, vbOKCancel, "Validacion de Nro en Direccion") = vbOK Then
                txtCalleV.Focus()
                txtCalleV.SelectionStart = InStr(1, Trim(txtCalleV.Text), Trim(txtNroV.Text)) - 1
                txtCalleV.SelectionLength = Len(Trim(txtNroV.Text))
                Exit Function
            End If
        End If

        If cmbComuna.SelectedIndex = -1 Or cmbComuna.Text = "" Then
            MsgBox("Ingrese la comuna a la cual pertenece la dirección.", vbExclamation, csNombreAplicacion)
            cmbComuna.Focus()
            Exit Function
        End If


        If cmbCiudad.SelectedIndex = -1 Or cmbCiudad.Text = "" Or cmbCiudad.SelectedValue = 0 Then
            MsgBox("Ingrese la ciudad a la cual pertenece la comuna.", vbExclamation, csNombreAplicacion)
            cmbCiudad.Focus()
            Exit Function
        End If


        If perfil <> "Regrabador" Then

            If txtPesoCliente.Text.Trim = "" Then
                MsgBox("Debe ingresar el peso del cliente.", vbExclamation, csNombreAplicacion)
                txtPesoCliente.Focus()
                Exit Function
            End If

            If mskEstaturaCliente.Text.Trim = "" Or mskEstaturaCliente.Text = " ." Or mskEstaturaCliente.Text = "0,00" Or mskEstaturaCliente.Text = "0.00" Or mskEstaturaCliente.Text = " .  " Then
                MsgBox("Debe ingresar la estatura del cliente.", vbExclamation, csNombreAplicacion)
                mskEstaturaCliente.Focus()
                Exit Function
            End If

            If cmbIsapreCliente.SelectedIndex <= 0 Then
                MsgBox("Debe ingresar isapre del cliente.", vbExclamation, csNombreAplicacion)
                cmbIsapreCliente.Focus()
                Exit Function
            End If

            If rdbSiPagador.Checked = True Then
                If txtRutPagador.Text = "" Then
                    MsgBox("Debe ingresar rut del Pagador.", vbExclamation, csNombreAplicacion)
                    txtRutPagador.Focus()
                    Exit Function
                End If

                If txtDvPagador.Text = "" Then
                    MsgBox("Debe ingresar DV del Pagador.", vbExclamation, csNombreAplicacion)
                    txtDvPagador.Focus()
                    Exit Function
                End If

                If txtNombrePagador.Text = "" Then
                    MsgBox("Debe ingresar Nombre del Pagador.", vbExclamation, csNombreAplicacion)
                    txtNombrePagador.Focus()
                    Exit Function
                End If

            End If


        End If

        ValidaInformacion = True
    End Function

#End Region

#Region "ADICIONALES"
    ''' <summary>
    ''' PROCEDIMIENTO PARA CARGAR LOS ADICIONALES EN LA GRILLA
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Carga_adicionales()

        lstAdi = biClsAdic.Carga_Adicional(CLIENTE.C_Id)
        dtAdicional.DataSource = lstAdi
        'Si no pongo esta línea, se crean automáticamente los campos del grid dependiendo de los campos del DataTable
        dtAdicional.AutoGenerateColumns = False
        'Aquí le indico cuales campos del select de mi SP van con los campos de mi grid
        With dtAdicional
            .Columns("nombre").DataPropertyName = "A_NOMBRE"
            .Columns("paterno").DataPropertyName = "A_PATERNO"
            .Columns("materno").DataPropertyName = "A_MATERNO"
            .Columns("rut").DataPropertyName = "A_RUT"
            .Columns("dv").DataPropertyName = "A_DV"
            .Columns("tipo_parentesco").DataPropertyName = "A_TIPO_BENEFICIARIO"
            .Columns("fechaNacimiento").DataPropertyName = "A_FECHA_NACIMIENTO"
            .Columns("sexo").DataPropertyName = "A_SEXO"
            .Columns("Isapre").DataPropertyName = "A_ISAPRE"
            .Columns("Peso").DataPropertyName = "A_PESO"
            .Columns("Estatura").DataPropertyName = "A_ESTATURA"
            .Columns("DPS").DataPropertyName = "A_DPS"
        End With
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If ValAdicional(1) Then
            Call paModificaAdicional()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If (MsgBox("Desea eliminar el adicional seleccionado", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, csNombreAplicacion)) = MsgBoxResult.No Then Exit Sub

        If paEliminaAdicional() Then
            MsgBox("Adicional eliminado", MsgBoxStyle.Information, csNombreAplicacion)
        Else
            MsgBox("No se ha podido eliminar el adicional, favor verificar rut", MsgBoxStyle.Exclamation, csNombreAplicacion)
            txtRutA.Focus()
        End If

    End Sub

    Private Sub dtAdicional_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtAdicional.CellContentClick

        If e.RowIndex = -1 Then Exit Sub

        txtNombreA.Text = dtAdicional.Rows(e.RowIndex).Cells("nombre").Value
        txtPaternoA.Text = dtAdicional.Rows(e.RowIndex).Cells("paterno").Value
        txtMaternoA.Text = dtAdicional.Rows(e.RowIndex).Cells("materno").Value
        txtRutA.Text = dtAdicional.Rows(e.RowIndex).Cells("rut").Value
        txtDvA.Text = dtAdicional.Rows(e.RowIndex).Cells("dv").Value
        cmbParentescoAdic.Text = dtAdicional.Rows(e.RowIndex).Cells("tipo_parentesco").Value
        dtFechaNacAdic.Value = dtAdicional.Rows(e.RowIndex).Cells("fechaNacimiento").Value
        cmbSexoA.Text = dtAdicional.Rows(e.RowIndex).Cells("Sexo").Value
        cmbIsapre.Text = dtAdicional.Rows(e.RowIndex).Cells("Isapre").Value
        txtPeso.Text = dtAdicional.Rows(e.RowIndex).Cells("Peso").Value
        mskEstatura.Text = dtAdicional.Rows(e.RowIndex).Cells("Estatura").Value
        txtDatosDPS.Text = dtAdicional.Rows(e.RowIndex).Cells("DPS").Value

        numeroFila = e.RowIndex
    End Sub

    Private Function paEliminaAdicional() As Boolean

        paEliminaAdicional = False

        For i As Int16 = 0 To dtAdicional.Rows.Count - 1
            If dtAdicional.Rows(i).Cells("rut").Value = txtRutA.Text Then
                If perfil <> "Regrabador" Then
                    dtAdicional.Rows.RemoveAt(i)
                    paEliminaAdicional = True
                    sumaUFAdicionales()
                    Exit Function
                Else
                    Dim entityRem As eAdicional = lstAdi.FirstOrDefault(Function(e) e.A_Rut = txtRutA.Text)
                    If entityRem IsNot Nothing Then
                        lstAdi.Remove(entityRem)
                        dtAdicional.DataSource = Nothing
                        dtAdicional.DataSource = lstAdi
                        dtAdicional.Refresh()
                    End If
                    paEliminaAdicional = True
                    sumaUFAdicionales()
                    Exit Function
                End If
            End If
        Next

    End Function

    Private Sub sumaUFAdicionales()
        'Dim uf As Double = 0
        'totalUfAdic = 0
        'For i As Integer = 0 To dtAdicional.RowCount - 1
        '    uf = CDbl(dtAdicional.Item("valorUf", i).Value)
        '    totalUfAdic = totalUfAdic + uf
        'Next

        'lblTotalPrimaUf.Text = "Total UF: " + (totalUfAdic + CDbl(ePlanGlobal.primaUF)).ToString
        'lblPrimaUF.Text = (totalUfAdic + CDbl(ePlanGlobal.primaUF)).ToString

        'Dim SumaUF As Double
        'Dim UfNumerico As Double = ePlanGlobal.primaUF
        'SumaUF = (totalUfAdic + UfNumerico)

        'TotalPesos = CInt(Math.Round(SumaUF * CDbl(valorPesosUf)))
        'totalUfAdic = totalUfAdic + CDbl(ePlanGlobal.primaUF)

        'lblPesosUF.Text = "Valor Pesos: " + TotalPesos.ToString
        'lblPrimaPesos.Text = TotalPesos.ToString

    End Sub

    Private Sub paModificaAdicional()

        LlenaParentescoCondicion()

        If perfil <> "Regrabador" Then
            If dtAdicional.Rows.Count <> 0 Then
                dtAdicional.Rows(numeroFila).Cells("nombre").Value = txtNombreA.Text
                dtAdicional.Rows(numeroFila).Cells("paterno").Value = txtPaternoA.Text
                dtAdicional.Rows(numeroFila).Cells("materno").Value = txtMaternoA.Text
                dtAdicional.Rows(numeroFila).Cells("rut").Value = txtRutA.Text
                dtAdicional.Rows(numeroFila).Cells("dv").Value = txtDvA.Text
                dtAdicional.Rows(numeroFila).Cells("tipo_parentesco").Value = cmbParentescoAdic.Text
                dtAdicional.Rows(numeroFila).Cells("fechaNacimiento").Value = dtFechaNacAdic.Value.ToString("yyyy-MM-dd")
                dtAdicional.Rows(numeroFila).Cells("Isapre").Value = cmbIsapre.Text
                dtAdicional.Rows(numeroFila).Cells("Peso").Value = txtPeso.Text
                dtAdicional.Rows(numeroFila).Cells("Estatura").Value = mskEstatura.Text
                dtAdicional.Rows(numeroFila).Cells("DPS").Value = txtDatosDPS.Text
            Else
                MsgBox("Debe agregar Primero antes de Modificar!.", vbInformation, csNombreAplicacion)
                Exit Sub
            End If
        Else
            If dtAdicional.Rows.Count <> 0 Then
                Dim entityToEdit As eAdicional = lstAdi.FirstOrDefault(Function(e) e.A_Rut = txtRutA.Text)
                If entityToEdit IsNot Nothing Then
                    entityToEdit.A_Nombre = txtNombreA.Text
                    entityToEdit.A_Paterno = txtPaternoA.Text
                    entityToEdit.A_Materno = txtMaternoA.Text
                    entityToEdit.A_Sexo = cmbSexoA.Text
                    entityToEdit.A_TipoBeneficiario = cmbParentescoAdic.SelectedValue
                    entityToEdit.A_FechaNacimiento = dtFechaNacAdic.Value.ToString("yyyy-MM-dd")
                    entityToEdit.A_Isapre = dtAdicional.Rows(numeroFila).Cells("Isapre").Value = cmbIsapre.Text
                    entityToEdit.A_Peso = dtAdicional.Rows(numeroFila).Cells("Peso").Value = txtPeso.Text
                    entityToEdit.A_Estatura = dtAdicional.Rows(numeroFila).Cells("Estatura").Value = mskEstatura.Text
                    entityToEdit.A_DPS = dtAdicional.Rows(numeroFila).Cells("DPS").Value = txtDatosDPS.Text


                    dtAdicional.DataSource = Nothing
                    dtAdicional.DataSource = lstAdi
                    dtAdicional.Refresh()
                End If
            Else
                MsgBox("Debe agregar Primero antes de Modificar!.", vbInformation, csNombreAplicacion)
                Exit Sub
            End If
        End If
        Call limpiaAdicionales()
        btnModificar.Enabled = True
        btnAgregar.Enabled = True
        sumaUFAdicionales()
    End Sub

    Private Function ValAdicional(ByVal num As Integer) As Boolean

        If txtNombreA.Text = "" Then
            MsgBox("El campo nombre es obligatorio.", vbExclamation, csNombreAplicacion)
            txtNombreA.Focus()
            Exit Function
        ElseIf Len(txtNombreA.Text) < 2 Then
            MsgBox("El nombre ingresado No es valido.", vbExclamation, csNombreAplicacion)
            txtNombreA.Focus()
            Exit Function
        End If

        If txtPaternoA.Text = "" Then
            MsgBox("El campo Apellido Paterno es obligatorio.", vbExclamation, csNombreAplicacion)
            txtPaternoA.Focus()
            Exit Function
        ElseIf Len(txtPaternoA.Text) < 2 Then
            MsgBox("El Apellido Paterno ingresado, No es valido.", vbExclamation, csNombreAplicacion)
            txtPaternoA.Focus()
            Exit Function
        End If
        If txtMaternoA.Text = "" Then
            MsgBox("El campo Apellido Materno es obligatorio.", vbExclamation, csNombreAplicacion)
            txtMaternoA.Focus()
            Exit Function
        ElseIf Len(txtMaternoA.Text) < 2 Then
            MsgBox("El Apellido Materno ingresado, No es valido.", vbExclamation, csNombreAplicacion)
            txtMaternoA.Focus()
            Exit Function
        End If

        If cmbSexoA.SelectedIndex = -1 Or cmbSexoA.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar el sexo.", vbExclamation, csNombreAplicacion)
            cmbSexoA.Focus()
            Exit Function
        End If

        If cmbParentescoAdic.SelectedIndex = -1 Or cmbParentescoAdic.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar el parentesco de la carga.", vbExclamation, csNombreAplicacion)
            cmbParentescoAdic.Focus()
            Exit Function
        End If

        'If cmbSaludAdic.SelectedIndex < 1 Then
        '    MsgBox("Debe seleccionar el sistema de salud del adicional.", vbExclamation, csNombreAplicacion)
        '    cmbSaludAdic.Focus()
        '    Exit Function
        'End If

        If txtRutA.Text <> "" Then
            '    MsgBox("Debe ingresar rut del Adicional", MsgBoxStyle.Exclamation, csNombreAplicacion)
            '    txtRutA.Focus()
            '    Exit Function
            'Else
            If Not vgFuncionComun.validarRut(Trim(txtRutA.Text) & "-" & Trim(txtDvA.Text)) Then
                MsgBox("El RUT del Adicional no es valido.", vbInformation, "CORDIALPHONE.")
                txtRutA.Focus()
                Exit Function
            End If
        End If

        If txtRutA.Text = GESTION.G_Rut Then
            MsgBox("El RUT del Adicional no puede ser igual al rut del titular.", vbInformation, "CORDIALPHONE.")
            txtRutA.Focus()
            Exit Function
        End If

        If num = 0 Then
            For x As Int16 = 0 To dtAdicional.Rows.Count - 1
                If dtAdicional.Rows(x).Cells("rut").Value = txtRutA.Text Then
                    MsgBox("Titular ya se encuentra ingresado con ese rut", vbInformation, "CORDIALPHONE")
                    txtRutA.Focus()
                    Exit Function
                End If
            Next
        End If

        If cmbIsapre.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar Sistema Salud del adicional", vbExclamation, "CORDIALPHONE")
            cmbIsapre.Focus()
            Exit Function
        End If

        If txtPeso.Text.Trim = "" Then
            MsgBox("Debe ingresar el peso del cliente.", vbExclamation, csNombreAplicacion)
            txtPeso.Focus()
            Exit Function
        End If

        If mskEstatura.Text.Trim = "" Or mskEstatura.Text.Trim = " ,  " Or mskEstatura.Text = "0,00" Or mskEstatura.Text = "0.00" Or mskEstatura.Text = " .  " Then
            MsgBox("Debe ingresar la estatura del cliente.", vbExclamation, csNombreAplicacion)
            mskEstatura.Focus()
            Exit Function
        End If

        ValAdicional = True
    End Function

    Private Sub btnAdicional_Click(sender As Object, e As EventArgs) Handles btnAdicional.Click
        Cuerpo.TabPages.Add(_Cuerpo_Adicionales)
        totalUfAdic = 0
        If cmbTipoContratoCotiza.SelectedIndex <> 0 And cmbTipoContratoCotiza.SelectedIndex <> -1 Then
            listParentescoCampania = biClsParentescoCampania.BuscarParentescoPorId(vgCampania.idCRM, 2)
            vgFuncionComun.llenaComboBox(cmbParentescoAdic, "nombreParentesco", "idParentesco", listParentescoCampania.ToArray)
        End If

        'sumaUFAdicionales()
        limpiaAdicionales()

        Cuerpo.TabPages.Item(0).Parent = Nothing
        guardarPantallaAnterior(3)
    End Sub

#End Region

#Region "BENEFICIARIOS"

    ''' <summary>
    ''' PROCEDIMIENTO PARA CARGAR LOS BENEFICIARIOS EN LA GRILLA
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Carga_Beneficiarios()
        lstBen = biClsBen.CargaBeneficiarios(CLIENTE.C_Id)
    End Sub


    Private Sub limpiaAdicionales()
        txtNombreA.Text = ""
        txtPaternoA.Text = ""
        txtMaternoA.Text = ""
        txtRutA.Text = ""
        txtDvA.Text = ""
        dtFechaNacAdic.Value = dtFechaNacAdic.MinDate
        cmbParentescoAdic.SelectedIndex = -1
        cmbSexoA.SelectedIndex = -1
        txtPeso.Text = ""
        cmbIsapre.SelectedValue = -1
        txtDatosDPS.Text = ""
        mskEstatura.Text = ""
    End Sub


#End Region

#Region "SCRIPTS"

    Private Function ScriptLblFinNoC() As String
        Dim mensaje As String
        mensaje = "Disculpe las molestias, gracias por su tiempo y que tenga un buen día." & vbNewLine
        ScriptLblFinNoC = mensaje
    End Function

    Private Function ScriptLblFinNoCumple() As String
        Dim mensaje As String
        mensaje = "Sr./Sra " & Trim$(CLIENTE.C_Nombre) & "  " & Trim$(CLIENTE.C_Paterno) & " " & Trim$(CLIENTE.C_Materno) & " Lamentablemente no podemos entregar el seguro ya no cumple con alguno de los requisitos anteriormente mencionado. Muchas gracias por su tiempo. " & vbNewLine
        ScriptLblFinNoCumple = mensaje
    End Function

#End Region


    Public Function CargaScript(ByVal _idTipoScript As Int32) As eScript

        Dim script As New eScript
        Dim biScript As New clsScriptBI
        script = biScript.BuscarScriptPorIdTipoScript(vgCampania.idCRM, _idTipoScript)

        'datos generales
        script.contenidoScript = Replace(script.contenidoScript, "[FechaActual]", Now())
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo1]", CLIENTE.Extra1)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo2]", CLIENTE.Extra2)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo3]", CLIENTE.Extra3)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo4]", CLIENTE.Extra4)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo5]", CLIENTE.Extra5)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo6]", CLIENTE.Extra6)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo7]", CLIENTE.Extra7)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo8]", CLIENTE.Extra8)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo9]", CLIENTE.Extra9)
        script.contenidoScript = Replace(script.contenidoScript, "[Persona.Campo10]", CLIENTE.Extra10)

        If (script.idTipoScript < 3) Then '1.Bienvenida  2.Presentacion  3.Informacion Adicional

            '[Persona.nombre] [Persona.paterno] [Persona.materno]
            script.contenidoScript = Replace(script.contenidoScript, "[Agente.Nombre]", Replace(WS_IDUSUARIO, ".", " "))
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.nombre]", CLIENTE.C_Nombre)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.paterno]", CLIENTE.C_Paterno)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.materno]", CLIENTE.C_Materno)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.fechaNacimiento]", CLIENTE.C_Fecha_Nacimiento)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.Rut]", CLIENTE.C_Rut & "-" & CLIENTE.C_Dv)
            script.contenidoScript = Replace(script.contenidoScript, "[DireccionParticular]", CLIENTE.C_Direccion)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.Comuna]", CLIENTE.C_Comuna)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.Ciudad]", CLIENTE.C_Ciudad)

        Else
            'datos venta

            script.contenidoScript = Replace(script.contenidoScript, "[Persona.nombre]", GESTION.G_Nombre)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.paterno]", GESTION.G_Paterno)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.materno]", GESTION.G_Materno)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.fechaNacimiento]", GESTION.G_Fecha_Nacimiento)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.Rut]", GESTION.G_Rut & "-" & GESTION.G_Dv)
            script.contenidoScript = Replace(script.contenidoScript, "[DireccionParticular]", GESTION.G_Calle & " " & GESTION.G_Nro & " " & GESTION.G_Referencia)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.Comuna]", GESTION.G_Comuna)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.mail]", GESTION.G_Email)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.FonoVenta]", GESTION.G_Fono_Contacto)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.FonoContacto]", GESTION.G_Fono_Contacto)
            'script.contenidoScript = Replace(script.contenidoScript, "[medioPago]", GESTION.G_ME)
            'script.contenidoScript = Replace(script.contenidoScript, "[banco]", CLIENTE.CLI_ABANCO)
            script.contenidoScript = Replace(script.contenidoScript, "[PrimaUf]", GESTION.G_Prima_Uf)
            script.contenidoScript = Replace(script.contenidoScript, "[PrimaPesos]", GESTION.G_Prima_Pesos)
            'script.contenidoScript = Replace(script.contenidoScript, "[Persona.numeroTarjeta]", CLIENTE.cli_anrotarjeta)
            script.contenidoScript = Replace(script.contenidoScript, "[Persona.email]", GESTION.G_Email)
            'script.contenidoScript = Replace(script.contenidoScript, "[CodigoVerificacion]", CLIENTE.cli_codverificacion)

            'Beneficiarios
            Dim beneficiario As eBeneficiario

            For x As Int16 = 0 To lstBen.Count - 1

                script.contenidoScript = Replace(script.contenidoScript, "BeneficiarioNombre" + (x + 1).ToString, lstBen(x).B_Nombre)
                script.contenidoScript = Replace(script.contenidoScript, "BeneficiarioPaterno" + (x + 1).ToString, lstBen(x).B_Paterno)
                script.contenidoScript = Replace(script.contenidoScript, "BeneficiarioMaterno" + (x + 1).ToString, lstBen(x).B_Materno)
                script.contenidoScript = Replace(script.contenidoScript, "BeneficiarioFechaNacimiento" + (x + 1).ToString, lstBen(x).B_FechaNacimiento)
                script.contenidoScript = Replace(script.contenidoScript, "BeneficiarioRut" + (x + 1).ToString, lstBen(x).B_Rut + "-" + lstBen(x).B_Dv)
                script.contenidoScript = Replace(script.contenidoScript, "BeneficiarioParentesco" + (x + 1).ToString, lstBen(x).B_TipoBeneficiario)
                script.contenidoScript = Replace(script.contenidoScript, "BeneficiarioPorcentaje" + (x + 1).ToString, lstBen(x).B_Porcentaje)

            Next

        End If

        Return script

    End Function




    Private Function paInsertaAdicional() As Boolean

        If perfil <> "Regrabador" Then

            Dim FilaTotal As Integer

            FilaTotal = dtAdicional.Rows.Count + 1

            Dim TpoContratoAdicional As New eTipoContrato

            TpoContratoAdicional = biClsTipoContrato.BuscarTipoContratoPorIdTipoContrato(tipoContrato.idTipoContrato)

            FilaAgregar = dtAdicional.Rows.Count

            dtAdicional.Rows.Add(1)
            dtAdicional.Item("nombre", FilaAgregar).Value = txtNombreA.Text
            dtAdicional.Item("paterno", FilaAgregar).Value = txtPaternoA.Text
            dtAdicional.Item("materno", FilaAgregar).Value = txtMaternoA.Text
            dtAdicional.Item("rut", FilaAgregar).Value = txtRutA.Text
            dtAdicional.Item("dv", FilaAgregar).Value = txtDvA.Text
            dtAdicional.Item("Sexo", FilaAgregar).Value = cmbSexoA.Text
            dtAdicional.Item("idParentescoAdi", FilaAgregar).Value = cmbParentescoAdic.SelectedValue
            dtAdicional.Item("tipo_parentesco", FilaAgregar).Value = cmbParentescoAdic.Text
            dtAdicional.Item("fechaNacimiento", FilaAgregar).Value = dtFechaNacAdic.Value.ToString("yyyy-MM-dd")
            dtAdicional.Item("Isapre", FilaAgregar).Value = cmbIsapre.Text
            dtAdicional.Item("Peso", FilaAgregar).Value = txtPeso.Text
            dtAdicional.Item("Estatura", FilaAgregar).Value = mskEstatura.Text
            dtAdicional.Item("DPS", FilaAgregar).Value = txtDatosDPS.Text
        Else
            'lstAdi.Add(New eAdicional() With {
            ' .A_Nombre = txtNombreA.Text,
            ' .A_Paterno = txtPaternoA.Text,
            ' .A_Materno = txtMaternoA.Text,
            ' .A_Rut = txtRutA.Text,
            ' .A_Dv = txtDvA.Text,
            ' .A_Sexo = cmbSexoA.Text,
            ' .A_TipoBeneficiario = cmbParentescoAdic.SelectedValue,
            ' .A_FechaNacimiento = dtFechaNacAdic.Value.ToString("yyyy-MM-dd")
            '}
            '  )
            dtAdicional.DataSource = Nothing
            dtAdicional.DataSource = lstAdi
            dtAdicional.Refresh()

        End If
        Call limpiaAdicionales()
        paInsertaAdicional = True
    End Function


    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Dim biMedioPago As New clsMedioPagoBI

        If validaMedioPago() = True Then


            poliza.medio_pago = cmbMedioPago.Text
            poliza.banco = IIf(CmbBanco.SelectedIndex < 0, "", CmbBanco.Text)
            poliza.tipo_tarjeta = IIf(cmbTpoTarjeta.SelectedIndex <= 0, "", cmbTpoTarjeta.Text)
            poliza.nro_Cuenta = txtNumeroCuenta.Text.Trim


            'CERTIFIOCACION
            clsScript = CargaScript(4)
            WebInfAdicional.DocumentText = clsScript.contenidoScript

            Cuerpo.TabPages.Add(_Cuerpo_InfAdic)
            Cuerpo.TabPages.Item(0).Parent = Nothing
            guardarPantallaAnterior(4)

        End If

    End Sub

    Private Function validaMedioPago() As Boolean

        Dim biMedioPago As New clsMedioPagoBI
        Dim medioPagoTar As eMedioPago
        medioPagoTar = biMedioPago.BuscaMedioPagoPorId(cmbMedioPago.SelectedValue)

        validaMedioPago = False
        If cmbMedioPago.SelectedIndex <= 0 Then
            MsgBox("Debe seleccionar Medio de Pago.", MsgBoxStyle.Information, "CORDIALPHONE")
            cmbMedioPago.Focus()
            Exit Function
        End If

        If CmbBanco.SelectedIndex < 0 Then
            MsgBox("Debe ingresar el banco.", MsgBoxStyle.Information, "CORDIALPHONE")
            CmbBanco.Focus()
            Exit Function
        End If

        If cmbMedioPago.SelectedIndex = 2 And cmbTpoTarjeta.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar tipo Tarjeta para el PAT.", MsgBoxStyle.Information, "CORDIALPHONE")
            cmbTpoTarjeta.Focus()
            Exit Function
        End If

        If cmbMedioPago.SelectedIndex = 1 Or cmbMedioPago.SelectedIndex = 3 Then
            If txtNumeroCuenta.Text.Trim = "" Then
                MsgBox("Debe ingresar numero de Cuenta.", MsgBoxStyle.Information, "CORDIALPHONE")
                txtNumeroCuenta.Focus()
                Exit Function
            End If
        End If

        validaMedioPago = True
    End Function

    Private Sub cmbAceptaPrima_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAceptaPrima.SelectedIndexChanged
        If cmbAceptaPrima.SelectedIndex = 1 Then

            'Script de certificación
            clsScript = CargaScript(5)
            WebBrowsercierre.DocumentText = clsScript.contenidoScript

            WebBrowsercierre.Visible = True
        Else
            WebBrowsercierre.Visible = False
        End If
    End Sub



    Private Sub LlenaPlanesCondicion()

        Dim tmpPlanes As New List(Of ePlan)
        Dim plan As New ePlan
        plan.idPlan = 0
        plan.primaUF = "---No ingresado---"
        plan.descripcionPlan = "---No ingresado---"
        tmpPlanes.Add(plan)

        If cmbTipoContratoCotiza.SelectedIndex <> -1 And cmbTipoContratoCotiza.SelectedIndex <> 0 Then

            tipoContrato.idTipoContrato = cmbTipoContratoCotiza.SelectedValue 'siempre analizara restriccion del titular
            listPlanes = biClsPlan.BuscarPlanPorTipoContrato(tipoContrato.idTipoContrato, 847)
            Dim listRestriccion As New List(Of eRestriccion)

            For x As SByte = 0 To listPlanes.Count - 1
                planE = biClsPlan.BuscarPlanPorIdPlan(listPlanes(x).idPlan)

                listRestriccion = biClsRestricion.BuscarRestriccionPorIdPlan(planE.idPlan)
                Dim count As Int16 = 0
                For y As SByte = 0 To listRestriccion.Count - 1
                    restricionE.idRestriccionPlan = listRestriccion(y).idRestriccionPlan
                    restricionE.idPlan = listRestriccion(y).idPlan
                    restricionE.operacion = listRestriccion(y).operacion

                    Dim edadCliente As Int16 = DateDiff(DateInterval.Year, Date.Parse(dtFechaNacimientoCotiza.Text), Date.UtcNow)

                    Select Case listRestriccion(y).operacion
                        Case ">"
                            If edadCliente > listRestriccion(y).valorRestriccion Then
                                count += 1
                            End If
                        Case "<"
                            If edadCliente < listRestriccion(y).valorRestriccion Then
                                count += 1
                            End If
                        Case "="
                            If edadCliente <> listRestriccion(y).valorRestriccion Then
                                count += 1
                            End If
                        Case "<="
                            If edadCliente <> listRestriccion(y).valorRestriccion Then
                                count += 1
                            End If
                        Case ">="
                            If edadCliente <> listRestriccion(y).valorRestriccion Then
                                count += 1
                            End If
                    End Select

                Next

                If count = 2 Then
                    tmpPlanes.Add(planE)
                    Dim TpoContrato As New eTipoContrato
                    TpoContrato = biClsTipoContrato.BuscarTipoContratoPorIdTipoContrato(tipoContrato.idTipoContrato)
                    btnAdicional.Visible = IIf(TpoContrato.cantidadAdicionales > 0, True, False)
                    btnBeneficiarios.Visible = IIf(TpoContrato.cantidadBeneficiarios > 0, True, False)
                End If
            Next
        End If

        If tmpPlanes.ToArray.Count > 0 Then
            cmbPlanCotiza.Visible = True
            'lblPlanes.Visible = True
            vgFuncionComun.llenaComboBox(cmbPlanCotiza, "descripcionPlan", "idplan", tmpPlanes.ToArray)
        Else
            cmbPlanCotiza.Visible = False
            'lblPlanes.Visible = False
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        clsScript = CargaScript(5)
        wbScriptCertificacion.DocumentText = clsScript.contenidoScript

        Cuerpo.TabPages.Add(_Cuerpo_Certifica)
        Cuerpo.TabPages.Item(0).Parent = Nothing
        guardarPantallaAnterior(5)
    End Sub

    Private Sub CmdFinVenta_Click(sender As Object, e As EventArgs) Handles cmdFinVenta.Click
        GESTION.G_Estado = "T"
        GESTION.G_Venta = "1"
        GESTION.G_Fecha_Vta = Today.ToString("yyyyMMdd")
        GESTION.G_Hora_Vta = TimeOfDay.ToString("HHmmss")
        GESTION.G_Tiempo_PostView = lblHora.Text + ":" + lblMinutos.Text + ":" + lblSegundos.Text
        If perfil <> "Regrabador" Then
            If cmbIngresaMedioPago.SelectedIndex = 2 Then 'NO
                If cmbHoraMandato.SelectedIndex < 0 Then
                    MsgBox("Debe ingresar hora de Llamado Mandato", vbExclamation)
                    Exit Sub
                End If
                If dtpFechaMandato.Value.ToString("yyyyMMdd") + cmbHoraMandato.Text < Today.ToString("yyyyMMdd") + TimeOfDay.ToString("HHmm") Then
                    MsgBox("Debe ingresar una hora superior a la hora actual", vbExclamation)
                    Exit Sub
                End If
                GESTION.G_Dato7 = dtpFechaMandato.Value.ToString("yyyyMMdd") + cmbHoraMandato.Text
            End If

            If chkGiftcard.Checked Then
                GESTION.G_Dato8 = cmbGiftCard.Text
            Else
                GESTION.G_Dato8 = ""
            End If

            GESTION.G_IdLlamada = WS_CALL_ID
            biCliente.GuardaDatosCliente(CLIENTE, GESTION)

            MsgBox("Fin de la gestión. Presione ACEPTAR para continuar con el siguiente registro.", MsgBoxStyle.Information, "CORDIALPHONE")
            limpiarPrimeraPantalla()
            Buscar_Cliente()
        Else
            RECUPERACION.R_Estado = "T"
            RECUPERACION.R_Venta = "1"
            RECUPERACION.R_Fecha_Vta = Today.ToString("yyyyMMdd")
            RECUPERACION.R_Hora_Vta = TimeOfDay.ToString("HHmmss")
            RECUPERACION.R_IdLlamada = WS_CALL_ID
            'CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = 1
            biGesRes.GuardaClienteGes(CLIENTE, RECUPERACION, GESTION)
            biGesRes.ActualizaClienteVenta(CLIENTE, GESTION)
            'InsertaAdicionales()
            'InsertaBeneficiarios()
            MsgBox("Fin de la gestión. Presione ACEPTAR para salir del formulario.", MsgBoxStyle.Information, csNombreAplicacion)
            limpiarPrimeraPantalla()
            Me.Hide()
            frmRegrabaciones.ShowDialog()
            BuscaGes()
        End If

    End Sub

    Private Function LlenaParentescoCondicion() As Boolean
        LlenaParentescoCondicion = False

        Dim tmpParentesco As New List(Of eTipoParentesco)
        Dim listParentesco As New List(Of eTipoParentesco)
        Dim entParentesco As New eTipoParentesco

        Dim biPlan As New clsPlanBI
        entParentesco.idParentesco = 0
        entParentesco.nombreParentesco = "---No ingresado---"
        tmpParentesco.Add(entParentesco)
        tmpParentesco.Clear()

        entParentesco.idParentesco = cmbParentescoAdic.SelectedValue

        If cmbParentescoAdic.SelectedIndex <> -1 And cmbParentescoAdic.SelectedIndex <> 0 Then
            ' listParentesco = biClsParentescoCampania.BuscarParentescoPorId(vgCampania.calCodigo, 2)

            For y As SByte = 0 To listParentesco.Count - 1
                If entParentesco.idParentesco = listParentesco(y).idParentesco Then
                    entParentesco.edadMin = listParentesco(y).edadMin
                    entParentesco.edadMax = listParentesco(y).edadMax

                    Dim difFecha As String = DateDiff(DateInterval.Year, Date.Parse(dtFechaNacAdic.Text), Date.UtcNow)

                    If listParentesco(y).edadMin <= difFecha And listParentesco(y).edadMax > difFecha Then
                        LlenaParentescoCondicion = True
                    End If

                    If listParentesco(y).edadMax = difFecha Then
                        LlenaParentescoCondicion = False
                    End If

                    Dim listRestriccion As New List(Of eRestriccion)
                    For x As SByte = 0 To listPlanes.Count - 1
                        planE = biClsPlan.BuscarPlanPorIdPlan(listPlanes(x).idPlan)

                        listRestriccion = biClsRestricion.BuscarRestriccionPorIdPlan(planE.idPlan)
                        Dim count As Int16 = 0
                        For i As SByte = 0 To listRestriccion.Count - 1
                            restricionE.idRestriccionPlan = listRestriccion(i).idRestriccionPlan
                            restricionE.idPlan = listRestriccion(i).idPlan
                            restricionE.operacion = listRestriccion(i).operacion

                            Select Case listRestriccion(i).operacion
                                Case ">"
                                    If difFecha < listRestriccion(i).valorRestriccion Then
                                        count += 1
                                    End If
                                Case "<"
                                    If difFecha > listRestriccion(i).valorRestriccion Then
                                        count += 1
                                    End If
                                Case "="
                                    If difFecha <> listRestriccion(i).valorRestriccion Then
                                        count += 1
                                    End If
                            End Select
                        Next

                        If count <= 0 Then
                            ufAdic = planE.primaUF
                            idPlanAdic = planE.idPlan
                            totalUfAdic = CDbl(totalUfAdic) + CDbl(ufAdic)
                            sumaUFAdicionales()

                        End If
                    Next

                End If
            Next
        Else
            MsgBox("Debe ingresar un parentezco.", vbExclamation, csNombreAplicacion)
        End If

        Return LlenaParentescoCondicion
    End Function


    Private Sub ValidaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroV.KeyPress, txtRutV.KeyPress, txtFonoVenta.KeyPress
        vgFuncionComun.validaNumeros(e)
    End Sub
    Private Sub txtCalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalleV.KeyPress, txtNombreV.KeyPress, txtPaternoV.KeyPress, txtMaternoV.KeyPress, txtReferenciaV.KeyPress, txtEmail.KeyPress
        vgFuncionComun.validaCaracter(e)
    End Sub

    Private Sub txtRutcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExclusiones_Click(sender As Object, e As EventArgs) Handles btnExclusiones.Click
        frmExclusiones.ShowDialog()
    End Sub

    Private Sub ComboBoxReconoce_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbReconoce.SelectedIndex = 1 Then
            CmbInteresa.Visible = True
            lblInteresa.Visible = True
        Else
            CmbInteresa.Visible = False
            lblInteresa.Visible = False
        End If
    End Sub

    Private Sub tmLabelRegrabacion_Tick(sender As Object, e As EventArgs) Handles tmLabelRegrabacion.Tick
        If lblRegrabacion.ForeColor = Color.Red Then
            lblRegrabacion.ForeColor = Color.Yellow
        Else
            lblRegrabacion.ForeColor = Color.Red
        End If
    End Sub

    Dim TiempoInicioPostView As DateTime


    Private Sub btnDescanso_Click(sender As Object, e As EventArgs) Handles btnDescanso.Click
        frmDescanso.ShowDialog()
    End Sub

    Private Sub TmrPostView_Tick(sender As Object, e As EventArgs) Handles tmrPostview.Tick

        lblSegundos.Text += 1
        If lblSegundos.Text.Length = 1 Then lblSegundos.Text = "0" + lblSegundos.Text
        If lblSegundos.Text = "60" Then
            lblMinutos.Text += 1
            If lblMinutos.Text.Length = 1 Then lblMinutos.Text = "0" + lblMinutos.Text
            lblSegundos.Text = 0
        End If
        If lblMinutos.Text = 60 Then
            lblHora.Text += 1
            lblMinutos.Text = 0
        End If

    End Sub

    Private Sub cmbTipoContratoCotiza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoContratoCotiza.SelectedIndexChanged

        If cmbTipoContratoCotiza.SelectedIndex < 0 Then Exit Sub


        If cmbTipoContratoCotiza.SelectedIndex <> -1 And cmbTipoContratoCotiza.SelectedIndex <> 0 Then
            'LlenaPlanesCondicion()
            llenar_planesCotiza()
            If vgListTipoContrato.Item(cmbTipoContratoCotiza.SelectedIndex).cantidadAdicionales <> 0 Then
                btnAdicionales.Visible = True
            Else
                btnAdicionales.Visible = False
            End If
        Else
            'lblPlanes.Visible = False
            'cmbPlanes.Visible = False
            lblPrimaUF.Text = "0"
            lblPrimaPesos.Text = "0"
            btnAdicionales.Visible = False
            btnBeneficiarios.Visible = False
        End If

    End Sub

    Private Sub btnAdicionales_Click(sender As Object, e As EventArgs) Handles btnAdicionales.Click
        Cuerpo.TabPages.Add(_Cuerpo_Adicionales)
        totalUfAdic = 0
        listParentescoCampania = biClsParentescoCampania.BuscarParentescoPorId(vgCampania.idCRM, 2)
        vgFuncionComun.llenaComboBox(cmbParentescoAdic, "nombreParentesco", "idParentesco", listParentescoCampania.ToArray)

        'sumaUFAdicionales()
        limpiaAdicionales()

        Cuerpo.TabPages.Item(0).Parent = Nothing
        guardarPantallaAnterior(0)
    End Sub

    Private Sub llenar_planesCotiza()

        Dim biplan As New clsPlanBI

        vgListPlanes = biplan.BuscarPlanPorTipoContrato(cmbTipoContratoCotiza.SelectedValue, vgCampania.idCRM)

        If vgListPlanes.Count > 1 Then
            vgFuncionComun.llenaComboBox(cmbPlanCotiza, "descripcionPlan", "idPlan", vgListPlanes.ToArray)
        End If
    End Sub

    Private Sub btnCotizar_Click(sender As Object, e As EventArgs) Handles btnCotizar.Click

        If validaDatosCotiza() = True Then
            Dim edad As Integer
            Dim nombrePlan As String
            Dim tipoContrato As Integer
            Dim dt As New DataTable


            lblNombrePlan.Text = "PLAN: "
            lblPrimaUF.Text = "Prima Uf: "
            lblPrimaPesos.Text = "Prima Pesos: "
            lblIdPlan.Text = "0"

            nombrePlan = cmbPlanCotiza.Text
            tipoContrato = cmbTipoContratoCotiza.SelectedValue

            If tipoContrato <> 1 Then

                For i As Integer = 0 To lstAdi.Count - 1
                    If vgFuncionComun.edad(lstAdi(i).A_FechaNacimiento) > vgFuncionComun.edad(dtFechaNacimientoCotiza.Value) Then
                        edad = vgFuncionComun.edad(lstAdi(i).A_FechaNacimiento)
                    Else
                        If edad < vgFuncionComun.edad(dtFechaNacimientoCotiza.Value) Then
                            edad = vgFuncionComun.edad(dtFechaNacimientoCotiza.Value)
                        End If
                    End If
                Next
            Else
                edad = vgFuncionComun.edad(dtFechaNacimientoCotiza.Value)
            End If


            dt = biCLSPoliza.BuscarCotizacion(edad, nombrePlan, tipoContrato, vgCampania.idCRM)

            If dt.Rows.Count > 0 Then

                lblNombrePlan.Text = "PLAN: " & dt.Rows(0)("NombrePlan") & " " & dt.Rows(0)("TipoContrato")

                lblPrimaUfCotiza.Text = "Prima Uf: " & dt.Rows(0)("PrimaUf")
                lblPrimaPesosCotiza.Text = "Prima Pesos: " & dt.Rows(0)("PrimaPesos")
                lblIdPlan.Text = dt.Rows(0)("IdPlan")

            Else
                lblNombrePlan.Text = "PLAN: "
                lblPrimaUfCotiza.Text = "Prima Uf: "
                lblPrimaPesosCotiza.Text = "Prima Pesos: "
                lblIdPlan.Text = "0"
                MsgBox("No se puede realizar cotizacion con los datos ingresados", vbInformation, csNombreAplicacion)
            End If


        End If
    End Sub

    Private Function validaDatosCotiza() As Boolean
        validaDatosCotiza = False


        'If Not vgFuncionComun.edad(dtFechaNacimientoCotiza.Value, csEdadMinima, csEdadMaxima) Then
        '    MsgBox("La fecha de nacimiento no es válida.", vbInformation, "Callsouth.")
        '    dtFechaNacimientoCotiza.Focus()
        '    Exit Function
        'End If

        If cmbPlanCotiza.SelectedIndex <= -1 Then
            MsgBox("Debe ingresar plan valido.", vbInformation, "Callsouth.")
            cmbPlanCotiza.Focus()
            Exit Function
        End If

        If cmbTipoContratoCotiza.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar tipo Contrato valido.", vbInformation, "Callsouth.")
            cmbTipoContratoCotiza.Focus()
            Exit Function
        End If


        If cmbTipoContratoCotiza.SelectedValue > 1 Then
            If lstAdi.Count <> (cmbTipoContratoCotiza.SelectedIndex - 1) Then
                MsgBox("Cantidad Adicionales no coincide con tipo Contrato, Favor Verificar.", vbInformation, "Callsouth.")
                cmbTipoContratoCotiza.Focus()
                Exit Function
            End If

        End If


        validaDatosCotiza = True

    End Function

    Private Sub btnGuardarCotizacion_Click(sender As Object, e As EventArgs) Handles btnGuardarCotizacion.Click
        If lblIdPlan.Text = "0" Then
            MsgBox("Debe cotizar primero antes de guardar", vbInformation, csNombreAplicacion)
            Exit Sub
        End If

        Dim edad As Integer
        Dim nombrePlan As String
        Dim tipoContrato As Integer

        nombrePlan = cmbPlanCotiza.Text
        tipoContrato = cmbTipoContratoCotiza.SelectedValue

        If tipoContrato <> 1 Then

            For i As Integer = 0 To lstAdi.Count - 1
                If vgFuncionComun.edad(lstAdi(i).A_FechaNacimiento) > vgFuncionComun.edad(dtFechaNacimientoCotiza.Value) Then
                    edad = vgFuncionComun.edad(lstAdi(i).A_FechaNacimiento)
                Else
                    If edad < vgFuncionComun.edad(dtFechaNacimientoCotiza.Value) Then
                        edad = vgFuncionComun.edad(dtFechaNacimientoCotiza.Value)
                    End If
                End If
            Next
        Else
            edad = vgFuncionComun.edad(dtFechaNacimientoCotiza.Value)
        End If

        If MsgBox("Desea ingresar la cotizacion con estos parametros" & vbNewLine & vbNewLine & "Edad Maxima: " & edad.ToString & " años" & vbNewLine & "Plan: " & nombrePlan.ToString & vbNewLine & "Tipo Contrato: " & cmbTipoContratoCotiza.Text, vbInformation + vbYesNo, csNombreAplicacion) = vbNo Then Exit Sub

        If biCLSPoliza.IngresarCotizacion(CLIENTE.C_Id, edad, nombrePlan, tipoContrato, dtFechaNacimientoCotiza.Value.ToString("yyyyMMdd")) = True Then
            MsgBox("Cotizacion ingresada exitosamente", vbInformation, csNombreAplicacion)

            dtCotizaciones.DataSource = biCLSPoliza.cargaCotizacionesCliente(CLIENTE.C_Id)
            dtCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            CLIENTE.C_Fecha_Nacimiento = dtFechaNacimientoCotiza.Value.ToString("yyyyMMdd")
            limpiaControlesCotiza()
        Else
            MsgBox("No se pudo ingresar cotizacion", vbInformation, csNombreAplicacion)
        End If

    End Sub

    Public Sub limpiaControlesCotiza()

        dtFechaNacimientoCotiza.Value = dtFechaNacimientoCotiza.MaxDate
        cmbPlanCotiza.SelectedIndex = -1
        cmbTipoContratoCotiza.SelectedIndex = -1
        lblNombrePlan.Text = "PLAN: "
        lblPrimaUF.Text = "Prima Uf: "
        lblPrimaPesos.Text = "Prima Pesos: "
        lblIdPlan.Text = "0"


    End Sub

    Private Sub asignaDatosCotiza()


        For I As Integer = 0 To dtCotizaciones.Rows.Count
            If dtCotizaciones.Item(0, I).Value = True Then
                CLIENTE.C_Edad = dtCotizaciones.Item(1, I).Value
                Select Case dtCotizaciones.Item(3, I).Value.ToString

                    Case "Solo para Titular"
                        GESTION.G_TipoContrato = 1
                        poliza.tipoContrato = 1
                    Case "Titular + 1 Adicional"
                        GESTION.G_TipoContrato = 2
                        poliza.tipoContrato = 2
                    Case "Titular + 2 Adicional"
                        GESTION.G_TipoContrato = 3
                        poliza.tipoContrato = 3
                    Case "Titular + 3 Adicional"
                        GESTION.G_TipoContrato = 4
                        poliza.tipoContrato = 4
                    Case "Titular + 4 Adicional"
                        GESTION.G_TipoContrato = 5
                        poliza.tipoContrato = 5
                    Case "Titular + 5 Adicional"
                        GESTION.G_TipoContrato = 6
                        poliza.tipoContrato = 6
                    Case "Titular + 6 Adicional"
                        GESTION.G_TipoContrato = 7
                        poliza.tipoContrato = 7
                    Case "Titular + 7 Adicional"
                        GESTION.G_TipoContrato = 51
                        poliza.tipoContrato = 51
                    Case "Titular + 8 Adicional"
                        GESTION.G_TipoContrato = 52
                        poliza.tipoContrato = 52
                    Case "Titular + 9 Adicional"
                        GESTION.G_TipoContrato = 53
                        poliza.tipoContrato = 53
                    Case "Titular + 10 Adicional"
                        GESTION.G_TipoContrato = 54
                        poliza.tipoContrato = 54
                End Select
                'CLIENTE.cli_plan = IIf(dtCotizaciones.Item(4, I).Value = "Plan 1 CATASTROFICO + EXONERACION", 1, 2)
                GESTION.G_Plan = dtCotizaciones.Item(8, I).Value
                GESTION.G_Prima_Uf = dtCotizaciones.Item(5, I).Value
                GESTION.G_Prima_Pesos = dtCotizaciones.Item(6, I).Value
                GESTION.G_Fecha_Nacimiento = dtCotizaciones.Item(7, I).Value

                poliza.plan = dtCotizaciones.Item(8, I).Value
                'poliza.CLI_PLAN = IIf(dtCotizaciones.Item(4, I).Value = "Plan 1 CATASTROFICO + EXONERACION", 1, 2)
                poliza.primaUf = dtCotizaciones.Item(5, I).Value
                poliza.primaPesos = dtCotizaciones.Item(6, I).Value
                poliza.fecha_Nacimiento = dtCotizaciones.Item(7, I).Value
                Exit For
            End If
        Next

    End Sub

    Private Sub cmdSiguientePoliza_Click(sender As Object, e As EventArgs) Handles cmdSiguientePoliza.Click

        Select Case cmbInteresaFinal.SelectedIndex
            Case 0, -1
                MsgBox("Selecione opción si cliente interesa Seguro", MsgBoxStyle.Exclamation, csNombreAplicacion)
                cmbInteresaFinal.Focus()
                Exit Sub
            Case 1

                If dtCotizaciones.Rows.Count <= 0 Then
                    MsgBox("Debe ingresar cotización para el cliente", vbInformation, "CORDIALPHONE")
                    Exit Sub
                End If
                Dim seleccionado As Boolean = False

                For i As Integer = 0 To dtCotizaciones.Rows.Count - 1

                    If dtCotizaciones.Rows(i).Cells("chkCotizacion").Value = True Then
                        seleccionado = True
                        planCotiza = dtCotizaciones.Rows(i).Cells("IdPlan").Value
                        tipoContratoCotiza = dtCotizaciones.Rows(i).Cells("IDTipoContrato").Value
                        primaUfCotiza = dtCotizaciones.Rows(i).Cells("primaUf").Value
                        primaPesosCotiza = dtCotizaciones.Rows(i).Cells("PrimaPesos").Value
                        fechaNacimientoCotiza = dtCotizaciones.Rows(i).Cells("FechaNacimientoCot").Value
                    End If
                Next

                If seleccionado = False Then
                    MsgBox("Debe seleccionar cotización para el cliente", vbInformation, "CORDIALPHONE")
                    Exit Sub
                End If

                If cmbTipoContratoCotiza.SelectedIndex = 1 Then
                    lstAdi.Clear()
                    dtAdicional.Rows.Clear()
                End If

                btnAvanzarSinIngresar.Visible = False
                Cuerpo.TabPages.Add(_Cuerpo_DatosCli)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                ' llenarTipoContrato()
                ' llenar_planes()

                GESTION.G_Contacto_Flujo = Trim(cmbInteresaFinal.Text)
                btnAdicional.Visible = False
                btnBeneficiarios.Visible = False
                AsignadatosCli()
                guardarPantallaAnterior(0)

            Case 2 ' NO
                GESTION.G_Contacto_Flujo = Trim(cmbInteresaFinal.Text)
                Cuerpo.TabPages.Add(_Cuerpo_Objeciones)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(0)

            Case 3 'lo pensara

                GESTION.G_Contacto_Flujo = Trim(cmbInteresaFinal.Text)
                Cuerpo.TabPages.Add(_Cuerpo_Agenda2)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(0)

        End Select






    End Sub

    Private Sub dtCotizaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCotizaciones.CellContentClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Dim row As DataGridViewRow = dtCotizaciones.Rows(e.RowIndex)



        If dtCotizaciones.Rows(e.RowIndex).Cells("chkCotizacion").Value = True Then
            dtCotizaciones.Rows(e.RowIndex).Cells("chkCotizacion").Value = False
        Else
            dtCotizaciones.Rows(e.RowIndex).Cells("chkCotizacion").Value = True

            dtFechaNacimientoCotiza.Value = dtCotizaciones.Rows(e.RowIndex).Cells("FechaNacimientoCot").Value
            cmbTipoContratoCotiza.Text = dtCotizaciones.Rows(e.RowIndex).Cells("tipoContratoPlan").Value
            cmbPlanCotiza.SelectedIndex = 1

            For i As Integer = 0 To dtCotizaciones.Rows.Count - 1
                If i <> e.RowIndex Then
                    dtCotizaciones.Rows(i).Cells("chkCotizacion").Value = False
                End If
            Next

        End If



    End Sub


    Private Sub rdbNoPagador_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNoPagador.CheckedChanged, rdbSiPagador.CheckedChanged
        If rdbNoPagador.Checked = True Then
            gpbPagador.Visible = False
            txtRutPagador.Text = ""
            txtNombrePagador.Text = ""
            txtDvPagador.Text = ""

        ElseIf rdbSiPagador.Checked = True Then
            gpbPagador.Visible = True
            txtRutPagador.Text = ""
            txtNombrePagador.Text = ""
            txtDvPagador.Text = ""

        End If
    End Sub

    Private Sub cmbNuevaPoliza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNuevaPoliza.SelectedIndexChanged
        Select Case cmbNuevaPoliza.SelectedIndex
            Case 1
                btnSiguientePoliza.Visible = True
                lblIngresoMP.Visible = False
                cmbIngresaMedioPago.Visible = False
                cmbIngresaMedioPago.SelectedIndex = 0
                chkGiftcard.Visible = False
                cmbGiftCard.Visible = False
            Case 2
                btnSiguientePoliza.Visible = False
                lblIngresoMP.Visible = True
                cmbIngresaMedioPago.Visible = True
                cmbIngresaMedioPago.SelectedIndex = 0
                chkGiftcard.Visible = True
                chkGiftcard.Checked = False
            Case Else
                btnSiguientePoliza.Visible = False
                lblIngresoMP.Visible = False
                cmbIngresaMedioPago.Visible = False
                cmbIngresaMedioPago.SelectedIndex = 0
                chkGiftcard.Visible = False
                chkGiftcard.Checked = False
        End Select

        If perfil <> "Ejecutivo" Then
            chkGiftcard.Visible = False
            chkGiftcard.Checked = False
        End If
    End Sub

    Private Sub btnSiguientePoliza_Click(sender As Object, e As EventArgs) Handles btnSiguientePoliza.Click


        dtCotizaciones.DataSource = biCLSPoliza.cargaCotizacionesCliente(CLIENTE.C_Id)
        dtCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        limpiaControlesCotiza()

        nuevapoliza = True

        Cuerpo.TabPages.Add(_Cuerpo_IngresoCli)
        Cuerpo.TabPages.Item(0).Parent = Nothing


    End Sub

    Private Sub cmbIngresaMedioPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIngresaMedioPago.SelectedIndexChanged
        Select Case cmbIngresaMedioPago.SelectedIndex
            Case 1
                lblPolizasPago.Visible = True
                dtgPolizasPago.Visible = True
                dtgPolizasPago.DataSource = biCLSPoliza.ListaPolizasPago(CLIENTE.C_Id)
                cmbMedioPago.SelectedIndex = 0
                btnGuardarPago.Visible = False
                cmdFinVenta.Visible = False
                lblFechaMandato.Visible = False
                lblHoraMandato.Visible = False
                dtpFechaMandato.Visible = False
                cmbHoraMandato.Visible = False
            Case 2
                lblPolizasPago.Visible = False
                dtgPolizasPago.Visible = False
                cmbMedioPago.SelectedIndex = 0
                btnGuardarPago.Visible = False
                cmdFinVenta.Visible = True
                lblFechaMandato.Visible = True
                lblHoraMandato.Visible = True
                dtpFechaMandato.Visible = True
                dtpFechaMandato.Value = Now()
                cmbHoraMandato.Visible = True
                cmbHoraMandato.SelectedIndex = -1
            Case Else
                lblPolizasPago.Visible = False
                dtgPolizasPago.Visible = False
                cmbMedioPago.SelectedIndex = 0
                btnGuardarPago.Visible = False
                cmdFinVenta.Visible = False
                lblFechaMandato.Visible = False
                lblHoraMandato.Visible = False
                dtpFechaMandato.Visible = False
                cmbHoraMandato.Visible = False
        End Select
    End Sub


    Private Sub cmbMedioPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedioPago.SelectedIndexChanged

        '0 [SELECCIONE]
        '1 PAC
        '2 PAT
        '3 CUENTA rut
        Select Case cmbMedioPago.SelectedIndex
            Case 0
                Panelotro.Visible = False
            Case 1
                Panelotro.Visible = True
                CmbBanco.Visible = True
                lblBanco.Visible = True
                CmbBanco.SelectedIndex = -1
                lblTipoTarjeta.Visible = False
                cmbTpoTarjeta.Visible = False
                cmbTpoTarjeta.SelectedIndex = -1
                lblNumeroCuenta.Visible = True
                txtNumeroCuenta.Visible = True
                txtNumeroCuenta.Text = ""

            Case 2
                Panelotro.Visible = True
                CmbBanco.Visible = True
                lblBanco.Visible = True
                CmbBanco.SelectedIndex = -1
                lblTipoTarjeta.Visible = True
                cmbTpoTarjeta.Visible = True
                cmbTpoTarjeta.SelectedIndex = -1
                lblNumeroCuenta.Visible = False
                txtNumeroCuenta.Visible = False
                txtNumeroCuenta.Text = ""
            Case 3
                Panelotro.Visible = True
                CmbBanco.Visible = True
                lblBanco.Visible = True
                CmbBanco.SelectedIndex = 5
                lblTipoTarjeta.Visible = False
                cmbTpoTarjeta.Visible = False
                cmbTpoTarjeta.SelectedIndex = -1
                lblNumeroCuenta.Visible = True
                txtNumeroCuenta.Visible = True
                txtNumeroCuenta.Text = ""

        End Select


    End Sub

    Private Sub dtgPolizasPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPolizasPago.CellContentClick
        If e.ColumnIndex = 0 Then
            If dtgPolizasPago.Rows(e.RowIndex).Cells(0).Value = False Then

                idPolizaParaPago = dtgPolizasPago.Rows(e.RowIndex).Cells("idPoliza").Value
                lblIngresoMedioPago.Visible = True
                lblMedioPago.Visible = True
                cmbMedioPago.Visible = True
                cmbMedioPago.SelectedIndex = 0
                btnGuardarPago.Visible = True
                dtgPolizasPago.Rows(e.RowIndex).Cells(0).Value = True

                For i As Integer = 0 To dtgPolizasPago.Rows.Count - 1
                    If i <> e.RowIndex Then
                        dtgPolizasPago.Rows(i).Cells(0).Value = False
                    End If
                Next
            ElseIf dtgPolizasPago.Rows(e.RowIndex).Cells(0).Value = True Then
                lblIngresoMedioPago.Visible = False
                lblMedioPago.Visible = False
                cmbMedioPago.Visible = False
                cmbMedioPago.SelectedIndex = 0
                btnGuardarPago.Visible = False
                dtgPolizasPago.Rows(e.RowIndex).Cells(0).Value = False
                idPolizaParaPago = 0
            End If
        End If
    End Sub

    Private Sub btnGuardarPago_Click(sender As Object, e As EventArgs) Handles btnGuardarPago.Click

        If idPolizaParaPago <> 0 Then

            If validaMedioPago() = True Then
                poliza.medio_pago = cmbMedioPago.Text
                poliza.banco = IIf(CmbBanco.SelectedIndex < 0, "", CmbBanco.Text)
                poliza.tipo_tarjeta = IIf(cmbTpoTarjeta.SelectedIndex <= 0, "", cmbTpoTarjeta.Text)
                poliza.nro_Cuenta = txtNumeroCuenta.Text.Trim

                biCLSPoliza.actualizaMedioPago(poliza, idPolizaParaPago)


                dtgPolizasPago.DataSource = biCLSPoliza.ListaPolizasPago(CLIENTE.C_Id)

                lblIngresoMedioPago.Visible = False
                lblMedioPago.Visible = False
                cmbMedioPago.Visible = False
                cmbMedioPago.SelectedIndex = 0
                btnGuardarPago.Visible = False
                lblTipoTarjeta.Visible = False
                cmbTpoTarjeta.Visible = False
                lblBanco.Visible = False
                CmbBanco.Visible = False
                lblNumeroCuenta.Visible = False
                txtNumeroCuenta.Visible = False
                Panelotro.Visible = False

                For i As Integer = 0 To dtgPolizasVigentes.Rows.Count - 1
                    If dtgPolizasVigentes.Rows(i).Cells(0).Value = "NO PAGADO" Then
                        dtgPolizasVigentes.Rows(i).Cells(0).Style.ForeColor = Color.Red
                    ElseIf dtgPolizasVigentes.Rows(i).Cells(0).Value = "POLIZA PAGADA" Then
                        dtgPolizasVigentes.Rows(i).Cells(0).Style.ForeColor = Color.Green
                    End If
                Next

                dtgPolizasVigentes.DataSource = biCLSPoliza.ListaPolizas(CLIENTE.C_Id)

                If dtgPolizasPago.Rows.Count <= 0 Then
                    cmdFinVenta.Visible = True
                Else
                    cmdFinVenta.Visible = False
                End If

            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnAvanzarSinIngresar_Click(sender As Object, e As EventArgs) Handles btnAvanzarSinIngresar.Click

        poblarComboboxGiftCard()
        clsScript = CargaScript(6)
        WebBrowsercierre.DocumentText = clsScript.contenidoScript

        Cuerpo.TabPages.Add(_Cuerpo_UltInfo)
        Cuerpo.TabPages.Item(0).Parent = Nothing
        guardarPantallaAnterior(3)
    End Sub

    Private Sub cmbReconoce_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReconoce.SelectedIndexChanged

        Select Case cmbReconoce.SelectedIndex
            Case 1
                CmbInteresa.Visible = True
                lblInteresa.Visible = True
                CmbInteresa.SelectedIndex = 0
                lblModificaDatos.Visible = False
                cmbModificaDatos.Visible = False
                cmbModificaDatos.SelectedIndex = 0
                gpbModificaDatos.Visible = False
                txtRutPoliza.Visible = False
                lblRutPoliza.Visible = False
                txtDvPoliza.Visible = False
                txtRutPoliza.Text = ""
                txtDvPoliza.Text = ""
                btnModificarDatos.Visible = False
                btnEliminarPoliza.Visible = False
                btnTerminarPolizas.Visible = False
                btnSiguientePolizas.Visible = False
                lblClickAdicional.Visible = False
            Case 2
                CmbInteresa.Visible = False
                lblInteresa.Visible = False
                CmbInteresa.SelectedIndex = 0
                lblRutPoliza.Visible = False
                lblModificaDatos.Visible = False
                cmbModificaDatos.Visible = False
                cmbModificaDatos.SelectedIndex = 0
                gpbModificaDatos.Visible = False
                txtRutPoliza.Visible = False
                txtDvPoliza.Visible = False
                txtRutPoliza.Text = ""
                txtDvPoliza.Text = ""
                btnModificarDatos.Visible = False
                btnEliminarPoliza.Visible = False
                btnTerminarPolizas.Visible = True
                btnSiguientePolizas.Visible = False
                lblClickAdicional.Visible = False
            Case Else
                CmbInteresa.Visible = False
                lblInteresa.Visible = False
                CmbInteresa.SelectedIndex = 0
                lblRutPoliza.Visible = False
                lblModificaDatos.Visible = False
                cmbModificaDatos.Visible = False
                cmbModificaDatos.SelectedIndex = 0
                gpbModificaDatos.Visible = False
                txtRutPoliza.Visible = False
                txtDvPoliza.Visible = False
                txtRutPoliza.Text = ""
                txtDvPoliza.Text = ""
                btnModificarDatos.Visible = False
                btnEliminarPoliza.Visible = False
                btnTerminarPolizas.Visible = False
                btnSiguientePolizas.Visible = False
                lblClickAdicional.Visible = False
        End Select
    End Sub

    Private Sub cmbModificaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModificaDatos.SelectedIndexChanged
        If cmbModificaDatos.SelectedIndex = 1 Then
            gpbModificaDatos.Visible = True
            txtRutPoliza.Visible = False
            lblRutPoliza.Visible = False
            txtDvPoliza.Visible = False
            txtRutPoliza.Text = ""
            txtDvPoliza.Text = ""
            btnModificarDatos.Visible = False
            btnEliminarPoliza.Visible = False
            btnTerminarPolizas.Visible = False
            btnSiguientePolizas.Visible = False
            lblClickAdicional.Visible = False
        ElseIf cmbModificaDatos.SelectedIndex = 2 Then
            gpbModificaDatos.Visible = False
            lblRutPoliza.Visible = False
            txtRutPoliza.Visible = False
            txtDvPoliza.Visible = False
            txtRutPoliza.Text = ""
            txtDvPoliza.Text = ""
            btnModificarDatos.Visible = False
            btnEliminarPoliza.Visible = False
            btnTerminarPolizas.Visible = True
            btnSiguientePolizas.Visible = False
            lblClickAdicional.Visible = False
        Else
            gpbModificaDatos.Visible = False
            lblRutPoliza.Visible = False
            txtRutPoliza.Visible = False
            txtDvPoliza.Visible = False
            txtRutPoliza.Text = ""
            txtDvPoliza.Text = ""
            btnModificarDatos.Visible = False
            btnEliminarPoliza.Visible = False
            btnTerminarPolizas.Visible = False
            btnSiguientePolizas.Visible = False
            lblClickAdicional.Visible = False
        End If
    End Sub

    Private Sub CmbInteresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbInteresa.SelectedIndexChanged

        Select Case CmbInteresa.SelectedIndex


            Case 1
                lblModificaDatos.Visible = True
                cmbModificaDatos.Visible = True
                cmbModificaDatos.SelectedIndex = 0
                gpbModificaDatos.Visible = False
                lblRutPoliza.Visible = False
                txtRutPoliza.Visible = False
                txtDvPoliza.Visible = False
                txtRutPoliza.Text = ""
                txtDvPoliza.Text = ""
                btnModificarDatos.Visible = False
                btnEliminarPoliza.Visible = False
                btnSiguientePolizas.Visible = False
                btnTerminarPolizas.Visible = False
                lblClickAdicional.Visible = False
            Case 2, 3
                lblModificaDatos.Visible = False
                cmbModificaDatos.Visible = False
                cmbModificaDatos.SelectedIndex = 0
                gpbModificaDatos.Visible = False
                lblRutPoliza.Visible = False
                txtRutPoliza.Visible = False
                txtDvPoliza.Visible = False
                txtRutPoliza.Text = ""
                txtDvPoliza.Text = ""
                btnModificarDatos.Visible = False
                btnEliminarPoliza.Visible = False
                btnSiguientePolizas.Visible = True
                btnTerminarPolizas.Visible = False
                lblClickAdicional.Visible = False
            Case Else
                lblModificaDatos.Visible = False
                cmbModificaDatos.Visible = False
                cmbModificaDatos.SelectedIndex = 0
                gpbModificaDatos.Visible = False
                lblRutPoliza.Visible = False
                txtRutPoliza.Visible = False
                txtDvPoliza.Visible = False
                txtRutPoliza.Text = ""
                txtDvPoliza.Text = ""
                btnModificarDatos.Visible = False
                btnEliminarPoliza.Visible = False
                btnSiguientePolizas.Visible = False
                btnTerminarPolizas.Visible = False
                lblClickAdicional.Visible = False

        End Select




    End Sub

    Private Sub btnModificarDatos_MouseEnter(sender As Object, e As EventArgs) Handles btnModificarDatos.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub btnEliminarPoliza_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminarPoliza.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub btnModificarDatos_MouseLeave(sender As Object, e As EventArgs) Handles btnModificarDatos.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnEliminarPoliza_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminarPoliza.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSiguientePolizas_Click(sender As Object, e As EventArgs) Handles btnSiguientePolizas.Click

        If cmbReconoce.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar opcion si cliente Reconoce venta", vbExclamation, "CORDIALPHONE")
            CmbInteresa.Focus()
            Exit Sub
        End If


        If CmbInteresa.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar opcion si cliente Interesa Seguro", vbExclamation, "CORDIALPHONE")
            CmbInteresa.Focus()
            Exit Sub
        End If


        Select Case cmbReconoce.SelectedIndex
            Case 1
                Select Case CmbInteresa.SelectedIndex
                    Case 1


                    Case 2 ' NO
                        RECUPERACION.R_Reconoce = Trim(cmbReconoce.Text)
                        RECUPERACION.R_Contacto_Flujo = Trim(CmbInteresa.Text)
                        Cuerpo.TabPages.Add(_Cuerpo_Objeciones)
                        Cuerpo.TabPages.Item(0).Parent = Nothing
                        guardarPantallaAnterior(14)

                    Case 3 'lo pensara
                        RECUPERACION.R_Reconoce = Trim(cmbReconoce.Text)
                        RECUPERACION.R_Contacto_Flujo = Trim(CmbInteresa.Text)
                        Cuerpo.TabPages.Add(_Cuerpo_Agenda2)
                        Cuerpo.TabPages.Item(0).Parent = Nothing
                        guardarPantallaAnterior(14)

                End Select
            Case 2
                RECUPERACION.R_Reconoce = Trim(cmbReconoce.Text)
                RECUPERACION.R_Contacto_Flujo = ""
                Cuerpo.TabPages.Add(_Cuerpo_FinNC)
                Cuerpo.TabPages.Item(0).Parent = Nothing
                guardarPantallaAnterior(14)

        End Select


    End Sub



    Private Sub dtgPolizasRegrabacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPolizasRegrabacion.CellContentClick

        If cmbModificaDatos.SelectedIndex = 1 Then
            If dtgPolizasRegrabacion.Rows(e.RowIndex).Cells("PLAN_POLIZA").Value = "PLAN FAMILIAR" Then

                Dim row As DataGridViewRow = dtgPolizasRegrabacion.Rows(e.RowIndex)

                lblRutPoliza.Visible = True
                txtRutPoliza.Visible = True
                txtDvPoliza.Visible = True
                btnModificarDatos.Visible = True
                btnEliminarPoliza.Visible = False
                txtRutPoliza.Text = dtgPolizasRegrabacion.Rows(e.RowIndex).Cells("RUT").Value
                txtDvPoliza.Text = dtgPolizasRegrabacion.Rows(e.RowIndex).Cells("DV").Value
                idPolizaRegrabacion = e.RowIndex
                lblClickAdicional.Visible = False
            Else
                lblClickAdicional.Visible = True
                lblRutPoliza.Visible = False
                txtRutPoliza.Visible = False
                txtDvPoliza.Visible = False
                btnModificarDatos.Visible = False
                btnEliminarPoliza.Visible = False
                txtRutPoliza.Text = ""
                txtDvPoliza.Text = ""
            End If

        Else
            lblRutPoliza.Visible = False
            txtRutPoliza.Visible = False
            txtDvPoliza.Visible = False
            btnModificarDatos.Visible = False
            btnEliminarPoliza.Visible = False
            txtRutPoliza.Text = ""
            txtDvPoliza.Text = ""
            lblClickAdicional.Visible = False
        End If


    End Sub

    Private Sub limpiaControlRegrabacion()
        CmbInteresa.Visible = False
        lblInteresa.Visible = False
        CmbInteresa.SelectedIndex = 0
        cmbReconoce.SelectedIndex = 0
        lblModificaDatos.Visible = False
        cmbModificaDatos.Visible = False
        cmbModificaDatos.SelectedIndex = 0
        gpbModificaDatos.Visible = False
        txtRutPoliza.Visible = False
        txtDvPoliza.Visible = False
        txtRutPoliza.Text = ""
        txtDvPoliza.Text = ""
        btnModificarDatos.Visible = False
        lblRutPoliza.Visible = False
        btnEliminarPoliza.Visible = False
        btnTerminarPolizas.Visible = False
        btnSiguientePolizas.Visible = False
        lblClickAdicional.Visible = False
    End Sub

    Private Sub btnModificarDatos_Click(sender As Object, e As EventArgs) Handles btnModificarDatos.Click

        idPolizaRegrabacion = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("IDPOLIZA").Value
        txtRutV.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("RUT").Value
        txtDvV.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("DV").Value
        txtNombreV.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("NOMBRE").Value
        txtPaternoV.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("PATERNO").Value
        txtMaternoV.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("MATERNO").Value
        dtFechaNacV.Value = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("FECHA_NACIMIENTO").Value
        txtCalleV.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("CALLE").Value
        txtNroV.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("NUMERO").Value
        txtReferenciaV.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("REFERENCIA").Value
        cmbComuna.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("COMUNA").Value
        cmbCiudad.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("CIUDAD").Value
        cmbIsapreCliente.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("SISTEMA_SALUD").Value
        txtPesoCliente.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("PESO").Value
        mskEstaturaCliente.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("ESTATURA").Value
        txtFonoVenta.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("FONO_VENTA").Value
        txtEmail.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("EMAIL").Value
        dtFechaNacV.Enabled = False
        txtRutV.Enabled = False
        txtDvV.Enabled = False
        lblTextPrimaUF.Visible = True
        lblTextPrimaPesos.Visible = True
        lblPrimaUF.Visible = True
        lblPrimaPesos.Visible = True
        btnAvanzarSinIngresar.Visible = False
        lblPrimaUF.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("PRIMAUF").Value
        lblPrimaPesos.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("PRIMAPESOS").Value

        Carga_adicionales()

        If dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("RUT_PAGADOR").Value <> "" Then
            rdbNoPagador.Checked = True
            txtRutPagador.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("RUT_PAGADOR").Value
            txtDvPagador.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("DV_PAGADOR").Value
            txtNombrePagador.Text = dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("NOMBRE_PAGADOR").Value
        Else
            rdbSiPagador.Checked = True
            txtRutPagador.Text = ""
            txtDvPagador.Text = ""
            txtNombrePagador.Text = ""
        End If

        MsgBox("Los siguientes datos no pueden ser modificados" & vbNewLine & "   - Fecha Nacimiento" & vbNewLine & "   - Rut" & vbNewLine & "   - Prima UF", vbInformation, "Informacion"
)
        Cuerpo.TabPages.Add(_Cuerpo_DatosCli)
        Cuerpo.TabPages.Item(0).Parent = Nothing
        ' llenarTipoContrato()
        ' llenar_planes()

        btnAdicional.Visible = True
        guardarPantallaAnterior(14)


    End Sub

    Private Sub btnEliminarPoliza_Click(sender As Object, e As EventArgs) Handles btnEliminarPoliza.Click
        If MsgBox("Esta seguro de eliminar la siguiente Poliza: " & vbNewLine & vbNewLine & "Rut: " & dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("RUT").Value & dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("DV").Value & vbNewLine & "Nombre: " & dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("NOMBRE").Value & " " & dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("PATERNO").Value & " " & dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("MATERNO").Value & vbNewLine & "Nota: Esto eliminara la poliza junto con sus adicionales ", vbExclamation + vbYesNo, csNombreAplicacion) = vbNo Then Exit Sub

        Dim clsPoliza As New clsPolizabBI
        Dim correcto As Boolean
        correcto = clsPoliza.eliminaPoliza(dtgPolizasRegrabacion.Rows(idPolizaRegrabacion).Cells("RUT").Value)
        If correcto = True Then
            MsgBox("Poliza fue eliminada", vbInformation, "CORDIALPHONE")
        End If

        Dim dt As New DataTable
        dt = clsPoliza.ListaPolizas(CLIENTE.C_Id)

        If dt.Rows.Count = 0 Then
            MsgBox("Cliente ya no cuenta con polizas para la venta", vbInformation, "CORDIALPHONE")
        Else
            dtgPolizasRegrabacion.DataSource = dt
            dtgPolizasRegrabacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If

    End Sub

    Private Sub btnTerminarPolizas_Click(sender As Object, e As EventArgs) Handles btnTerminarPolizas.Click
        RECUPERACION.R_Reconoce = cmbReconoce.Text
        If cmbReconoce.Text = "Si" Then
            RECUPERACION.R_Contacto_Flujo = CmbInteresa.Text
        Else
            RECUPERACION.R_Contacto_Flujo = ""
        End If

        RECUPERACION.R_Estado = "T"

        If cmbReconoce.Text = "Si" And CmbInteresa.Text = "Interesa" Then
            RECUPERACION.R_Venta = 1
            RECUPERACION.R_Fecha_Vta = Today.ToString("yyyyMMdd")
            RECUPERACION.R_Hora_Vta = TimeOfDay.ToString("HHmmss")
        Else
            RECUPERACION.R_Venta = 0
            RECUPERACION.R_Fecha_Vta = ""
            RECUPERACION.R_Hora_Vta = ""
        End If

        RECUPERACION.R_IdLlamada = WS_CALL_ID
        'CLIENTE.CLI_ESTADO_OBJECION_CALIDAD = 1
        biGesRes.GuardaClienteGes(CLIENTE, RECUPERACION, GESTION)
        biGesRes.ActualizaClienteVenta(CLIENTE, GESTION)


        MsgBox("Fin de la gestión. Presione ACEPTAR para salir del formulario.", MsgBoxStyle.Information, csNombreAplicacion)
        limpiarPrimeraPantalla()
        Me.Hide()
        frmRegrabaciones.ShowDialog()
        BuscaGes()
    End Sub

    Private Sub btnEliminarPolizaVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarPolizaVenta.Click
        frmPolizasAEliminar.ShowDialog()
        If sinPolizasAsociadas = True Then
            llenarTipoContrato()
            dtCotizaciones.DataSource = biCLSPoliza.cargaCotizacionesCliente(CLIENTE.C_Id)
            dtCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Cuerpo.TabPages.Add(_Cuerpo_IngresoCli)
            Cuerpo.TabPages.Item(0).Parent = Nothing
            guardarPantallaAnterior(1)
            sinPolizasAsociadas = False
        Else
            dtgPolizasVigentes.DataSource = biCLSPoliza.ListaPolizas(CLIENTE.C_Id)
            dtgPolizasVigentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            cargaGiftCardSegunPoliza()
        End If
    End Sub

    Private Sub btnCalcularIMC_Click(sender As Object, e As EventArgs) Handles btnCalcularIMC.Click
        If txtPesoCliente.Text.Trim = "0" Then
            MsgBox("Debe ingresar correctamente el peso", vbExclamation, "CordialPhone")
            txtPesoCliente.Focus()
            Exit Sub
        End If
        If mskEstaturaCliente.Text.Trim = "" Or mskEstaturaCliente.Text = " ." Or mskEstaturaCliente.Text = "0,00" Or mskEstaturaCliente.Text = "0.00" Or mskEstaturaCliente.Text = " .  " Then
            MsgBox("Debe ingresar correctamente la estatura", vbExclamation, "CordialPhone")
            mskEstaturaCliente.Focus()
            Exit Sub
        End If

        lblIMC.Text = calcularIMC(txtPesoCliente.Text, mskEstaturaCliente.Text)
    End Sub

    Public Function calcularIMC(peso As String, estatura As String) As String
        Dim imc As String
        Dim estaturaIMC As Double
        estaturaIMC = Replace(estatura, ".", ",") * Replace(estatura, ".", ",")

        imc = peso / estaturaIMC

        Return "IMC: " + Mid(imc, 1, 5)

    End Function

    Private Sub chkGiftcard_CheckedChanged(sender As Object, e As EventArgs) Handles chkGiftcard.CheckedChanged
        If chkGiftcard.Checked Then
            cmbGiftCard.Visible = True
            cargaGiftCardSegunPoliza()
        Else
            cmbGiftCard.Visible = False
        End If
    End Sub

    Private Sub cargaGiftCardSegunPoliza()
        Dim cantidadPolizas() As String = (From row As DataGridViewRow In dtgPolizasVigentes.Rows.Cast(Of DataGridViewRow)()
                                           Where Not row.IsNewRow
                                           Select CStr(row.Cells("IDPOLIZA").Value)).Distinct.ToArray

        cmbGiftCard.SelectedValue = Convert.ToInt16(cantidadPolizas.Count)
        cmbGiftCard.Enabled = False
    End Sub

    Private Sub poblarComboboxGiftCard()
        Dim giftCardBI As New clsGiftCardRegaloBI
        vgFuncionComun.llenaComboBox(cmbGiftCard, "descripcion", "cantidadPolizas", giftCardBI.ListaGiftCard.ToArray)
    End Sub

    Private Sub btnIMCAdicional_Click(sender As Object, e As EventArgs) Handles btnIMCAdicional.Click
        If txtPeso.Text.Trim = "0" Then
            MsgBox("Debe ingresar correctamente el peso", vbExclamation, "CordialPhone")
            txtPeso.Focus()
            Exit Sub
        End If
        If mskEstatura.Text.Trim = "" Or mskEstatura.Text = " ." Or mskEstatura.Text = "0,00" Or mskEstatura.Text = "0.00" Or mskEstatura.Text = " .  " Then
            MsgBox("Debe ingresar correctamente la estatura", vbExclamation, "CordialPhone")
            mskEstatura.Focus()
            Exit Sub
        End If
        lblIMCAdicional.Text = calcularIMC(txtPeso.Text, mskEstatura.Text)

    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        txtUsu.Text = UCase(txtUsu.Text)
        txtExtension.Text = UCase(txtExtension.Text)
        'txtUsu.SelectionStart = Len(txtUsu)
        'txtExtension.SelectionStart = Len(txtExtension)
        If txtUsu.Text = "" Or txtExtension.Text = "" Then
            MessageBox.Show("Debe completar los campos para transferir llamada")
        Else
            soap.Transferfir(txtUsu.Text, txtExtension.Text)
        End If
    End Sub
End Class