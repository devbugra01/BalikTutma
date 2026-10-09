Console.WriteLine("🎣 Balık Tutma Oyunu");
Console.WriteLine("balık tutmak için enter bas");

String[] Balik = { "hamsi", "levrek", "Köpekbaligi","Sea Monster" };
int[] Puan = { 1, 3, 10, 30 };
int toplamPuan = 0;
int tutulanBalik = 0;

ConsoleKeyInfo tus = Console.ReadKey();


while (tus.Key == ConsoleKey.Enter)
{
   
    Random rnd = new Random();
        int indeks = rnd.Next(0, 4);
        Console.WriteLine("Balık tutdun");
        Console.WriteLine("tutugun balık");
    Console.WriteLine($"{Balik[indeks]} paun: {Puan[indeks]}");
    Console.WriteLine("devam etmek için enter çıkmak için herhangi bir tuş");
    toplamPuan += Puan[indeks];
    tutulanBalik += 1;
    tus = Console.ReadKey();
}
Console.WriteLine("Oyundan çıktın");
Console.WriteLine($"Tutulan balik {tutulanBalik} toplam puan {toplamPuan}");