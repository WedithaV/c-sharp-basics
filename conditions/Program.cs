var dice = new Random();
var roll1 = dice.Next(1,7);
var roll2 = dice.Next(1,7);
var roll3 = dice.Next(1,7);
int total = roll1 + roll2 + roll3;

Console.WriteLine(roll1+" "+roll2+" "+roll3);

if((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)){
    total += 2;
}
if(total > 6){
    Console.WriteLine("You win");
}
else{
    Console.WriteLine("You Loose");
}

Console.WriteLine(total);