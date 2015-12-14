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

        ' call a function
        addition()
        CalculateAge(10, 20, "Ruchira")

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


        'integer operations
        Dim num2 As Integer = 20
        Dim num3 As Integer = 30

        'addition
        Dim addResult As Integer
        addResult = num2 + num3
        Console.WriteLine("{0} number 1 plus {1} number 2 is equal to Addresult {2}", num2, num3, addResult)
        Console.ReadLine()


        'subtraction
        Dim subResult As Integer
        subResult = num3 - num2

        'product
        Dim prodResult As Integer
        prodResult = num2 * num3

        'division
        Dim divResult As Integer
        divResult = num3 / num2

        Dim quotient As Integer
        Dim remainder As Integer
        quotient = Math.DivRem(num2, num3, remainder)
        Console.WriteLine(quotient)

        'string operations
        Dim str1 As String
        Dim str2 As String

        str1 = "This is Day 1 of VB session"
        str2 = " and we are confident of learning VB or atleast are hopeful!"

        Dim strResult As String
        'concatenation
        strResult = str1 + str2 ' this is not recommended

        strResult = str1 & str2 ' use & for concatenation
        Console.WriteLine(strResult)
        Console.ReadLine()

        'position of string within a string
        Dim position As Integer
        position = InStr(strResult, "VB")
        Console.WriteLine(position)

        'Left and right operations
        Dim leftPortion As String
        Dim rightPortion As String

        leftPortion = Left(strResult, 25)
        rightPortion = Right(strResult, 25)
        Console.WriteLine("LeftPortion is {0}", leftPortion)
        Console.WriteLine("RightPortion is {0}", rightPortion)
        Console.ReadLine()

        'conversion of data types
        Dim number As Integer = 40
        Dim numAsString As String
        numAsString = CStr(number)
        numAsString = number.ToString()

        Dim newStr As String = "100"
        Dim strAsnumber As Integer
        strAsnumber = CInt(newStr)

        'CDbl
        'Csng

        ' cases of concatenation on string values and numerals
        Dim anotherNum As Integer = 20
        Dim anotherStr As String = "random string"
        Dim result As Integer = number.ToString() + anotherNum.ToString()
        Dim resultStr As String = numAsString & anotherStr
        Console.WriteLine("Number Result {0}", result)
        Console.WriteLine("String Result {0}", resultStr)
        Console.ReadLine()

        'object type variables
        Dim myColl As New Collection

        'adding items in the collection
        Dim strName As String = "bag"
        myColl.Add(1, "myNumber")
        myColl.Add("VB Session")
        myColl.Add(20)
        myColl.Add(strName)

        'retrieval of items
        Console.WriteLine(myColl.Item("myNumber"))
        Console.WriteLine(myColl.Item(2))
        Console.ReadLine()

        'removal
        myColl.Remove(2)

        Console.WriteLine(myColl.Item(1))
        Console.WriteLine(myColl.Item(2))
        Console.ReadLine()

        ' dispose
        myColl = Nothing ' empty collection


    End Sub

End Module
