Console.WriteLine("----------Balık Tutma Oyunu----------");
Console.WriteLine(" balık tutmak için enter bas\n ");

List<string> baliklar = new List<string>();
List<string> tutulanBaliklar = new List<string>();
Dictionary<string, int> fishNamePoints = new Dictionary<string, int>();
string enBuyukBalik = "";

fishNamePoints.Add("hamsi", 1);
fishNamePoints.Add("levrek", 4);
fishNamePoints.Add("köpekbalıgı", 10);
fishNamePoints.Add("Sea Monster", 30);

Console.WriteLine("  Denizde olan balıklarımız: ");
foreach (var balik in fishNamePoints)
{

    Console.Write("       ");
    Console.WriteLine(balik);

    baliklar.Add(balik.Key);

}




int[] puanlar = { 1, 3, 10, 30 };
int toplamPuan = 0;
int enBuyukPuan = 0;
Random rnd = new Random();
ConsoleKeyInfo tus = Console.ReadKey();


while (tus.Key == ConsoleKey.Enter)
{

    int indeks = rnd.Next(baliklar.Count);

    Console.WriteLine("Balık tutdun! ");
    Console.WriteLine($"balık: {baliklar[indeks]} ,  paun: {puanlar[indeks]}");
    Console.WriteLine("\ndevam etmek için enter çıkmak için herhangi bir tuş\n");
    if (puanlar[indeks] > enBuyukPuan)
    {

        enBuyukPuan = puanlar[indeks];
        enBuyukBalik = baliklar[indeks];
    }
    tutulanBaliklar.Add(baliklar[indeks]);
    toplamPuan += puanlar[indeks];
    
    
    tus = Console.ReadKey();
}
Console.WriteLine("\n--------Oyundan çıktın--------\n");


if (tutulanBaliklar.Count == 0)
{
    Console.WriteLine("     Balık tutamadın ");
}

else
{
    Console.WriteLine("     Tutuğun Balıklar!!:     ");
    foreach (string balik in tutulanBaliklar)
    {
        Console.WriteLine(balik);
    }
    Console.WriteLine($"\nTutulan balik: {tutulanBaliklar.Count} , toplam puan : {toplamPuan}");
    Console.Write($"En buyuk balık : {enBuyukBalik}");
}


