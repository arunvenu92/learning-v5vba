Public Class Dog
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

    Sub New()
        Console.WriteLine("We are inside Dog's / child classes' constructor")
    End Sub

    Sub Bark()

    End Sub

    Overrides Sub Walk()
        Console.WriteLine("My Dog walks differently than Animal")
    End Sub
End Class
