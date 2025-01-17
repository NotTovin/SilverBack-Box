<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaEmpleados))
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
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 337)
        Me.Panel1.TabIndex = 71
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
        Me.dgvEmpleados.Location = New System.Drawing.Point(11, 30)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersVisible = False
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(836, 280)
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
        Me.lblTotalEmpleados.Location = New System.Drawing.Point(826, 313)
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
        Me.Label9.Location = New System.Drawing.Point(633, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Empleados registrados:"
        '
        'frmBusquedaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(879, 362)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBusquedaEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbCedula As RadioButton
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents NombrePuesto As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalEmpleados As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
