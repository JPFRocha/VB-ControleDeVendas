Public Class frmCategoriaCadastro
    Private Sub frmCategoriaCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim _Operacao As DllControleDeVendas.clnFuncoesGerais.Operacao
    Public Property Operacao() As DllControleDeVendas.clnFuncoesGerais.Operacao
        Get
            Return _Operacao
        End Get
        Set(ByVal value As DllControleDeVendas.clnFuncoesGerais.Operacao)
            _Operacao = value
        End Set
    End Property

    Dim _Codigo As Integer
    Public Property Código() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property
End Class
