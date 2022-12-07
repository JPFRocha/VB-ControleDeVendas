Imports DllControleDeVendas
Imports DllControleDeVendas.clnFuncoesGerais

Public Class frmClienteCadastro
    Private Sub lblCPfCnpj_Click(sender As Object, e As EventArgs) Handles lblCPfCnpj.Click

    End Sub

    Private Sub grbEndereco_Enter(sender As Object, e As EventArgs) Handles grbEndereco.Enter

    End Sub

    Private Sub lblLogradouro_Click(sender As Object, e As EventArgs) Handles lblLogradouro.Click

    End Sub

    Private Sub cboUf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUf.SelectedIndexChanged

    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub



    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        If txtNome.Text.Equals(String.Empty) Then
            errErro.SetError(txtNome, "Digite um nome")
            Exit Sub
        Else
            errErro.SetError(txtNome, "")
        End If

        If txtCpfCnpj.Text.Equals(String.Empty) Then
            errErro.SetError(txtCpfCnpj, "Digite um CPF/CNPJ")
            Exit Sub
        Else
            errErro.SetError(txtCpfCnpj, "")
        End If

        If txtLogradouro.Text.Equals(String.Empty) Then
            errErro.SetError(txtLogradouro, "Digite um logradouro")
            Exit Sub
        Else
            errErro.SetError(txtLogradouro, "")
        End If

        If txtBairro.Text.Equals(String.Empty) Then
            errErro.SetError(txtBairro, "Digite um bairro")
            Exit Sub
        Else
            errErro.SetError(txtBairro, "")
        End If

        If txtCidade.Text.Equals(String.Empty) Then
            errErro.SetError(txtCidade, "Digite um cidade")
            Exit Sub
        Else
            errErro.SetError(txtCidade, "")
        End If

        If cboUf.Text.Equals(String.Empty) Then
            errErro.SetError(cboUf, "Selecione uma UF")
            Exit Sub
        Else
            errErro.SetError(cboUf, "")
        End If

        If txtCep.Text.Equals(String.Empty) Then
            errErro.SetError(txtCep, "Digite um cidade")
            Exit Sub
        Else
            errErro.SetError(txtCep, "")
        End If



        Dim cldCliente As New DllControleDeVendas.clnCliente
        With cldCliente
            .cli_Bairro = txtBairro.Text
            .cli_CEP = txtCep.Text
            .cli_Cidade -= txtCidade.Text
            .cli_CNPJCPF = txtCpfCnpj.Text
            Dim txtDtCadastro As Object = Nothing
            .cli_DtCadastro = txtDtCadastro.Text
            .cli_Email = txtEmail.Text
            .cli_Fones = txtTelefone.Text
            .cli_Logradouro = txtLogradouro.Text
            .cli_NomeRazao = txtNome.Text
            .cli_Uf = cboUf.Text
        End With

        If Operacao() = DllControleDeVendas.clnFuncoesGerais.Operacao.Inclusao Then
            cldCliente.Gravar()
        ElseIf Operacao() = DllControleDeVendas.clnFuncoesGerais.Operacao.Alteracao Then
            cldCliente.cli_Id = Codigo
            cldCliente.Alterar()
        End If

        MessageBox.Show("Registro gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()

    End Sub

    Private Function Codigo() As Integer
        Throw New NotImplementedException()
    End Function

    Public ReadOnly Property Operacao As DllControleDeVendas.clnFuncoesGerais.Operacao
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private Sub frmClienteCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Operacao As DllControleDeVendas.clnFuncoesGerais.Operacao = Nothing

        If _Operacao = DllControleDeVendas.clnFuncoesGerais.Operacao.Alteracao Then

            Dim clncliente As New DllControleDeVendas.clnCliente
            Dim drDados As System.Data.OleDb.OleDbDataReader
            Dim Codigo As Integer = Nothing
            drDados = clncliente.ListarCliente(Codigo)

            If drDados.Read = True Then
                txtNome.Text = drDados("cli_NomeRazao")
                txtCpfCnpj.Text = drDados("cli_CNPJCPF")
                txtLogradouro.Text = drDados("cli_Logradouro")
                txtBairro.Text = drDados("cli_Bairro")
                txtCidade.Text = drDados("cli_Cidade")
                cboUf.Text = drDados("cli_Uf")
                txtCep = drDados("cli_CEP")
                txtEmail.Text = drDados("cli_Email")
                txtTelefone.Text = drDados("cli_Fones")
            End If
        End If
    End Sub
End Class
