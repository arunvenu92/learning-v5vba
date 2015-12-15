Public Class Animal
    Implements ISound


    Private _age As Integer
    Private _name As String
    Private _weight As Single

    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            _age = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Weight() As Single
        Get
            Return _weight
        End Get
        Set(ByVal value As Single)
            _weight = value
        End Set
    End Property

    Sub New()
        _age = 1
        Console.WriteLine("Animal's constructor")
    End Sub

    Sub New(name As String)
        Console.WriteLine("We are inside overloaded constructor")
    End Sub
    Overridable Sub Walk()
        Console.WriteLine("This is the Animal walking")
    End Sub


    Public Sub MakeSound() Implements ISound.MakeSound
        'define specifc implementation of sound sub
    End Sub

    Public Sub MakeNoise() Implements ISound.MakeNoise

    End Sub
End Class
