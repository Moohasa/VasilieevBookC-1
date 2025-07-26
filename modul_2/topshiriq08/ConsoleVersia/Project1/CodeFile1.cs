using System;

class Program
{
    static void Main()
    {
        Console.Write("Butun son kiriting: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            // 3-bitni 1 ga o‘rnatish
            int newNumber = number | (1 << 2);

            Console.WriteLine($"Yangi son: {newNumber}");
            Console.WriteLine($"Binary ko‘rinishi: {Convert.ToString(newNumber, 2).PadLeft(8, '0')}");
        }
        else
        {
            Console.WriteLine("Iltimos, butun son kiriting.");
        }
    }
}
