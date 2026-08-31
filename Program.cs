// basic greeter program
// ask user for their name and then print their name
// and then ask the user for their age

// inform the user what the program expects
Console.WriteLine("Please enter your name, and then hit enter: ");

string userName = Console.ReadLine();

Console.WriteLine($"Users name is {userName}");

string userAge = Console.ReadLine();

Console.WriteLine($"Users age is {userAge}");

// small note on naming convetion in C#:

// local variables are camelCase (name starts with an a-z value in lowercase), any any new word is split on an uppercase first character
// Global or Public variables or Classes are PascalCase (name starts with an A-Z value in uppercase) , any any new word is split on an uppercase first character
// Lastly, we usually prefer very verbose variablenames over short names that can confuse the reader.
