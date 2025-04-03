
' Función para verificar los datos de login
Imports System.Data.SqlClient

Public Class LoginForm
    Private conexion As New SqlConnection("Server=SLIMREAPER;Database=ShopShoesM;Trusted_Connection=True;")

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim correo As String = txtCorreo.Text
        Dim password As String = txtPassword.Text

        If VerificarUsuario(correo, password) Then

            ' Abrir HomeForm y ocultar este formulario
            Dim home As New HomeForm()
            home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Correo o contraseña incorrectos.")
        End If
    End Sub

    ' Función para verificar usuario en la base de datos
    Private Function VerificarUsuario(correo As String, password As String) As Boolean
        Dim usuarioEncontrado As Boolean = False
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Usuarios WHERE Correo = @correo AND Password = @password", conexion)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                usuarioEncontrado = True
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return usuarioEncontrado
    End Function

    'Función para redirigir al formulario de registrarse si el usuario quiere ir allá'
    Private Sub lblNoTengoCuenta_Click(sender As Object, e As EventArgs) Handles lblNoTengoCuenta.Click
        Dim Register As New Register()
        Register.Show()
        Me.Hide() ' Oculta el formulario de registro
    End Sub
End Class
