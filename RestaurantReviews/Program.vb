Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim menu As IMenu = new MainMenu(new RestBL(new RestDL()))
        menu.Start()
    End Sub
End Module
