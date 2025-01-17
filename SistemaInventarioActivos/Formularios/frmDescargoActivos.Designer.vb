<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDescargoActivos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescargoActivos))
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtNombreArticulo = New System.Windows.Forms.TextBox()
        Me.txtNumeroIdentidad = New System.Windows.Forms.TextBox()
        Me.cbMotivo = New System.Windows.Forms.ComboBox()
        Me.txtCodigoI = New System.Windows.Forms.TextBox()
        Me.txtIdCargo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaDescargo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCargos = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbNombreA = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvDescargoActivos = New System.Windows.Forms.DataGridView()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDescargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoDescargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDescargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalD = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDescargoActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(1206, 286)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(27, 20)
        Me.txtIdArticulo.TabIndex = 146
        Me.txtIdArticulo.Visible = False
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(504, 70)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.ReadOnly = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(198, 23)
        Me.txtNombreEmpleado.TabIndex = 5
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Location = New System.Drawing.Point(504, 35)
        Me.txtNombreArticulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.ReadOnly = True
        Me.txtNombreArticulo.Size = New System.Drawing.Size(198, 23)
        Me.txtNombreArticulo.TabIndex = 2
        '
        'txtNumeroIdentidad
        '
        Me.txtNumeroIdentidad.Location = New System.Drawing.Point(140, 74)
        Me.txtNumeroIdentidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumeroIdentidad.Name = "txtNumeroIdentidad"
        Me.txtNumeroIdentidad.ReadOnly = True
        Me.txtNumeroIdentidad.Size = New System.Drawing.Size(158, 23)
        Me.txtNumeroIdentidad.TabIndex = 4
        '
        'cbMotivo
        '
        Me.cbMotivo.FormattingEnabled = True
        Me.cbMotivo.Items.AddRange(New Object() {"Obsoleto", "Cambio"})
        Me.cbMotivo.Location = New System.Drawing.Point(855, 118)
        Me.cbMotivo.Name = "cbMotivo"
        Me.cbMotivo.Size = New System.Drawing.Size(137, 24)
        Me.cbMotivo.TabIndex = 9
        '
        'txtCodigoI
        '
        Me.txtCodigoI.Location = New System.Drawing.Point(140, 34)
        Me.txtCodigoI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoI.Name = "txtCodigoI"
        Me.txtCodigoI.Size = New System.Drawing.Size(124, 23)
        Me.txtCodigoI.TabIndex = 1
        '
        'txtIdCargo
        '
        Me.txtIdCargo.Location = New System.Drawing.Point(1206, 321)
        Me.txtIdCargo.Name = "txtIdCargo"
        Me.txtIdCargo.Size = New System.Drawing.Size(27, 20)
        Me.txtIdCargo.TabIndex = 148
        Me.txtIdCargo.Visible = False
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
        Me.Label3.Text = "Nombre artículo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 38)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inventario"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(27, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 19)
        Me.Label16.TabIndex = 132
        Me.Label16.Text = "N° identidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDescargo)
        Me.GroupBox1.Controls.Add(Me.txtNombreEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtNombreArticulo)
        Me.GroupBox1.Controls.Add(Me.txtNumeroIdentidad)
        Me.GroupBox1.Controls.Add(Me.cbMotivo)
        Me.GroupBox1.Controls.Add(Me.txtCodigoI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCargos)
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
        Me.GroupBox1.Location = New System.Drawing.Point(164, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 233)
        Me.GroupBox1.TabIndex = 149
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del inventario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(411, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 38)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "descargo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dtpFechaDescargo
        '
        Me.dtpFechaDescargo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDescargo.Location = New System.Drawing.Point(504, 116)
        Me.dtpFechaDescargo.Name = "dtpFechaDescargo"
        Me.dtpFechaDescargo.Size = New System.Drawing.Size(198, 23)
        Me.dtpFechaDescargo.TabIndex = 8
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
        'btnCargos
        '
        Me.btnCargos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargos.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargos.ForeColor = System.Drawing.Color.White
        Me.btnCargos.Location = New System.Drawing.Point(267, 34)
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.Size = New System.Drawing.Size(31, 23)
        Me.btnCargos.TabIndex = 130
        Me.btnCargos.Text = "..."
        Me.btnCargos.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 167)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(852, 35)
        Me.txtDescripcion.TabIndex = 10
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(855, 34)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(137, 23)
        Me.txtPrecio.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(757, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(83, 38)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "Motivo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "descargo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(855, 69)
        Me.txtDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(137, 23)
        Me.txtDepartamento.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(48, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 38)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entrega"
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
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Enabled = False
        Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(140, 116)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(158, 23)
        Me.dtpFechaEntrega.TabIndex = 7
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbEmpleado)
        Me.Panel1.Controls.Add(Me.rbCodigo)
        Me.Panel1.Controls.Add(Me.rbNombreA)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvDescargoActivos)
        Me.Panel1.Controls.Add(Me.lblTotalD)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(164, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 452)
        Me.Panel1.TabIndex = 139
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
        Me.txtBuscar.Size = New System.Drawing.Size(491, 19)
        Me.txtBuscar.TabIndex = 11
        '
        'dgvDescargoActivos
        '
        Me.dgvDescargoActivos.AllowUserToAddRows = False
        Me.dgvDescargoActivos.AllowUserToDeleteRows = False
        Me.dgvDescargoActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDescargoActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargo, Me.CodigoInventario, Me.NombreA, Me.PrecioCompra, Me.Nombre, Me.Identidad, Me.NombreD, Me.FechaDescargo, Me.MotivoDescargo, Me.Descripcion, Me.IdArticulo, Me.IdDescargo, Me.IdEmpleado})
        Me.dgvDescargoActivos.Location = New System.Drawing.Point(0, 33)
        Me.dgvDescargoActivos.Name = "dgvDescargoActivos"
        Me.dgvDescargoActivos.ReadOnly = True
        Me.dgvDescargoActivos.RowHeadersVisible = False
        Me.dgvDescargoActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDescargoActivos.Size = New System.Drawing.Size(1000, 397)
        Me.dgvDescargoActivos.TabIndex = 23
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
        'FechaDescargo
        '
        Me.FechaDescargo.DataPropertyName = "FechaDescargo"
        Me.FechaDescargo.HeaderText = "Fecha descargo"
        Me.FechaDescargo.Name = "FechaDescargo"
        Me.FechaDescargo.ReadOnly = True
        Me.FechaDescargo.Width = 110
        '
        'MotivoDescargo
        '
        Me.MotivoDescargo.DataPropertyName = "MotivoDescargo"
        Me.MotivoDescargo.HeaderText = "Motivo descargo"
        Me.MotivoDescargo.Name = "MotivoDescargo"
        Me.MotivoDescargo.ReadOnly = True
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
        'IdDescargo
        '
        Me.IdDescargo.DataPropertyName = "IdDescargo"
        Me.IdDescargo.HeaderText = "IdDescargo"
        Me.IdDescargo.Name = "IdDescargo"
        Me.IdDescargo.ReadOnly = True
        Me.IdDescargo.Visible = False
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "IdEmpleado"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'lblTotalD
        '
        Me.lblTotalD.AutoSize = True
        Me.lblTotalD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalD.ForeColor = System.Drawing.Color.White
        Me.lblTotalD.Location = New System.Drawing.Point(984, 433)
        Me.lblTotalD.Name = "lblTotalD"
        Me.lblTotalD.Size = New System.Drawing.Size(16, 19)
        Me.lblTotalD.TabIndex = 22
        Me.lblTotalD.Text = "T"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(900, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Registros:"
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
        Me.txtId.Location = New System.Drawing.Point(1206, 358)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(27, 20)
        Me.txtId.TabIndex = 147
        Me.txtId.Visible = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(1170, 78)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 30)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "   Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(1170, 114)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 30)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "    Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(1170, 42)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 30)
        Me.btnNuevo.TabIndex = 12
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
        Me.pbReturn.TabIndex = 150
        Me.pbReturn.TabStop = False
        '
        'frmDescargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1342, 751)
        Me.Controls.Add(Me.pbReturn)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.txtIdCargo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(410, 137)
        Me.Name = "frmDescargoActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Descargo activos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDescargoActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtIdArticulo As TextBox
    Public WithEvents txtNombreEmpleado As TextBox
    Public WithEvents txtNombreArticulo As TextBox
    Public WithEvents txtNumeroIdentidad As TextBox
    Public WithEvents cbMotivo As ComboBox
    Friend WithEvents txtIdCargo As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
    Public WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCargos As Button
    Public WithEvents txtDescripcion As TextBox
    Public WithEvents txtPrecio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents txtDepartamento As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Public WithEvents dtpFechaEntrega As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents rbNombreA As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvDescargoActivos As DataGridView
    Friend WithEvents lblTotalD As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents dtpFechaDescargo As DateTimePicker
    Friend WithEvents txtCodigoI As TextBox
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents FechaDescargo As DataGridViewTextBoxColumn
    Friend WithEvents MotivoDescargo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents IdDescargo As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents pbReturn As PictureBox
End Class
