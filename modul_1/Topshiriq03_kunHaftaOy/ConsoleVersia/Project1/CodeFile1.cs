using System;

class Program
{
    static void Main()
    {
        Console.Write("Hafta kunini kiriting (masalan: Dushanba): ");
        string haftaKuni = Console.ReadLine();

        Console.Write("Oy nomini kiriting (masalan: Mart): ");
        string oyNomi = Console.ReadLine();

        Console.Write("Oydagi sanani kiriting : ");
        string sana = Console.ReadLine();

        Console.WriteLine($"Bugungi sana: {haftaKuni}, {sana} - {oyNomi}.");
    }
}
