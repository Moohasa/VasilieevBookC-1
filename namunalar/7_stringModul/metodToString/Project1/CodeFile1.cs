using System;

// Maxsus sinf yaratamiz
class MyClass
{
    // Obyekt maydonlari (xususiyatlari)
    public int num;   // Raqamli maydon
    public char symb; // Belgili maydon

    // Konstruktor: obyekt yaratilganda avtomatik ishlaydi
    public MyClass(int n, char s)
    {
        num = n; symb = s;

        // this obyektni bildiradi, ya'ni shu obyektning o'zini
        // ToString() avtomatik chaqiriladi bu yerda
        Console.WriteLine("Yangi maydon yaratildi\n" + this);
    }

    // ToString() metodi — obyektni string shaklida ifodalaydi
    public override string ToString()
    {
        // Yangi string hosil qilamiz
        String txt = "Raqamli maydon :" + num;
        txt += "\nSimvol maydoni:  " + symb;

        return txt;
    }
}

// Asosiy ishchi sinf
class ToStringDemo
{
    static void Main()
    {
        // MyClass turida yangi obyekt yaratamiz
        MyClass obj = new MyClass(100, 'A');

        // Obyekt maydonlariga yangi qiymatlar beramiz
        obj.num = 200;
        obj.symb = 'B';

        // Yangi qiymatlarni chiqaramiz
        Console.WriteLine("Maydonni yangi qiymati");
        Console.WriteLine(obj); // bu yerda ham ToString() avtomatik chaqiriladi

        // Obyektning string ko‘rinishini alohida qatorlarga bo‘lamiz
        // obj dagi int qiymatni stringga o'tqazilyapdi
        String[] str = obj.ToString().Split('\n');

        Console.WriteLine("ToString metodini yaqqol chaqiruvi");

        // Har bir qatorni formatlab chiqaramiz
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine("[* " + str[i] + " *]");
        }
    }
}
