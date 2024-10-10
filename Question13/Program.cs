//Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

//metin girdisi
Console.Write("İlk ismi giriniz: ");
string isim1 = Console.ReadLine();

Console.Write("İkinci ismi giriniz: ");
string isim2 = Console.ReadLine();

//method çeğırma
IsimDegistirme(ref isim1, ref isim2);
Console.WriteLine($"yeni ilk isim {isim1}");
Console.WriteLine($"yeni ikinci isim {isim2}");

// method tanımlama
static void IsimDegistirme(ref string isim1, ref string isim2)
{
    string temp = isim1;
    isim1 = isim2;
    isim2 = temp;
    
}