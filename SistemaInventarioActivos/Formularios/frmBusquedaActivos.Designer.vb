<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaActivos))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbNombreA = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvCargoActivos = New System.Windows.Forms.DataGridView()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalA = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvCargoActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbDepartamento)
        Me.Panel2.Controls.Add(Me.rbEmpleado)
        Me.Panel2.Controls.Add(Me.rbCodigo)
        Me.Panel2.Controls.Add(Me.rbNombreA)
        Me.Panel2.Controls.Add(Me.txtBuscar)
        Me.Panel2.Controls.Add(Me.dgvCargoActivos)
        Me.Panel2.Controls.Add(Me.lblTotalA)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(64, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 322)
        Me.Panel2.TabIndex = 80
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
        Me.dgvCargoActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargo, Me.CodigoInventario, Me.NombreA, Me.PrecioCompra, Me.Nombre, Me.Identidad, Me.NombreD, Me.FechaAsignacion, Me.Descripcion})
        Me.dgvCargoActivos.Location = New System.Drawing.Point(0, 33)
        Me.dgvCargoActivos.Name = "dgvCargoActivos"
        Me.dgvCargoActivos.ReadOnly = True
        Me.dgvCargoActivos.RowHeadersVisible = False
        Me.dgvCargoActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCargoActivos.Size = New System.Drawing.Size(1000, 255)
        Me.dgvCargoActivos.TabIndex = 23
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
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
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
        'frmBusquedaActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 345)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusquedaActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de activos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvCargoActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents rbNombreA As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvCargoActivos As DataGridView
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents FechaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
