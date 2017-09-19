Imports System.Data.Odbc
Imports System.Data
Imports System.Data.SqlClient


Public Class DBAccess
    Public DBCommand As OdbcCommand
    Private ConnectionString As String = "Driver={MySQL ODBC 5.3 ANSI Driver};SERVER=141.209.241.47;DATABASE=bis425;USER=bis425c1g1;PASSWORD=initpass"
    Private DBConnection As New OdbcConnection(ConnectionString)
    Public DBdataAdapter As OdbcDataAdapter
    Public DBDataTable As DataTable
    Public Params As New List(Of OdbcParameter)
    Public RecordCount As Integer
    Public DBReader As OdbcDataReader
    Public Exception As String
    Public Sub ExecuteQuery(QueryString As String)
        RecordCount = 0
        Exception = String.Empty

        Try
            'open a data connection
            DBConnection.Open()

            'create database command
            DBCommand = New OdbcCommand(QueryString, DBConnection)

            'load aparameters into DBCOmmand
            For Each p As OdbcParameter In Params
                DBCommand.Parameters.Add(p)
            Next

            Params.Clear()

            DBDataTable = New DataTable
            DBdataAdapter = New OdbcDataAdapter(DBCommand)

            RecordCount = DBdataAdapter.Fill(DBDataTable)
        Catch ex As Exception
            'Carry message into presentation tier
            Exception = ex.Message
        End Try

        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If
    End Sub
    'Procedure to accept parameters for queries
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OdbcParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
End Class
