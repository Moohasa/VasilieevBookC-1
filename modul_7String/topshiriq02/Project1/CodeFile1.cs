/*Statik metod yozing, unga matn beriladi, u matndagi so'zlarni 
 * teskari tartibda qaytaradi. So'zlar probellar bilan ajratilgan
 * deb hisoblanadi.


 */

using System;

class ReverseWordsDemo
{
    // Statik metod: argument sifatida matn oladi va so'zlarni teskari tartibda qaytaradi
    public static string ReverseWords(string text)
    {
        // Matnni so'zlarga ajratamiz
        string[] words = text.Split(' ');

        // So'zlarni teskari tartibda jamlaymiz
        string result = "";

        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i];

            // Agar oxirgi so'z bo'lmasa, so'zlar orasiga probel qo'shamiz
            if (i > 0)
            {
                result += " ";
            }
        }

        return result;
    }

    static void Main()
    {
        string input = "Bu matn so'zlarni teskari tartibda chiqaradi";
        Console.WriteLine("Original matn: " + input);

        // Metodni chaqiramiz va natijani olamiz
        string reversed = ReverseWords(input);

        Console.WriteLine("Teskari tartibdagi matn: " + reversed);
    }
}
