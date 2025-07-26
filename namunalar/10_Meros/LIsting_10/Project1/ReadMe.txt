
// --- Alpha klassi ---
// Ota klass, unda protected 'alpha' maydoni va private 'symbs' massiv mavjud.
// Property (number, length), indeksator ([int], [char]), va ToString() metodlari mavjud.

using System;
class Alpha
{
    protected int alpha;
    private char[] symbs;

    public Alpha(int a, string txt)
    {
        alpha = a;
        symbs = txt.ToCharArray(); // stringni belgilar massiviga aylantiramiz
    }

    public virtual int number
    {
        get { return alpha; }
        set { alpha = value; }
    }

    public int length
    {
        get { return symbs.Length; }
    }

    public char this[int k]
    {
        get { return symbs[k]; }
        set { symbs[k] = value; }
    }

    public virtual int this[char s]
    {
        get { return this[s - 'a']; } // 'a' -> 0, 'b' -> 1
        set { this[s - 'a'] = (char)value; } // qiymatni charga aylantirib yozamiz
    }

    public override string ToString()
    {
        string txt = "|";
        for (int i = 0; i < this.length; i++)
        {
            txt += this[i] + "|"; // har bir belgini |A|B|C| tarzda qo‘shamiz
        }
        return txt;
    }
}

// --- Bravo klassi ---
// Alpha'dan meros oladi. Qo‘shimcha 'bravo' maydoni mavjud.
// number property va [char] indeksator override qilingan.

class Bravo : Alpha
{
    protected int bravo;

    public Bravo(int a, int b, string txt) : base(a, txt)
    {
        bravo = b;
        // alpha qiymati base konstruktoridan olinadi, bu yerda alohida belgilanmaydi
    }

    public override int number
    {
        get { return alpha + bravo; } // faqat o‘qish (readonly)
    }

    public override int this[char s]
    {
        get
        {
            if (s == 'a') return alpha;
            else return bravo;
        }
        set
        {
            if (s == 'a') alpha = value;
            else bravo = value;
        }
    }
}

// --- Main() ---
// Obyektlar bilan ishlash. Property, indeksator, override, toString ko‘rinishda sinov qilinadi.

class inheritPropIndexerDemo
{
    static void Main()
    {
        int i;
        char s;

        Alpha A = new Alpha(100, "ABCD");
        Console.WriteLine("Obyekt A");
        Console.WriteLine(A); // ToString()
        Console.WriteLine("A.number =" + A.number);
        A.number = 150;
        Console.WriteLine("A.number =" + A.number);

        for (i = 0, s = 'a'; i < A.length; i++, s++)
        {
            Console.WriteLine("'{0}' simvoli {1} kodi bilan", A[i], A[s]);
        }

        A[0] = 'E';
        A['b'] = 'A' + 10; // 'K'
        Console.WriteLine(A);

        Bravo B = new Bravo(200, 300, "EFGHI");
        Console.WriteLine("Obyekt B:");
        Console.WriteLine(B);
        Console.WriteLine("B.number = " + B.number);

        // B.number = 400; // bu yerda xato bo‘ladi, chunki set mavjud emas

        B['a'] = 10; // alpha = 10
        B['d'] = 20; // bravo = 20
        Console.WriteLine("B['a']=" + B['a']);
        Console.WriteLine("B['b']=" + B['b']);
        Console.WriteLine("B.number = " + B.number);

        for (i = 0; i < B.length; i++)
        {
            Console.Write(B[i] + " ");
            B[i] = (char)('a' + i); // belgilarni 'a', 'b', 'c' ga almashtiramiz
        }
        Console.WriteLine();
        Console.WriteLine(B);
    }
}
