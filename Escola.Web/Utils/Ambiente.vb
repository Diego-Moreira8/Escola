Public Class Ambiente

    Public Shared Property EhDesenvolvimento As Boolean = ConfigurationManager.AppSettings("Ambiente") = "Desenvolvimento"
    Public Shared Property EhProducao As Boolean = ConfigurationManager.AppSettings("Ambiente") = "Producao"

End Class
