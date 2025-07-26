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
        Console.WriteLine("butun sonli maydon:  " +  num);
        //belgii maydon
        Console.WriteLine("belgili maydon:  " +  symb);
    }
}
//bosh metodli class
class UsingObjectDemo
{
    static void Main()
    {
        //birinchi obyekt
        MyClass A = new MyClass();
        //obyektli o'zgaruvchi
        MyClass B;
        //ikkinchi obyekt
        B = new MyClass();
        //maydonlarga qiymat belgilash
        A.num = 123;
        A.symb = 'A';
        //ikkinchi obyekt maydoniga qiymat belgilash
        B.num = 321;
        B.symb = 'B';
        //metod chaqiruvi
        Console.WriteLine("birinchi obyekt");
        A.print();
        Console.WriteLine("ikkinchi obyekt");
        B.print();
    }
}