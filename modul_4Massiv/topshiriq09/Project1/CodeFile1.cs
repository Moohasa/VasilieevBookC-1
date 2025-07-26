using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        // Asosiy massiv o'lchamlari
        int rows = 4;
        int cols = 5;

        // Asosiy massivni yaratamiz
        int[,] originalArray = new int[rows, cols];

        // Massivni tasodifiy sonlar bilan to'ldirish (0 dan 99 gacha)
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                originalArray[i, j] = rnd.Next(0, 100);
            }
        }

        // Boshlang'ich massivni ko'rsatamiz
        Console.WriteLine("Boshlang'ich massiv:");
        Print2DArray(originalArray, rows, cols);

        // Tasodifiy o'chiriladigan qator va ustun indekslarini aniqlaymiz
        int rowToRemove = rnd.Next(0, rows);  // 0 dan rows-1 gacha
        int colToRemove = rnd.Next(0, cols);  // 0 dan cols-1 gacha

        Console.WriteLine($"\nO'chiriladigan qator indeksi: {rowToRemove}");
        Console.WriteLine($"O'chiriladigan ustun indeksi: {colToRemove}");

        // Yangi massiv yaratamiz, u bir qator va bir ustun kichik bo'ladi
        int[,] newArray = new int[rows - 1, cols - 1];

        // Yangi massivni to'ldirish uchun indekslarni saqlovchi o'zgaruvchilar
        int newRow = 0;

        for (int i = 0; i < rows; i++)
        {
            if (i == rowToRemove)
                continue; // O'chiriladigan qatorni o'tkazib yuboramiz

            int newCol = 0;

            for (int j = 0; j < cols; j++)
            {
                if (j == colToRemove)
                    continue; // O'chiriladigan ustunni o'tkazib yuboramiz

                // Qolgan elementlarni yangi massivga ko'chiramiz
                newArray[newRow, newCol] = originalArray[i, j];
                newCol++;
            }

            newRow++;
        }

        // Yangi massivni ko'rsatamiz
        Console.WriteLine("\nYangi massiv (o'chirilgan qator va ustun bilan):");
        Print2DArray(newArray, rows - 1, cols - 1);
    }

    // Yordamchi metod: 2D massivni chiroyli konsolga chiqarish
    static void Print2DArray(int[,] array, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
