display('r');
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
    List<string> => "List of strings",
    Array => "Array",
    _ => "Unknown type"
};

CheckType(num);
CheckType(name);
CheckType(cities);
CheckType(numbers);
CheckType(salary);