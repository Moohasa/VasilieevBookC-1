using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        string input = Console.ReadLine();

        // Sonni int ga aylantirishga harakat qilamiz
        if (int.TryParse(input, out int son))
        {
            if (son % 3 == 0)
            {
                Console.WriteLine($"{son} soni 3 ga bo'linadi.");
            }
            else
            {
                Console.WriteLine($"{son} soni 3 ga bo'linmaydi.");
            }
        }
        else
        {
            Console.WriteLine("Iltimos, butun son kiriting!");
        }
    }
}
