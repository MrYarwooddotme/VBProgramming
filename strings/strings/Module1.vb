Module Module1
    Sub Main()
        dim ask, email, name, agent, lastname, letter, sentence, last as String
        dim x as integer
        console.WriteLine("Enter a word")
        ask = console.readline.Tolower
        console.WriteLine(ask)
        Console.writeline("What is your email address?")
        email = Console.readline
        if email.Contains(" ") Then
            email = email.Replace(" ", "_")
            Console.writeline(email)
        End If
        Console.WriteLine("What is your name?")
        name = console.readline
        Console.writeline("{0} letters long", name.length)
        console.WriteLine("Which agent?")
        agent = console.ReadLine()
        if agent.Contains("James") Then
            agent = agent.replace("James", "XXXX")
        End If
        If agent.Contains("Bond") Then
            agent = agent.replace("Bond", "XXXX")
        End If
        Console.WriteLine(agent)
        Console.writeline("What is last name?")
        lastname = console.ReadLine()
        Console.WriteLine(name(0) & " " & lastname)
        Console.WriteLine("Enter a letter")
        letter = Console.readline
        Console.writeline ("Number #{0} in the alphabet", Asc(letter) -64)
        Console.WriteLine("Enter a sentence")
        sentence = console.readline
        last = sentence(sentence.Length-1) 'sentence.last
        if last = "." Then
            Console.WriteLine("Ends with a full stop")
        Else
            Console.writeline("Does not end with a full stop")
        End If
        if sentence.Contains("potato") Then
            Console.writeline("text does contain 'potato'")
        Else 
             Console.writeline("text does not contain 'potato'")   
        End If
    End Sub
End Module
