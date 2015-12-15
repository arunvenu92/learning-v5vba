Module colleexercise

    Sub MultipleCollectionRemove()
        Dim names As New Collection()
        names.Add("Donald")
        names.Add("Launchpad")
        names.Add("Niranjan")
        names.Add("Ruchira")
        names.Add("Daffy")
        names.Add("Bugs")
        names.Add("Goofy")
        names.Add("Pluto")
        names.Add("Minnie")

        Dim namesToRemove = New Collection()
        namesToRemove.Add("Niranjan")
        namesToRemove.Add("Ruchira")

        For i = 1 To namesToRemove.Count
            For index = 1 To names.Count
                If names.Item(index) = namesToRemove.Item(i) Then
                    names.Remove(index)
                    Exit For
                End If
            Next
        Next
        For i = 1 To names.Count
            Console.WriteLine(names.Item(i))
        Next
        Console.ReadLine()
    End Sub

End Module
