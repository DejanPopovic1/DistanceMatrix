using DistanceMatrixNamespace;

class TestClass
{
    static void Main(string[] args)
    {
        List<Location> origins = new List<Location>() {
            new Location(37.73475, -122.47523),
            new Location(38.11751, -121.53500),
            new Location(38.58993, -121.73333),
        };
        List<Location> destinations = new List<Location>() {
            new Location(37.67184, -122.43652),
            new Location(38.45499, -120.88909),
            new Location(38.66347, -121.85902),
        };
        var distanceMatrix = DistanceMatrixCreator.GenerateDistanceMatrix(origins, destinations, "GOOGLE_MAPS_API_KEY");
        var Origin1ToAllDestinations = distanceMatrix[0];
        var Origin2ToAllDestinations = distanceMatrix[1];
        var Origin3ToAllDestinations = distanceMatrix[2];
        var Origin2ToDestination2 = distanceMatrix[1][1];
    }
}