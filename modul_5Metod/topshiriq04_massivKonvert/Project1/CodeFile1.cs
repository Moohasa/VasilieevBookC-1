using System;

class Program
{
    // Statik metod: char tipidagi massivni qabul qilib, 
    // har bir belgining butun sonli (int) kodlarini qaytaradi
    static int[] ConvertCharArrayToCodeArray(char[] charArray)
    {
        // 1. Natija uchun yangi butun sonlar massivini charArray uzunligi bilan yaratamiz
        int[] codeArray = new int[charArray.Length];

        // 2. For sikli yordamida charArray elementlarini birma-bir ko‘rib chiqamiz
        for (int i = 0; i < charArray.Length; i++)
        {
            // 3. Har bir char elementni int ga (ya’ni Unicode yoki ASCII kodga) o‘zgartiramiz
            codeArray[i] = (int)charArray[i];
        }

        // 4. Tayyorlangan butun sonlar massivini qaytaramiz
        return codeArray;
    }

    static void Main()
    {
        // 5. Sinov uchun simvollardan iborat massiv yaratamiz
        //  char[] symbols = { 'A', 'b', '3', '#', 'я' };

        Console.WriteLine("Iltimos, biror matn kiriting:");
        string input = Console.ReadLine();

        // 2. Satrni char massivga aylantirish
        char[] symbols = input.ToCharArray();

        // 6. Metodni chaqiramiz va natijani int massivga saqlaymiz
        int[] codes = ConvertCharArrayToCodeArray(symbols);

        // 7. Boshlang‘ich simvollarni ekranga chiqaramiz
        Console.WriteLine("Simvollar: " + new string(symbols));

        // 8. Har bir kodni alohida chiqarish uchun sikl ishlatamiz
        Console.WriteLine("Kodlar: ");
        foreach (int code in codes)
        {
            Console.Write(code + " ");
        }
        Console.WriteLine();
    }
}
