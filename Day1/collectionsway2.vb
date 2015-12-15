Module collectionsway2

    '2 collections
    '1 collection has 10 names
    'second collection is empty
    'code such that : transfer of all the names from one collection to another 
    'except the one which has your name

    Dim coll1 As New Collection
    Dim coll2 As New Collection

    Sub myCollection()
        'Add items in collection 1
        coll1.Add("Niranjan")
        coll1.Add("Ruchira")
        coll1.Add("Ajith")
        coll1.Add("Priyanka")
        coll1.Add("Yogesh")
        coll1.Add("Siddy")
        coll1.Add("Sid")
        coll1.Add("Tom")
        coll1.Add("Jerry")
        coll1.Add("Mickey")

        'print items in collection 1
        For Each item In coll1
            Console.WriteLine(item)
        Next
        Console.ReadLine()
        'add all items in collection 2 where name is not my name
        'run the loop from 1 to items in the collection 1
        For index = 1 To coll1.Count
            coll2.Add(coll1.Item(index))
        Next

        'retrieval of items in collection 2
        For count = 1 To coll2.Count
            If coll2.Item(count) = "Ruchira" Then
                coll2.Remove(count)
                Exit For
            End If
        Next

        For Each item In coll2
            Console.WriteLine(item)
        Next
        Console.ReadLine()
    End Sub

End Module


