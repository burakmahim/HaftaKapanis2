//Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

//hız ve yol bilgisinin alınması
Console.Write("hızı giriniz: ");
int hiz = int.Parse(Console.ReadLine());

Console.Write("yol bilgisini giriniz: ");
int sure = int.Parse(Console.ReadLine());

// methodun çağırılması
int mesafe = GidilenYol(hiz, sure);

Console.WriteLine($"gidilen yol  {mesafe}");

//method tanımı
static int GidilenYol(int fast, int time)
{
    int gidilenYol = fast * time;
    return gidilenYol;
}