using System;
//klass nomi
class MyClass
{
    //yopiq maydonlar
    public int num;
    public char symb;
    public string txt;
    //chop etuvchi ochiq metod
    public void print()
    {
       // Console.WriteLine("maydonlar :  {0}, \'{1}\' va \"{ 2}\"", num, symb, txt);
        Console.WriteLine("Maydonlar  :  " +  num + ",  " + symb +" va  " + txt);

    }
    //argumentsiz konstruktor
    public MyClass()
    {
        num = 100;
        symb = 'A';
        txt = "Qizil";
    }
    //argumenti butunsonli konstruktor
    public MyClass(int n)
    {
        num = n;
        symb = 'B';
        txt = "Sariq";
    }
    //ikki argumentli konstruktor
    public MyClass(int n, char c)
    {
        num = n;
        symb = c;
        txt = "Yashil";
    }
    //uch argumentli konstruktor
    public MyClass(int n, char c, string s)
    {
        num = n;
        symb = c;
        txt = s;
    }
    //argumenti Matnli konstructor
    public MyClass(string s)
    {
        num = 0;
        symb = 'Z';
        txt = s;
    }

}
// bosh metodli klass
class ConstructorDemo
{
    static void Main()
    {
        //obyektlar yaratilinadi
        //yaratilgan konstructorlar chaqiriladi
        // argumentsiz konstruktor
        MyClass A = new MyClass();
        //;obyekt maydon qiymatlari tekshiramiz
        A.print();
        //butunsonli argumentli konstruktor
        MyClass B = new MyClass(200);
        //chop etish
        B.print();
        //ikki argumentli konstruktor
        MyClass C = new MyClass(300, 'C');
        //chop etish
        C.print();
        //uch argumentli konstructor
        MyClass D = new MyClass(400, 'D', "Ko'k");
        D.print();
        //Belgi argumentli konstruktor
        MyClass E = new MyClass('A');
        //chop etish
        E.print();
        //Matn argumentli konstructor
        MyClass F = new MyClass("Jigarrang");
        //chop etish
        F.print();
    }
}