//İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

//Deger döndüren method tanımlama
static int DegerleriTopla(int a, int b)
{
    return a + b;
}

//tanımlanmış deger donduren methodu çağırma
int topla = DegerleriTopla(5, 8);

Console.WriteLine($"iki sayının toplamı: {topla}");