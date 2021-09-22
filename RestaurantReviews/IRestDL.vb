Imports RRModels
Interface IRestDL
    Function AddRestaurant(ByVal newRest as Restaurant) As Restaurant
    Function GetRestaurants() As List(of Restaurant)
End Interface
