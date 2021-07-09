using NewFeaturesApp;
using System;

// Top-level statements
// With C # 9.0, we can start writing declarations directly, without the need for namespaces, classes etc...

// Logical Patterns
// You can combine relational operators with Logical Operators and, or and not(word)
string namePerson = "John";

if (namePerson is not null)
{
    Console.WriteLine($"The name of the person is: {namePerson}, and his complete name is: {CompleteNamePerson(namePerson)}");
}

Console.WriteLine($"The result of Add Numbers is: {AddNumbers(5, 5)}");

Console.WriteLine($"The temperature is: { CalculateTemperature(-1)}");

static double AddNumbers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

static string CompleteNamePerson(string namePerson)
{
    string CompleteNamePerson = string.Empty;

    // Target - typed "new"
    // Expression doesn't need to say type it will come from context
    // Property values ​​are set in the constructor
    Person person = new() { Id = Guid.NewGuid(), Name = namePerson, LastName = "Smith" };

    CompleteNamePerson = person.Name + " " + person.LastName;

    return CompleteNamePerson;
}

// New switch sintaxe and Relational Patterns
// Relational operators (<, >, etc) can be used as patterns indicators
static string CalculateTemperature(int temperature)
{
    string resultTemperature = temperature switch
    {
        > 0 => "cold",
        <= -1 => "freezing",
        _ => throw new ArgumentException("Not a known Product type", nameof(temperature)),
    };

    return resultTemperature;
}
