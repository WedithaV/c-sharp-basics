display(4,4);
display(3,5);
display(-3,5);

void display(int a, int b){
    switch(a,b){
        case var(x,y) when x > 0 && y > 0 && x == y:
        Console.WriteLine("Values are valid and equal");
        break;
        case var(x,y) when x > 0 && y > 0:
        Console.WriteLine("Values are valid");
        break;
        default:
        Console.WriteLine("Invalid values");
        break;
    }
}