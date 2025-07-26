using System;

class Program
{
    static void Main()
    {
        // Massiv o'lchami aniqlanadi
        int size = 10;

        // 10 ta simvolli massiv e'lon qilinadi
        char[] letters = new char[size];

        // Boshlang'ich harf ('a' ASCII'da 97)
        char currentChar = 'a';

        // Massivni har 2-harf bilan to‘ldirish
        for (int i = 0; i < size; i++)
        {
            letters[i] = currentChar;  // joriy harfni massivga joylaymiz
            currentChar += (char)2;    // keyingi harfga 2 qo‘shamiz: 'a' → 'c' → 'e' va hokazo
        }

        // Massivni to‘g‘ri tartibda chiqarish
        Console.WriteLine("Massiv (to‘g‘ri tartibda):");
        for (int i = 0; i < size; i++)
        {
            Console.Write(letters[i] + " ");
        }

        Console.WriteLine(); // Bo‘sh qator

        // Massivni teskari tartibda chiqarish
        Console.WriteLine("Massiv (teskari tartibda):");
        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(letters[i] + " ");
        }

        Console.WriteLine(); // Bo‘sh qator
    }
}
