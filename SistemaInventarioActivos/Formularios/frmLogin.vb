Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class frmLogin

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub CustomizeComponents()
        'txtUsername
        UsernameTextBox.AutoSize = False
        UsernameTextBox.Size = New Size(350, 30)
        'txtPassword
        PasswordTextBox.AutoSize = False
        PasswordTextBox.Size = New Size(350, 30)
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub



    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then

            MsgBox("Por favor ingrese los datos", vbCritical, "Operación cancelada")

        Else

            Try

                conexion.Open()
                'Consultar a la base de datos Usuario en los txtusername y txtpassword
                adaptador = New SqlDataAdapter("SELECT * FROM Usuarios WHERE Usuario = '" & UsernameTextBox.Text & "' AND Password = '" & PasswordTextBox.Text & "'", conexion)
                'borrar todos los datos de la tabla consultada
                tabla.Clear()
                'dataset que va a generar
                adaptador.Fill(tabla)

                If tabla.Rows.Count = 1 Then

                    'Traer los datos en el formulario principal del usuario logeado y el tipo
                    Dim fila As DataRow = tabla.Rows(0)
                    nombre = Trim(fila("NombreCompleto").ToString)
                    tipousuario = Trim(fila("TipoUsuario").ToString)

                    'Mostrar la informacion en el formulario del nombre y tipo
                    frmDashboard.lblNombre.Text = nombre
                    frmDashboard.lblTipo.Text = tipousuario

                    'MsgBox("¡Ingresando al sistema!", vbInformation, "Operación completada")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Me.Hide()
                    frmDashboard.Show()

                Else

                    MsgBox("¡Nombre de usuario o contraseña invalidos!", vbExclamation, "Operación cancelada")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""

                End If
                'cerrar la conexion que se llama al principio de open en la base de datos
                conexion.Close()

            Catch ex As Exception

                MsgBox(ex.Message, vbCritical, "Error")

            End Try

        End If

    End Sub



    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles logoSBB.Click

        frmConfiguracion.Show()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeComponents()
        establecerconexion()
        UsernameTextBox.Padding = New Padding(20, 0, 0, 0)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles titleBar.Paint

    End Sub

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

End Class
