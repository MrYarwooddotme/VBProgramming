Module Module1
    Sub Main()
        dim words as New list (of String)
        dim guess as string
        dim score, n as integer
        dim game as boolean
        Randomize()
        n = 0
        game = true
        words.addrange({"dog", "cat", "rabbit", "hamster", "spider", "snake", "rat", "goldfish", "fox", "badger", "wolf", "owl" })
        words = words.OrderBy(Function() Rnd()).ToList
        Console.WriteLine("Take a moment to remember these words, press any key when you are ready to continue")
        Console.ReadKey()
        Console.Clear()
        For counter = 0 To 7
            Console.WriteLine(words(counter))
        Next
        Console.WriteLine("Now press any key to continue")
        Console.ReadKey()
        Console.Clear()
        
        do
            Console.writeline("Enter word")
            guess = console.readline
            if guess = words(n) Then
                score = score + 1
                n = n + 1
                Console.WriteLine("Correct!")
                
            Else 
                console.WriteLine("Sorry that is incorrect")
                Console.WriteLine("Your score is {0}", score)
                game = false    
            End If
        loop until game = false or n = 8
        
        if score = 8 Then
            Console.WriteLine("You win!")
        
        Else 
            Console.writeline("You lose")
        End If
    End Sub
End Module
