using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 dan 7 gacha son kiriting va kunni bilib oling:");

        try
        {
            string input = Console.ReadLine();

            // Matnni butun songa aylantiramiz
            int dayNumber = int.Parse(input);

            // Son diapazonda ekanligini tekshiramiz
            if (dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Xato: Kiritilgan son 1 dan 7 gacha bo'lishi kerak.");
            }
            else
            {
                // switch bilan haftaning kunini aniqlaymiz
                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("Dushanba");
                        break;
                    case 2:
                        Console.WriteLine("Seshanba");
                        break;
                    case 3:
                        Console.WriteLine("Chorshanba");
                        break;
                    case 4:
                        Console.WriteLine("Payshanba");
                        break;
                    case 5:
                        Console.WriteLine("Juma");
                        break;
                    case 6:
                        Console.WriteLine("Shanba");
                        break;
                    case 7:
                        Console.WriteLine("Yakshanba");
                        break;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Xato: Iltimos, son kiriting.");
        }
    }
}
