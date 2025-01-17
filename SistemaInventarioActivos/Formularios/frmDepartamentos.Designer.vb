<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentos))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalD = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvDepartamentos = New System.Windows.Forms.DataGridView()
        Me.IdDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcionD = New System.Windows.Forms.TextBox()
        Me.txtNombreD = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 69)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(21, 23)
        Me.txtID.TabIndex = 5
        Me.txtID.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotalD)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvDepartamentos)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(448, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 502)
        Me.Panel1.TabIndex = 37
        '
        'lblTotalD
        '
        Me.lblTotalD.AutoSize = True
        Me.lblTotalD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalD.ForeColor = System.Drawing.Color.White
        Me.lblTotalD.Location = New System.Drawing.Point(390, 478)
        Me.lblTotalD.Name = "lblTotalD"
        Me.lblTotalD.Size = New System.Drawing.Size(16, 19)
        Me.lblTotalD.TabIndex = 26
        Me.lblTotalD.Text = "T"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(165, 478)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(219, 19)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "Departamentos registrados:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(88, 11)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(312, 21)
        Me.txtBuscar.TabIndex = 24
        '
        'dgvDepartamentos
        '
        Me.dgvDepartamentos.AllowUserToAddRows = False
        Me.dgvDepartamentos.AllowUserToDeleteRows = False
        Me.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepartamento, Me.NombreD, Me.DescripcionD})
        Me.dgvDepartamentos.Location = New System.Drawing.Point(0, 37)
        Me.dgvDepartamentos.Name = "dgvDepartamentos"
        Me.dgvDepartamentos.ReadOnly = True
        Me.dgvDepartamentos.RowHeadersVisible = False
        Me.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartamentos.Size = New System.Drawing.Size(412, 438)
        Me.dgvDepartamentos.TabIndex = 23
        '
        'IdDepartamento
        '
        Me.IdDepartamento.DataPropertyName = "IdDepartamento"
        Me.IdDepartamento.HeaderText = "ID"
        Me.IdDepartamento.Name = "IdDepartamento"
        Me.IdDepartamento.ReadOnly = True
        Me.IdDepartamento.Visible = False
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "Departamento"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        Me.NombreD.Width = 150
        '
        'DescripcionD
        '
        Me.DescripcionD.DataPropertyName = "DescripcionD"
        Me.DescripcionD.HeaderText = "Descripcion"
        Me.DescripcionD.Name = "DescripcionD"
        Me.DescripcionD.ReadOnly = True
        Me.DescripcionD.Width = 240
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 23)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionD)
        Me.GroupBox1.Controls.Add(Me.txtNombreD)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(448, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 136)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del departamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(32, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 23)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Departamento"
        '
        'txtDescripcionD
        '
        Me.txtDescripcionD.Location = New System.Drawing.Point(153, 60)
        Me.txtDescripcionD.Multiline = True
        Me.txtDescripcionD.Name = "txtDescripcionD"
        Me.txtDescripcionD.Size = New System.Drawing.Size(247, 63)
        Me.txtDescripcionD.TabIndex = 41
        '
        'txtNombreD
        '
        Me.txtNombreD.Location = New System.Drawing.Point(153, 24)
        Me.txtNombreD.Name = "txtNombreD"
        Me.txtNombreD.Size = New System.Drawing.Size(247, 23)
        Me.txtNombreD.TabIndex = 40
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
        Me.btnBuscar.Location = New System.Drawing.Point(866, 188)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 30)
        Me.btnBuscar.TabIndex = 47
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(866, 260)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 30)
        Me.btnCancelar.TabIndex = 46
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
        Me.btnEliminar.Location = New System.Drawing.Point(866, 224)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 30)
        Me.btnEliminar.TabIndex = 45
        Me.btnEliminar.Text = "  Eliminar"
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
        Me.btnEditar.Location = New System.Drawing.Point(866, 152)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(122, 30)
        Me.btnEditar.TabIndex = 44
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
        Me.btnGuardar.Location = New System.Drawing.Point(866, 116)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 30)
        Me.btnGuardar.TabIndex = 43
        Me.btnGuardar.Text = "   Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(866, 80)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 30)
        Me.btnNuevo.TabIndex = 42
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
        'frmDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1342, 801)
        Me.Controls.Add(Me.pbReturn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDepartamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvDepartamentos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalD As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtDescripcionD As TextBox
    Friend WithEvents txtNombreD As TextBox
    Friend WithEvents IdDepartamento As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionD As DataGridViewTextBoxColumn
    Friend WithEvents pbReturn As PictureBox
End Class
