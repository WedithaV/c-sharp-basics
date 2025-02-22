﻿display('r');
display('g');
display('b');
display('K');

//Value pattern
void display(char color){
    var result = color switch{
        'r' => "color is red",
        'g' => "color is green",
        'b' => "color is blue",
        _ => "Unknown color"
    };
    Console.WriteLine(result);
}



//Type pattern

int num = 10;
string name = "Weditha";
List<string> cities = new List<string> {"Colombo","Kandy","Galle"};
var numbers = new  int[] {1,2,3,4,5};
double salary = 10000.00;

object CheckType(object val) => val switch{
    int => "Integer",
    string => "String",
    Array => "Array",
    List<string> => "List of strings",
    _ => "Unknown type"
};

CheckType(num);
CheckType(name);
CheckType(cities);
CheckType(numbers);
CheckType(salary);


//Relational pattern
var numbers1 = new List<int> {1,0,-4,4,-890,3434,0};
foreach(var num1 in numbers1)
{
    var result = num1 switch
    {
        >0 => $"{num1} is a positive number",
        0 => "Zero",
        <0 => $"{num1} is a negative number",
    };
    Console.WriteLine(result);
}




//Logical pattern
string CheckGrade(int m) => m switch{
    < 15  => "Your grade if F",
    15 >= and < 35 => "Your grade is W",
    35 >= and <55 => "Your grade is C",
};

Console.WriteLine(CheckGrade(45));

//When guard
var people = new List<Person>
{
    new ("John", "Doe", 44),
    new ("Saman", "Kumara", 20),
    new ("Jane", "Doe", 15),
    new ("Kenuli", "Thesara", 16)
};

string checkPerson(Person person)
{
    return person switch
    {
        {Age: var age} when age < 18 => "Minor person",
        _ => "Adult"
    };
}

foreach(var p in people)
{
    Console.WriteLine(checkPerson(p));
}

record Person(string FirstName, string LastName, int Age);