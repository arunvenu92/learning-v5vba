Module Module1

    Sub Main()
        ' What is a program?
        '   set of instructions
        ' What it comprises of?
        '   Data
        '       Variables
        '           native variables
        '               stack
        '               faster
        '               fixed
        '               dispose on their own
        '           object variables
        '               heap
        '               slower
        '               varying size
        '               dispose them explicitly
        '       Constants
        '       
        '   logic

        ' native variables
        ' lifecycle of variables
        '   declare
        '   use / assigning values
        '   dispose

        'Declaration
        ' Dim dimension
        ' name
        ' as 
        ' data type
        Dim flag As Boolean ' 2 bytes
        Dim num As Integer '4 bytes
        Dim precision As Single ' 4 bytes
        Dim accuracy As Double '8bytes
        Dim currency As Decimal ' 16 bytes
        Dim name As String 'depending on the size of string

        'assignment
        flag = True
        num = 10
        precision = 123.123456
        accuracy = 1.1243423525
        currency = 1.123545345345
        name = "Ruchira"

        Console.WriteLine(flag)
        Console.WriteLine(num)
        Console.ReadLine()


    End Sub

End Module
