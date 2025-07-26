using System;

using System;

// MyData klassi — uch xil ma’lumot saqlaydi: int, char, string
class MyData
{
    private int code;       // butun son maydon
    private char symb;      // belgi (char) maydon
    private string text;    // matnli maydon

    // Konstruktor — obyektga boshlang‘ich qiymat beradi
    public MyData(int n, char s, string t)
    {
        code = n; symb = s; text = t;
    }

    // ToString() — obyektni ekranga chiqarish uchun formatlangan ko‘rinishga aylantiradi
    public override string ToString()
    {
        string txt = "Obyekt maydoni:  \n";
        txt += "Butun son maydoni:  " + code + "\n";
        txt += "Simvolli maydon:  " + symb + "\n;";
        txt += "Butun matn:  " + text + "\n";
        txt += "__________________________";

        return txt;
    }

    // MyData + int — kodga qo‘shish, lekin boshqa qiymatlar eski holatda qoladi
    public static MyData operator +(MyData obj, int n)
    {
        return new MyData(+obj + n, -obj, ~obj);
    }

    // MyData - int — koddan ayirish
    public static MyData operator -(MyData obj, int n)
    {
        return new MyData(+obj - n, -obj, ~obj);
    }

    // int + MyData — kod qiymatiga int qo‘shish
    public static int operator +(int n, MyData obj)
    {
        return n + (+obj);
    }

    // int - MyData — kod qiymatidan ayirish
    public static int operator -(int n, MyData obj)
    {
        return n - (+obj);
    }

    // MyData + string — matnni almashtiradi
    public static MyData operator +(MyData obj, string t)
    {
        return new MyData(+obj, -obj, t);
    }

    // ~obj — string maydonni olish (matn)
    public static string operator ~(MyData obj)
    {
        return obj.text;
    }

    // +obj — unar operator, kodni olish
    public static int operator +(MyData obj)
    {
        return obj.code;
    }

    // -obj — unar operator, simvolni olish
    public static char operator -(MyData obj)
    {
        return obj.symb;
    }

    // obj >> int — matndagi chapdan indeksga teng harfni olish
    public static char operator >>(MyData obj, int k)
    {
        return (~obj)[k];
    }

    // obj << int — matndagi o‘ngdan indeksga teng harfni olish
    public static char operator <<(MyData obj, int k)
    {
        return (~obj)[(~obj).Length - k - 1];
    }

    // a ^ b — ikkita matnni "&" bilan bog‘lab, yangi obyekt yaratish
    public static MyData operator ^(MyData a, MyData b)
    {
        string txt = ~a + " & " + ~b;
        return new MyData(+a, -b, txt);
    }

    // A++ — kodga 10 qo‘shish
    public static MyData operator ++(MyData obj)
    {
        obj.code += 10;
        return obj;
    }

    // A-- — koddan 10 ayirish
    public static MyData operator --(MyData obj)
    {
        obj.code -= 10;
        return obj;
    }
}


class OverloadingOperatorsDemo
{
    static void Main()
    {
        // Ikki obyekt yaratamiz
        MyData A = new MyData(100, 'A', "Alpha");
        MyData B = new MyData(200, 'B', "Bravo");

        // A ^ B — matnlarni bog‘lab, yangi obyekt
        MyData C = A ^ B;

        // Har bir obyektni chiqarish
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(C);

        // B ^ A — teskarisi (matnlar o‘rin almashadi)
        C = B ^ A;
        Console.WriteLine(C);

        // Unar operatorlar: +A (code), -A (symb), ~A (text)
        int n = +A;
        char s = -A;
        string t = ~A;

        // Formatlangan chiqish
        Console.WriteLine("A obyekti maydonlari:  {0}, \'{1}\'  va \"{2}\"\n", n, s, t);

        // Postfix va prefix inkrement/dekrement operatorlari
        A++; // 100 → 110
        Console.WriteLine(A);
        Console.WriteLine(++A); // 110 → 120

        Console.WriteLine(B--); // Avval chiqaradi, keyin 200 → 190
        --B;                    // 190 → 180
        Console.WriteLine(B);

        // A + 1000 va A - 100
        C = A + 1000;
        Console.WriteLine(C);
        C = A - 100;
        Console.WriteLine(C);

        // int + MyData va int - MyData
        Console.WriteLine("Yig'indi va  ayirma :  {0}  va {1}\n", 2000 + A, 1000 - A);

        // Matnni o‘zgartirish: A + "Charlie"
        C = A + "Charlie";
        Console.WriteLine(C);

        // C >> i: matnning i-chi belgisi (chapdan)
        for (int i = 0; i < (~C).Length; i++)
        {
            Console.Write((C >> i) + "  ");
        }
        Console.WriteLine();

        // C << i: matnning i-chi belgisi (o‘ngdan)
        for (int i = 0; i < (~C).Length; i++)
        {
            Console.Write((C << i) + "  ");
        }
        Console.WriteLine();

        // Obyektni matnga aylantirib, chiqarish
        t = "Obyekt C." + C;
        Console.WriteLine(t);
    }
}
