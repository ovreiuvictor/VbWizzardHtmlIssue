Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim model As New Equipment

        model.Description = "d"
        model.Symbol = "d"

        Return View(model)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your app description page."

        Return View()
    End Function
    
    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

End Class
