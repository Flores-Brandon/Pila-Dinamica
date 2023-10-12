<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCrear = New Button()
        Button2 = New Button()
        Button3 = New Button()
        txtDato = New TextBox()
        Label2 = New Label()
        lblCima = New Label()
        SuspendLayout()
        ' 
        ' btnCrear
        ' 
        btnCrear.Location = New Point(218, 89)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(167, 29)
        btnCrear.TabIndex = 0
        btnCrear.Text = "Push (Apliar)"
        btnCrear.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(218, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 29)
        Button2.TabIndex = 1
        Button2.Text = "Pop (Eliminar)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(218, 159)
        Button3.Name = "Button3"
        Button3.Size = New Size(167, 29)
        Button3.TabIndex = 2
        Button3.Text = "Peek (Mostrar)"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtDato
        ' 
        txtDato.Location = New Point(23, 134)
        txtDato.Name = "txtDato"
        txtDato.Size = New Size(125, 27)
        txtDato.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(460, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 40)
        Label2.TabIndex = 5
        Label2.Text = "Label2"
        ' 
        ' lblCima
        ' 
        lblCima.Location = New Point(460, 163)
        lblCima.Name = "lblCima"
        lblCima.Size = New Size(124, 40)
        lblCima.TabIndex = 6
        lblCima.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblCima)
        Controls.Add(Label2)
        Controls.Add(txtDato)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btnCrear)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCrear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtDato As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCima As Label
End Class
