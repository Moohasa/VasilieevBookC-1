using System;

class Program
{
    static void Main()
    {
        int size = 10; // Massiv o'lchami
        char[] consonants = new char[size]; // Undosh harflar uchun massiv

        // Ingliz alifbosidagi katta harflar, faqat undoshlar:
        // A, E, I harflari o‘tkazib yuboriladi
        // Boshlanish harfi 'A' (ASCII 65)
        char currentChar = 'A';

        int index = 0; // massiv elementining indeksini boshqarish

        // Massiv to'liq to'lgunga qadar harflarni tekshiramiz
        while (index < size)
        {
            // Agar currentChar 'A', 'E', yoki 'I' ga teng bo'lmasa — massivga qo'shamiz
            if (currentChar != 'A' && currentChar != 'E' && currentChar != 'I')
            {
                consonants[index] = currentChar;
                index++;
            }

            currentChar++; // Keyingi harfga o'tamiz

            // Agar 'Z' dan oshsa, alifboga qaytamiz (agar kerak bo'lsa)
            if (currentChar > 'Z')
            {
                // Qaytadan 'A' ga boshlash (kerak bo'lmasa, bu shartni olib tashlash mumkin)
                currentChar = 'A';
            }
        }

        // Natijani ekranga chiqarish
        Console.WriteLine("Massivdagi undosh katta harflar:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(consonants[i] + " ");
        }
        Console.WriteLine(); // Bo'sh qator
    }
}
