Airplane planeOne = new Airplane("Jeff", 4);
planeOne.Name = "Jeff";
// planeOne.numEngines = 4;

if(null != planeOne.Name) {
    Console.WriteLine($"planeOne name: {planeOne.Name}");
} else {
    Console.WriteLine($"planeOne name: null");
}

Console.WriteLine($"planeOne airline: {planeOne.Airline}");

Console.WriteLine($"planeOne numEngines: {planeOne.NumEngines}");


