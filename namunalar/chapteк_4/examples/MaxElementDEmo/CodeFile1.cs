using System;
class MaxElementDemoConsoleApp
{
    static void Main()
    {
        Console.WriteLine("massivda katta qiymatni topish");

        Console.WriteLine();
        //element va indeks yozish uchun o'zgaruvchilar
        int value, index,
        // massiv o'lcghami
                            size = 15;
        // tasodifiy raqamni generatsiya qilish uchun obyekt
        Random rnd = new Random();
        //massive yaratish
        int[] nums = new int[size];
        //Massivni to'ldirish va konsolda chop etish
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rnd.Next(1, 100);
            Console.WriteLine(nums[i] + "  ");
        }
        Console.WriteLine();
        Console.WriteLine();
        //massivda katta qiymatni izlash
        index = 0;//indeksni boshlang'ich qiymati
        value = nums[index];// elementni indeksi bilan qiymati
        for (int i = 0;i < nums.Length;i++)
        {
            //Agar tekshirirlyatgan qiymati ushbu element qiymatdan katta bo'lsa
            if (nums[i] > value)
            {
                value = nums[i];//tekshiruvchi qiymatai ushbu elementga tenlashadi
                index = i;

            }
        }
        //Natijani konsolda e'lon qilish
        Console.WriteLine("katta qiymat  "+ value);
        Console.WriteLine("element indeksi  " + index);
    }
}