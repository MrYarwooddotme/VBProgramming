Module Countingforchildren
    Sub Main()
        dim guess, answer, total, goes as integer
        dim gameover as boolean = false
        Randomize()
        
        total = Int(10  - 5) * Rnd + 5
        answer = 0
        goes = 0
        Console.WriteLine("Today we will be counting to {0}", total)
        Console.WriteLine("Let's go")
        do
            goes = goes + 1
            answer = answer + 1
            
            guess = console.readline
            if guess <> answer
                gameover = true
                
            End If
            
        Loop Until goes = total or gameover = true
        if guess <> answer
            gameover = true
            Console.WriteLine("NO WRONG CHILD!")
            else
                console.writeline("YOU CAN COUNT OMG")
        End If
    End Sub
End Module
