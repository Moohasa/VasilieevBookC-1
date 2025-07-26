using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        bool success = int.TryParse(Console.ReadLine(), out int number);
        if (!success)
        {
            Console.WriteLine("Iltimos, butun son kiriting.");
            return;
        }

        // 4-bitni 0 ga o'rnatish uchun 1 ni chapga 3 marta suramiz: 1 << 3 = 8 (1000)
        // Bu bitni 0 qilish uchun AND operatoridan va uning inkoridan foydalanamiz
        int mask = ~(1 << 3);

        int result = number & mask;

        Console.WriteLine($"Natija: {result}");
    }
}
