Imports RRModels
Imports System.IO
Imports System.Text.Json
Class RestDL
    Implements IRestDL
    Dim filename As string = "Restaurants.json"
    Dim jsonString As string = ""
    Function AddRestaurant(ByVal newRest as Restaurant) As Restaurant Implements IRestDL.AddRestaurant
        Dim restaurantsFromFile as List(of Restaurant) = GetRestaurants()
        restaurantsFromFile.Add(newRest)
        jsonString = JsonSerializer.Serialize(restaurantsFromFile)
        File.WriteAllText(filename, jsonString)
        return newRest
    End Function
    Function GetRestaurants() As List(of Restaurant) Implements irestdl.getrestaurants
        Try
            jsonString = File.ReadAllText(filename)
            return JsonSerializer.Deserialize(of List(of Restaurant))(jsonString)
        Catch ex As Exception
            return new List(Of Restaurant)
        End Try
    End Function
End Class
