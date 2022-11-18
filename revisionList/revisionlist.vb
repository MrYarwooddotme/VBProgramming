Module Module1
    Function CheckIfInList(thelist As List(Of String), searchitem As String)
        For n = 0 To thelist.Count -1
            If thelist(n) = searchitem Then
                Return True
            End If
        Next
        Return False
    End Function
    Sub Main()
        Dim topic As String
        Dim score As Integer
        Dim topiclist As New List(Of String)
        Dim revisionlist As New List(Of String)
        Dim topicInList As Boolean
        Do
            Console.WriteLine("Enter what topic you have been studying")
            topic = console.ReadLine()
            Console.WriteLine("What was the score for that topic?")
            score = console.ReadLine()
            If CheckIfInList(topiclist, topic) = False Then
                topiclist.Add(topic)
            End If
            If CheckIfInList(revisionlist, topic) = False And Score <5 Then 
                revisionlist.Add(topic)
            ElseIf CheckIfInList(revisionlist, topic) = True And score >= 5 Then
                revisionlist.Remove(topic)    
            End If
            
            Console.writeline ("here is your topic list ") 
            For counter = 0 to topiclist.Count -1
                Console.writeline (topiclist(counter))
            Next
            Console.writeline ("here is your revision list, ")
            For counter =  0 To revisionlist.Count -1
                Console.Writeline(revisionlist(counter))
                
            Next
            Console.WriteLine("................................")
        loop    
    End Sub
End Module
