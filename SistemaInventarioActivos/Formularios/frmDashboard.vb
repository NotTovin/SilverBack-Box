Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hideSubmenu()
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Dim thisDate As Date
        thisDate = Today
        lblFecha.Text = thisDate



    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub hideSubmenu()
        panelUsuarios.Visible = False
        panelEmpleados.Visible = False
        panelArticulos.Visible = False
        panelInventario.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'lblTitle.Text = childForm.Text
    End Sub


    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        showSubmenu(panelUsuarios)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        showSubmenu(panelEmpleados)
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        showSubmenu(panelArticulos)
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        showSubmenu(panelInventario)
    End Sub

    Private Sub btnControlUsuarios_Click(sender As Object, e As EventArgs) Handles btnControlUsuarios.Click
        openChildForm(New frmUsuarios())
        hideSubmenu()
    End Sub

    Private Sub btnControlEmpleados_Click(sender As Object, e As EventArgs) Handles btnControlEmpleados.Click
        openChildForm(New frmEmpleados())
        hideSubmenu()
    End Sub

    Private Sub btnPuestos_Click(sender As Object, e As EventArgs) 
        openChildForm(New frmPuestos())
        hideSubmenu()
    End Sub

    Private Sub btnControlArticulos_Click(sender As Object, e As EventArgs) Handles btnControlArticulos.Click
        openChildForm(New frmArticulos())
        hideSubmenu()
    End Sub

    Private Sub btnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        openChildForm(New frmMarcas())
        hideSubmenu()
    End Sub

    Private Sub btnCargoActivos_Click(sender As Object, e As EventArgs) Handles btnCargoActivos.Click
        'openChildForm(New frmCargoActivos())
        frmCargoActivos.ShowDialog()
        hideSubmenu()
    End Sub

    Private Sub btnDescargoActivos_Click(sender As Object, e As EventArgs) Handles btnDescargoActivos.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then

            'openChildForm(New frmDescargoActivos())
            frmDescargoActivos.ShowDialog()
            hideSubmenu()

        Else

            MsgBox("No tiene los privilegios para acceder a este modulo", vbInformation, "Operacion cancelada")

        End If



    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnDepartamento.Click
        openChildForm(New frmDepartamentos())
        hideSubmenu()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        On Error Resume Next
        Dim Salir As String

        Salir = MsgBox("¿Desea Salir del sistema?", vbQuestion + vbYesNo, "Salir")

        If Salir = vbYes Then
            Global.System.Windows.Forms.Application.Exit()

        Else
            Me.ShowDialog()
        End If
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If (WindowState = FormWindowState.Normal) Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub bntMinimize_Click(sender As Object, e As EventArgs) Handles bntMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCloseChildForm_Click(sender As Object, e As EventArgs)
        If (Not (ActiveForm) Is Nothing) Then
            ActiveForm.Close()
        End If
        Reset()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        On Error Resume Next
        Dim Salir As String

        Salir = MsgBox("¿Desea Salir del sistema?", vbQuestion + vbYesNo, "Salir")

        If Salir = vbYes Then
            Global.System.Windows.Forms.Application.Exit()

        Else
            Me.ShowDialog()
        End If
    End Sub

    Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub btnPuesto_Click(sender As Object, e As EventArgs) Handles btnPuesto.Click
        openChildForm(New frmPuestos())
        hideSubmenu()
    End Sub

    Private Sub PanelChildForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelChildForm.Paint

    End Sub
End Class