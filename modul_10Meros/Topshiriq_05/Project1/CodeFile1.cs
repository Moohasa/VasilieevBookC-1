using System;
class A
{
    public char symb;
    public A(char c)
    {
        symb = c;
    }
    public A(A obj)
    {
       symb = obj.symb;
    }     
}
class B : A
{
   
    public string text;
    public B (char c, string t):base(c)
    {
        text = t;
    }
    public B (B obj):base(obj)
    {
        symb = obj.symb;
        text = obj.text;
    }
}
class C : B
{
   
    public int num;
    public C(char c, string t, int n) : base(c, t)
    {
        num = n;
    }
    public C (C obj):base(obj)
    {
        symb = obj.symb;
        text = obj.text;
        num = obj.num;
    }
}
class Program
{
    static void Main()
    {
        // C klassidan obyekt yaratamiz
        C c1 = new C('a', "matn", 10);

        Console.WriteLine("Boshlang‘ich qiymatlar:");
        Console.WriteLine("c1.symb = " + c1.symb);
        Console.WriteLine("c1.text = " + c1.text);
        Console.WriteLine("c1.num = " + c1.num);

        // Qiymatlarni o‘zgartiramiz
        c1.symb = 'z';
        c1.text = "yangi matn";
        c1.num = 99;

        Console.WriteLine("\nO‘zgartirilgan qiymatlar:");
        Console.WriteLine("c1.symb = " + c1.symb);
        Console.WriteLine("c1.text = " + c1.text);
        Console.WriteLine("c1.num = " + c1.num);

        // Nusxalovchi konstruktor orqali nusxa yaratamiz
        C c2 = new C(c1);

        Console.WriteLine("\nNusxalangan obyekt qiymatlari (c2):");
        Console.WriteLine("c2.symb = " + c2.symb);
        Console.WriteLine("c2.text = " + c2.text);
        Console.WriteLine("c2.num = " + c2.num);

        // c1 ni o‘zgartirib, c2 ga ta’sir qilmaydiganligini ko‘rsatamiz
        c1.num = 123;

        Console.WriteLine("\nc1.num o‘zgartirilgach:");
        Console.WriteLine("c1.num = " + c1.num); // 123
        Console.WriteLine("c2.num = " + c2.num); // 99
    }
}


