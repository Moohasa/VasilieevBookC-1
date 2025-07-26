using System;
class Fibonacce
{
    static void Main()
    {
        Console.WriteLine("fibonache darajasini kiriting");
        ulong n = UInt32.Parse(Console.ReadLine()), k = 0, fib1 = 1, fib2 = 2, fibSum;

        for (k = 0; k < n - 2; k++)
        {
            fibSum = fib1 + fib2;
            fib1 = fib2; fib2 = fibSum;
            Console.WriteLine(k + 2 + " " + fibSum);

        }
        Console.WriteLine(fib2);

    }
}