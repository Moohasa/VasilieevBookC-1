using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int size = 10; // Massiv o'lchami
        int[] numbers = new int[size];

        Random rand = new Random();

        // Massivni tasodifiy sonlar bilan to'ldirish (masalan, 0 dan 99 gacha)
        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(0, 100);
        }

        // Massivni konsolga chiqarish
        Console.WriteLine("Massiv elementlari:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine(); // Bo'sh qator

        // Minimal qiymatni topish
        int minValue = numbers[0];
        for (int i = 1; i < size; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }

        // Minimal qiymatga teng bo'lgan barcha indekslarni yig'ish
        List<int> minIndices = new List<int>();
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] == minValue)
            {
                minIndices.Add(i);
            }
        }

        // Natijani chiqarish
        Console.WriteLine($"Minimal qiymat: {minValue}");
        Console.Write("Minimal qiymatga ega elementlar indekslari: ");
        foreach (int index in minIndices)
        {
            Console.Write(index + " ");
        }
        Console.WriteLine();
    }
}
