using System;

class CompareCharSets
{
    // Statik metod: ikki matn harf to‘plami bo‘yicha bir xilmi?
    public static bool AreLetterSetsEqual(string text1, string text2)
    {
        // Harf bor-yo‘qligini belgilovchi 256 o‘lchamli (ASCII bo‘yicha) massivlar
        bool[] set1 = new bool[256];
        bool[] set2 = new bool[256];

        // Har bir matndagi belgilar bo‘yicha to‘plam tuzamiz
        foreach (char ch in text1)
        {
            if (char.IsLetter(ch))  // faqat harflarni hisobga olamiz
            {
                set1[char.ToLower(ch)] = true;
            }
        }

        foreach (char ch in text2)
        {
            if (char.IsLetter(ch))
            {
                set2[char.ToLower(ch)] = true;
            }
        }

        // Har bir indeks bo‘yicha ikkala to‘plam bir xil bo‘lishi kerak
        for (int i = 0; i < set1.Length; i++)
        {
            if (set1[i] != set2[i])
                return false;
        }

        return true; // hamma belgilar mos keldi
    }

    static void Main()
    {
        Console.Write("Birinchi matnni kiriting: ");
        string t1 = Console.ReadLine();

        Console.Write("Ikkinchi matnni kiriting: ");
        string t2 = Console.ReadLine();

        bool result = AreLetterSetsEqual(t1, t2);

        Console.WriteLine("\nMatnlar harflar to‘plami bo‘yicha: {0}", result ? "bir xil" : "turli");
    }
}
