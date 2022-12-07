<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutoCadastro
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
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.nudQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.optSim = New System.Windows.Forms.RadioButton()
        Me.optNao = New System.Windows.Forms.RadioButton()
        Me.grpCampos.SuspendLayout()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCampos
        '
        Me.grpCampos.Controls.Add(Me.optNao)
        Me.grpCampos.Controls.Add(Me.optSim)
        Me.grpCampos.Controls.Add(Me.lblAtivo)
        Me.grpCampos.Controls.Add(Me.txtValor)
        Me.grpCampos.Controls.Add(Me.lblValor)
        Me.grpCampos.Controls.Add(Me.nudQuantidade)
        Me.grpCampos.Controls.Add(Me.lblQuantidade)
        Me.grpCampos.Controls.Add(Me.txtDescricao)
        Me.grpCampos.Controls.Add(Me.lblDescricao)
        Me.grpCampos.Controls.Add(Me.lblCategoria)
        Me.grpCampos.Controls.Add(Me.cboCategoria)
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(100, 16)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(308, 21)
        Me.cboCategoria.TabIndex = 0
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(39, 19)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblCategoria.TabIndex = 1
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(36, 44)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(100, 41)
        Me.txtDescricao.MaxLength = 80
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(308, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(29, 68)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 13)
        Me.lblQuantidade.TabIndex = 4
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'nudQuantidade
        '
        Me.nudQuantidade.Location = New System.Drawing.Point(100, 66)
        Me.nudQuantidade.Name = "nudQuantidade"
        Me.nudQuantidade.Size = New System.Drawing.Size(84, 20)
        Me.nudQuantidade.TabIndex = 5
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(60, 94)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(34, 13)
        Me.lblValor.TabIndex = 6
        Me.lblValor.Text = "Valor:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(100, 91)
        Me.txtValor.MaxLength = 80
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(84, 20)
        Me.txtValor.TabIndex = 7
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(60, 119)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(34, 13)
        Me.lblAtivo.TabIndex = 8
        Me.lblAtivo.Text = "Ativo:"
        '
        'optSim
        '
        Me.optSim.AutoSize = True
        Me.optSim.Location = New System.Drawing.Point(100, 117)
        Me.optSim.Name = "optSim"
        Me.optSim.Size = New System.Drawing.Size(42, 17)
        Me.optSim.TabIndex = 9
        Me.optSim.Text = "Sim"
        Me.optSim.UseVisualStyleBackColor = True
        '
        'optNao
        '
        Me.optNao.AutoSize = True
        Me.optNao.Location = New System.Drawing.Point(148, 117)
        Me.optNao.Name = "optNao"
        Me.optNao.Size = New System.Drawing.Size(45, 17)
        Me.optNao.TabIndex = 10
        Me.optNao.Text = "Não"
        Me.optNao.UseVisualStyleBackColor = True
        '
        'frmProdutoCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(475, 347)
        Me.Name = "frmProdutoCadastro"
        Me.grpCampos.ResumeLayout(False)
        Me.grpCampos.PerformLayout()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCategoria As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents optNao As RadioButton
    Friend WithEvents optSim As RadioButton
    Friend WithEvents lblAtivo As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents nudQuantidade As NumericUpDown
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lblDescricao As Label
End Class
