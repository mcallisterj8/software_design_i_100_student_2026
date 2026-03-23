using System.Text.Json;

/**************************************
    READING FROM TEXT FILE
**************************************/


string filePath = "./lorem_ipsum.txt";
string fileContents = File.ReadAllText(filePath);

// Console.WriteLine($"\nFile Contents:\n\n{fileContents}\n");

/**************************************
    WRITING TO TEXT FILE
**************************************/
string pathToFile = $"{Directory.GetCurrentDirectory()}/hello.txt";
string content = "Hello World!";

File.WriteAllText(pathToFile, content);

// Console.WriteLine($"\n\nCurrent Directory:\n{Directory.GetCurrentDirectory()}\n\n");

string moreContent = "\nThe sun is out!";
File.AppendAllText(pathToFile, moreContent);

/**************************************
    FORMAT WRITING TO TEXT FILE
**************************************/
string pathToFormatFile = "./format.txt";
string title = "Example Title";
int number = 80;

string formatContent =
    @$"{title}
================
Non-indented sentence.
    Indented sentence with the number {number}!";

File.WriteAllText(pathToFormatFile, formatContent);


/**************************************
    READING FROM JSON
**************************************/

string jsonFilePath = "./company_info.json";
string json = File.ReadAllText(jsonFilePath);

// Console.WriteLine($"\n\n{json}");

// Just like JSON.parse();
Company? companyA = JsonSerializer.Deserialize<Company>(json);

Console.WriteLine($"\n\nCompany Name: {companyA.Name}");

Employee singleEmployee = companyA.Employees[0];

Console.WriteLine($"Employee BEFORE: {singleEmployee.FullName} | Position: {singleEmployee.Position.Description}\n");

singleEmployee.Position.Description = "Software Engineer";

Console.WriteLine($"Employee AFTER: {singleEmployee.FullName} | Position: {singleEmployee.Position.Description}\n");

// Options to format the JSON file
var options = new JsonSerializerOptions { WriteIndented = true };

// Serialize / string the company object back to JSON
string updatedJson = JsonSerializer.Serialize(companyA, options);

// Write the JSON back out to the file
File.WriteAllText(jsonFilePath, updatedJson);
