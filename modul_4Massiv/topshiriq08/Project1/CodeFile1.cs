using System;

class Program
{
    static void Main()
    {
        // Tasodifiy sonlar uchun Random obyekti yaratamiz
        Random rnd = new Random();

        // Boshlang'ich massiv o'lchamlari (masalan, 3 qator, 5 ustun)
        int rows = 3;
        int cols = 5;

        // Dastlabki massivni e'lon qilamiz
        int[,] originalArray = new int[rows, cols];

        // Massivni tasodifiy sonlar bilan to'ldiramiz
        for (int i = 0; i < rows; i++)           // Har bir qator uchun
        {
            for (int j = 0; j < cols; j++)       // Har bir ustun uchun
            {
                originalArray[i, j] = rnd.Next(0, 100); // 0 dan 99 gacha bo'lgan tasodifiy son
            }
        }

        // Boshlang'ich massivni konsolga chiqaramiz
        Console.WriteLine("Boshlang'ich massiv:");
        Print2DArray(originalArray, rows, cols);

        // Endi transpozitsiya qilingan yangi massivni yaratamiz
        // Transpozitsiya: satrlar soni va ustunlar soni o'rin almashadi
        int[,] transposedArray = new int[cols, rows]; // endi qatorlar = cols, ustunlar = rows

        // Transpozitsiya jarayoni
        for (int i = 0; i < rows; i++)           // Dastlabki massiv qatorlari bo'ylab
        {
            for (int j = 0; j < cols; j++)       // Dastlabki massiv ustunlari bo'ylab
            {
                // Dastlabki massivning i-qatori, j-ustuni yangi massivning j-qatori, i-ustuni bo'ladi
                transposedArray[j, i] = originalArray[i, j];
            }
        }

        // Yangi, transpozitsiya qilingan massivni chiqaramiz
        Console.WriteLine("\nTranspozitsiya qilingan massiv:");
        Print2DArray(transposedArray, cols, rows);
    }

    // 2D massivni chiroyli ko'rinishda konsolga chiqarish uchun yordamchi metod
    static void Print2DArray(int[,] array, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)      // Har bir qator uchun
        {
            for (int j = 0; j < cols; j++)  // Har bir ustun uchun
            {
                // Massiv elementini chiqaramiz va elementlar orasida bo'sh joy qoldiramiz
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine(); // Har qator oxirida yangi qatordan boshlaymiz
        }
    }
}
