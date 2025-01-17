Imports System.Data.SqlClient
Public Class frmDescargoActivos
    Private Sub frmDescargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvDescargoActivos.AutoGenerateColumns = False
        DesactivarControles()
        LlenarDatos()


        'LLAMA TODOS LOS DATOS DE LA TABLA AL FORM'
        txtCodigoI.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigoI.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigoI.AutoCompleteCustomSource = obtenerCodigoInventario()

    End Sub



    Sub DesactivarControles()
        'DESACTIVAR BOTONES' 
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnCargos.Enabled = False

        'DESACTIVAR TEXTBOX'
        txtCodigoI.Enabled = False
        txtNombreArticulo.Enabled = False
        txtPrecio.Enabled = False
        txtNumeroIdentidad.Enabled = False
        txtNombreEmpleado.Enabled = False
        txtDepartamento.Enabled = False
        dtpFechaDescargo.Enabled = False
        cbMotivo.Enabled = False
        txtDescripcion.Enabled = False

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControles()
        'ACTIVAR BOTONES'
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnCargos.Enabled = True

        'ACTIVAR TEXTBOX'
        txtCodigoI.Enabled = True
        txtNombreArticulo.Enabled = True
        txtPrecio.Enabled = True
        txtNumeroIdentidad.Enabled = True
        txtNombreEmpleado.Enabled = True
        txtDepartamento.Enabled = True
        dtpFechaEntrega.Enabled = False
        dtpFechaDescargo.Enabled = True
        cbMotivo.Enabled = True
        txtDescripcion.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()
        'LIMPIAR TODOS LOS DATOS'
        txtCodigoI.Text = ""
        txtNombreArticulo.Text = ""
        txtPrecio.Text = ""
        txtNumeroIdentidad.Text = ""
        txtNombreEmpleado.Text = ""
        txtDepartamento.Text = ""
        dtpFechaDescargo.Text = ""
        dtpFechaEntrega.Text = ""
        cbMotivo.Text = ""
        txtDescripcion.Text = ""
        'ID DE LAS BD'
        txtId.Text = ""
        txtBuscar.Text = ""
        txtIdArticulo.Text = ""
        txtIdCargo.Text = ""

    End Sub

    Private Function obtenerCodigoInventario() As AutoCompleteStringCollection

        adaptador = New SqlDataAdapter("SELECT CodigoInventario FROM CargoActivos WHERE EstadoArticulo <> 'ELIMINADO'", obtenerconexion)
        Dim dt As New DataTable("CargoActivos")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection

        For Each row As DataRow In dt.Rows
            'CONVIERTE LOS DATOS A STRING'
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

        adaptador = New SqlDataAdapter("SELECT CargoActivos.CodigoInventario FROM CargoActivos 
                                                    INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo
                                                Where CargoActivos.CodigoInventario = '" & txtCodigoI.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then

            txtCodigoI.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("¡El registo ya existe!", vbInformation, "Sistema de inventario")

            Exit Sub

        End If

        If txtIdArticulo.Text = "" Or txtIdCargo.Text = "" Or dtpFechaDescargo.Text = "" Or cbMotivo.Text = "" Then


            MsgBox("Exiten campos vacios", vbInformation, "Sistema inventario")

            Exit Sub

        Else

            sql = "INSERT INTO DescargoActivos(FechaDescargo,Descripcion,MotivoDescargo,IdCargoActivo) VALUES ('" & dtpFechaDescargo.Text & "', '" & txtDescripcion.Text &
                                        "', '" & cbMotivo.Text & "', '" & txtIdCargo.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            'abrimos la base de datos
            conect.Open()
            'declaro variable comando, instancia de SQL command recibe 2 paramentos sql y conect la base de datos
            Using comando As New SqlCommand(sql, conect)

                id = comando.ExecuteScalar()

            End Using

            conect.Close()

            MsgBox("¡Registo ingresado!", vbInformation, "Sistema inventario")

        End If

    End Sub

    Sub EliminarCargo()

        Dim id As Integer

        Dim sql As String
        'borrar por completo el usuario de la base de datos
        sql = "UPDATE CargoActivos SET EstadoArticulo = 'ELIMINADO' WHERE IdCargo = " & Trim(txtIdCargo.Text)

        Dim conect As New SqlConnection(obtenerconexion)
        'abrir la conexion de la base de datos
        conect.Open()

        Using comando As New SqlCommand(sql, conect)
            'funcion ejecuta la consulta  a travez de comando
            id = comando.ExecuteScalar

        End Using
        'cierra la conexion de la base de datos
        conect.Close()


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

    Sub ModificarArticuloDefectuoso()
        'Actualizar el estado del articulo cuando se entrega, en la tabla articulos
        Dim id As Integer

        Dim sql As String
        'para actualizar la base datos y agregar/editar la nueva informacion
        sql = "UPDATE Articulos SET EstadoArticulo = 'NO FUNCIONA' WHERE IdArticulo = '" & txtIdArticulo.Text & "'"

        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()

        Using comando As New SqlCommand(sql, conect)
            'funcion ejecuta la consulta
            id = comando.ExecuteScalar

        End Using

        conect.Close()

    End Sub

    Sub Buscar()

        If rbEmpleado.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, 
                                                    Articulos.NombreA, Articulos.IdArticulo,Articulos.PrecioCompra,
                                                    Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD,
                                                    DescargoActivos.IdDescargo, DescargoActivos.FechaDescargo, DescargoActivos.MotivoDescargo, DescargoActivos.Descripcion
                                                    FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                                                    INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                                                    INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                                                                    INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo
                                                    WHERE Empleados.Nombre LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvDescargoActivos.DataSource = tabla
                lblTotalD.Text = tabla.Rows.Count

            Else

                dgvDescargoActivos.DataSource = ""

            End If

        End If

        If rbCodigo.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, 
                                                    Articulos.NombreA, Articulos.IdArticulo,Articulos.PrecioCompra,
                                                    Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD,
                                                    DescargoActivos.IdDescargo, DescargoActivos.FechaDescargo, DescargoActivos.MotivoDescargo, DescargoActivos.Descripcion
                                                    FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                                                   INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                                                   INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                                                                   INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo
                                                    WHERE CargoActivos.CodigoInventario LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)

            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvDescargoActivos.DataSource = tabla
                lblTotalD.Text = tabla.Rows.Count

            Else

                dgvDescargoActivos.DataSource = ""

            End If

        End If

        If rbNombreA.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, 
                                                    Articulos.NombreA, Articulos.IdArticulo,Articulos.PrecioCompra,
                                                    Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD,
                                                    DescargoActivos.IdDescargo, DescargoActivos.FechaDescargo, DescargoActivos.MotivoDescargo, DescargoActivos.Descripcion
                                                    FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                                                   INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                                                   INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                                                                   INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo
                                                    WHERE Articulos.NombreA LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)

            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvDescargoActivos.DataSource = tabla
                lblTotalD.Text = tabla.Rows.Count

            Else

                dgvDescargoActivos.DataSource = ""

            End If

        End If

        If rbDepartamento.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, 
                                                      Articulos.NombreA, Articulos.IdArticulo,Articulos.PrecioCompra,
                                                      Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD,
                                                      DescargoActivos.IdDescargo, DescargoActivos.FechaDescargo, DescargoActivos.MotivoDescargo, DescargoActivos.Descripcion
                                                      FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                                                     INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                                                     INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                                                                     INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo
                                                      WHERE Departamentos.NombreD LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)

            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvDescargoActivos.DataSource = tabla
                lblTotalD.Text = tabla.Rows.Count

            Else

                dgvDescargoActivos.DataSource = ""

            End If

        End If

    End Sub

    Sub LlenarDatos()

        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, 
                      Articulos.NombreA, Articulos.IdArticulo,Articulos.PrecioCompra,
                      Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD,
                      DescargoActivos.IdDescargo, DescargoActivos.FechaDescargo, DescargoActivos.MotivoDescargo, DescargoActivos.Descripcion
                      FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                      INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                      INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                                      INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivo"
        Try
            'tabla declarada solo para este proceso en vez de publica que esta en conexionDB
            Dim tabla As New DataTable
            'instansiar adaptador, recibe parametros sql, tabla en conectarDB recibe la nueva tabla y al dgv se le asigan todo lo que trae tabla
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvDescargoActivos.DataSource = tabla
            'mostrar el total de usuarios
            lblTotalD.Text = tabla.Rows.Count

        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema inventario")

        End Try

    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        ActivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        DesactivarControles()
        LimpiarControles()

    End Sub

    Private Sub txtCodigoI_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoI.TextChanged

        If txtCodigoI.Text <> "" Then

            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.FechaAsignacion, Articulos.IdArticulo, Articulos.NombreA, Articulos.PrecioCompra,
                                                   Empleados.Nombre, Empleados.Identidad, Departamentos.NombreD 
                                                   FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                                                   INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                                                   INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                                                   WHERE CargoActivos.CodigoInventario = '" & txtCodigoI.Text & "' ", obtenerconexion)
            Dim tabla As New DataTable
            'LIMPAR TODA LA INFO EN LA TABLA'
            tabla.Clear()
            'ACTUALIZAR Y LLENAR'
            adaptador.Fill(tabla)

            If tabla.Rows.Count = 1 Then

                Dim fila As DataRow = tabla.Rows(0)
                'Devolver el objeto selecciona en la tabla de Articulos y se la asignamos a la caja de texto respectiva
                txtNombreArticulo.Text = fila("NombreA").ToString
                txtPrecio.Text = fila("PrecioCompra").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString
                txtNumeroIdentidad.Text = fila("Identidad").ToString
                txtNombreEmpleado.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                dtpFechaEntrega.Text = fila("FechaAsignacion").ToString
                txtIdCargo.Text = fila("IdCargo").ToString

            Else

                txtNombreArticulo.Clear()
                txtPrecio.Clear()
                txtIdArticulo.Clear()
                txtNumeroIdentidad.Clear()
                txtNombreEmpleado.Clear()
                txtDepartamento.Clear()
                dtpFechaEntrega.Text = ""
                txtIdCargo.Clear()

                txtCodigoI.Focus()

            End If

        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If cbMotivo.Text = "Obsoleto" Then

            Insertar()
            EliminarCargo()
            ModificarArticuloDefectuoso()
            LlenarDatos()
            DesactivarControles()
            LimpiarControles()

        Else

            Insertar()
            EliminarCargo()
            ModificarArticuloPendiente()
            LlenarDatos()
            DesactivarControles()
            LimpiarControles()

        End If

    End Sub

    Private Sub btnCargos_Click(sender As Object, e As EventArgs) Handles btnCargos.Click

        frmBusquedaActivos.ShowDialog()

    End Sub

    Private Sub pbReturn_Click(sender As Object, e As EventArgs) Handles pbReturn.Click

        Me.Close()

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

    Private Sub dgvDescargoActivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescargoActivos.CellDoubleClick

        'se va a transferir el error y el sistema continua normal
        On Error Resume Next
        'pasar la informacion del grid al txtID box
        'ARTICULO'
        txtIdArticulo.Text = CStr(dgvDescargoActivos.Item("IdArticulo", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        txtCodigoI.Text = CStr(dgvDescargoActivos.Item("CodigoInventario", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        txtNombreArticulo.Text = CStr(dgvDescargoActivos.Item("NombreA", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvDescargoActivos.Item("PrecioCompra", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        'EMPLEADO'
        txtIdCargo.Text = CStr(dgvDescargoActivos.Item("IdCargo", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        txtNumeroIdentidad.Text = CStr(dgvDescargoActivos.Item("Identidad", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        txtNombreEmpleado.Text = CStr(dgvDescargoActivos.Item("Nombre", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        txtDepartamento.Text = CStr(dgvDescargoActivos.Item("NombreD", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        'CARGO ACTIVOS'
        txtId.Text = CStr(dgvDescargoActivos.Item("IdDescargo", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        dtpFechaDescargo.Text = CStr(dgvDescargoActivos.Item("FechaDescargo", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        dtpFechaEntrega.Text = CStr(dgvDescargoActivos.Item("FechaAsignacion", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        cbMotivo.Text = CStr(dgvDescargoActivos.Item("MotivoDescargo", dgvDescargoActivos.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvDescargoActivos.Item("Descripcion", dgvDescargoActivos.CurrentCell.RowIndex).Value)


        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnCargos.Enabled = True


        txtCodigoI.Enabled = True
        dtpFechaDescargo.Enabled = True
        cbMotivo.Enabled = True
        txtDescripcion.Enabled = True

        txtCodigoI.Focus()

    End Sub



End Class