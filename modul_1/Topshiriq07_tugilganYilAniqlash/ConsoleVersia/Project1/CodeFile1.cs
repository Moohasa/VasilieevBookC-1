using System;

class Program
{
    static void Main()
    {
        Console.Write("Yoshingizni kiriting: ");
        string yoshStr = Console.ReadLine();

        if (int.TryParse(yoshStr, out int yosh))
        {
            int joriyYil = DateTime.Now.Year;
            int tugilganYil = joriyYil - yosh;

            Console.WriteLine($"Siz taxminan {tugilganYil}-yilda tug‘ilgansiz.");
        }
        else
        {
            Console.WriteLine("Iltimos, to‘g‘ri raqam kiriting.");
        }
    }
}
