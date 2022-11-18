Module Module1
    Sub Main()
    Dim income, tax As Integer
    Dim monthlytax As Decimal
    Console.WriteLine("What's your annual income?")
    income = Console.ReadLine
    If income < 11000 Then
        tax = 0
    ElseIf income > 11001 And income < 43000 Then
        tax = (income - 11000) * 0.2
    ElseIf income > 43001 And income < 150000 Then
        tax = ((income - 43000) * 0.4) + ((43000 - 11000) * 0.2)
    ElseIf income > 150000 Then
        tax = ((income - 150000) * 0.45) + ((150000 - 43000) * 0.4) + ((43000 - 11000) * 0.2)
    End If
    monthlytax = tax / 12
        
    Console.WriteLine("Annual tax {0:c0}", tax)
        Console.WriteLine("monthly tax {0:c0}", monthlytax)
        Console.ReadKey()
    End Sub

End Module
