using System;
class InitTwoDimArray
{
    static void Main(string[] args)
    {
        //ikki o'lchmli massiv yaratamiz va ishga tusshiramiz
        char[,] symbs = { { 'A', 'B', 'C' }, 
                        { 'D', 'E', 'F' } };
        Console.WriteLine("boshlang'ich massiv");
        //masivni chop etish
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                Console.Write(symbs[i, j]);

            }
            Console.WriteLine();
        }
        //tasodifiy raqam uchun obyekt yaratish
        Random rnd = new Random();
        //qator va ustun
        int row = rnd.Next(symbs.GetLength(0) + 1);
        int col = rnd.Next(symbs.GetLength(1) + 1);
        Console.WriteLine(" massive {0} chi qaotriga va {1} ustuniga qo'shilyapdi ", row, col);
        //Yangi massiv yaratish
        char[,] tmp = new char[symbs.GetLength(0) + 1, symbs.GetLength(1) + 1];
        //butun sonli o'zgaruvhci elon qilamiz
        int a, b;
        //simvolli o'zgaruvchi elon qilamiz
        char s = 'a';
        //massivni to'ldiramiz, birinchi massivdan nusxa olamiz
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            // yang massiv birinchi indeks element uchun
            if (i < row) a = i;
            else a = i + 1;
            for (int j = 0;  j < symbs.GetLength(1) ; j++)
            {
                //ikkinchi indeks yangi massiv elementi uchun
                if (j < col) b = j; else b = j + 1;
                //massiv element qiymatlarini tenglashtirish
                tmp[a, b] = symbs[i, j];

            }
        }
        //qo'shilgan qator ustunni to'ldirish
        for (int i = 0; i < tmp.GetLength(1); i++)
        {
            //qatordagi element qiymati
            tmp[row, i] = s;
            //yangi qiymat keyingi element uchun
            s++;
        }
        for (int i = 0; i<tmp.GetLength(0); i++)
        {
            //agar element qo'shilga qatorda bo'lmasa
            if (i != row)
            {
                //ustundagi element qiymati quyidagicha
                tmp[i, col] = s;
                //yangi qiymat keyingi elementga
                s++;
            }
        }
       // massivlarni tenglashtirish
       symbs = tmp;
        //yangi massivni chop etish
        Console.WriteLine();
        Console.WriteLine("ynagilangan massiv;");
        for (int i = 0;i < symbs.GetLength(0); i++)
        {
            for (int j = 0;j < symbs.GetLength(1); j++)
            {
                Console.Write(symbs[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}