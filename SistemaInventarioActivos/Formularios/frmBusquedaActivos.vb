Imports System.Data.SqlClient
Public Class frmBusquedaActivos
    Private Sub frmBusquedaActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarDatos()
        txtBuscar.Focus()

    End Sub


    Sub LlenarDatos()

        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion, CargoActivos.EstadoArticulo, 
                      Articulos.NombreA, Articulos.IdArticulo,Articulos.PrecioCompra, Articulos.CodigoA,
                      Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado, Departamentos.NombreD 
                      FROM Articulos INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                      INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                                      INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento"
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
        frmDescargoActivos.txtIdArticulo.Text = CStr(dgvCargoActivos.Item("IdArticulo", dgvCargoActivos.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtCodigoI.Text = CStr(dgvCargoActivos.Item("CodigoInventario", dgvCargoActivos.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtNombreArticulo.Text = CStr(dgvCargoActivos.Item("NombreA", dgvCargoActivos.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtPrecio.Text = CStr(dgvCargoActivos.Item("PrecioCompra", dgvCargoActivos.CurrentCell.RowIndex).Value)
        'EMPLEADO'
        frmDescargoActivos.txtIdCargo.Text = CStr(dgvCargoActivos.Item("IdCargo", dgvCargoActivos.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtNumeroIdentidad.Text = CStr(dgvCargoActivos.Item("Identidad", dgvCargoActivos.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtNombreEmpleado.Text = CStr(dgvCargoActivos.Item("Nombre", dgvCargoActivos.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtDepartamento.Text = CStr(dgvCargoActivos.Item("NombreD", dgvCargoActivos.CurrentCell.RowIndex).Value)
        'CARGO ACTIVOS'
        frmDescargoActivos.dtpFechaEntrega.Text = CStr(dgvCargoActivos.Item("FechaAsignacion", dgvCargoActivos.CurrentCell.RowIndex).Value)
        Me.Close()

    End Sub
End Class