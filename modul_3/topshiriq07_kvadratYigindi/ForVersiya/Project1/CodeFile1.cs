using System;

class Program
{
    static void Main()
    {
        Console.Write("n ni kiriting: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        // for sikli bilan 1^2 + 2^2 + ... + n^2 ni hisoblaymiz
        for (int i = 1; i <= n; i++)
        {
            sum += i * i;  // har bir sonning kvadratini qo‘shamiz
        }

        Console.WriteLine($"Kvadratlar yig'indisi (for bilan): {sum}");

        // Formuladan foydalanamiz: n(n+1)(2n+1)/6
        int formula = n * (n + 1) * (2 * n + 1) / 6;
        Console.WriteLine($"Formula bo‘yicha: {formula}");
    }
}
