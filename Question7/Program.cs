//Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

// ilk metin girdisi
Console.Write("ilk metni giriniz: ");
string metin1 = Console.ReadLine();

// ikinci metin girdisi
Console.Write("ikinci metni giriniz: ");
string metin2 = Console.ReadLine();

// Metinlerin yerlerini değiştirme
string temp = metin1;
metin1 = metin2;
metin2 = temp;

Console.WriteLine("Yerleri değişmiş metinler:");
Console.WriteLine($"Yeni ilk metin {metin1}");
Console.WriteLine($"Yeni ikinci metin {metin2}");