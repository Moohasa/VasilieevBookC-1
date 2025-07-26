using System;
//class nomi
class MyClass
{
    //yopiq butunsonli maydon
    private int num;
    //yopiq belgili maydon
    private char symb;
    //ochiq chop etuvchi metod
    public void print()
    {
        Console.WriteLine("obyekt maydonlari : " +  num + "  va  "+ symb);

    }
    //maydon qiymatlarni tenglashturuvchi metod
    //ikki argumentli versiyasi
    public void set(int n, char s)
    {
        num = n;
        symb = s;
    }
    //bir argumentli versiyalari
    public void set(int n)
    {
        num = n;
        symb = 'B';

    }
    //argumentsiz versiyasi
    public void set()
    {
        //Ikki argumentli versiyali metodni chaqirish
        set(100, 'A');

    }

}
//bosh metodli klass
class classMethodDemo
{
    static void Main()
    {
        //obyekt yaratilinadi
        MyClass obj = new MyClass();
        //maydon qiymatlarini tenglash(qiymatlash)
        obj.set();
        //qiymatlangan maydonni chop etish
        obj.print();
        //maydonni qiymatlash
        obj.set(200);
        //chop etish
        obj.print();
        //obyekt maydonni qiymatlash
        obj.set(300, 'C');
        //chop etish
        obj.print();
    }
}