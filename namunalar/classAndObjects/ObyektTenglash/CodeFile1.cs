using System;
//klass nomi
class MyClass
{
    //butun sonli maydon
    public int num;
    //belgili maydon
    public char symb;
    //metod
    public void print()
    {
        //butun sonli qiymatni chop etish 
        Console.WriteLine("butun sonli maydon:  " + num);
        //belgii maydon
        Console.WriteLine("belgili maydon:  " + symb);
    }
}
//bosh metodli class
class ObyektTenglashDemo
{
    static void Main()
    {
        //obyekt o'zgaruvchilari
        MyClass A, B;
        A = new MyClass();
        // Obyektlarni bir biriga tenglash
        B = A;
        //ikkinchi obyekt maydoniga qiymat belgilash
        A.num = 123;
        A.symb = 'A';
        //metod chaqiruvi ikkinchi obyekt bilan
       
        Console.WriteLine("ikkinchi obyekt");
        B.print();
        B.num = 0;
        B.print();
    }
}