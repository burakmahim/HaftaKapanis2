//Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

Console.Write("yarıçapı giriniz: ");
double yaricap=double.Parse(Console.ReadLine());

double alan = AlanHesaplama(yaricap);

Console.WriteLine(alan);

static double AlanHesaplama(double yaricap)
{
    return Math.PI * Math.Pow(yaricap, 2);
}