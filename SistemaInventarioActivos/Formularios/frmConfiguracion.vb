Imports System.IO

Public Class frmConfiguracion
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click

        If txtIP.Text = "" Or txtBD.Text = "" Or txtUser.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Operacion cancelada")

        End If

        Dim archivo As StreamWriter

        Try
            'Trim funciona para quitar los espacios que inicien o al final de la palabra
            'crear los archivos de texto
            archivo = New StreamWriter(Application.StartupPath + "\IP.txt")
            archivo.WriteLine(txtIP.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\BD.txt")
            archivo.WriteLine(txtBD.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\USER.txt")
            archivo.WriteLine(txtUser.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\PASS.txt")
            archivo.WriteLine(txtPassword.Text.Trim)
            archivo.Flush()
            archivo.Close()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

        'evento genera el mismo evento de cancelar con el boton
        btnCancelar.PerformClick()

    End Sub

    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If File.Exists(Application.StartupPath + "\IP.txt") Then

                txtIP.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\IP.txt")


            End If

            If File.Exists(Application.StartupPath + "\USER.txt") Then

                txtUser.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\USER.txt")


            End If

            If File.Exists(Application.StartupPath + "\PASS.txt") Then

                txtPassword.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\PASS.txt")


            End If

            If File.Exists(Application.StartupPath + "\BD.txt") Then

                txtBD.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\BD.txt")


            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

End Class