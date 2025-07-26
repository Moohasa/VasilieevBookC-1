using System;

class Alpha
{
    public int alpha;

    // Argumentsiz set() metodi: alpha o'zgaruvchisini 10 ga tenglaydi va chiqaradi
    public void set()
    {
        alpha = 10;
        Console.WriteLine("Alpha (argumentsiz):  {0}", alpha);
    }

    // Virtual metod: bir int argument qabul qilib alpha ni o'sha qiymatga o'rnatadi va chiqaradi
    // virtual so'zi metodni avlod klasslarda override qilish mumkinligini bildiradi
    public virtual void set(int n)
    {
        alpha = n;
        Console.WriteLine("Alpha (bir argument):  {0}", alpha);
    }
}

class Bravo : Alpha
{
    public int bravo;

    // Override qilinayotgan metod — ota klassdagi virtual set(int n) ni qayta ta'riflayapmiz
    // Bravo klassida alpha va bravo qiymatlarini o'rnatadi va chiqaradi
    public override void set(int n)
    {
        alpha = n;
        bravo = alpha;
        Console.WriteLine("Bravo (bir argument):  {0},  {1}", alpha, bravo);
    }

    // Overload (qayta yuklash) — bir xil nomdagi set metodining yangi versiyasi,
    // lekin bu safar ikkita int argument qabul qiladi va ularni alpha va bravo ga o'rnatadi
    public void set(int m, int n)
    {
        alpha = m;
        bravo = n;
        Console.WriteLine("Bravo (ikki argument): {0}, {1}", alpha, bravo);
    }
}

class OverloadAndOverrideDemo
{
    static void Main()
    {
        Alpha A = new Alpha();
        A.set();       // Alpha klassidagi argumentsiz set() chaqiriladi -> alpha=10
        A.set(20);     // Alpha klassidagi virtual set(int n) chaqiriladi -> alpha=20
        Console.WriteLine();

        Bravo B = new Bravo();
        B.set();       // Alpha klassidan meros olingan argumentsiz set() chaqiriladi -> alpha=10
        B.set(30);     // Bravo klassidagi override qilingan set(int n) chaqiriladi -> alpha=30, bravo=30
        B.set(40, 50);// Bravo klassidagi overload qilingan set(int m, int n) chaqiriladi -> alpha=40, bravo=50
    }
}
