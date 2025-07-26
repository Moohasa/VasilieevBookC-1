using System;

// Bazaviy klass
class Base
{
    public int code; // public maydon (odatda bu private/protected bo'lishi kerak)

    public void show()
    {
        Console.WriteLine("Klass Base:  " + code);
    }

    // Konstruktor — bazaviy klassning code maydoniga qiymat beradi
    public Base(int n)
    {
        code = n;
    }
}

// MyClass bazaviy klassdan meros oladi
class MyClass : Base
{
    // Bu yerda "new" kalit so‘z bilan code maydoni YANGIDAN e’lon qilinyapti.
    // Endi bu MyClass uchun YANGI code maydonidir, bazaviy klassdagidan alohida.
    new public int code;

    // Bu yerda ham show() metodi "new" bilan qayta e’lon qilingan, bu - method hiding
    new public void show()
    {
        // Bazaviy klassning show() metodini chaqiramiz (unda Base.code ishlatiladi)
        base.show();

        // MyClass’dagi yangi code maydonini chiqaramiz
        Console.WriteLine("Klaass MyClass:  " + code);
    }

    // Base klassdagi code maydoniga qiymat beruvchi metod
    public void set(int n)
    {
        base.code = n; // bu yerda base klassdagi code maydoniga murojaat qilinyapti
    }

    // Konstruktor — ikkita code maydoniga qiymat beradi:
    // base(m) — bazaviy klassdagi code maydoniga
    // code = n — MyClass’dagi yangi maydon
    public MyClass(int m, int n) : base(m)
    {
        code = n;
    }
}

// Test klass
class inhritAndHidingDemo
{
    static void Main()
    {
        // MyClass tipidagi obyekt yaratildi: Base.code = 100, MyClass.code = 200
        MyClass obj = new MyClass(100, 200);

        obj.show();  // 1-chi ko‘rsatish:
                     // Klass Base: 100      ← bu base.code qiymati
                     // Klaass MyClass: 200  ← bu MyClass.code qiymati

        Console.WriteLine();
        // set(300): bu bazaviy code maydoniga yangi qiymat berish
        obj.set(300);

        // obj.code = 400 — bu MyClass’dagi YANGI code maydoniga berilyapti
        obj.code = 400;

        obj.show();  // 2-chi ko‘rsatish:
                     // Klass Base: 300      ← bazaviy maydon
                     // Klaass MyClass: 400  ← MyClass’dagi maydon
    }
}