<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.btnPuesto = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnDepartamento = New System.Windows.Forms.Button()
        Me.panelInventario = New System.Windows.Forms.Panel()
        Me.btnDescargoActivos = New System.Windows.Forms.Button()
        Me.btnCargoActivos = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.panelArticulos = New System.Windows.Forms.Panel()
        Me.btnMarcas = New System.Windows.Forms.Button()
        Me.btnControlArticulos = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.panelEmpleados = New System.Windows.Forms.Panel()
        Me.btnControlEmpleados = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.panelUsuarios = New System.Windows.Forms.Panel()
        Me.btnControlUsuarios = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bntMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelSideMenu.SuspendLayout()
        Me.panelInventario.SuspendLayout()
        Me.panelArticulos.SuspendLayout()
        Me.panelEmpleados.SuspendLayout()
        Me.panelUsuarios.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChildForm.SuspendLayout()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.btnPuesto)
        Me.PanelSideMenu.Controls.Add(Me.btnSalir)
        Me.PanelSideMenu.Controls.Add(Me.btnDepartamento)
        Me.PanelSideMenu.Controls.Add(Me.panelInventario)
        Me.PanelSideMenu.Controls.Add(Me.btnInventario)
        Me.PanelSideMenu.Controls.Add(Me.panelArticulos)
        Me.PanelSideMenu.Controls.Add(Me.btnArticulos)
        Me.PanelSideMenu.Controls.Add(Me.panelEmpleados)
        Me.PanelSideMenu.Controls.Add(Me.btnEmpleados)
        Me.PanelSideMenu.Controls.Add(Me.panelUsuarios)
        Me.PanelSideMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelSideMenu.Controls.Add(Me.PanelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 840)
        Me.PanelSideMenu.TabIndex = 0
        '
        'btnPuesto
        '
        Me.btnPuesto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPuesto.FlatAppearance.BorderSize = 0
        Me.btnPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPuesto.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPuesto.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPuesto.Image = CType(resources.GetObject("btnPuesto.Image"), System.Drawing.Image)
        Me.btnPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPuesto.Location = New System.Drawing.Point(0, 670)
        Me.btnPuesto.Name = "btnPuesto"
        Me.btnPuesto.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPuesto.Size = New System.Drawing.Size(250, 60)
        Me.btnPuesto.TabIndex = 12
        Me.btnPuesto.Text = "Puestos"
        Me.btnPuesto.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.Image = Global.SistemaInventarioActivos.My.Resources.Resources.logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 741)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSalir.Size = New System.Drawing.Size(250, 99)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "     Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnDepartamento
        '
        Me.btnDepartamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDepartamento.FlatAppearance.BorderSize = 0
        Me.btnDepartamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartamento.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartamento.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDepartamento.Image = CType(resources.GetObject("btnDepartamento.Image"), System.Drawing.Image)
        Me.btnDepartamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartamento.Location = New System.Drawing.Point(0, 610)
        Me.btnDepartamento.Name = "btnDepartamento"
        Me.btnDepartamento.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDepartamento.Size = New System.Drawing.Size(250, 60)
        Me.btnDepartamento.TabIndex = 10
        Me.btnDepartamento.Text = "            Departamentos"
        Me.btnDepartamento.UseVisualStyleBackColor = True
        '
        'panelInventario
        '
        Me.panelInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelInventario.Controls.Add(Me.btnDescargoActivos)
        Me.panelInventario.Controls.Add(Me.btnCargoActivos)
        Me.panelInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelInventario.Location = New System.Drawing.Point(0, 523)
        Me.panelInventario.Name = "panelInventario"
        Me.panelInventario.Size = New System.Drawing.Size(250, 87)
        Me.panelInventario.TabIndex = 9
        '
        'btnDescargoActivos
        '
        Me.btnDescargoActivos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDescargoActivos.FlatAppearance.BorderSize = 0
        Me.btnDescargoActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDescargoActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescargoActivos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescargoActivos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDescargoActivos.Location = New System.Drawing.Point(0, 40)
        Me.btnDescargoActivos.Name = "btnDescargoActivos"
        Me.btnDescargoActivos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnDescargoActivos.Size = New System.Drawing.Size(250, 40)
        Me.btnDescargoActivos.TabIndex = 1
        Me.btnDescargoActivos.Text = "Descargo de activos"
        Me.btnDescargoActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescargoActivos.UseVisualStyleBackColor = True
        '
        'btnCargoActivos
        '
        Me.btnCargoActivos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCargoActivos.FlatAppearance.BorderSize = 0
        Me.btnCargoActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCargoActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargoActivos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargoActivos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCargoActivos.Location = New System.Drawing.Point(0, 0)
        Me.btnCargoActivos.Name = "btnCargoActivos"
        Me.btnCargoActivos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCargoActivos.Size = New System.Drawing.Size(250, 40)
        Me.btnCargoActivos.TabIndex = 0
        Me.btnCargoActivos.Text = "Cargo de activos"
        Me.btnCargoActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargoActivos.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInventario.Image = CType(resources.GetObject("btnInventario.Image"), System.Drawing.Image)
        Me.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventario.Location = New System.Drawing.Point(0, 463)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInventario.Size = New System.Drawing.Size(250, 60)
        Me.btnInventario.TabIndex = 8
        Me.btnInventario.Text = "Activos"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'panelArticulos
        '
        Me.panelArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelArticulos.Controls.Add(Me.btnMarcas)
        Me.panelArticulos.Controls.Add(Me.btnControlArticulos)
        Me.panelArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelArticulos.Location = New System.Drawing.Point(0, 374)
        Me.panelArticulos.Name = "panelArticulos"
        Me.panelArticulos.Size = New System.Drawing.Size(250, 89)
        Me.panelArticulos.TabIndex = 7
        '
        'btnMarcas
        '
        Me.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarcas.FlatAppearance.BorderSize = 0
        Me.btnMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarcas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarcas.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMarcas.Location = New System.Drawing.Point(0, 40)
        Me.btnMarcas.Name = "btnMarcas"
        Me.btnMarcas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnMarcas.Size = New System.Drawing.Size(250, 40)
        Me.btnMarcas.TabIndex = 1
        Me.btnMarcas.Text = "Marcas"
        Me.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarcas.UseVisualStyleBackColor = True
        '
        'btnControlArticulos
        '
        Me.btnControlArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnControlArticulos.FlatAppearance.BorderSize = 0
        Me.btnControlArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnControlArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlArticulos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlArticulos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnControlArticulos.Location = New System.Drawing.Point(0, 0)
        Me.btnControlArticulos.Name = "btnControlArticulos"
        Me.btnControlArticulos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnControlArticulos.Size = New System.Drawing.Size(250, 40)
        Me.btnControlArticulos.TabIndex = 0
        Me.btnControlArticulos.Text = "Control de inventario"
        Me.btnControlArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnControlArticulos.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArticulos.FlatAppearance.BorderSize = 0
        Me.btnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnArticulos.Image = CType(resources.GetObject("btnArticulos.Image"), System.Drawing.Image)
        Me.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArticulos.Location = New System.Drawing.Point(0, 314)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnArticulos.Size = New System.Drawing.Size(250, 60)
        Me.btnArticulos.TabIndex = 6
        Me.btnArticulos.Text = "    Inventario"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'panelEmpleados
        '
        Me.panelEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelEmpleados.Controls.Add(Me.btnControlEmpleados)
        Me.panelEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEmpleados.Location = New System.Drawing.Point(0, 258)
        Me.panelEmpleados.Name = "panelEmpleados"
        Me.panelEmpleados.Size = New System.Drawing.Size(250, 56)
        Me.panelEmpleados.TabIndex = 5
        '
        'btnControlEmpleados
        '
        Me.btnControlEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnControlEmpleados.FlatAppearance.BorderSize = 0
        Me.btnControlEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnControlEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlEmpleados.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlEmpleados.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnControlEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.btnControlEmpleados.Name = "btnControlEmpleados"
        Me.btnControlEmpleados.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnControlEmpleados.Size = New System.Drawing.Size(250, 40)
        Me.btnControlEmpleados.TabIndex = 0
        Me.btnControlEmpleados.Text = "Control de empleados"
        Me.btnControlEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnControlEmpleados.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEmpleados.Image = CType(resources.GetObject("btnEmpleados.Image"), System.Drawing.Image)
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 198)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEmpleados.Size = New System.Drawing.Size(250, 60)
        Me.btnEmpleados.TabIndex = 4
        Me.btnEmpleados.Text = "      Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'panelUsuarios
        '
        Me.panelUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelUsuarios.Controls.Add(Me.btnControlUsuarios)
        Me.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelUsuarios.Location = New System.Drawing.Point(0, 151)
        Me.panelUsuarios.Name = "panelUsuarios"
        Me.panelUsuarios.Size = New System.Drawing.Size(250, 47)
        Me.panelUsuarios.TabIndex = 3
        '
        'btnControlUsuarios
        '
        Me.btnControlUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnControlUsuarios.FlatAppearance.BorderSize = 0
        Me.btnControlUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnControlUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlUsuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnControlUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.btnControlUsuarios.Name = "btnControlUsuarios"
        Me.btnControlUsuarios.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnControlUsuarios.Size = New System.Drawing.Size(250, 40)
        Me.btnControlUsuarios.TabIndex = 0
        Me.btnControlUsuarios.Text = "Control de usuarios"
        Me.btnControlUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnControlUsuarios.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 91)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(250, 60)
        Me.btnUsuarios.TabIndex = 2
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.Black
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.lblFecha)
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Controls.Add(Me.lblTipo)
        Me.PanelLogo.Controls.Add(Me.lblNombre)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 91)
        Me.PanelLogo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(203, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ver 1.0"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(95, 71)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(50, 17)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(95, 36)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(53, 17)
        Me.lblTipo.TabIndex = 2
        Me.lblTipo.Text = "Label2"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(95, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(53, 17)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Label1"
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelChildForm.Controls.Add(Me.panelTitleBar)
        Me.PanelChildForm.Controls.Add(Me.PictureBox2)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(1358, 840)
        Me.PanelChildForm.TabIndex = 1
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.Button1)
        Me.panelTitleBar.Controls.Add(Me.bntMinimize)
        Me.panelTitleBar.Controls.Add(Me.btnMaximize)
        Me.panelTitleBar.Controls.Add(Me.btnClose)
        Me.panelTitleBar.Controls.Add(Me.lblTitle)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(1358, 37)
        Me.panelTitleBar.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1217, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bntMinimize
        '
        Me.bntMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntMinimize.FlatAppearance.BorderSize = 0
        Me.bntMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntMinimize.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntMinimize.ForeColor = System.Drawing.Color.White
        Me.bntMinimize.Location = New System.Drawing.Point(1253, 3)
        Me.bntMinimize.Name = "bntMinimize"
        Me.bntMinimize.Size = New System.Drawing.Size(30, 30)
        Me.bntMinimize.TabIndex = 4
        Me.bntMinimize.Text = "—"
        Me.bntMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.Location = New System.Drawing.Point(1289, 3)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(30, 30)
        Me.btnMaximize.TabIndex = 3
        Me.btnMaximize.Text = "[ ]"
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1325, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(583, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(199, 27)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SILVERBACK BOX"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(287, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(826, 738)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1608, 840)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SilverBack Box"
        Me.PanelSideMenu.ResumeLayout(False)
        Me.panelInventario.ResumeLayout(False)
        Me.panelArticulos.ResumeLayout(False)
        Me.panelEmpleados.ResumeLayout(False)
        Me.panelUsuarios.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChildForm.ResumeLayout(False)
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents panelInventario As Panel
    Friend WithEvents btnDescargoActivos As Button
    Friend WithEvents btnCargoActivos As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents panelArticulos As Panel
    Friend WithEvents btnMarcas As Button
    Friend WithEvents btnControlArticulos As Button
    Friend WithEvents btnArticulos As Button
    Friend WithEvents panelEmpleados As Panel
    Friend WithEvents btnControlEmpleados As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnDepartamento As Button
    Friend WithEvents panelUsuarios As Panel
    Friend WithEvents btnControlUsuarios As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents bntMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPuesto As Button
End Class
