Imports System.Text
Public Class clnItem
    Private _ite_Id As Integer
    Public Property ite_Id() As Integer
        Get
            Return _ite_Id
        End Get
        Set(ByVal value As Integer)
            _ite_Id = value
        End Set
    End Property

    Private _clnPedido As clnPedido
    Public Property clnPedido() As clnPedido
        Get
            Return _clnPedido
        End Get
        Set(ByVal value As clnPedido)
            _clnPedido = value
        End Set
    End Property

    Private _clnProduto As clnProduto
    Public Property clnProduto() As clnProduto
        Get
            Return _clnProduto
        End Get
        Set(value As clnProduto)
            _clnProduto = value
        End Set
    End Property

    Private _ite_Qtde As Integer
    Public Property ite_Qtde() As Integer
        Get
            Return _ite_Qtde
        End Get
        Set(ByVal value As Integer)
            _ite_Qtde = value
        End Set
    End Property

    Private _ite_Valor As Decimal
    Public Property ite_Valor() As Decimal
        Get
            Return _ite_Valor
        End Get
        Set(ByVal value As Decimal)
            _ite_Valor = value
        End Set
    End Property

    Public Sub Gravar()


        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO item ")

        strQuery.Append(" ( ")

        strQuery.Append(" ped_Id ")
        strQuery.Append(", pro_Id ")
        strQuery.Append(", ite_Qtde ")
        strQuery.Append(", ite_Valor ")

        strQuery.Append(" ) ")

        strQuery.Append(" VALUES ( ")

        strQuery.Append(" '" & _clnPedido.ped_id & "' ")
        strQuery.Append(", '" & _clnPedido.pro_id & "' ")
        strQuery.Append(", '" & _ite_Qtde & "' ")
        strQuery.Append(", '" & _ite_Valor & "' ")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function Listar(ByVal ped_Id As Integer) As Data.DataSet

        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT ite_Id as Codigo, ped_Id as Pedido, pro_Id as Produto, ite_Qtde as Qtdade,, ite_Valor as Valor")
        strQuery.Append(" FROM item ")
        strQuery.Append(" WHERE ped_Id = " & ped_Id & " ")

        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function

    Public Sub Excluir(ByVal ite_ID As Integer)

        Dim strQuerry As New StringBuilder
        strQuerry.Append(" DELETE FROM item ")

        strQuerry.Append(" WHERE ite_ID = " & ite_ID & " ; ")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuerry.ToString)

    End Sub

End Class
