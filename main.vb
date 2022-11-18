Module HelloWorld
	Sub Main()
    dim Guess, Answer As Integer
    Randomize()
    Answer = Int(Rnd()*100)+1
    Do
			Console.WriteLine("Guess the number?")
      Guess = Console.readline
      If Guess = Answer then
      console.writeline("You are correct")
      else
      console.writeline("No wrong")
      end if
    Loop Until Answer = Guess
	End Sub
End Module