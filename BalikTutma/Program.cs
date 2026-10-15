using BalikTutma;

Console.WriteLine("");
Console.WriteLine(" -----Console Fishing Game(Hand made)-----\n");
Console.WriteLine("      Play:Enter   Exit:Any button\n");

List<Fish> Fishes = new List<Fish>();

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