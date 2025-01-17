
Imports System.Data.SqlClient

Public Class frmEmpleados

    Private tabla_departamentos As New DataTable
    Private tabla_puestos As New DataTable

    Public Function Departamento_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        'asignar sql la consulta a la base de datos y pasar los campos que ocupamos
        sql = "SELECT IdDepartamento, NombreD FROM Departamentos"
        'using asignar la instancia de sql data adapter 
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            'limpiar toda la conexcion de datos en las filas y fill para actualizar
            tabla.Rows.Clear()
            adaptador.Fill(tabla)

        End Using

        Return tabla

    End Function

    Private Sub Mostrar_Departamentos()

        tabla_departamentos = Departamento_Listar(True)
        cbDepartamento.DataSource = tabla_departamentos
        cbDepartamento.DisplayMember = "NombreD"
        cbDepartamento.ValueMember = "IdDepartamento"

    End Sub

    Public Function Puestos_Listar(activo As Integer) As DataTable

        Dim tabla As New DataTable
        Dim sql As String
        'asignar sql la consulta a la base de datos y pasar los campos que ocupamos
        sql = "SELECT IdPuesto, NombrePuesto FROM Puestos"
        'using asignar la instancia de sql data adapter 
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            'limpiar toda la conexcion de datos en las filas y fill para actualizar
            tabla.Rows.Clear()
            adaptador.Fill(tabla)

        End Using

        Return tabla

    End Function

    Private Sub Mostrar_Puestos()

        tabla_puestos = Puestos_Listar(True)
        cbPuesto.DataSource = tabla_puestos
        cbPuesto.DisplayMember = "NombrePuesto"
        cbPuesto.ValueMember = "IdPuesto"

    End Sub

    Sub DesactivarControles()
        'desactivar los botones 
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancel.Enabled = False
        'desactivar los textbox
        txtNombreEmpleado.Enabled = False
        txtCedula.Enabled = False
        txtTelefono.Enabled = False
        txtDireccion.Enabled = False
        txtCorreo.Enabled = False
        txtBuscar.Enabled = True
        cbGenero.Enabled = False
        cbPuesto.Enabled = False
        cbDepartamento.Enabled = False
        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControles()
        'Activar los botones 
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancel.Enabled = True
        'Activar los textbox
        txtNombreEmpleado.Enabled = True
        txtCedula.Enabled = True
        txtTelefono.Enabled = True
        txtDireccion.Enabled = True
        txtCorreo.Enabled = True
        txtBuscar.Enabled = True
        cbGenero.Enabled = True
        cbPuesto.Enabled = True
        cbDepartamento.Enabled = True
        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreEmpleado.Text = ""
        txtCedula.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtCorreo.Text = ""
        cbGenero.Text = ""
        cbPuesto.Text = ""
        cbDepartamento.Text = ""
        txtID.Text = ""
        txtBuscar.Text = ""

    End Sub

    'Sub tamañoformulario()

    ' Width = 450
    ' Height = 352
    '
    ' Panel1.Visible = False

    ' End Sub

    ' Sub tamañoformulariobuscar()

    ' Width = 450
    ' Height = 689

    ' Panel1.Visible = True

    ' End Sub

    Sub Insertar()

        Dim sql As String
        Dim id As Integer

        If MsgBox("¿Está seguro de ingresar " + Trim(txtNombreEmpleado.Text) + " al sistema?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

            Exit Sub

        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Empleados Where Identidad = '" & txtCedula.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then

            txtCedula.Text = tabla.Rows(0).Item("Identidad")
            MsgBox("¡El empleado ya existe!", vbInformation, "Sistema de inventario")

            Exit Sub

        End If

        If txtNombreEmpleado.Text = "" Or txtCedula.Text = "" Or txtTelefono.Text = "" Or txtDireccion.Text = "" Or txtCorreo.Text = "" Or cbGenero.Text = "" Or cbPuesto.Text = "" Or cbDepartamento.Text = "" Then


            MsgBox("Exiten campos vacios", vbInformation, "Sistema inventario")

            Exit Sub

        Else

            sql = "INSERT INTO Empleados(Nombre,Identidad,Genero,Telefono,Correo,Direccion,IdPuesto,IdDepartamento) VALUES ('" & txtNombreEmpleado.Text & "', '" & txtCedula.Text &
                                        "', '" & cbGenero.Text & "', '" & txtTelefono.Text & "', '" & txtCorreo.Text & "', '" & txtDireccion.Text & "', '" & Trim(cbPuesto.SelectedValue) &
                                        "', '" & Trim(cbDepartamento.SelectedValue) & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            'abrimos la base de datos
            conect.Open()
            'declaro variable comando, instancia de SQL command recibe 2 paramentos sql y conect la base de datos
            Using comando As New SqlCommand(sql, conect)

                id = comando.ExecuteScalar()

            End Using

            conect.Close()
            MsgBox("¡Empleado " + Trim(txtNombreEmpleado.Text) + " ingresado!", vbInformation, "Sistema inventario")

        End If

    End Sub

    Sub LlenarDatos()

        Dim sql As String
        sql = "SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Direccion, Empleados.Correo, Empleados.Telefono, Departamentos.NombreD, Puestos.NombrePuesto 
                       FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                          INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto"
        Try
            'tabla declarada solo para este proceso en vez de publica que esta en conexionDB
            Dim tabla As New DataTable
            'instansiar adaptador, recibe parametros sql, tabla en conectarDB recibe la nueva tabla y al dgv se le asigan todo lo que trae tabla
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvEmpleados.DataSource = tabla
            'mostrar el total de usuarios
            lblTotalEmpleados.Text = tabla.Rows.Count

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
            sql = "UPDATE Empleados SET Nombre = '" & txtNombreEmpleado.Text & "', Identidad = '" & txtCedula.Text & "', Genero = '" & cbGenero.Text &
                                                 "', Telefono = '" & txtTelefono.Text & "', Correo = '" & txtCorreo.Text & "', Direccion = '" & txtDireccion.Text &
                                                 "', IdPuesto = '" & Trim(cbPuesto.SelectedValue) & "', IdDepartamento = '" & Trim(cbDepartamento.SelectedValue) &
                                                 "'WHERE IdEmpleado = '" & txtID.Text & "'"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()

            Using comando As New SqlCommand(sql, conect)
                'funcion ejecuta la consulta
                id = comando.ExecuteScalar

            End Using

            conect.Close()
            MsgBox("¡Modificado con exitó!", vbInformation, "Sistema de inventario")
            LimpiarControles()

        End If

    End Sub

    Sub Eliminar()

        Dim id As Integer

        If txtID.Text = "" Then

            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")

        Else

            If MsgBox("¿Está seguro de eliminar " + Trim(txtNombreEmpleado.Text) + " del registro?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then

                LimpiarControles()
                DesactivarControles()

                Exit Sub

            Else

                Dim sql As String
                'borrar por completo el usuario de la base de datos
                sql = "DELETE FROM Empleados WHERE IdEmpleado = " & Trim(txtID.Text)
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
                MsgBox("¡Empleado " + Trim(txtNombreEmpleado.Text) + " eliminado del registro!", vbInformation, "Sistema de inventario")
                LimpiarControles()

            End If
        End If

    End Sub

    Sub Buscar()

        If rbNombreEmpleado.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT Empleados.IDEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Direccion, Empleados.Correo, Empleados.Telefono, Departamentos.NombreD, Puestos.NombrePuesto 
                       FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                          INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto
                                          WHERE Empleados.Nombre LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count

            Else

                dgvEmpleados.DataSource = ""

            End If

        End If

        If rbCedula.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT Empleados.IDEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Direccion, Empleados.Correo, Empleados.Telefono, Departamentos.NombreD, Puestos.NombrePuesto 
                       FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                          INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto
                                          WHERE Empleados.Identidad LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count

            Else

                dgvEmpleados.DataSource = ""

            End If

        End If

        If rbDepartamento.Checked Then

            If txtBuscar.Text = "" Then

                LlenarDatos()

            End If

            adaptador = New SqlDataAdapter("SELECT Empleados.IDEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Direccion, Empleados.Correo, Empleados.Telefono, Departamentos.NombreD, Puestos.NombrePuesto 
                       FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                          INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto
                                          WHERE Departamentos.NombreD LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then

                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count

            Else

                dgvEmpleados.DataSource = ""

            End If

        End If

    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DesactivarControles()
        LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
        Mostrar_Departamentos()
        cbDepartamento.SelectedIndex = -1
        Mostrar_Puestos()
        cbPuesto.SelectedIndex = -1

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Buscar()

        'extraer la busqueda de buscar con el LIKE
        ' If txtBuscar.Text = "" Then

        'LlenarDatos()

        '  End If

        ' adaptador = New SqlDataAdapter("SELECT * FROM Empleados WHERE Nombre LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
        '  tabla.Clear()
        'adaptador.Fill(tabla)

        ' If tabla.Rows.Count > 0 Then

        ' dgvEmpleados.DataSource = tabla
        'lblTotalEmpleados.Text = tabla.Rows.Count

        ' Else

        'Empleados.DataSource = ""

        ' End If


    End Sub

    Private Sub dgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick

        'se va a transferir el error y el sistema continua normal
        On Error Resume Next
        'pasar la informacion del grid al txtID box
        txtID.Text = CStr(dgvEmpleados.Item("IdEmpleado", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtNombreEmpleado.Text = CStr(dgvEmpleados.Item("Nombre", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtCedula.Text = CStr(dgvEmpleados.Item("Identidad", dgvEmpleados.CurrentCell.RowIndex).Value)
        cbGenero.Text = CStr(dgvEmpleados.Item("Genero", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtTelefono.Text = CStr(dgvEmpleados.Item("Telefono", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtCorreo.Text = CStr(dgvEmpleados.Item("Correo", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtDireccion.Text = CStr(dgvEmpleados.Item("Direccion", dgvEmpleados.CurrentCell.RowIndex).Value)
        cbPuesto.Text = CStr(dgvEmpleados.Item("NombrePuesto", dgvEmpleados.CurrentCell.RowIndex).Value)
        cbDepartamento.Text = CStr(dgvEmpleados.Item("NombreD", dgvEmpleados.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        txtNombreEmpleado.Enabled = True
        txtCedula.Enabled = True
        cbGenero.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        txtDireccion.Enabled = True
        cbPuesto.Enabled = True
        cbDepartamento.Enabled = True
        txtNombreEmpleado.Focus()

    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub rbCedula_CheckedChanged(sender As Object, e As EventArgs) Handles rbCedula.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged

        txtBuscar.Focus()

    End Sub

    Private Sub btnDepartamento_Click(sender As Object, e As EventArgs)

        frmDepartamentos.ShowDialog()

    End Sub

    Private Sub btnPuesto_Click(sender As Object, e As EventArgs)

        frmPuestos.ShowDialog()

    End Sub

    Private Sub cbPuesto_Click(sender As Object, e As EventArgs)

        Mostrar_Puestos()

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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Editar()
        DesactivarControles()
        LlenarDatos()

    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click

        btnCancelar.Enabled = True
        btnBuscar.Enabled = False

        txtBuscar.Focus()
        txtBuscar.BackColor = Color.YellowGreen

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Eliminar()
        DesactivarControles()
        LlenarDatos()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        DesactivarControles()
        LimpiarControles()


    End Sub

    Private Sub pbReturn_Click(sender As Object, e As EventArgs) Handles pbReturn.Click
        Me.Close()
    End Sub

    Private Sub btnPuesto_Click_1(sender As Object, e As EventArgs) Handles btnPuesto.Click
        frmPuestos.ShowDialog()
    End Sub

    Private Sub btnDepartamento_Click_1(sender As Object, e As EventArgs) Handles btnDepartamento.Click
        frmDepartamentos.ShowDialog()
    End Sub
End Class