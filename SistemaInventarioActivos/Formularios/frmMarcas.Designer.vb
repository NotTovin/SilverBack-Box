<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMarcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarcas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDescripcionM = New System.Windows.Forms.TextBox()
        Me.txtNombreM = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvMarcas = New System.Windows.Forms.DataGridView()
        Me.IdMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalM = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbReturn = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionM)
        Me.GroupBox1.Controls.Add(Me.txtNombreM)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(451, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 117)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de la marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(32, 55)
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
        Me.Label3.Location = New System.Drawing.Point(80, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Marca"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 25)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(21, 24)
        Me.txtID.TabIndex = 5
        Me.txtID.Visible = False
        '
        'txtDescripcionM
        '
        Me.txtDescripcionM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionM.Location = New System.Drawing.Point(153, 55)
        Me.txtDescripcionM.Multiline = True
        Me.txtDescripcionM.Name = "txtDescripcionM"
        Me.txtDescripcionM.Size = New System.Drawing.Size(247, 52)
        Me.txtDescripcionM.TabIndex = 41
        '
        'txtNombreM
        '
        Me.txtNombreM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreM.Location = New System.Drawing.Point(153, 28)
        Me.txtNombreM.Name = "txtNombreM"
        Me.txtNombreM.Size = New System.Drawing.Size(247, 21)
        Me.txtNombreM.TabIndex = 40
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
        Me.btnBuscar.Location = New System.Drawing.Point(869, 219)
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
        Me.btnCancelar.Location = New System.Drawing.Point(869, 291)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 30)
        Me.btnCancelar.TabIndex = 46
        Me.btnCancelar.Text = "     Cancelar"
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
        Me.btnEliminar.Location = New System.Drawing.Point(869, 255)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 30)
        Me.btnEliminar.TabIndex = 45
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
        Me.btnEditar.Location = New System.Drawing.Point(869, 183)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(122, 30)
        Me.btnEditar.TabIndex = 44
        Me.btnEditar.Text = "     Modificar"
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
        Me.btnGuardar.Location = New System.Drawing.Point(869, 147)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 30)
        Me.btnGuardar.TabIndex = 43
        Me.btnGuardar.Text = "    Guardar"
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
        Me.btnNuevo.Location = New System.Drawing.Point(869, 111)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 30)
        Me.btnNuevo.TabIndex = 42
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvMarcas)
        Me.Panel1.Controls.Add(Me.lblTotalM)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(451, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 474)
        Me.Panel1.TabIndex = 42
        '
        'dgvMarcas
        '
        Me.dgvMarcas.AllowUserToAddRows = False
        Me.dgvMarcas.AllowUserToDeleteRows = False
        Me.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMarcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMarca, Me.NombreM, Me.DescripcionM})
        Me.dgvMarcas.Location = New System.Drawing.Point(3, 38)
        Me.dgvMarcas.Name = "dgvMarcas"
        Me.dgvMarcas.ReadOnly = True
        Me.dgvMarcas.RowHeadersVisible = False
        Me.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMarcas.Size = New System.Drawing.Size(406, 414)
        Me.dgvMarcas.TabIndex = 27
        '
        'IdMarca
        '
        Me.IdMarca.DataPropertyName = "IdMarca"
        Me.IdMarca.HeaderText = "IdMarca"
        Me.IdMarca.Name = "IdMarca"
        Me.IdMarca.ReadOnly = True
        Me.IdMarca.Visible = False
        '
        'NombreM
        '
        Me.NombreM.DataPropertyName = "NombreM"
        Me.NombreM.HeaderText = "Marca"
        Me.NombreM.Name = "NombreM"
        Me.NombreM.ReadOnly = True
        Me.NombreM.Width = 150
        '
        'DescripcionM
        '
        Me.DescripcionM.DataPropertyName = "DescripcionM"
        Me.DescripcionM.HeaderText = "Descripción"
        Me.DescripcionM.Name = "DescripcionM"
        Me.DescripcionM.ReadOnly = True
        Me.DescripcionM.Width = 255
        '
        'lblTotalM
        '
        Me.lblTotalM.AutoSize = True
        Me.lblTotalM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalM.ForeColor = System.Drawing.Color.White
        Me.lblTotalM.Location = New System.Drawing.Point(395, 455)
        Me.lblTotalM.Name = "lblTotalM"
        Me.lblTotalM.Size = New System.Drawing.Size(16, 19)
        Me.lblTotalM.TabIndex = 26
        Me.lblTotalM.Text = "T"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(231, 455)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(158, 19)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "Marcas registradas:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(88, 11)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(312, 21)
        Me.txtBuscar.TabIndex = 24
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
        'frmMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1342, 801)
        Me.Controls.Add(Me.pbReturn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMarcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalM As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtDescripcionM As TextBox
    Friend WithEvents txtNombreM As TextBox
    Friend WithEvents dgvMarcas As DataGridView
    Friend WithEvents IdMarca As DataGridViewTextBoxColumn
    Friend WithEvents NombreM As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionM As DataGridViewTextBoxColumn
    Friend WithEvents pbReturn As PictureBox
End Class
