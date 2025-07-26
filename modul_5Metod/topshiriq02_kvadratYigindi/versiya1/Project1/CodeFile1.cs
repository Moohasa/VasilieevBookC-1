using System;

class Program
{
    public static int SumOfSquares(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i * i;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("n ni kiriting: ");
        int n = int.Parse(Console.ReadLine());

        int result = SumOfSquares(n);
        Console.WriteLine($"1² + 2² + ... + {n}² = {result}");

        // Formuladan tekshiruv
        int formula = n * (n + 1) * (2 * n + 1) / 6;
        Console.WriteLine($"Formulaga ko‘ra: {formula}");
    }
}
