Module Module1
    Sub Main()
        dim people, milk, water, teaNoMilk As Integer
        console.writeLine("How many people would like a cup of tea?")
        people = console.readline
        while people < 0
            console.writeLine("You have entered an invalid amount, how many would like tea?")
            people = console.ReadLine()
        End While
        
        Console.WriteLine("How many would like milk?")
        milk = Console.ReadLine()
        while milk > people
            Console.writeline("You have entered an invalid amount, how many would like milk")
            milk  = console.readline
        End while    
        teaNomilk = people - milk
        water = (teaNoMilk * 250) + (milk * 200)
        milk = milk * 50
        
        Console.writeLine("We need {0} ml of water, {1} ml of milk and {2} tea bags.", water, milk, people )
        if water > 1500 Then
            Console.WriteLine("Boil the kettle twice")
        End If
        
        
    End Sub
End Module
