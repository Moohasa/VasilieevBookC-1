using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 4 == 0 && number >= 10)
            {
                Console.WriteLine("Son 4 ga bo'linadi va 10 dan katta yoki teng.");
            }
            else
            {
                Console.WriteLine("Son shartlarga javob bermaydi.");
            }
        }
        else
        {
            Console.WriteLine("Iltimos, to'g'ri son kiriting.");
        }
    }
}
