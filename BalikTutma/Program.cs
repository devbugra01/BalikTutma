Console.WriteLine("----------Balık Tutma Oyunu----------");
Console.WriteLine(" balık tutmak için enter bas\n ");

string[] baliklar = { "hamsi", "levrek", "Köpekbaligi","Sea Monster" };
int[] puanlar = { 1, 3, 10, 30 };
int toplamPuan = 0;
int tutulanBalikSayisi = 0;
Random rnd = new Random();
ConsoleKeyInfo tus = Console.ReadKey();


while (tus.Key == ConsoleKey.Enter)
{

    int indeks = rnd.Next(baliklar.Length);

    Console.WriteLine("Balık tutdun! ");
    Console.WriteLine($"balık: {baliklar[indeks]} ,  paun: {puanlar[indeks]}");
    Console.WriteLine("\ndevam etmek için enter çıkmak için herhangi bir tuş\n");
    toplamPuan += puanlar[indeks];
    tutulanBalikSayisi += 1;
    tus = Console.ReadKey();
}
Console.WriteLine("\n--------Oyundan çıktın--------\n");
Console.WriteLine($"Tutulan balik: {tutulanBalikSayisi} , toplam puan : {toplamPuan}");