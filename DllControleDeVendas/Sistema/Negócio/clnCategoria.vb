Imports System.Data.OleDb
Imports System.Text
Public Class clnCategoria
    Private _cat_ID As Integer
    Public Property cat_ID() As Integer
        Get
            Return _cat_ID
        End Get
        Set(ByVal value As Integer)
            _cat_ID = value
        End Set
    End Property

    Private _cat_Descricao As String
    Public Property cat_Descricao() As String
        Get
            Return _cat_Descricao
        End Get
        Set(ByVal value As String)
            _cat_Descricao = value
        End Set
    End Property

    Public Function Lista(ByVal strDescricao As String) As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append("Select cat_ID as Codigo, cat_Descricao as Descricao")
        strQuery.Append("FROM Categoria")

        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append("WHERE  cat_Descricao like '%" & strDescricao & "%' ")
        End If

        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function

    Public Sub Excluir(ByVal intCodigo As Integer)
        Dim strQuery As New StringBuilder
        strQuery.Append("DELETE FROM categoria")
        strQuery.Append("Where cat_id=" & intCodigo & "")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub Gravar()
        Dim strQuery As New StringBuilder
        strQuery.Append("(")
        strQuery.Append("cat_Descricao")
        strQuery.Append(")")
        strQuery.Append("VALUES ( ")
        strQuery.Append("'" & cat_Descricao & "'")
        strQuery.Append(");")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub Alterar()
        Dim strQuery As New StringBuilder
        strQuery.Append("UPDATE categoria")
        strQuery.Append("SET")
        strQuery.Append("cat_Descricao = ' " & _cat_Descricao & "'")
        strQuery.Append("WHERE")
        strQuery.Append("cat_ID = " & _cat_ID & "")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function ListarCategoria(ByVal intCodigo As Integer) As OleDbDataReader
        Dim strQuery As New StringBuilder
        strQuery.Append("SELECT cat_Descricao")
        strQuery.Append("FROM categoria")

        strQuery.Append("WHERE cat_id = " & intCodigo & "")

        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataReader(strQuery.ToString)

    End Function
End Class
