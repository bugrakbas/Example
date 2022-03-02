// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Calisan calisan1 = new Calisan();
calisan1.Ad = "Buğra";
calisan1.Soyad = "Akbaş";
calisan1.No = 546;
calisan1.Departman = "Bilgisayar";
calisan1.CalisanBilgileri();

Console.WriteLine("*********");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Buğra";
calisan2.Soyad = "AKbaş";
calisan2.No = 547;
calisan2.Departman = "Mühendislik";
calisan2.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0},", Ad);
        Console.WriteLine("Çalışan Soyadı: {0},", Soyad);
        Console.WriteLine("Çalışan Numarası: {0},", No);
        Console.WriteLine("Çalışan Departmanı: {0},", Departman);
    }
}