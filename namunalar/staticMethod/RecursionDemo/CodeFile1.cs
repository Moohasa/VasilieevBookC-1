using System;
class RecursionDemo
{
    // faktorial sonni qaytaruvchi metof
    static int factorial(int n)
    {
        if (n == 1) return 1;
        else return n * factorial(n - 1);
    }
    //jfibonache sonini qaytaruvchi metod
    static int fibonacce(int n)
    {
        if (n == 1 || n == 2) return 1;
        else return fibonacce(n - 1) + fibonacce(n - 2);
    }
    //sonni yig'indisini qaytaruvchi metod
    static int summa(int n)
    {
        if (n == 0) return 0;
        else return n + summa(n - 1);;
    }
    //natijalarni chop etuvchi metod
    static void print(int[] a, int b)
    {
        //massivni element qiymatini chop etish
        Console.Write(a[b] + "  ");
        if (b == a.Length - 1)
        {
            Console.WriteLine();
        }
        //agar element massivning so'ngisi bo'lmasa
        else
        {
            print(a, b + 1);
        }

    }
    //massivni achop etish uchun metodni qayta e'lon qilamiz
    static void print(int[] a)
    {
        //metodni ikki argumentligi chaqiriladi
        print(a, 0);

    }
    static void Main()
    {
        Console.WriteLine("Sonni faktoriali");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " != " + factorial(i));
        }
        Console.WriteLine("fibonachi sonlari ");
        for (int i = 1;i <= 10; i++)
        {
            Console.WriteLine(i + " = " + fibonacce(i));
        }
        Console.WriteLine(" 100 gacha bo'lgan sonlarni yig'indisi");
        Console.WriteLine(summa(100));

        //sonli massiv
        int[] A = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
        //elemen 3 dan boshlanadi
       print(A);
        print (A,2);

    }
}