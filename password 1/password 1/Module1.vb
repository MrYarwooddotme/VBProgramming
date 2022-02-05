Module Module1
    Sub Main()
        dim password as String
        dim valid As Boolean = False 
        Console.WriteLine("enter the password")
        password = console.ReadLine()
        for i = 1 to password.length - 1
            if Char.IsDigit(password(i)) then
                valid = True
            End If
            If Char.IsLetter(password(i)) Then
                valid = True
            End If
        Next
        
    End Sub
End Module
