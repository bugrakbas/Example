﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Out Parametreler
string sayi = "999";

bool sonuc = int.TryParse(sayi, out int outSayi);
if (sonuc)
{
    Console.WriteLine("Başarılı!");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Başarısız!");
}

Metotlar instance = new Metotlar();
instance.Topla(4, 5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);

//Metot Aşırı Yükleme - Overloading
int ifade = 999;
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
instance.EkranaYazdir("Buğra", "Akbaş");

//Metot İmzası
//metot adı + parametre sayısı + parametre

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}