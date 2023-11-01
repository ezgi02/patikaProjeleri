using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir string ifadeyi ve bir sayıyı (virgülle ayırarak) girin: ");
        string input = Console.ReadLine();
        string[] inputParts = input.Split(',');

        if (inputParts.Length == 2)
        {
            string text = inputParts[0].Trim();
            int indexToRemove = int.Parse(inputParts[1]);

            if (indexToRemove >= 0 && indexToRemove < text.Length)
            {
                string result = RemoveCharAtIndex(text, indexToRemove);
                Console.WriteLine("Sonuç: " + result);
            }
            else
            {
                Console.WriteLine("Hatalı endeks, lütfen doğru bir endeks girin.");
            }
        }
        else
        {
            Console.WriteLine("Hatalı giriş, lütfen string ifade ve endeks arasında bir virgül kullanın.");
        }
    }

    static string RemoveCharAtIndex(string text, int index)
    {
        if (index == 0)
        {
            return text.Substring(1);
        }
        else if (index == text.Length - 1)
        {
            return text.Substring(0, text.Length - 1);
        }
        else
        {
            return text.Substring(0, index) + text.Substring(index + 1);
        }
    }
}
