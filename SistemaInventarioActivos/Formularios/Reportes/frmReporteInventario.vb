Imports System.Data.SqlClient
Public Class frmReporteInventario
    Private Sub frmReporteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ImprimirInventario()

        Dim adaptador1, adaptador2 As SqlDataAdapter
        Dim reporte As New crInventario
        Dim ds As New dsData
        Dim sql1, sql2 As String

        sql1 = "SELECT * FROM  Articulos WHERE EstadoArticulo='PENDIENTE'"
        sql2 = "SELECT * FROM Marcas"

        Try

            adaptador1 = New SqlDataAdapter(sql1, obtenerconexion)
            adaptador2 = New SqlDataAdapter(sql2, obtenerconexion)
            adaptador1.Fill(ds, "Articulos")
            adaptador2.Fill(ds, "Marcas")

            reporte.SetDataSource(ds)
            Me.CrystalReportViewer1.ReportSource = reporte

        Catch ex As Exception

            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")

        End Try

    End Sub


End Class