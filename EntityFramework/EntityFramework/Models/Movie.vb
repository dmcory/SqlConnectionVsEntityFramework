Imports System.Data.Entity
Imports System.Threading.Tasks

Public Class Movie
    Public Property id As Integer
    Public Property Name As String
    Public Property Genre As String

#Region "data"
    Private ReadOnly _dbContext As New MovieDBContext
    Async Function GetAll() As Task(Of List(Of Movie))
        Return Await _dbContext.Movies.ToListAsync
    End Function
#End Region
End Class
