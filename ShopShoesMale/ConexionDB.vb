Imports System.Data.SqlClient

Module ConexionDB
    Public conexion As New SqlConnection("Server=SLIMREAPER;Database=ShopShoesM;Trusted_Connection=True;")

    Public Sub AbrirConexion()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
        End Try
    End Sub

    Public Sub CerrarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
End Module
