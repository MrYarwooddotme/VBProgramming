Imports System.Console
Module Coin
    Dim _lives As Integer = 3
    Dim _Score As Integer = 0
    'this is a CLASS/RECORD, a data structure that can hold items of data of different types
    Class GameEntity
        Public x, y As Integer
        Public ReadOnly symbol As Char
        'the CONSTRUCTOR for this class lets us make a player, passing the necessary parameters
        Sub New(startx As Integer, starty As Integer, defaultsymbol As Char)
            x = startx
            y = starty
            symbol = defaultsymbol
        End Sub
    End Class
 
    Sub Main()
        CursorVisible = False
        OutputEncoding = Text.Encoding.UTF8 'allow use of UNICODE characters
        menu()
    End Sub
    Sub menu()
        Dim go As String
        Do
            WriteLine("Welcome press 1 to play")
            go = ReadLine()
        Loop Until go = "1"
        Console.clear
        Play()
    End Sub
    Sub Setup(ByRef grid(,) As Char) 'REFERENCE parameter lets us modify the array values
       'grass
        For y = 0 To 19
            For x = 0 To 19
                grid(x, y) = chrw(9608)
            Next
        Next
        'pool
        For y = 6 To 9
            For x = 6 To 9
                grid(x, y) = chrw(9618)
            Next
        Next
        For y = 14 To 18
            For x = 11 To 16
                grid(x, y) = chrw(9618)
            Next
        Next
        'Rocks
        For y = 2 To 3
            For x = 2 To 3
                grid(x, y) = chrw(9619)
            Next
        Next
        For y = 17 To 19
            For x = 14 To 15
                grid(x, y) = chrw(9619)
            Next
        Next
        For y = 4 To 5
            For x = 4 To 5
                grid(x, y) = chrw(9619)
            Next
        Next
        
    End Sub
 
    Sub Play()
        Randomize()
        Dim level(19, 19) As Char 'this is our level/stage for the game
        Dim player As New GameEntity(0, 0, ChrW(9786)) 'A smiley face!
        Dim collectable1 As New GameEntity(Int(Rnd() * 19) + 1, Int(Rnd() * 19) + 1, ChrW(9829)) ' A lovely heart!
        Dim collectable2 As New GameEntity(Int(Rnd() * 19) + 1, Int(Rnd() * 19) + 1, ChrW(9829)) ' A lovely heart!
        Dim collectable3 As New GameEntity(Int(Rnd() * 19) + 1, Int(Rnd() * 19) + 1, ChrW(9829)) ' A lovely heart!
        'maybe we should have a LIST of collectables?
        Setup(level)
       Display(level, player, collectable1, collectable2, collectable3) 'inital display, before key press
       
        Do
            MovePlayer(player)
            Display(level, player, collectable1, collectable2, collectable3)
        Loop Until _lives = 0 or _score = 10     'this loop should end at some point?
        menu()
    End Sub
 
    Sub MovePlayer(ByRef player As GameEntity) 'REFERENCE parameter lets us modify the player values
        Dim input As ConsoleKeyInfo 'records details of any key press
 
        input = ReadKey(True)
        If input.Key = ConsoleKey.LeftArrow And player.x > 0 Then 'can crash if you move outside the grid
            player.x = player.x - 1
        ElseIf input.Key = ConsoleKey.RightArrow And player.x < 19 Then 'can crash if you move outside the grid
            player.x = player.x + 1
        ElseIf input.Key = ConsoleKey.UpArrow And player.y > 0 Then 'can crash if you move outside the grid
            player.y = player.y - 1
        ElseIf input.Key = ConsoleKey.DownArrow And player.y < 19 Then 'can crash if you move outside the grid
            player.y = player.y + 1
        End If
 
    End Sub
 
    Sub Display(grid(,) As Char, player As GameEntity, collectable1 As GameEntity, collectable2 As GameEntity, collectable3 As GameEntity)
        ResetColor()
 
        For y = 0 To 19 'these loops draw the level and its contents
            For x = 0 To 19
                SetCursorPosition(x, y)
                If grid(x, y) = ChrW(9608) Then
                    
                    ForegroundColor = ConsoleColor.Green
                ElseIf grid(x, y) = ChrW(9618) Then
                   
                    Console.ForegroundColor = ConsoleColor.Blue
 
                ElseIf grid(x, y) = ChrW(9618) Then
                    
                    Console.ForegroundColor = ConsoleColor.DarkRed
                End If
                Write(grid(x, y))
 
            Next
        Next
 
        SetCursorPosition(player.x, player.y) 'this draws the player
        Write(player.symbol)
        ForegroundColor = ConsoleColor.Blue
 
        SetCursorPosition(collectable1.x, collectable1.y)
        Write(collectable1.symbol)
 
        SetCursorPosition(collectable2.x, collectable2.y)
        Write(collectable2.symbol)
 
        SetCursorPosition(collectable3.x, collectable3.y)
        Write(collectable3.symbol)
 
        If grid(player.x, player.y) = "Rocks" Then
            Console.ForegroundColor = ConsoleColor.Red
            Threading.Thread.Sleep(1000)
            Console.ForegroundColor = ConsoleColor.Blue
            Console.SetCursorPosition(player.x, player.y)
            player.x = player.x - 1
            player.y = player.y - 1
        ElseIf grid(player.x, player.y) = "Pond" Then
            Console.ForegroundColor = ConsoleColor.Red
            Threading.Thread.Sleep(1000)
            _lives = _lives - 1
            Console.ForegroundColor = ConsoleColor.Blue
            Console.SetCursorPosition(player.x, player.y)
            player.x = 0
            player.y = 0
        End If
 
        If player.x = collectable1.x And player.y = collectable1.y Then
            _Score = _Score + 1
            Do
                collectable1.x = Int(Rnd() * 19) + 1
                collectable1.y = Int(Rnd() * 19) + 1
            Loop Until ChrW(9829) = ChrW(9608)
        End If
        If player.x = collectable2.x And player.y = collectable2.y Then
           _Score = _Score + 1
            Do
                collectable2.x = Int(Rnd() * 19) + 1
                collectable2.y = Int(Rnd() * 19) + 1
            Loop Until ChrW(9829) = ChrW(9608)
        End If
        If player.x = collectable3.x And player.y = collectable3.y Then
            _Score = _Score + 1
            Do
                collectable2.x = Int(Rnd() * 19) + 1
                collectable2.y = Int(Rnd() * 19) + 1
            Loop Until ChrW(9829) = ChrW(9608)
        End If
    End Sub
 
End Module