using System;

class Program
{
    // Double factorial: recursive
    public static long DoubleFactorialRecursive(int n)
    {
        if (n <= 0)
            return 1; // ← Bazaviy holat (rekursiya shu yerda to‘xtaydi)
        return n * DoubleFactorialRecursive(n - 2);  // ← O‘zini qayta chaqiradi
                                                     
}

    static void Main()
    {
        Console.Write("n ni kiriting: ");
        int n = int.Parse(Console.ReadLine());

        long doubleFact = DoubleFactorialRecursive(n);
        Console.WriteLine($"{n}!! = {doubleFact}");
    }
}
