using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<string, int> categoryVotes = new Dictionary<string, int>();
    static List<string> categories= new List<string> { "Film Kategorileri","Tech Stack Kategorileri","Spor Kategorileri"};
    static Dictionary<string, bool> registeredUsers = new Dictionary<string, bool>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hoş geldiniz");
        while (true)
        {
            Console.WriteLine("Kullanıcı adınızı giriniz");
            string username = Console.ReadLine();
            if (!registeredUsers.ContainsKey(username))
            {
                Console.WriteLine(" Yeni Kullanıcı kaydı oluşturuldu");
                registeredUsers[username] = true;
                // registeredUsers.Add(username, true);
            }
            ShowCategories();
            Console.WriteLine("Oy vermek istediğiniz kategoriyi seçin (Çıkmak için 'q' tuşuna basın):");
            string selectedCategory = Console.ReadLine();

            if (selectedCategory.ToLower() == "q")
            {
                break;
            }

            if (categories.Contains(selectedCategory))
            {
                if (!categoryVotes.ContainsKey(selectedCategory))
                {
                    categoryVotes[selectedCategory] = 1;
                }
                else
                {
                    categoryVotes[selectedCategory]++;
                }

                Console.WriteLine("Oyunuz alındı. Teşekkür ederiz!");
            }
            else
            {
                Console.WriteLine("Geçersiz kategori seçimi. Lütfen geçerli bir kategori seçin.");
            }
        }
        DisplayResults();
    }
       

        
        static void ShowCategories()
        {
            Console.WriteLine("Oylama kategorileri:");
            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }
        }

    static void DisplayResults()
    {
        Console.WriteLine("Oylama Sonuçları:");
        foreach (var category in categories)
        {
            int votes = categoryVotes.ContainsKey(category) ? categoryVotes[category] : 0;
            double percentage = (votes / (double)registeredUsers.Count) * 100;

            Console.WriteLine($"{category}: {votes} oy, %{percentage:F2}");
        }
    }

}
