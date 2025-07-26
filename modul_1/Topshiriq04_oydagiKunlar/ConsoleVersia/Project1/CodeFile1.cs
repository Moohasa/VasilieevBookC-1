using System;

class Program
{
    static void Main()
    {
        Console.Write("Oy nomini kiriting (masalan: Mart): ");
        string oy = Console.ReadLine();

        Console.Write("Ushbu oyda nechta kun borligini kiriting: ");
        string kunlar = Console.ReadLine();

        Console.WriteLine($"{oy} oyida {kunlar} kun bor.");
    }
}
