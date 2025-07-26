using System;

class MyClass
{
    public int code;

    public MyClass(int n)
    {
        code = n;
    }

    // Bu operator: ikkita MyClass obyektini solishtiradi va kichik yoki teng bo'lgan obyektni qaytaradi.
    // Diqqat: bu overload NOTOG'RI — aslida <= operatori faqat bool qaytarishi kerak.
    public static MyClass operator <=(MyClass a, MyClass b)
    {
        if (a.code <= b.code)
        {
            return a; // a kichik yoki teng bo'lsa, a ni qaytaramiz
        }
        else
            return b; // aks holda b ni
    }

    // >= operatori ham xuddi shunday ishlayapti, bu yerda katta yoki teng bo'lgan obyektni qaytaryapti
    public static MyClass operator >=(MyClass a, MyClass b)
    {
        if (a.code >= b.code)
        {
            return a;
        }
        else
            return b;
    }

    // MyClass obyektini butun son bilan taqqoslaydi
    public static bool operator <=(MyClass a, int x)
    {
        // ❓ Nega `x - 1`?
        // Bu noaniq. Odatda `a.code <= x` deb solishtirish kerak.
        // Bu yerda x-1 deyilgan bo'lishi mumkin:
        // "katta bo'lmasligi" uchun xavfsiz oraliqni cheklamoqchi bo'lgan. Lekin bu chalkashtiradi.
        return a.code <= x - 1;
    }

    public static bool operator >=(MyClass a, int x)
    {
        // ❓ Nega `x + 1`?
        // Bu ham xatolik keltirishi mumkin. To‘g‘risi: `a.code >= x` bo'lishi kerak.
        return a.code >= x + 1;
    }

    // Bu operator: a.code < b.code holatni tekshiradi
    public static bool operator <(MyClass a, MyClass b)
    {
        // ❓ Nega if-else emas?
        // `return a.code < b.code;` bu if-else ni qisqa yozish shakli.
        // Ya'ni agar if (a.code < b.code) return true; else return false; bilan bir xil.
        return a.code < b.code;
    }

    public static bool operator >(MyClass a, MyClass b)
    {
        return a.code > b.code;
    }

    // ❌ Bu noto‘g‘ri overload:
    // < operatori faqat bool qaytarishi kerak, bu yerda int qaytarilmoqda.
    public static int operator <(MyClass a, int x)
    {
        return x - a.code; // ❌ noto‘g‘ri overload. Operator < faqat bool qaytarishi mumkin.
    }

    public static int operator >(MyClass a, int x)
    {
        return a.code - x; // ❌ noto‘g‘ri overload
    }
}

class MoreOverloadingCompsDemo
{
    static void Main()
    {
        MyClass A = new MyClass(100);
        MyClass B = new MyClass(200);

        Console.WriteLine("A obyekti:  {0}", A.code);
        Console.WriteLine("B obyekti:  {0}", B.code);
        Console.WriteLine("A<B natijasi:   {0}", A < B);  // true, chunki 100 < 200
        Console.WriteLine("A>B natijasi:   {0}", A > B);  // false

        Console.WriteLine();

        MyClass C;
        C = A >= B; // bu sizning overload qilingan >= operatoringiz ishlayapti
        // bu holda a.code = 100, b.code = 200 => return b qaytariladi (ya'ni B obyekt)
        C.code = 300; // bu yerda B obyektini code qiymatini o'zgartiryapsiz!

        Console.WriteLine("B obyekti:  {0}", B.code); // 300, chunki C va B — bir xil obyektga ishora qilmoqda!

        C = A <= B; // A <= B => a.code = 100, b.code = 300 => return A
        C.code = 150; // A obyektining code maydonini 150 ga o‘zgartiryapsiz

        Console.WriteLine("A obyekti:  {0}", A.code); // 150 chiqadi

        // 🔍 Bu yerda: (B <= A).code = 500;
        // Siz B va A ni solishtirasiz. B.code = 300, A.code = 150 => B > A => return A
        // Demak, bu ifoda A obyektini qaytaradi va uni .code qiymati 500 bo‘ladi
        (B <= A).code = 500;

        Console.WriteLine("A obyekti:  {0}", A.code); // 500 chiqadi — bu to‘g‘ri

        int x = 400, y = 500, z = 600;

        Console.WriteLine("A <= {0} natijasi '{1}' ga teng", x, A <= x); // 500 <= 399 → false
        Console.WriteLine("A >= {0} natijasi '{1}' ga teng", x, A >= x); // 500 >= 401 → true

        Console.WriteLine("A <= {0} natijasi {1} ga teng", y, A <= y); // 500 <= 499 → false
        Console.WriteLine("A >= {0} natijasi {1} ga teng", y, A <= y); // 👈 xato: >= bo‘lishi kerak edi, <= yozilgan

        Console.WriteLine("A <= {0} natijasi {1} ga teng", z, A <= z); // 500 <= 599 → true
        Console.WriteLine("A >= {0} natijasi {1} ga teng", z, A >= z); // 👈 bu ham noto‘g‘ri, ikkalasi ham <= bo‘lib qolgan

        // Quyidagilar operatorlar noto‘g‘ri overload bo‘lgani uchun ishlamasligi kerak:
        Console.WriteLine("A < {0} natijasi {1} ga teng", z, A < z); // ❌ operator<(MyClass, int) noto‘g‘ri
        Console.WriteLine("A > {0} natijasi {1} ga teng", x, A > x); // ❌ operator>(MyClass, int) noto‘g‘ri
    }
}
