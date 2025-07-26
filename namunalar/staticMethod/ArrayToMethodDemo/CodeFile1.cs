using System;
class ArrayToMethodDemo
{
    //massivni tasodifiy sonlar bilan to'ldirish uchun static metod
    static void massivToldirish(int[] nums)
    {
        //Random obyekti sonni tasodifiy son bilan to'ldirgani
        Random r = new Random();
        //massivni to'ldirish uchun sikl
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = r.Next(1, 100);
        }

    }
    //massivni chop etish uchun statik metod
    static void printMassiv(int[] nums)
    {
        //massivni chop etish uchun sikl
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("| {0 }", nums[i]);

        }
        Console.WriteLine("|");
    }
 
    //ikki o'lchamli massivni chop etish uchun print statik metodini overloadi
    static void printMassiv(int[,] nums)
    {
        //massivni chop etish uchun sikllar
        for(int i = 0;i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write("{0, 3}", nums[i, j]);
            }
            Console.WriteLine();
        }

    }
    //massivdan eng kichik elementini topish statik metodi
    static int kichikSonTopish(int[] nums)
    {
       //lokal o'zgaruvchi
       int s = nums [0];
        //massivdan eng kichik elementi topish uchun sikl
        for (int i = 1; i < nums.Length; i++)
        {
            //agar joriy element s o'zgaruvchisidan kichik bo'lsa
            //s o'zgaruvchisiga tenglanadai
            if (nums[i] < s) s= nums[i];
        }
        //qaytuvchi metod natijasi
        return s;

    }
    static void print (string matn)
    {
        Console.WriteLine(matn );
    }
   // Main bosh metodi
   static void Main()
    {
        // bir o'lchamli massiv
        int[] A = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int[] B = new int[5];
        // ikki o'lchamli massiv
        int[,] C = { { 1, 2, 3, 4, }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        // B massivni tasodifiy sonlar bilan to'ldiramiz
        // massivni to'ldirish metodini qo'llanilinadi
        massivToldirish( B);


        print("Massiv  A");
        printMassiv(A);
        print("Massiv  B");
        printMassiv(B);
        //B massividan eng kichik elementni topamiz
        // o'zgaruvchi elon qilib unga metod natijasini qaytaramiz
        int m = kichikSonTopish (B);
        //natijani chop etamiz
        Console.WriteLine(" B massivini eng kichik qiymat {0}", m);


        print("Ikki o'lchamli massiv C");
        printMassiv(C);


    }
}