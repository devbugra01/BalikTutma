using BalikTutma;
using System.Drawing;

Console.WriteLine("");
Console.WriteLine(" -----Console Fishing Game(Hand made)-----\n");
Console.WriteLine("      Play:Enter   Exit:Any button\n");

List<Fish> Fishes = new List<Fish>();
List<string> caughtFishes = new List<string>();

Fishes.Add(new Fish("anchovy", 1));
Fishes.Add(new Fish("sardine", 3));
Fishes.Add(new Fish("Mackerel", 5));
Fishes.Add(new Fish("Sea Bass", 8));
Fishes.Add(new Fish("Tuna", 18));

Console.WriteLine(" Fish in the Ocean:");
foreach (Fish fish in Fishes)
{
    fish.Describe();
}

Random rnd = new Random();
Fish biggestFish = new Fish("", 0);

int totalPoint = 0;
ConsoleKeyInfo button = Console.ReadKey();

while (button.Key == ConsoleKey.Enter)
{
    int indeks = rnd.Next(Fishes.Count);

    Fish myFish= Fishes[indeks];



    Console.WriteLine("\nCaught!");
    Console.WriteLine($" Fish: ({myFish.name}) , Point: ({myFish.point})");

    caughtFishes.Add(myFish.name);

    if (myFish.point > biggestFish.point)
    {
        biggestFish.point = myFish.point;
        biggestFish.name = myFish.name;

    }
    totalPoint += myFish.point;

    button = Console.ReadKey ();
}

if (caughtFishes.Count == 0)
{
    Console.WriteLine("\n-----You didn't catch any fish-----");
    Environment.Exit(0);
}
Console.WriteLine("\n -----Game Over-----");
Console.WriteLine("      Your catches:     ");
foreach (string fish in caughtFishes)
{
    Console.Write(" ");
    Console.Write(fish);
    Console.Write(",");
}


Console.Write($"\n\nBiggest Fish!: ({biggestFish.name}) , Point: ({biggestFish.point})");
Console.WriteLine($" Total Point = {totalPoint}");





    