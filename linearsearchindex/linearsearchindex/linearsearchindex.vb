Option Strict On
Module Module1
    Sub Main()
        
        dim searchItem As String
        dim myList As New List(Of String)
        dim foundPosition = -1
        myList.Add("Apple")
        myList.Add("Banana")
        myList.Add("Cherry")
        
        Console.writeline ("What are you searching for?")
        searchItem = Console.readline
        For i = 0 To myList.Count - 1
            If myList(i) = searchItem Then
                foundPosition = i
            End If
        Next    
        console.WriteLine(foundPosition)    
    End Sub
End Module
