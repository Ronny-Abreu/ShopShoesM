<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private lblMensaje As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.Location = New System.Drawing.Point(337, 242)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(277, 33)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "Has iniciado sesión"
        '
        'HomeForm
        '
        Me.ClientSize = New System.Drawing.Size(937, 585)
        Me.Controls.Add(Me.lblMensaje)
        Me.Name = "HomeForm"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
