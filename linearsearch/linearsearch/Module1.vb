Module Module1
    Sub Main()
        dim found As Boolean
        dim searchItem As String
        dim myList As New List(Of String)
        myList.Add("Apple")
        myList.Add("Banana")
        myList.Add("Cherry")
        
        Console.writeline ("What are you searching for?")
        searchItem = Console.readline
        For i = 0 To myList.Count - 1
            If myList(i) = searchItem Then
                found = True
            End If
        Next    
        console.WriteLine(found)    
    End Sub
End Module
