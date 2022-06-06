<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPolizasAEliminar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtgPolizasAEliminar = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.chkSeleccione = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primaUf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primaPesos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgPolizasAEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgPolizasAEliminar
        '
        Me.dtgPolizasAEliminar.AllowUserToAddRows = False
        Me.dtgPolizasAEliminar.AllowUserToDeleteRows = False
        Me.dtgPolizasAEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPolizasAEliminar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSeleccione, Me.id, Me.nombre, Me.paterno, Me.materno, Me.rut, Me.dv, Me.fechaNacimiento, Me.primaUf, Me.primaPesos, Me.idPoliza})
        Me.dtgPolizasAEliminar.Location = New System.Drawing.Point(12, 47)
        Me.dtgPolizasAEliminar.Name = "dtgPolizasAEliminar"
        Me.dtgPolizasAEliminar.ReadOnly = True
        Me.dtgPolizasAEliminar.RowHeadersVisible = False
        Me.dtgPolizasAEliminar.Size = New System.Drawing.Size(973, 157)
        Me.dtgPolizasAEliminar.TabIndex = 162
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Red
        Me.btnEliminar.Location = New System.Drawing.Point(422, 225)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(167, 42)
        Me.btnEliminar.TabIndex = 163
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(908, 278)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(77, 35)
        Me.btnVolver.TabIndex = 164
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'chkSeleccione
        '
        Me.chkSeleccione.HeaderText = "Seleccione"
        Me.chkSeleccione.Name = "chkSeleccione"
        Me.chkSeleccione.ReadOnly = True
        Me.chkSeleccione.Width = 70
        '
        'id
        '
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "NOMBRE"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'paterno
        '
        Me.paterno.DataPropertyName = "PATERNO"
        Me.paterno.HeaderText = "Paterno"
        Me.paterno.Name = "paterno"
        Me.paterno.ReadOnly = True
        '
        'materno
        '
        Me.materno.DataPropertyName = "MATERNO"
        Me.materno.HeaderText = "Materno"
        Me.materno.Name = "materno"
        Me.materno.ReadOnly = True
        '
        'rut
        '
        Me.rut.DataPropertyName = "RUT"
        Me.rut.HeaderText = "Rut"
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        '
        'dv
        '
        Me.dv.DataPropertyName = "DV"
        Me.dv.HeaderText = "Dv"
        Me.dv.Name = "dv"
        Me.dv.ReadOnly = True
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.DataPropertyName = "FECHA_NACIMIENTO"
        Me.fechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.ReadOnly = True
        '
        'primaUf
        '
        Me.primaUf.DataPropertyName = "PRIMAUF"
        Me.primaUf.HeaderText = "Prima Uf"
        Me.primaUf.Name = "primaUf"
        Me.primaUf.ReadOnly = True
        '
        'primaPesos
        '
        Me.primaPesos.DataPropertyName = "PRIMAPESOS"
        Me.primaPesos.HeaderText = "Prima Pesos"
        Me.primaPesos.Name = "primaPesos"
        Me.primaPesos.ReadOnly = True
        '
        'idPoliza
        '
        Me.idPoliza.DataPropertyName = "IDPOLIZA"
        Me.idPoliza.HeaderText = "ID POLIZA"
        Me.idPoliza.Name = "idPoliza"
        Me.idPoliza.ReadOnly = True
        Me.idPoliza.Visible = False
        '
        'frmPolizasAEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dtgPolizasAEliminar)
        Me.Name = "frmPolizasAEliminar"
        Me.Text = "Polizas A Eliminar"
        CType(Me.dtgPolizasAEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgPolizasAEliminar As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents chkSeleccione As DataGridViewCheckBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents paterno As DataGridViewTextBoxColumn
    Friend WithEvents materno As DataGridViewTextBoxColumn
    Friend WithEvents rut As DataGridViewTextBoxColumn
    Friend WithEvents dv As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents primaUf As DataGridViewTextBoxColumn
    Friend WithEvents primaPesos As DataGridViewTextBoxColumn
    Friend WithEvents idPoliza As DataGridViewTextBoxColumn
End Class
