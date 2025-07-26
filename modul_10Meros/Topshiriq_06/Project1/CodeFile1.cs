using System;

// Baza klass: matnli maydon va uni ko‘rsatish funksiyasi bor
class Base
{
    protected string text; // himoyalangan matnli maydon

    // Konstruktor: obyektga matn qiymatini berish
    public Base(string t)
    {
        text = t;
    }

    // Virtual metod: klass nomi va matn qiymatini chiqaradi
    public virtual void Show()
    {
        Console.WriteLine("Base klassi");
        Console.WriteLine("Text: " + text);
    }
}

// Birinchi hosila klass: matn + raqam saqlaydi
class FirstDerived : Base
{
    protected int number; // himoyalangan butun sonli maydon

    // Konstruktor: matn va sonni qabul qiladi
    public FirstDerived(string t, int n) : base(t)
    {
        number = n;
    }

    // Overriding: Show metodi yangilangan, 2 ta qiymat chiqaradi
    public override void Show()
    {
        Console.WriteLine("FirstDerived klassi");
        Console.WriteLine("Text: " + text);
        Console.WriteLine("Number: " + number);
    }
}

// Ikkinchi hosila klass: matn + belgi saqlaydi
class SecondDerived : Base
{
    protected char symbol; // himoyalangan belgili maydon

    // Konstruktor: matn va belgi qabul qiladi
    public SecondDerived(string t, char s) : base(t)
    {
        symbol = s;
    }

    // Overriding: Show metodi matn va belgini chiqaradi
    public override void Show()
    {
        Console.WriteLine("SecondDerived klassi");
        Console.WriteLine("Text: " + text);
        Console.WriteLine("Symbol: " + symbol);
    }
}

// Dastur boshlanishi
class Program
{
    static void Main()
    {
        // Baza klassdan obyekt yaratamiz
        Base a = new Base("Bazaviy matn");
        a.Show();
        Console.WriteLine();

        // Birinchi hosila klassdan obyekt
        FirstDerived b = new FirstDerived("Birinchi hosila", 42);
        b.Show();
        Console.WriteLine();

        // Ikkinchi hosila klassdan obyekt
        SecondDerived c = new SecondDerived("Ikkinchi hosila", 'Z');
        c.Show();
        Console.WriteLine();

        // Polimorfizm: baza klass orqali hosila obyektga murojaat
        Console.WriteLine("→ Polimorfizm sinovi:");

        Base ref1 = new FirstDerived("Polimorfizm 1", 100);
        Base ref2 = new SecondDerived("Polimorfizm 2", 'X');

        ref1.Show(); // FirstDerived.Show() ishlaydi
        Console.WriteLine();
        ref2.Show(); // SecondDerived.Show() ishlaydi
    }
}
