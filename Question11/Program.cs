//3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

//yaş girdileri
Console.Write("Birinci kişinin yaşı: ");
int age1 = int.Parse(Console.ReadLine());

Console.Write("İkinci kişinin yaşı: ");
int age2 = int.Parse(Console.ReadLine());

Console.Write("Üçüncü kişinin yaşı: ");
int age3 = int.Parse(Console.ReadLine());

//method çağırma
int result = EnYasliKisi(age1, age2, age3);
Console.WriteLine($"En yaşlı kişi: {result}");

//method tanımlama
static int EnYasliKisi(int yas1, int yas2, int yas3)
{
    return Math.Max(yas1, Math.Max(yas2, yas3));
}
