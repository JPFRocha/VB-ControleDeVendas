Imports System.Data.OleDb

Public Class cldBancoDados
    Dim StringConexao As String = My.Settings.Conexão.ToString

    Private Function AbreBanco() As OleDbConnection
        Dim Conn As New OleDbConnection
        With Conn
            Conn.ConnectionString = StringConexao
            .Open()
        End With

        Return Conn
    End Function

    Private Sub FechaBanco(ByVal Conn As OleDbConnection)
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub

    Public Sub ExecutaComando(ByVal strQuery As String)
        Dim Conn As New OleDbConnection()
        Try
            Conn = AbreBanco()
            Dim cmdComando As New OleDbCommand
            With cmdComando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw ex
        Finally
            FechaBanco(Conn)
        End Try
    End Sub

    Public Function ExecutaComandoRetorno(ByVal strQuery As String) As Integer
        Dim Conn As New OleDbConnection()
        Dim dr As OleDbDataReader

        Try
            Conn = AbreBanco()

            Dim cmdComando As New OleDbCommand
            With cmdComando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn
                .ExecuteNonQuery()
                .CommandText = "Select @@Identity"

                dr = .ExecuteReader()
            End With
            dr.Read()

            Return dr(0)
        Catch ex As Exception
            Throw ex
        Finally
            FechaBanco(Conn)
        End Try
    End Function

    Public Function RetornaDataSet(ByVal strQuery As String)
        Dim Conn As New OleDbConnection()
        Try
            Conn = AbreBanco()
            Dim cmdComando As New OleDbCommand
            With cmdComando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn
            End With
            Dim daAdaptador As New OleDbDataAdapter
            Dim dsDataSet As New DataSet

            daAdaptador.SelectCommand = cmdComando

            daAdaptador.Fill(dsDataSet)

            Return dsDataSet

        Catch ex As Exception
            Throw ex
        Finally
            FechaBanco(Conn)
        End Try

    End Function

    Public Function RetornaDataReader(ByVal strQuery As String) As OleDbDataReader
        Dim Conn As New OleDbConnection()
        Try
            Conn = AbreBanco()

            Dim cmdComando As New OleDbCommand
            With cmdComando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn
            End With

            Return cmdComando.ExecuteReader

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
