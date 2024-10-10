// Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

//// Kullanıcıdan true ya da false değerini al
Console.Write("True ya da False degeri giriniz: ");
bool cevap = bool.Parse(Console.ReadLine().ToLower());

//// Metodu çağır ve sonucu ekrana yazdır   
string result = TrueOrFalse(cevap);
Console.WriteLine($"Sonuc {result}");


//// True ya da False değerine göre string dönen metot
static string TrueOrFalse(bool value)
{
    if (value)
    {
        return "Doğru bir değer girdiniz.";
    }
    else
    {
        return "Ynalış bir değer girdiniz.";
    }
}