using System;

class Program
{
    static void Main()
    {
        // Massiv uzunligini aniqlovchi o'zgaruvchi
        int size = 11;

        // 11 ta elementdan iborat massiv e'lon qilinadi
        int[] powersOfTwo = new int[size];

        // Massivni 2 ning darajalari bilan to‘ldirish
        powersOfTwo[0] = 1; // 2^0 = 1

        for (int i = 1; i < size; i++)
        {
            powersOfTwo[i] = powersOfTwo[i - 1] * 2; // Har bir keyingi son oldingisining 2 baravariga teng
        }

        // Massivni to'g'ri tartibda chiqarish
        Console.WriteLine("Massiv (to‘g‘ri tartibda):");
        for (int i = 0; i < size; i++)
        {
            Console.Write(powersOfTwo[i] + " ");
        }

        Console.WriteLine(); // Bo‘sh qator

        // Massivni teskari tartibda chiqarish
        Console.WriteLine("Massiv (teskari tartibda):");
        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(powersOfTwo[i] + " ");
        }

        Console.WriteLine(); // Yana bo‘sh qator
    }
}
