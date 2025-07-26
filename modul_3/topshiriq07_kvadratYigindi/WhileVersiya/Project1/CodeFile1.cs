using System;

class Program
{
    static void Main()
    {
        Console.Write("n ni kiriting: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int i = 1;

        while (i <= n)
        {
            sum += i * i;
            i++;
        }

        Console.WriteLine($"Kvadratlar yig'indisi (while bilan): {sum}");

        int formula = n * (n + 1) * (2 * n + 1) / 6;
        Console.WriteLine($"Formula bo‘yicha: {formula}");
    }
}
