Imports System.Data.OleDb
Imports System.Text
Public Class clnProduto
    Private _pro_id As Integer
    Public Property pro_id() As Integer
        Get
            Return _pro_id
        End Get
        Set(ByVal value As Integer)
            _pro_id = value
        End Set
    End Property

    Private _clnCategoria As clnCategoria
    Public Property clnCategoria() As clnCategoria
        Get
            Return _clnCategoria
        End Get
        Set(value As clnCategoria)
        End Set
    End Property

    Private _pro_Descricao As String
    Public Property pro_Descricao() As String
        Get
            Return _pro_Descricao
        End Get
        Set(ByVal value As String)
            _pro_Descricao = value
        End Set
    End Property

    Private _pro_QtdeEstoque As Integer
    Public Property pro_QtdeEstoque() As Integer
        Get
            Return _pro_QtdeEstoque
        End Get
        Set(ByVal value As Integer)
            _pro_QtdeEstoque = value
        End Set
    End Property

    Private _pro_Valor As Decimal
    Public Property pro_Valor() As Decimal
        Get
            Return _pro_Valor
        End Get
        Set(ByVal value As Decimal)
            _pro_Valor = value
        End Set
    End Property

    Private _pro_Ativo As Boolean
    Public Property pro_Ativo() As Boolean
        Get
            Return _pro_Ativo
        End Get
        Set(ByVal value As Boolean)
            _pro_Ativo = value
        End Set
    End Property

    Public Sub Gravar()
        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO produto")

        strQuery.Append("(")

        strQuery.Append("cat_Id")
        strQuery.Append(", pro_Descricao")
        strQuery.Append(", pro_QtdeEstoque")
        strQuery.Append(", pro_Valor")
        strQuery.Append(", pro_Ativo")

        strQuery.Append(")")

        strQuery.Append(" VALUES ( ")

        strQuery.Append(" '" & _clnCategoria.cat_ID & "' ")
        strQuery.Append(" '" & _pro_Descricao & "' ")
        strQuery.Append(" '" & _pro_QtdeEstoque & "' ")
        strQuery.Append(" '" & _pro_Valor & "' ")
        strQuery.Append(" " & _pro_Ativo & " ")

        strQuery.Append(");")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Function Listar(ByVal strDescricao As String) As DataSet

        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT pro_Id as Codigo, pro_Descricao as Descricao ")
        strQuery.Append(" FROM produto ")

        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append("WHERE pro_Descricao like '%" & strDescricao & "%' ")
        End If
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    Public Sub Excluir(ByVal intCodigo As Integer)
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM produto ")
        strQuery.Append(" WHERE pro_id = " & intCodigo & "")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub Alterar()
        Dim strQuery As New StringBuilder()
        strQuery.Append(" UPDATE produto ")

        strQuery.Append(" SET ")

        strQuery.Append(" cat_Id = ' " & _clnCategoria.cat_ID & "' ")

        strQuery.Append(", pro_Descricao = '" & _pro_Descricao & "' ")
        strQuery.Append(", pro_QtdeEstoque = '" & _pro_QtdeEstoque & "' ")
        strQuery.Append(", pro_Valor = '" & _pro_Valor & "' ")
        strQuery.Append(", pro_Ativo = " & _pro_Ativo & "")

        strQuery.Append(" WHERE ")

        strQuery.Append(" pro_ID = " & _pro_id & " ")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Function ListarProduto(ByVal intCodigo As Integer) As OleDbDataReader

        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cai_Id, pro_descricao, pro_QtdeEstoque, pro-Valor, pro_Ativo ")
        strQuery.Append(" FROM produto")

        strQuery.Append(" WHERE pro_id = " & intCodigo & " ")

        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataReader(strQuery.ToString)

    End Function
End Class
