Dictionary<string, long> phoneList = new Dictionary<string, long>()
{
    {"Buğra Akbaş", 12324432423 },
    {"Ali Veli", 6356456456 },
    {"Veli Ali", 1524625662 },
    {"Ahmet Mehmet", 75241346513 },
    {"Mehmet Ahmet", 14367514614 }
};
AnaSayfa();

void AnaSayfa()
{
    Console.WriteLine("Lütfen yapmak istediğniz işlemi seçiniz");
    Console.WriteLine("***************************************");
    Console.WriteLine("(1) Yeni Numara Kaydetmek");
    Console.WriteLine("(2) Varolan Numarayı Silmek");
    Console.WriteLine("(3) Varolan Numarayı Güncelleme");
    Console.WriteLine("(4) Rehberi Listele");
    Console.WriteLine("(5) Rehberde Arama Yapma");

    int number = int.Parse(Console.ReadLine());
    switch (number)
    {
        case 1:
            SavePhoneNumber();
            break;
        case 2:
            DeleteNumber();
            break;
        case 3:
            UpdateNumber();
            break;
        case 4:
            ListDirectory();
            break;
        case 5:
            SearchUser();
            break;

    }
}

void SavePhoneNumber()
{
    Console.WriteLine("Lütfen isim ve soyisim giriniz :");
    string nameAndSurnanme = Console.ReadLine();
    Console.WriteLine("Lütfen telefon numarası giriniz :");
    long number = long.Parse(Console.ReadLine());
    phoneList.Add(nameAndSurnanme, number);
    Console.WriteLine("İşlem başarılı bir şekilde yürütüldü.");
}
void UpdateNumber()
{
    Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz");
    string nameOrSurname = Console.ReadLine();
    if (phoneList.ContainsKey(nameOrSurname))
    {
        Console.WriteLine("Lütfen yeni numarayı giriniz :");
        long newNumber = long.Parse(Console.ReadLine());
        phoneList[nameOrSurname] = newNumber;
        Console.WriteLine("Numara güncellendi");
        foreach (var item in phoneList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Ana menüye dönüyorsunuz");
        AnaSayfa();
    }
    else
    {
        Console.WriteLine("Aradığınız kriterlere uygun  veri rehberde bulunamadı.Lütfen bir seçin yapınız :");
        Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
        Console.WriteLine("Yeniden denemek için : (2)");
    }
    int n = int.Parse(Console.ReadLine());
    if (n == 1)
    {
        Console.WriteLine("İşlem sonlandırıldı.Ana sayfaya dönüyorsunuz");
        AnaSayfa();
    }
    else if (n == 2)
    {
        UpdateNumber();
    }
}
void ListDirectory()
{
    Console.WriteLine("Telefon Rehberi");
    Console.WriteLine("**********************");
    Console.WriteLine("Listeyi A dan Z ye sıralamak için : (1)");
    Console.WriteLine("Listeyi Z den A ya sıralamak için : (2)");
    int n = int.Parse(Console.ReadLine());

    if (n == 1)
    {
        var list = phoneList.OrderByDescending(i => i.Key);
        var newList = list.Reverse();
        foreach (var item in newList)
        {
            Console.WriteLine("Ad ve Soyad : " + item.Key);
            Console.WriteLine("Telefon Numarası : " + item.Value);
            Console.WriteLine("---------------------------");
        }
    }
    else if (n == 2)
    {
        var list2 = phoneList.OrderByDescending(i => i.Key);
        foreach (var item in list2)
        {
            Console.WriteLine("Ad ve Soyad : " + item.Key);
            Console.WriteLine("Telefon Numarası : " + item.Value);
            Console.WriteLine("---------------------------");
        }
    }
    AnaSayfa();
}
void DeleteNumber()
{
    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz");
    string nameOrSurname = Console.ReadLine();
    if (phoneList.ContainsKey(nameOrSurname))
    {
        Console.WriteLine("{0} listeden silinmek üzere onaylıyor musunuz? (y/n)", nameOrSurname);
        string secim = Console.ReadLine();
        if (secim == "y")
        {
            phoneList.Remove(nameOrSurname);
        }
        else
        {
            Console.WriteLine("İşlem sonlandırılmıştır Ana Sayfaya dönüyorsunuz.");
            AnaSayfa();
        }
    }
    else
    {
        Console.WriteLine("Aradığınız kriterlere uygun  veri rehberde bulunamadı.Lütfen bir seçin yapınız :");
        Console.WriteLine("Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("Yeniden denemek için : (2)");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            AnaSayfa();
        }
        else
        {
            DeleteNumber();
        }
    }
}
void SearchUser()
{
    Console.WriteLine("Arama yapmak istdeğiniz tipi seçiniz");
    Console.WriteLine("************************************");
    Console.WriteLine("İsim ve Soyisime göre arama yapmak için : (1)");
    Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
    int n = int.Parse(Console.ReadLine());
    if (n == 1)
    {
        Console.WriteLine("İsim ve Soyisim giriniz :");
        string input = Console.ReadLine();
        if (phoneList.ContainsKey(input))
        {
            int index = 0;
            foreach (var item in phoneList)
            {
                if (item.Key == input)
                {
                    Console.WriteLine("Arama sonucu: ");
                    Console.WriteLine("*************************");
                    Console.WriteLine("Ad ve Soyad : " + item.Key);
                    Console.WriteLine("Telefon Numarası : " + item.Value);
                }
                index++;
            }
            AnaSayfa();
        }
        else
        {
            Console.WriteLine("Aradığınız kişi rehberde bulunamadı.");
            SearchUser();
        }
        AnaSayfa();
    }
    else if (n == 2)
    {
        Console.WriteLine("Telefon numarası giriniz :");
        long phoneNumber = long.Parse(Console.ReadLine());
        if (phoneList.ContainsValue(phoneNumber))
        {
            int index = 0;
            foreach (var item in phoneList)
            {
                if (item.Value == phoneNumber)
                {
                    Console.WriteLine("Arama sonucu : ");
                    Console.WriteLine("*************************");
                    Console.WriteLine("Ad ve Soyad : " + item.Key);
                    Console.WriteLine("Telefon Numarası : " + item.Value);
                }
                index++;
            }
            AnaSayfa();
        }
        else
        {
            Console.WriteLine("Aradığınız numara rehberde bulunamadı");
            SearchUser();
        }
        AnaSayfa();
    }
}
