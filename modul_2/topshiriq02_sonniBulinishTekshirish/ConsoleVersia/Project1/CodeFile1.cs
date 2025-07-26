using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int son))
        {
            if (son % 5 == 2 && son % 7 == 1)
            {
                Console.WriteLine($"{son} soni 5 ga bo‘lganda qoldiq 2 va 7 ga bo‘lganda qoldiq 1 beradi.");
            }
            else
            {
                Console.WriteLine($"{son} soni shartlarga mos kelmaydi.");
            }
        }
        else
        {
            Console.WriteLine("Iltimos, to‘g‘ri butun son kiriting!");
        }
    }
}
