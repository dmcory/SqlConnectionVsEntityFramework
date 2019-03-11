Imports System.Data.Entity

Public Class MovieDBContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("MovieDBContext")
    End Sub

    Public Property Movies As DbSet(Of Movie)
End Class
