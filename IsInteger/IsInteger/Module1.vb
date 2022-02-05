Module Module1
    Function IsInteger(ByVal x As decimal)
        'If x = Int(x) 'The Alaa and Aneurin method
        If (x * 10) mod 10 = 0 Then 'Another method?'
            return True
        Else
            return False
        End If
    End Function
    Sub Main()
        Dim n, f, d As Decimal
        Console.WriteLine("Enter value:")
        n = Console.ReadLine
        f = 2
        While n > 1
            d = n / f
            If IsInteger(d) = True Then
                Console.WriteLine(f)
                n = d
            Else
                f = f + 1
            End If
        End While
        Console.ReadKey()
    End Sub
End Module
