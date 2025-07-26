using System; // Standart kutubxona: Console.WriteLine va boshqa umumiy funksiyalar uchun

// Bazaviy klass
class Base
{
    public int code;  // Ommaviy (public) maydon: avlod klasslar va tashqi kod ishlata oladi

    // Metod: code qiymatini konsolga chiqaradi
    public void show()
    {
        Console.WriteLine("Code maydoni: " + code);
    }
}

// MyClass - bu Base klassdan meros olgan avlod klass
class MyClass : Base
{
    public char symb;  // Ommaviy maydon: belgi saqlaydi

    // display metodi: symb ni chiqaradi va show() ni chaqiradi
    public void display()
    {
        Console.WriteLine("symb maydoni: " + symb);
        show(); // Base klassdagi show() metodini chaqiryapti
    }

    // number nomli xususiyat (property), bu orqali code ga kirish mumkin
    public int number
    {
        get
        {
            return code; // code qiymatini qaytaradi (Base'dan meros)
        }
        set
        {
            code = value; // code qiymatini o‘zgartiradi
        }
    }
}

// Dastur bajarilishi shu yerda boshlanadi
class InheritDemo
{
    static void Main()
    {
        MyClass obj = new MyClass(); // MyClass tipida obyekt yaratilyapti

        obj.code = 100;      // Base klassdagi maydonga to‘g‘ridan-to‘g‘ri qiymat berilmoqda
        obj.symb = 'A';      // MyClass'dagi symb maydoniga qiymat berildi

        obj.display();       // display() chaqiriladi → symb chiqariladi va show() ichida code ham

        obj.number = 200;    // property orqali code qiymati o‘zgartirilmoqda

        Console.WriteLine("number tarkibi:  " + obj.number); // number orqali code ni o‘qish

        obj.show();          // code ni yana konsolga chiqarish (200 bo‘lgan holatda)
    }
}
