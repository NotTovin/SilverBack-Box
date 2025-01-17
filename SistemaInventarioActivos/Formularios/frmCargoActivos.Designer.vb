<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargoActivos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargoActivos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbNombreA = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvCargoActivos = New System.Windows.Forms.DataGridView()
        Me.lblTotalA = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.cbEstadoActivo = New System.Windows.Forms.ComboBox()
        Me.txtCodigoInventario = New System.Windows.Forms.TextBox()
        Me.btnIdentidad = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnCodigo = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNumeroIdentidad = New System.Windows.Forms.TextBox()
        Me.txtNombreArticulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCargoActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbEmpleado)
        Me.Panel1.Controls.Add(Me.rbCodigo)
        Me.Panel1.Controls.Add(Me.rbNombreA)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvCargoActivos)
        Me.Panel1.Controls.Add(Me.lblTotalA)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(150, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 423)
        Me.Panel1.TabIndex = 79
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDepartamento.ForeColor = System.Drawing.Color.White
        Me.rbDepartamento.Location = New System.Drawing.Point(367, 10)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(133, 22)
        Me.rbDepartamento.TabIndex = 88
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEmpleado.ForeColor = System.Drawing.Color.White
        Me.rbEmpleado.Location = New System.Drawing.Point(262, 11)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(102, 22)
        Me.rbEmpleado.TabIndex = 87
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.ForeColor = System.Drawing.Color.White
        Me.rbCodigo.Location = New System.Drawing.Point(182, 10)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(82, 22)
        Me.rbCodigo.TabIndex = 86
        Me.rbCodigo.Text = "Código"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'rbNombreA
        '
        Me.rbNombreA.AutoSize = True
        Me.rbNombreA.BackColor = System.Drawing.Color.Transparent
        Me.rbNombreA.Checked = True
        Me.rbNombreA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreA.ForeColor = System.Drawing.Color.White
        Me.rbNombreA.Location = New System.Drawing.Point(95, 11)
        Me.rbNombreA.Name = "rbNombreA"
        Me.rbNombreA.Size = New System.Drawing.Size(86, 22)
        Me.rbNombreA.TabIndex = 85
        Me.rbNombreA.TabStop = True
        Me.rbNombreA.Text = "Nombre"
        Me.rbNombreA.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(506, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(486, 19)
        Me.txtBuscar.TabIndex = 84
        '
        'dgvCargoActivos
        '
        Me.dgvCargoActivos.AllowUserToAddRows = False
        Me.dgvCargoActivos.AllowUserToDeleteRows = False
        Me.dgvCargoActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargoActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargo, Me.CodigoInventario, Me.NombreA, Me.PrecioCompra, Me.Nombre, Me.Identidad, Me.NombreD, Me.FechaAsignacion, Me.EstadoArticulo, Me.Descripcion, Me.IdArticulo, Me.IdEmpleado})
        Me.dgvCargoActivos.Location = New System.Drawing.Point(0, 33)
        Me.dgvCargoActivos.Name = "dgvCargoActivos"
        Me.dgvCargoActivos.ReadOnly = True
        Me.dgvCargoActivos.RowHeadersVisible = False
        Me.dgvCargoActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCargoActivos.Size = New System.Drawing.Size(1000, 368)
        Me.dgvCargoActivos.TabIndex = 23
        '
        'lblTotalA
        '
        Me.lblTotalA.AutoSize = True
        Me.lblTotalA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalA.ForeColor = System.Drawing.Color.White
        Me.lblTotalA.Location = New System.Drawing.Point(981, 404)
        Me.lblTotalA.Name = "lblTotalA"
        Me.lblTotalA.Size = New System.Drawing.Size(16, 19)
        Me.lblTotalA.TabIndex = 22
        Me.lblTotalA.Text = "T"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(810, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Articulos registrados:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Buscar por:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(1192, 356)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(27, 20)
        Me.txtId.TabIndex = 137
        Me.txtId.Visible = False
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(1192, 284)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(27, 20)
        Me.txtIdArticulo.TabIndex = 136
        Me.txtIdArticulo.Visible = False
        '
        'cbEstadoActivo
        '
        Me.cbEstadoActivo.FormattingEnabled = True
        Me.cbEstadoActivo.Items.AddRange(New Object() {"Nuevo", "Usado"})
        Me.cbEstadoActivo.Location = New System.Drawing.Point(855, 118)
        Me.cbEstadoActivo.Name = "cbEstadoActivo"
        Me.cbEstadoActivo.Size = New System.Drawing.Size(137, 24)
        Me.cbEstadoActivo.TabIndex = 135
        '
        'txtCodigoInventario
        '
        Me.txtCodigoInventario.Location = New System.Drawing.Point(140, 118)
        Me.txtCodigoInventario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoInventario.Name = "txtCodigoInventario"
        Me.txtCodigoInventario.Size = New System.Drawing.Size(161, 23)
        Me.txtCodigoInventario.TabIndex = 134
        '
        'btnIdentidad
        '
        Me.btnIdentidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIdentidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIdentidad.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIdentidad.ForeColor = System.Drawing.Color.White
        Me.btnIdentidad.Location = New System.Drawing.Point(267, 70)
        Me.btnIdentidad.Name = "btnIdentidad"
        Me.btnIdentidad.Size = New System.Drawing.Size(31, 23)
        Me.btnIdentidad.TabIndex = 133
        Me.btnIdentidad.Text = "..."
        Me.btnIdentidad.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(27, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 19)
        Me.Label16.TabIndex = 132
        Me.Label16.Text = "N° identidad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(48, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 19)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "inventario"
        '
        'btnCodigo
        '
        Me.btnCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCodigo.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCodigo.ForeColor = System.Drawing.Color.White
        Me.btnCodigo.Location = New System.Drawing.Point(267, 34)
        Me.btnCodigo.Name = "btnCodigo"
        Me.btnCodigo.Size = New System.Drawing.Size(31, 23)
        Me.btnCodigo.TabIndex = 130
        Me.btnCodigo.Text = "..."
        Me.btnCodigo.UseVisualStyleBackColor = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(855, 34)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(137, 23)
        Me.txtPrecio.TabIndex = 129
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(757, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(92, 38)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "Estado del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "activo"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(855, 69)
        Me.txtDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(137, 23)
        Me.txtDepartamento.TabIndex = 127
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(727, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 19)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Departamento"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(504, 70)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.ReadOnly = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(198, 23)
        Me.txtNombreEmpleado.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(338, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(160, 19)
        Me.Label12.TabIndex = 124
        Me.Label12.Text = "Nombre empleado"
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(504, 118)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(198, 23)
        Me.dtpFechaEntrega.TabIndex = 123
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(350, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 19)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Fecha de entrega"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(792, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Precio"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 167)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(852, 35)
        Me.txtDescripcion.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 19)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(67, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Código"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(67, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 19)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(363, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Nombre articulo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(140, 34)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(124, 23)
        Me.txtCodigo.TabIndex = 108
        '
        'txtNumeroIdentidad
        '
        Me.txtNumeroIdentidad.Location = New System.Drawing.Point(140, 70)
        Me.txtNumeroIdentidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumeroIdentidad.Name = "txtNumeroIdentidad"
        Me.txtNumeroIdentidad.Size = New System.Drawing.Size(124, 23)
        Me.txtNumeroIdentidad.TabIndex = 109
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(504, 35)
        Me.txtNombreArticulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.ReadOnly = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(198, 23)
        Me.txtNombreArticulo.TabIndex = 107
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombreEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtNombreArticulo)
        Me.GroupBox1.Controls.Add(Me.txtNumeroIdentidad)
        Me.GroupBox1.Controls.Add(Me.cbEstadoActivo)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.txtCodigoInventario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCodigo)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEntrega)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(150, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 223)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del inventario"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(1192, 319)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(27, 20)
        Me.txtIdEmpleado.TabIndex = 138
        Me.txtIdEmpleado.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(1156, 193)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 30)
        Me.btnCancelar.TabIndex = 121
        Me.btnCancelar.Text = "    Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(1156, 157)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 30)
        Me.btnEliminar.TabIndex = 120
        Me.btnEliminar.Text = "   Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(1156, 122)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(122, 30)
        Me.btnEditar.TabIndex = 118
        Me.btnEditar.Text = "    Modificar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(1156, 86)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 30)
        Me.btnGuardar.TabIndex = 116
        Me.btnGuardar.Text = "   Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(1156, 50)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 30)
        Me.btnNuevo.TabIndex = 114
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'pbReturn
        '
        Me.pbReturn.Image = CType(resources.GetObject("pbReturn.Image"), System.Drawing.Image)
        Me.pbReturn.Location = New System.Drawing.Point(12, 12)
        Me.pbReturn.Name = "pbReturn"
        Me.pbReturn.Size = New System.Drawing.Size(24, 24)
        Me.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbReturn.TabIndex = 151
        Me.pbReturn.TabStop = False
        '
        'IdCargo
        '
        Me.IdCargo.DataPropertyName = "IdCargo"
        Me.IdCargo.HeaderText = "ID"
        Me.IdCargo.Name = "IdCargo"
        Me.IdCargo.ReadOnly = True
        Me.IdCargo.Visible = False
        '
        'CodigoInventario
        '
        Me.CodigoInventario.DataPropertyName = "CodigoInventario"
        Me.CodigoInventario.HeaderText = "Código inventario"
        Me.CodigoInventario.Name = "CodigoInventario"
        Me.CodigoInventario.ReadOnly = True
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "Nombre"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        Me.NombreA.Width = 120
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "PrecioCompra"
        Me.PrecioCompra.HeaderText = "Precio compra"
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.ReadOnly = True
        Me.PrecioCompra.Width = 110
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre empleado"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'Identidad
        '
        Me.Identidad.DataPropertyName = "Identidad"
        Me.Identidad.HeaderText = "Identidad"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "Departamento"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        Me.NombreD.Width = 110
        '
        'FechaAsignacion
        '
        Me.FechaAsignacion.DataPropertyName = "FechaAsignacion"
        Me.FechaAsignacion.HeaderText = "Fecha asignación"
        Me.FechaAsignacion.Name = "FechaAsignacion"
        Me.FechaAsignacion.ReadOnly = True
        Me.FechaAsignacion.Width = 110
        '
        'EstadoArticulo
        '
        Me.EstadoArticulo.DataPropertyName = "EstadoArticulo"
        Me.EstadoArticulo.HeaderText = "Estado"
        Me.EstadoArticulo.Name = "EstadoArticulo"
        Me.EstadoArticulo.ReadOnly = True
        Me.EstadoArticulo.Width = 50
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "IdArticulo"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "IdEmpleado"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'frmCargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1326, 712)
        Me.Controls.Add(Me.pbReturn)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(410, 137)
        Me.Name = "frmCargoActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cargo activos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCargoActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents rbNombreA As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvCargoActivos As DataGridView
    Friend WithEvents lblTotalA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents btnIdentidad As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCodigo As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdEmpleado As TextBox
    Public WithEvents txtPrecio As TextBox
    Public WithEvents txtCodigo As TextBox
    Public WithEvents txtNombreArticulo As TextBox
    Public WithEvents cbEstadoActivo As ComboBox
    Public WithEvents txtCodigoInventario As TextBox
    Public WithEvents txtDepartamento As TextBox
    Public WithEvents txtNombreEmpleado As TextBox
    Public WithEvents dtpFechaEntrega As DateTimePicker
    Public WithEvents txtDescripcion As TextBox
    Public WithEvents txtNumeroIdentidad As TextBox
    Public WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents pbReturn As PictureBox
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents FechaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
End Class
