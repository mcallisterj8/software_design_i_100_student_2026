Airplane planeOne = new Airplane("Jeff", 4);
// planeOne.name = "Jeff";
// planeOne.numEngines = 4;

if(null != planeOne.name) {
    Console.WriteLine($"planeOne name: {planeOne.name}");
} else {
    Console.WriteLine($"planeOne name: null");
}

Console.WriteLine($"planeOne numEngines: {planeOne.numEngines}");


