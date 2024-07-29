// See https://aka.ms/new-console-template for more information
// I want to check whether the script can read user input from the console
Console.WriteLine("Project DebugWithConsoleInput runs");

// ReSharper disable once JoinDeclarationAndInitializer
string? userInput;

WriteLine("Enter any value if you like. Then press Enter to print your input.");
userInput = ReadLine();// ?? "User entered nothing (script got null)"; // Wait for user to get input

switch (userInput)
{
    // is null
    case null:
        WriteLine("User entered nothing. That's why the script got null. " +
                  "This is the expected behaviour of Console.ReadLine()");
        break;
    // is empty
    case "":
        WriteLine("User entered nothing (script got empty string)");
        WriteLine("This is a specific behaviour of Visual Studio 2022, VS code & dotnet run on Windows 11.");
        break;
    // is string with length > 0
    case { Length: > 0 }:
        WriteLine($"User entered a string '{userInput}' of length {userInput.Length}");
        break;
    default:
        WriteLine($"Unexpected behaviour: User entered: {userInput}");
        break;
}

WriteLine($"Press Enter to end script");


