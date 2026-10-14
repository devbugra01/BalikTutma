Console.WriteLine("-----------Console Fishing Game-----------");
Console.WriteLine(" ----------Press Enter button For play---------- ");
Console.WriteLine("-----------Press any button for exit-----------\n");
List<string> baliklar = new List<string>();
List<string> caughtFish = new List<string>();
Dictionary<string, int> fishNamePoints = new Dictionary<string, int>();
List<Fish> fishes = new List<Fish>();
string biggestFish = "";

fishNamePoints.Add("anchovy", 1);
fishNamePoints.Add("sea bass", 4);
fishNamePoints.Add("Shark", 10);
fishNamePoints.Add("Sea Monster", 30);
Fish fish1 = new Fish("Mutation Shark", 50);
Fish fish2 = new Fish("whale",100);
Fish fish3 = new Fish("Dolphin", 70);
Fish fish4 = new Fish("Crab", 3);
fishes.Add(fish1);
fishes.Add(fish2);
fishes.Add(fish3);
fishes.Add(fish4);

foreach (Fish fih in fishes)
{
   fih.Describe();
}

Console.WriteLine("       Fish in the sea: ");
foreach (var balik in fishNamePoints)
{

    Console.Write("       ");
    Console.WriteLine(balik);

    baliklar.Add(balik.Key);
   

}
;




int totalPoint = 0;
int biggestPoint = 0;
Random rnd = new Random();
ConsoleKeyInfo tus = Console.ReadKey();


while (tus.Key == ConsoleKey.Enter)
{

    int indeks = rnd.Next(baliklar.Count);
    string myFish = baliklar[indeks];
    int myPoint= fishNamePoints[myFish];

    Console.WriteLine("Caught! ");
    Console.WriteLine($"balık: {myFish} ,  paun: {myPoint}");
    Console.WriteLine("\ndevam etmek için enter çıkmak için herhangi bir tuş\n");
    if (myPoint > biggestPoint)
    {

        biggestPoint= myPoint;
        biggestFish = myFish;
    }
    caughtFish.Add(myFish);
    totalPoint += myPoint;
    
    
    tus = Console.ReadKey();
}
Console.WriteLine("\n--------Exit--------\n");


if (caughtFish.Count == 0)
{
    Console.WriteLine("     You didn't catch any fish \n");
}

else
{
    Console.WriteLine("     Your catches:     ");
    foreach (string balik in caughtFish)
    {
        Console.WriteLine(balik);
    }
    Console.WriteLine($"\nCaught fishes: {caughtFish.Count} , total point : {totalPoint}");
    Console.Write($"Biggest Fish : {biggestFish}\n\n\n\n");
}


class Fish
{
    public string name = "";
    public int point = 0;

    public Fish(string name, int point)
    {
        this.name = name;
        this.point = point;
    }

    public void Describe()
    {
        Console.WriteLine($" New Fish :{name} Point : {point}");
    }
}
