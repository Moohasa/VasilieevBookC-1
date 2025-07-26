using System;
using System.Dynamic;
class TwoDimArrayDemo
{
    static void Main()
    {
        // qator va ustunlar qiymati o'zgaruvchisi
        //ustun
        int rows = 3,
            //qator
            cols = 5;
        //ikki o'lchamli massiv yaratish
        int[,] numss = new int[rows, cols];
        //massivdagi birinchi element qiymati
        int value = 1;
        // massivni to'ldirish, ko'rsatish va tartiblash
        //massiv qatori
        for (int i = 0; i < numss.GetLength(0); i++)
        {
            //massivni ustuni
            for (int j = 0; j < numss.GetLength(1); j++)
            {
                numss[i, j] = value;
                // keyingi elementga qiymatni oshirib boriladi
                value++;
                //maassivni chop etiladi
                Console.Write(numss[i, j] + "\t");
            }
            //keyingi qatorga o'tiladi
            Console.WriteLine();
        }
    }
}