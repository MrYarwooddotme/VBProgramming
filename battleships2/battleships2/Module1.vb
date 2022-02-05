Imports System
Public Module Module1
    Public Sub Main()
        dim game_over as boolean = false
        dim grid(10, 10) as char
        dim gamegrid(10,10) as char
        SetUpGrid(grid, gamegrid)
        Do
            DisplayGrid(gamegrid)
            PlayGame(grid, gamegrid)
        loop until game_over = true
    End Sub
    sub SetUpGrid(byref grid(,) as char, gamegrid(,) as char)
        for y = 1 to 10
            for x = 1 to 10
                grid(x, y) = "~"
                gamegrid(x, y) = "~"
            Next
        next
        grid(2, 3) = "S"
        grid(7, 8) = "S"
        grid(9, 9) = "S"
        grid(6, 2) = "S"
        grid(2, 8) = "S"
        grid(5, 1) = "S"
        grid(2, 7) = "S"
    end sub
    sub Playgame(byref grid(,) as Char, gamegrid(,) as char)
        dim x, y as Integer
        Console.WriteLine("Enter x coordinate")
        x = Console.readline()
        Console.WriteLine("Enter y coordinate")
        y = Console.readline()
        
        if grid(x,y) = "S" Then
            Console.WriteLine("hit")
            gamegrid(x,y) = "H"
        Else 
            Console.writeline ("miss")
            gamegrid(x,y) = "M"
        End If
    end sub

    sub DisplayGrid(gamegrid(,) as char)
        for y = 1 to 10
            for x = 1 to 10
                
                console.write(gamegrid(x, y))
            Next
            Console.writeline
        next
        
    end sub
End Module