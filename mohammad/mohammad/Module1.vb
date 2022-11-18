Module Module1

    Function Search (a As String, b As List (of String))
        dim found as Boolean
        for i = 0 To b.Count - 1
            Console.WriteLine(b(i))
        Next
        
        For x = 0 To b.Count - 1
            If b(x) = a Then
                found = True
                return found
            
            End If
            
        Next
    End Function

    Sub Main()

        Dim input As String
        Dim found As Boolean
        Dim searchList As New List(Of String)
        searchList.Add("apple")
        searchList.Add("pineapple")
        searchList.Add("yogurt")
        searchList.Add("keyboard")
        searchList.Add("mouse")
        searchList.Add("mousepad")
        searchList.Add("monitor")

        Console.WriteLine("input a string of what you want to check for in the list")
        input = Console.ReadLine()
        found = Search(input, searchList)
        Console.writeline(found)
        Console.ReadKey()

    End Sub

End Module
