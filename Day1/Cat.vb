Public Class Cat
    Inherits Animal

    Private _breed As String
    Public Property Breed() As String
        Get
            Return _breed
        End Get
        Set(ByVal value As String)
            _breed = value
        End Set
    End Property

End Class
