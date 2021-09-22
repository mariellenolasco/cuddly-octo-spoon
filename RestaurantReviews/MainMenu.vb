Imports System
Imports RRModels
Class MainMenu
    Implements IMenu
    Sub Start() Implements IMenu.Start
    Dim repeat As boolean = true
    Do While repeat
        Console.WriteLine("Welcome to my restaurant reviews app")
        Console.WriteLine("What would you like to do?")
        Console.WriteLine("[0] Create a restaurant")
        Console.WriteLine("[x] Exit")
        Dim input as string = Console.ReadLine()
        Select Case input
            Case "x"
                repeat = false
                Console.WriteLine("Goodbye")
            Case "0"
                CreateRestaurant()
        End Select
    Loop
    End Sub
    Private Sub CreateRestaurant()
        Console.WriteLine("Enter restaurant name: ")
        Dim Name As String = Console.ReadLine()
        Console.WriteLine("Enter restaurant city: ")
        Dim City As String = Console.ReadLine()
        Console.WriteLine("Enter restaurant state: ")
        Dim State As String = Console.ReadLine()
        Dim newRest As Restaurant = new Restaurant(Name, City, State)
        Console.WriteLine(newRest.ToString())
    End Sub
    
End Class
