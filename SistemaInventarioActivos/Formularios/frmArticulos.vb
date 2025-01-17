
Imports System.Data.SqlClient
Public Class frmArticulos

    Private tabla_marcas As New DataTable

    Public Function Marcas_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        'asignar sql la consulta a la base de datos y pasar los campos que ocupamos
        sql = "SELECT IdMarca, NombreM FROM Marcas"
        'using asignar la instancia de sql data adapter 
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            'limpiar toda la conexcion de datos en las filas y fill para actualizar
            tabla.Rows.Clear()
            adaptador.Fill(tabla)

        End Using

        Return tabla

    End Function

    Private Sub Mostrar_Marcas()

        tabla_marcas = Marcas_Listar(True)
        cbMarca.DataSource = tabla_marcas
        cbMarca.DisplayMember = "NombreM"
        cbMarca.ValueMember = "IdMarca"

    End Sub

    Sub DesactivarControles()
        'desactivar los botones 
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnMarca.Enabled = False
        'desactivar los textbox
        txtNombreA.Enabled = False
        txtNumeroSerie.Enabled = False
        txtCodigo.Enabled = False
        cbMarca.Enabled = False
        txtModelo.Enabled = False
        txtPrecio.Enabled = False
        dtpFechaCompra.Enabled = False
        txtDescripcion.Enabled = False
        txtBuscar.Enabled = True
        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControles()
        'Activar los botones 
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnMarca.Enabled = True
        'Activar los textbox
        txtNombreA.Enabled = True
        txtNumeroSerie.Enabled = True
        txtCodigo.Enabled = True
        cbMarca.Enabled = True
        txtModelo.Enabled = True
        txtPrecio.Enabled = True
        dtpFechaCompra.Enabled = True
        txtDescripcion.Enabled = True
        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreA.Text = ""
        txtNumeroSerie.Text = ""
        txtCodigo.Text = ""
        cbMarca.Text = ""
        txtModelo.Text = ""
        txtPrecio.Text = ""
        dtpFechaCompra.Text = ""
        txtDescripcion.Text = ""
        txtID.Text = ""
        txtBuscar.Text = ""

    End Sub

    Sub Insertar()

        Dim sql As String
        Dim id As Integer

        If MsgBox("¿Está seguro de ingresar " + Trim(txtNombreA.Text) + " al sistema?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Articulos Where CodigoA = '" & txtCodigo.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then

            txtCodigo.Text = tabla.Rows(0).Item("CodigoA")
            MsgBox("¡El artículo ya existe!", vbInformation, "Sistema de inventario")

            Exit Sub

        End If

        If txtNombreA.Text = "" Or txtCodigo.Text = "" Then


            MsgBox("Exiten campos vacios", vbInformation, "Sistema inventario")

            Exit Sub

        Else

            sql = "INSERT INTO Articulos(NombreA,NumeroSerie,CodigoA,IdMarca,Modelo,PrecioCompra,FechaCompra,EstadoArticulo,Descripcion)" &
                                        "VALUES('" & txtNombreA.Text & "', '" & txtNumeroSerie.Text & "', '" & txtCodigo.Text & "', '" & Trim(cbMarca.SelectedValue) &
                                        "', '" & txtModelo.Text & "', '" & txtPrecio.Text & "', '" & dtpFechaCompra.Text & "', 'PENDIENTE', '" & txtDescripcion.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            'abrimos la base de datos
            conect.Open()
            'declaro variable comando, instancia de SQL command recibe 2 paramentos sql y conect la base de datos
            Using comando As New SqlCommand(sql, conect)

                id = comando.ExecuteScalar()

            End Using

            conect.Close()
            MsgBox("¡Articulo " + Trim(txtNombreA.Text) + " ingresado!", vbInformation, "Sistema inventario")

        End If

    End Sub

    Sub LlenarDatos()

        Dim sql As String
        'Mostrar solo los articulos que estan pendientes
        sql = "SELECT Articulos.IdArticulo,Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,Articulos.FechaCompra,
               Articulos.EstadoArticulo,Articulos.Descripcion FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca WHERE Articulos.EstadoArticulo = 'PENDIENTE'"
        Try
            'tabla declarada solo para este proceso en vez de publica que esta en conexionDB
            Dim tabla As New DataTable
            'instansiar adaptador, recibe parametros sql, tabla en conectarDB recibe la nueva tabla y al dgv se le asigan todo lo que trae tabla
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvArticulos.DataSource = tabla
            'mostrar el total de usuarios
            lblTotalA.Text = tabla.Rows.Count

        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema inventario")

        End Try

    End Sub

    Sub BuscarDatos()

        If rbNombreA.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,
                                            Articulos.FechaCompra,Articulos.EstadoArticulo,Articulos.Descripcion 
                                            FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca
                                            WHERE Articulos.NombreA LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvArticulos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvArticulos.DataSource = ""

            End If

        End If

        If rbCodigo.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,
                                            Articulos.FechaCompra,Articulos.EstadoArticulo,Articulos.Descripcion 
                                            FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca
                                            WHERE Articulos.CodigoA LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvArticulos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvArticulos.DataSource = ""

            End If

        End If

        If rbMarca.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,
                                            Articulos.FechaCompra,Articulos.EstadoArticulo,Articulos.Descripcion 
                                            FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca
                                            WHERE Marcas.NombreM LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvArticulos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvArticulos.DataSource = ""

            End If

        End If

    End Sub

    Sub Editar()

        Dim id As Integer

        If txtID.Text = "" Then

            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")

        Else

            Dim sql As String
            'para actualizar la base datos y agregar/editar la nueva informacion
            sql = "UPDATE Articulos SET NombreA = '" & txtNombreA.Text & "', NumeroSerie = '" & txtNumeroSerie.Text & "', CodigoA = '" & txtCodigo.Text &
                                                 "', IdMarca = '" & Trim(cbMarca.SelectedValue) & "', Modelo = '" & txtModelo.Text & "', PrecioCompra = '" & txtPrecio.Text &
                                                 "', FechaCompra = '" & dtpFechaCompra.Text & "', Descripcion = '" & txtDescripcion.Text &
                                                 "'WHERE IdArticulo = '" & txtID.Text & "'"

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

            If MsgBox("¿Está seguro de eliminar " + Trim(txtNombreA.Text) + " del registro?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else

                Dim sql As String
                'borrar por completo el usuario de la base de datos
                sql = "DELETE FROM Articulos WHERE IdArticulo = " & Trim(txtID.Text)
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
                MsgBox("¡Articulo " + Trim(txtNombreA.Text) + " eliminado del registro!", vbInformation, "Sistema de inventario")
                LimpiarControles()

            End If
        End If

    End Sub


    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DesactivarControles()
        LlenarDatos()
        Mostrar_Marcas()
        cbMarca.SelectedIndex = -1
        dgvArticulos.AutoGenerateColumns = False
        'estilo para la celda de la columna - y establecer la celda modifica
        dgvArticulos.Columns("PrecioCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("PrecioCompra").DefaultCellStyle.Format = "N2"

    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click

        frmMarcas.ShowDialog()

    End Sub

    Private Sub cbMarca_Click(sender As Object, e As EventArgs)

        Mostrar_Marcas()

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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        BuscarDatos()

    End Sub

    Private Sub rbNombreA_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreA.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub rbMarca_CheckedChanged(sender As Object, e As EventArgs) Handles rbMarca.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub dgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellDoubleClick

        'se va a transferir el error y el sistema continua normal
        On Error Resume Next
        'pasar la informacion del grid al txtID box
        txtID.Text = CStr(dgvArticulos.Item("IdArticulo", dgvArticulos.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvArticulos.Item("NombreA", dgvArticulos.CurrentCell.RowIndex).Value)
        txtNumeroSerie.Text = CStr(dgvArticulos.Item("NumeroSerie", dgvArticulos.CurrentCell.RowIndex).Value)
        txtCodigo.Text = CStr(dgvArticulos.Item("CodigoA", dgvArticulos.CurrentCell.RowIndex).Value)
        cbMarca.Text = CStr(dgvArticulos.Item("NombreM", dgvArticulos.CurrentCell.RowIndex).Value)
        txtModelo.Text = CStr(dgvArticulos.Item("Modelo", dgvArticulos.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvArticulos.Item("PrecioCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        dtpFechaCompra.Text = CStr(dgvArticulos.Item("FechaCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvArticulos.Item("Descripcion", dgvArticulos.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        txtNombreA.Enabled = True
        txtNumeroSerie.Enabled = True
        txtCodigo.Enabled = True
        cbMarca.Enabled = True
        txtModelo.Enabled = True
        txtPrecio.Enabled = True
        dtpFechaCompra.Enabled = True
        txtDescripcion.Enabled = True
        txtNombreA.Focus()

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

    Private Sub pbReturn_Click(sender As Object, e As EventArgs) Handles pbReturn.Click
        Me.Close()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

        frmReporteInventario.ImprimirInventario()
        frmReporteInventario.ShowDialog()

    End Sub
End Class