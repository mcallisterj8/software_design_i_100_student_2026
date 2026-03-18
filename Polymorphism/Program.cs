Console.WriteLine("\n================= Compile Time & Runtime Types ================\n");
Vehicle vehicleOne = new Vehicle();
Airplane airplaneOne = new Airplane("Delta", 35000, 2);
Automobile carOne = new Automobile("ABC123", 5, true);
Boat boatOne = new Boat(30.5, true, "Yacht");

Vehicle mysteryBox = new Automobile("ABC123", 5, true);
Automobile test = new ElectricCar("BCD456", 3, 100);
mysteryBox.Drive();
mysteryBox = new Airplane("Delta", 35000, 2);

if(mysteryBox is Automobile) {
    ((Automobile)mysteryBox).Honk();
} else {
    Console.WriteLine("Automobile is not in mysteryBox.");
}

mysteryBox.Drive();

List<Vehicle> vehicles = new List<Vehicle> {
    vehicleOne,
    airplaneOne,
    carOne,
    boatOne
};

// foreach(Vehicle elem in vehicles) {    
//     elem.Drive();
// }


