using System;

class MyClass
{
    // Statik (hamma obyektlar uchun umumiy) indeks — bu toq sonlar ketma-ketligidagi tartib raqami
    private static int index = 1;

    // Statik property: bu yerda get va set alohida vazifani bajaradi
    public static int Value
    {
        // Har gal o'qilganda yangi toq sonni qaytaradi: 1, 3, 5, 7, ...
        get
        {
            int result = 2 * index - 1; // Toq son formulasi
            index++; // Keyingi chaqiruvda navbatdagi toq son chiqishi uchun indeksni oshiramiz
            return result;
        }

        // Agar qiymat tayinlansa — toq sonlar qayerdan boshlanishi belgilanadi
        // Masalan: 5 bo'lsa, toq sonlar 9, 11, 13 ... bo'ladi
        set
        {
            if (value > 0) // Faqat ijobiy tartib raqamlarga ruxsat
                index = value;
        }
    }
}

class OddGeneration
{
    static void Main()
    {
        // Toq sonlar ketma-ketligini 1-chi elementdan (ya'ni 1 dan) boshlaymiz
        MyClass.Value = 1;

        // Har safar Value o'qilganda navbatdagi toq son chiqadi
        Console.WriteLine(MyClass.Value); // 1 (1-chi toq son)
        Console.WriteLine(MyClass.Value); // 3 (2-chi)
        Console.WriteLine(MyClass.Value); // 5 (3-chi)
        Console.WriteLine(MyClass.Value); // 7 (4-chi)
    }
}
