
using GenericsExamples.Models;

List<int> numbers = new List<int>();

iPhone phoneA = new iPhone { Model = "iPhone 16" };
iPhone phoneB = new iPhone { Model = "iPhone 15" };
iPhone phoneC = new iPhone { Model = "iPhone 14" };

Android phoneD = new Android { Model = "Android 12" };
Android phoneE = new Android { Model = "Android 11" };
Android phoneF = new Android { Model = "Android 10" };

Box<int> boxA = new Box<int> { Name = "boxA", Item = 8 };
Box<bool> boxB = new Box<bool> { Name = "boxB", Item = true };

Box<iPhone> boxC =
    new Box<iPhone> { Name = "boxC", Item = phoneA };

boxC.ItemList.Add(phoneB);
boxC.ItemList.Add(phoneC);

Console.WriteLine($"\n\n{boxC}\n\n");


SmartBox<Phone> boxD =
    new SmartBox<Phone> { Name = "boxD", Item = phoneA };

boxD.ItemList.Add(phoneB);
boxD.ItemList.Add(phoneF);

Console.WriteLine($"\n\n{boxD}\n\n");


SmartBox<int> example =
    new SmartBox<int> { Name = "example", Item = 8 };


