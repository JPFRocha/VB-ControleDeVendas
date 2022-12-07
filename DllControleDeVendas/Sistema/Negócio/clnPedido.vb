Imports System.Text
Public Class clnPedido

    Private _ped_id As Integer
    Public Property ped_() As Integer
        Get
            Return _ped_id
        End Get
        Set(ByVal value As Integer)
            _ped_id = value
        End Set
    End Property

    Private _clnCliente As clnCliente
    Public Property clnCliente() As clnCliente
        Get
            Return _clnCliente
        End Get
        Set(ByVal value As clnCliente)
            _clnCliente = value
        End Set
    End Property

    Private _ped_DtEncomenda As DateTime
    Public Property ped_DtEncomenda() As DateTime
        Get
            Return _ped_DtEncomenda
        End Get
        Set(ByVal value As DateTime)
            _ped_DtEncomenda = value
        End Set
    End Property


    Private _ped_Valor As Decimal
    Public Property ped_Valor() As Decimal
        Get
            Return _ped_Valor
        End Get
        Set(ByVal value As Decimal)
            _ped_Valor = value
        End Set
    End Property

    Private _ped_Status As Char
    Friend ped_id As String
    Friend pro_id As String

    Public Property ped_Status() As Char
        Get
            Return _ped_Status
        End Get
        Set(ByVal value As Char)
            _ped_Status = value
        End Set
    End Property

    Public Function Gravar() As Integer

        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO pedido ")

        strQuery.Append(" ( ")

        strQuery.Append(" cli_Id ")
        strQuery.Append(", ped_dtEncomenda ")
        strQuery.Append(", ped_Valor ")
        strQuery.Append(", ped_Status ")

        strQuery.Append(" ) ")

        strQuery.Append(" VALUES ( ")

        strQuery.Append(" '" & _clnCliente.cli_Id & "' ")
        strQuery.Append(", '" & _ped_DtEncomenda & "' ")
        strQuery.Append(", '" & _ped_Valor & "' ")
        strQuery.Append(", '" & _ped_Status & "' ")

        strQuery.Append(" ); ")

        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.ExecutaComandoRetorno(strQuery.ToString)

    End Function

End Class
