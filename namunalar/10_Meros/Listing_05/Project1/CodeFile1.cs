using System;

class Base
{
    public int code;

    // Base klassining oddiy metodlari
    public void show()
    {
        Console.WriteLine("code maydoni: " + code);
    }

    // Base klassining konstruktorlari
    public Base(int n)
    {
        code = n;
    }

    // Bu konstruktor "copy constructor" deb ataladi.
    // Boshqa Base tipidagi obyektni qabul qilib,
    // uning code maydonini yangi obyektga nusxalab beradi.
    public Base(Base obj)
    {
        code = obj.code; // bu yerda obj.code ni olish va yangi obyektga berish
    }
}

class MyClass : Base
{
    public char symb;

    public void display()
    {
        Console.WriteLine("symb maydoni: " + symb);
    }

    // MyClass konstruktori, bazaviy klass konstruktorini chaqiradi
    public MyClass(int n, char s) : base(n)
    {
        symb = s;
    }

    // MyClass uchun copy constructor
    // base(obj) chaqirilib, bazaviy klassdagi copy constructor ishlaydi
    public MyClass(MyClass obj) : base(obj)
    {
        symb = obj.symb;  // symb maydonini nusxalash
    }
}

class BaseObjVarDemo
{
    static void Main()
    {
        MyClass A = new MyClass(100, 'A'); // A obyekti yaratildi
        Base obj;  // Bazaviy klass tipida o'zgaruvchi yaratildi

        obj = A;  // Polimorfizm - Bazaviy klass tipidagi o'zgaruvchiga derived klass obyektini berish mumkin
        Console.WriteLine("obj o'zgaruvchisi qo'llandi:");
        obj.show();  // Bazaviy klass metodini chaqirish (code=100)

        // Quyidagi qismda (()) — "casting" ya'ni turini majburiy o'zgartirish amalga oshirilmoqda.
        // obj o'zgaruvchisi hozirda Base tipida, lekin undagi obyekt aslida MyClass tipida.
        // Shuning uchun bazaviy tipdagi o'zgaruvchini derived tipga aylantirib, derived sinfga xos metodni chaqirish mumkin.

        ((MyClass)obj).display(); // display metodini chaqirish uchun casting kerak

        // Endi bazaviy klass o'zgaruvchisining maydonini o'zgartiramiz
        obj.code = 200;
        // Endi esa symb maydonini ham derived klass tipida o'zgaruvchidan casting yordamida o'zgartiramiz
        ((MyClass)obj).symb = 'B';

        Console.WriteLine("A o'zgaruvchisi qo'llandi: ");
        A.show();     // A ning code maydoni 200 bo'lib qolganini ko'ramiz, chunki A va obj aslida bitta obyektga ishora qiladi
        A.display();  // symb ham 'B' bo'lib o'zgardi

        // Endi copy constructor orqali yangi obyekt yaratamiz
        MyClass B = new MyClass(A);

        Console.WriteLine("B o'zgaruvchisi qo'llandi");
        B.show();     // B ning code maydoni 200 (A dan nusxa olindi)
        B.display();  // symb ham 'B' (A dan nusxa)
    }
}
