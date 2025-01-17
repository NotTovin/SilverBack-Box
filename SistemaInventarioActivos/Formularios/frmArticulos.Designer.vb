<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbMarca = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbNombreA = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalA = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtNumeroSerie = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbMarca)
        Me.Panel1.Controls.Add(Me.rbCodigo)
        Me.Panel1.Controls.Add(Me.rbNombreA)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvArticulos)
        Me.Panel1.Controls.Add(Me.lblTotalA)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(149, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(999, 350)
        Me.Panel1.TabIndex = 76
        '
        'rbMarca
        '
        Me.rbMarca.AutoSize = True
        Me.rbMarca.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMarca.ForeColor = System.Drawing.Color.White
        Me.rbMarca.Location = New System.Drawing.Point(288, 22)
        Me.rbMarca.Name = "rbMarca"
        Me.rbMarca.Size = New System.Drawing.Size(75, 22)
        Me.rbMarca.TabIndex = 87
        Me.rbMarca.Text = "Marca"
        Me.rbMarca.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.ForeColor = System.Drawing.Color.White
        Me.rbCodigo.Location = New System.Drawing.Point(208, 22)
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
        Me.rbNombreA.Location = New System.Drawing.Point(117, 22)
        Me.rbNombreA.Name = "rbNombreA"
        Me.rbNombreA.Size = New System.Drawing.Size(86, 22)
        Me.rbNombreA.TabIndex = 85
        Me.rbNombreA.TabStop = True
        Me.rbNombreA.Text = "Nombre"
        Me.rbNombreA.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(364, 22)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(252, 20)
        Me.txtBuscar.TabIndex = 78
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToDeleteRows = False
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticulo, Me.NombreA, Me.NumeroSerie, Me.CodigoA, Me.NombreM, Me.Modelo, Me.PrecioCompra, Me.FechaCompra, Me.EstadoArticulo, Me.Descripcion})
        Me.dgvArticulos.Location = New System.Drawing.Point(0, 48)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReadOnly = True
        Me.dgvArticulos.RowHeadersVisible = False
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(999, 274)
        Me.dgvArticulos.TabIndex = 23
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "ID"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "Articulo"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        Me.NombreA.Width = 150
        '
        'NumeroSerie
        '
        Me.NumeroSerie.DataPropertyName = "NumeroSerie"
        Me.NumeroSerie.HeaderText = "Número serie"
        Me.NumeroSerie.Name = "NumeroSerie"
        Me.NumeroSerie.ReadOnly = True
        Me.NumeroSerie.Width = 120
        '
        'CodigoA
        '
        Me.CodigoA.DataPropertyName = "CodigoA"
        Me.CodigoA.HeaderText = "Código"
        Me.CodigoA.Name = "CodigoA"
        Me.CodigoA.ReadOnly = True
        Me.CodigoA.Width = 120
        '
        'NombreM
        '
        Me.NombreM.DataPropertyName = "NombreM"
        Me.NombreM.HeaderText = "Marca"
        Me.NombreM.Name = "NombreM"
        Me.NombreM.ReadOnly = True
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "Modelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "PrecioCompra"
        Me.PrecioCompra.HeaderText = "Precio"
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.ReadOnly = True
        '
        'FechaCompra
        '
        Me.FechaCompra.DataPropertyName = "FechaCompra"
        Me.FechaCompra.HeaderText = "Fecha compra"
        Me.FechaCompra.Name = "FechaCompra"
        Me.FechaCompra.ReadOnly = True
        '
        'EstadoArticulo
        '
        Me.EstadoArticulo.DataPropertyName = "EstadoArticulo"
        Me.EstadoArticulo.HeaderText = "Estado"
        Me.EstadoArticulo.Name = "EstadoArticulo"
        Me.EstadoArticulo.ReadOnly = True
        Me.EstadoArticulo.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 210
        '
        'lblTotalA
        '
        Me.lblTotalA.AutoSize = True
        Me.lblTotalA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalA.ForeColor = System.Drawing.Color.White
        Me.lblTotalA.Location = New System.Drawing.Point(980, 325)
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
        Me.Label9.Location = New System.Drawing.Point(809, 325)
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
        Me.Label10.Location = New System.Drawing.Point(21, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Buscar por:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaCompra)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnMarca)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.cbMarca)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.txtNumeroSerie)
        Me.GroupBox1.Controls.Add(Me.txtNombreA)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(149, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(999, 202)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del articulo"
        '
        'dtpFechaCompra
        '
        Me.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCompra.Location = New System.Drawing.Point(261, 107)
        Me.dtpFechaCompra.Name = "dtpFechaCompra"
        Me.dtpFechaCompra.Size = New System.Drawing.Size(228, 23)
        Me.dtpFechaCompra.TabIndex = 75
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(747, 47)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(228, 23)
        Me.txtPrecio.TabIndex = 73
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(257, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 23)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Fecha de compra"
        '
        'btnMarca
        '
        Me.btnMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarca.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarca.ForeColor = System.Drawing.Color.White
        Me.btnMarca.Location = New System.Drawing.Point(701, 106)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(31, 24)
        Me.btnMarca.TabIndex = 85
        Me.btnMarca.Text = "..."
        Me.btnMarca.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 380)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 23)
        Me.txtID.TabIndex = 60
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(142, 143)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(833, 39)
        Me.txtDescripcion.TabIndex = 77
        '
        'cbMarca
        '
        Me.cbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(504, 106)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(191, 24)
        Me.cbMarca.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(500, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 23)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 23)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(500, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Código"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 23)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(743, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(257, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 23)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Número de serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 23)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Artículo"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(20, 107)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(228, 23)
        Me.txtModelo.TabIndex = 74
        '
        'txtNumeroSerie
        '
        Me.txtNumeroSerie.Location = New System.Drawing.Point(261, 47)
        Me.txtNumeroSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumeroSerie.Name = "txtNumeroSerie"
        Me.txtNumeroSerie.Size = New System.Drawing.Size(228, 23)
        Me.txtNumeroSerie.TabIndex = 71
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(20, 47)
        Me.txtNombreA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(228, 23)
        Me.txtNombreA.TabIndex = 70
        '
        'pbReturn
        '
        Me.pbReturn.Image = CType(resources.GetObject("pbReturn.Image"), System.Drawing.Image)
        Me.pbReturn.Location = New System.Drawing.Point(12, 12)
        Me.pbReturn.Name = "pbReturn"
        Me.pbReturn.Size = New System.Drawing.Size(24, 24)
        Me.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbReturn.TabIndex = 152
        Me.pbReturn.TabStop = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(1154, 109)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 30)
        Me.btnNuevo.TabIndex = 80
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(1154, 145)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 30)
        Me.btnGuardar.TabIndex = 81
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
        Me.btnCancelar.Location = New System.Drawing.Point(1154, 289)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 30)
        Me.btnCancelar.TabIndex = 85
        Me.btnCancelar.Text = "    Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.White
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(1154, 217)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(122, 30)
        Me.btnReporte.TabIndex = 83
        Me.btnReporte.Text = " Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(1154, 181)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(122, 30)
        Me.btnEditar.TabIndex = 82
        Me.btnEditar.Text = "    Modificar"
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnEliminar.Location = New System.Drawing.Point(1154, 253)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 30)
        Me.btnEliminar.TabIndex = 84
        Me.btnEliminar.Text = "   Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(504, 47)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(228, 23)
        Me.txtCodigo.TabIndex = 72
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1342, 801)
        Me.Controls.Add(Me.pbReturn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbMarca As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents rbNombreA As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents lblTotalA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMarca As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtNumeroSerie As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents dtpFechaCompra As DateTimePicker
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents NumeroSerie As DataGridViewTextBoxColumn
    Friend WithEvents CodigoA As DataGridViewTextBoxColumn
    Friend WithEvents NombreM As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents FechaCompra As DataGridViewTextBoxColumn
    Friend WithEvents EstadoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents pbReturn As PictureBox
    Friend WithEvents txtCodigo As TextBox
End Class
