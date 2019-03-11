Imports System.Threading.Tasks

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Async Function Movies() As Task(Of ActionResult)
        Dim list As New List(Of Movie)
        Dim m As New Movie
        list = Await m.GetAll
        Return View(list)
    End Function
End Class
