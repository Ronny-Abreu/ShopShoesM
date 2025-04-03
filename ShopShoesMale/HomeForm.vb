Public Class HomeForm
    ' Variable compartida para controlar la sesión
    Public Shared UsuarioLogueado As Boolean = False

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Si el usuario ya ha iniciado sesión, oculta el botón de "Iniciar sesión"
        If UsuarioLogueado Then
            ToolStripLabel1.Visible = False
        End If
    End Sub

    ' Evento para redirigir al formulario de login
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub
End Class
