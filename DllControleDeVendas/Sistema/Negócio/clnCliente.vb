Imports System.Data.OleDb
Imports System.Text

Public Class clnCliente
    Private _cli_Id As Integer
    Public Property cli_Id() As Integer
        Get
            Return _cli_Id
        End Get
        Set(ByVal value As Integer)
            _cli_Id = value
        End Set
    End Property

    Private _cli_NomeRazao As String
    Public Property cli_NomeRazao() As String
        Get
            Return _cli_NomeRazao
        End Get
        Set(ByVal value As String)
            _cli_NomeRazao = value
        End Set
    End Property

    Private _cli_CNPJCPF As String
    Public Property cli_CNPJCPF As String
        Get
            Return _cli_CNPJCPF
        End Get
        Set(ByVal value As String)
            _cli_CNPJCPF = value
        End Set
    End Property

    Private _cli_Logradouro As String
    Public Property cli_Logradouro() As String
        Get
            Return _cli_Logradouro
        End Get
        Set(ByVal value As String)
            _cli_Logradouro = value
        End Set
    End Property

    Private _cli_Bairro As String
    Public Property cli_Bairro() As String
        Get
            Return _cli_Bairro
        End Get
        Set(ByVal value As String)
            _cli_Bairro = value
        End Set
    End Property

    Private _cli_Cidade As String
    Public Property cli_Cidade() As String
        Get
            Return _cli_Cidade
        End Get
        Set(ByVal value As String)
            _cli_Cidade = value
        End Set
    End Property

    Private _cli_Uf As String
    Public Property cli_Uf() As String
        Get
            Return _cli_Uf
        End Get
        Set(ByVal value As String)
            _cli_Uf = value
        End Set
    End Property

    Private _cli_CEP As String
    Public Property cli_CEP() As String
        Get
            Return _cli_CEP
        End Get
        Set(ByVal value As String)
            _cli_CEP = value
        End Set
    End Property

    Private _cli_Email As String
    Public Property cli_Email() As String
        Get
            Return _cli_Email
        End Get
        Set(ByVal value As String)
            _cli_Email = value
        End Set
    End Property

    Private _cli_Fones As String
    Public Property cli_Fones() As String
        Get
            Return _cli_Fones
        End Get
        Set(ByVal value As String)
            _cli_Fones = value
        End Set
    End Property

    Private _cli_DtCadastro As DateTime
    Public Property cli_DtCadastro() As DateTime
        Get
            Return _cli_DtCadastro
        End Get
        Set(ByVal value As DateTime)
            _cli_DtCadastro = value
        End Set
    End Property

    Public Sub Gravar()
        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO cliente ")

        strQuery.Append(" ( ")

        strQuery.Append(" cli_NomeRazao ")
        strQuery.Append(", cli_CNPJCPF ")
        strQuery.Append(", cli_Logradouro ")
        strQuery.Append(", cli_Bairro ")
        strQuery.Append(", cli_Cidade ")
        strQuery.Append(", cli_Uf ")
        strQuery.Append(", cli_CEP ")
        strQuery.Append(", cli_Email ")
        strQuery.Append(", cli_Fones ")
        strQuery.Append(", cli_DtCadastro ")

        strQuery.Append(" ) ")

        strQuery.Append(" VALUES ( ")

        strQuery.Append(" '" & cli_NomeRazao & "' ")
        strQuery.Append(", '" & _cli_CNPJCPF & "' ")
        strQuery.Append(", '" & _cli_Logradouro & "' ")
        strQuery.Append(", '" & _cli_Bairro & "' ")
        strQuery.Append(", '" & _cli_Cidade & "' ")
        strQuery.Append(", '" & _cli_Uf & "' ")
        strQuery.Append(", '" & _cli_CEP & "' ")
        strQuery.Append(", '" & _cli_Email & "' ")
        strQuery.Append(", '" & _cli_Fones & "' ")
        strQuery.Append(", '" & _cli_DtCadastro & "' ")

        strQuery.Append(" ); ")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub Alterar()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE cliente ")

        strQuery.Append(" SET ")

        strQuery.Append(" cli_NomeRazao = '" & _cli_NomeRazao & "' ")
        strQuery.Append(", cli_CNPJCPF = '" & _cli_CNPJCPF & "' ")
        strQuery.Append(", cli_Logradouro = '" & _cli_Logradouro & "' ")
        strQuery.Append(", cli_Bairro = '" & _cli_Bairro & "' ")
        strQuery.Append(", cli_Cidade = '" & _cli_Cidade & "' ")
        strQuery.Append(", cli_Uf = '" & _cli_Uf & "' ")
        strQuery.Append(", cli_CEP = '" & _cli_CEP & "' ")
        strQuery.Append(", cli_Email = '" & _cli_Email & "' ")
        strQuery.Append(", cli_Fones = '" & _cli_Fones & "' ")

        strQuery.Append(" WHERE ")

        strQuery.Append(" cli_ID = " & _cli_Id & " ")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Function Listar(ByVal strDescricao As String) As DataSet

        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cli_Id as Codigo, cli_NomeRazao as Descricao ")
        strQuery.Append(" FROM cliente ")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE cli_NomeRazao like '%" & strDescricao & "%' ")
        End If

        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function

    Public Sub Excluir(ByVal intCodigo As Integer)

        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM cliente ")
        strQuery.Append(" WHERE cli_id = " & intCodigo & "")

        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Function ListarCliente(ByVal intCodigo As Integer) As OleDbDataReader

        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cli_NomeRazao, cli_CNPJCPF, cli_Logradouro, cli_Bairro, cli_Cidade, cli_Uf, cli_CEP, cli_Email, cli_Fones ")
        strQuery.Append(" FROM cliente ")

        strQuery.Append(" WHERE cli_id = " & intCodigo & " ")

        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataReader(strQuery.ToString)
    End Function
End Class
