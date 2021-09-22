Imports RRModels
Interface IRestBL
    Function AddRestaurant(ByVal newRest as Restaurant) As Restaurant
    Function GetRestaurants() As List(of Restaurant)
End Interface
