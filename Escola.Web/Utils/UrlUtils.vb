Public Class UrlUtils

    Public Shared Function ObterMatriculaDeURL(request As HttpRequest) As Integer

        Dim Matricula As Integer

        If Integer.TryParse(request.QueryString("matricula"), Matricula) Then
            Return Matricula
        End If

        Return Nothing

    End Function

End Class
