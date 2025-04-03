<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    ' Limpieza de componentes
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    ' Inicialización de componentes
    Private Sub InitializeComponent()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.lblNoTengoCuenta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(257, 243)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(61, 20)
        Me.lblCorreo.TabIndex = 0
        Me.lblCorreo.Text = "Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(357, 243)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(200, 26)
        Me.txtCorreo.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(257, 293)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(96, 20)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(357, 293)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 26)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Location = New System.Drawing.Point(357, 386)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(120, 35)
        Me.btnIniciarSesion.TabIndex = 4
        Me.btnIniciarSesion.Text = "Iniciar Sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'lblNoTengoCuenta
        '
        Me.lblNoTengoCuenta.AutoSize = True
        Me.lblNoTengoCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNoTengoCuenta.ForeColor = System.Drawing.Color.Blue
        Me.lblNoTengoCuenta.Location = New System.Drawing.Point(298, 351)
        Me.lblNoTengoCuenta.Name = "lblNoTengoCuenta"
        Me.lblNoTengoCuenta.Size = New System.Drawing.Size(259, 20)
        Me.lblNoTengoCuenta.TabIndex = 9
        Me.lblNoTengoCuenta.Text = "¿No tienes cuenta? Regístrate aquí"
        '
        'LoginForm
        '
        Me.ClientSize = New System.Drawing.Size(883, 598)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.lblNoTengoCuenta)
        Me.Name = "LoginForm"
        Me.Text = "Inicio de Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents lblNoTengoCuenta As Label
End Class
