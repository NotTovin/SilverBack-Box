Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class frmPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    '  Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
    'Dim OpenFileDialog As New OpenFileDialog
    '  OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '  OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    'Dim FileName As String = OpenFileDialog.FileName
    ' TODO: Add code here to open the file.
    ' ' If
    ' End Sub

    ' Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    'Dim SaveFileDialog As New SaveFileDialog
    ' SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    ' SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    '
    '  If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    'Dim FileName As String = SaveFileDialog.FileName
    '' TODO: Add code here to save the current contents of the form to a file.
    ' End If
    ' End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click


        On Error Resume Next
        Dim Salir As String

        Salir = MsgBox("¿Desea Salir del sistema?", vbQuestion + vbYesNo, "Salir")

        If Salir = vbYes Then

            Global.System.Windows.Forms.Application.Exit()

        Else


            Me.ShowDialog()

        End If

    End Sub


    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click

        If UCase(tipousuario) = "ADMINISTRADOR" Then

            frmUsuarios.Show()

        Else

            MsgBox("No tiene los derechos para acceder a este modulo", vbInformation, "Operacion cancelada")

        End If

    End Sub

    Private Sub StatusStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
