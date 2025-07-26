/*Statik metod yozing. Unga matn argument sifatida beriladi. 
 * Metod natijasida, ushbu matndagi har bir belgi orasiga probel 
 * qo‘shilgan matn qaytarilsin.*/

using System;

class InsertSpacesDemo
{
    // 🟦 Statik metod: kiruvchi matn orasiga bo‘sh joy (probel) qo‘shadi
    static string InsertSpaces(string text)
    {
        string result = ""; // Natijaviy matn

        for (int i = 0; i < text.Length; i++)
        {
            result += text[i]; // Har bir belgi qo‘shiladi

            // Oxirgi belgidan keyin probel qo‘shilmaydi
            if (i < text.Length - 1)
                result += " ";
        }

        return result; // Natijani qaytaradi
    }

    static void Main()
    {
        // 🟨 Kiruvchi matn
        Console.Write("Matn kiriting: ");
        string original = Console.ReadLine();

        // 🟨 Metodni chaqiramiz
        string spaced = InsertSpaces(original);

        // 🟩 Natijani chiqaramiz
        Console.WriteLine("Oraliqli matn: " + spaced);
    }
}
