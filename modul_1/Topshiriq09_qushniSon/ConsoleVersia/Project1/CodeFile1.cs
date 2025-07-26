using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int son))
        {
            Console.WriteLine($"Natija: {son - 1}, {son}, {son + 1}");
        }
        else
        {
            Console.WriteLine("Iltimos, butun son kiriting.");
        }
    }
}
