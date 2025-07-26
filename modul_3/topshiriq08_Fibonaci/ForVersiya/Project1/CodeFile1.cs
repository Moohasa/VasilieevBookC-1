using System;

class Program
{
    static void Main()
    {
        Console.Write("Fibonacci ketma-ketligidagi sonlar sonini kiriting: ");
        int n = int.Parse(Console.ReadLine());

        // Agar n kichik yoki 0 bo'lsa, dastur tugaydi
        if (n <= 0)
        {
            Console.WriteLine("Iltimos, musbat butun son kiriting.");
            return;
        }

        // Birinchi ikki Fibonacci soni
        int a = 1, b = 1;

        Console.WriteLine("Fibonacci ketma-ketligi:");

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == 2)
            {
                // Birinchi ikki son 1 ga teng
                Console.Write("1 ");
            }
            else
            {
                // Yangi son oldingi ikkitasining yig'indisi
                int c = a + b;
                Console.Write(c + " ");
                // O'tgan ikkita sonni yangilaymiz
                a = b;
                b = c;
            }
        }
    }
}
