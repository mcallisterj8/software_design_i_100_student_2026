Console.WriteLine("\n============================================================");
Console.WriteLine("1. Creating a base class object");
Console.WriteLine("============================================================");

Vehicle genericVehicle = new Vehicle();
genericVehicle.Name = "Generic Vehicle";
genericVehicle.ModelYear = 2020;

Console.WriteLine("Name: " + genericVehicle.Name);
Console.WriteLine("Model Year: " + genericVehicle.ModelYear);
genericVehicle.Drive();
genericVehicle.Stop();


Console.WriteLine("\n============================================================");
Console.WriteLine("2. Creating an Automobile object");
Console.WriteLine("============================================================");

Automobile car = new Automobile("ABC-123", 5, false);

car.Name = "Family Sedan";       // Inherited from Vehicle
car.ModelYear = 2022;            // Inherited from Vehicle
car.LicensePlate = "ABC-123";    // Defined in Automobile
car.SeatingCapacity = 5;         // Defined in Automobile

Console.WriteLine("Name: " + car.Name);
Console.WriteLine("Model Year: " + car.ModelYear);
Console.WriteLine("License Plate: " + car.LicensePlate);
Console.WriteLine("Seating Capacity: " + car.SeatingCapacity);

car.Drive();
car.Honk();
car.Stop();
car.TestMethod();

Console.WriteLine("\n============================================================");
Console.WriteLine("3. Creating an ElectricCar object (Multi-Level Inheritance)");
Console.WriteLine("============================================================");

ElectricCar tesla = new ElectricCar("EV-2026", 5, 100);

tesla.Name = "Electric Sedan";        // From Vehicle
tesla.ModelYear = 2026;               // From Vehicle
tesla.LicensePlate = "EV-2026";       // From Automobile
tesla.SeatingCapacity = 5;            // From Automobile
tesla.BatteryCapacity = 100;          // From ElectricCar

Console.WriteLine("Name: " + tesla.Name);
Console.WriteLine("Model Year: " + tesla.ModelYear);
Console.WriteLine("License Plate: " + tesla.LicensePlate);
Console.WriteLine("Seating Capacity: " + tesla.SeatingCapacity);
Console.WriteLine("Battery Capacity: " + tesla.BatteryCapacity + " kWh");

tesla.Drive();
tesla.ChargeBattery();
tesla.Honk();
tesla.Stop();
tesla.TestMethod();

Console.WriteLine("\n============================================================");
Console.WriteLine("4. Creating a Boat object");
Console.WriteLine("============================================================");

Boat fishingBoat = new Boat(24.5, true, "Fishing Boat");

fishingBoat.Name = "North Star";
fishingBoat.ModelYear = 2018;

Console.WriteLine("Name: " + fishingBoat.Name);
Console.WriteLine("Model Year: " + fishingBoat.ModelYear);
Console.WriteLine("Length: " + fishingBoat.Length + " feet");
Console.WriteLine("In Port: " + fishingBoat.InPort);

fishingBoat.Drive();
fishingBoat.Anchor();
fishingBoat.Stop();


Console.WriteLine("\n============================================================");
Console.WriteLine("5. Creating an Airplane object");
Console.WriteLine("============================================================");

Airplane plane = new Airplane("Delta", 35000, 2);

plane.Name = "Regional Jet";
plane.ModelYear = 2024;

Console.WriteLine("Name: " + plane.Name);
Console.WriteLine("Model Year: " + plane.ModelYear);
Console.WriteLine(plane.ToString());

plane.Drive();
plane.DeployLandingGear();
plane.Stop();


