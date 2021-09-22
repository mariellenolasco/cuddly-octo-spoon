Imports System
Imports RRModels
Class MainMenu
    Implements IMenu
    Dim _logic as IRestBL
    Public Sub New(ByVal logic as IRestBL)
        Me._logic = logic
    End Sub
    Sub Start() Implements IMenu.Start
    Dim repeat As boolean = true
    Do While repeat
        Console.WriteLine("Welcome to my restaurant reviews app")
        Console.WriteLine("What would you like to do?")
        Console.WriteLine("[0] Create a restaurant")
        Console.WriteLine("[1] Get all restaurants")
        Console.WriteLine("[x] Exit")
        Dim input as string = Console.ReadLine()
        Select Case input
            Case "x"
                repeat = false
                Console.WriteLine("Goodbye")
            Case "0"
                CreateRestaurant()
            Case "1"
                GetRestaurants()
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
        Console.WriteLine(_logic.AddRestaurant(newRest).ToString())
    End Sub
    Private Sub GetRestaurants()
        Dim restaurants as List(of Restaurant) = _logic.getrestaurants()
        For Each rest As restaurant In restaurants
            Console.WriteLine(rest.ToString())
        Next
    End Sub
    
End Class
