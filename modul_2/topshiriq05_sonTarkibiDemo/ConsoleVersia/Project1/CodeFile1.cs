using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        string input = Console.ReadLine();

        if (long.TryParse(input, out long number))
        {
            // manfiy son bo'lsa, musbatga aylantiramiz
            number = Math.Abs(number);

            // minglik raqami aniqlash uchun 1000 ga bo'lib 1 ga qoldiq olish
            long thousandsDigit = (number / 1000) % 10;

            Console.WriteLine($"Sonning mingliklar o'rni: {thousandsDigit}");
        }
        else
        {
            Console.WriteLine("Iltimos, to'g'ri son kiriting.");
        }
    }
}
