Imports System.Data.SqlClient

Public Class frmUsuarios

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DesactivarControles()
        LlenarDatos()
        dgvUsuarios.AutoGenerateColumns = False

    End Sub

    Sub DesactivarControles()
        'desactivar los botones 
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        'desactivar los textbox
        txtNombreC.Enabled = False
        txtUsuario.Enabled = False
        txtContraseña.Enabled = False
        cboTipoUser.Enabled = False
        cboEstado.Enabled = False

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControles()
        'Activar los botones 
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        'Activar los textbox
        txtNombreC.Enabled = True
        txtUsuario.Enabled = True
        txtContraseña.Enabled = True
        cboTipoUser.Enabled = True
        cboEstado.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreC.Text = ""
        txtContraseña.Text = ""
        txtUsuario.Text = ""
        cboEstado.Text = ""
        cboTipoUser.Text = ""
        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub

    Sub Insertar()

        Dim sql As String
        Dim id As Integer

        If MsgBox("¿Está seguro de ingresar " + Trim(txtUsuario.Text) + " al sistema?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Usuarios Where Usuario = '" & txtUsuario.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then

            txtUsuario.Text = tabla.Rows(0).Item("Usuario")
            MsgBox("¡El usuario ya existe!", vbInformation, "Sistema de inventario")

            Exit Sub

        End If

        If txtNombreC.Text = "" Or txtUsuario.Text = "" Or txtContraseña.Text = "" Or cboTipoUser.Text = "" Or cboEstado.Text = "" Then

            MsgBox("Exiten campos vacios", vbInformation, "Sistema inventario")

            Exit Sub

        Else

            sql = "INSERT INTO Usuarios(NombreCompleto,Usuario,Password,TipoUsuario,Estado) VALUES('" & txtNombreC.Text & "', '" & txtUsuario.Text & "', '" & txtContraseña.Text & "','" & cboTipoUser.Text & "','" & cboEstado.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)

                id = comando.ExecuteScalar()

            End Using

            conect.Close()
            MsgBox("¡Usuario " + Trim(txtUsuario.Text) + " exitoso!", vbInformation, "Sistema inventario")

        End If

    End Sub

    Sub LlenarDatos()

        Dim sql As String
        sql = "SELECT * FROM Usuarios"
        Try
            'tabla declarada solo para este proceso en vez de publica que esta en conexionDB
            Dim tabla As New DataTable
            'instansiar adaptador, recibe parametros sql, tabla en conectarDB recibe la nueva tabla y al dgv se le asigan todo lo que trae tabla
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvUsuarios.DataSource = tabla
            'mostrar el total de usuarios
            lblTotalUsuarios.Text = tabla.Rows.Count

        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema inventario")

        End Try

    End Sub

    Sub Editar()

        Dim id As Integer

        If txtId.Text = "" Or txtNombreC.Text = "" Or txtUsuario.Text = "" Or txtContraseña.Text = "" Or cboTipoUser.Text = "" Or cboEstado.Text = "" Then

            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")

        Else

            Dim sql As String
            'para actualizar la base datos y agregar/editar la nueva informacion
            sql = "UPDATE Usuarios SET NombreCompleto = '" & txtNombreC.Text & "', Usuario = '" & txtUsuario.Text & "', Password= '" & txtContraseña.Text & "',
                                                        TipoUsuario = '" & cboTipoUser.Text & "', Estado = '" & cboEstado.Text & "' WHERE IdUsuario = '" & txtId.Text & "'"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()

            Using comando As New SqlCommand(sql, conect)
                'funcion ejecuta la consulta
                id = comando.ExecuteScalar

            End Using

            conect.Close()
            MsgBox("¡Ingreso exitoso!", vbInformation, "Sistema de inventario")
            LimpiarControles()

        End If

    End Sub

    Sub Eliminar()

        Dim id As Integer

        If txtId.Text = "" Or txtNombreC.Text = "" Or txtUsuario.Text = "" Or txtContraseña.Text = "" Or cboTipoUser.Text = "" Or cboEstado.Text = "" Then

            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")

        Else

            If MsgBox("¿Está seguro de eliminar " + Trim(txtUsuario.Text) + " del registro?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else

                Dim sql As String
                'borrar por completo el usuario de la base de datos
                sql = "DELETE FROM Usuarios WHERE IdUsuario = " & Trim(txtId.Text)

                Dim conect As New SqlConnection(obtenerconexion)
                'abrir la conexion de la base de datos
                conect.Open()

                Using comando As New SqlCommand(sql, conect)
                    'funcion ejecuta la consulta  a travez de comando
                    id = comando.ExecuteScalar

                End Using
                'cierra la conexion de la base de datos
                conect.Close()
                MsgBox("¡Usuario " + Trim(txtUsuario.Text) + " eliminado del registro!", vbInformation, "Sistema de inventario")
                LimpiarControles()

            End If
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        ActivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Insertar()
        LlenarDatos()
        DesactivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        DesactivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Editar()
        DesactivarControles()
        LlenarDatos()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Eliminar()
        DesactivarControles()
        LlenarDatos()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'extraer la busqueda de buscar con el LIKE
        If txtBuscar.Text = "" Then

            LlenarDatos()

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Usuarios WHERE NombreCompleto LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then

            dgvUsuarios.DataSource = tabla
            lblTotalUsuarios.Text = tabla.Rows.Count

        Else

            dgvUsuarios.DataSource = ""

        End If
    End Sub

    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        'se va a transferir el error y el sistema continua normal
        On Error Resume Next
        'pasar la informacion del grid al txtID box
        txtId.Text = CStr(dgvUsuarios.Item("IdUsuario", dgvUsuarios.CurrentCell.RowIndex).Value)
        txtNombreC.Text = CStr(dgvUsuarios.Item("NombreCompleto", dgvUsuarios.CurrentCell.RowIndex).Value)
        txtUsuario.Text = CStr(dgvUsuarios.Item("Usuario", dgvUsuarios.CurrentCell.RowIndex).Value)
        txtContraseña.Text = CStr(dgvUsuarios.Item("Password", dgvUsuarios.CurrentCell.RowIndex).Value)
        cboTipoUser.Text = CStr(dgvUsuarios.Item("TipoUsuario", dgvUsuarios.CurrentCell.RowIndex).Value)
        cboEstado.Text = CStr(dgvUsuarios.Item("Estado", dgvUsuarios.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        txtNombreC.Enabled = True
        txtUsuario.Enabled = True
        txtContraseña.Enabled = True
        cboTipoUser.Enabled = True
        cboEstado.Enabled = True
        txtNombreC.Focus()


    End Sub

    Private Sub pbReturn_Click(sender As Object, e As EventArgs) Handles pbReturn.Click
        Me.Close()
    End Sub
End Class