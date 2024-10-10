//"Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string text = "Zaman bir GeRi SayIm";

string textKucuk= text.ToLower();
string textBuyuk= text.ToUpper();

Console.WriteLine(textKucuk);
Console.WriteLine(textBuyuk);
