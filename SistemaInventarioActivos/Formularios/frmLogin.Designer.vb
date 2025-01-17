<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmLogin
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
    Friend WithEvents logoSBB As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.titleBar = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logoSBB = New System.Windows.Forms.PictureBox()
        Me.titleBar.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoSBB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(26, 292)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(26, 368)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(286, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.DimGray
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.White
        Me.UsernameTextBox.Location = New System.Drawing.Point(30, 318)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(350, 26)
        Me.UsernameTextBox.TabIndex = 1
        Me.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.DimGray
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.White
        Me.PasswordTextBox.Location = New System.Drawing.Point(30, 394)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(350, 26)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.DimGray
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(30, 452)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(350, 64)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Iniciar sesión"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'titleBar
        '
        Me.titleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.titleBar.Controls.Add(Me.btnMinimizar)
        Me.titleBar.Controls.Add(Me.btnCerrar)
        Me.titleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleBar.Location = New System.Drawing.Point(0, 0)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(420, 50)
        Me.titleBar.TabIndex = 8
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = Global.SistemaInventarioActivos.My.Resources.Resources.Programming_Minimize_Window_icon
        Me.btnMinimizar.Location = New System.Drawing.Point(363, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(24, 24)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 11
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.SistemaInventarioActivos.My.Resources.Resources.delete_icon__1_
        Me.btnCerrar.Location = New System.Drawing.Point(393, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 618)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 15)
        Me.Panel2.TabIndex = 9
        '
        'logoSBB
        '
        Me.logoSBB.Image = CType(resources.GetObject("logoSBB.Image"), System.Drawing.Image)
        Me.logoSBB.Location = New System.Drawing.Point(108, 81)
        Me.logoSBB.Margin = New System.Windows.Forms.Padding(1)
        Me.logoSBB.Name = "logoSBB"
        Me.logoSBB.Size = New System.Drawing.Size(216, 181)
        Me.logoSBB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoSBB.TabIndex = 0
        Me.logoSBB.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 633)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.titleBar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.logoSBB)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.titleBar.ResumeLayout(False)
        Me.titleBar.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoSBB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As Button
    Friend WithEvents titleBar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
End Class
