Imports System.Data.SqlClient

Public Class frmPuestos
    Private Sub frmPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DesactivarControles()
        tamañoformulario()
        LlenarDatos()

    End Sub

    Sub DesactivarControles()
        'desactivar los botones 
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        'desactivar los textbox
        txtNombrePuesto.Enabled = False
        txtDescripcionP.Enabled = False

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControles()
        'Activar los botones 
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        'Activar los textbox
        txtNombrePuesto.Enabled = True
        txtDescripcionP.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombrePuesto.Text = ""
        txtDescripcionP.Text = ""
        txtID.Text = ""
        txtBuscar.Text = ""

    End Sub

    Sub tamañoformulario()

        'Width = 450
        'Height = 352

        Panel1.Visible = False

    End Sub

    Sub tamañoformulariobuscar()

        'Width = 450
        'Height = 689

        Panel1.Visible = True

    End Sub

    Sub Insertar()

        Dim sql As String
        Dim id As Integer

        If MsgBox("¿Está seguro de ingresar " + Trim(txtNombrePuesto.Text) + " al sistema?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Puestos Where NombrePuesto = '" & txtNombrePuesto.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then

            txtNombrePuesto.Text = tabla.Rows(0).Item("NombrePuesto")
            MsgBox("¡El puesto ya existe!", vbInformation, "Sistema de inventario")

            Exit Sub

        End If

        If txtNombrePuesto.Text = "" Or txtDescripcionP.Text = "" Then

            MsgBox("Exiten campos vacios", vbInformation, "Sistema inventario")

            Exit Sub

        Else

            sql = "INSERT INTO Puestos(NombrePuesto,DescripcionP) VALUES('" & txtNombrePuesto.Text & "', '" & txtDescripcionP.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            'abrimos la base de datos
            conect.Open()
            'declaro variable comando, instancia de SQL command recibe 2 paramentos sql y conect la base de datos
            Using comando As New SqlCommand(sql, conect)

                id = comando.ExecuteScalar()

            End Using

            conect.Close()
            MsgBox("¡Puesto " + Trim(txtNombrePuesto.Text) + " ingresado!", vbInformation, "Sistema inventario")

        End If

    End Sub

    Sub LlenarDatos()

        Dim sql As String
        sql = "SELECT * FROM Puestos"
        Try
            'tabla declarada solo para este proceso en vez de publica que esta en conexionDB
            Dim tabla As New DataTable
            'instansiar adaptador, recibe parametros sql, tabla en conectarDB recibe la nueva tabla y al dgv se le asigan todo lo que trae tabla
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvPuestos.DataSource = tabla
            'mostrar el total de usuarios
            lblTotalP.Text = tabla.Rows.Count

        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema inventario")

        End Try

    End Sub

    Sub Editar()

        Dim id As Integer

        If txtID.Text = "" Then

            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")

        Else

            Dim sql As String
            'para actualizar la base datos y agregar/editar la nueva informacion
            sql = "UPDATE Puestos SET NombrePuesto = '" & txtNombrePuesto.Text & "', DescripcionP = '" & txtDescripcionP.Text & "' WHERE IdPuesto = '" & txtID.Text & "'"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()

            Using comando As New SqlCommand(sql, conect)
                'funcion ejecuta la consulta
                id = comando.ExecuteScalar

            End Using

            conect.Close()
            MsgBox("¡Modificado con exito!", vbInformation, "Sistema de inventario")
            LimpiarControles()

        End If

    End Sub

    Sub Eliminar()

        Dim id As Integer

        If txtID.Text = "" Then

            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")

        Else

            If MsgBox("¿Está seguro de eliminar " + Trim(txtNombrePuesto.Text) + " del registro?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else

                Dim sql As String
                'borrar por completo el usuario de la base de datos
                sql = "DELETE FROM Puestos WHERE IdPuesto = " & Trim(txtID.Text)
                'DELETE FROM Departamentos WHERE NombreD

                Dim conect As New SqlConnection(obtenerconexion)
                'abrir la conexion de la base de datos
                conect.Open()

                Using comando As New SqlCommand(sql, conect)
                    'funcion ejecuta la consulta  a travez de comando
                    id = comando.ExecuteScalar

                End Using
                'cierra la conexion de la base de datos
                conect.Close()
                MsgBox("¡Puesto " + Trim(txtNombrePuesto.Text) + " eliminado del registro!", vbInformation, "Sistema de inventario")
                LimpiarControles()

            End If
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        ActivarControles()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Insertar()
        LlenarDatos()
        DesactivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Editar()
        DesactivarControles()
        LlenarDatos()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        tamañoformulariobuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False

        txtBuscar.Focus()
        'txtBuscar.BackColor = Color.YellowGreen

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Eliminar()
        DesactivarControles()
        LlenarDatos()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        tamañoformulario()
        LimpiarControles()
        DesactivarControles()
        Panel1.Visible = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        If txtBuscar.Text = "" Then

            LlenarDatos()

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Puestos WHERE NombrePuesto LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
        'adaptador = New SqlDataAdapter("SELECT * FROM Departamentos WHERE NombreD LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then

            dgvPuestos.DataSource = tabla
            lblTotalP.Text = tabla.Rows.Count

        Else

            dgvPuestos.DataSource = ""

        End If

    End Sub

    Private Sub dgvPuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPuestos.CellDoubleClick

        'se va a transferir el error y el sistema continua normal
        On Error Resume Next
        'pasar la informacion del grid al txtID box
        txtID.Text = CStr(dgvPuestos.Item("IdPuesto", dgvPuestos.CurrentCell.RowIndex).Value)
        txtNombrePuesto.Text = CStr(dgvPuestos.Item("NombrePuesto", dgvPuestos.CurrentCell.RowIndex).Value)
        txtDescripcionP.Text = CStr(dgvPuestos.Item("DescripcionP", dgvPuestos.CurrentCell.RowIndex).Value)


        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        txtNombrePuesto.Enabled = True
        txtDescripcionP.Enabled = True
        txtNombreP.Focus()

    End Sub

    Private Sub pbReturn_Click(sender As Object, e As EventArgs) Handles pbReturn.Click
        Me.Close()
    End Sub
End Class