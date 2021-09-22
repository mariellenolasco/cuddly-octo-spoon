Imports RRModels
Class RestBL
    Implements IRestBL
    Dim _repo as IRestDL
    Public Sub New(ByVal repo as IRestDL)
        Me._repo = repo
    End Sub
    Function AddRestaurant(ByVal newRest as Restaurant) As Restaurant Implements IRestBL.AddRestaurant
        _repo.AddRestaurant(newRest)
        return newRest
    End Function
    Function GetRestaurants() As List(of Restaurant) Implements IRestBL.GetRestaurants
        return _repo.GetRestaurants()
    End Function
    
End Class
