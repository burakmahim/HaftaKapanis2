//list tanımlama
List<int> numbers = new List<int>();
string input;
Console.WriteLine("Sayı giriniz. Bitirmek için bitti yazınız.");


while (true)
{
    //sayı girdisi
    Console.Write("sayı: ");
    input = Console.ReadLine();

    //bitti yazarsa döngüyü bitirme
    if (input.ToLower() == "bitti")
    {
        break;
    }

    //deger dönüşümü
    bool isValid = int.TryParse(input, out int number);


    if (isValid)
    {
        numbers.Add(number);
    }

    else
    {
        Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin.");
    }
}

//methoddan gelen en büyük sayıyı yazdırma
if (numbers.Count > 0)
{
    int enBuyukSayi = EnBuyukSayi(numbers);
    Console.WriteLine($"Girilen sayılardan en büyüğü: {enBuyukSayi}");

}
else
{
    Console.WriteLine("Hiç sayı girilmedi.");
}


//merhod tanımlama
static int EnBuyukSayi(List<int> sayilar)
{
    int enBuyuk = sayilar[0];

    foreach (int sayi in sayilar)
    {
        if (sayi > enBuyuk)
        {
            enBuyuk = sayi;
        }
    }

    return enBuyuk;
}