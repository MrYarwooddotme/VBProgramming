Module Module1
Sub Main()
dim camera1, camera2, time1, time2, speed, distance, time as Decimal
Do
Console.WriteLine("Enter the location of camera 1 in KM")
camera1 = console.ReadLine()
Console.WriteLine("Enter the location of camera 2 in KM")
camera2 = console.ReadLine()
if camera1 < 0 and camera2 < camera1 Then
                    Console.WriteLine("You have entered an invalid distance")
End If
loop until camera1 > 0 and camera2 > camera1
        
Do
Console.WriteLine("What time was camera 1 passed?")
time1 = console.ReadLine()
Console.WriteLine("What time was camera 2 passed?")
time2 = console.ReadLine()
if time1 < 0 and time2 > 1439 and time2 < time1 Then
                    Console.WriteLine("You have entered an invalid time")
End If
loop until time1 > 0 and time2 > time1
distance = camera2 - camera1
time = time2 - time1
time = time / 60
speed = distance / time
if speed > 100 Then
console.WriteLine(speed)
console.writeline("Fine issued")
Else 
console.WriteLine(speed)
console.writeline("Thank you for driving safely")   
End If
End Sub
End Module