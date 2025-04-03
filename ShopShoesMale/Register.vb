Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Register
    Private conexion As New SqlConnection("Server=SLIMREAPER;Database=ShopShoesM;Trusted_Connection=True;")

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ' Verificar si algún campo está vacío
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse
           String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse
           String.IsNullOrWhiteSpace(txtTelefono.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then

            MessageBox.Show("Por favor, complete todos los campos antes de registrarse.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validar la contraseña (mínimo 8 caracteres y al menos un número)
        If txtPassword.Text.Length < 8 OrElse Not Regex.IsMatch(txtPassword.Text, "\d") Then
            MessageBox.Show("La contraseña debe tener al menos 8 caracteres y contener al menos un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            conexion.Open()

            ' Verificar si el correo ya está registrado
            Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Correo = @correo", conexion)
            checkCmd.Parameters.AddWithValue("@correo", txtCorreo.Text)
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("El correo ingresado ya está registrado. Intente con otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Insertar usuario en la base de datos
            Dim cmd As New SqlCommand("INSERT INTO Usuarios (Nombre, Correo, Telefono, Password, Rol) VALUES (@nombre, @correo, @telefono, @password, 'cliente')", conexion)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text) ' ***En texto plano, aunque no es seguro***

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Usuario registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar los campos después del registro
                txtNombre.Clear()
                txtCorreo.Clear()
                txtTelefono.Clear()
                txtPassword.Clear()

                ' Redirigir al login
                Dim loginForm As New LoginForm()
                loginForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error al registrar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    'Función para redirigir al formulario de inicio de sesión'
    Private Sub lblTengoCuenta_Click(sender As Object, e As EventArgs) Handles lblTengoCuenta.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide() ' Oculta el formulario de registro
    End Sub

End Class
