using System.Collections;
# region Soru1
ArrayList asalList = new ArrayList();
ArrayList asalOlmayanList = new ArrayList();
int temp;
bool control = false;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Lütfen Pozitif {0}. Sayıyı Giriniz: ", (i + 1));
    int.TryParse(Console.ReadLine(), out temp);
    if (temp > 0)
    {
        for (int j = 2; j <= temp / 2; j++)
        {
            if (temp % j == 0)
            {
                control = true;
            }
        }
    }
    if (control == true)
    {
        if (temp == 2)
        {
            asalList.Add(temp);
        }
        else
        {
            asalOlmayanList.Add(temp);
        }
    }
    else
    {
        if (temp == 1)
        {
            asalOlmayanList.Add(temp);
        }
        else
        {
            asalList.Add(temp);
        }
    }
    control = false;
}
asalList.Sort();
asalOlmayanList.Sort();
Console.WriteLine("Asal Sayılar: ");
foreach (int i in asalList)
{
    Console.WriteLine(i);
}
Console.WriteLine("Asal Olmayan Sayılar: ");
foreach (int i in asalOlmayanList)
{
    Console.WriteLine(i);
}
int asalElemanSayisi = asalList.Count;
double asalElemanSayisiToplam = 0;
foreach (int i in asalList)
{
    asalElemanSayisiToplam += i;
}
var asalOrtalama = asalElemanSayisiToplam / asalElemanSayisi;
Console.WriteLine("Asal Olan Listenin Eleman Sayısı: {0} Ortalaması: {1}", asalElemanSayisi.ToString(), Math.Round(asalOrtalama, 2).ToString());
Console.WriteLine();
Console.WriteLine();
int asalOlmayanElemanSayisi = asalOlmayanList.Count;
double asalOlmayanElemanSayisiToplam = 0;
foreach (int i in asalOlmayanList)
{
    asalOlmayanElemanSayisiToplam += i;
}
var asalOlmayanOrtalama = asalOlmayanElemanSayisiToplam / asalOlmayanElemanSayisi;
Console.WriteLine("Asal Olmayan Listenin Eleman Sayısı: {0} Ortalaması: {1}", asalOlmayanElemanSayisi.ToString(), Math.Round(asalOlmayanOrtalama, 2).ToString());
#endregion
#region Soru2
int tempi;
int n = 20;
int[] numbers = new int[n];
int[] bigNumbers = new int[3];
int[] smallNumbers = new int[3];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Lütfen Pozitif {0}. Sayıyı Giriniz: ", (i + 1));
    int.TryParse(Console.ReadLine(), out tempi);
    if (tempi > 0)
    {
        numbers[i] = tempi;
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            var tempNumber = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = tempNumber;
        }
    }
}
int bigSum = 0;
double bigAverage;
int smallSum = 0;
double smallAverage;
for (int i = 0; i < 3; i++)
{
    bigNumbers.Append(numbers[(n - 1) - i]);
    smallNumbers.Append(numbers[i]);
    bigSum += numbers[(n - 1) - i];
    smallSum += numbers[i];
}
bigAverage = bigSum / 3.0;
smallAverage = smallSum / 3.0;

Console.WriteLine("En Büyük 3 Elemanın Toplamı: {0} Ortalaması: {1}", bigSum.ToString(), Math.Round(bigAverage, 2).ToString());
Console.WriteLine("En Küçük 3 Elemanın Toplamı: {0} Ortalaması: {1}", smallSum.ToString(), Math.Round(smallAverage, 2).ToString());
#endregion
#region Soru3
Console.WriteLine("Lütfen Bir Cümle giriniz: ");
string sentence = Console.ReadLine();
int count = sentence.Length;
char[] vowels = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
char[] sentenceArray = sentence.ToCharArray();
ArrayList sentenceVowels = new ArrayList();
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < vowels.Length; j++)
    {
        if (sentenceArray[i] == vowels[j])
        {
            sentenceVowels.Add(vowels[j]);
            break;
        }
    }
}
Console.WriteLine("Sıralama");
sentenceVowels.Sort();
foreach (char c in sentenceVowels)
{
    Console.WriteLine(c);
}
#endregion