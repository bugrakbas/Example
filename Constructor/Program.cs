// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calisan calisan1 = new Calisan("Buğra", "Akbaş", 546, "Bilgisayar");
calisan1.CalisanYazdir();
Console.WriteLine("****************");
Calisan calisan2 = new Calisan();
calisan2.Ad = "Buğra";
calisan2.Soyad = "Akbaş";
calisan2.No = 747;
calisan2.Departman = "Mühendislik";
calisan2.CalisanYazdir();
Console.WriteLine("****************");
Calisan calisan3 = new Calisan("Buğra", "Akbaş");
calisan3.CalisanYazdir();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan() { }
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }
    public void CalisanYazdir()
    {
        Console.WriteLine("Çalışan Adı: {0}", Ad);
        Console.WriteLine("Çalışan Soyadıdı: {0}", Soyad);
        Console.WriteLine("Çalışan Numarası: {0}", No);
        Console.WriteLine("Çalışan Departmanı: {0}", Departman);
    }
}