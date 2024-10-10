//Rastgele bir sayı üretip , ekrana yazdırınız.
Random rnd = new Random();
int sayi = rnd.Next(1,20);

Console.WriteLine($"random sayı: {sayi}");