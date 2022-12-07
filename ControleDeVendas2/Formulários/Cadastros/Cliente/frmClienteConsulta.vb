Public Class frmClienteConsulta
    Private Sub frmClienteConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CarregaGrid()
        Dim cldCliente As New DllControleDeVendas.clnCliente
        dgdGrid.DataSource = cldCliente.Listar(txtDescricao.Text).Tables(0)

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Dim frmCliente As New frmClienteCadastro
        With frmCliente.Operacao = DllControleDeVendas.clnFuncoesGerais.Operacao.Inclusao
            ShowDialog()
        End With

        CarregaGrid()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim frmCliente As New frmClienteCadastro
        With frmCliente.Operacao = DllControleDeVendas.clnFuncoesGerais.Operacao.Inclusao
            ShowDialog()

        End With

        CarregaGrid()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If (MessageBox.Show("Deseja excluir o registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

        Dim cldCliente As New DllControleDeVendas.clnCliente
        cldCliente.Excluir(dgdGrid.CurrentRow.Cells(0).Value)

        MessageBox.Show("Registro excluído com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        CarregaGrid()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class
