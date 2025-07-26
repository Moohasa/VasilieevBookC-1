using System;

class MyClass
{
    // Statik private butun sonli maydon, dastlab 0 ga teng
    private static int counter = 0;

    // Statik metod — qiymatni ko'rsatadi va keyin 1 ga oshiradi
    public static void ShowAndIncrement()
    {
        Console.WriteLine("Joriy qiymat: " + counter);
        counter++;  // Qiymatni 1 ga oshirish
    }
}

class Program
{
    static void Main()
    {
        MyClass.ShowAndIncrement();  // 0 ni chiqaradi, keyin 1 ga oshiradi
        MyClass.ShowAndIncrement();  // 1 ni chiqaradi, keyin 2 ga oshiradi
        MyClass.ShowAndIncrement();  // 2 ni chiqaradi, keyin 3 ga
                                     // oshiradi

        MyClass.ShowAndIncrement();
        MyClass.ShowAndIncrement();
        MyClass.ShowAndIncrement();
    }
}
