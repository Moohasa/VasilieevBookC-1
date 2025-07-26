using System;

class Fibs
{
    // Statik o'zgaruvchilar, barcha obyektlar uchun umumiy
    private static int last = 1;
    private static int prev = 1;

    // Statik property (xossa) — Fibs sinfi bo'yicha ishlaydi
    public static int number
    {
        // Qiymat olish (get) — Fibonacci ketma-ketligidan keyingi elementni hisoblaydi
        get
        {
            int res = prev;         // Natija sifatida oldingi elementni qaytaramiz
            last = last + prev;     // So'nggi ikkita element yig'indisini yangilaymiz
            prev = last - prev;     // Oldingi qiymatni yangilab boramiz (Fibonacci formulasi)
            return res;             // Natijani qaytaramiz
        }
        // Qiymat berish (set) — Fibonacci ketma-ketligini berilgan indexdan boshlash uchun
        set
        {
            prev = 1;   // Boshlang'ich qiymatlarni 1 ga o'rnatamiz
            last = 1;
            // Indeks bo'yicha ketma-ketlikni oldindan hisoblaymiz
            for (int i = 2; i <= value; i++)
            {
                last = last + prev;    // Keyingi Fibonacci sonini hisoblash
                prev = last - prev;    // oldingi qiymatni yangilash
            }
        }
    }
}

class StaticPropdemo
{
    static void Main()
    {
        // Fibonacci ketma-ketligining dastlabki 10 elementini chiqarish
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("{0,4}", Fibs.number);
            // {0,4} — birinchi argumentni 4 belgilik joy ajratib, o'ngga tekislab chiqaradi
            // Shu bilan sonlar chiroyli va qatorda joylashadi
        }
        Console.WriteLine();

        Fibs.number = 6; // Fibonacci ketma-ketligini 6-elementdan boshlash (reset va hisoblash)

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("{0,4}", Fibs.number);
        }
        Console.WriteLine();

        Fibs.number = 1; // Ketma-ketlikni yana 1-dan boshlash

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("{0,4}", Fibs.number);
        }
        Console.WriteLine();
    }
}
