<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModeloCadastro
    Inherits ControleDeVendas2.frmModelo

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
        Me.grpCampos = New System.Windows.Forms.GroupBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grpCampos
        '
        Me.grpCampos.Location = New System.Drawing.Point(12, 12)
        Me.grpCampos.Name = "grpCampos"
        Me.grpCampos.Size = New System.Drawing.Size(441, 284)
        Me.grpCampos.TabIndex = 0
        Me.grpCampos.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(297, 302)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(378, 302)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Gravar"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'frmModeloCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(475, 347)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.grpCampos)
        Me.Name = "frmModeloCadastro"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents grpCampos As GroupBox
    Public WithEvents btnSair As Button
    Public WithEvents btnNovo As Button
End Class
