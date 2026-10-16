using BalikTutma;


Console.WriteLine("");
Console.WriteLine(" -----Console Fishing Game(Hand made)-----\n");
Console.WriteLine("      Play:Enter   Exit:Any button\n");

List<Fish> fishes = new List<Fish>();
List<Fish> caughtFishes = new List<Fish>();

fishes.Add(new Fish("anchovy", 1,Rarity.Common));
fishes.Add(new Fish("sardine", 3, Rarity.Common));
fishes.Add(new Fish("Mackerel", 5, Rarity.Rare));
fishes.Add(new Fish("Sea Bass", 8, Rarity.Rare));
fishes.Add(new Fish("Tuna", 18, Rarity.Epic));
fishes.Add(new Fish("Shark", 30, Rarity.Legendary));

Console.WriteLine(" Fish in the Ocean:");
foreach (Fish fish in fishes)
{
    fish.Describe();
}

Random rnd = new Random();
Fish biggestFish = new Fish("", 0, Rarity.Common);

int totalPoint = 0;
ConsoleKeyInfo button = Console.ReadKey();

while (button.Key == ConsoleKey.Enter)
{
    int indeks = rnd.Next(fishes.Count);

    Fish myFish= fishes[indeks];



    Console.WriteLine("\nCaught!");
    myFish.Describe(); // I use Fish class describe method

    caughtFishes.Add(myFish);

    if (myFish.point > biggestFish.point)
    {
        biggestFish = myFish;
        

    }
    totalPoint += myFish.point;

    button = Console.ReadKey ();
}
Console.WriteLine("\n -----Game Over-----");

if (caughtFishes.Count == 0)
{
    Console.WriteLine("\n-----You didn't catch any fish-----");
}
else
{
    Console.WriteLine("      Your catches:     ");
    foreach (Fish fish in caughtFishes)
    {
        Console.Write(" ");
        Console.Write(fish.name + fish.rarity);
        Console.Write(",");
    }


    biggestFish.Describe(); 
    Console.WriteLine($" Total Point = {totalPoint}");

}