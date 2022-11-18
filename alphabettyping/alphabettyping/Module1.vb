Module Module1
    Sub Main()
        dim points as Integer
        dim letter as Char
        dim attempt as String
        dim check as Char
        dim alphabet as String = "abcdefghijklmnopqrstuvwxyz"
        dim alphabetcheck as Char
        Console.WriteLine("3")
        Threading.Thread.Sleep(1000)
        Console.WriteLine("2")
        Threading.Thread.Sleep(1000)
        Console.WriteLine("1")
        Threading.Thread.Sleep(1000)
        Console.WriteLine("GO")
        Dim startTime, endTime As DateTime
        startTime = Now()
        
        For counter = 1 to 26
            letter = console.ReadLine()
            attempt = attempt + letter
        Next
        
        endTime = Now()
        Console.WriteLine("Started at {0}", startTime)
        Console.WriteLine("Finished at {0}", endTime)
        Console.WriteLine(endtime - startTime)
        Console.writeline(attempt)
        For i = 1 to 26
            check = Mid(attempt,i,1)
            alphabetcheck = Mid(alphabet, i, 1)
            if check = alphabetcheck Then
                points = points + 1
            End If
        Next
Console.WriteLine("Your points are " & points)
    End Sub
End Module
