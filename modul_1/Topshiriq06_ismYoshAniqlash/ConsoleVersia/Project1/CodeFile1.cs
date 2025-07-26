using System;

class Program
{
    static void Main()
    {
        Console.Write("Ismingizni kiriting: ");
        string ism = Console.ReadLine();

        Console.Write("Tug'ilgan yilingizni kiriting: ");
        string yilStr = Console.ReadLine();

        if (int.TryParse(yilStr, out int tugilganYil))
        {
            int hozirgiYil = DateTime.Now.Year;
            int yosh = hozirgiYil - tugilganYil;

            Console.WriteLine($"Salom, {ism}! Siz {yosh} yoshdasiz.");
        }
        else
        {
            Console.WriteLine("Yilni to'g'ri raqam ko'rinishida kiriting!");
        }
    }
}
