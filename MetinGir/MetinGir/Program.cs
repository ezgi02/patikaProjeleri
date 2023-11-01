using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir metin girin:");
        string metin = Console.ReadLine();

        bool sonuc = SessizVarMi(metin);
        Console.WriteLine(sonuc);
    }

    static bool SessizVarMi(string metin)
    {
        for (int i = 0; i < metin.Length - 1; i++)
        {
            char mevcutKarakter = char.ToLower(metin[i]);
            char sonrakiKarakter = char.ToLower(metin[i + 1]);

            if (Char.IsLetter(mevcutKarakter) && Char.IsLetter(sonrakiKarakter))
            {
                if ("aeiou".Contains(mevcutKarakter) && "aeiou".Contains(sonrakiKarakter))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
