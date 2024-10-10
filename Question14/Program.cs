// Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

//sayi girdisi
Console.Write("Lütfen bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());

//method çağırma
bool sonuc = TekMİCiftMi(sayi);

//methodun sonucunu yadırma
if (sonuc)
{
    Console.WriteLine("girilen sayi tektir.");
}

else
{
    Console.WriteLine("girilen sayi çifttir");
}

//method tanımlama
static bool TekMİCiftMi(int sayi)
{
    return sayi % 2 !=0;
}