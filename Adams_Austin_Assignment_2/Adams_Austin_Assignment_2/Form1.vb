Public Class Form1
    Private DB As New DBAccess
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DBDataGridView.ReadOnly = True

        DB.ExecuteQuery("Select * From Customer")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        'Fill data grid
        DBDataGridView.DataSource = DB.DBDataTable
    End Sub
    Private Sub LastNameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles LastNameTextBox.TextChanged
        DB.AddParam("@lastname", LastNameTextBox.Text & "%")
        DB.ExecuteQuery("Select * FROM customer WHERE Last_name LIKE?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        'FIll Data Grid
        DBDataGridView.DataSource = DB.DBDataTable

        If FirstNameTextBox.Text <> "" Then FirstNameTextBox.Clear()
    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles FirstNameTextBox.TextChanged
        DB.AddParam("@firstname", FirstNameTextBox.Text & "%")
        DB.ExecuteQuery("SELECT * FROM customer Where first_name LIKE?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        DBDataGridView.DataSource = DB.DBDataTable

        If LastNameTextBox.Text <> "" Then LastNameTextBox.Clear()
    End Sub

    Imports System.Data.Odbc
    Public Class DBAccess
        'Create DB Connection
        Private ConnectionString As String = "Driver={MySQL OBDC 5.3 ANSI Driver};
Server=141.209.241.47; database=sakila; user=bis425; password=test"
        Private DBConnection As New odbcConnection(ConnectionString)

        Private DBCommand As OdbcCommand

        'DB data. Make them public as they need to be accessed from presentation tier.
        Public DBDataAdapter As OdbcDataAdapter
        Public DBDataTable As DataTable
        'query parameters
        Public Params As New List(Of OdbcParameter)
        'query statistics
        Public RecordCount As Integer
        Public Exception As String
        'create a general procedure to execute queries to a database.
        Public Sub ExecuteQuery(QueryString As String)
            'reset query statistics
            RecordCount = 0
            Exception = String.Empty
            Try
                'open a database connection
                DBConnection.Open()
                'create a database command
                DBCommand = New OdbcCommand(QueryString, DBConnection)
                'load parameters into DB command.
                For Each p As OdbcParameter In Params
                    DBCommand.Parameters.Add(p)
                Next
                'clear parameter list
                Params.Clear()
                'execute command and fill database
                DBDataTable = New DataTable
                DBDataAdapter = New OdbcDataAdapter(DBCommand)
                RecordCount = DBDataAdapter.Fill(DBDataTable) 'all query results will be
                loaded into the data table.
 Catch ex As Exception
                Exception = ex.Message
            End Try
            'close db connection
            If DBConnection.State = ConnectionState.Open Then
                DBConnection.Close()
            End If
        End Sub
        'accept parameters for queries.
        Public Sub AddParam(Name As String, Value As Object)
            Dim NewParam As New OdbcParameter(Name, Value)
            Params.Add(NewParam)
        End Sub
    End Class
