Console.WriteLine("-----------Console Fishing Game-----------");
Console.WriteLine(" ----------Press Enter button For play---------- ");
Console.WriteLine("-----------Press any button for exit-----------\n");
List<string> baliklar = new List<string>();
List<string> catchedFih = new List<string>();
Dictionary<string, int> fishNamePoints = new Dictionary<string, int>();
string biggerFih = "";

fishNamePoints.Add("anchovy", 1);
fishNamePoints.Add("sea bass", 4);
fishNamePoints.Add("Shark", 10);
fishNamePoints.Add("Sea Monster", 30);

Console.WriteLine("       Fish in the sea: ");
foreach (var balik in fishNamePoints)
{

    Console.Write("       ");
    Console.WriteLine(balik);

    baliklar.Add(balik.Key);
   

}





int totalPoint = 0;
int biggerFihPoint = 0;
Random rnd = new Random();
ConsoleKeyInfo tus = Console.ReadKey();


while (tus.Key == ConsoleKey.Enter)
{

    int indeks = rnd.Next(baliklar.Count);
    string myFih = baliklar[indeks];
    int myPoint= fishNamePoints[myFih];

    Console.WriteLine("Balık tutdun! ");
    Console.WriteLine($"balık: {myFih} ,  paun: {myPoint}");
    Console.WriteLine("\ndevam etmek için enter çıkmak için herhangi bir tuş\n");
    if (myPoint > biggerFihPoint)
    {

        biggerFihPoint= myPoint;
        biggerFih = myFih;
    }
    catchedFih.Add(myFih);
    totalPoint += myPoint;
    
    
    tus = Console.ReadKey();
}
Console.WriteLine("\n--------Exit--------\n");


if (catchedFih.Count == 0)
{
    Console.WriteLine("     Balık tutamadın ");
}

else
{
    Console.WriteLine("     Your catches:     ");
    foreach (string balik in catchedFih)
    {
        Console.WriteLine(balik);
    }
    Console.WriteLine($"\nTutulan balik: {catchedFih.Count} , toplam puan : {totalPoint}");
    Console.Write($"En buyuk balık : {biggerFih}");
}


