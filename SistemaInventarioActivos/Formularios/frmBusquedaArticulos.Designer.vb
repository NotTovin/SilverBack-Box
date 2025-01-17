<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBusquedaArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaArticulos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbMarca = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbNombreA = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvBusquedaArticulos = New System.Windows.Forms.DataGridView()
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
        Me.Panel1.SuspendLayout()
        CType(Me.dgvBusquedaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbMarca)
        Me.Panel1.Controls.Add(Me.rbCodigo)
        Me.Panel1.Controls.Add(Me.rbNombreA)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvBusquedaArticulos)
        Me.Panel1.Controls.Add(Me.lblTotalA)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(75, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 322)
        Me.Panel1.TabIndex = 80
        '
        'rbMarca
        '
        Me.rbMarca.AutoSize = True
        Me.rbMarca.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMarca.ForeColor = System.Drawing.Color.White
        Me.rbMarca.Location = New System.Drawing.Point(262, 11)
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
        Me.txtBuscar.Location = New System.Drawing.Point(343, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(252, 19)
        Me.txtBuscar.TabIndex = 84
        '
        'dgvBusquedaArticulos
        '
        Me.dgvBusquedaArticulos.AllowUserToAddRows = False
        Me.dgvBusquedaArticulos.AllowUserToDeleteRows = False
        Me.dgvBusquedaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusquedaArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticulo, Me.NombreA, Me.NumeroSerie, Me.CodigoA, Me.NombreM, Me.Modelo, Me.PrecioCompra, Me.FechaCompra, Me.EstadoArticulo, Me.Descripcion})
        Me.dgvBusquedaArticulos.Location = New System.Drawing.Point(0, 33)
        Me.dgvBusquedaArticulos.Name = "dgvBusquedaArticulos"
        Me.dgvBusquedaArticulos.ReadOnly = True
        Me.dgvBusquedaArticulos.RowHeadersVisible = False
        Me.dgvBusquedaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusquedaArticulos.Size = New System.Drawing.Size(1000, 255)
        Me.dgvBusquedaArticulos.TabIndex = 23
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
        Me.CodigoA.Width = 80
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
        Me.PrecioCompra.Width = 85
        '
        'FechaCompra
        '
        Me.FechaCompra.DataPropertyName = "FechaCompra"
        Me.FechaCompra.HeaderText = "Fecha compra"
        Me.FechaCompra.Name = "FechaCompra"
        Me.FechaCompra.ReadOnly = True
        Me.FechaCompra.Width = 110
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
        Me.Descripcion.Width = 250
        '
        'lblTotalA
        '
        Me.lblTotalA.AutoSize = True
        Me.lblTotalA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalA.ForeColor = System.Drawing.Color.White
        Me.lblTotalA.Location = New System.Drawing.Point(981, 291)
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
        Me.Label9.Location = New System.Drawing.Point(810, 291)
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
        'frmBusquedaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 348)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(250, 0)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBusquedaArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda de inventario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvBusquedaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbMarca As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents rbNombreA As RadioButton
    Friend WithEvents txtBuscar As TextBox
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
    Friend WithEvents lblTotalA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvBusquedaArticulos As DataGridView
End Class
