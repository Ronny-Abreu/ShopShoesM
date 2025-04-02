Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form1
    Private conexion As New SqlConnection("Server=SLIMREAPER;Database=ShopShoesM;Trusted_Connection=True;")

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtPassword.Text.Length < 8 OrElse Not Regex.IsMatch(txtPassword.Text, "\d") Then
            MessageBox.Show("La contraseña debe tener al menos 8 caracteres y un número.")
            Return
        End If

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("INSERT INTO Usuarios (Nombre, Correo, Telefono, Password, Rol) VALUES (@nombre, @correo, @telefono, @password, 'cliente')", conexion)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Usuario registrado correctamente.")
            Else
                MessageBox.Show("Error al registrar usuario.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
