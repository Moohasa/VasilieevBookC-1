using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting (o'nlik): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number < 0)
            {
                Console.WriteLine("Iltimos, manfiy bo'lmagan son kiriting.");
                return;
            }

            // Sonni sakkizlik tizimga o'zgartiramiz
            string octal = Convert.ToString(number, 8);
            Console.WriteLine(octal);

            // O'ngdan ikkinchi raqamni olish uchun
            // Stringning uzunligi 2 dan katta bo'lishi kerak
            if (octal.Length >= 2)
            {
                char secondFromRight = octal[octal.Length - 2];
                Console.WriteLine($"Sakkizlik ko'rinishda o'ngdan ikkinchi raqam: {secondFromRight}");
            }
            else
            {
                Console.WriteLine("Sakkizlik ko'rinishda o'ngdan ikkinchi raqam mavjud emas.");
            }
        }
        else
        {
            Console.WriteLine("Iltimos, to'g'ri butun son kiriting.");
        }
    }
}
