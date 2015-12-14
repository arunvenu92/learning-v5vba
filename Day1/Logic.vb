Module Logic
    'functions
    ' return a type / value
    'subroutines
    '    do not return a value

    'lifecycle of logic blocks
    '    declare
    '   implement /logic building
    '   call / use 

    Function DoThis() As Boolean
        'do something
        DoThisAsWell()
        Return True
    End Function

    Sub DoThisAsWell()
        ' Do something
        Dim flag As Boolean
        flag = DoThis()
    End Sub

    Sub MySub()
        DoThisAsWell()
        addition()
    End Sub

    Function addition() As Boolean
        Dim a As Integer = 10
        Dim b As Integer = 20
        Dim sum As Integer = a + b
        Return True
    End Function

    'signature
    '   keyword function
    '    name
    '   return type
    '   parameters
    '   no. of parameters
    ' type of parameters
    ' sequence of parameters
    Function CalculateAge(height As Integer, weight As Single, name As String) As Integer
        'body
        ' conditional statements

        If height = 6 Then
            'do something
            Console.WriteLine("Height is {0}", height)
        ElseIf height > 6 Then
            Console.WriteLine("Height is greatherthan 6")
        Else
            Console.WriteLine("If all the above conditions fail, then only this is printed")
        End If


        'select
        Dim myWeight As Single
        Select Case myWeight
            Case 20
                ' do somethhing
            Case 21, 22, 24
                ' do something
            Case Is > 30
                ' do something
            Case Else
                Console.WriteLine("If all the above conditions fail, then only this is printed")
        End Select

        'looping statements
        For index = 1 To 10
            Console.WriteLine(index)
        Next

        For index = 1 To 10 Step 2
            Console.WriteLine(index)
        Next

        For index = 5 To 1 Step -1
            Console.WriteLine(index)
        Next

        'while
        While height > 0
            Console.WriteLine("This is run till the above condition is true")
            height = height - 1
        End While

        ' Do while
        Do
            Console.WriteLine("This will be run atleast once")
            height = 0
        Loop While height > 0

        ' nesting ifs
        If height > 10 Then
            If name = "Ruchira" Then
            ElseIf name = "somethingelse" Then

            End If
        End If

        ' for and ifs
        For index = 1 To 10
            If index = 2 Then
                ' do something
            End If

        Next

        Return 10
    End Function

    Function CalculateAge() As Boolean

        Return 0
    End Function




End Module
