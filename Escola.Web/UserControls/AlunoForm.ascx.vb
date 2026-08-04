Public Class AlunoForm
    Inherits System.Web.UI.UserControl

    Public Property Nome As String
        Get
            Return txtNome.Text
        End Get
        Set(value As String)
            txtNome.Text = value
        End Set
    End Property

    Public Property DataNascimento As Date
        Get
            Return Date.Parse(txtDataNascimento.Text)
        End Get
        Set(value As Date)
            txtDataNascimento.Text = value.ToString("yyyy-MM-dd")
        End Set
    End Property

End Class