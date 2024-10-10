//Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random rnd = new Random();

int sayi = rnd.Next(1, 100);

int kalan = sayi % 3;

Console.WriteLine($"{sayi} sayısının 3 ile bölümünden kalan {kalan}");