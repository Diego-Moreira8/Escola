Public Class UsuarioJaExisteException

    Inherits Exception

    Public Sub New()
        MyBase.New("Nome de usuário já existe.")
    End Sub

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

    Public Sub New(message As String, innerException As Exception)
        MyBase.New(message, innerException)
    End Sub

End Class
