Console.WriteLine("----------Balık Tutma Oyunu----------");
Console.WriteLine(" balık tutmak için enter bas\n ");

List<string> baliklar = new List<string>();
List<string> tutulanBaliklar = new List<string>();
string enBuyukBalik = "";

baliklar.Add("hamsi");                       
baliklar.Add("levrek");
baliklar.Add("köpekbalıgı");
baliklar.Add("Sea Monster");


Console.WriteLine("  Denizde olan balıklarımız: ");
foreach (string balik in baliklar) {
    Console.Write("       ");
    Console.WriteLine(balik);
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


