using System;

class Program
{
    static void Main()
    {
        int rows = 4;  // qatorlar soni
        int cols = 5;  // ustunlar soni

        int[,] matrix = new int[rows, cols];

        // "Zmeika" bo'yicha to'ldirish uchun kerakli chegaralar
        int top = 0;             // yuqori chegarasi
        int bottom = rows - 1;   // pastki chegarasi
        int left = 0;            // chap chegarasi
        int right = cols - 1;    // o'ng chegarasi

        /*
         
         top, bottom, left, right - bu biz hozirgi "to'ldirish chegaralarimiz" ni bildiradi.

Har safar yagona qator yoki yagona ustunni to'ldirganimizdan so'ng, shu chegarani bir bo‘lak ichkariga (ichki tomonga) suramiz.

Dastlab, yuqori qatordan boshlaymiz, so‘ng o‘ng ustunni, pastki qatordan o‘ngdan chapga, keyin chap ustunni pastdan yuqoriga to‘ldiramiz.

Keyin yana yuqori qatorni, va shu tarzda to‘ldirishni davom ettiramiz.

Bu sikl chegaralar to‘qnashguncha ishlaydi.

*/

        int num = 1;  // to'ldirilayotgan qiymat

        // Chegaralar to'qnashguncha davom etadi
        while (top <= bottom && left <= right)
        {
            // 1) Yuqori qator: chapdan o'ngga
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = num++;
            }
            top++;  // yuqori qator pastga siljidi

            if (top > bottom) break;

            // 2) O'ng ustun: yuqoridan pastga
            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = num++;
            }
            right--;  // o'ng ustun chapga siljidi

            if (left > right) break;

            // 3) Pastki qator: o'ngdan chapga
            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = num++;
            }
            bottom--;  // pastki qator yuqoriga siljidi

            if (top > bottom) break;

            // 4) Chap ustun: pastdan yuqoriga
            for (int i = bottom; i >= top; i--)
            {
                matrix[i, left] = num++;
            }
            left++;  // chap ustun o'ngga siljidi
        }

        // Natijani konsolga chiqarish
        Console.WriteLine("Zmeyka bo'yicha to'ldirilgan massiv:");
        Print2DArray(matrix, rows, cols);
    }

    // 2D massivni chiroyli chiqarish uchun yordamchi metod
    static void Print2DArray(int[,] array, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }
    }
}
