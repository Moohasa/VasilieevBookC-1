using System;



class StringDemo
{
    // 1. Belgilar massivini stringga aylantiruvchi metod
    static String getText(char[] symbs)
    {
        String txt = ""; // Bo‘sh string yaratiladi
        for (int i = 0; i < symbs.Length; i++)
        {
            txt += symbs[i]; // Har bir belgini stringga qo‘shib boradi
        }
        return txt; // Tayyor stringni qaytaradi
    }

    // 2. Belgilar oraliqdan string yaratish metodi (a dan b gacha)
    static String getText(char a, char b)
    {
        String txt = ""; // Bo‘sh string
        char s = a; // Boshlang‘ich belgi
        while (s <= b) // a dan b gacha belgilar
        {
            txt += s; // Belgini qo‘shish
            s++; // Keyingi belgiga o‘tish
        }
        return txt; // Tayyor stringni qaytarish
    }

    static void Main()
    {
        // Belgilar massivini e'lon qilish
        char[] symbs = { 'H', 'a', 's', 'a', 'n', 'b', 'o', 'y' };

        Console.WriteLine("Simvolli massiv");
        Console.WriteLine(symbs); // C# da char[] avtomatik string sifatida chiqadi

        // 1. To‘liq massivdan string yaratish
        String A = new String(symbs); // "Hasanboy"
        Console.WriteLine("A:  \"{0}\"", A);

        // 2. Massivdan qisman string yaratish (1-pozitsiyadan 5 ta belgi)
        String B = new String(symbs, 1, 5); // "asanb"
        Console.WriteLine("B:  \"{0}\"", B);

        // 3. Bir xil belgidan iborat string (7 ta 's')
        String C = new String('s', 7); // "sssssss"
        Console.WriteLine("C:  \"{0}\"", C);

        // 4. getText('M','U') → "MNOPQRSTU"
        A = getText('M', 'U');
        Console.WriteLine("A:  \"{0}\"", A);

        // 5.hech narsa chiqmaydi, metod shartiga to'g'ri kelmaydi
        B = getText('U', 'M');
        Console.WriteLine("B:  \"{0}\"", B);

        // 6. getText(char[]) orqali massivni stringga aylantirish
        C = getText(symbs); // "Hasanboy"
        Console.WriteLine("C:  \"{0}\"", C);
    }
}
