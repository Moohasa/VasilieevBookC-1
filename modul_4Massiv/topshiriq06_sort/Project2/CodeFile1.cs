using System;

class Program
{
    static void Main()
    {
        int size = 10; // Massiv o'lchami
        int[] numbers = new int[size];
        Random rand = new Random();

        // Tasodifiy sonlar bilan massivni to'ldirish
        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(0, 100);
        }

        // Boshlang'ich massivni chiqarish
        Console.WriteLine("Boshlang'ich massiv:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        // Bubble Sort yordamida kamayish tartibida saralash
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = size - 1 - i - 1; j >= 0; j--)
            {
                if (numbers[j] < numbers[j + 1])
                {
                    // Agar keyingi element kattaroq bo'lsa, almashtiramiz
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        // Saralangan massivni chiqarish
        Console.WriteLine("Kamayish tartibida saralangan massiv:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
