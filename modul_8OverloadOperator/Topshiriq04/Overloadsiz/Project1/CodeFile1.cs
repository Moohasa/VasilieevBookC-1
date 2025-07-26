using System;

class MyClass
{
    public int Number;
    public string Text;

    public MyClass(int number, string text)
    {
        Number = number;
        Text = text;
    }

    // "Kichik" operatori: matn uzunligi bo'yicha
    public bool IsLessThan(MyClass other)
    {
        return this.Text.Length < other.Text.Length;
    }

    // "Katta" operatori: matn uzunligi bo'yicha
    public bool IsGreaterThan(MyClass other)
    {
        return this.Text.Length > other.Text.Length;
    }

    // "Kichik yoki teng" operatori: butun son bo'yicha
    public bool IsLessOrEqual(MyClass other)
    {
        return this.Number <= other.Number;
    }

    // "Katta yoki teng" operatori: butun son bo'yicha
    public bool IsGreaterOrEqual(MyClass other)
    {
        return this.Number >= other.Number;
    }

    // "Teng" operatori: butun son va matn tengligini tekshiradi
    public bool IsEqual(MyClass other)
    {
        if (other == null) return false;
        return this.Number == other.Number && this.Text == other.Text;
    }

    // "Teng emas" operatori: butun son va matn teng emasligini tekshiradi
    public bool IsNotEqual(MyClass other)
    {
        if (other == null) return true;
        return this.Number != other.Number || this.Text != other.Text;
    }
}

class Program
{
    static void Main()
    {
        MyClass a = new MyClass(10, "Hello");
        MyClass b = new MyClass(15, "World!");

        Console.WriteLine(a.IsLessThan(b));       // True, chunki "Hello".Length=5 < "World!".Length=6
        Console.WriteLine(a.IsGreaterThan(b));    // False
        Console.WriteLine(a.IsLessOrEqual(b));    // True, 10 <= 15
        Console.WriteLine(a.IsGreaterOrEqual(b)); // False, 10 >= 15 emas
        Console.WriteLine(a.IsEqual(b));           // False
        Console.WriteLine(a.IsNotEqual(b));        // True
    }
}
