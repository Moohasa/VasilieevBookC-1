using System;

class IndexingString
{
    // 1. getReversed: Stringni teskari tartibda qaytaradi
    static String getReversed(String txt)
    {
        String str = ""; // Bo‘sh string yaratiladi
        foreach (char s in txt) // Har bir belgini olamiz
        {
            str = s + str; // Har bir belgini boshiga qo‘shamiz → teskari bo'ladi
        }
        return str; // Teskari stringni qaytaradi
    }

    // 2. showReversed: Stringni teskari holatda konsolga chiqaradi
    static void showReversed(String txt)
    {
        for (int i = txt.Length - 1; i >= 0; i--) // Oxiridan boshlab
        {
            Console.Write(txt[i]); // Har bir belgini chiqarish
        }
        Console.WriteLine(); // Yangi qator
    }

    // 3. Main: Bosh dastur
    static void Main()
    {
        // a) Foreach yordamida har bir belgini ajratib chiqarish
        foreach (char s in "Matn")
        {
            Console.Write(s + "  "); // Belgilar orasiga ikki bo‘sh joy
        }
        Console.WriteLine(); // Yangi qator

        // b) For sikli orqali xuddi shu stringni chiqarish
        for (int i = 0; i < "Matn".Length; i++)
        {
            Console.Write("Matn"[i] + "  "); // Indeks orqali harflarni chiqarish
        }
        Console.WriteLine();

        // c) Yangi matn ustida ishlash
        String A = "C# o'rganayapmiz";

        // Har bir belgini chiqarish (indekslash orqali)
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i]);
        }
        Console.WriteLine();

        // d) Teskari chiqarish (lekin stringni o‘zgartirmay faqat chiqaradi)
        showReversed(A);

        // e) Asl matnni chiqarish
        Console.WriteLine(A);

        // f) getReversed orqali stringni teskari qilib olib, konsolga chiqarish
        String B = getReversed(A);
        Console.Write(B);
    }
}
