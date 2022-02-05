Module Module1
    
    Function Spin()
        Dim randomiser As New Random
        Dim random_number As Integer
        Randomize()
        random_number = randomiser.Next(0, 37)
        Console.WriteLine("Spinning")
        Console.writeline("and the number is....{0}", random_number )
        return random_number
    End Function
    
    Function oddOrEven (balance As Integer)
        Dim betType As String
        Dim betAmount, roulettenumber As Integer
        Console.WriteLine("Bet on odd or even?")
        betType = Console.ReadLine
        Console.WriteLine("How much do you bet?")
        betAmount = Console.ReadLine 
        while betAmount > balance
            Console.writeLine("Sorry you have insufficient funds, please enter an amount equal to or below {0}", balance)
            betAmount = Console.ReadLine
        End While
        roulettenumber  = spin()
            
        If betType = "odd" And roulettenumber Mod 2 = 1 Then
                
            betAmount = betAmount*2
            console.WriteLine("you win £{0}",betAmount)
            balance = balance + betAmount
            
        ElseIf betType = "even" And roulettenumber Mod 2 = 0 Then
                
            betAmount = betAmount*2
            console.WriteLine("you win £{0}",betAmount)
            balance = balance + betAmount
            
        Else
            Console.WriteLine("You lose...")
            balance = balance - betAmount
            
        End If
        return balance    
    End Function
    Function redOrBlack (balance As Integer)
        Dim betType As String
        Dim betAmount, roulettenumber As Integer
        Dim red As New List(Of Integer) From {1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36}
        Dim black As New List(Of Integer) From {2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35}
        Dim win As Boolean
        Console.WriteLine("Bet on red or black?")
        betType = Console.ReadLine
        Console.WriteLine("How much do you bet?")
        betAmount = Console.ReadLine 
        while betAmount > balance
            Console.writeLine("Sorry you have insufficient funds, please enter an amount equal to or below {0}", balance)
            betAmount = Console.ReadLine
        End While
        roulettenumber  = spin()
        If betType = "red" then 
            For i = 0 To red.Count - 1
                If red(i) = roulettenumber And betType = "red" Then
                win = True
                End If
            Next
        ElseIf bettype = "black" then    
            For i = 0 To black.Count -1
                If  black(i) = roulettenumber Then
                win = True
            End If        
            Next
        Else   
            win = False
        End If
        If win = True Then
            betAmount = betAmount*3
            console.WriteLine("you win £{0}",betAmount)
            balance = balance + betAmount   
        
        Else
            Console.WriteLine("You lose...")
            balance = balance - betAmount
        End If
        return balance    
    End Function
    Function straightUp (balance) As Integer
        Dim betType As Integer
        Dim betAmount, roulettenumber As Integer
        Console.WriteLine("Which number?")
        betType = Console.ReadLine
        Console.WriteLine("How much do you bet?")
        betAmount = Console.ReadLine 
        while betAmount > balance
            Console.writeLine("Sorry you have insufficient funds, please enter an amount equal to or below {0}", balance)
            betAmount = Console.ReadLine
        End While
        roulettenumber  = spin()
            
        If betType = roulettenumber Then
                
            betAmount = betAmount*35
            console.WriteLine("you win £{0}",betAmount)
            balance = balance + betAmount
            
        Else
            Console.WriteLine("You lose...")
            balance = balance - betAmount
            
        End If
        return balance    
    End Function
    Sub Main()
        dim game, balance As Integer
        balance = 100
        while balance > 0
            Console.WriteLine("You have £{0}", balance)
            Console.WriteLine("Which game would you like to play?")
            Console.WriteLine("1 for Odds and Evens")
            Console.WriteLine("2 for red or black")
            Console.WriteLine("3 for Straight Up")
            game = Console.readline
            if game = 1 Then
                balance = oddOrEven(balance)
            ElseIf game = 2 Then
                balance = redOrBlack(balance)
            ElseIf game = 3 Then
                balance = straightUp(balance)
            Else
                Console.WriteLine("That game is not available")
            End if
        End While    
        Console.writeLine("You have no money left!")
    End Sub
End Module
