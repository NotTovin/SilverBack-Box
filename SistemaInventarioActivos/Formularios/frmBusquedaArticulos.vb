Imports System.Data.SqlClient
Public Class frmBusquedaArticulos
    Private Sub frmBusquedaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarDatos()

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
            dgvBusquedaArticulos.DataSource = tabla
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

                dgvBusquedaArticulos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvBusquedaArticulos.DataSource = ""

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

                dgvBusquedaArticulos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvBusquedaArticulos.DataSource = ""

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

                dgvBusquedaArticulos.DataSource = tabla
                lblTotalA.Text = tabla.Rows.Count

            Else

                dgvBusquedaArticulos.DataSource = ""

            End If

        End If

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        BuscarDatos()

    End Sub

    Private Sub dgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusquedaArticulos.CellDoubleClick
        'se va a transferir el error y el sistema continua normal
        On Error Resume Next


        'pasar la informacion del grid al txtID box
        frmCargoActivos.txtIdArticulo.Text = CStr(dgvBusquedaArticulos.Item("IdArticulo", dgvBusquedaArticulos.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtNombreArticulo.Text = CStr(dgvBusquedaArticulos.Item("NombreA", dgvBusquedaArticulos.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtPrecio.Text = CStr(dgvBusquedaArticulos.Item("PrecioCompra", dgvBusquedaArticulos.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtCodigo.Text = CStr(dgvBusquedaArticulos.Item("CodigoA", dgvBusquedaArticulos.CurrentCell.RowIndex).Value)



        Me.Close()


    End Sub

End Class