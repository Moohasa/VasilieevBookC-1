using System;
class OverLoadMethodDemo
{
    //Overload(bir nom turli hil argumentlar statik metod yaratilishi
    //"перегрузка"
    
    // Print chopetish statik metodini tekst versiasi)
    static void print(string txt)
    {
        Console.WriteLine("Matn  " + txt);
    }
    //print chop etish statik metodini butun son versiyasi
    static void print(int num)
    {
        Console.WriteLine("butun son  " +  num);
    }
    //Print chop etish static metodini haqiqiy son versiasi
    static void print(double num)
    {
        Console.WriteLine("Haqiqiy son  " + num);

    }
    //print chop etish static metodini simvolli versiyasi
    static void print(char s)
    {
        Console.WriteLine("simvolli belgi   " + s);
    }
    //bitta print statik metodida turli hil argumentlar
    //butun sonli va simvolli qiymatni chop etish
    static void print(int num, char s)
    {
        Console.WriteLine("butun son va simvolli argumentlar {0}  {1}  "
            ,num,s);
    }
    //dasturni bosh metodi
    static void Main ()
    {
        //o'zgaaruvhchilar 
        int num = 5;
        double z = 12.5;
        char symb = '$';
        //matnli print
        print("overload metodlari bilan tanishuv");
        print(symb);
        print(num);
        print (z);
        print(num + symb);
        print("kelgusida omad:-)");



    }
}