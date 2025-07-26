using System;

// MyClass nomli klass e'lon qilinyapti
class MyClass
{
    // 2 ta maxfiy butun sonli maydon (faqat klass ichidan foydalaniladi)
    private int first;
    private int last;

    // Konstruktor: obyekt yaratilganda boshlang‘ich qiymatlarni oladi
    public MyClass(int a, int b)
    {
        first = a;  // birinchi qiymat
        last = b;   // ikkinchi qiymat
    }

    // ToString() metodini override qilamiz — obyektni string ko‘rinishida chiqarish uchun
    public override String ToString()
    {
        string txt = "Obyekt maydoni:  ";
        txt += first + "  va  " + last;
        return txt;
    }

    // number nomli xossa (property) — o‘zgacha xatti-harakatli
    public int number
    {
        get
        {
            // get ishlaganda first va last qiymatlarini joyini almashtiramiz (swap)
            int t = last;
            last = first;
            first = t;

            // almashtirishdan keyin t (eski last) qiymatini qaytaramiz
            return t;
        }
        set
        {
            // set ishlaganda yangi qiymat first ga yoziladi,
            // eski first qiymati esa last ga saqlanadi
            last = first;
            first = value;
        }
    }
}

// Dastur bajariladigan joy (Main)
class MorePropsDemo
{
    static void Main()
    {
        // MyClass obyektini yaratamiz: first = 1, last = 9
        MyClass obj = new MyClass(1, 9);

        // obyektni konsolga chiqaramiz (ToString ishlaydi)
        Console.WriteLine(obj); // 1 va 9

        // number xossasini o‘qiyapmiz: get ishlaydi → joy almashtiradi → 9 qaytadi
        Console.WriteLine("Butun son xossai:  {0}", obj.number);

        // obyektni yana chiqaramiz → endi qiymatlar almashgan: 9 va 1
        Console.WriteLine(obj);

        // number xossasiga 5 qiymatini beramiz → set ishlaydi
        // first = 5, last = 9 (oldingi first)
        obj.number = 5;

        // obyekt holatini chiqaramiz → 5 va 9
        Console.WriteLine(obj);

        // number o‘qiladi → joy almashtiradi → 9 ni qaytaradi
        Console.WriteLine("Butun son xossasi:  {0}", obj.number);

        // obyekt holatini chiqaramiz → qiymatlar almashgan: 9 va 5
        Console.WriteLine(obj);

        // yana o‘qiladi → joy almashtiradi → 5 ni qaytaradi
        Console.WriteLine("Butun son xossasi:   {0}", obj.number);

        // obyekt holati → qiymatlar yana almashgan: 5 va 9
        Console.WriteLine(obj);

        // number ga 3 yozamiz → set ishlaydi: first = 3, last = 5
        obj.number = 3;

        // obyekt holati: 3 va 5
        Console.WriteLine(obj);

        // Agar pastdagi qatorlar ishga tushirilsa:
        // get ishlaydi → joy almashtiradi → 5 ni qaytaradi
        // Console.WriteLine("Butun son xossasi:   {0}", obj.number);
        // Console.WriteLine(obj);
    }
}
