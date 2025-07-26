using System;

class Program
{
    static void Main()
    {
        Console.Write("Fibonacci ketma-ketligidagi sonlar sonini kiriting: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Iltimos, musbat butun son kiriting.");
            return;
        }

        int a = 1, b = 1;
        int count = 1;

        Console.WriteLine("Fibonacci ketma-ketligi:");

        do
        {
            if (count == 1 || count == 2)
            {
                Console.Write("1 ");
            }
            else
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            count++;
        } while (count <= n);
    }
}
