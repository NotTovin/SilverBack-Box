<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbCedula = New System.Windows.Forms.RadioButton()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalEmpleados = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.GroupBox()
        Me.btnDepartamento = New System.Windows.Forms.Button()
        Me.btnPuesto = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbPuesto = New System.Windows.Forms.ComboBox()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnCancelar.SuspendLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbCedula)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvEmpleados)
        Me.Panel1.Controls.Add(Me.lblTotalEmpleados)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(283, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 394)
        Me.Panel1.TabIndex = 70
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDepartamento.ForeColor = System.Drawing.Color.White
        Me.rbDepartamento.Location = New System.Drawing.Point(273, 5)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(133, 22)
        Me.rbDepartamento.TabIndex = 87
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbCedula
        '
        Me.rbCedula.AutoSize = True
        Me.rbCedula.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCedula.ForeColor = System.Drawing.Color.White
        Me.rbCedula.Location = New System.Drawing.Point(193, 5)
        Me.rbCedula.Name = "rbCedula"
        Me.rbCedula.Size = New System.Drawing.Size(81, 22)
        Me.rbCedula.TabIndex = 86
        Me.rbCedula.Text = "Cédula"
        Me.rbCedula.UseVisualStyleBackColor = True
        '
        'rbNombreEmpleado
        '
        Me.rbNombreEmpleado.AutoSize = True
        Me.rbNombreEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.rbNombreEmpleado.Checked = True
        Me.rbNombreEmpleado.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreEmpleado.ForeColor = System.Drawing.Color.White
        Me.rbNombreEmpleado.Location = New System.Drawing.Point(102, 5)
        Me.rbNombreEmpleado.Name = "rbNombreEmpleado"
        Me.rbNombreEmpleado.Size = New System.Drawing.Size(86, 22)
        Me.rbNombreEmpleado.TabIndex = 85
        Me.rbNombreEmpleado.TabStop = True
        Me.rbNombreEmpleado.Text = "Nombre"
        Me.rbNombreEmpleado.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(408, 3)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(436, 21)
        Me.txtBuscar.TabIndex = 84
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleado, Me.Nombre, Me.Identidad, Me.Genero, Me.Telefono, Me.Correo, Me.Direccion, Me.NombrePuesto, Me.NombreD})
        Me.dgvEmpleados.Location = New System.Drawing.Point(3, 30)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersVisible = False
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(853, 335)
        Me.dgvEmpleados.TabIndex = 23
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "ID"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre completo"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 130
        '
        'Identidad
        '
        Me.Identidad.DataPropertyName = "Identidad"
        Me.Identidad.HeaderText = "Cédula"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        Me.Identidad.Width = 72
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        Me.Genero.HeaderText = "Género"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        Me.Genero.Visible = False
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "Télefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 65
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "Correo"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.Width = 165
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 220
        '
        'NombrePuesto
        '
        Me.NombrePuesto.DataPropertyName = "NombrePuesto"
        Me.NombrePuesto.HeaderText = "Puesto"
        Me.NombrePuesto.Name = "NombrePuesto"
        Me.NombrePuesto.ReadOnly = True
        Me.NombrePuesto.Width = 80
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "Departamento"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        '
        'lblTotalEmpleados
        '
        Me.lblTotalEmpleados.AutoSize = True
        Me.lblTotalEmpleados.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmpleados.ForeColor = System.Drawing.Color.White
        Me.lblTotalEmpleados.Location = New System.Drawing.Point(831, 368)
        Me.lblTotalEmpleados.Name = "lblTotalEmpleados"
        Me.lblTotalEmpleados.Size = New System.Drawing.Size(16, 19)
        Me.lblTotalEmpleados.TabIndex = 22
        Me.lblTotalEmpleados.Text = "T"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Buscar por:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(638, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Empleados registrados:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Controls.Add(Me.btnDepartamento)
        Me.btnCancelar.Controls.Add(Me.btnPuesto)
        Me.btnCancelar.Controls.Add(Me.txtID)
        Me.btnCancelar.Controls.Add(Me.txtDireccion)
        Me.btnCancelar.Controls.Add(Me.cbDepartamento)
        Me.btnCancelar.Controls.Add(Me.cbPuesto)
        Me.btnCancelar.Controls.Add(Me.cbGenero)
        Me.btnCancelar.Controls.Add(Me.Label8)
        Me.btnCancelar.Controls.Add(Me.Label7)
        Me.btnCancelar.Controls.Add(Me.Label6)
        Me.btnCancelar.Controls.Add(Me.Label5)
        Me.btnCancelar.Controls.Add(Me.Label4)
        Me.btnCancelar.Controls.Add(Me.Label2)
        Me.btnCancelar.Controls.Add(Me.Label1)
        Me.btnCancelar.Controls.Add(Me.Label3)
        Me.btnCancelar.Controls.Add(Me.txtCorreo)
        Me.btnCancelar.Controls.Add(Me.txtTelefono)
        Me.btnCancelar.Controls.Add(Me.txtCedula)
        Me.btnCancelar.Controls.Add(Me.txtNombreEmpleado)
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(283, 68)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(731, 220)
        Me.btnCancelar.TabIndex = 71
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Información del empleado"
        '
        'btnDepartamento
        '
        Me.btnDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartamento.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartamento.ForeColor = System.Drawing.Color.White
        Me.btnDepartamento.Location = New System.Drawing.Point(449, 169)
        Me.btnDepartamento.Name = "btnDepartamento"
        Me.btnDepartamento.Size = New System.Drawing.Size(32, 24)
        Me.btnDepartamento.TabIndex = 104
        Me.btnDepartamento.Text = "..."
        Me.btnDepartamento.UseVisualStyleBackColor = False
        '
        'btnPuesto
        '
        Me.btnPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPuesto.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPuesto.ForeColor = System.Drawing.Color.White
        Me.btnPuesto.Location = New System.Drawing.Point(208, 169)
        Me.btnPuesto.Name = "btnPuesto"
        Me.btnPuesto.Size = New System.Drawing.Size(31, 24)
        Me.btnPuesto.TabIndex = 103
        Me.btnPuesto.Text = "..."
        Me.btnPuesto.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(703, 13)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 23)
        Me.txtID.TabIndex = 86
        Me.txtID.Visible = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(495, 113)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(228, 80)
        Me.txtDireccion.TabIndex = 96
        '
        'cbDepartamento
        '
        Me.cbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(253, 169)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(190, 24)
        Me.cbDepartamento.TabIndex = 94
        '
        'cbPuesto
        '
        Me.cbPuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPuesto.FormattingEnabled = True
        Me.cbPuesto.Location = New System.Drawing.Point(11, 171)
        Me.cbPuesto.Name = "cbPuesto"
        Me.cbPuesto.Size = New System.Drawing.Size(191, 24)
        Me.cbPuesto.TabIndex = 92
        '
        'cbGenero
        '
        Me.cbGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "No especificar"})
        Me.cbGenero.Location = New System.Drawing.Point(11, 113)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(228, 24)
        Me.cbGenero.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(249, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 19)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Puesto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(491, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(249, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(248, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Género"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(490, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Cédula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 19)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Nombre completo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(253, 113)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(228, 23)
        Me.txtCorreo.TabIndex = 89
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(253, 57)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(228, 23)
        Me.txtTelefono.TabIndex = 90
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(495, 57)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(228, 23)
        Me.txtCedula.TabIndex = 88
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(11, 57)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(228, 23)
        Me.txtNombreEmpleado.TabIndex = 87
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(1020, 254)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 30)
        Me.btnCancel.TabIndex = 91
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(1020, 182)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 30)
        Me.btnBuscar.TabIndex = 89
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
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
        Me.btnEliminar.Location = New System.Drawing.Point(1020, 218)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 30)
        Me.btnEliminar.TabIndex = 90
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(1020, 74)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 30)
        Me.btnNuevo.TabIndex = 86
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(1020, 146)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(122, 30)
        Me.btnEditar.TabIndex = 88
        Me.btnEditar.Text = "Modificar"
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
        Me.btnGuardar.Location = New System.Drawing.Point(1020, 110)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 30)
        Me.btnGuardar.TabIndex = 87
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1342, 801)
        Me.Controls.Add(Me.pbReturn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnCancelar.ResumeLayout(False)
        Me.btnCancelar.PerformLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents lblTotalEmpleados As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents NombrePuesto As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents rbCedula As RadioButton
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents btnCancelar As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnDepartamento As Button
    Friend WithEvents btnPuesto As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbPuesto As ComboBox
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents pbReturn As PictureBox
End Class
