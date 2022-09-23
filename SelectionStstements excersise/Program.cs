var r = new Random();
var favNumber = r.Next(1,10);
Console.Write("guess my faviorite number here: ");
var userInput = int.Parse(Console.ReadLine());

Console.WriteLine();

if (userInput > favNumber)
{
    Console.WriteLine("too high");
}
else if (userInput < favNumber) 
{
    Console.WriteLine("too low");
}
else 
{
    Console.WriteLine("you guessed it");
}

Console.WriteLine("what is your favorite subject between math, art, gym, cooking?");
string favSub = Console.ReadLine();

switch (favSub)
{
    case "math":
        Console.WriteLine("Math is your favorite subject!");
        break;

    case "art":
        Console.WriteLine("Art is your favorite subject!");
        break;

    case "gym":
        Console.WriteLine("gym is your favorite subject!");
        break;

    case "cooking":
        Console.WriteLine("cooking is your favorite subject!");
        break;

    default:
        Console.WriteLine("enter correct subject");
        break ;
}


