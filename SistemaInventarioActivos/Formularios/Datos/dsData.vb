Partial Class dsData
    Partial Public Class EmpleadosDataTable
        Private Sub EmpleadosDataTable_EmpleadosRowChanging(sender As Object, e As EmpleadosRowChangeEvent) Handles Me.EmpleadosRowChanging

        End Sub

    End Class

    Partial Public Class UsuariosDataTable
        Private Sub UsuariosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.UsuarioColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub UsuariosDataTable_UsuariosRowChanging(sender As Object, e As UsuariosRowChangeEvent) Handles Me.UsuariosRowChanging

        End Sub

    End Class
End Class

Namespace dsDataTableAdapters

    Partial Public Class MarcasTableAdapter
    End Class
End Namespace
