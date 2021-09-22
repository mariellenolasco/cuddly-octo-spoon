Imports System
Public Class Restaurant
    Public Sub New(ByVal name as String, ByVal city as String, ByVal state as String)
        Me.name = name    
        Me.city = city
        Me.state = state    
    End Sub
    
    Property Name As string
    Property State As string
    Property City As string
    
    Public Overrides Function ToString() As string
        return $"{Name} {City},{State}"
    End Function
    
    
End Class
