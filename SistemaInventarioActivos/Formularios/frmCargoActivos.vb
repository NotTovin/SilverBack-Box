Imports System.Data.SqlClient
Public Class frmCargoActivos
    Private Sub frmCargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCargoActivos.AutoGenerateColumns = False
        DesactivarControles()
        LlenarDatos()

        'llamar los datos de la tabla Articulos al form
        txtCodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigo.AutoCompleteCustomSource = ObtenerCodigo()

        'llamar los datos de la tabla Empleados al form
        txtNumeroIdentidad.AutoCompleteMode = AutoCompleteMode.Suggest
        txtNumeroIdentidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNumeroIdentidad.AutoCompleteCustomSource = ObtenerIdentidad()




    End Sub


    Sub DesactivarControles()
        'desactivar los botones 
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnCodigo.Enabled = False
        btnIdentidad.Enabled = False
        'desactivar los textbox
        txtCodigo.Enabled = False
        txtNombreArticulo.Enabled = False
        txtPrecio.Enabled = False
        txtNumeroIdentidad.Enabled = False
        txtNombreEmpleado.Enabled = False
        txtDepartamento.Enabled = False
        txtCodigoInventario.Enabled = False
        dtpFechaEntrega.Enabled = False
        cbEstadoActivo.Enabled = False
        txtDescripcion.Enabled = False

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControles()
        'Activar los botones 
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnCodigo.Enabled = True
        btnIdentidad.Enabled = True
        'Activar los textbox
        txtCodigo.Enabled = True
        txtNombreArticulo.Enabled = True
        txtPrecio.Enabled = True
        txtNumeroIdentidad.Enabled = True
        txtNombreEmpleado.Enabled = True
        txtDepartamento.Enabled = True
        txtCodigoInventario.Enabled = True
        dtpFechaEntrega.Enabled = True
        cbEstadoActivo.Enabled = True
        txtDescripcion.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtCodigo.Text = ""
        txtNombreArticulo.Text = ""
        txtPrecio.Text = ""
        txtNumeroIdentidad.Text = ""
        txtNombreEmpleado.Text = ""
        txtDepartamento.Text = ""
        txtCodigoInventario.Text = ""
        dtpFechaEntrega.Text = ""
        cbEstadoActivo.Text = ""
        txtDescripcion.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""
        txtIdArticulo.Text = ""
        txtIdEmpleado.Text = ""

    End Sub

    Private Function ObtenerCodigo() As AutoCompleteStringCollection

        adaptador = New SqlDataAdapter("SELECT CodigoA FROM Articulos WHERE EstadoArticulo = 'PENDIENTE'", obtenerconexion)
        Dim dt As New DataTable("Articulos")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection

        For Each row As DataRow In dt.Rows
            'convertir datos a string
            ListarDatos.Add(CStr(row(0)))
        Next

        Return ListarDatos

    End Function

    Private Function ObtenerIdentidad() As AutoCompleteStringCollection

        adaptador = New SqlDataAdapter("SELECT Identidad FROM Empleados ", obtenerconexion)
        Dim dt As New DataTable("Empleados")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection

        For Each row As DataRow In dt.Rows
            'convertir datos a string
            ListarDatos.Add(CStr(row(0)))
        Next

        Return ListarDatos

    End Function

    Sub Insertar()

        Dim sql As String
        Dim id As Integer

        If MsgBox("¿Guardar nuevo registro?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM CargoActivos Where CodigoInventario = '" & txtCodigoInventario.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then

            txtCodigoInventario.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("¡El código ya existe!", vbInformation, "Sistema de inventario")

            Exit Sub

        End If

        If txtIdArticulo.Text = "" Or txtIdEmpleado.Text = "" Or txtCodigoInventario.Text = "" Or dtpFechaEntrega.Text = "" Then


            MsgBox("Exiten campos vacios", vbInformation, "Sistema inventario")

            Exit Sub

        Else

            sql = "INSERT INTO CargoActivos(CodigoInventario,FechaAsignacion,EstadoArticulo,Descripcion,IdArticulo,IdEmpleado) VALUES ('" & txtCodigoInventario.Text & "', '" & dtpFechaEntrega.Text &
                                        "', '" & cbEstadoActivo.Text & "', '" & txtDescripcion.Text & "', '" & txtIdArticulo.Text & "', '" & txtIdEmpleado.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            'abrimos la base de datos
            conect.Open()
            'declaro variable comando, instancia de SQL command recibe 2 paramentos sql y conect la base de datos
            Using comando As New SqlCommand(sql, conect)

                id = comando.ExecuteScalar()

            End Using

            conect.Close()
            ModificarArticulo()
            MsgBox("¡Inventario ingresado!", vbInformation, "Sistema inventario")

        End If

    End Sub

    Sub ModificarArticulo()
        'Actualizar el estado del articulo cuando se entrega, en la tabla articulos
        Dim id As Integer

        Dim sql As String
        'para actualizar la base datos y agregar/editar la nueva informacion
        sql = "UPDATE Articulos SET EstadoArticulo = 'ENTREGADO' WHERE IdArticulo = '" & txtIdArticulo.Text & "'"

        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()

        Using comando As New SqlCommand(sql, conect)
            'funcion ejecuta la consulta
            id = comando.ExecuteScalar

        End Using

        conect.Close()

    End Sub

    Sub LlenarDatos()

        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion, CargoActivos.EstadoArticulo, 
                      Articulos.NombreA, Articulos.IdArticulo,Articulos.PrecioCompra, Articulos.CodigoA,
                      Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado, Departamentos.NombreD 
                      FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                      INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                      INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                      WHERE CargoActivos.EstadoArticulo <> 'ELIMINADO'"
        Try
            'tabla declarada solo para este proceso en vez de publica que esta en conexionDB
            Dim tabla As New DataTable
            'instansiar adaptador, recibe parametros sql, tabla en conectarDB recibe la nueva tabla y al dgv se le asigan todo lo que trae tabla
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvCargoActivos.DataSource = tabla
            'mostrar el total de usuarios
            lblTotalA.Text = tabla.Rows.Count

        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema inventario")

        End Try

    End Sub

    Sub Buscar()

        If rbEmpleado.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion, Articulos.NombreA, Articulos.IdArticulo,
                Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado, Departamentos.NombreD 
                FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                               INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                               INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                               WHERE Empleados.Nombre LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvCargoActivos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvCargoActivos.DataSource = ""

            End If

        End If

        If rbCodigo.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion, Articulos.NombreA, Articulos.IdArticulo,
                Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado, Departamentos.NombreD 
                FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                               INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                               INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                               WHERE CargoActivos.CodigoInventario LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvCargoActivos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvCargoActivos.DataSource = ""

            End If

        End If

        If rbNombreA.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion, Articulos.NombreA, Articulos.IdArticulo,
                Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado, Departamentos.NombreD 
                FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                               INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                               INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                               WHERE Articulos.NombreA LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvCargoActivos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvCargoActivos.DataSource = ""

            End If

        End If

        If rbDepartamento.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion, Articulos.NombreA, Articulos.IdArticulo,
                Articulos.PrecioCompra, Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado, Departamentos.NombreD 
                FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                               INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                               INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                               WHERE Departamentos.NombreD LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvCargoActivos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvCargoActivos.DataSource = ""

            End If

        End If

    End Sub

    Sub Editar()


        Dim id As Integer

        If txtId.Text = "" Then

            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")

        Else

            Dim sql As String
            'para actualizar la base datos y agregar/editar la nueva informacion
            sql = "UPDATE CargoActivos SET CodigoInventario = '" & txtCodigoInventario.Text & "', FechaAsignacion = '" & dtpFechaEntrega.Text & "', EstadoArticulo = '" & cbEstadoActivo.Text &
                                                 "', Descripcion = '" & txtDescripcion.Text & "', IdArticulo = '" & txtIdArticulo.Text & "', IdEmpleado = '" & txtIdEmpleado.Text &
                                                 "'WHERE IdCargo = '" & txtId.Text & "'"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()

            Using comando As New SqlCommand(sql, conect)
                'funcion ejecuta la consulta
                id = comando.ExecuteScalar

            End Using

            conect.Close()
            MsgBox("¡Modificado con éxito!", vbInformation, "Sistema de inventario")
            LimpiarControles()

        End If


    End Sub

    Sub Eliminar()

        Dim id As Integer

        If txtId.Text = "" Then

            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")

        Else

            If MsgBox("¿Está seguro de eliminar " + Trim(txtNombreArticulo.Text) + " del registro?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else

                Dim sql As String
                'borrar por completo el usuario de la base de datos
                sql = "DELETE FROM CargoActivos WHERE IdCargo = " & Trim(txtId.Text)
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
                ModificarArticuloPendiente()
                MsgBox("¡Activo " + Trim(txtNombreArticulo.Text) + " eliminado del registro!", vbInformation, "Sistema de inventario")
                LimpiarControles()

            End If
        End If

    End Sub

    Sub ModificarArticuloPendiente()
        'Actualizar el estado del articulo cuando se entrega, en la tabla articulos
        Dim id As Integer

        Dim sql As String
        'para actualizar la base datos y agregar/editar la nueva informacion
        sql = "UPDATE Articulos SET EstadoArticulo = 'PENDIENTE' WHERE IdArticulo = '" & txtIdArticulo.Text & "'"

        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()

        Using comando As New SqlCommand(sql, conect)
            'funcion ejecuta la consulta
            id = comando.ExecuteScalar

        End Using

        conect.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        ActivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        DesactivarControles()
        LimpiarControles()

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

        If txtCodigo.Text <> "" Then

            adaptador = New SqlDataAdapter("SELECT IdArticulo,NombreA,PrecioCompra FROM Articulos WHERE CodigoA = '" & txtCodigo.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            'Limpiar
            tabla.Clear()
            'actualizar y llenar
            adaptador.Fill(tabla)

            If tabla.Rows.Count = 1 Then

                Dim fila As DataRow = tabla.Rows(0)
                'Devolver el objeto selecciona en la tabla de Articulos y se la asignamos a la caja de texto respectiva
                txtNombreArticulo.Text = fila("NombreA").ToString
                txtPrecio.Text = fila("PrecioCompra").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString

            Else

                txtNombreArticulo.Clear()
                txtPrecio.Clear()
                txtCodigo.Focus()

            End If

        End If

    End Sub

    Private Sub txtNumeroIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroIdentidad.TextChanged

        If txtNumeroIdentidad.Text <> "" Then

            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado,Empleados.Nombre,Departamentos.NombreD 
                                            FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                            WHERE Identidad = '" & txtNumeroIdentidad.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            'Limpiar
            tabla.Clear()
            'actualizar y llenar
            adaptador.Fill(tabla)

            If tabla.Rows.Count = 1 Then

                Dim fila As DataRow = tabla.Rows(0)
                'Devolver el objeto selecciona en la tabla de Articulos y se la asignamos a la caja de texto respectiva
                txtNombreEmpleado.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                txtIdEmpleado.Text = fila("IdEmpleado").ToString

            Else

                txtNombreEmpleado.Clear()
                txtIdEmpleado.Clear()
                txtNumeroIdentidad.Focus()

            End If

        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Insertar()
        LlenarDatos()
        DesactivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnCodigo_Click(sender As Object, e As EventArgs) Handles btnCodigo.Click

        frmBusquedaArticulos.ShowDialog()

    End Sub

    Private Sub btnIdentidad_Click(sender As Object, e As EventArgs) Handles btnIdentidad.Click

        frmBusquedaEmpleados.ShowDialog()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Buscar()

    End Sub

    Private Sub rbNombreA_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreA.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub rbEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpleado.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub dgvCargoActivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargoActivos.CellDoubleClick

        'se va a transferir el error y el sistema continua normal
        On Error Resume Next
        'pasar la informacion del grid al txtID box
        'ARTICULO'
        txtIdArticulo.Text = CStr(dgvCargoActivos.Item("IdArticulo", dgvCargoActivos.CurrentCell.RowIndex).Value)
        'txtCodigo.Text = CStr(dgvCargoActivos.Item("CodigoA", dgvCargoActivos.CurrentCell.RowIndex).Value)
        txtCodigo.Text = CStr(dgvCargoActivos.Item("CodigoInventario", dgvCargoActivos.CurrentCell.RowIndex).Value)
        txtNombreArticulo.Text = CStr(dgvCargoActivos.Item("NombreA", dgvCargoActivos.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvCargoActivos.Item("PrecioCompra", dgvCargoActivos.CurrentCell.RowIndex).Value)
        'EMPLEADO'
        txtIdEmpleado.Text = CStr(dgvCargoActivos.Item("IdEmpleado", dgvCargoActivos.CurrentCell.RowIndex).Value)
        txtNumeroIdentidad.Text = CStr(dgvCargoActivos.Item("Identidad", dgvCargoActivos.CurrentCell.RowIndex).Value)
        txtNombreEmpleado.Text = CStr(dgvCargoActivos.Item("Nombre", dgvCargoActivos.CurrentCell.RowIndex).Value)
        txtDepartamento.Text = CStr(dgvCargoActivos.Item("NombreD", dgvCargoActivos.CurrentCell.RowIndex).Value)
        'CARGO ACTIVOS'
        txtId.Text = CStr(dgvCargoActivos.Item("IdCargo", dgvCargoActivos.CurrentCell.RowIndex).Value)
        txtCodigoInventario.Text = CStr(dgvCargoActivos.Item("CodigoInventario", dgvCargoActivos.CurrentCell.RowIndex).Value)
        dtpFechaEntrega.Text = CStr(dgvCargoActivos.Item("FechaAsignacion", dgvCargoActivos.CurrentCell.RowIndex).Value)
        cbEstadoActivo.Text = CStr(dgvCargoActivos.Item("EstadoArticulo", dgvCargoActivos.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvCargoActivos.Item("Descripcion", dgvCargoActivos.CurrentCell.RowIndex).Value)


        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False
        btnCodigo.Enabled = True
        btnIdentidad.Enabled = True

        txtCodigo.Enabled = True
        txtNumeroIdentidad.Enabled = True
        txtCodigo.Enabled = True
        txtCodigoInventario.Enabled = True
        dtpFechaEntrega.Enabled = True
        cbEstadoActivo.Enabled = True
        txtDescripcion.Enabled = True

        txtCodigo.Focus()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If UCase(tipousuario) = "ADMINISTRADOR" Then

            Editar()
            DesactivarControles()
            LlenarDatos()

        Else

            MsgBox("No tiene los privilegios para modificar la información", vbExclamation, "Operación cancelada")

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If UCase(tipousuario) = "ADMINISTRADOR" Then

            Eliminar()
            DesactivarControles()
            LlenarDatos()

        Else

            MsgBox("No tiene los privilegios para modificar la información", vbExclamation, "Operación cancelada")

        End If

    End Sub

    Private Sub pbReturn_Click(sender As Object, e As EventArgs) Handles pbReturn.Click
        Me.Close()
    End Sub


End Class
