using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        int number = int.Parse(Console.ReadLine());

        // 1-bitni teskari o'zgartirish uchun maska
        int mask = 1 << 1;

        // 1-bitni invertatsiya qilish
        int result = number ^ mask;

        Console.WriteLine($"Natija: {result}");
    }
}
