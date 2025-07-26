using System;

class Program
{
    static void Main()
    {
        int size = 10; // Massiv o'lchami
        int[] numbers = new int[size];

        Random rand = new Random();

        // Massivni tasodifiy sonlar bilan to'ldirish (0 dan 99 gacha)
        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(0, 100);
        }

        // Tasodifiy to'ldirilgan massivni konsolga chiqarish
        Console.WriteLine("Boshlang'ich massiv:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        // Massivni kamayish tartibida saralash
        // 1-usul: Array.Sort va Array.Reverse
        Array.Sort(numbers);    // Massivni o'sish tartibida saralaymiz
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Array.Reverse(numbers); // Keyin massivni teskari aylantiramiz — kamayish tartibi hosil bo'ladi

        // Saralangan massivni konsolga chiqarish
        Console.WriteLine("Kamayish tartibida saralangan massiv:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
