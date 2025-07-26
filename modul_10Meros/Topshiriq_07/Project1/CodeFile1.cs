using System;

// Baza klass
class Base
{
    public string text;

    public Base(string t)
    {
        text = t;
    }

    // Virtual metod: hosila klassdan oddiy obyekt yaratadi
    public virtual Base Create()
    {
        return new MyClass(text, 'x');
    }
}

// Hosila klass
class MyClass : Base
{
    public char symb;

    public MyClass(string t, char s) : base(t)
    {
        symb = s;
    }

    // Override: hozirgi obyektning nusxasini qaytaradi
    public override Base Create()
    {
        return new MyClass(text, symb);
    }

    // ToString: obyekt haqida matnli ko‘rinish
    public override string ToString()
    {
        return "Matn: " + text + "\nBelgisi: " + symb;
    }
}

// Main klass
class Program
{
    static void Main()
    {
        // Baza klassdan obyekt
        Base b = new Base("Salom dunyo");
        Console.WriteLine("Base → Create():");
        Console.WriteLine(b.Create()); // Bu MyClass obyektini chiqaradi
        Console.WriteLine("b.text = " + b.text);
        Console.WriteLine();

        // Hosila klassdan obyekt
        MyClass b1 = new MyClass("Salom", 'h');
        Console.WriteLine("MyClass:");
        Console.WriteLine("text = " + b1.text);
        Console.WriteLine("symbol = " + b1.symb);

        Console.WriteLine("\nMyClass → Create():");
        Console.WriteLine(b1.Create()); // O‘zidan nusxa
    }
}
