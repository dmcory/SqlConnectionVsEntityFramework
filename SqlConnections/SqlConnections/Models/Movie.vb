Imports System.Data.SqlClient

Public Class Movie
    Public Property id As Integer
    Public Property Name As String
    Public Property Genre As String

#Region "data"
    Async Function GetAll() As Threading.Tasks.Task(Of List(Of Movie))
        Dim list As New List(Of Movie)
        Using con As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("MovieDBContext").ConnectionString)
            con.Open()
            Using SqlCommand = New SqlCommand("SELECT * FROM Movies", con)
                Using dr As SqlDataReader = Await SqlCommand.ExecuteReaderAsync
                    While dr.Read
                        list.Add(New Movie With {.id = dr.GetInt32(0), .Name = dr.GetString(1), .Genre = dr.GetString(2)})
                    End While
                    Return list
                End Using
            End Using
            con.Close()
        End Using
    End Function
#End Region
End Class
