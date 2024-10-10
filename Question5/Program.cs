
//Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.Console.Write("Lütfen yaşınızı giriniz: ");

string age = Console.ReadLine();
bool isAge = short.TryParse(age, out short ageValue);

//sayı mı metin mi girildi kontrolü
if (isAge)
{
    //sayı girildiyse ve 18den büyükse
    if (ageValue > 18)
    {
        Console.WriteLine("+");
    }
    //sayı girildiyse ve 18 den küçükse
    else
    {
        Console.WriteLine("-");
    }
}

//metin girilmediyse
else
{
    Console.WriteLine("Lütfen sayı giriniz: ");
}