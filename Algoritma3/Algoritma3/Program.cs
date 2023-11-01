
/*
 Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

Örnek: Input: Merhaba Hello Algoritma x

Output: aerhabM oellH algoritmA x
 */

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bir metin girin:");
        string metin=Console.ReadLine();
        if (metin.Length < 2)
        {
            Console.WriteLine("Metin iki karekterden fazla olsun");
        }
        //Burda metin string ifadesi karekter dizesine dönüştürür;
        else
        {
            char[] metinDizi= metin.ToCharArray();

            //ilk harfi ve son harfi degiştirir.
            char temp = metinDizi[0];
            metinDizi[0] = metinDizi[metin.Length-1];
            metinDizi[metinDizi.Length-1] = temp;

            string sonuc=new string(metinDizi);
            Console.WriteLine(sonuc);
        }
    }
}