using System;

class Program
{
    // Statik metod: massiv, va ikki out parametri qabul qiladi
    static int FindMaxElement(int[,] array, out int maxRow, out int maxCol)
    {
        // Dastlab eng katta element sifatida birinchi elementni qabul qilamiz
        int max = array[0, 0];
        maxRow = 0;
        maxCol = 0;

        // Massivning o'lchamlarini olish
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Barcha elementlarni tekshirish uchun ikki sikl
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j]; // Yangi maksimum topildi
                    maxRow = i;        // Indekslarini saqlaymiz
                    maxCol = j;
                }
            }
        }

        return max; // Eng katta element qiymatini qaytaramiz
    }

    static void Main()
    {
        // Misol uchun 3x3 massiv
        int[,] myArray = {
            { 5, 4, 12, 7 },
            { 3,10, 15, 9 },
            { 8, 8, 6, 14 },
            { 7, 9, 10, 11 },
        };

        // Indekslar uchun o'zgaruvchilar e'lon qilamiz
        int maxRow, maxCol;

        // Metodni chaqiramiz
        int maxValue = FindMaxElement(myArray, out maxRow, out maxCol);

        Console.WriteLine($"Massivdagi eng katta element: {maxValue}");
        Console.WriteLine($"Indekslari: qator = {maxRow}, ustun = {maxCol}");
    }
}
