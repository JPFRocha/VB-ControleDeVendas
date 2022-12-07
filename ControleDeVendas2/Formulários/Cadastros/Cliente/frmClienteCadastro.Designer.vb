<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteCadastro
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
        Me.grpDadosCliente = New System.Windows.Forms.GroupBox()
        Me.txtCpfCnpj = New System.Windows.Forms.TextBox()
        Me.lblCPfCnpj = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.grbEndereco = New System.Windows.Forms.GroupBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.lblTelefones = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.grpCampos.SuspendLayout()
        Me.grpDadosCliente.SuspendLayout()
        Me.grbEndereco.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCampos
        '
        Me.grpCampos.Controls.Add(Me.grbEndereco)
        Me.grpCampos.Controls.Add(Me.grpDadosCliente)
        '
        'btnNovo
        '
        '
        'grpDadosCliente
        '
        Me.grpDadosCliente.Controls.Add(Me.txtCpfCnpj)
        Me.grpDadosCliente.Controls.Add(Me.lblCPfCnpj)
        Me.grpDadosCliente.Controls.Add(Me.txtNome)
        Me.grpDadosCliente.Controls.Add(Me.lblNome)
        Me.grpDadosCliente.Location = New System.Drawing.Point(6, 22)
        Me.grpDadosCliente.Name = "grpDadosCliente"
        Me.grpDadosCliente.Size = New System.Drawing.Size(447, 83)
        Me.grpDadosCliente.TabIndex = 0
        Me.grpDadosCliente.TabStop = False
        Me.grpDadosCliente.Text = "Dados do Cliente"
        '
        'txtCpfCnpj
        '
        Me.txtCpfCnpj.Location = New System.Drawing.Point(102, 52)
        Me.txtCpfCnpj.MaxLength = 20
        Me.txtCpfCnpj.Name = "txtCpfCnpj"
        Me.txtCpfCnpj.Size = New System.Drawing.Size(140, 20)
        Me.txtCpfCnpj.TabIndex = 1
        '
        'lblCPfCnpj
        '
        Me.lblCPfCnpj.AutoSize = True
        Me.lblCPfCnpj.Location = New System.Drawing.Point(34, 55)
        Me.lblCPfCnpj.Name = "lblCPfCnpj"
        Me.lblCPfCnpj.Size = New System.Drawing.Size(62, 13)
        Me.lblCPfCnpj.TabIndex = 2
        Me.lblCPfCnpj.Text = "CPF/CNPJ:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(85, 22)
        Me.txtNome.MaxLength = 80
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(337, 20)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(34, 29)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'grbEndereco
        '
        Me.grbEndereco.Controls.Add(Me.txtTelefone)
        Me.grbEndereco.Controls.Add(Me.lblTelefones)
        Me.grbEndereco.Controls.Add(Me.txtEmail)
        Me.grbEndereco.Controls.Add(Me.lblEmail)
        Me.grbEndereco.Controls.Add(Me.txtCep)
        Me.grbEndereco.Controls.Add(Me.lblCep)
        Me.grbEndereco.Controls.Add(Me.cboUf)
        Me.grbEndereco.Controls.Add(Me.lblUf)
        Me.grbEndereco.Controls.Add(Me.txtCidade)
        Me.grbEndereco.Controls.Add(Me.lblCidade)
        Me.grbEndereco.Controls.Add(Me.txtBairro)
        Me.grbEndereco.Controls.Add(Me.lblBairro)
        Me.grbEndereco.Controls.Add(Me.txtLogradouro)
        Me.grbEndereco.Controls.Add(Me.lblLogradouro)
        Me.grbEndereco.Location = New System.Drawing.Point(6, 111)
        Me.grbEndereco.Name = "grbEndereco"
        Me.grbEndereco.Size = New System.Drawing.Size(447, 167)
        Me.grbEndereco.TabIndex = 1
        Me.grbEndereco.TabStop = False
        Me.grbEndereco.Text = "Dados do Cliente"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(77, 144)
        Me.txtTelefone.MaxLength = 50
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(324, 20)
        Me.txtTelefone.TabIndex = 13
        '
        'lblTelefones
        '
        Me.lblTelefones.AutoSize = True
        Me.lblTelefones.Location = New System.Drawing.Point(14, 147)
        Me.lblTelefones.Name = "lblTelefones"
        Me.lblTelefones.Size = New System.Drawing.Size(57, 13)
        Me.lblTelefones.TabIndex = 12
        Me.lblTelefones.Text = "Telefones:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(77, 120)
        Me.txtEmail.MaxLength = 80
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(171, 20)
        Me.txtEmail.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(28, 123)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(292, 96)
        Me.txtCep.MaxLength = 8
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(91, 20)
        Me.txtCep.TabIndex = 9
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(255, 99)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(31, 13)
        Me.lblCep.TabIndex = 8
        Me.lblCep.Text = "CEP:"
        '
        'cboUf
        '
        Me.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {"SP", "RJ", "MG", "BA"})
        Me.cboUf.Location = New System.Drawing.Point(77, 96)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(172, 21)
        Me.cboUf.TabIndex = 7
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(39, 99)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(24, 13)
        Me.lblUf.TabIndex = 6
        Me.lblUf.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(77, 72)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(324, 20)
        Me.txtCidade.TabIndex = 5
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(29, 75)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 4
        Me.lblCidade.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(77, 46)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(324, 20)
        Me.txtBairro.TabIndex = 3
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(34, 49)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 2
        Me.lblBairro.Text = "Bairro:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(77, 20)
        Me.txtLogradouro.MaxLength = 80
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(324, 20)
        Me.txtLogradouro.TabIndex = 1
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Location = New System.Drawing.Point(8, 23)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(64, 13)
        Me.lblLogradouro.TabIndex = 0
        Me.lblLogradouro.Text = "Logradouro:"
        '
        'frmClienteCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(475, 347)
        Me.Name = "frmClienteCadastro"
        Me.grpCampos.ResumeLayout(False)
        Me.grpDadosCliente.ResumeLayout(False)
        Me.grpDadosCliente.PerformLayout()
        Me.grbEndereco.ResumeLayout(False)
        Me.grbEndereco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDadosCliente As GroupBox
    Friend WithEvents lblCPfCnpj As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents grbEndereco As GroupBox
    Friend WithEvents txtCep As TextBox
    Friend WithEvents lblCep As Label
    Friend WithEvents cboUf As ComboBox
    Friend WithEvents lblUf As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtLogradouro As TextBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents txtCpfCnpj As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents lblTelefones As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
End Class
