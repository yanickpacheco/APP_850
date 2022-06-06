<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVenta
#Region "Código generado por el Diseñador de Windows Forms "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
    End Sub
    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents FrmConex As System.Windows.Forms.GroupBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents _Cuerpo_Conex As System.Windows.Forms.TabPage
    Public WithEvents _Cuerpo_DatosCli As System.Windows.Forms.TabPage
    Public WithEvents _Label27_0 As System.Windows.Forms.Label
    Public WithEvents TxtObj As System.Windows.Forms.TextBox
    Public WithEvents FrmObj As System.Windows.Forms.GroupBox
    Public WithEvents CmbObj As System.Windows.Forms.ComboBox
    Public WithEvents _Cuerpo_Objeciones As System.Windows.Forms.TabPage
    Public WithEvents cmbMin As System.Windows.Forms.ComboBox
    Public WithEvents TxtObsA As System.Windows.Forms.TextBox
    Public WithEvents Label44 As System.Windows.Forms.Label
    Public WithEvents FrmAgendamiento As System.Windows.Forms.GroupBox
    Public WithEvents CmbEstAgenda As System.Windows.Forms.ComboBox
    Public WithEvents LblAgendar As System.Windows.Forms.Label
    Public WithEvents Label47 As System.Windows.Forms.Label
    Public WithEvents _Cuerpo_Agendar As System.Windows.Forms.TabPage
    Public WithEvents LblFinNoC As System.Windows.Forms.Label
    Public WithEvents _Cuerpo_FinNC As System.Windows.Forms.TabPage
    Public WithEvents CmbHora2 As System.Windows.Forms.ComboBox
    Public WithEvents CmbMin2 As System.Windows.Forms.ComboBox
    Public WithEvents TxtObsAgen2 As System.Windows.Forms.TextBox
    Public WithEvents Label58 As System.Windows.Forms.Label
    Public WithEvents Label57 As System.Windows.Forms.Label
    Public WithEvents Label56 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Label59 As System.Windows.Forms.Label
    Public WithEvents _Cuerpo_Agenda2 As System.Windows.Forms.TabPage
    Public WithEvents Cuerpo As System.Windows.Forms.TabControl
    Public WithEvents tmrEstadoLlamada As System.Windows.Forms.Timer
    Public WithEvents txtObsAgen As System.Windows.Forms.TextBox
    Public WithEvents txtFechaNacimiento As System.Windows.Forms.TextBox
    Public WithEvents txtIntentos As System.Windows.Forms.TextBox
    Public WithEvents TxtRut As System.Windows.Forms.TextBox
    Public WithEvents TxtId As System.Windows.Forms.TextBox
    Public WithEvents txtNombre As System.Windows.Forms.TextBox
    Public WithEvents Txt_Fono6 As System.Windows.Forms.TextBox
    Public WithEvents Txt_Fono5 As System.Windows.Forms.TextBox
    Public WithEvents Txt_Fono4 As System.Windows.Forms.TextBox
    Public WithEvents chkMute As System.Windows.Forms.CheckBox
    Public WithEvents txtCallId As System.Windows.Forms.TextBox
    Public WithEvents Txt_Fono_alt As System.Windows.Forms.TextBox
    Public WithEvents CmdLlamarAlt As System.Windows.Forms.Button
    Public WithEvents Txt_Fono3 As System.Windows.Forms.TextBox
    Public WithEvents Txt_Fono2 As System.Windows.Forms.TextBox
    Public WithEvents Txt_Fono1 As System.Windows.Forms.TextBox
    Public WithEvents CmdLlamar3 As System.Windows.Forms.Button
    Public WithEvents CmdLlamar2 As System.Windows.Forms.Button
    Public WithEvents CmdLlamar1 As System.Windows.Forms.Button
    Public WithEvents CmdLlamar4 As System.Windows.Forms.Button
    Public WithEvents CmdLlamar5 As System.Windows.Forms.Button
    Public WithEvents CmdLlamar6 As System.Windows.Forms.Button
    Public WithEvents lblFono6 As System.Windows.Forms.Label
    Public WithEvents lblFono5 As System.Windows.Forms.Label
    Public WithEvents Label91 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents lblFono2 As System.Windows.Forms.Label
    Public WithEvents lblFono3 As System.Windows.Forms.Label
    Public WithEvents lblFono1 As System.Windows.Forms.Label
    Public WithEvents lblFono4 As System.Windows.Forms.Label
    Public WithEvents fraPadTelefonos As System.Windows.Forms.GroupBox
    Public WithEvents lblObservacionAgenda As System.Windows.Forms.Label
    Public WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Public WithEvents lblIntentos As System.Windows.Forms.Label
    Public WithEvents lblRut As System.Windows.Forms.Label
    Public WithEvents lblIdCliente As System.Windows.Forms.Label
    Public WithEvents lblNombre As System.Windows.Forms.Label
    Public WithEvents gpbDatosInicio As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cuerpo = New System.Windows.Forms.TabControl()
        Me._Cuerpo_IngresoCli = New System.Windows.Forms.TabPage()
        Me.cmdSiguientePoliza = New System.Windows.Forms.Button()
        Me.gpbCotizacion = New System.Windows.Forms.GroupBox()
        Me.cmbInteresaFinal = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtCotizaciones = New System.Windows.Forms.DataGridView()
        Me.chkCotizacion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primaUf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primaPesos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoContratoPlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTipoContrato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoCot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardarCotizacion = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblNombrePlan = New System.Windows.Forms.Label()
        Me.lblPrimaUfCotiza = New System.Windows.Forms.Label()
        Me.lblPrimaPesosCotiza = New System.Windows.Forms.Label()
        Me.lblIdPlan = New System.Windows.Forms.Label()
        Me.dtFechaNacimientoCotiza = New System.Windows.Forms.DateTimePicker()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.btnCotizar = New System.Windows.Forms.Button()
        Me.cmbPlanCotiza = New System.Windows.Forms.ComboBox()
        Me.btnAdicionales = New System.Windows.Forms.Button()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.cmbTipoContratoCotiza = New System.Windows.Forms.ComboBox()
        Me._Cuerpo_Conex = New System.Windows.Forms.TabPage()
        Me.CmdSiguiente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbNoConecta = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbConecta = New System.Windows.Forms.ComboBox()
        Me.FrmConex = New System.Windows.Forms.GroupBox()
        Me.wbScriptBienvenida = New System.Windows.Forms.WebBrowser()
        Me.CmbComunicaCon = New System.Windows.Forms.ComboBox()
        Me.CmbComunicaTercero = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me._Cuerpo_MtvoLL = New System.Windows.Forms.TabPage()
        Me.btnExclusiones = New System.Windows.Forms.Button()
        Me.wbScriptPresentacion = New System.Windows.Forms.WebBrowser()
        Me.CmdSiguiente1 = New System.Windows.Forms.Button()
        Me._Cuerpo_DatosCli = New System.Windows.Forms.TabPage()
        Me.CmdSiguiente2 = New System.Windows.Forms.Button()
        Me.frmServicio = New System.Windows.Forms.GroupBox()
        Me.btnCalcularIMC = New System.Windows.Forms.Button()
        Me.lblIMC = New System.Windows.Forms.Label()
        Me.btnAvanzarSinIngresar = New System.Windows.Forms.Button()
        Me.txtDPSCliente = New System.Windows.Forms.TextBox()
        Me.lblDPS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbIsapreCliente = New System.Windows.Forms.ComboBox()
        Me.mskEstaturaCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPesoCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdbNoPagador = New System.Windows.Forms.RadioButton()
        Me.rdbSiPagador = New System.Windows.Forms.RadioButton()
        Me.gpbPagador = New System.Windows.Forms.GroupBox()
        Me.txtDvPagador = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtNombrePagador = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtRutPagador = New System.Windows.Forms.TextBox()
        Me.lblPrimaPesos = New System.Windows.Forms.Label()
        Me.lblPrimaUF = New System.Windows.Forms.Label()
        Me.lblTextPrimaPesos = New System.Windows.Forms.Label()
        Me.lblTextPrimaUF = New System.Windows.Forms.Label()
        Me.btnAdicional = New System.Windows.Forms.Button()
        Me.btnBeneficiarios = New System.Windows.Forms.Button()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.txtCalculaEdad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFonoVenta = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.lblTomaDireccion = New System.Windows.Forms.Label()
        Me.dtFechaNacV = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.txtReferenciaV = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNroV = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCalleV = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDvV = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRutV = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMaternoV = New System.Windows.Forms.TextBox()
        Me.txtPaternoV = New System.Windows.Forms.TextBox()
        Me.txtNombreV = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDatosCli = New System.Windows.Forms.Label()
        Me._Cuerpo_MPago = New System.Windows.Forms.TabPage()
        Me.CmdFinVentaMP = New System.Windows.Forms.Button()
        Me.Label90 = New System.Windows.Forms.Label()
        Me._Cuerpo_InfAdic = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.WebInfAdicional = New System.Windows.Forms.WebBrowser()
        Me._Cuerpo_Certifica = New System.Windows.Forms.TabPage()
        Me.wbScriptCertificacion = New System.Windows.Forms.WebBrowser()
        Me.cmbAceptaPrima = New System.Windows.Forms.ComboBox()
        Me.lblCargoTarjeta = New System.Windows.Forms.Label()
        Me.cmbAceptaContrato = New System.Windows.Forms.ComboBox()
        Me.lblAcepta = New System.Windows.Forms.Label()
        Me.cmdSiguienteFin = New System.Windows.Forms.Button()
        Me._Cuerpo_UltInfo = New System.Windows.Forms.TabPage()
        Me.cmbGiftCard = New System.Windows.Forms.ComboBox()
        Me.chkGiftcard = New System.Windows.Forms.CheckBox()
        Me.btnEliminarPolizaVenta = New System.Windows.Forms.Button()
        Me.dtpFechaMandato = New System.Windows.Forms.DateTimePicker()
        Me.cmbHoraMandato = New System.Windows.Forms.ComboBox()
        Me.lblFechaMandato = New System.Windows.Forms.Label()
        Me.lblHoraMandato = New System.Windows.Forms.Label()
        Me.lblPolizasPago = New System.Windows.Forms.Label()
        Me.btnGuardarPago = New System.Windows.Forms.Button()
        Me.dtgPolizasPago = New System.Windows.Forms.DataGridView()
        Me.seleccione = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.llave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoPlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblIngresoMP = New System.Windows.Forms.Label()
        Me.cmbIngresaMedioPago = New System.Windows.Forms.ComboBox()
        Me.lblIngresoMedioPago = New System.Windows.Forms.Label()
        Me.Panelotro = New System.Windows.Forms.Panel()
        Me.cmbTpoTarjeta = New System.Windows.Forms.ComboBox()
        Me.lblTipoTarjeta = New System.Windows.Forms.Label()
        Me.CmbBanco = New System.Windows.Forms.ComboBox()
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox()
        Me.lblNumeroCuenta = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.cmbMedioPago = New System.Windows.Forms.ComboBox()
        Me.lblMedioPago = New System.Windows.Forms.Label()
        Me.btnSiguientePoliza = New System.Windows.Forms.Button()
        Me.cmdFinVenta = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNuevaPoliza = New System.Windows.Forms.Label()
        Me.cmbNuevaPoliza = New System.Windows.Forms.ComboBox()
        Me.dtgPolizasVigentes = New System.Windows.Forms.DataGridView()
        Me.WebBrowsercierre = New System.Windows.Forms.WebBrowser()
        Me._Cuerpo_TabBenef = New System.Windows.Forms.TabPage()
        Me._Cuerpo_Adicionales = New System.Windows.Forms.TabPage()
        Me.btnAdicionalSgt = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIMCAdicional = New System.Windows.Forms.Label()
        Me.btnIMCAdicional = New System.Windows.Forms.Button()
        Me.dtAdicional = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_parentesco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idParentescoAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Isapre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDatosDPS = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.mskEstatura = New System.Windows.Forms.MaskedTextBox()
        Me.lblEstatura = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbIsapre = New System.Windows.Forms.ComboBox()
        Me.lblIsapre = New System.Windows.Forms.Label()
        Me.lblSexoA = New System.Windows.Forms.Label()
        Me.cmbSexoA = New System.Windows.Forms.ComboBox()
        Me.dtFechaNacAdic = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Parentesco = New System.Windows.Forms.Label()
        Me.cmbParentescoAdic = New System.Windows.Forms.ComboBox()
        Me.txtDvA = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtRutA = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtMaternoA = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtPaternoA = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me._Cuerpo_Objeciones = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmbNoIntereso = New System.Windows.Forms.ComboBox()
        Me._Label27_0 = New System.Windows.Forms.Label()
        Me.FrmObj = New System.Windows.Forms.GroupBox()
        Me.TxtObj = New System.Windows.Forms.TextBox()
        Me.CmbObj = New System.Windows.Forms.ComboBox()
        Me.CmdSiguiente11 = New System.Windows.Forms.Button()
        Me._Cuerpo_Agendar = New System.Windows.Forms.TabPage()
        Me.CmdSiguienteA = New System.Windows.Forms.Button()
        Me.CmdTerminarA = New System.Windows.Forms.Button()
        Me.FrmAgendamiento = New System.Windows.Forms.GroupBox()
        Me.DTFechaAgen = New System.Windows.Forms.DateTimePicker()
        Me.cmbHora = New System.Windows.Forms.ComboBox()
        Me.cmbMin = New System.Windows.Forms.ComboBox()
        Me.TxtObsA = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.CmbEstAgenda = New System.Windows.Forms.ComboBox()
        Me.LblAgendar = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me._Cuerpo_Agenda2 = New System.Windows.Forms.TabPage()
        Me.CmdTerminarA2 = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.DTAgenFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.CmbHora2 = New System.Windows.Forms.ComboBox()
        Me.CmbMin2 = New System.Windows.Forms.ComboBox()
        Me.TxtObsAgen2 = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me._Cuerpo_FinNC = New System.Windows.Forms.TabPage()
        Me.CmdTerminarNC = New System.Windows.Forms.Button()
        Me.LblFinNoC = New System.Windows.Forms.Label()
        Me._Cuerpo_Polizas = New System.Windows.Forms.TabPage()
        Me.btnTerminarPolizas = New System.Windows.Forms.Button()
        Me.btnSiguientePolizas = New System.Windows.Forms.Button()
        Me.gpbModificaDatos = New System.Windows.Forms.GroupBox()
        Me.lblClickAdicional = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnEliminarPoliza = New System.Windows.Forms.Button()
        Me.btnModificarDatos = New System.Windows.Forms.Button()
        Me.txtDvPoliza = New System.Windows.Forms.TextBox()
        Me.lblRutPoliza = New System.Windows.Forms.Label()
        Me.txtRutPoliza = New System.Windows.Forms.TextBox()
        Me.cmbModificaDatos = New System.Windows.Forms.ComboBox()
        Me.lblModificaDatos = New System.Windows.Forms.Label()
        Me.cmbReconoce = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CmbInteresa = New System.Windows.Forms.ComboBox()
        Me.lblInteresa = New System.Windows.Forms.Label()
        Me.dtgPolizasRegrabacion = New System.Windows.Forms.DataGridView()
        Me.tmrEstadoLlamada = New System.Windows.Forms.Timer(Me.components)
        Me.gpbDatosInicio = New System.Windows.Forms.GroupBox()
        Me.lblSegundos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.lblSeparador1 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblTiempoPostView = New System.Windows.Forms.Label()
        Me.btnDescanso = New System.Windows.Forms.Button()
        Me.lblRegrabacion = New System.Windows.Forms.Label()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.gpbDatosClientes = New System.Windows.Forms.GroupBox()
        Me.txtUsu = New System.Windows.Forms.TextBox()
        Me.lblIngUsuario = New System.Windows.Forms.Label()
        Me.TxtRut = New System.Windows.Forms.TextBox()
        Me.dtgCamposAdicionales = New System.Windows.Forms.DataGridView()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtObsAgen = New System.Windows.Forms.TextBox()
        Me.txtFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.lblObservacionAgenda = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.fraPadTelefonos = New System.Windows.Forms.GroupBox()
        Me.txt_FonoVenta = New System.Windows.Forms.TextBox()
        Me.CmdLlamarVent = New System.Windows.Forms.Button()
        Me.Txt_Fono6 = New System.Windows.Forms.TextBox()
        Me.Txt_Fono5 = New System.Windows.Forms.TextBox()
        Me.Txt_Fono4 = New System.Windows.Forms.TextBox()
        Me.lbLFonoVenta = New System.Windows.Forms.Label()
        Me.chkMute = New System.Windows.Forms.CheckBox()
        Me.txtCallId = New System.Windows.Forms.TextBox()
        Me.CmdLlamarAlt = New System.Windows.Forms.Button()
        Me.Txt_Fono3 = New System.Windows.Forms.TextBox()
        Me.Txt_Fono2 = New System.Windows.Forms.TextBox()
        Me.Txt_Fono_alt = New System.Windows.Forms.TextBox()
        Me.Txt_Fono1 = New System.Windows.Forms.TextBox()
        Me.CmdLlamar3 = New System.Windows.Forms.Button()
        Me.CmdLlamar2 = New System.Windows.Forms.Button()
        Me.CmdLlamar1 = New System.Windows.Forms.Button()
        Me.CmdLlamar4 = New System.Windows.Forms.Button()
        Me.CmdLlamar5 = New System.Windows.Forms.Button()
        Me.CmdLlamar6 = New System.Windows.Forms.Button()
        Me.lblFono6 = New System.Windows.Forms.Label()
        Me.lblFono5 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblFono2 = New System.Windows.Forms.Label()
        Me.lblFono3 = New System.Windows.Forms.Label()
        Me.lblFono1 = New System.Windows.Forms.Label()
        Me.lblFono4 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.txtIntentos = New System.Windows.Forms.TextBox()
        Me.lblIntentos = New System.Windows.Forms.Label()
        Me.tmLabelRegrabacion = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPostview = New System.Windows.Forms.Timer(Me.components)
        Me.CmdAtras = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.Cuerpo.SuspendLayout()
        Me._Cuerpo_IngresoCli.SuspendLayout()
        Me.gpbCotizacion.SuspendLayout()
        CType(Me.dtCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me._Cuerpo_Conex.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FrmConex.SuspendLayout()
        Me._Cuerpo_MtvoLL.SuspendLayout()
        Me._Cuerpo_DatosCli.SuspendLayout()
        Me.frmServicio.SuspendLayout()
        Me.gpbPagador.SuspendLayout()
        Me._Cuerpo_MPago.SuspendLayout()
        Me._Cuerpo_InfAdic.SuspendLayout()
        Me._Cuerpo_Certifica.SuspendLayout()
        Me._Cuerpo_UltInfo.SuspendLayout()
        CType(Me.dtgPolizasPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelotro.SuspendLayout()
        CType(Me.dtgPolizasVigentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._Cuerpo_Adicionales.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._Cuerpo_Objeciones.SuspendLayout()
        Me.FrmObj.SuspendLayout()
        Me._Cuerpo_Agendar.SuspendLayout()
        Me.FrmAgendamiento.SuspendLayout()
        Me._Cuerpo_Agenda2.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me._Cuerpo_FinNC.SuspendLayout()
        Me._Cuerpo_Polizas.SuspendLayout()
        Me.gpbModificaDatos.SuspendLayout()
        CType(Me.dtgPolizasRegrabacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDatosInicio.SuspendLayout()
        Me.gpbDatosClientes.SuspendLayout()
        CType(Me.dtgCamposAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraPadTelefonos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cuerpo
        '
        Me.Cuerpo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.Cuerpo.Controls.Add(Me._Cuerpo_IngresoCli)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_Conex)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_MtvoLL)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_DatosCli)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_MPago)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_InfAdic)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_Certifica)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_UltInfo)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_TabBenef)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_Adicionales)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_Objeciones)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_Agendar)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_Agenda2)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_FinNC)
        Me.Cuerpo.Controls.Add(Me._Cuerpo_Polizas)
        Me.Cuerpo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuerpo.ItemSize = New System.Drawing.Size(42, 18)
        Me.Cuerpo.Location = New System.Drawing.Point(0, 235)
        Me.Cuerpo.Name = "Cuerpo"
        Me.Cuerpo.SelectedIndex = 2
        Me.Cuerpo.Size = New System.Drawing.Size(996, 427)
        Me.Cuerpo.TabIndex = 32
        Me.Cuerpo.TabStop = False
        '
        '_Cuerpo_IngresoCli
        '
        Me._Cuerpo_IngresoCli.Controls.Add(Me.cmdSiguientePoliza)
        Me._Cuerpo_IngresoCli.Controls.Add(Me.gpbCotizacion)
        Me._Cuerpo_IngresoCli.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_IngresoCli.Name = "_Cuerpo_IngresoCli"
        Me._Cuerpo_IngresoCli.Padding = New System.Windows.Forms.Padding(3)
        Me._Cuerpo_IngresoCli.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_IngresoCli.TabIndex = 14
        Me._Cuerpo_IngresoCli.Text = "Agregar Cliente"
        Me._Cuerpo_IngresoCli.UseVisualStyleBackColor = True
        '
        'cmdSiguientePoliza
        '
        Me.cmdSiguientePoliza.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSiguientePoliza.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSiguientePoliza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiguientePoliza.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSiguientePoliza.Image = CType(resources.GetObject("cmdSiguientePoliza.Image"), System.Drawing.Image)
        Me.cmdSiguientePoliza.Location = New System.Drawing.Point(111, 353)
        Me.cmdSiguientePoliza.Name = "cmdSiguientePoliza"
        Me.cmdSiguientePoliza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSiguientePoliza.Size = New System.Drawing.Size(73, 41)
        Me.cmdSiguientePoliza.TabIndex = 186
        Me.cmdSiguientePoliza.Text = "&Siguiente "
        Me.cmdSiguientePoliza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSiguientePoliza.UseVisualStyleBackColor = False
        '
        'gpbCotizacion
        '
        Me.gpbCotizacion.BackColor = System.Drawing.Color.LightGray
        Me.gpbCotizacion.Controls.Add(Me.cmbInteresaFinal)
        Me.gpbCotizacion.Controls.Add(Me.Label19)
        Me.gpbCotizacion.Controls.Add(Me.dtCotizaciones)
        Me.gpbCotizacion.Controls.Add(Me.btnGuardarCotizacion)
        Me.gpbCotizacion.Controls.Add(Me.GroupBox3)
        Me.gpbCotizacion.Controls.Add(Me.lblIdPlan)
        Me.gpbCotizacion.Controls.Add(Me.dtFechaNacimientoCotiza)
        Me.gpbCotizacion.Controls.Add(Me.Label55)
        Me.gpbCotizacion.Controls.Add(Me.Label60)
        Me.gpbCotizacion.Controls.Add(Me.btnCotizar)
        Me.gpbCotizacion.Controls.Add(Me.cmbPlanCotiza)
        Me.gpbCotizacion.Controls.Add(Me.btnAdicionales)
        Me.gpbCotizacion.Controls.Add(Me.Label61)
        Me.gpbCotizacion.Controls.Add(Me.cmbTipoContratoCotiza)
        Me.gpbCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gpbCotizacion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbCotizacion.ForeColor = System.Drawing.Color.Maroon
        Me.gpbCotizacion.Location = New System.Drawing.Point(15, 20)
        Me.gpbCotizacion.Name = "gpbCotizacion"
        Me.gpbCotizacion.Size = New System.Drawing.Size(931, 316)
        Me.gpbCotizacion.TabIndex = 185
        Me.gpbCotizacion.TabStop = False
        Me.gpbCotizacion.Text = "Cotizacion"
        '
        'cmbInteresaFinal
        '
        Me.cmbInteresaFinal.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInteresaFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbInteresaFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInteresaFinal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInteresaFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbInteresaFinal.Items.AddRange(New Object() {"[No Especificado]", "Interesa", "No Interesa", "Lo Pensara"})
        Me.cmbInteresaFinal.Location = New System.Drawing.Point(161, 223)
        Me.cmbInteresaFinal.Name = "cmbInteresaFinal"
        Me.cmbInteresaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbInteresaFinal.Size = New System.Drawing.Size(172, 24)
        Me.cmbInteresaFinal.TabIndex = 188
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(14, 227)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(141, 20)
        Me.Label19.TabIndex = 189
        Me.Label19.Text = "Interesa Final?"
        '
        'dtCotizaciones
        '
        Me.dtCotizaciones.AllowUserToAddRows = False
        Me.dtCotizaciones.AllowUserToDeleteRows = False
        Me.dtCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkCotizacion, Me.DataGridViewTextBoxColumn2, Me.edad, Me.plan, Me.primaUf, Me.primaPesos, Me.tipoContratoPlan, Me.IdPlan, Me.IDTipoContrato, Me.FechaNacimientoCot})
        Me.dtCotizaciones.Location = New System.Drawing.Point(422, 150)
        Me.dtCotizaciones.Name = "dtCotizaciones"
        Me.dtCotizaciones.ReadOnly = True
        Me.dtCotizaciones.RowHeadersVisible = False
        Me.dtCotizaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtCotizaciones.Size = New System.Drawing.Size(495, 136)
        Me.dtCotizaciones.TabIndex = 187
        '
        'chkCotizacion
        '
        Me.chkCotizacion.FalseValue = ""
        Me.chkCotizacion.HeaderText = "Seleccione"
        Me.chkCotizacion.Name = "chkCotizacion"
        Me.chkCotizacion.ReadOnly = True
        Me.chkCotizacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chkCotizacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'edad
        '
        Me.edad.DataPropertyName = "Edad"
        Me.edad.HeaderText = "Edad"
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        '
        'plan
        '
        Me.plan.DataPropertyName = "NombrePlan"
        Me.plan.HeaderText = "Plan"
        Me.plan.Name = "plan"
        Me.plan.ReadOnly = True
        '
        'primaUf
        '
        Me.primaUf.DataPropertyName = "PrimaUf"
        Me.primaUf.HeaderText = "Prima Uf"
        Me.primaUf.Name = "primaUf"
        Me.primaUf.ReadOnly = True
        '
        'primaPesos
        '
        Me.primaPesos.DataPropertyName = "PrimaPesos"
        Me.primaPesos.HeaderText = "Prima Pesos"
        Me.primaPesos.Name = "primaPesos"
        Me.primaPesos.ReadOnly = True
        '
        'tipoContratoPlan
        '
        Me.tipoContratoPlan.DataPropertyName = "TipoContrato"
        Me.tipoContratoPlan.HeaderText = "Tipo Contrato"
        Me.tipoContratoPlan.Name = "tipoContratoPlan"
        Me.tipoContratoPlan.ReadOnly = True
        '
        'IdPlan
        '
        Me.IdPlan.DataPropertyName = "ID_Plan"
        Me.IdPlan.HeaderText = "IdPlan"
        Me.IdPlan.Name = "IdPlan"
        Me.IdPlan.ReadOnly = True
        Me.IdPlan.Visible = False
        '
        'IDTipoContrato
        '
        Me.IDTipoContrato.DataPropertyName = "ID_TipoContrato"
        Me.IDTipoContrato.HeaderText = "Id Tipo Contrato"
        Me.IDTipoContrato.Name = "IDTipoContrato"
        Me.IDTipoContrato.ReadOnly = True
        Me.IDTipoContrato.Visible = False
        '
        'FechaNacimientoCot
        '
        Me.FechaNacimientoCot.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimientoCot.HeaderText = "IdFechaNacimiento"
        Me.FechaNacimientoCot.Name = "FechaNacimientoCot"
        Me.FechaNacimientoCot.ReadOnly = True
        Me.FechaNacimientoCot.Visible = False
        '
        'btnGuardarCotizacion
        '
        Me.btnGuardarCotizacion.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGuardarCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnGuardarCotizacion.FlatAppearance.BorderSize = 2
        Me.btnGuardarCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardarCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGuardarCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCotizacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCotizacion.ForeColor = System.Drawing.Color.Red
        Me.btnGuardarCotizacion.Location = New System.Drawing.Point(576, 117)
        Me.btnGuardarCotizacion.Name = "btnGuardarCotizacion"
        Me.btnGuardarCotizacion.Size = New System.Drawing.Size(166, 26)
        Me.btnGuardarCotizacion.TabIndex = 184
        Me.btnGuardarCotizacion.Text = "GUARDAR COTIZACION"
        Me.btnGuardarCotizacion.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.lblNombrePlan)
        Me.GroupBox3.Controls.Add(Me.lblPrimaUfCotiza)
        Me.GroupBox3.Controls.Add(Me.lblPrimaPesosCotiza)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(419, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(498, 92)
        Me.GroupBox3.TabIndex = 183
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Cotizacion"
        '
        'lblNombrePlan
        '
        Me.lblNombrePlan.AutoSize = True
        Me.lblNombrePlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePlan.Location = New System.Drawing.Point(6, 19)
        Me.lblNombrePlan.Name = "lblNombrePlan"
        Me.lblNombrePlan.Size = New System.Drawing.Size(47, 16)
        Me.lblNombrePlan.TabIndex = 179
        Me.lblNombrePlan.Text = "Plan: "
        '
        'lblPrimaUfCotiza
        '
        Me.lblPrimaUfCotiza.AutoSize = True
        Me.lblPrimaUfCotiza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimaUfCotiza.Location = New System.Drawing.Point(6, 44)
        Me.lblPrimaUfCotiza.Name = "lblPrimaUfCotiza"
        Me.lblPrimaUfCotiza.Size = New System.Drawing.Size(67, 16)
        Me.lblPrimaUfCotiza.TabIndex = 180
        Me.lblPrimaUfCotiza.Text = "Prima Uf"
        '
        'lblPrimaPesosCotiza
        '
        Me.lblPrimaPesosCotiza.AutoSize = True
        Me.lblPrimaPesosCotiza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimaPesosCotiza.Location = New System.Drawing.Point(6, 73)
        Me.lblPrimaPesosCotiza.Name = "lblPrimaPesosCotiza"
        Me.lblPrimaPesosCotiza.Size = New System.Drawing.Size(96, 16)
        Me.lblPrimaPesosCotiza.TabIndex = 181
        Me.lblPrimaPesosCotiza.Text = "Prima Pesos"
        '
        'lblIdPlan
        '
        Me.lblIdPlan.AutoSize = True
        Me.lblIdPlan.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdPlan.Location = New System.Drawing.Point(278, 19)
        Me.lblIdPlan.Name = "lblIdPlan"
        Me.lblIdPlan.Size = New System.Drawing.Size(17, 17)
        Me.lblIdPlan.TabIndex = 182
        Me.lblIdPlan.Text = "0"
        Me.lblIdPlan.Visible = False
        '
        'dtFechaNacimientoCotiza
        '
        Me.dtFechaNacimientoCotiza.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacimientoCotiza.Location = New System.Drawing.Point(140, 30)
        Me.dtFechaNacimientoCotiza.Name = "dtFechaNacimientoCotiza"
        Me.dtFechaNacimientoCotiza.Size = New System.Drawing.Size(118, 23)
        Me.dtFechaNacimientoCotiza.TabIndex = 171
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.Control
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Location = New System.Drawing.Point(14, 30)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(120, 23)
        Me.Label55.TabIndex = 172
        Me.Label55.Text = "Fecha Nacimiento:"
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.SystemColors.Control
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(14, 107)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label60.Size = New System.Drawing.Size(120, 23)
        Me.Label60.TabIndex = 173
        Me.Label60.Text = "Plan a Contratar:"
        '
        'btnCotizar
        '
        Me.btnCotizar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCotizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCotizar.FlatAppearance.BorderSize = 2
        Me.btnCotizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCotizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotizar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCotizar.ForeColor = System.Drawing.Color.Red
        Me.btnCotizar.Location = New System.Drawing.Point(149, 150)
        Me.btnCotizar.Name = "btnCotizar"
        Me.btnCotizar.Size = New System.Drawing.Size(161, 24)
        Me.btnCotizar.TabIndex = 178
        Me.btnCotizar.Text = "COTIZAR"
        Me.btnCotizar.UseVisualStyleBackColor = False
        '
        'cmbPlanCotiza
        '
        Me.cmbPlanCotiza.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPlanCotiza.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPlanCotiza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanCotiza.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlanCotiza.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPlanCotiza.Location = New System.Drawing.Point(140, 104)
        Me.cmbPlanCotiza.Name = "cmbPlanCotiza"
        Me.cmbPlanCotiza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbPlanCotiza.Size = New System.Drawing.Size(257, 24)
        Me.cmbPlanCotiza.TabIndex = 174
        '
        'btnAdicionales
        '
        Me.btnAdicionales.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionales.ForeColor = System.Drawing.Color.Black
        Me.btnAdicionales.Location = New System.Drawing.Point(317, 62)
        Me.btnAdicionales.Name = "btnAdicionales"
        Me.btnAdicionales.Size = New System.Drawing.Size(80, 24)
        Me.btnAdicionales.TabIndex = 177
        Me.btnAdicionales.Text = "Adicionales"
        Me.btnAdicionales.UseVisualStyleBackColor = True
        Me.btnAdicionales.Visible = False
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.SystemColors.Control
        Me.Label61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(14, 66)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label61.Size = New System.Drawing.Size(120, 23)
        Me.Label61.TabIndex = 175
        Me.Label61.Text = "Tipo Contrato:"
        '
        'cmbTipoContratoCotiza
        '
        Me.cmbTipoContratoCotiza.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoContratoCotiza.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoContratoCotiza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoContratoCotiza.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoContratoCotiza.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoContratoCotiza.Location = New System.Drawing.Point(140, 63)
        Me.cmbTipoContratoCotiza.Name = "cmbTipoContratoCotiza"
        Me.cmbTipoContratoCotiza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTipoContratoCotiza.Size = New System.Drawing.Size(166, 24)
        Me.cmbTipoContratoCotiza.TabIndex = 176
        '
        '_Cuerpo_Conex
        '
        Me._Cuerpo_Conex.BackColor = System.Drawing.Color.MediumSeaGreen
        Me._Cuerpo_Conex.Controls.Add(Me.CmdSiguiente)
        Me._Cuerpo_Conex.Controls.Add(Me.GroupBox1)
        Me._Cuerpo_Conex.Controls.Add(Me.FrmConex)
        Me._Cuerpo_Conex.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_Conex.Name = "_Cuerpo_Conex"
        Me._Cuerpo_Conex.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_Conex.TabIndex = 0
        Me._Cuerpo_Conex.Text = "Conexión"
        '
        'CmdSiguiente
        '
        Me.CmdSiguiente.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSiguiente.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSiguiente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSiguiente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSiguiente.Image = CType(resources.GetObject("CmdSiguiente.Image"), System.Drawing.Image)
        Me.CmdSiguiente.Location = New System.Drawing.Point(99, 353)
        Me.CmdSiguiente.Name = "CmdSiguiente"
        Me.CmdSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSiguiente.Size = New System.Drawing.Size(73, 41)
        Me.CmdSiguiente.TabIndex = 54
        Me.CmdSiguiente.Text = "&Siguiente "
        Me.CmdSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSiguiente.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CmbNoConecta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CmbConecta)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(984, 83)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.AliceBlue
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(485, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(257, 16)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Seleccione Opción para No Conecta."
        '
        'CmbNoConecta
        '
        Me.CmbNoConecta.BackColor = System.Drawing.SystemColors.Window
        Me.CmbNoConecta.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbNoConecta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNoConecta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbNoConecta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbNoConecta.Items.AddRange(New Object() {"[No Especificado]", "Ocupado", "Fuera de servicio", "Buzón de voz", "Número no válido", "No contesta", "Fax o módem", "Congestionado", "Fuera de área o apagado"})
        Me.CmbNoConecta.Location = New System.Drawing.Point(488, 43)
        Me.CmbNoConecta.Name = "CmbNoConecta"
        Me.CmbNoConecta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbNoConecta.Size = New System.Drawing.Size(293, 21)
        Me.CmbNoConecta.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.AliceBlue
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(57, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(289, 18)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Seleccione Opción para Conecta Llamada."
        '
        'CmbConecta
        '
        Me.CmbConecta.BackColor = System.Drawing.SystemColors.Window
        Me.CmbConecta.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbConecta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbConecta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbConecta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbConecta.Items.AddRange(New Object() {"[No Especificado]", "CONECTA", "NO CONECTA"})
        Me.CmbConecta.Location = New System.Drawing.Point(57, 43)
        Me.CmbConecta.Name = "CmbConecta"
        Me.CmbConecta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbConecta.Size = New System.Drawing.Size(289, 21)
        Me.CmbConecta.TabIndex = 49
        '
        'FrmConex
        '
        Me.FrmConex.BackColor = System.Drawing.Color.AliceBlue
        Me.FrmConex.Controls.Add(Me.wbScriptBienvenida)
        Me.FrmConex.Controls.Add(Me.CmbComunicaCon)
        Me.FrmConex.Controls.Add(Me.CmbComunicaTercero)
        Me.FrmConex.Controls.Add(Me.Label12)
        Me.FrmConex.Controls.Add(Me.Label13)
        Me.FrmConex.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrmConex.Location = New System.Drawing.Point(4, 86)
        Me.FrmConex.Name = "FrmConex"
        Me.FrmConex.Padding = New System.Windows.Forms.Padding(0)
        Me.FrmConex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrmConex.Size = New System.Drawing.Size(984, 277)
        Me.FrmConex.TabIndex = 40
        Me.FrmConex.TabStop = False
        Me.FrmConex.Visible = False
        '
        'wbScriptBienvenida
        '
        Me.wbScriptBienvenida.Location = New System.Drawing.Point(6, 17)
        Me.wbScriptBienvenida.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbScriptBienvenida.Name = "wbScriptBienvenida"
        Me.wbScriptBienvenida.Size = New System.Drawing.Size(969, 132)
        Me.wbScriptBienvenida.TabIndex = 189
        '
        'CmbComunicaCon
        '
        Me.CmbComunicaCon.BackColor = System.Drawing.SystemColors.Window
        Me.CmbComunicaCon.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbComunicaCon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbComunicaCon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbComunicaCon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbComunicaCon.Items.AddRange(New Object() {"[No Especificado]", "Comunica con cliente", "Comunica con tercero válido", "Comunica con tercero No válido", "Comunica con Cliente - No desea Contestar"})
        Me.CmbComunicaCon.Location = New System.Drawing.Point(54, 211)
        Me.CmbComunicaCon.Name = "CmbComunicaCon"
        Me.CmbComunicaCon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbComunicaCon.Size = New System.Drawing.Size(257, 21)
        Me.CmbComunicaCon.TabIndex = 52
        '
        'CmbComunicaTercero
        '
        Me.CmbComunicaTercero.BackColor = System.Drawing.SystemColors.Window
        Me.CmbComunicaTercero.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbComunicaTercero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbComunicaTercero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbComunicaTercero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbComunicaTercero.Items.AddRange(New Object() {"[No Especificado]", "Tercero pide dejar pendiente", "Viaje", "Fallecido", "No vive ahí", "Problema por horario", "No desesa contestar"})
        Me.CmbComunicaTercero.Location = New System.Drawing.Point(485, 211)
        Me.CmbComunicaTercero.Name = "CmbComunicaTercero"
        Me.CmbComunicaTercero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbComunicaTercero.Size = New System.Drawing.Size(256, 21)
        Me.CmbComunicaTercero.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.AliceBlue
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(55, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(347, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Seleccione para saber con quien se comunica."
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.AliceBlue
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(485, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(331, 33)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Seleccione Opción para Comunica con Tercero."
        '
        '_Cuerpo_MtvoLL
        '
        Me._Cuerpo_MtvoLL.BackColor = System.Drawing.Color.MediumSeaGreen
        Me._Cuerpo_MtvoLL.Controls.Add(Me.btnExclusiones)
        Me._Cuerpo_MtvoLL.Controls.Add(Me.wbScriptPresentacion)
        Me._Cuerpo_MtvoLL.Controls.Add(Me.CmdSiguiente1)
        Me._Cuerpo_MtvoLL.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_MtvoLL.Name = "_Cuerpo_MtvoLL"
        Me._Cuerpo_MtvoLL.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_MtvoLL.TabIndex = 1
        Me._Cuerpo_MtvoLL.Text = "Motivo Llamado"
        '
        'btnExclusiones
        '
        Me.btnExclusiones.Location = New System.Drawing.Point(737, 323)
        Me.btnExclusiones.Name = "btnExclusiones"
        Me.btnExclusiones.Size = New System.Drawing.Size(98, 40)
        Me.btnExclusiones.TabIndex = 192
        Me.btnExclusiones.Text = "Exclusiones"
        Me.btnExclusiones.UseVisualStyleBackColor = True
        Me.btnExclusiones.Visible = False
        '
        'wbScriptPresentacion
        '
        Me.wbScriptPresentacion.Location = New System.Drawing.Point(5, 3)
        Me.wbScriptPresentacion.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbScriptPresentacion.Name = "wbScriptPresentacion"
        Me.wbScriptPresentacion.Size = New System.Drawing.Size(983, 305)
        Me.wbScriptPresentacion.TabIndex = 170
        '
        'CmdSiguiente1
        '
        Me.CmdSiguiente1.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSiguiente1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSiguiente1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSiguiente1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSiguiente1.Image = CType(resources.GetObject("CmdSiguiente1.Image"), System.Drawing.Image)
        Me.CmdSiguiente1.Location = New System.Drawing.Point(99, 354)
        Me.CmdSiguiente1.Name = "CmdSiguiente1"
        Me.CmdSiguiente1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSiguiente1.Size = New System.Drawing.Size(73, 41)
        Me.CmdSiguiente1.TabIndex = 3
        Me.CmdSiguiente1.Text = "&Siguiente "
        Me.CmdSiguiente1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSiguiente1.UseVisualStyleBackColor = False
        '
        '_Cuerpo_DatosCli
        '
        Me._Cuerpo_DatosCli.BackColor = System.Drawing.Color.MediumSeaGreen
        Me._Cuerpo_DatosCli.Controls.Add(Me.CmdSiguiente2)
        Me._Cuerpo_DatosCli.Controls.Add(Me.frmServicio)
        Me._Cuerpo_DatosCli.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_DatosCli.Name = "_Cuerpo_DatosCli"
        Me._Cuerpo_DatosCli.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_DatosCli.TabIndex = 2
        Me._Cuerpo_DatosCli.Text = "Toma de Datos"
        '
        'CmdSiguiente2
        '
        Me.CmdSiguiente2.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSiguiente2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSiguiente2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSiguiente2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSiguiente2.Image = CType(resources.GetObject("CmdSiguiente2.Image"), System.Drawing.Image)
        Me.CmdSiguiente2.Location = New System.Drawing.Point(99, 353)
        Me.CmdSiguiente2.Name = "CmdSiguiente2"
        Me.CmdSiguiente2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSiguiente2.Size = New System.Drawing.Size(73, 41)
        Me.CmdSiguiente2.TabIndex = 84
        Me.CmdSiguiente2.Text = "Siguiente"
        Me.CmdSiguiente2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSiguiente2.UseVisualStyleBackColor = False
        '
        'frmServicio
        '
        Me.frmServicio.BackColor = System.Drawing.Color.AliceBlue
        Me.frmServicio.Controls.Add(Me.btnCalcularIMC)
        Me.frmServicio.Controls.Add(Me.lblIMC)
        Me.frmServicio.Controls.Add(Me.btnAvanzarSinIngresar)
        Me.frmServicio.Controls.Add(Me.txtDPSCliente)
        Me.frmServicio.Controls.Add(Me.lblDPS)
        Me.frmServicio.Controls.Add(Me.Label1)
        Me.frmServicio.Controls.Add(Me.cmbIsapreCliente)
        Me.frmServicio.Controls.Add(Me.mskEstaturaCliente)
        Me.frmServicio.Controls.Add(Me.Label4)
        Me.frmServicio.Controls.Add(Me.txtPesoCliente)
        Me.frmServicio.Controls.Add(Me.Label7)
        Me.frmServicio.Controls.Add(Me.rdbNoPagador)
        Me.frmServicio.Controls.Add(Me.rdbSiPagador)
        Me.frmServicio.Controls.Add(Me.gpbPagador)
        Me.frmServicio.Controls.Add(Me.lblPrimaPesos)
        Me.frmServicio.Controls.Add(Me.lblPrimaUF)
        Me.frmServicio.Controls.Add(Me.lblTextPrimaPesos)
        Me.frmServicio.Controls.Add(Me.lblTextPrimaUF)
        Me.frmServicio.Controls.Add(Me.btnAdicional)
        Me.frmServicio.Controls.Add(Me.btnBeneficiarios)
        Me.frmServicio.Controls.Add(Me.Label82)
        Me.frmServicio.Controls.Add(Me.CmbSexo)
        Me.frmServicio.Controls.Add(Me.txtCalculaEdad)
        Me.frmServicio.Controls.Add(Me.Label2)
        Me.frmServicio.Controls.Add(Me.txtFonoVenta)
        Me.frmServicio.Controls.Add(Me.Label81)
        Me.frmServicio.Controls.Add(Me.lblTomaDireccion)
        Me.frmServicio.Controls.Add(Me.dtFechaNacV)
        Me.frmServicio.Controls.Add(Me.Label34)
        Me.frmServicio.Controls.Add(Me.cmbCiudad)
        Me.frmServicio.Controls.Add(Me.Label33)
        Me.frmServicio.Controls.Add(Me.cmbComuna)
        Me.frmServicio.Controls.Add(Me.txtReferenciaV)
        Me.frmServicio.Controls.Add(Me.Label23)
        Me.frmServicio.Controls.Add(Me.txtNroV)
        Me.frmServicio.Controls.Add(Me.Label22)
        Me.frmServicio.Controls.Add(Me.txtCalleV)
        Me.frmServicio.Controls.Add(Me.Label21)
        Me.frmServicio.Controls.Add(Me.txtEmail)
        Me.frmServicio.Controls.Add(Me.Label20)
        Me.frmServicio.Controls.Add(Me.Label18)
        Me.frmServicio.Controls.Add(Me.txtDvV)
        Me.frmServicio.Controls.Add(Me.Label16)
        Me.frmServicio.Controls.Add(Me.txtRutV)
        Me.frmServicio.Controls.Add(Me.Label15)
        Me.frmServicio.Controls.Add(Me.txtMaternoV)
        Me.frmServicio.Controls.Add(Me.txtPaternoV)
        Me.frmServicio.Controls.Add(Me.txtNombreV)
        Me.frmServicio.Controls.Add(Me.Label14)
        Me.frmServicio.Controls.Add(Me.Label10)
        Me.frmServicio.Controls.Add(Me.Label5)
        Me.frmServicio.Controls.Add(Me.lblDatosCli)
        Me.frmServicio.Location = New System.Drawing.Point(3, 4)
        Me.frmServicio.Name = "frmServicio"
        Me.frmServicio.Size = New System.Drawing.Size(985, 402)
        Me.frmServicio.TabIndex = 82
        Me.frmServicio.TabStop = False
        '
        'btnCalcularIMC
        '
        Me.btnCalcularIMC.BackColor = System.Drawing.Color.White
        Me.btnCalcularIMC.Location = New System.Drawing.Point(349, 149)
        Me.btnCalcularIMC.Name = "btnCalcularIMC"
        Me.btnCalcularIMC.Size = New System.Drawing.Size(125, 23)
        Me.btnCalcularIMC.TabIndex = 279
        Me.btnCalcularIMC.Text = "Calcular IMC"
        Me.btnCalcularIMC.UseVisualStyleBackColor = False
        '
        'lblIMC
        '
        Me.lblIMC.BackColor = System.Drawing.Color.AliceBlue
        Me.lblIMC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIMC.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblIMC.ForeColor = System.Drawing.Color.Black
        Me.lblIMC.Location = New System.Drawing.Point(492, 153)
        Me.lblIMC.Name = "lblIMC"
        Me.lblIMC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIMC.Size = New System.Drawing.Size(91, 17)
        Me.lblIMC.TabIndex = 278
        Me.lblIMC.Text = "IMC: "
        '
        'btnAvanzarSinIngresar
        '
        Me.btnAvanzarSinIngresar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAvanzarSinIngresar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAvanzarSinIngresar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvanzarSinIngresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAvanzarSinIngresar.Image = CType(resources.GetObject("btnAvanzarSinIngresar.Image"), System.Drawing.Image)
        Me.btnAvanzarSinIngresar.Location = New System.Drawing.Point(188, 350)
        Me.btnAvanzarSinIngresar.Name = "btnAvanzarSinIngresar"
        Me.btnAvanzarSinIngresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAvanzarSinIngresar.Size = New System.Drawing.Size(180, 41)
        Me.btnAvanzarSinIngresar.TabIndex = 274
        Me.btnAvanzarSinIngresar.Text = "Avanzar Sin Ingresar Datos"
        Me.btnAvanzarSinIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAvanzarSinIngresar.UseVisualStyleBackColor = False
        Me.btnAvanzarSinIngresar.Visible = False
        '
        'txtDPSCliente
        '
        Me.txtDPSCliente.AcceptsReturn = True
        Me.txtDPSCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtDPSCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDPSCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDPSCliente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDPSCliente.Location = New System.Drawing.Point(5, 173)
        Me.txtDPSCliente.MaxLength = 45
        Me.txtDPSCliente.Name = "txtDPSCliente"
        Me.txtDPSCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDPSCliente.Size = New System.Drawing.Size(317, 21)
        Me.txtDPSCliente.TabIndex = 272
        '
        'lblDPS
        '
        Me.lblDPS.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblDPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDPS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDPS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPS.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblDPS.Location = New System.Drawing.Point(5, 145)
        Me.lblDPS.Name = "lblDPS"
        Me.lblDPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDPS.Size = New System.Drawing.Size(317, 25)
        Me.lblDPS.TabIndex = 273
        Me.lblDPS.Text = "DPS"
        Me.lblDPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(576, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 271
        Me.Label1.Text = "Isapre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbIsapreCliente
        '
        Me.cmbIsapreCliente.AutoCompleteCustomSource.AddRange(New String() {"[Seleccione...]", "BANMEDICA", "COLMENA", "CONSALUD", "CRUZ BLANCA", "FONASA", "FAST BANCO ESTADO", "FUSAT", "MAS VIDA", "RIO BLANCO", "VIDA TRES", "DIPRECA", "CHUQUICAMATA"})
        Me.cmbIsapreCliente.BackColor = System.Drawing.SystemColors.Window
        Me.cmbIsapreCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbIsapreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIsapreCliente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbIsapreCliente.Items.AddRange(New Object() {"[No Especificado]", "BANMEDICA", "COLMENA", "CONSALUD", "CRUZ BLANCA", "FONASA", "FAST BANCO ESTADO", "FUSAT", "MAS VIDA", "RIO BLANCO", "VIDA TRES", "DIPRECA", "CHUQUICAMATA"})
        Me.cmbIsapreCliente.Location = New System.Drawing.Point(576, 114)
        Me.cmbIsapreCliente.Name = "cmbIsapreCliente"
        Me.cmbIsapreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbIsapreCliente.Size = New System.Drawing.Size(178, 21)
        Me.cmbIsapreCliente.TabIndex = 270
        '
        'mskEstaturaCliente
        '
        Me.mskEstaturaCliente.Location = New System.Drawing.Point(497, 114)
        Me.mskEstaturaCliente.Mask = "0,00"
        Me.mskEstaturaCliente.Name = "mskEstaturaCliente"
        Me.mskEstaturaCliente.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.mskEstaturaCliente.Size = New System.Drawing.Size(73, 21)
        Me.mskEstaturaCliente.TabIndex = 269
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(495, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 268
        Me.Label4.Text = "Estatura"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPesoCliente
        '
        Me.txtPesoCliente.AcceptsReturn = True
        Me.txtPesoCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtPesoCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPesoCliente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPesoCliente.Location = New System.Drawing.Point(430, 114)
        Me.txtPesoCliente.MaxLength = 3
        Me.txtPesoCliente.Name = "txtPesoCliente"
        Me.txtPesoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPesoCliente.Size = New System.Drawing.Size(51, 21)
        Me.txtPesoCliente.TabIndex = 267
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(431, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(50, 25)
        Me.Label7.TabIndex = 266
        Me.Label7.Text = "Peso"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbNoPagador
        '
        Me.rdbNoPagador.AutoSize = True
        Me.rdbNoPagador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNoPagador.ForeColor = System.Drawing.Color.Blue
        Me.rdbNoPagador.Location = New System.Drawing.Point(657, 155)
        Me.rdbNoPagador.Name = "rdbNoPagador"
        Me.rdbNoPagador.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rdbNoPagador.Size = New System.Drawing.Size(128, 17)
        Me.rdbNoPagador.TabIndex = 261
        Me.rdbNoPagador.TabStop = True
        Me.rdbNoPagador.Text = "Titular es Pagador"
        Me.rdbNoPagador.UseVisualStyleBackColor = True
        '
        'rdbSiPagador
        '
        Me.rdbSiPagador.AutoSize = True
        Me.rdbSiPagador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSiPagador.ForeColor = System.Drawing.Color.Blue
        Me.rdbSiPagador.Location = New System.Drawing.Point(800, 156)
        Me.rdbSiPagador.Name = "rdbSiPagador"
        Me.rdbSiPagador.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rdbSiPagador.Size = New System.Drawing.Size(168, 17)
        Me.rdbSiPagador.TabIndex = 260
        Me.rdbSiPagador.TabStop = True
        Me.rdbSiPagador.Text = "Titular distinto a Pagador"
        Me.rdbSiPagador.UseVisualStyleBackColor = True
        '
        'gpbPagador
        '
        Me.gpbPagador.Controls.Add(Me.txtDvPagador)
        Me.gpbPagador.Controls.Add(Me.Label65)
        Me.gpbPagador.Controls.Add(Me.Label64)
        Me.gpbPagador.Controls.Add(Me.txtNombrePagador)
        Me.gpbPagador.Controls.Add(Me.Label63)
        Me.gpbPagador.Controls.Add(Me.txtRutPagador)
        Me.gpbPagador.Location = New System.Drawing.Point(659, 179)
        Me.gpbPagador.Name = "gpbPagador"
        Me.gpbPagador.Size = New System.Drawing.Size(313, 145)
        Me.gpbPagador.TabIndex = 259
        Me.gpbPagador.TabStop = False
        Me.gpbPagador.Text = "Datos Pagador"
        Me.gpbPagador.Visible = False
        '
        'txtDvPagador
        '
        Me.txtDvPagador.AcceptsReturn = True
        Me.txtDvPagador.BackColor = System.Drawing.SystemColors.Window
        Me.txtDvPagador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDvPagador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDvPagador.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDvPagador.Location = New System.Drawing.Point(104, 45)
        Me.txtDvPagador.MaxLength = 1
        Me.txtDvPagador.Name = "txtDvPagador"
        Me.txtDvPagador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDvPagador.Size = New System.Drawing.Size(28, 21)
        Me.txtDvPagador.TabIndex = 201
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Blue
        Me.Label65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label65.Location = New System.Drawing.Point(103, 17)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(29, 24)
        Me.Label65.TabIndex = 165
        Me.Label65.Text = "DV"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Blue
        Me.Label64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label64.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label64.Location = New System.Drawing.Point(6, 69)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label64.Size = New System.Drawing.Size(297, 24)
        Me.Label64.TabIndex = 163
        Me.Label64.Text = "Nombre Pagador"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombrePagador
        '
        Me.txtNombrePagador.AcceptsReturn = True
        Me.txtNombrePagador.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombrePagador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombrePagador.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombrePagador.Location = New System.Drawing.Point(6, 96)
        Me.txtNombrePagador.MaxLength = 100
        Me.txtNombrePagador.Name = "txtNombrePagador"
        Me.txtNombrePagador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombrePagador.Size = New System.Drawing.Size(297, 21)
        Me.txtNombrePagador.TabIndex = 202
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Blue
        Me.Label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label63.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label63.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label63.Location = New System.Drawing.Point(6, 17)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(91, 24)
        Me.Label63.TabIndex = 161
        Me.Label63.Text = "Rut Pagador"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRutPagador
        '
        Me.txtRutPagador.AcceptsReturn = True
        Me.txtRutPagador.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutPagador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRutPagador.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRutPagador.Location = New System.Drawing.Point(6, 44)
        Me.txtRutPagador.MaxLength = 8
        Me.txtRutPagador.Name = "txtRutPagador"
        Me.txtRutPagador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRutPagador.Size = New System.Drawing.Size(90, 21)
        Me.txtRutPagador.TabIndex = 200
        '
        'lblPrimaPesos
        '
        Me.lblPrimaPesos.BackColor = System.Drawing.Color.AliceBlue
        Me.lblPrimaPesos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPrimaPesos.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrimaPesos.ForeColor = System.Drawing.Color.Black
        Me.lblPrimaPesos.Location = New System.Drawing.Point(436, 207)
        Me.lblPrimaPesos.Name = "lblPrimaPesos"
        Me.lblPrimaPesos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPrimaPesos.Size = New System.Drawing.Size(65, 17)
        Me.lblPrimaPesos.TabIndex = 243
        Me.lblPrimaPesos.Text = "0"
        Me.lblPrimaPesos.Visible = False
        '
        'lblPrimaUF
        '
        Me.lblPrimaUF.BackColor = System.Drawing.Color.AliceBlue
        Me.lblPrimaUF.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPrimaUF.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrimaUF.ForeColor = System.Drawing.Color.Black
        Me.lblPrimaUF.Location = New System.Drawing.Point(436, 179)
        Me.lblPrimaUF.Name = "lblPrimaUF"
        Me.lblPrimaUF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPrimaUF.Size = New System.Drawing.Size(65, 17)
        Me.lblPrimaUF.TabIndex = 242
        Me.lblPrimaUF.Text = "0"
        Me.lblPrimaUF.Visible = False
        '
        'lblTextPrimaPesos
        '
        Me.lblTextPrimaPesos.BackColor = System.Drawing.Color.AliceBlue
        Me.lblTextPrimaPesos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTextPrimaPesos.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblTextPrimaPesos.ForeColor = System.Drawing.Color.Black
        Me.lblTextPrimaPesos.Location = New System.Drawing.Point(339, 207)
        Me.lblTextPrimaPesos.Name = "lblTextPrimaPesos"
        Me.lblTextPrimaPesos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTextPrimaPesos.Size = New System.Drawing.Size(91, 17)
        Me.lblTextPrimaPesos.TabIndex = 241
        Me.lblTextPrimaPesos.Text = "Prima Pesos:"
        Me.lblTextPrimaPesos.Visible = False
        '
        'lblTextPrimaUF
        '
        Me.lblTextPrimaUF.BackColor = System.Drawing.Color.AliceBlue
        Me.lblTextPrimaUF.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTextPrimaUF.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblTextPrimaUF.ForeColor = System.Drawing.Color.Black
        Me.lblTextPrimaUF.Location = New System.Drawing.Point(339, 179)
        Me.lblTextPrimaUF.Name = "lblTextPrimaUF"
        Me.lblTextPrimaUF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTextPrimaUF.Size = New System.Drawing.Size(91, 17)
        Me.lblTextPrimaUF.TabIndex = 240
        Me.lblTextPrimaUF.Text = "Prima UF:"
        Me.lblTextPrimaUF.Visible = False
        '
        'btnAdicional
        '
        Me.btnAdicional.BackColor = System.Drawing.Color.White
        Me.btnAdicional.Location = New System.Drawing.Point(526, 205)
        Me.btnAdicional.Name = "btnAdicional"
        Me.btnAdicional.Size = New System.Drawing.Size(125, 23)
        Me.btnAdicional.TabIndex = 14
        Me.btnAdicional.Text = "Adicional"
        Me.btnAdicional.UseVisualStyleBackColor = False
        Me.btnAdicional.Visible = False
        '
        'btnBeneficiarios
        '
        Me.btnBeneficiarios.BackColor = System.Drawing.Color.White
        Me.btnBeneficiarios.Location = New System.Drawing.Point(526, 179)
        Me.btnBeneficiarios.Name = "btnBeneficiarios"
        Me.btnBeneficiarios.Size = New System.Drawing.Size(125, 23)
        Me.btnBeneficiarios.TabIndex = 15
        Me.btnBeneficiarios.Text = "Beneficiario"
        Me.btnBeneficiarios.UseVisualStyleBackColor = False
        Me.btnBeneficiarios.Visible = False
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label82.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label82.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label82.Location = New System.Drawing.Point(772, 86)
        Me.Label82.Name = "Label82"
        Me.Label82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label82.Size = New System.Drawing.Size(110, 25)
        Me.Label82.TabIndex = 233
        Me.Label82.Text = "Sexo"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbSexo
        '
        Me.CmbSexo.BackColor = System.Drawing.SystemColors.Window
        Me.CmbSexo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSexo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbSexo.Items.AddRange(New Object() {"[No Especificado]", "M", "F"})
        Me.CmbSexo.Location = New System.Drawing.Point(772, 114)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbSexo.Size = New System.Drawing.Size(109, 21)
        Me.CmbSexo.TabIndex = 11
        '
        'txtCalculaEdad
        '
        Me.txtCalculaEdad.AcceptsReturn = True
        Me.txtCalculaEdad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalculaEdad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalculaEdad.Enabled = False
        Me.txtCalculaEdad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCalculaEdad.Location = New System.Drawing.Point(887, 115)
        Me.txtCalculaEdad.MaxLength = 10
        Me.txtCalculaEdad.Name = "txtCalculaEdad"
        Me.txtCalculaEdad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCalculaEdad.Size = New System.Drawing.Size(51, 21)
        Me.txtCalculaEdad.TabIndex = 223
        Me.txtCalculaEdad.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(888, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 222
        Me.Label2.Text = "Edad"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'txtFonoVenta
        '
        Me.txtFonoVenta.AcceptsReturn = True
        Me.txtFonoVenta.BackColor = System.Drawing.SystemColors.Window
        Me.txtFonoVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFonoVenta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFonoVenta.Location = New System.Drawing.Point(6, 114)
        Me.txtFonoVenta.MaxLength = 9
        Me.txtFonoVenta.Name = "txtFonoVenta"
        Me.txtFonoVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFonoVenta.Size = New System.Drawing.Size(156, 21)
        Me.txtFonoVenta.TabIndex = 7
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label81.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label81.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label81.Location = New System.Drawing.Point(6, 86)
        Me.Label81.Name = "Label81"
        Me.Label81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label81.Size = New System.Drawing.Size(156, 25)
        Me.Label81.TabIndex = 206
        Me.Label81.Text = "Fono Venta"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTomaDireccion
        '
        Me.lblTomaDireccion.BackColor = System.Drawing.Color.AliceBlue
        Me.lblTomaDireccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTomaDireccion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTomaDireccion.ForeColor = System.Drawing.Color.Red
        Me.lblTomaDireccion.Location = New System.Drawing.Point(9, 209)
        Me.lblTomaDireccion.Name = "lblTomaDireccion"
        Me.lblTomaDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTomaDireccion.Size = New System.Drawing.Size(306, 26)
        Me.lblTomaDireccion.TabIndex = 201
        Me.lblTomaDireccion.Text = "Indique direccion direccion:"
        '
        'dtFechaNacV
        '
        Me.dtFechaNacV.CustomFormat = ""
        Me.dtFechaNacV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacV.Location = New System.Drawing.Point(787, 63)
        Me.dtFechaNacV.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtFechaNacV.Name = "dtFechaNacV"
        Me.dtFechaNacV.Size = New System.Drawing.Size(142, 21)
        Me.dtFechaNacV.TabIndex = 6
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label34.Location = New System.Drawing.Point(227, 297)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(206, 25)
        Me.Label34.TabIndex = 183
        Me.Label34.Text = "Ciudad"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCiudad
        '
        Me.cmbCiudad.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCiudad.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCiudad.Enabled = False
        Me.cmbCiudad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCiudad.Location = New System.Drawing.Point(227, 325)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCiudad.Size = New System.Drawing.Size(206, 21)
        Me.cmbCiudad.TabIndex = 182
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label33.Location = New System.Drawing.Point(12, 297)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(206, 25)
        Me.Label33.TabIndex = 181
        Me.Label33.Text = "Comuna"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbComuna
        '
        Me.cmbComuna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbComuna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbComuna.BackColor = System.Drawing.SystemColors.Window
        Me.cmbComuna.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbComuna.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbComuna.Location = New System.Drawing.Point(12, 325)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbComuna.Size = New System.Drawing.Size(206, 21)
        Me.cmbComuna.TabIndex = 20
        '
        'txtReferenciaV
        '
        Me.txtReferenciaV.AcceptsReturn = True
        Me.txtReferenciaV.BackColor = System.Drawing.SystemColors.Window
        Me.txtReferenciaV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReferenciaV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReferenciaV.Location = New System.Drawing.Point(374, 263)
        Me.txtReferenciaV.MaxLength = 50
        Me.txtReferenciaV.Name = "txtReferenciaV"
        Me.txtReferenciaV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtReferenciaV.Size = New System.Drawing.Size(220, 21)
        Me.txtReferenciaV.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label23.Location = New System.Drawing.Point(374, 235)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(220, 25)
        Me.Label23.TabIndex = 176
        Me.Label23.Text = "Referencia (Depto)"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNroV
        '
        Me.txtNroV.AcceptsReturn = True
        Me.txtNroV.BackColor = System.Drawing.SystemColors.Window
        Me.txtNroV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNroV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNroV.Location = New System.Drawing.Point(296, 263)
        Me.txtNroV.MaxLength = 10
        Me.txtNroV.Name = "txtNroV"
        Me.txtNroV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNroV.Size = New System.Drawing.Size(72, 21)
        Me.txtNroV.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label22.Location = New System.Drawing.Point(296, 235)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(72, 25)
        Me.Label22.TabIndex = 174
        Me.Label22.Text = "Numero"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCalleV
        '
        Me.txtCalleV.AcceptsReturn = True
        Me.txtCalleV.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalleV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalleV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalleV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCalleV.Location = New System.Drawing.Point(12, 263)
        Me.txtCalleV.MaxLength = 70
        Me.txtCalleV.Name = "txtCalleV"
        Me.txtCalleV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCalleV.Size = New System.Drawing.Size(277, 21)
        Me.txtCalleV.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label21.Location = New System.Drawing.Point(12, 235)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(277, 25)
        Me.Label21.TabIndex = 172
        Me.Label21.Text = "Calle"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.AcceptsReturn = True
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmail.Location = New System.Drawing.Point(168, 114)
        Me.txtEmail.MaxLength = 45
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(252, 21)
        Me.txtEmail.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label20.Location = New System.Drawing.Point(168, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(252, 25)
        Me.Label20.TabIndex = 170
        Me.Label20.Text = "Email"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label18.Location = New System.Drawing.Point(786, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(144, 25)
        Me.Label18.TabIndex = 164
        Me.Label18.Text = "Fecha de Nacimiento"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDvV
        '
        Me.txtDvV.AcceptsReturn = True
        Me.txtDvV.BackColor = System.Drawing.SystemColors.Window
        Me.txtDvV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDvV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDvV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDvV.Location = New System.Drawing.Point(739, 62)
        Me.txtDvV.MaxLength = 1
        Me.txtDvV.Name = "txtDvV"
        Me.txtDvV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDvV.Size = New System.Drawing.Size(39, 21)
        Me.txtDvV.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label16.Location = New System.Drawing.Point(738, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(40, 25)
        Me.Label16.TabIndex = 162
        Me.Label16.Text = "DV"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRutV
        '
        Me.txtRutV.AcceptsReturn = True
        Me.txtRutV.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRutV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRutV.Location = New System.Drawing.Point(643, 62)
        Me.txtRutV.MaxLength = 8
        Me.txtRutV.Name = "txtRutV"
        Me.txtRutV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRutV.Size = New System.Drawing.Size(90, 21)
        Me.txtRutV.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label15.Location = New System.Drawing.Point(644, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(91, 25)
        Me.Label15.TabIndex = 160
        Me.Label15.Text = "Rut"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaternoV
        '
        Me.txtMaternoV.AcceptsReturn = True
        Me.txtMaternoV.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaternoV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaternoV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaternoV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMaternoV.Location = New System.Drawing.Point(510, 62)
        Me.txtMaternoV.MaxLength = 50
        Me.txtMaternoV.Name = "txtMaternoV"
        Me.txtMaternoV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaternoV.Size = New System.Drawing.Size(127, 21)
        Me.txtMaternoV.TabIndex = 3
        '
        'txtPaternoV
        '
        Me.txtPaternoV.AcceptsReturn = True
        Me.txtPaternoV.BackColor = System.Drawing.SystemColors.Window
        Me.txtPaternoV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaternoV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaternoV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPaternoV.Location = New System.Drawing.Point(374, 62)
        Me.txtPaternoV.MaxLength = 50
        Me.txtPaternoV.Name = "txtPaternoV"
        Me.txtPaternoV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPaternoV.Size = New System.Drawing.Size(127, 21)
        Me.txtPaternoV.TabIndex = 2
        '
        'txtNombreV
        '
        Me.txtNombreV.AcceptsReturn = True
        Me.txtNombreV.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombreV.Location = New System.Drawing.Point(6, 62)
        Me.txtNombreV.MaxLength = 50
        Me.txtNombreV.Name = "txtNombreV"
        Me.txtNombreV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombreV.Size = New System.Drawing.Size(362, 21)
        Me.txtNombreV.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label14.Location = New System.Drawing.Point(509, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(128, 25)
        Me.Label14.TabIndex = 156
        Me.Label14.Text = "Apellido Materno"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(374, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(127, 25)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "Apellido Paterno"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(6, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(362, 25)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Nombre"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDatosCli
        '
        Me.lblDatosCli.BackColor = System.Drawing.Color.AliceBlue
        Me.lblDatosCli.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDatosCli.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblDatosCli.Location = New System.Drawing.Point(6, 17)
        Me.lblDatosCli.Name = "lblDatosCli"
        Me.lblDatosCli.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDatosCli.Size = New System.Drawing.Size(128, 17)
        Me.lblDatosCli.TabIndex = 38
        Me.lblDatosCli.Text = "Datos Personales:"
        '
        '_Cuerpo_MPago
        '
        Me._Cuerpo_MPago.BackColor = System.Drawing.Color.MediumSeaGreen
        Me._Cuerpo_MPago.Controls.Add(Me.CmdFinVentaMP)
        Me._Cuerpo_MPago.Controls.Add(Me.Label90)
        Me._Cuerpo_MPago.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_MPago.Name = "_Cuerpo_MPago"
        Me._Cuerpo_MPago.Padding = New System.Windows.Forms.Padding(3)
        Me._Cuerpo_MPago.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_MPago.TabIndex = 17
        Me._Cuerpo_MPago.Text = "Medio Pago"
        '
        'CmdFinVentaMP
        '
        Me.CmdFinVentaMP.BackColor = System.Drawing.SystemColors.Control
        Me.CmdFinVentaMP.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdFinVentaMP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFinVentaMP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdFinVentaMP.Image = CType(resources.GetObject("CmdFinVentaMP.Image"), System.Drawing.Image)
        Me.CmdFinVentaMP.Location = New System.Drawing.Point(110, 354)
        Me.CmdFinVentaMP.Name = "CmdFinVentaMP"
        Me.CmdFinVentaMP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdFinVentaMP.Size = New System.Drawing.Size(73, 41)
        Me.CmdFinVentaMP.TabIndex = 273
        Me.CmdFinVentaMP.Text = "&Terminar"
        Me.CmdFinVentaMP.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdFinVentaMP.UseVisualStyleBackColor = False
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Tahoma", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label90.Location = New System.Drawing.Point(9, 20)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(416, 18)
        Me.Label90.TabIndex = 272
        Me.Label90.Text = "INGRESE MEDIO DE PAGO INDICADO POR EL CLIENTE"
        '
        '_Cuerpo_InfAdic
        '
        Me._Cuerpo_InfAdic.BackColor = System.Drawing.Color.MediumSeaGreen
        Me._Cuerpo_InfAdic.Controls.Add(Me.Button2)
        Me._Cuerpo_InfAdic.Controls.Add(Me.WebInfAdicional)
        Me._Cuerpo_InfAdic.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_InfAdic.Name = "_Cuerpo_InfAdic"
        Me._Cuerpo_InfAdic.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_InfAdic.TabIndex = 13
        Me._Cuerpo_InfAdic.Text = "Informacion Adic"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(99, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(73, 41)
        Me.Button2.TabIndex = 156
        Me.Button2.Text = "&Siguiente"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'WebInfAdicional
        '
        Me.WebInfAdicional.Location = New System.Drawing.Point(7, 3)
        Me.WebInfAdicional.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebInfAdicional.Name = "WebInfAdicional"
        Me.WebInfAdicional.Size = New System.Drawing.Size(981, 326)
        Me.WebInfAdicional.TabIndex = 123
        '
        '_Cuerpo_Certifica
        '
        Me._Cuerpo_Certifica.BackColor = System.Drawing.Color.MediumSeaGreen
        Me._Cuerpo_Certifica.Controls.Add(Me.wbScriptCertificacion)
        Me._Cuerpo_Certifica.Controls.Add(Me.cmbAceptaPrima)
        Me._Cuerpo_Certifica.Controls.Add(Me.lblCargoTarjeta)
        Me._Cuerpo_Certifica.Controls.Add(Me.cmbAceptaContrato)
        Me._Cuerpo_Certifica.Controls.Add(Me.lblAcepta)
        Me._Cuerpo_Certifica.Controls.Add(Me.cmdSiguienteFin)
        Me._Cuerpo_Certifica.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_Certifica.Name = "_Cuerpo_Certifica"
        Me._Cuerpo_Certifica.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_Certifica.TabIndex = 12
        Me._Cuerpo_Certifica.Text = "Certificador"
        '
        'wbScriptCertificacion
        '
        Me.wbScriptCertificacion.Location = New System.Drawing.Point(7, 3)
        Me.wbScriptCertificacion.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbScriptCertificacion.Name = "wbScriptCertificacion"
        Me.wbScriptCertificacion.Size = New System.Drawing.Size(985, 284)
        Me.wbScriptCertificacion.TabIndex = 156
        '
        'cmbAceptaPrima
        '
        Me.cmbAceptaPrima.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAceptaPrima.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbAceptaPrima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAceptaPrima.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAceptaPrima.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAceptaPrima.Items.AddRange(New Object() {"[No Especificado]", "SI", "NO"})
        Me.cmbAceptaPrima.Location = New System.Drawing.Point(176, 324)
        Me.cmbAceptaPrima.Name = "cmbAceptaPrima"
        Me.cmbAceptaPrima.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbAceptaPrima.Size = New System.Drawing.Size(124, 24)
        Me.cmbAceptaPrima.TabIndex = 122
        '
        'lblCargoTarjeta
        '
        Me.lblCargoTarjeta.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lblCargoTarjeta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCargoTarjeta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargoTarjeta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCargoTarjeta.Location = New System.Drawing.Point(173, 301)
        Me.lblCargoTarjeta.Name = "lblCargoTarjeta"
        Me.lblCargoTarjeta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCargoTarjeta.Size = New System.Drawing.Size(141, 19)
        Me.lblCargoTarjeta.TabIndex = 121
        Me.lblCargoTarjeta.Text = "¿Acepta Prima?"
        '
        'cmbAceptaContrato
        '
        Me.cmbAceptaContrato.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAceptaContrato.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbAceptaContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAceptaContrato.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAceptaContrato.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAceptaContrato.Items.AddRange(New Object() {"[No Especificado]", "SI", "NO"})
        Me.cmbAceptaContrato.Location = New System.Drawing.Point(17, 324)
        Me.cmbAceptaContrato.Name = "cmbAceptaContrato"
        Me.cmbAceptaContrato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbAceptaContrato.Size = New System.Drawing.Size(124, 24)
        Me.cmbAceptaContrato.TabIndex = 119
        '
        'lblAcepta
        '
        Me.lblAcepta.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lblAcepta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAcepta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcepta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAcepta.Location = New System.Drawing.Point(20, 300)
        Me.lblAcepta.Name = "lblAcepta"
        Me.lblAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAcepta.Size = New System.Drawing.Size(144, 21)
        Me.lblAcepta.TabIndex = 118
        Me.lblAcepta.Text = "¿Acepta Contratacion?"
        '
        'cmdSiguienteFin
        '
        Me.cmdSiguienteFin.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSiguienteFin.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSiguienteFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiguienteFin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSiguienteFin.Image = CType(resources.GetObject("cmdSiguienteFin.Image"), System.Drawing.Image)
        Me.cmdSiguienteFin.Location = New System.Drawing.Point(99, 354)
        Me.cmdSiguienteFin.Name = "cmdSiguienteFin"
        Me.cmdSiguienteFin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSiguienteFin.Size = New System.Drawing.Size(73, 41)
        Me.cmdSiguienteFin.TabIndex = 155
        Me.cmdSiguienteFin.Text = "&Siguiente"
        Me.cmdSiguienteFin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSiguienteFin.UseVisualStyleBackColor = False
        '
        '_Cuerpo_UltInfo
        '
        Me._Cuerpo_UltInfo.BackColor = System.Drawing.Color.MediumSeaGreen
        Me._Cuerpo_UltInfo.Controls.Add(Me.cmbGiftCard)
        Me._Cuerpo_UltInfo.Controls.Add(Me.chkGiftcard)
        Me._Cuerpo_UltInfo.Controls.Add(Me.btnEliminarPolizaVenta)
        Me._Cuerpo_UltInfo.Controls.Add(Me.dtpFechaMandato)
        Me._Cuerpo_UltInfo.Controls.Add(Me.cmbHoraMandato)
        Me._Cuerpo_UltInfo.Controls.Add(Me.lblFechaMandato)
        Me._Cuerpo_UltInfo.Controls.Add(Me.lblHoraMandato)
        Me._Cuerpo_UltInfo.Controls.Add(Me.lblPolizasPago)
        Me._Cuerpo_UltInfo.Controls.Add(Me.btnGuardarPago)
        Me._Cuerpo_UltInfo.Controls.Add(Me.dtgPolizasPago)
        Me._Cuerpo_UltInfo.Controls.Add(Me.lblIngresoMP)
        Me._Cuerpo_UltInfo.Controls.Add(Me.cmbIngresaMedioPago)
        Me._Cuerpo_UltInfo.Controls.Add(Me.lblIngresoMedioPago)
        Me._Cuerpo_UltInfo.Controls.Add(Me.Panelotro)
        Me._Cuerpo_UltInfo.Controls.Add(Me.cmbMedioPago)
        Me._Cuerpo_UltInfo.Controls.Add(Me.lblMedioPago)
        Me._Cuerpo_UltInfo.Controls.Add(Me.btnSiguientePoliza)
        Me._Cuerpo_UltInfo.Controls.Add(Me.cmdFinVenta)
        Me._Cuerpo_UltInfo.Controls.Add(Me.Label8)
        Me._Cuerpo_UltInfo.Controls.Add(Me.lblNuevaPoliza)
        Me._Cuerpo_UltInfo.Controls.Add(Me.cmbNuevaPoliza)
        Me._Cuerpo_UltInfo.Controls.Add(Me.dtgPolizasVigentes)
        Me._Cuerpo_UltInfo.Controls.Add(Me.WebBrowsercierre)
        Me._Cuerpo_UltInfo.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_UltInfo.Name = "_Cuerpo_UltInfo"
        Me._Cuerpo_UltInfo.Padding = New System.Windows.Forms.Padding(3)
        Me._Cuerpo_UltInfo.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_UltInfo.TabIndex = 18
        Me._Cuerpo_UltInfo.Text = "Cierre Venta"
        '
        'cmbGiftCard
        '
        Me.cmbGiftCard.FormattingEnabled = True
        Me.cmbGiftCard.Location = New System.Drawing.Point(513, 331)
        Me.cmbGiftCard.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbGiftCard.Name = "cmbGiftCard"
        Me.cmbGiftCard.Size = New System.Drawing.Size(123, 21)
        Me.cmbGiftCard.TabIndex = 290
        Me.cmbGiftCard.Visible = False
        '
        'chkGiftcard
        '
        Me.chkGiftcard.AutoSize = True
        Me.chkGiftcard.Location = New System.Drawing.Point(375, 334)
        Me.chkGiftcard.Margin = New System.Windows.Forms.Padding(2)
        Me.chkGiftcard.Name = "chkGiftcard"
        Me.chkGiftcard.Size = New System.Drawing.Size(122, 17)
        Me.chkGiftcard.TabIndex = 289
        Me.chkGiftcard.Text = "Cliente con GiftCard"
        Me.chkGiftcard.UseVisualStyleBackColor = True
        '
        'btnEliminarPolizaVenta
        '
        Me.btnEliminarPolizaVenta.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPolizaVenta.ForeColor = System.Drawing.Color.Red
        Me.btnEliminarPolizaVenta.Location = New System.Drawing.Point(688, 166)
        Me.btnEliminarPolizaVenta.Name = "btnEliminarPolizaVenta"
        Me.btnEliminarPolizaVenta.Size = New System.Drawing.Size(132, 30)
        Me.btnEliminarPolizaVenta.TabIndex = 288
        Me.btnEliminarPolizaVenta.Text = "Eliminar Poliza"
        Me.btnEliminarPolizaVenta.UseVisualStyleBackColor = True
        '
        'dtpFechaMandato
        '
        Me.dtpFechaMandato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMandato.Location = New System.Drawing.Point(505, 181)
        Me.dtpFechaMandato.Name = "dtpFechaMandato"
        Me.dtpFechaMandato.Size = New System.Drawing.Size(91, 21)
        Me.dtpFechaMandato.TabIndex = 287
        '
        'cmbHoraMandato
        '
        Me.cmbHoraMandato.AutoCompleteCustomSource.AddRange(New String() {"0900", "0930", "1000", "1030", "1100", "1130", "1200", "1230", "1300", "1330", "1400", "1430", "1500", "1530", "1600", "1630", "1700", "1730", "1800", "1830", "1900", "1930", "2000", ""})
        Me.cmbHoraMandato.BackColor = System.Drawing.SystemColors.Window
        Me.cmbHoraMandato.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbHoraMandato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoraMandato.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbHoraMandato.Items.AddRange(New Object() {"0800", "0830", "0900", "0930", "1000", "1030", "1100", "1130", "1200", "1230", "1300", "1330", "1400", "1430", "1500", "1530", "1600", "1630", "1700", "1730", "1800", "1830", "1900", "1930"})
        Me.cmbHoraMandato.Location = New System.Drawing.Point(604, 182)
        Me.cmbHoraMandato.Name = "cmbHoraMandato"
        Me.cmbHoraMandato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbHoraMandato.Size = New System.Drawing.Size(61, 21)
        Me.cmbHoraMandato.TabIndex = 284
        '
        'lblFechaMandato
        '
        Me.lblFechaMandato.AutoSize = True
        Me.lblFechaMandato.BackColor = System.Drawing.Color.Navy
        Me.lblFechaMandato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaMandato.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaMandato.ForeColor = System.Drawing.Color.White
        Me.lblFechaMandato.Location = New System.Drawing.Point(505, 163)
        Me.lblFechaMandato.Name = "lblFechaMandato"
        Me.lblFechaMandato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaMandato.Size = New System.Drawing.Size(38, 15)
        Me.lblFechaMandato.TabIndex = 286
        Me.lblFechaMandato.Text = "Fecha"
        Me.lblFechaMandato.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHoraMandato
        '
        Me.lblHoraMandato.AutoSize = True
        Me.lblHoraMandato.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHoraMandato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHoraMandato.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHoraMandato.ForeColor = System.Drawing.Color.White
        Me.lblHoraMandato.Location = New System.Drawing.Point(604, 163)
        Me.lblHoraMandato.Name = "lblHoraMandato"
        Me.lblHoraMandato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHoraMandato.Size = New System.Drawing.Size(32, 15)
        Me.lblHoraMandato.TabIndex = 285
        Me.lblHoraMandato.Text = "Hora"
        Me.lblHoraMandato.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPolizasPago
        '
        Me.lblPolizasPago.AutoSize = True
        Me.lblPolizasPago.Font = New System.Drawing.Font("Tahoma", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPolizasPago.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblPolizasPago.Location = New System.Drawing.Point(9, 217)
        Me.lblPolizasPago.Name = "lblPolizasPago"
        Me.lblPolizasPago.Size = New System.Drawing.Size(193, 18)
        Me.lblPolizasPago.TabIndex = 283
        Me.lblPolizasPago.Text = "Seleccione Poliza a Pago"
        '
        'btnGuardarPago
        '
        Me.btnGuardarPago.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPago.Location = New System.Drawing.Point(649, 339)
        Me.btnGuardarPago.Name = "btnGuardarPago"
        Me.btnGuardarPago.Size = New System.Drawing.Size(120, 35)
        Me.btnGuardarPago.TabIndex = 282
        Me.btnGuardarPago.Text = "Guardar Pago"
        Me.btnGuardarPago.UseVisualStyleBackColor = True
        '
        'dtgPolizasPago
        '
        Me.dtgPolizasPago.AllowUserToAddRows = False
        Me.dtgPolizasPago.AllowUserToDeleteRows = False
        Me.dtgPolizasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPolizasPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccione, Me.idPoliza, Me.llave, Me.uf, Me.tipoPlan})
        Me.dtgPolizasPago.Location = New System.Drawing.Point(12, 249)
        Me.dtgPolizasPago.Name = "dtgPolizasPago"
        Me.dtgPolizasPago.ReadOnly = True
        Me.dtgPolizasPago.RowHeadersVisible = False
        Me.dtgPolizasPago.Size = New System.Drawing.Size(358, 87)
        Me.dtgPolizasPago.TabIndex = 281
        '
        'seleccione
        '
        Me.seleccione.HeaderText = "Seleccione"
        Me.seleccione.Name = "seleccione"
        Me.seleccione.ReadOnly = True
        Me.seleccione.Width = 65
        '
        'idPoliza
        '
        Me.idPoliza.DataPropertyName = "ID_POLIZA"
        Me.idPoliza.HeaderText = "Id Poliza"
        Me.idPoliza.Name = "idPoliza"
        Me.idPoliza.ReadOnly = True
        Me.idPoliza.Visible = False
        '
        'llave
        '
        Me.llave.DataPropertyName = "LLAVE"
        Me.llave.HeaderText = "Llave"
        Me.llave.Name = "llave"
        Me.llave.ReadOnly = True
        Me.llave.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.llave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.llave.Width = 120
        '
        'uf
        '
        Me.uf.DataPropertyName = "UF"
        Me.uf.HeaderText = "Valor UF"
        Me.uf.Name = "uf"
        Me.uf.ReadOnly = True
        Me.uf.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.uf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.uf.Width = 70
        '
        'tipoPlan
        '
        Me.tipoPlan.DataPropertyName = "TIPO_PLAN"
        Me.tipoPlan.HeaderText = "Tipo Plan"
        Me.tipoPlan.Name = "tipoPlan"
        Me.tipoPlan.ReadOnly = True
        '
        'lblIngresoMP
        '
        Me.lblIngresoMP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoMP.ForeColor = System.Drawing.Color.Transparent
        Me.lblIngresoMP.Location = New System.Drawing.Point(271, 163)
        Me.lblIngresoMP.Name = "lblIngresoMP"
        Me.lblIngresoMP.Size = New System.Drawing.Size(121, 39)
        Me.lblIngresoMP.TabIndex = 280
        Me.lblIngresoMP.Text = "¿Cliente Ingresara Medio de Pago?"
        '
        'cmbIngresaMedioPago
        '
        Me.cmbIngresaMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIngresaMedioPago.FormattingEnabled = True
        Me.cmbIngresaMedioPago.Items.AddRange(New Object() {"[Seleccione]", "Si", "No"})
        Me.cmbIngresaMedioPago.Location = New System.Drawing.Point(398, 166)
        Me.cmbIngresaMedioPago.Name = "cmbIngresaMedioPago"
        Me.cmbIngresaMedioPago.Size = New System.Drawing.Size(92, 21)
        Me.cmbIngresaMedioPago.TabIndex = 279
        '
        'lblIngresoMedioPago
        '
        Me.lblIngresoMedioPago.AutoSize = True
        Me.lblIngresoMedioPago.Font = New System.Drawing.Font("Tahoma", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoMedioPago.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblIngresoMedioPago.Location = New System.Drawing.Point(404, 235)
        Me.lblIngresoMedioPago.Name = "lblIngresoMedioPago"
        Me.lblIngresoMedioPago.Size = New System.Drawing.Size(416, 18)
        Me.lblIngresoMedioPago.TabIndex = 278
        Me.lblIngresoMedioPago.Text = "INGRESE MEDIO DE PAGO INDICADO POR EL CLIENTE"
        '
        'Panelotro
        '
        Me.Panelotro.Controls.Add(Me.cmbTpoTarjeta)
        Me.Panelotro.Controls.Add(Me.lblTipoTarjeta)
        Me.Panelotro.Controls.Add(Me.CmbBanco)
        Me.Panelotro.Controls.Add(Me.txtNumeroCuenta)
        Me.Panelotro.Controls.Add(Me.lblNumeroCuenta)
        Me.Panelotro.Controls.Add(Me.lblBanco)
        Me.Panelotro.Location = New System.Drawing.Point(565, 267)
        Me.Panelotro.Name = "Panelotro"
        Me.Panelotro.Size = New System.Drawing.Size(415, 55)
        Me.Panelotro.TabIndex = 277
        Me.Panelotro.Visible = False
        '
        'cmbTpoTarjeta
        '
        Me.cmbTpoTarjeta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTpoTarjeta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTpoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTpoTarjeta.FormattingEnabled = True
        Me.cmbTpoTarjeta.Items.AddRange(New Object() {"--Seleccione--", "VISA", "MASTERCARD", "AMERICAN EXPRESS", "DINNERS CLUB"})
        Me.cmbTpoTarjeta.Location = New System.Drawing.Point(154, 28)
        Me.cmbTpoTarjeta.Name = "cmbTpoTarjeta"
        Me.cmbTpoTarjeta.Size = New System.Drawing.Size(122, 21)
        Me.cmbTpoTarjeta.TabIndex = 271
        '
        'lblTipoTarjeta
        '
        Me.lblTipoTarjeta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTipoTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoTarjeta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoTarjeta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTarjeta.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblTipoTarjeta.Location = New System.Drawing.Point(153, 0)
        Me.lblTipoTarjeta.Name = "lblTipoTarjeta"
        Me.lblTipoTarjeta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoTarjeta.Size = New System.Drawing.Size(123, 25)
        Me.lblTipoTarjeta.TabIndex = 270
        Me.lblTipoTarjeta.Text = "Tipo tarjeta"
        Me.lblTipoTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbBanco
        '
        Me.CmbBanco.BackColor = System.Drawing.SystemColors.Window
        Me.CmbBanco.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBanco.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbBanco.Items.AddRange(New Object() {"[--Seleccionar--]", "BANCO DE CHILE", "BANCO ESTADO", "SCOTIABANK", "BCI", "CORPBANCA", "BANCO SANTANDER", "BANCO SECURITY", "BANCO FALABELLA", "BANCO RIPLEY", "BANCO BBVA", "BANCO PARIS", "BANCO NOVA", "BANCO CREDICHILE", "ITAÚ"})
        Me.CmbBanco.Location = New System.Drawing.Point(3, 28)
        Me.CmbBanco.Name = "CmbBanco"
        Me.CmbBanco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbBanco.Size = New System.Drawing.Size(142, 21)
        Me.CmbBanco.TabIndex = 269
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.AcceptsReturn = True
        Me.txtNumeroCuenta.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumeroCuenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumeroCuenta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(282, 28)
        Me.txtNumeroCuenta.MaxLength = 200
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(117, 21)
        Me.txtNumeroCuenta.TabIndex = 214
        '
        'lblNumeroCuenta
        '
        Me.lblNumeroCuenta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNumeroCuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumeroCuenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumeroCuenta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCuenta.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblNumeroCuenta.Location = New System.Drawing.Point(282, 0)
        Me.lblNumeroCuenta.Name = "lblNumeroCuenta"
        Me.lblNumeroCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumeroCuenta.Size = New System.Drawing.Size(117, 25)
        Me.lblNumeroCuenta.TabIndex = 211
        Me.lblNumeroCuenta.Text = "Número Cuenta"
        Me.lblNumeroCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBanco
        '
        Me.lblBanco.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBanco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBanco.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBanco.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblBanco.Location = New System.Drawing.Point(3, 0)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBanco.Size = New System.Drawing.Size(144, 25)
        Me.lblBanco.TabIndex = 210
        Me.lblBanco.Text = "Banco Emisor"
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbMedioPago
        '
        Me.cmbMedioPago.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMedioPago.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMedioPago.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMedioPago.Items.AddRange(New Object() {"[SELECCIONE]", "PAC", "PAT", "CUENTA RUT"})
        Me.cmbMedioPago.Location = New System.Drawing.Point(405, 295)
        Me.cmbMedioPago.Name = "cmbMedioPago"
        Me.cmbMedioPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbMedioPago.Size = New System.Drawing.Size(140, 21)
        Me.cmbMedioPago.TabIndex = 276
        '
        'lblMedioPago
        '
        Me.lblMedioPago.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMedioPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedioPago.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMedioPago.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedioPago.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblMedioPago.Location = New System.Drawing.Point(405, 267)
        Me.lblMedioPago.Name = "lblMedioPago"
        Me.lblMedioPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMedioPago.Size = New System.Drawing.Size(140, 25)
        Me.lblMedioPago.TabIndex = 275
        Me.lblMedioPago.Text = "Medio de Pago"
        Me.lblMedioPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSiguientePoliza
        '
        Me.btnSiguientePoliza.BackColor = System.Drawing.SystemColors.Control
        Me.btnSiguientePoliza.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSiguientePoliza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePoliza.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSiguientePoliza.Image = CType(resources.GetObject("btnSiguientePoliza.Image"), System.Drawing.Image)
        Me.btnSiguientePoliza.Location = New System.Drawing.Point(111, 353)
        Me.btnSiguientePoliza.Name = "btnSiguientePoliza"
        Me.btnSiguientePoliza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSiguientePoliza.Size = New System.Drawing.Size(73, 41)
        Me.btnSiguientePoliza.TabIndex = 164
        Me.btnSiguientePoliza.Text = "&Siguiente"
        Me.btnSiguientePoliza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSiguientePoliza.UseVisualStyleBackColor = False
        '
        'cmdFinVenta
        '
        Me.cmdFinVenta.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFinVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFinVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinVenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFinVenta.Image = CType(resources.GetObject("cmdFinVenta.Image"), System.Drawing.Image)
        Me.cmdFinVenta.Location = New System.Drawing.Point(99, 354)
        Me.cmdFinVenta.Name = "cmdFinVenta"
        Me.cmdFinVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFinVenta.Size = New System.Drawing.Size(73, 41)
        Me.cmdFinVenta.TabIndex = 274
        Me.cmdFinVenta.Text = "&Terminar"
        Me.cmdFinVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFinVenta.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Indigo
        Me.Label8.Location = New System.Drawing.Point(839, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(142, 72)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "Listado de las Polizas Contratadas, junto con adicionales"
        '
        'lblNuevaPoliza
        '
        Me.lblNuevaPoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaPoliza.ForeColor = System.Drawing.Color.Transparent
        Me.lblNuevaPoliza.Location = New System.Drawing.Point(8, 163)
        Me.lblNuevaPoliza.Name = "lblNuevaPoliza"
        Me.lblNuevaPoliza.Size = New System.Drawing.Size(150, 39)
        Me.lblNuevaPoliza.TabIndex = 163
        Me.lblNuevaPoliza.Text = "¿Desea ingresar una nueva Poliza?"
        '
        'cmbNuevaPoliza
        '
        Me.cmbNuevaPoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNuevaPoliza.FormattingEnabled = True
        Me.cmbNuevaPoliza.Items.AddRange(New Object() {"[Seleccione]", "Si", "No"})
        Me.cmbNuevaPoliza.Location = New System.Drawing.Point(161, 166)
        Me.cmbNuevaPoliza.Name = "cmbNuevaPoliza"
        Me.cmbNuevaPoliza.Size = New System.Drawing.Size(94, 21)
        Me.cmbNuevaPoliza.TabIndex = 162
        '
        'dtgPolizasVigentes
        '
        Me.dtgPolizasVigentes.AllowUserToAddRows = False
        Me.dtgPolizasVigentes.AllowUserToDeleteRows = False
        Me.dtgPolizasVigentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPolizasVigentes.Location = New System.Drawing.Point(8, 3)
        Me.dtgPolizasVigentes.Name = "dtgPolizasVigentes"
        Me.dtgPolizasVigentes.ReadOnly = True
        Me.dtgPolizasVigentes.Size = New System.Drawing.Size(973, 157)
        Me.dtgPolizasVigentes.TabIndex = 161
        '
        'WebBrowsercierre
        '
        Me.WebBrowsercierre.Location = New System.Drawing.Point(7, 6)
        Me.WebBrowsercierre.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowsercierre.Name = "WebBrowsercierre"
        Me.WebBrowsercierre.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowsercierre.TabIndex = 160
        Me.WebBrowsercierre.Visible = False
        '
        '_Cuerpo_TabBenef
        '
        Me._Cuerpo_TabBenef.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_TabBenef.Name = "_Cuerpo_TabBenef"
        Me._Cuerpo_TabBenef.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_TabBenef.TabIndex = 16
        Me._Cuerpo_TabBenef.Text = "Beneficiarios"
        Me._Cuerpo_TabBenef.UseVisualStyleBackColor = True
        '
        '_Cuerpo_Adicionales
        '
        Me._Cuerpo_Adicionales.BackColor = System.Drawing.Color.MediumSeaGreen
        Me._Cuerpo_Adicionales.Controls.Add(Me.btnAdicionalSgt)
        Me._Cuerpo_Adicionales.Controls.Add(Me.GroupBox2)
        Me._Cuerpo_Adicionales.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_Adicionales.Name = "_Cuerpo_Adicionales"
        Me._Cuerpo_Adicionales.Padding = New System.Windows.Forms.Padding(3)
        Me._Cuerpo_Adicionales.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_Adicionales.TabIndex = 11
        Me._Cuerpo_Adicionales.Text = "Adicionales"
        '
        'btnAdicionalSgt
        '
        Me.btnAdicionalSgt.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdicionalSgt.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAdicionalSgt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionalSgt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdicionalSgt.Image = CType(resources.GetObject("btnAdicionalSgt.Image"), System.Drawing.Image)
        Me.btnAdicionalSgt.Location = New System.Drawing.Point(99, 354)
        Me.btnAdicionalSgt.Name = "btnAdicionalSgt"
        Me.btnAdicionalSgt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAdicionalSgt.Size = New System.Drawing.Size(73, 41)
        Me.btnAdicionalSgt.TabIndex = 170
        Me.btnAdicionalSgt.Text = "&Siguiente "
        Me.btnAdicionalSgt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdicionalSgt.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.lblIMCAdicional)
        Me.GroupBox2.Controls.Add(Me.btnIMCAdicional)
        Me.GroupBox2.Controls.Add(Me.dtAdicional)
        Me.GroupBox2.Controls.Add(Me.txtDatosDPS)
        Me.GroupBox2.Controls.Add(Me.lblObservaciones)
        Me.GroupBox2.Controls.Add(Me.mskEstatura)
        Me.GroupBox2.Controls.Add(Me.lblEstatura)
        Me.GroupBox2.Controls.Add(Me.txtPeso)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbIsapre)
        Me.GroupBox2.Controls.Add(Me.lblIsapre)
        Me.GroupBox2.Controls.Add(Me.lblSexoA)
        Me.GroupBox2.Controls.Add(Me.cmbSexoA)
        Me.GroupBox2.Controls.Add(Me.dtFechaNacAdic)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Parentesco)
        Me.GroupBox2.Controls.Add(Me.cmbParentescoAdic)
        Me.GroupBox2.Controls.Add(Me.txtDvA)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtRutA)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtMaternoA)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtPaternoA)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txtNombreA)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(981, 363)
        Me.GroupBox2.TabIndex = 199
        Me.GroupBox2.TabStop = False
        '
        'lblIMCAdicional
        '
        Me.lblIMCAdicional.AutoSize = True
        Me.lblIMCAdicional.Location = New System.Drawing.Point(427, 138)
        Me.lblIMCAdicional.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIMCAdicional.Name = "lblIMCAdicional"
        Me.lblIMCAdicional.Size = New System.Drawing.Size(0, 13)
        Me.lblIMCAdicional.TabIndex = 279
        '
        'btnIMCAdicional
        '
        Me.btnIMCAdicional.Location = New System.Drawing.Point(325, 135)
        Me.btnIMCAdicional.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIMCAdicional.Name = "btnIMCAdicional"
        Me.btnIMCAdicional.Size = New System.Drawing.Size(83, 17)
        Me.btnIMCAdicional.TabIndex = 278
        Me.btnIMCAdicional.Text = "Calcular IMC"
        Me.btnIMCAdicional.UseVisualStyleBackColor = True
        '
        'dtAdicional
        '
        Me.dtAdicional.AllowUserToAddRows = False
        Me.dtAdicional.AllowUserToDeleteRows = False
        Me.dtAdicional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtAdicional.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.paterno, Me.materno, Me.rut, Me.dv, Me.Sexo, Me.tipo_parentesco, Me.fechaNacimiento, Me.idParentescoAdi, Me.Isapre, Me.Peso, Me.Estatura, Me.DPS})
        Me.dtAdicional.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtAdicional.Location = New System.Drawing.Point(7, 157)
        Me.dtAdicional.Name = "dtAdicional"
        Me.dtAdicional.ReadOnly = True
        Me.dtAdicional.RowHeadersVisible = False
        Me.dtAdicional.Size = New System.Drawing.Size(969, 187)
        Me.dtAdicional.TabIndex = 277
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'paterno
        '
        Me.paterno.HeaderText = "Paterno"
        Me.paterno.Name = "paterno"
        Me.paterno.ReadOnly = True
        '
        'materno
        '
        Me.materno.HeaderText = "Materno"
        Me.materno.Name = "materno"
        Me.materno.ReadOnly = True
        '
        'rut
        '
        Me.rut.HeaderText = "Rut"
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        '
        'dv
        '
        Me.dv.HeaderText = "DV"
        Me.dv.Name = "dv"
        Me.dv.ReadOnly = True
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'tipo_parentesco
        '
        Me.tipo_parentesco.HeaderText = "Parentesco"
        Me.tipo_parentesco.Name = "tipo_parentesco"
        Me.tipo_parentesco.ReadOnly = True
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.ReadOnly = True
        '
        'idParentescoAdi
        '
        Me.idParentescoAdi.HeaderText = "idParentesco"
        Me.idParentescoAdi.Name = "idParentescoAdi"
        Me.idParentescoAdi.ReadOnly = True
        Me.idParentescoAdi.Visible = False
        '
        'Isapre
        '
        Me.Isapre.HeaderText = "Isapre"
        Me.Isapre.Name = "Isapre"
        Me.Isapre.ReadOnly = True
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        '
        'Estatura
        '
        Me.Estatura.HeaderText = "Estatura"
        Me.Estatura.Name = "Estatura"
        Me.Estatura.ReadOnly = True
        '
        'DPS
        '
        Me.DPS.HeaderText = "DPS"
        Me.DPS.Name = "DPS"
        Me.DPS.ReadOnly = True
        '
        'txtDatosDPS
        '
        Me.txtDatosDPS.AcceptsReturn = True
        Me.txtDatosDPS.BackColor = System.Drawing.SystemColors.Window
        Me.txtDatosDPS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatosDPS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDatosDPS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDatosDPS.Location = New System.Drawing.Point(493, 116)
        Me.txtDatosDPS.MaxLength = 50
        Me.txtDatosDPS.Name = "txtDatosDPS"
        Me.txtDatosDPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDatosDPS.Size = New System.Drawing.Size(258, 21)
        Me.txtDatosDPS.TabIndex = 275
        '
        'lblObservaciones
        '
        Me.lblObservaciones.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblObservaciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblObservaciones.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblObservaciones.Location = New System.Drawing.Point(493, 88)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblObservaciones.Size = New System.Drawing.Size(257, 25)
        Me.lblObservaciones.TabIndex = 276
        Me.lblObservaciones.Text = "Datos DPS"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskEstatura
        '
        Me.mskEstatura.Location = New System.Drawing.Point(414, 116)
        Me.mskEstatura.Mask = "0,00"
        Me.mskEstatura.Name = "mskEstatura"
        Me.mskEstatura.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.mskEstatura.Size = New System.Drawing.Size(73, 21)
        Me.mskEstatura.TabIndex = 274
        '
        'lblEstatura
        '
        Me.lblEstatura.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblEstatura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEstatura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEstatura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatura.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblEstatura.Location = New System.Drawing.Point(412, 88)
        Me.lblEstatura.Name = "lblEstatura"
        Me.lblEstatura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEstatura.Size = New System.Drawing.Size(75, 25)
        Me.lblEstatura.TabIndex = 273
        Me.lblEstatura.Text = "Estatura"
        Me.lblEstatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPeso
        '
        Me.txtPeso.AcceptsReturn = True
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPeso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPeso.Location = New System.Drawing.Point(357, 116)
        Me.txtPeso.MaxLength = 3
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeso.Size = New System.Drawing.Size(51, 21)
        Me.txtPeso.TabIndex = 272
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(358, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(50, 25)
        Me.Label6.TabIndex = 271
        Me.Label6.Text = "Peso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbIsapre
        '
        Me.cmbIsapre.AutoCompleteCustomSource.AddRange(New String() {"[Seleccione...]", "BANMEDICA", "COLMENA", "CONSALUD", "CRUZ BLANCA", "FONASA", "FAST BANCO ESTADO", "FUSAT", "MAS VIDA", "RIO BLANCO", "VIDA TRES", "DIPRECA", "CHUQUICAMATA"})
        Me.cmbIsapre.BackColor = System.Drawing.SystemColors.Window
        Me.cmbIsapre.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbIsapre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIsapre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbIsapre.Items.AddRange(New Object() {"[No Especificado]", "BANMEDICA", "COLMENA", "CONSALUD", "CRUZ BLANCA", "FONASA", "FAST BANCO ESTADO", "FUSAT", "MAS VIDA", "RIO BLANCO", "VIDA TRES", "DIPRECA", "CHUQUICAMATA"})
        Me.cmbIsapre.Location = New System.Drawing.Point(183, 116)
        Me.cmbIsapre.Name = "cmbIsapre"
        Me.cmbIsapre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbIsapre.Size = New System.Drawing.Size(167, 21)
        Me.cmbIsapre.TabIndex = 270
        '
        'lblIsapre
        '
        Me.lblIsapre.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblIsapre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIsapre.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIsapre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsapre.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblIsapre.Location = New System.Drawing.Point(183, 88)
        Me.lblIsapre.Name = "lblIsapre"
        Me.lblIsapre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIsapre.Size = New System.Drawing.Size(166, 25)
        Me.lblIsapre.TabIndex = 269
        Me.lblIsapre.Text = "Isapre"
        Me.lblIsapre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSexoA
        '
        Me.lblSexoA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSexoA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSexoA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSexoA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoA.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblSexoA.Location = New System.Drawing.Point(679, 36)
        Me.lblSexoA.Name = "lblSexoA"
        Me.lblSexoA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSexoA.Size = New System.Drawing.Size(110, 25)
        Me.lblSexoA.TabIndex = 218
        Me.lblSexoA.Text = "Sexo"
        Me.lblSexoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSexoA
        '
        Me.cmbSexoA.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSexoA.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSexoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexoA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSexoA.Items.AddRange(New Object() {"--Seleccione--", "M", "F"})
        Me.cmbSexoA.Location = New System.Drawing.Point(679, 64)
        Me.cmbSexoA.Name = "cmbSexoA"
        Me.cmbSexoA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSexoA.Size = New System.Drawing.Size(110, 21)
        Me.cmbSexoA.TabIndex = 206
        '
        'dtFechaNacAdic
        '
        Me.dtFechaNacAdic.CustomFormat = ""
        Me.dtFechaNacAdic.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacAdic.Location = New System.Drawing.Point(795, 64)
        Me.dtFechaNacAdic.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtFechaNacAdic.Name = "dtFechaNacAdic"
        Me.dtFechaNacAdic.Size = New System.Drawing.Size(141, 21)
        Me.dtFechaNacAdic.TabIndex = 207
        Me.dtFechaNacAdic.Value = New Date(2014, 9, 4, 0, 0, 0, 0)
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.AliceBlue
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(4, 14)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(147, 17)
        Me.Label31.TabIndex = 216
        Me.Label31.Text = "Ingrese Adicionales:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(875, 127)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(98, 24)
        Me.btnEliminar.TabIndex = 215
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(875, 100)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(98, 24)
        Me.btnModificar.TabIndex = 214
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(771, 107)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(98, 37)
        Me.btnAgregar.TabIndex = 210
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label32.Location = New System.Drawing.Point(795, 36)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(143, 25)
        Me.Label32.TabIndex = 213
        Me.Label32.Text = "Fecha de Nacimiento"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Parentesco
        '
        Me.Parentesco.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Parentesco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Parentesco.Cursor = System.Windows.Forms.Cursors.Default
        Me.Parentesco.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parentesco.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Parentesco.Location = New System.Drawing.Point(6, 88)
        Me.Parentesco.Name = "Parentesco"
        Me.Parentesco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Parentesco.Size = New System.Drawing.Size(167, 25)
        Me.Parentesco.TabIndex = 212
        Me.Parentesco.Text = "Parentesco"
        Me.Parentesco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbParentescoAdic
        '
        Me.cmbParentescoAdic.BackColor = System.Drawing.SystemColors.Window
        Me.cmbParentescoAdic.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbParentescoAdic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParentescoAdic.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbParentescoAdic.Location = New System.Drawing.Point(6, 116)
        Me.cmbParentescoAdic.Name = "cmbParentescoAdic"
        Me.cmbParentescoAdic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbParentescoAdic.Size = New System.Drawing.Size(167, 21)
        Me.cmbParentescoAdic.TabIndex = 208
        '
        'txtDvA
        '
        Me.txtDvA.AcceptsReturn = True
        Me.txtDvA.BackColor = System.Drawing.SystemColors.Window
        Me.txtDvA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDvA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDvA.Location = New System.Drawing.Point(634, 64)
        Me.txtDvA.MaxLength = 1
        Me.txtDvA.Name = "txtDvA"
        Me.txtDvA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDvA.Size = New System.Drawing.Size(39, 21)
        Me.txtDvA.TabIndex = 205
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label29.Location = New System.Drawing.Point(633, 36)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(40, 25)
        Me.Label29.TabIndex = 211
        Me.Label29.Text = "DV"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRutA
        '
        Me.txtRutA.AcceptsReturn = True
        Me.txtRutA.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRutA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRutA.Location = New System.Drawing.Point(540, 64)
        Me.txtRutA.MaxLength = 8
        Me.txtRutA.Name = "txtRutA"
        Me.txtRutA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRutA.Size = New System.Drawing.Size(90, 21)
        Me.txtRutA.TabIndex = 204
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label30.Location = New System.Drawing.Point(539, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(91, 25)
        Me.Label30.TabIndex = 209
        Me.Label30.Text = "Rut"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaternoA
        '
        Me.txtMaternoA.AcceptsReturn = True
        Me.txtMaternoA.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaternoA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaternoA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaternoA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMaternoA.Location = New System.Drawing.Point(399, 64)
        Me.txtMaternoA.MaxLength = 50
        Me.txtMaternoA.Name = "txtMaternoA"
        Me.txtMaternoA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaternoA.Size = New System.Drawing.Size(134, 21)
        Me.txtMaternoA.TabIndex = 202
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label28.Location = New System.Drawing.Point(399, 36)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(134, 25)
        Me.Label28.TabIndex = 207
        Me.Label28.Text = "Materno"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPaternoA
        '
        Me.txtPaternoA.AcceptsReturn = True
        Me.txtPaternoA.BackColor = System.Drawing.SystemColors.Window
        Me.txtPaternoA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaternoA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaternoA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPaternoA.Location = New System.Drawing.Point(264, 64)
        Me.txtPaternoA.MaxLength = 50
        Me.txtPaternoA.Name = "txtPaternoA"
        Me.txtPaternoA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPaternoA.Size = New System.Drawing.Size(129, 21)
        Me.txtPaternoA.TabIndex = 201
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label27.Location = New System.Drawing.Point(264, 36)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(129, 25)
        Me.Label27.TabIndex = 203
        Me.Label27.Text = "Paterno"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreA
        '
        Me.txtNombreA.AcceptsReturn = True
        Me.txtNombreA.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombreA.Location = New System.Drawing.Point(6, 64)
        Me.txtNombreA.MaxLength = 50
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombreA.Size = New System.Drawing.Size(250, 21)
        Me.txtNombreA.TabIndex = 200
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label25.Location = New System.Drawing.Point(6, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(252, 25)
        Me.Label25.TabIndex = 199
        Me.Label25.Text = "Nombre 1"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Cuerpo_Objeciones
        '
        Me._Cuerpo_Objeciones.Controls.Add(Me.Label26)
        Me._Cuerpo_Objeciones.Controls.Add(Me.cmbNoIntereso)
        Me._Cuerpo_Objeciones.Controls.Add(Me._Label27_0)
        Me._Cuerpo_Objeciones.Controls.Add(Me.FrmObj)
        Me._Cuerpo_Objeciones.Controls.Add(Me.CmbObj)
        Me._Cuerpo_Objeciones.Controls.Add(Me.CmdSiguiente11)
        Me._Cuerpo_Objeciones.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_Objeciones.Name = "_Cuerpo_Objeciones"
        Me._Cuerpo_Objeciones.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_Objeciones.TabIndex = 6
        Me._Cuerpo_Objeciones.Text = "Manejo de Objeciones."
        Me._Cuerpo_Objeciones.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label26.Location = New System.Drawing.Point(118, 235)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(447, 25)
        Me.Label26.TabIndex = 156
        Me.Label26.Text = "Motivo Interno No intereso "
        Me.Label26.Visible = False
        '
        'cmbNoIntereso
        '
        Me.cmbNoIntereso.BackColor = System.Drawing.SystemColors.Window
        Me.cmbNoIntereso.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbNoIntereso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNoIntereso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNoIntereso.Items.AddRange(New Object() {"[No Especificado]", "ME FALTO MANEJO DE OBJECIONES", "ME FALTO CONOCIMIENTO DEL PRODUCTO", "ME FALTO SONRISA TELEFONICA"})
        Me.cmbNoIntereso.Location = New System.Drawing.Point(116, 268)
        Me.cmbNoIntereso.Name = "cmbNoIntereso"
        Me.cmbNoIntereso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNoIntereso.Size = New System.Drawing.Size(449, 21)
        Me.cmbNoIntereso.TabIndex = 155
        Me.cmbNoIntereso.Visible = False
        '
        '_Label27_0
        '
        Me._Label27_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me._Label27_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label27_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label27_0.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label27_0.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Label27_0.Location = New System.Drawing.Point(118, 88)
        Me._Label27_0.Name = "_Label27_0"
        Me._Label27_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label27_0.Size = New System.Drawing.Size(447, 25)
        Me._Label27_0.TabIndex = 153
        Me._Label27_0.Text = "Me podría decir la razón por la cual no desea contra el seguro:"
        '
        'FrmObj
        '
        Me.FrmObj.BackColor = System.Drawing.SystemColors.Control
        Me.FrmObj.Controls.Add(Me.TxtObj)
        Me.FrmObj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrmObj.Location = New System.Drawing.Point(118, 148)
        Me.FrmObj.Name = "FrmObj"
        Me.FrmObj.Padding = New System.Windows.Forms.Padding(0)
        Me.FrmObj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrmObj.Size = New System.Drawing.Size(433, 73)
        Me.FrmObj.TabIndex = 150
        Me.FrmObj.TabStop = False
        '
        'TxtObj
        '
        Me.TxtObj.AcceptsReturn = True
        Me.TxtObj.BackColor = System.Drawing.SystemColors.Window
        Me.TxtObj.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtObj.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtObj.Location = New System.Drawing.Point(8, 16)
        Me.TxtObj.MaxLength = 100
        Me.TxtObj.Multiline = True
        Me.TxtObj.Name = "TxtObj"
        Me.TxtObj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtObj.Size = New System.Drawing.Size(417, 54)
        Me.TxtObj.TabIndex = 151
        '
        'CmbObj
        '
        Me.CmbObj.BackColor = System.Drawing.SystemColors.Window
        Me.CmbObj.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbObj.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbObj.Items.AddRange(New Object() {"[No Especificado]", "MALA EXPERIENCIA BANCO", "NO CONFÍA EN ESTOS LLAMADOS", "NO LE INTERESA", "NO LO NECESITA", "TIENE MUCHOS SEGUROS", "YA NO ES CLIENTE DEL BANCO"})
        Me.CmbObj.Location = New System.Drawing.Point(116, 121)
        Me.CmbObj.Name = "CmbObj"
        Me.CmbObj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbObj.Size = New System.Drawing.Size(449, 21)
        Me.CmbObj.TabIndex = 152
        '
        'CmdSiguiente11
        '
        Me.CmdSiguiente11.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSiguiente11.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSiguiente11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSiguiente11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSiguiente11.Image = CType(resources.GetObject("CmdSiguiente11.Image"), System.Drawing.Image)
        Me.CmdSiguiente11.Location = New System.Drawing.Point(99, 354)
        Me.CmdSiguiente11.Name = "CmdSiguiente11"
        Me.CmdSiguiente11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSiguiente11.Size = New System.Drawing.Size(73, 41)
        Me.CmdSiguiente11.TabIndex = 154
        Me.CmdSiguiente11.Text = "&Siguiente"
        Me.CmdSiguiente11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSiguiente11.UseVisualStyleBackColor = False
        '
        '_Cuerpo_Agendar
        '
        Me._Cuerpo_Agendar.Controls.Add(Me.CmdSiguienteA)
        Me._Cuerpo_Agendar.Controls.Add(Me.CmdTerminarA)
        Me._Cuerpo_Agendar.Controls.Add(Me.FrmAgendamiento)
        Me._Cuerpo_Agendar.Controls.Add(Me.CmbEstAgenda)
        Me._Cuerpo_Agendar.Controls.Add(Me.LblAgendar)
        Me._Cuerpo_Agendar.Controls.Add(Me.Label47)
        Me._Cuerpo_Agendar.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_Agendar.Name = "_Cuerpo_Agendar"
        Me._Cuerpo_Agendar.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_Agendar.TabIndex = 7
        Me._Cuerpo_Agendar.Text = "Agendar"
        Me._Cuerpo_Agendar.UseVisualStyleBackColor = True
        '
        'CmdSiguienteA
        '
        Me.CmdSiguienteA.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSiguienteA.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSiguienteA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSiguienteA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSiguienteA.Image = CType(resources.GetObject("CmdSiguienteA.Image"), System.Drawing.Image)
        Me.CmdSiguienteA.Location = New System.Drawing.Point(111, 354)
        Me.CmdSiguienteA.Name = "CmdSiguienteA"
        Me.CmdSiguienteA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSiguienteA.Size = New System.Drawing.Size(73, 41)
        Me.CmdSiguienteA.TabIndex = 129
        Me.CmdSiguienteA.Text = "&Siguiente"
        Me.CmdSiguienteA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSiguienteA.UseVisualStyleBackColor = False
        '
        'CmdTerminarA
        '
        Me.CmdTerminarA.BackColor = System.Drawing.SystemColors.Control
        Me.CmdTerminarA.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdTerminarA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTerminarA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdTerminarA.Image = CType(resources.GetObject("CmdTerminarA.Image"), System.Drawing.Image)
        Me.CmdTerminarA.Location = New System.Drawing.Point(99, 354)
        Me.CmdTerminarA.Name = "CmdTerminarA"
        Me.CmdTerminarA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdTerminarA.Size = New System.Drawing.Size(73, 41)
        Me.CmdTerminarA.TabIndex = 128
        Me.CmdTerminarA.Text = "&Terminar"
        Me.CmdTerminarA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdTerminarA.UseVisualStyleBackColor = False
        Me.CmdTerminarA.Visible = False
        '
        'FrmAgendamiento
        '
        Me.FrmAgendamiento.BackColor = System.Drawing.SystemColors.Control
        Me.FrmAgendamiento.Controls.Add(Me.DTFechaAgen)
        Me.FrmAgendamiento.Controls.Add(Me.cmbHora)
        Me.FrmAgendamiento.Controls.Add(Me.cmbMin)
        Me.FrmAgendamiento.Controls.Add(Me.TxtObsA)
        Me.FrmAgendamiento.Controls.Add(Me.Label48)
        Me.FrmAgendamiento.Controls.Add(Me.Label46)
        Me.FrmAgendamiento.Controls.Add(Me.Label44)
        Me.FrmAgendamiento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrmAgendamiento.Location = New System.Drawing.Point(152, 174)
        Me.FrmAgendamiento.Name = "FrmAgendamiento"
        Me.FrmAgendamiento.Padding = New System.Windows.Forms.Padding(0)
        Me.FrmAgendamiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrmAgendamiento.Size = New System.Drawing.Size(681, 177)
        Me.FrmAgendamiento.TabIndex = 118
        Me.FrmAgendamiento.TabStop = False
        Me.FrmAgendamiento.Visible = False
        '
        'DTFechaAgen
        '
        Me.DTFechaAgen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaAgen.Location = New System.Drawing.Point(192, 130)
        Me.DTFechaAgen.Name = "DTFechaAgen"
        Me.DTFechaAgen.Size = New System.Drawing.Size(91, 21)
        Me.DTFechaAgen.TabIndex = 126
        '
        'cmbHora
        '
        Me.cmbHora.BackColor = System.Drawing.SystemColors.Window
        Me.cmbHora.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbHora.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22"})
        Me.cmbHora.Location = New System.Drawing.Point(312, 131)
        Me.cmbHora.Name = "cmbHora"
        Me.cmbHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbHora.Size = New System.Drawing.Size(57, 21)
        Me.cmbHora.TabIndex = 121
        '
        'cmbMin
        '
        Me.cmbMin.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMin.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50"})
        Me.cmbMin.Location = New System.Drawing.Point(392, 131)
        Me.cmbMin.Name = "cmbMin"
        Me.cmbMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbMin.Size = New System.Drawing.Size(57, 21)
        Me.cmbMin.TabIndex = 120
        '
        'TxtObsA
        '
        Me.TxtObsA.AcceptsReturn = True
        Me.TxtObsA.BackColor = System.Drawing.SystemColors.Window
        Me.TxtObsA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtObsA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtObsA.Location = New System.Drawing.Point(40, 32)
        Me.TxtObsA.MaxLength = 255
        Me.TxtObsA.Multiline = True
        Me.TxtObsA.Name = "TxtObsA"
        Me.TxtObsA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtObsA.Size = New System.Drawing.Size(585, 73)
        Me.TxtObsA.TabIndex = 119
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(192, 112)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(38, 15)
        Me.Label48.TabIndex = 125
        Me.Label48.Text = "Fecha"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(312, 112)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label46.Size = New System.Drawing.Size(32, 15)
        Me.Label46.TabIndex = 124
        Me.Label46.Text = "Hora"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(392, 112)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(46, 15)
        Me.Label44.TabIndex = 123
        Me.Label44.Text = "Minutos"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CmbEstAgenda
        '
        Me.CmbEstAgenda.BackColor = System.Drawing.SystemColors.Window
        Me.CmbEstAgenda.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbEstAgenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstAgenda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbEstAgenda.Items.AddRange(New Object() {"ENTREGA HORARIO", "NO ENTREGA HORARIO", "NO ENTREGA HORARIO - ULTIMO INTENTO"})
        Me.CmbEstAgenda.Location = New System.Drawing.Point(400, 134)
        Me.CmbEstAgenda.Name = "CmbEstAgenda"
        Me.CmbEstAgenda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbEstAgenda.Size = New System.Drawing.Size(209, 21)
        Me.CmbEstAgenda.TabIndex = 115
        '
        'LblAgendar
        '
        Me.LblAgendar.BackColor = System.Drawing.SystemColors.Control
        Me.LblAgendar.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblAgendar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LblAgendar.Location = New System.Drawing.Point(168, 56)
        Me.LblAgendar.Name = "LblAgendar"
        Me.LblAgendar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblAgendar.Size = New System.Drawing.Size(673, 49)
        Me.LblAgendar.TabIndex = 127
        Me.LblAgendar.Text = "Disculpe, ¿Cuál es la mejor hora/día en la que puedo encontrar al Sr.(a) [NOMBRE " &
    "CLIENTE TITULAR]?"
        Me.LblAgendar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(336, 110)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(353, 17)
        Me.Label47.TabIndex = 126
        Me.Label47.Text = "Seleccione una opción sobre este agendamiento."
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Cuerpo_Agenda2
        '
        Me._Cuerpo_Agenda2.Controls.Add(Me.CmdTerminarA2)
        Me._Cuerpo_Agenda2.Controls.Add(Me.Frame2)
        Me._Cuerpo_Agenda2.Controls.Add(Me.Label59)
        Me._Cuerpo_Agenda2.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_Agenda2.Name = "_Cuerpo_Agenda2"
        Me._Cuerpo_Agenda2.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_Agenda2.TabIndex = 10
        Me._Cuerpo_Agenda2.Text = "Agendar 2"
        Me._Cuerpo_Agenda2.UseVisualStyleBackColor = True
        '
        'CmdTerminarA2
        '
        Me.CmdTerminarA2.BackColor = System.Drawing.SystemColors.Control
        Me.CmdTerminarA2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdTerminarA2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTerminarA2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdTerminarA2.Image = CType(resources.GetObject("CmdTerminarA2.Image"), System.Drawing.Image)
        Me.CmdTerminarA2.Location = New System.Drawing.Point(99, 353)
        Me.CmdTerminarA2.Name = "CmdTerminarA2"
        Me.CmdTerminarA2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdTerminarA2.Size = New System.Drawing.Size(73, 41)
        Me.CmdTerminarA2.TabIndex = 111
        Me.CmdTerminarA2.Text = "&Terminar"
        Me.CmdTerminarA2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdTerminarA2.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.DTAgenFecha2)
        Me.Frame2.Controls.Add(Me.CmbHora2)
        Me.Frame2.Controls.Add(Me.CmbMin2)
        Me.Frame2.Controls.Add(Me.TxtObsAgen2)
        Me.Frame2.Controls.Add(Me.Label58)
        Me.Frame2.Controls.Add(Me.Label57)
        Me.Frame2.Controls.Add(Me.Label56)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(184, 110)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(633, 177)
        Me.Frame2.TabIndex = 101
        Me.Frame2.TabStop = False
        '
        'DTAgenFecha2
        '
        Me.DTAgenFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTAgenFecha2.Location = New System.Drawing.Point(192, 131)
        Me.DTAgenFecha2.Name = "DTAgenFecha2"
        Me.DTAgenFecha2.Size = New System.Drawing.Size(91, 21)
        Me.DTAgenFecha2.TabIndex = 127
        '
        'CmbHora2
        '
        Me.CmbHora2.BackColor = System.Drawing.SystemColors.Window
        Me.CmbHora2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbHora2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHora2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbHora2.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22"})
        Me.CmbHora2.Location = New System.Drawing.Point(312, 131)
        Me.CmbHora2.Name = "CmbHora2"
        Me.CmbHora2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbHora2.Size = New System.Drawing.Size(57, 21)
        Me.CmbHora2.TabIndex = 104
        '
        'CmbMin2
        '
        Me.CmbMin2.BackColor = System.Drawing.SystemColors.Window
        Me.CmbMin2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbMin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMin2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbMin2.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50"})
        Me.CmbMin2.Location = New System.Drawing.Point(392, 131)
        Me.CmbMin2.Name = "CmbMin2"
        Me.CmbMin2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbMin2.Size = New System.Drawing.Size(57, 21)
        Me.CmbMin2.TabIndex = 103
        '
        'TxtObsAgen2
        '
        Me.TxtObsAgen2.AcceptsReturn = True
        Me.TxtObsAgen2.BackColor = System.Drawing.SystemColors.Window
        Me.TxtObsAgen2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtObsAgen2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtObsAgen2.Location = New System.Drawing.Point(24, 32)
        Me.TxtObsAgen2.MaxLength = 255
        Me.TxtObsAgen2.Multiline = True
        Me.TxtObsAgen2.Name = "TxtObsAgen2"
        Me.TxtObsAgen2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtObsAgen2.Size = New System.Drawing.Size(585, 73)
        Me.TxtObsAgen2.TabIndex = 102
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label58.ForeColor = System.Drawing.Color.White
        Me.Label58.Location = New System.Drawing.Point(192, 107)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label58.Size = New System.Drawing.Size(38, 15)
        Me.Label58.TabIndex = 108
        Me.Label58.Text = "Fecha"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label57.ForeColor = System.Drawing.Color.White
        Me.Label57.Location = New System.Drawing.Point(312, 107)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(32, 15)
        Me.Label57.TabIndex = 107
        Me.Label57.Text = "Hora"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(392, 107)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(46, 15)
        Me.Label56.TabIndex = 106
        Me.Label56.Text = "Minutos"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.SystemColors.Control
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label59.Location = New System.Drawing.Point(256, 78)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(489, 33)
        Me.Label59.TabIndex = 110
        Me.Label59.Text = "Ingrese Información para agendar un nuevo llamado."
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Cuerpo_FinNC
        '
        Me._Cuerpo_FinNC.Controls.Add(Me.CmdTerminarNC)
        Me._Cuerpo_FinNC.Controls.Add(Me.LblFinNoC)
        Me._Cuerpo_FinNC.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_FinNC.Name = "_Cuerpo_FinNC"
        Me._Cuerpo_FinNC.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_FinNC.TabIndex = 9
        Me._Cuerpo_FinNC.Text = "Fin No Contrata"
        Me._Cuerpo_FinNC.UseVisualStyleBackColor = True
        '
        'CmdTerminarNC
        '
        Me.CmdTerminarNC.BackColor = System.Drawing.SystemColors.Control
        Me.CmdTerminarNC.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdTerminarNC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTerminarNC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdTerminarNC.Image = CType(resources.GetObject("CmdTerminarNC.Image"), System.Drawing.Image)
        Me.CmdTerminarNC.Location = New System.Drawing.Point(99, 354)
        Me.CmdTerminarNC.Name = "CmdTerminarNC"
        Me.CmdTerminarNC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdTerminarNC.Size = New System.Drawing.Size(73, 41)
        Me.CmdTerminarNC.TabIndex = 113
        Me.CmdTerminarNC.Text = "&Terminar"
        Me.CmdTerminarNC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdTerminarNC.UseVisualStyleBackColor = False
        '
        'LblFinNoC
        '
        Me.LblFinNoC.BackColor = System.Drawing.SystemColors.Control
        Me.LblFinNoC.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblFinNoC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinNoC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LblFinNoC.Location = New System.Drawing.Point(152, 96)
        Me.LblFinNoC.Name = "LblFinNoC"
        Me.LblFinNoC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblFinNoC.Size = New System.Drawing.Size(673, 89)
        Me.LblFinNoC.TabIndex = 112
        Me.LblFinNoC.Text = "Sr.(a) XXXXXXXXXXXXXXXXXXXXX , en nombre de XXXX le agradezco su atención."
        '
        '_Cuerpo_Polizas
        '
        Me._Cuerpo_Polizas.Controls.Add(Me.btnTerminarPolizas)
        Me._Cuerpo_Polizas.Controls.Add(Me.btnSiguientePolizas)
        Me._Cuerpo_Polizas.Controls.Add(Me.gpbModificaDatos)
        Me._Cuerpo_Polizas.Controls.Add(Me.cmbModificaDatos)
        Me._Cuerpo_Polizas.Controls.Add(Me.lblModificaDatos)
        Me._Cuerpo_Polizas.Controls.Add(Me.cmbReconoce)
        Me._Cuerpo_Polizas.Controls.Add(Me.Label36)
        Me._Cuerpo_Polizas.Controls.Add(Me.CmbInteresa)
        Me._Cuerpo_Polizas.Controls.Add(Me.lblInteresa)
        Me._Cuerpo_Polizas.Controls.Add(Me.dtgPolizasRegrabacion)
        Me._Cuerpo_Polizas.Location = New System.Drawing.Point(4, 22)
        Me._Cuerpo_Polizas.Name = "_Cuerpo_Polizas"
        Me._Cuerpo_Polizas.Padding = New System.Windows.Forms.Padding(3)
        Me._Cuerpo_Polizas.Size = New System.Drawing.Size(988, 401)
        Me._Cuerpo_Polizas.TabIndex = 19
        Me._Cuerpo_Polizas.Text = "Polizas Regrabacion"
        Me._Cuerpo_Polizas.UseVisualStyleBackColor = True
        '
        'btnTerminarPolizas
        '
        Me.btnTerminarPolizas.BackColor = System.Drawing.SystemColors.Control
        Me.btnTerminarPolizas.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTerminarPolizas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminarPolizas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTerminarPolizas.Image = CType(resources.GetObject("btnTerminarPolizas.Image"), System.Drawing.Image)
        Me.btnTerminarPolizas.Location = New System.Drawing.Point(114, 354)
        Me.btnTerminarPolizas.Name = "btnTerminarPolizas"
        Me.btnTerminarPolizas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnTerminarPolizas.Size = New System.Drawing.Size(73, 41)
        Me.btnTerminarPolizas.TabIndex = 200
        Me.btnTerminarPolizas.Text = "&Terminar"
        Me.btnTerminarPolizas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTerminarPolizas.UseVisualStyleBackColor = False
        '
        'btnSiguientePolizas
        '
        Me.btnSiguientePolizas.BackColor = System.Drawing.SystemColors.Control
        Me.btnSiguientePolizas.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSiguientePolizas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePolizas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSiguientePolizas.Image = CType(resources.GetObject("btnSiguientePolizas.Image"), System.Drawing.Image)
        Me.btnSiguientePolizas.Location = New System.Drawing.Point(99, 354)
        Me.btnSiguientePolizas.Name = "btnSiguientePolizas"
        Me.btnSiguientePolizas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSiguientePolizas.Size = New System.Drawing.Size(73, 41)
        Me.btnSiguientePolizas.TabIndex = 199
        Me.btnSiguientePolizas.Text = "&Siguiente "
        Me.btnSiguientePolizas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSiguientePolizas.UseVisualStyleBackColor = False
        '
        'gpbModificaDatos
        '
        Me.gpbModificaDatos.Controls.Add(Me.lblClickAdicional)
        Me.gpbModificaDatos.Controls.Add(Me.lblMensaje)
        Me.gpbModificaDatos.Controls.Add(Me.btnEliminarPoliza)
        Me.gpbModificaDatos.Controls.Add(Me.btnModificarDatos)
        Me.gpbModificaDatos.Controls.Add(Me.txtDvPoliza)
        Me.gpbModificaDatos.Controls.Add(Me.lblRutPoliza)
        Me.gpbModificaDatos.Controls.Add(Me.txtRutPoliza)
        Me.gpbModificaDatos.Location = New System.Drawing.Point(314, 232)
        Me.gpbModificaDatos.Name = "gpbModificaDatos"
        Me.gpbModificaDatos.Size = New System.Drawing.Size(668, 158)
        Me.gpbModificaDatos.TabIndex = 198
        Me.gpbModificaDatos.TabStop = False
        Me.gpbModificaDatos.Text = "Datos Polizas"
        '
        'lblClickAdicional
        '
        Me.lblClickAdicional.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickAdicional.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblClickAdicional.Location = New System.Drawing.Point(11, 107)
        Me.lblClickAdicional.Name = "lblClickAdicional"
        Me.lblClickAdicional.Size = New System.Drawing.Size(175, 38)
        Me.lblClickAdicional.TabIndex = 6
        Me.lblClickAdicional.Text = "** Debe seleccionar el Titular de la cuenta"
        Me.lblClickAdicional.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(11, 28)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(212, 79)
        Me.lblMensaje.TabIndex = 5
        Me.lblMensaje.Text = "** Para modificar datos, primero debe seleccionar una de las polizas a modificar " &
    "y/o eliminar"
        '
        'btnEliminarPoliza
        '
        Me.btnEliminarPoliza.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPoliza.ForeColor = System.Drawing.Color.Red
        Me.btnEliminarPoliza.Location = New System.Drawing.Point(506, 63)
        Me.btnEliminarPoliza.Name = "btnEliminarPoliza"
        Me.btnEliminarPoliza.Size = New System.Drawing.Size(141, 30)
        Me.btnEliminarPoliza.TabIndex = 4
        Me.btnEliminarPoliza.Text = "Eliminar Poliza"
        Me.btnEliminarPoliza.UseVisualStyleBackColor = True
        Me.btnEliminarPoliza.Visible = False
        '
        'btnModificarDatos
        '
        Me.btnModificarDatos.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDatos.ForeColor = System.Drawing.Color.Blue
        Me.btnModificarDatos.Location = New System.Drawing.Point(506, 20)
        Me.btnModificarDatos.Name = "btnModificarDatos"
        Me.btnModificarDatos.Size = New System.Drawing.Size(141, 32)
        Me.btnModificarDatos.TabIndex = 3
        Me.btnModificarDatos.Text = "Modificar Datos"
        Me.btnModificarDatos.UseVisualStyleBackColor = True
        '
        'txtDvPoliza
        '
        Me.txtDvPoliza.Location = New System.Drawing.Point(459, 31)
        Me.txtDvPoliza.Name = "txtDvPoliza"
        Me.txtDvPoliza.Size = New System.Drawing.Size(17, 21)
        Me.txtDvPoliza.TabIndex = 2
        '
        'lblRutPoliza
        '
        Me.lblRutPoliza.AutoSize = True
        Me.lblRutPoliza.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRutPoliza.Location = New System.Drawing.Point(263, 34)
        Me.lblRutPoliza.Name = "lblRutPoliza"
        Me.lblRutPoliza.Size = New System.Drawing.Size(85, 17)
        Me.lblRutPoliza.TabIndex = 1
        Me.lblRutPoliza.Text = "Rut Poliza"
        '
        'txtRutPoliza
        '
        Me.txtRutPoliza.Location = New System.Drawing.Point(355, 31)
        Me.txtRutPoliza.Name = "txtRutPoliza"
        Me.txtRutPoliza.Size = New System.Drawing.Size(98, 21)
        Me.txtRutPoliza.TabIndex = 0
        '
        'cmbModificaDatos
        '
        Me.cmbModificaDatos.BackColor = System.Drawing.SystemColors.Window
        Me.cmbModificaDatos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbModificaDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModificaDatos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModificaDatos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbModificaDatos.Items.AddRange(New Object() {"[No Especificado]", "Si", "No"})
        Me.cmbModificaDatos.Location = New System.Drawing.Point(143, 248)
        Me.cmbModificaDatos.Name = "cmbModificaDatos"
        Me.cmbModificaDatos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbModificaDatos.Size = New System.Drawing.Size(128, 24)
        Me.cmbModificaDatos.TabIndex = 196
        Me.cmbModificaDatos.Visible = False
        '
        'lblModificaDatos
        '
        Me.lblModificaDatos.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblModificaDatos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblModificaDatos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificaDatos.ForeColor = System.Drawing.Color.Transparent
        Me.lblModificaDatos.Location = New System.Drawing.Point(17, 248)
        Me.lblModificaDatos.Name = "lblModificaDatos"
        Me.lblModificaDatos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblModificaDatos.Size = New System.Drawing.Size(112, 36)
        Me.lblModificaDatos.TabIndex = 197
        Me.lblModificaDatos.Text = "Desea Modificar Datos?"
        Me.lblModificaDatos.Visible = False
        '
        'cmbReconoce
        '
        Me.cmbReconoce.BackColor = System.Drawing.SystemColors.Window
        Me.cmbReconoce.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbReconoce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReconoce.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReconoce.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbReconoce.Items.AddRange(New Object() {"[No Especificado]", "Si", "No"})
        Me.cmbReconoce.Location = New System.Drawing.Point(143, 188)
        Me.cmbReconoce.Name = "cmbReconoce"
        Me.cmbReconoce.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbReconoce.Size = New System.Drawing.Size(128, 24)
        Me.cmbReconoce.TabIndex = 193
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(17, 191)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(112, 20)
        Me.Label36.TabIndex = 195
        Me.Label36.Text = "Reconoce venta?"
        '
        'CmbInteresa
        '
        Me.CmbInteresa.BackColor = System.Drawing.SystemColors.Window
        Me.CmbInteresa.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbInteresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInteresa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbInteresa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbInteresa.Items.AddRange(New Object() {"[No Especificado]", "Interesa", "No Interesa", "Lo Pensara"})
        Me.CmbInteresa.Location = New System.Drawing.Point(482, 187)
        Me.CmbInteresa.Name = "CmbInteresa"
        Me.CmbInteresa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbInteresa.Size = New System.Drawing.Size(172, 24)
        Me.CmbInteresa.TabIndex = 192
        Me.CmbInteresa.Visible = False
        '
        'lblInteresa
        '
        Me.lblInteresa.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lblInteresa.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInteresa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInteresa.Location = New System.Drawing.Point(311, 189)
        Me.lblInteresa.Name = "lblInteresa"
        Me.lblInteresa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInteresa.Size = New System.Drawing.Size(161, 20)
        Me.lblInteresa.TabIndex = 194
        Me.lblInteresa.Text = "¿Desea la Contratacion?"
        Me.lblInteresa.Visible = False
        '
        'dtgPolizasRegrabacion
        '
        Me.dtgPolizasRegrabacion.AllowUserToAddRows = False
        Me.dtgPolizasRegrabacion.AllowUserToDeleteRows = False
        Me.dtgPolizasRegrabacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPolizasRegrabacion.Location = New System.Drawing.Point(9, 6)
        Me.dtgPolizasRegrabacion.Name = "dtgPolizasRegrabacion"
        Me.dtgPolizasRegrabacion.ReadOnly = True
        Me.dtgPolizasRegrabacion.RowHeadersVisible = False
        Me.dtgPolizasRegrabacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPolizasRegrabacion.Size = New System.Drawing.Size(973, 167)
        Me.dtgPolizasRegrabacion.TabIndex = 162
        '
        'tmrEstadoLlamada
        '
        Me.tmrEstadoLlamada.Enabled = True
        Me.tmrEstadoLlamada.Interval = 5000
        '
        'gpbDatosInicio
        '
        Me.gpbDatosInicio.BackColor = System.Drawing.Color.White
        Me.gpbDatosInicio.Controls.Add(Me.lblSegundos)
        Me.gpbDatosInicio.Controls.Add(Me.Label3)
        Me.gpbDatosInicio.Controls.Add(Me.lblMinutos)
        Me.gpbDatosInicio.Controls.Add(Me.lblSeparador1)
        Me.gpbDatosInicio.Controls.Add(Me.lblHora)
        Me.gpbDatosInicio.Controls.Add(Me.lblTiempoPostView)
        Me.gpbDatosInicio.Controls.Add(Me.btnDescanso)
        Me.gpbDatosInicio.Controls.Add(Me.lblRegrabacion)
        Me.gpbDatosInicio.Controls.Add(Me.CmdSalir)
        Me.gpbDatosInicio.Controls.Add(Me.gpbDatosClientes)
        Me.gpbDatosInicio.Controls.Add(Me.fraPadTelefonos)
        Me.gpbDatosInicio.Controls.Add(Me.TxtId)
        Me.gpbDatosInicio.Controls.Add(Me.lblIdCliente)
        Me.gpbDatosInicio.Controls.Add(Me.txtIntentos)
        Me.gpbDatosInicio.Controls.Add(Me.lblIntentos)
        Me.gpbDatosInicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gpbDatosInicio.Location = New System.Drawing.Point(0, 1)
        Me.gpbDatosInicio.Name = "gpbDatosInicio"
        Me.gpbDatosInicio.Padding = New System.Windows.Forms.Padding(0)
        Me.gpbDatosInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gpbDatosInicio.Size = New System.Drawing.Size(996, 233)
        Me.gpbDatosInicio.TabIndex = 0
        Me.gpbDatosInicio.TabStop = False
        '
        'lblSegundos
        '
        Me.lblSegundos.BackColor = System.Drawing.Color.Transparent
        Me.lblSegundos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSegundos.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblSegundos.Location = New System.Drawing.Point(701, 23)
        Me.lblSegundos.Name = "lblSegundos"
        Me.lblSegundos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSegundos.Size = New System.Drawing.Size(25, 20)
        Me.lblSegundos.TabIndex = 226
        Me.lblSegundos.Text = "00"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(689, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = ":"
        '
        'lblMinutos
        '
        Me.lblMinutos.BackColor = System.Drawing.Color.Transparent
        Me.lblMinutos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMinutos.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMinutos.Location = New System.Drawing.Point(670, 23)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMinutos.Size = New System.Drawing.Size(25, 20)
        Me.lblMinutos.TabIndex = 224
        Me.lblMinutos.Text = "00"
        '
        'lblSeparador1
        '
        Me.lblSeparador1.BackColor = System.Drawing.Color.Transparent
        Me.lblSeparador1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeparador1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparador1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblSeparador1.Location = New System.Drawing.Point(661, 23)
        Me.lblSeparador1.Name = "lblSeparador1"
        Me.lblSeparador1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeparador1.Size = New System.Drawing.Size(14, 20)
        Me.lblSeparador1.TabIndex = 223
        Me.lblSeparador1.Text = ":"
        '
        'lblHora
        '
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHora.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblHora.Location = New System.Drawing.Point(650, 23)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHora.Size = New System.Drawing.Size(14, 20)
        Me.lblHora.TabIndex = 202
        Me.lblHora.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTiempoPostView
        '
        Me.lblTiempoPostView.BackColor = System.Drawing.Color.Transparent
        Me.lblTiempoPostView.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTiempoPostView.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoPostView.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTiempoPostView.Location = New System.Drawing.Point(618, 7)
        Me.lblTiempoPostView.Name = "lblTiempoPostView"
        Me.lblTiempoPostView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTiempoPostView.Size = New System.Drawing.Size(156, 20)
        Me.lblTiempoPostView.TabIndex = 201
        Me.lblTiempoPostView.Text = "Tiempo con Cliente:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnDescanso
        '
        Me.btnDescanso.BackColor = System.Drawing.SystemColors.Window
        Me.btnDescanso.Image = CType(resources.GetObject("btnDescanso.Image"), System.Drawing.Image)
        Me.btnDescanso.Location = New System.Drawing.Point(523, 6)
        Me.btnDescanso.Name = "btnDescanso"
        Me.btnDescanso.Size = New System.Drawing.Size(94, 35)
        Me.btnDescanso.TabIndex = 200
        Me.btnDescanso.Text = "Descanso"
        Me.btnDescanso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDescanso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDescanso.UseVisualStyleBackColor = False
        '
        'lblRegrabacion
        '
        Me.lblRegrabacion.AutoSize = True
        Me.lblRegrabacion.BackColor = System.Drawing.Color.Transparent
        Me.lblRegrabacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRegrabacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegrabacion.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRegrabacion.Location = New System.Drawing.Point(775, 13)
        Me.lblRegrabacion.Name = "lblRegrabacion"
        Me.lblRegrabacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRegrabacion.Size = New System.Drawing.Size(151, 22)
        Me.lblRegrabacion.TabIndex = 197
        Me.lblRegrabacion.Text = "REGRABACION"
        '
        'CmdSalir
        '
        Me.CmdSalir.BackColor = System.Drawing.SystemColors.Window
        Me.CmdSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSalir.Image = CType(resources.GetObject("CmdSalir.Image"), System.Drawing.Image)
        Me.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalir.Location = New System.Drawing.Point(926, 8)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSalir.Size = New System.Drawing.Size(67, 35)
        Me.CmdSalir.TabIndex = 196
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSalir.UseVisualStyleBackColor = False
        '
        'gpbDatosClientes
        '
        Me.gpbDatosClientes.Controls.Add(Me.btnTransferir)
        Me.gpbDatosClientes.Controls.Add(Me.txtExtension)
        Me.gpbDatosClientes.Controls.Add(Me.Label24)
        Me.gpbDatosClientes.Controls.Add(Me.txtUsu)
        Me.gpbDatosClientes.Controls.Add(Me.lblIngUsuario)
        Me.gpbDatosClientes.Controls.Add(Me.TxtRut)
        Me.gpbDatosClientes.Controls.Add(Me.dtgCamposAdicionales)
        Me.gpbDatosClientes.Controls.Add(Me.lblRut)
        Me.gpbDatosClientes.Controls.Add(Me.txtNombre)
        Me.gpbDatosClientes.Controls.Add(Me.lblDireccion)
        Me.gpbDatosClientes.Controls.Add(Me.lblNombre)
        Me.gpbDatosClientes.Controls.Add(Me.txtDireccion)
        Me.gpbDatosClientes.Controls.Add(Me.txtObsAgen)
        Me.gpbDatosClientes.Controls.Add(Me.txtFechaNacimiento)
        Me.gpbDatosClientes.Controls.Add(Me.lblObservacionAgenda)
        Me.gpbDatosClientes.Controls.Add(Me.lblFechaNacimiento)
        Me.gpbDatosClientes.Location = New System.Drawing.Point(254, 38)
        Me.gpbDatosClientes.Name = "gpbDatosClientes"
        Me.gpbDatosClientes.Size = New System.Drawing.Size(739, 190)
        Me.gpbDatosClientes.TabIndex = 190
        Me.gpbDatosClientes.TabStop = False
        Me.gpbDatosClientes.Text = "Datos Clientes"
        '
        'txtUsu
        '
        Me.txtUsu.Location = New System.Drawing.Point(167, 103)
        Me.txtUsu.Name = "txtUsu"
        Me.txtUsu.Size = New System.Drawing.Size(100, 20)
        Me.txtUsu.TabIndex = 224
        '
        'lblIngUsuario
        '
        Me.lblIngUsuario.AutoSize = True
        Me.lblIngUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblIngUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIngUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngUsuario.ForeColor = System.Drawing.Color.Navy
        Me.lblIngUsuario.Location = New System.Drawing.Point(7, 104)
        Me.lblIngUsuario.Name = "lblIngUsuario"
        Me.lblIngUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIngUsuario.Size = New System.Drawing.Size(153, 16)
        Me.lblIngUsuario.TabIndex = 223
        Me.lblIngUsuario.Text = "Ingrese Usuario Propio"
        '
        'TxtRut
        '
        Me.TxtRut.AcceptsReturn = True
        Me.TxtRut.BackColor = System.Drawing.SystemColors.Highlight
        Me.TxtRut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtRut.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRut.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TxtRut.Location = New System.Drawing.Point(78, 19)
        Me.TxtRut.MaxLength = 0
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.ReadOnly = True
        Me.TxtRut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtRut.Size = New System.Drawing.Size(113, 16)
        Me.TxtRut.TabIndex = 88
        '
        'dtgCamposAdicionales
        '
        Me.dtgCamposAdicionales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtgCamposAdicionales.Location = New System.Drawing.Point(24, 134)
        Me.dtgCamposAdicionales.Name = "dtgCamposAdicionales"
        Me.dtgCamposAdicionales.ReadOnly = True
        Me.dtgCamposAdicionales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgCamposAdicionales.Size = New System.Drawing.Size(687, 50)
        Me.dtgCamposAdicionales.TabIndex = 222
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.BackColor = System.Drawing.Color.Transparent
        Me.lblRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.ForeColor = System.Drawing.Color.Navy
        Me.lblRut.Location = New System.Drawing.Point(7, 21)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRut.Size = New System.Drawing.Size(29, 16)
        Me.lblRut.TabIndex = 89
        Me.lblRut.Text = "Rut"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtNombre.Location = New System.Drawing.Point(78, 48)
        Me.txtNombre.MaxLength = 0
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(265, 16)
        Me.txtNombre.TabIndex = 25
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.Navy
        Me.lblDireccion.Location = New System.Drawing.Point(7, 78)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDireccion.Size = New System.Drawing.Size(68, 16)
        Me.lblDireccion.TabIndex = 189
        Me.lblDireccion.Text = "Direccion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Navy
        Me.lblNombre.Location = New System.Drawing.Point(7, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtDireccion
        '
        Me.txtDireccion.AcceptsReturn = True
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtDireccion.Location = New System.Drawing.Point(78, 76)
        Me.txtDireccion.MaxLength = 0
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDireccion.Size = New System.Drawing.Size(266, 16)
        Me.txtDireccion.TabIndex = 188
        '
        'txtObsAgen
        '
        Me.txtObsAgen.AcceptsReturn = True
        Me.txtObsAgen.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtObsAgen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObsAgen.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtObsAgen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsAgen.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtObsAgen.Location = New System.Drawing.Point(438, 48)
        Me.txtObsAgen.MaxLength = 0
        Me.txtObsAgen.Multiline = True
        Me.txtObsAgen.Name = "txtObsAgen"
        Me.txtObsAgen.ReadOnly = True
        Me.txtObsAgen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObsAgen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsAgen.Size = New System.Drawing.Size(258, 46)
        Me.txtObsAgen.TabIndex = 26
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.AcceptsReturn = True
        Me.txtFechaNacimiento.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFechaNacimiento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNacimiento.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(438, 19)
        Me.txtFechaNacimiento.MaxLength = 0
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.ReadOnly = True
        Me.txtFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(154, 16)
        Me.txtFechaNacimiento.TabIndex = 172
        '
        'lblObservacionAgenda
        '
        Me.lblObservacionAgenda.AutoSize = True
        Me.lblObservacionAgenda.BackColor = System.Drawing.Color.Transparent
        Me.lblObservacionAgenda.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblObservacionAgenda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacionAgenda.ForeColor = System.Drawing.Color.Navy
        Me.lblObservacionAgenda.Location = New System.Drawing.Point(351, 48)
        Me.lblObservacionAgenda.Name = "lblObservacionAgenda"
        Me.lblObservacionAgenda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblObservacionAgenda.Size = New System.Drawing.Size(81, 16)
        Me.lblObservacionAgenda.TabIndex = 3
        Me.lblObservacionAgenda.Text = "Obs.Agend."
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.Navy
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(351, 16)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(79, 16)
        Me.lblFechaNacimiento.TabIndex = 175
        Me.lblFechaNacimiento.Text = "Fecha Nac."
        '
        'fraPadTelefonos
        '
        Me.fraPadTelefonos.BackColor = System.Drawing.Color.White
        Me.fraPadTelefonos.Controls.Add(Me.txt_FonoVenta)
        Me.fraPadTelefonos.Controls.Add(Me.CmdLlamarVent)
        Me.fraPadTelefonos.Controls.Add(Me.Txt_Fono6)
        Me.fraPadTelefonos.Controls.Add(Me.Txt_Fono5)
        Me.fraPadTelefonos.Controls.Add(Me.Txt_Fono4)
        Me.fraPadTelefonos.Controls.Add(Me.lbLFonoVenta)
        Me.fraPadTelefonos.Controls.Add(Me.chkMute)
        Me.fraPadTelefonos.Controls.Add(Me.txtCallId)
        Me.fraPadTelefonos.Controls.Add(Me.CmdLlamarAlt)
        Me.fraPadTelefonos.Controls.Add(Me.Txt_Fono3)
        Me.fraPadTelefonos.Controls.Add(Me.Txt_Fono2)
        Me.fraPadTelefonos.Controls.Add(Me.Txt_Fono_alt)
        Me.fraPadTelefonos.Controls.Add(Me.Txt_Fono1)
        Me.fraPadTelefonos.Controls.Add(Me.CmdLlamar3)
        Me.fraPadTelefonos.Controls.Add(Me.CmdLlamar2)
        Me.fraPadTelefonos.Controls.Add(Me.CmdLlamar1)
        Me.fraPadTelefonos.Controls.Add(Me.CmdLlamar4)
        Me.fraPadTelefonos.Controls.Add(Me.CmdLlamar5)
        Me.fraPadTelefonos.Controls.Add(Me.CmdLlamar6)
        Me.fraPadTelefonos.Controls.Add(Me.lblFono6)
        Me.fraPadTelefonos.Controls.Add(Me.lblFono5)
        Me.fraPadTelefonos.Controls.Add(Me.Label91)
        Me.fraPadTelefonos.Controls.Add(Me.Label17)
        Me.fraPadTelefonos.Controls.Add(Me.lblFono2)
        Me.fraPadTelefonos.Controls.Add(Me.lblFono3)
        Me.fraPadTelefonos.Controls.Add(Me.lblFono1)
        Me.fraPadTelefonos.Controls.Add(Me.lblFono4)
        Me.fraPadTelefonos.Cursor = System.Windows.Forms.Cursors.Default
        Me.fraPadTelefonos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraPadTelefonos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.fraPadTelefonos.Location = New System.Drawing.Point(4, 9)
        Me.fraPadTelefonos.Name = "fraPadTelefonos"
        Me.fraPadTelefonos.Padding = New System.Windows.Forms.Padding(0)
        Me.fraPadTelefonos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraPadTelefonos.Size = New System.Drawing.Size(241, 201)
        Me.fraPadTelefonos.TabIndex = 6
        Me.fraPadTelefonos.TabStop = False
        Me.fraPadTelefonos.Text = "Discador"
        '
        'txt_FonoVenta
        '
        Me.txt_FonoVenta.AcceptsReturn = True
        Me.txt_FonoVenta.BackColor = System.Drawing.Color.White
        Me.txt_FonoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FonoVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_FonoVenta.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.txt_FonoVenta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_FonoVenta.Location = New System.Drawing.Point(56, 126)
        Me.txt_FonoVenta.MaxLength = 0
        Me.txt_FonoVenta.Name = "txt_FonoVenta"
        Me.txt_FonoVenta.ReadOnly = True
        Me.txt_FonoVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FonoVenta.Size = New System.Drawing.Size(105, 19)
        Me.txt_FonoVenta.TabIndex = 146
        Me.txt_FonoVenta.Visible = False
        '
        'CmdLlamarVent
        '
        Me.CmdLlamarVent.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdLlamarVent.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdLlamarVent.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLlamarVent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLlamarVent.Location = New System.Drawing.Point(161, 127)
        Me.CmdLlamarVent.Name = "CmdLlamarVent"
        Me.CmdLlamarVent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdLlamarVent.Size = New System.Drawing.Size(73, 17)
        Me.CmdLlamarVent.TabIndex = 147
        Me.CmdLlamarVent.Text = "LLAMAR"
        Me.CmdLlamarVent.UseVisualStyleBackColor = False
        Me.CmdLlamarVent.Visible = False
        '
        'Txt_Fono6
        '
        Me.Txt_Fono6.AcceptsReturn = True
        Me.Txt_Fono6.BackColor = System.Drawing.Color.White
        Me.Txt_Fono6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Fono6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Fono6.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Fono6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Fono6.Location = New System.Drawing.Point(56, 108)
        Me.Txt_Fono6.MaxLength = 0
        Me.Txt_Fono6.Name = "Txt_Fono6"
        Me.Txt_Fono6.ReadOnly = True
        Me.Txt_Fono6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Fono6.Size = New System.Drawing.Size(105, 19)
        Me.Txt_Fono6.TabIndex = 139
        '
        'Txt_Fono5
        '
        Me.Txt_Fono5.AcceptsReturn = True
        Me.Txt_Fono5.BackColor = System.Drawing.Color.White
        Me.Txt_Fono5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Fono5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Fono5.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Fono5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Fono5.Location = New System.Drawing.Point(56, 89)
        Me.Txt_Fono5.MaxLength = 0
        Me.Txt_Fono5.Name = "Txt_Fono5"
        Me.Txt_Fono5.ReadOnly = True
        Me.Txt_Fono5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Fono5.Size = New System.Drawing.Size(105, 19)
        Me.Txt_Fono5.TabIndex = 136
        '
        'Txt_Fono4
        '
        Me.Txt_Fono4.AcceptsReturn = True
        Me.Txt_Fono4.BackColor = System.Drawing.Color.White
        Me.Txt_Fono4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Fono4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Fono4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Fono4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Fono4.Location = New System.Drawing.Point(56, 70)
        Me.Txt_Fono4.MaxLength = 0
        Me.Txt_Fono4.Name = "Txt_Fono4"
        Me.Txt_Fono4.ReadOnly = True
        Me.Txt_Fono4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Fono4.Size = New System.Drawing.Size(105, 19)
        Me.Txt_Fono4.TabIndex = 24
        '
        'lbLFonoVenta
        '
        Me.lbLFonoVenta.AutoSize = True
        Me.lbLFonoVenta.BackColor = System.Drawing.Color.Transparent
        Me.lbLFonoVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbLFonoVenta.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbLFonoVenta.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbLFonoVenta.Location = New System.Drawing.Point(8, 129)
        Me.lbLFonoVenta.Name = "lbLFonoVenta"
        Me.lbLFonoVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbLFonoVenta.Size = New System.Drawing.Size(40, 13)
        Me.lbLFonoVenta.TabIndex = 145
        Me.lbLFonoVenta.Text = "Fono V"
        Me.lbLFonoVenta.Visible = False
        '
        'chkMute
        '
        Me.chkMute.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkMute.BackColor = System.Drawing.SystemColors.Control
        Me.chkMute.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.chkMute.Font = New System.Drawing.Font("Tahoma", 6.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMute.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMute.Location = New System.Drawing.Point(8, 202)
        Me.chkMute.Name = "chkMute"
        Me.chkMute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMute.Size = New System.Drawing.Size(225, 17)
        Me.chkMute.TabIndex = 23
        Me.chkMute.Text = "Mute Desactivado"
        Me.chkMute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkMute.UseVisualStyleBackColor = False
        Me.chkMute.Visible = False
        '
        'txtCallId
        '
        Me.txtCallId.AcceptsReturn = True
        Me.txtCallId.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCallId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCallId.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCallId.Enabled = False
        Me.txtCallId.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallId.ForeColor = System.Drawing.Color.White
        Me.txtCallId.Location = New System.Drawing.Point(56, 170)
        Me.txtCallId.MaxLength = 0
        Me.txtCallId.Name = "txtCallId"
        Me.txtCallId.ReadOnly = True
        Me.txtCallId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCallId.Size = New System.Drawing.Size(177, 22)
        Me.txtCallId.TabIndex = 22
        '
        'CmdLlamarAlt
        '
        Me.CmdLlamarAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdLlamarAlt.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdLlamarAlt.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLlamarAlt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLlamarAlt.Location = New System.Drawing.Point(161, 147)
        Me.CmdLlamarAlt.Name = "CmdLlamarAlt"
        Me.CmdLlamarAlt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdLlamarAlt.Size = New System.Drawing.Size(73, 17)
        Me.CmdLlamarAlt.TabIndex = 20
        Me.CmdLlamarAlt.Text = "LLAMAR"
        Me.CmdLlamarAlt.UseVisualStyleBackColor = False
        '
        'Txt_Fono3
        '
        Me.Txt_Fono3.AcceptsReturn = True
        Me.Txt_Fono3.BackColor = System.Drawing.Color.White
        Me.Txt_Fono3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Fono3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Fono3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Fono3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Fono3.Location = New System.Drawing.Point(56, 54)
        Me.Txt_Fono3.MaxLength = 0
        Me.Txt_Fono3.Name = "Txt_Fono3"
        Me.Txt_Fono3.ReadOnly = True
        Me.Txt_Fono3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Fono3.Size = New System.Drawing.Size(105, 19)
        Me.Txt_Fono3.TabIndex = 15
        '
        'Txt_Fono2
        '
        Me.Txt_Fono2.AcceptsReturn = True
        Me.Txt_Fono2.BackColor = System.Drawing.Color.White
        Me.Txt_Fono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Fono2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Fono2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Fono2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Fono2.Location = New System.Drawing.Point(56, 35)
        Me.Txt_Fono2.MaxLength = 0
        Me.Txt_Fono2.Name = "Txt_Fono2"
        Me.Txt_Fono2.ReadOnly = True
        Me.Txt_Fono2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Fono2.Size = New System.Drawing.Size(105, 19)
        Me.Txt_Fono2.TabIndex = 12
        '
        'Txt_Fono_alt
        '
        Me.Txt_Fono_alt.AcceptsReturn = True
        Me.Txt_Fono_alt.BackColor = System.Drawing.Color.White
        Me.Txt_Fono_alt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Fono_alt.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Fono_alt.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Fono_alt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Fono_alt.Location = New System.Drawing.Point(56, 145)
        Me.Txt_Fono_alt.MaxLength = 0
        Me.Txt_Fono_alt.Name = "Txt_Fono_alt"
        Me.Txt_Fono_alt.ReadOnly = True
        Me.Txt_Fono_alt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Fono_alt.Size = New System.Drawing.Size(105, 19)
        Me.Txt_Fono_alt.TabIndex = 19
        '
        'Txt_Fono1
        '
        Me.Txt_Fono1.AcceptsReturn = True
        Me.Txt_Fono1.BackColor = System.Drawing.Color.White
        Me.Txt_Fono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Fono1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Fono1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Fono1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Fono1.Location = New System.Drawing.Point(56, 16)
        Me.Txt_Fono1.MaxLength = 0
        Me.Txt_Fono1.Name = "Txt_Fono1"
        Me.Txt_Fono1.ReadOnly = True
        Me.Txt_Fono1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Fono1.Size = New System.Drawing.Size(105, 19)
        Me.Txt_Fono1.TabIndex = 8
        '
        'CmdLlamar3
        '
        Me.CmdLlamar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdLlamar3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdLlamar3.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLlamar3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLlamar3.Location = New System.Drawing.Point(161, 53)
        Me.CmdLlamar3.Name = "CmdLlamar3"
        Me.CmdLlamar3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdLlamar3.Size = New System.Drawing.Size(73, 17)
        Me.CmdLlamar3.TabIndex = 14
        Me.CmdLlamar3.Text = "LLAMAR"
        Me.CmdLlamar3.UseVisualStyleBackColor = False
        '
        'CmdLlamar2
        '
        Me.CmdLlamar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdLlamar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdLlamar2.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLlamar2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLlamar2.Location = New System.Drawing.Point(161, 35)
        Me.CmdLlamar2.Name = "CmdLlamar2"
        Me.CmdLlamar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdLlamar2.Size = New System.Drawing.Size(73, 17)
        Me.CmdLlamar2.TabIndex = 11
        Me.CmdLlamar2.Text = "LLAMAR"
        Me.CmdLlamar2.UseVisualStyleBackColor = False
        '
        'CmdLlamar1
        '
        Me.CmdLlamar1.BackColor = System.Drawing.Color.LimeGreen
        Me.CmdLlamar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdLlamar1.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLlamar1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLlamar1.Location = New System.Drawing.Point(161, 17)
        Me.CmdLlamar1.Name = "CmdLlamar1"
        Me.CmdLlamar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdLlamar1.Size = New System.Drawing.Size(73, 17)
        Me.CmdLlamar1.TabIndex = 9
        Me.CmdLlamar1.Text = "LLAMAR"
        Me.CmdLlamar1.UseVisualStyleBackColor = False
        '
        'CmdLlamar4
        '
        Me.CmdLlamar4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdLlamar4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdLlamar4.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLlamar4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLlamar4.Location = New System.Drawing.Point(161, 71)
        Me.CmdLlamar4.Name = "CmdLlamar4"
        Me.CmdLlamar4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdLlamar4.Size = New System.Drawing.Size(73, 17)
        Me.CmdLlamar4.TabIndex = 17
        Me.CmdLlamar4.Text = "LLAMAR"
        Me.CmdLlamar4.UseVisualStyleBackColor = False
        '
        'CmdLlamar5
        '
        Me.CmdLlamar5.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdLlamar5.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdLlamar5.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLlamar5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLlamar5.Location = New System.Drawing.Point(161, 89)
        Me.CmdLlamar5.Name = "CmdLlamar5"
        Me.CmdLlamar5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdLlamar5.Size = New System.Drawing.Size(73, 17)
        Me.CmdLlamar5.TabIndex = 137
        Me.CmdLlamar5.Text = "LLAMAR"
        Me.CmdLlamar5.UseVisualStyleBackColor = False
        '
        'CmdLlamar6
        '
        Me.CmdLlamar6.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdLlamar6.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdLlamar6.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLlamar6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmdLlamar6.Location = New System.Drawing.Point(161, 107)
        Me.CmdLlamar6.Name = "CmdLlamar6"
        Me.CmdLlamar6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdLlamar6.Size = New System.Drawing.Size(73, 17)
        Me.CmdLlamar6.TabIndex = 140
        Me.CmdLlamar6.Text = "LLAMAR"
        Me.CmdLlamar6.UseVisualStyleBackColor = False
        '
        'lblFono6
        '
        Me.lblFono6.AutoSize = True
        Me.lblFono6.BackColor = System.Drawing.Color.Transparent
        Me.lblFono6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFono6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFono6.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFono6.Location = New System.Drawing.Point(8, 111)
        Me.lblFono6.Name = "lblFono6"
        Me.lblFono6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFono6.Size = New System.Drawing.Size(40, 13)
        Me.lblFono6.TabIndex = 141
        Me.lblFono6.Text = "Fono 6"
        '
        'lblFono5
        '
        Me.lblFono5.AutoSize = True
        Me.lblFono5.BackColor = System.Drawing.Color.Transparent
        Me.lblFono5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFono5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFono5.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFono5.Location = New System.Drawing.Point(8, 93)
        Me.lblFono5.Name = "lblFono5"
        Me.lblFono5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFono5.Size = New System.Drawing.Size(40, 13)
        Me.lblFono5.TabIndex = 138
        Me.lblFono5.Text = "Fono 5"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label91.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label91.Location = New System.Drawing.Point(9, 170)
        Me.Label91.Name = "Label91"
        Me.Label91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label91.Size = New System.Drawing.Size(49, 16)
        Me.Label91.TabIndex = 21
        Me.Label91.Text = "Call-Id"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label17.Location = New System.Drawing.Point(8, 148)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Fono A"
        '
        'lblFono2
        '
        Me.lblFono2.AutoSize = True
        Me.lblFono2.BackColor = System.Drawing.Color.Transparent
        Me.lblFono2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFono2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFono2.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFono2.Location = New System.Drawing.Point(8, 38)
        Me.lblFono2.Name = "lblFono2"
        Me.lblFono2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFono2.Size = New System.Drawing.Size(40, 13)
        Me.lblFono2.TabIndex = 10
        Me.lblFono2.Text = "Fono 2"
        '
        'lblFono3
        '
        Me.lblFono3.AutoSize = True
        Me.lblFono3.BackColor = System.Drawing.Color.Transparent
        Me.lblFono3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFono3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFono3.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFono3.Location = New System.Drawing.Point(8, 56)
        Me.lblFono3.Name = "lblFono3"
        Me.lblFono3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFono3.Size = New System.Drawing.Size(40, 13)
        Me.lblFono3.TabIndex = 13
        Me.lblFono3.Text = "Fono 3"
        '
        'lblFono1
        '
        Me.lblFono1.AutoSize = True
        Me.lblFono1.BackColor = System.Drawing.Color.Transparent
        Me.lblFono1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFono1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFono1.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFono1.Location = New System.Drawing.Point(8, 20)
        Me.lblFono1.Name = "lblFono1"
        Me.lblFono1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFono1.Size = New System.Drawing.Size(38, 13)
        Me.lblFono1.TabIndex = 7
        Me.lblFono1.Text = "Fono 1"
        '
        'lblFono4
        '
        Me.lblFono4.AutoSize = True
        Me.lblFono4.BackColor = System.Drawing.Color.Transparent
        Me.lblFono4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFono4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFono4.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFono4.Location = New System.Drawing.Point(8, 74)
        Me.lblFono4.Name = "lblFono4"
        Me.lblFono4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFono4.Size = New System.Drawing.Size(40, 13)
        Me.lblFono4.TabIndex = 16
        Me.lblFono4.Text = "Fono 4"
        '
        'TxtId
        '
        Me.TxtId.AcceptsReturn = True
        Me.TxtId.BackColor = System.Drawing.Color.White
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtId.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtId.Location = New System.Drawing.Point(327, 9)
        Me.TxtId.MaxLength = 0
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtId.Size = New System.Drawing.Size(87, 23)
        Me.TxtId.TabIndex = 30
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblIdCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIdCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblIdCliente.Location = New System.Drawing.Point(251, 11)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIdCliente.Size = New System.Drawing.Size(70, 16)
        Me.lblIdCliente.TabIndex = 31
        Me.lblIdCliente.Text = "ID Cliente"
        '
        'txtIntentos
        '
        Me.txtIntentos.AcceptsReturn = True
        Me.txtIntentos.BackColor = System.Drawing.Color.White
        Me.txtIntentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntentos.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtIntentos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntentos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIntentos.Location = New System.Drawing.Point(486, 9)
        Me.txtIntentos.MaxLength = 0
        Me.txtIntentos.Name = "txtIntentos"
        Me.txtIntentos.ReadOnly = True
        Me.txtIntentos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIntentos.Size = New System.Drawing.Size(33, 23)
        Me.txtIntentos.TabIndex = 132
        '
        'lblIntentos
        '
        Me.lblIntentos.AutoSize = True
        Me.lblIntentos.BackColor = System.Drawing.Color.Transparent
        Me.lblIntentos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIntentos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntentos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblIntentos.Location = New System.Drawing.Point(418, 11)
        Me.lblIntentos.Name = "lblIntentos"
        Me.lblIntentos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIntentos.Size = New System.Drawing.Size(62, 16)
        Me.lblIntentos.TabIndex = 135
        Me.lblIntentos.Text = "Intentos "
        '
        'tmLabelRegrabacion
        '
        Me.tmLabelRegrabacion.Interval = 1000
        '
        'tmrPostview
        '
        Me.tmrPostview.Interval = 1000
        '
        'CmdAtras
        '
        Me.CmdAtras.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAtras.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAtras.Enabled = False
        Me.CmdAtras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAtras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAtras.Image = CType(resources.GetObject("CmdAtras.Image"), System.Drawing.Image)
        Me.CmdAtras.Location = New System.Drawing.Point(24, 611)
        Me.CmdAtras.Name = "CmdAtras"
        Me.CmdAtras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAtras.Size = New System.Drawing.Size(73, 40)
        Me.CmdAtras.TabIndex = 37
        Me.CmdAtras.Text = " Atras"
        Me.CmdAtras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdAtras.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewImageColumn1.HeaderText = "Llamar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.Width = 60
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(281, 105)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(175, 16)
        Me.Label24.TabIndex = 225
        Me.Label24.Text = "Ingrese Posicion ejecutivo"
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(462, 104)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(100, 20)
        Me.txtExtension.TabIndex = 226
        '
        'btnTransferir
        '
        Me.btnTransferir.Location = New System.Drawing.Point(578, 102)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(104, 23)
        Me.btnTransferir.TabIndex = 227
        Me.btnTransferir.Text = "Transferir Llamada"
        Me.btnTransferir.UseVisualStyleBackColor = True
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(995, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdAtras)
        Me.Controls.Add(Me.gpbDatosInicio)
        Me.Controls.Add(Me.Cuerpo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(58, 59)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenta"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Cuerpo.ResumeLayout(False)
        Me._Cuerpo_IngresoCli.ResumeLayout(False)
        Me.gpbCotizacion.ResumeLayout(False)
        Me.gpbCotizacion.PerformLayout()
        CType(Me.dtCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me._Cuerpo_Conex.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.FrmConex.ResumeLayout(False)
        Me._Cuerpo_MtvoLL.ResumeLayout(False)
        Me._Cuerpo_DatosCli.ResumeLayout(False)
        Me.frmServicio.ResumeLayout(False)
        Me.frmServicio.PerformLayout()
        Me.gpbPagador.ResumeLayout(False)
        Me.gpbPagador.PerformLayout()
        Me._Cuerpo_MPago.ResumeLayout(False)
        Me._Cuerpo_MPago.PerformLayout()
        Me._Cuerpo_InfAdic.ResumeLayout(False)
        Me._Cuerpo_Certifica.ResumeLayout(False)
        Me._Cuerpo_UltInfo.ResumeLayout(False)
        Me._Cuerpo_UltInfo.PerformLayout()
        CType(Me.dtgPolizasPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelotro.ResumeLayout(False)
        Me.Panelotro.PerformLayout()
        CType(Me.dtgPolizasVigentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me._Cuerpo_Adicionales.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        Me._Cuerpo_Objeciones.ResumeLayout(False)
        Me.FrmObj.ResumeLayout(False)
        Me.FrmObj.PerformLayout()
        Me._Cuerpo_Agendar.ResumeLayout(False)
        Me.FrmAgendamiento.ResumeLayout(False)
        Me.FrmAgendamiento.PerformLayout()
        Me._Cuerpo_Agenda2.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me._Cuerpo_FinNC.ResumeLayout(False)
        Me._Cuerpo_Polizas.ResumeLayout(False)
        Me.gpbModificaDatos.ResumeLayout(False)
        Me.gpbModificaDatos.PerformLayout()
        CType(Me.dtgPolizasRegrabacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDatosInicio.ResumeLayout(False)
        Me.gpbDatosInicio.PerformLayout()
        Me.gpbDatosClientes.ResumeLayout(False)
        Me.gpbDatosClientes.PerformLayout()
        CType(Me.dtgCamposAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraPadTelefonos.ResumeLayout(False)
        Me.fraPadTelefonos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmServicio As System.Windows.Forms.GroupBox
    Public WithEvents lblDatosCli As System.Windows.Forms.Label
    Friend WithEvents DTAgenFecha2 As System.Windows.Forms.DateTimePicker
    Public WithEvents txtDireccion As System.Windows.Forms.TextBox
    Public WithEvents lblDireccion As System.Windows.Forms.Label
    Public WithEvents CmdSalir As System.Windows.Forms.Button
    Public WithEvents CmdSiguiente As System.Windows.Forms.Button
    Public WithEvents CmdSiguiente2 As System.Windows.Forms.Button
    Public WithEvents CmdSiguiente11 As System.Windows.Forms.Button
    Public WithEvents CmdSiguienteA As System.Windows.Forms.Button
    Public WithEvents CmdTerminarA As System.Windows.Forms.Button
    Public WithEvents CmdTerminarNC As System.Windows.Forms.Button
    Public WithEvents CmdTerminarA2 As System.Windows.Forms.Button
    Public WithEvents _Cuerpo_MtvoLL As System.Windows.Forms.TabPage
    Public WithEvents CmdSiguiente1 As System.Windows.Forms.Button
    Friend WithEvents _Cuerpo_Adicionales As System.Windows.Forms.TabPage
    Public WithEvents btnAdicionalSgt As System.Windows.Forms.Button
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents txtDvV As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents txtRutV As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents txtMaternoV As System.Windows.Forms.TextBox
    Public WithEvents txtPaternoV As System.Windows.Forms.TextBox
    Public WithEvents txtNombreV As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtReferenciaV As System.Windows.Forms.TextBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents txtNroV As System.Windows.Forms.TextBox
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents txtCalleV As System.Windows.Forms.TextBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents txtEmail As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Public WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents _Cuerpo_Certifica As System.Windows.Forms.TabPage
    Public WithEvents cmbAceptaPrima As System.Windows.Forms.ComboBox
    Public WithEvents lblCargoTarjeta As System.Windows.Forms.Label
    Public WithEvents cmbAceptaContrato As System.Windows.Forms.ComboBox
    Public WithEvents lblAcepta As System.Windows.Forms.Label
    Friend WithEvents dtFechaNacV As System.Windows.Forms.DateTimePicker
    Public WithEvents cmdSiguienteFin As System.Windows.Forms.Button
    Friend WithEvents _Cuerpo_InfAdic As System.Windows.Forms.TabPage
    Friend WithEvents cmbComuna As System.Windows.Forms.ComboBox
    Friend WithEvents _Cuerpo_IngresoCli As System.Windows.Forms.TabPage
    Friend WithEvents _Cuerpo_TabBenef As System.Windows.Forms.TabPage
    Public WithEvents CmbNoConecta As System.Windows.Forms.ComboBox
    Public WithEvents CmbConecta As System.Windows.Forms.ComboBox
    Public WithEvents CmbComunicaCon As System.Windows.Forms.ComboBox
    Public WithEvents CmbComunicaTercero As System.Windows.Forms.ComboBox
    Friend WithEvents _Cuerpo_MPago As System.Windows.Forms.TabPage
    Public WithEvents CmdAtras As System.Windows.Forms.Button
    Public WithEvents lblTomaDireccion As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents cmbNoIntereso As System.Windows.Forms.ComboBox
    Public WithEvents txtFonoVenta As System.Windows.Forms.TextBox
    Public WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents wbScriptPresentacion As System.Windows.Forms.WebBrowser
    Friend WithEvents wbScriptCertificacion As System.Windows.Forms.WebBrowser
    Public WithEvents txtCalculaEdad As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblPrimaPesos As System.Windows.Forms.Label
    Public WithEvents lblPrimaUF As System.Windows.Forms.Label
    Public WithEvents lblTextPrimaPesos As System.Windows.Forms.Label
    Public WithEvents lblTextPrimaUF As System.Windows.Forms.Label
    Friend WithEvents btnAdicional As System.Windows.Forms.Button
    Friend WithEvents btnBeneficiarios As System.Windows.Forms.Button
    Public WithEvents Label82 As System.Windows.Forms.Label
    Public WithEvents CmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents _Cuerpo_UltInfo As System.Windows.Forms.TabPage
    Public WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents WebInfAdicional As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowsercierre As System.Windows.Forms.WebBrowser
    Friend WithEvents dtgCamposAdicionales As System.Windows.Forms.DataGridView
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents lblSexoA As System.Windows.Forms.Label
    Public WithEvents cmbSexoA As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaNacAdic As System.Windows.Forms.DateTimePicker
    Public WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Parentesco As System.Windows.Forms.Label
    Public WithEvents cmbParentescoAdic As System.Windows.Forms.ComboBox
    Public WithEvents txtDvA As System.Windows.Forms.TextBox
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents txtRutA As System.Windows.Forms.TextBox
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents txtMaternoA As System.Windows.Forms.TextBox
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents txtPaternoA As System.Windows.Forms.TextBox
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents txtNombreA As System.Windows.Forms.TextBox
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents txt_FonoVenta As System.Windows.Forms.TextBox
    Public WithEvents CmdLlamarVent As System.Windows.Forms.Button
    Public WithEvents lbLFonoVenta As System.Windows.Forms.Label
    Friend WithEvents wbScriptBienvenida As System.Windows.Forms.WebBrowser
    Friend WithEvents gpbDatosClientes As GroupBox
    Friend WithEvents btnExclusiones As Button
    Public WithEvents lblRegrabacion As Label
    Friend WithEvents tmLabelRegrabacion As Timer
    Friend WithEvents btnDescanso As Button
    Public WithEvents lblTiempoPostView As Label
    Friend WithEvents tmrPostview As Timer
    Public WithEvents lblSegundos As Label
    Public WithEvents Label3 As Label
    Public WithEvents lblMinutos As Label
    Public WithEvents lblSeparador1 As Label
    Public WithEvents lblHora As Label
    Friend WithEvents gpbCotizacion As GroupBox
    Friend WithEvents dtCotizaciones As DataGridView
    Friend WithEvents btnGuardarCotizacion As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblNombrePlan As Label
    Friend WithEvents lblPrimaUfCotiza As Label
    Friend WithEvents lblPrimaPesosCotiza As Label
    Friend WithEvents lblIdPlan As Label
    Friend WithEvents dtFechaNacimientoCotiza As DateTimePicker
    Public WithEvents Label55 As Label
    Public WithEvents Label60 As Label
    Friend WithEvents btnCotizar As Button
    Public WithEvents cmbPlanCotiza As ComboBox
    Friend WithEvents btnAdicionales As Button
    Public WithEvents Label61 As Label
    Public WithEvents cmbTipoContratoCotiza As ComboBox
    Public WithEvents cmdSiguientePoliza As Button
    Friend WithEvents dtAdicional As DataGridView
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents paterno As DataGridViewTextBoxColumn
    Friend WithEvents materno As DataGridViewTextBoxColumn
    Friend WithEvents rut As DataGridViewTextBoxColumn
    Friend WithEvents dv As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents tipo_parentesco As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents idParentescoAdi As DataGridViewTextBoxColumn
    Friend WithEvents Isapre As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Estatura As DataGridViewTextBoxColumn
    Friend WithEvents DPS As DataGridViewTextBoxColumn
    Public WithEvents txtDatosDPS As TextBox
    Public WithEvents lblObservaciones As Label
    Friend WithEvents mskEstatura As MaskedTextBox
    Public WithEvents lblEstatura As Label
    Public WithEvents txtPeso As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents cmbIsapre As ComboBox
    Public WithEvents lblIsapre As Label
    Friend WithEvents rdbNoPagador As RadioButton
    Friend WithEvents rdbSiPagador As RadioButton
    Friend WithEvents gpbPagador As GroupBox
    Public WithEvents txtDvPagador As TextBox
    Public WithEvents Label65 As Label
    Public WithEvents Label64 As Label
    Public WithEvents txtNombrePagador As TextBox
    Public WithEvents Label63 As Label
    Public WithEvents txtRutPagador As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents cmbIsapreCliente As ComboBox
    Friend WithEvents mskEstaturaCliente As MaskedTextBox
    Public WithEvents Label4 As Label
    Public WithEvents txtPesoCliente As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents txtDPSCliente As TextBox
    Public WithEvents lblDPS As Label
    Friend WithEvents dtgPolizasVigentes As DataGridView
    Friend WithEvents lblNuevaPoliza As Label
    Friend WithEvents cmbNuevaPoliza As ComboBox
    Public WithEvents btnSiguientePoliza As Button
    Friend WithEvents chkCotizacion As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
    Friend WithEvents plan As DataGridViewTextBoxColumn
    Friend WithEvents primaUf As DataGridViewTextBoxColumn
    Friend WithEvents primaPesos As DataGridViewTextBoxColumn
    Friend WithEvents tipoContratoPlan As DataGridViewTextBoxColumn
    Friend WithEvents IdPlan As DataGridViewTextBoxColumn
    Friend WithEvents IDTipoContrato As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoCot As DataGridViewTextBoxColumn
    Public WithEvents Label8 As Label
    Friend WithEvents Label90 As Label
    Public WithEvents CmdFinVentaMP As Button
    Public WithEvents cmdFinVenta As Button
    Friend WithEvents lblIngresoMP As Label
    Friend WithEvents cmbIngresaMedioPago As ComboBox
    Friend WithEvents lblIngresoMedioPago As Label
    Friend WithEvents Panelotro As Panel
    Friend WithEvents cmbTpoTarjeta As ComboBox
    Public WithEvents lblTipoTarjeta As Label
    Public WithEvents CmbBanco As ComboBox
    Public WithEvents txtNumeroCuenta As TextBox
    Public WithEvents lblNumeroCuenta As Label
    Public WithEvents lblBanco As Label
    Public WithEvents cmbMedioPago As ComboBox
    Public WithEvents lblMedioPago As Label
    Friend WithEvents lblPolizasPago As Label
    Friend WithEvents btnGuardarPago As Button
    Friend WithEvents dtgPolizasPago As DataGridView
    Friend WithEvents seleccione As DataGridViewCheckBoxColumn
    Friend WithEvents idPoliza As DataGridViewTextBoxColumn
    Friend WithEvents llave As DataGridViewTextBoxColumn
    Friend WithEvents uf As DataGridViewTextBoxColumn
    Friend WithEvents tipoPlan As DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaMandato As DateTimePicker
    Public WithEvents cmbHoraMandato As ComboBox
    Public WithEvents lblFechaMandato As Label
    Public WithEvents lblHoraMandato As Label
    Friend WithEvents DTFechaAgen As DateTimePicker
    Public WithEvents cmbHora As ComboBox
    Public WithEvents Label48 As Label
    Public WithEvents Label46 As Label
    Public WithEvents cmbInteresaFinal As ComboBox
    Public WithEvents Label19 As Label
    Public WithEvents btnAvanzarSinIngresar As Button
    Friend WithEvents _Cuerpo_Polizas As TabPage
    Friend WithEvents dtgPolizasRegrabacion As DataGridView
    Public WithEvents cmbModificaDatos As ComboBox
    Public WithEvents lblModificaDatos As Label
    Public WithEvents cmbReconoce As ComboBox
    Public WithEvents Label36 As Label
    Public WithEvents CmbInteresa As ComboBox
    Public WithEvents lblInteresa As Label
    Friend WithEvents gpbModificaDatos As GroupBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnEliminarPoliza As Button
    Friend WithEvents btnModificarDatos As Button
    Friend WithEvents txtDvPoliza As TextBox
    Friend WithEvents lblRutPoliza As Label
    Friend WithEvents txtRutPoliza As TextBox
    Public WithEvents btnTerminarPolizas As Button
    Public WithEvents btnSiguientePolizas As Button
    Friend WithEvents lblClickAdicional As Label
    Friend WithEvents btnEliminarPolizaVenta As Button
    Friend WithEvents btnCalcularIMC As Button
    Public WithEvents lblIMC As Label
    Friend WithEvents cmbGiftCard As ComboBox
    Friend WithEvents chkGiftcard As CheckBox
    Friend WithEvents lblIMCAdicional As Label
    Friend WithEvents btnIMCAdicional As Button
    Friend WithEvents txtUsu As TextBox
    Public WithEvents lblIngUsuario As Label
    Friend WithEvents btnTransferir As Button
    Friend WithEvents txtExtension As TextBox
    Public WithEvents Label24 As Label
#End Region
End Class