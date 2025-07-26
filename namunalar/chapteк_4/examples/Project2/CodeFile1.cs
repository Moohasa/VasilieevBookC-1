using System;
class ArrayCopyDemo
{
    static void Main()
    {
        Console.WriteLine("Massivdan nusxa olish\t");
        //Butun sonli massiv
        int[] A = { 1, 3, 5, 7, 9 };
        //massiv o'zgaruvchisi
        int[] B, C;
        //massivni tenglash
        B = A;
        //yangi massiv
        C = new int[A.Length];
        //massivni element bo'yicha nusxa olish
        for (int i = 0; i < A.Length; i++)
        {
            C[i] = A [i];   
        }
        //A massivini birirnchi elementini o'zgartirish
        A[0]= 0;
        //B massivini oxirgi elementini o'zgartirish
        B[B.Length - 1]= 0;
        Console.WriteLine("A:\tB:\tC:");
        //Konsolda massivni ko'rsatish
        for (int i = 0;i < A.Length;i++)
        {
            Console.WriteLine("{0}\t {1}\t {2}", A[i], B[i], C[i]);
        }

    }
}