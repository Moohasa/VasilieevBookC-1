using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinchi sonni kiriting: ");
        string aStr = Console.ReadLine();

        Console.Write("Ikkinchi sonni kiriting: ");
        string bStr = Console.ReadLine();

        if (double.TryParse(aStr, out double a) && double.TryParse(bStr, out double b))
        {
            double summa = a + b;
            double ayirma = a - b;

            Console.WriteLine($"Yig‘indi: {summa}");
            Console.WriteLine($"Ayirma: {ayirma}");
        }
        else
        {
            Console.WriteLine("Iltimos, to‘g‘ri sonlar kiriting.");
        }
    }
}
