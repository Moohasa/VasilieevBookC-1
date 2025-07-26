using System;

class Program
{
    // Double factorial: non-recursive
    public static long DoubleFactorial(int n)
    {
        long result = 1;
        for (int i = n; i > 0; i -= 2)
        {
            result *= i;
            Console.WriteLine(result);
        }
        return result;
    }

    static void Main()
    {
        Console.Write("n ni kiriting: ");
        int n = int.Parse(Console.ReadLine());

        long doubleFact = DoubleFactorial(n);
        Console.WriteLine($"{n}!! = {doubleFact}");
    }
}
