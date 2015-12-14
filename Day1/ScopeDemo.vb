Module ScopeDemo
    ' module level variable
    Dim number As Integer

    Function DoThisTask() As Integer
        'local variable
        Dim age As Integer = 20
        number = 20
        Return 0
    End Function

    Function DoThisAsWell() As Boolean
        number = 30
        Return True
    End Function
End Module
