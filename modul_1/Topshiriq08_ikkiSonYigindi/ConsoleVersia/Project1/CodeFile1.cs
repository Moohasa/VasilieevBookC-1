using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinchi sonni kiriting: ");
        string son1Str = Console.ReadLine();

        Console.Write("Ikkinchi sonni kiriting: ");
        string son2Str = Console.ReadLine();

        if (double.TryParse(son1Str, out double son1) && double.TryParse(son2Str, out double son2))
        {
            double summa = son1 + son2;
            Console.WriteLine($"Natija: {son1} + {son2} = {summa}");
        }
        else
        {
            Console.WriteLine("Iltimos, to‘g‘ri sonlar kiriting.");
        }
    }
}
