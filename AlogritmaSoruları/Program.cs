#region Soru 1 
Console.WriteLine("Pozitif bir sayı giriniz:");
int diziLenght = int.Parse(Console.ReadLine());
int[] dizi = new int[diziLenght];
for (int i = 0; i < diziLenght; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz", i + 1);
    dizi[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Çift Sayılar");
for (int i = 0; i < dizi.Length; i++)
{
    if (dizi[i] % 2 == 0)
        Console.WriteLine("Girdiğiniz sayılar içerisindeki çift sayılar:" + dizi[i]);
}
#endregion
#region Soru 2
Console.WriteLine("Lütfen iki pozitif sayı giriniz:");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[] sayi = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz:", i + 1);
    sayi[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < sayi.Length; i++)
{
    if (sayi[i] % m == 0 || sayi[i] == m)
        Console.WriteLine("Girdiğiniz " + sayi[i] + " sayısı " + m + " ye tam bölünüyordur ya da eşittir");
}
#endregion
#region Soru 3
Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
int n1 = int.Parse(Console.ReadLine());
string[] yazi = new string[n1];
for (int i = 0; i < n1; i++)
{
    Console.WriteLine("Lütfen {0}. kelimeyi giriniz:", i + 1);
    yazi[i] = Console.ReadLine();
}
Array.Reverse(yazi);
Console.WriteLine("Kelimeler");
foreach (var item in yazi)
{
    Console.WriteLine(item);
}
#endregion
#region Soru 4
Console.Write("Lütfen bir cümle giriniz:");
string cumle = Console.ReadLine();
string[] kelime = cumle.Split(" ");
char[] harfler = cumle.ToCharArray();
int harf = 0;
Console.WriteLine("Kurduğunuz cümlede {0} tane kelime vardır", kelime.Length);
for (int i = 0; i < kelime.Length; i++)
{
    char[] harfdizisi = kelime[i].ToCharArray();
    harf += harfdizisi.Length;
}
System.Console.WriteLine("Girdiğiniz cümlede {0} tane harf vardır", harf);

#endregion
