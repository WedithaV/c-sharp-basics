Console.Write("Hello");
Console.Write("World");

Console.Write("\n");

Console.WriteLine("Hello\nWorld");

Console.WriteLine("Weditha\tVishwa\tPrabhath");

Console.WriteLine("The word \"Hello\" ");

Console.WriteLine(@"The word \");
Console.WriteLine(@"C:\Users\wedit\Desktop\c#\c-sharp-basics\strings");

//String concat

string firstName = "Weditha";
string greeting = "Hello, ";

Console.WriteLine(firstName+greeting+" Good evening !");

Console.WriteLine("File Path is "+ @"C:\Users\wedit\Desktop\c#\c-sharp-basics\strings");



//string interpolation
Console.WriteLine($"Hello, {firstName}");
Console.WriteLine($"Hello, {firstName} - Today is {DateTime.Now}");