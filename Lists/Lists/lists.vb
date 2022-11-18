Module Module1
    Sub Main()
        dim myList As New List(Of String)
        myList.Add("Apple")
        myList.Add("Banana")
        myList.Add("Cherry")
        for i = 0 To myList.Count - 1
            Console.WriteLine(myList(i))
        Next
        for i = 1 To 3
            Console.WriteLine("Add a fruit")
            myList.Add(console.ReadLine())
        
            for i = 0 To myList.Count - 1
            Console.WriteLine(myList(i))
            Next    
        Next
End Sub
End Module
