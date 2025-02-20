string[] names = new string[3];
names[0] = "Weditha";
names[1] = "Vishwa";
names[2] = "Prabhath";

foreach (string name in names){
    Console.WriteLine(name);
}

int[] numbers = {1,2,3,4,5,6};

foreach(int num in numbers)
{
    Console.WriteLine(num);
}


Console.WriteLine("\nDoWhile loop");
int n = 4;
do
{
    Console.WriteLine(n);
    n--;
}while(n > 0);


Console.WriteLine("\n\nWhile Loop");
int a = 3;
while(a >=0){
    Console.WriteLine(a);
    a--;
}