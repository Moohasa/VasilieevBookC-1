using System;

class Program
{
    // 🧮 Statik metod: n gacha bo'lgan sonlar kvadratining yig'indisini hisoblaydi (rekursiv usulda)
    public static int SumOfSquaresRecursive(int n)
    {
        // 📌 Bazaviy holat (rekursiyani to‘xtatish sharti)
        // Agar n 1 yoki undan kichik bo‘lsa, to‘xtaydi. 1² = 1 ni qaytaradi.
        if (n <= 1)
            return 1;

        // 🔁 Rekursiv chaqiriq
        // Masalan: 3 bo‘lsa → 3² + SumOfSquaresRecursive(2)
        return n * n + SumOfSquaresRecursive(n - 1);
    }

    static void Main()
    {
        // 📥 Foydalanuvchidan n qiymatini olish
        Console.Write("n ni kiriting: ");
        int n = int.Parse(Console.ReadLine());

        // 🧾 Rekursiya bilan kvadratlar yig‘indisini hisoblash
        int result = SumOfSquaresRecursive(n);

        // 🖨 Natijani chiqarish
        Console.WriteLine($"(Rekursiya bilan) 1² + 2² + ... + {n}² = {result}");

        // ✅ Formuladan tekshiruv
        // n(n + 1)(2n + 1) / 6
        int formula = n * (n + 1) * (2 * n + 1) / 6;
        Console.WriteLine($"Formulaga ko‘ra: {formula}");
    }
}
