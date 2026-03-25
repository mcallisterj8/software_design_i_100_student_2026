using System.Text.Json;

EmployeeWriter writer
    = new EmployeeWriter { DirPath = "./Employees" };

string jsonFilePath = "./company_info.json";
string json = File.ReadAllText(jsonFilePath);

Company? companyA
    = JsonSerializer.Deserialize<Company>(json);

Employee singleEmployee = companyA.Employees[0];
EmployeeOptions empOptions
    = new EmployeeOptions { IncludePosition = true, IncludeBenefits = false };

// writer.Write(singleEmployee, empOptions);

writer.WriteAll(companyA.Employees, empOptions);

// Console.WriteLine($"\nCurrent Location: {Directory.GetCurrentDirectory()}\n");

