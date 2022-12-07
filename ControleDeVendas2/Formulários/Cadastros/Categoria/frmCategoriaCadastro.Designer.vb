<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoriaCadastro
    Inherits ControleDeVendas2.frmModeloCadastro

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.grpCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCampos
        '
        Me.grpCampos.Controls.Add(Me.txtNome)
        Me.grpCampos.Controls.Add(Me.lblNome)
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(15, 28)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(66, 25)
        Me.txtNome.MaxLength = 80
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(337, 20)
        Me.txtNome.TabIndex = 1
        '
        'frmCategoriaCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(475, 347)
        Me.Name = "frmCategoriaCadastro"
        Me.grpCampos.ResumeLayout(False)
        Me.grpCampos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents txtNome As TextBox
End Class
