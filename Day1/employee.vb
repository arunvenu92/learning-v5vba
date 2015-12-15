Public Class Employee ' base class / parent class / generic
    Private _name As String
    Private _email As String
    Private _Id As Integer

    Function register() As Integer
        _name = "ruchira"
        _Id = 106456
        Return 0
    End Function

    'Function GetName() As String
    '    Return _name
    'End Function

    'Sub SetName()
    '    _name = "Ruchira"
    'End Sub


    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            If True Then
                _name = value
            End If
        End Set
    End Property

    Public ReadOnly Property Id() As Integer
        Get
            Return _Id
        End Get
    End Property

    Public WriteOnly Property Email() As String
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

End Class
