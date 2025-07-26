using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting (o'nlik): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            // 3-bitni olish (o'ngdan hisoblaganda)
            int thirdBit = (number >> 2) & 1;

            Console.WriteLine($"Sonning o'ngdan uchinchi biti: {thirdBit}");
        }
        else
        {
            Console.WriteLine("Iltimos, to'g'ri butun son kiriting.");
        }
    }
}
