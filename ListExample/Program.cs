// int[] numberArr = new int[4];

// numberArr[0] = 3;
// numberArr[1] = 2;
// numberArr[2] = 6;
// numberArr[3] = 8;


// for(int i = 0; i < numberArr.Length; i++) {
//     Console.WriteLine($"numberArr[{i}] = {numberArr[i]}");
// }


Console.WriteLine($"=============== Count & Capacity =================");
List<int> numberList = new List<int>();
// numberList.Add(8);

Console.WriteLine($"Count: {numberList.Count}"); // Equivalent of Length for arrays
Console.WriteLine($"Capacity: {numberList.Capacity}");

foreach(int num in numberList){
    Console.WriteLine($"{num}");
}
Console.WriteLine($"==================================================");

Console.WriteLine($"=============== Adding, Removing, Looping =================");
// List<string> fruits = new List<string> {"apple", "banana", "cherry"};
List<string> fruits = ["apple", "banana", "cherry"];

// List<string> fruits = new List<string>();
// fruits.Add("Apple");
// fruits.Add("Banana");
// fruits.Add("Cherry");

foreach(string fruit in fruits) {
    Console.WriteLine(fruit);
}

// Remove "banana"
bool result = fruits.Remove("banana");

Console.WriteLine("\nAfter editing list:");
foreach (string fruit in fruits) {
    Console.WriteLine(fruit);
}

Console.WriteLine($"result: {result}");

Console.WriteLine($"==================================================");

Console.WriteLine($"=============== Removing with Predicate =================");
List<decimal> decimalList = new List<decimal> {12.75m, 3.4m, 0.99m, 18.125m, 12.75m, 7m};

Console.WriteLine("Before Removal:");
foreach(decimal number in decimalList){
    Console.WriteLine(number);
}

decimalList.RemoveAll(num => num < 10);

Console.WriteLine("\nAfter Removal:");
foreach(decimal number in decimalList){
    Console.WriteLine(number);
}

Console.WriteLine($"==================================================");