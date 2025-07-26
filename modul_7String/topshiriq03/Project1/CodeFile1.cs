using System;

class FuzzyCompareDemo
{
    /// <summary>
    /// Ikki satrni “fuzzy” usulda (belgilarning kod farqi ≤ 1) taqqoslaydi.
    /// </summary>
    /// <param name="a">Birinchi satr</param>
    /// <param name="b">Ikkinchi satr</param>
    /// <returns>
    /// Agar satrlarning uzunligi bir xil va har bir pozitsiyadagi 
    /// belgilar kod farqi ≤ 1 bo‘lsa — true, aks holda false.
    /// </returns>
    public static bool CompareStrings(string a, string b)
    {
        // 1. Uzunliklarini solishtiramiz: teng bo‘lmasa, darhol false qaytamiz
        if (a.Length != b.Length)
            return false;

        // 2. Har bir indeks bo‘yicha belgilarni tekshiramiz
        for (int i = 0; i < a.Length; i++)
        {
            // Belgilarni kodga aylantiramiz (char → int)
            int codeA = (int)a[i];
            int codeB = (int)b[i];

            // Agar kod farqi > 1 bo‘lsa, satrlar mos emas
            if (Math.Abs(codeA - codeB) != 0)
                return false;
        }

        // Agar hamma belgi shartga mos kelsa — true qaytamiz
        return true;
    }

    static void Main()
    {
        // 3. Test uchun misol satrlar
        Console.Write("1-satrni kiriting: ");
        string s1 = Console.ReadLine();

        Console.Write("2-satrni kiriting: ");
        string s2 = Console.ReadLine();

        // 4. Metodni chaqiramiz va natijani chiqaramiz
        bool same = CompareStrings(s1, s2);

        if (same)
            Console.WriteLine("Satrlar mos keldi (harf kodi farqi ≤ 1).");
        else
            Console.WriteLine("Satrlar mos kelmadi.");
    }
}
