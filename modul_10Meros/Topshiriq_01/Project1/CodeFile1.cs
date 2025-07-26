using System;

class ALpha
{
    protected string txt;

    public ALpha(string t)
    {
        txt = t;
    }

    public override string ToString()
    {
        return "ALpha klassi: " + txt;
    }
}

class Bravo : ALpha
{
    // Yangi field OCHILMADI, ALpha'dagi txt ishlatiladi

    public Bravo(string s) : base(s)
    {
        // Faqat ALpha konstruktoriga qiymat uzatildi
    }

    public Bravo(string t, string s) : base(t)
    {
        // txt ga yangi qiymat qo‘shiladi
        txt += " " + s;
    }

    public override string ToString()
    {
        return "Bravo klassi: " + txt;
    }
}

class Program
{
    static void Main()
    {
        ALpha a = new ALpha("Salom");
        Console.WriteLine(a); // ALpha klassi: Salom

        Bravo b1 = new Bravo("Yaxshi");
        Console.WriteLine(b1); // Bravo klassi: Yaxshi

        Bravo b2 = new Bravo("Salom", "dunyo");
        Console.WriteLine(b2); // Bravo klassi: Salom dunyo
    }
}
