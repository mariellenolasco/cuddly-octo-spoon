Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim menu As IMenu = new MainMenu()
        menu.Start()
    End Sub
End Module
