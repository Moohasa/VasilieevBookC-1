using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting (5 dan 10 gacha): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number >= 5 && number <= 10)
            {
                Console.WriteLine("Son diapazon ichida.");
            }
            else
            {
                Console.WriteLine("Son diapazon tashqarisida.");
            }
        }
        else
        {
            Console.WriteLine("Iltimos, to'g'ri son kiriting.");
        }
    }
}
