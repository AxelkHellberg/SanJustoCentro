Imports System.Data.SqlClient
Public MustInherit Class ConnectionToSql
    Private connectionString As String
    Public Sub New()
        'connectionString = "Server=IGGI662\PRUEBA1; DataBase=VerdaderoBackupSanJusto; integrated security= true"
        connectionString = "Server=45.169.100.7; DataBase=sanjusto_centro; User Id=sanjusto_sanjusto ; Password=sz2dKOe&Y9~J35"
    End Sub
    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
