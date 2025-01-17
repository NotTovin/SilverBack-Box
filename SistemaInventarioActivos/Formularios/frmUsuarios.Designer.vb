<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.cboTipoUser = New System.Windows.Forms.ComboBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalUsuarios = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.cboEstado)
        Me.GroupBox1.Controls.Add(Me.cboTipoUser)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.txtNombreC)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(413, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 220)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 19)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Nombre completo"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(11, 28)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(26, 23)
        Me.txtId.TabIndex = 31
        Me.txtId.Visible = False
        '
        'cboEstado
        '
        Me.cboEstado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cboEstado.Location = New System.Drawing.Point(165, 180)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(266, 27)
        Me.cboEstado.TabIndex = 25
        '
        'cboTipoUser
        '
        Me.cboTipoUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoUser.FormattingEnabled = True
        Me.cboTipoUser.Items.AddRange(New Object() {"Administrador", "Invitado"})
        Me.cboTipoUser.Location = New System.Drawing.Point(165, 140)
        Me.cboTipoUser.Name = "cboTipoUser"
        Me.cboTipoUser.Size = New System.Drawing.Size(266, 27)
        Me.cboTipoUser.TabIndex = 24
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(165, 100)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(266, 27)
        Me.txtContraseña.TabIndex = 23
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(165, 20)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(266, 27)
        Me.txtUsuario.TabIndex = 22
        '
        'txtNombreC
        '
        Me.txtNombreC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreC.Location = New System.Drawing.Point(165, 60)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(266, 27)
        Me.txtNombreC.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(100, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tipo de usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(61, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(94, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Usuario"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(956, 235)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(123, 30)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(956, 199)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(123, 30)
        Me.btnEliminar.TabIndex = 29
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(956, 163)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(123, 30)
        Me.btnEditar.TabIndex = 28
        Me.btnEditar.Text = "Modificar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(956, 127)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 30)
        Me.btnGuardar.TabIndex = 27
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvUsuarios)
        Me.Panel1.Controls.Add(Me.lblTotalUsuarios)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(413, 308)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 427)
        Me.Panel1.TabIndex = 17
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(78, 3)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(144, 23)
        Me.txtBuscar.TabIndex = 24
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuario, Me.NombreCompleto, Me.Usuario, Me.Password, Me.TipoUsuario, Me.Estado})
        Me.dgvUsuarios.Location = New System.Drawing.Point(0, 32)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(537, 373)
        Me.dgvUsuarios.TabIndex = 23
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "ID"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'NombreCompleto
        '
        Me.NombreCompleto.DataPropertyName = "NombreCompleto"
        Me.NombreCompleto.HeaderText = "Nombre completo"
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.ReadOnly = True
        Me.NombreCompleto.Width = 180
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "Contraseña"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        Me.Password.Visible = False
        '
        'TipoUsuario
        '
        Me.TipoUsuario.DataPropertyName = "TipoUsuario"
        Me.TipoUsuario.HeaderText = "Tipo usuario"
        Me.TipoUsuario.Name = "TipoUsuario"
        Me.TipoUsuario.ReadOnly = True
        Me.TipoUsuario.Width = 120
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 120
        '
        'lblTotalUsuarios
        '
        Me.lblTotalUsuarios.AutoSize = True
        Me.lblTotalUsuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblTotalUsuarios.Location = New System.Drawing.Point(517, 408)
        Me.lblTotalUsuarios.Name = "lblTotalUsuarios"
        Me.lblTotalUsuarios.Size = New System.Drawing.Size(16, 19)
        Me.lblTotalUsuarios.TabIndex = 22
        Me.lblTotalUsuarios.Text = "T"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(349, 408)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Usuarios registrados:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Buscar"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 801)
        Me.Splitter1.TabIndex = 18
        Me.Splitter1.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(956, 91)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(123, 30)
        Me.btnNuevo.TabIndex = 26
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
        Me.pbReturn.TabIndex = 152
        Me.pbReturn.TabStop = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1342, 801)
        Me.Controls.Add(Me.pbReturn)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents cboTipoUser As ComboBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtNombreC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalUsuarios As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents TipoUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents pbReturn As PictureBox
End Class
