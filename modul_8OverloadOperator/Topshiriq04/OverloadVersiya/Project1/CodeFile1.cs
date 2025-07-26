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

    // "Kichik" operatori (<): matn uzunligi bo'yicha taqqoslash
    public static bool operator <(MyClass a, MyClass b)
    {
        return a.Text.Length < b.Text.Length;
    }

    // "Katta" operatori (>): matn uzunligi bo'yicha taqqoslash
    public static bool operator >(MyClass a, MyClass b)
    {
        return a.Text.Length > b.Text.Length;
    }

    // "Kichik yoki teng" operatori (<=): butun son bo'yicha taqqoslash
    public static bool operator <=(MyClass a, MyClass b)
    {
        return a.Number <= b.Number;
    }

    // "Katta yoki teng" operatori (>=): butun son bo'yicha taqqoslash
    public static bool operator >=(MyClass a, MyClass b)
    {
        return a.Number >= b.Number;
    }

    // "Teng" operatori (==): butun son va matn tengligini tekshiradi
    public static bool operator ==(MyClass a, MyClass b)
    {
        // Null tekshirish
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;

        return a.Number == b.Number && a.Text == b.Text;
    }

    // "Teng emas" operatori (!=): butun son va matn teng emasligini tekshiradi
    public static bool operator !=(MyClass a, MyClass b)
    {
        return !(a == b);
    }

    // Equals metodini qayta yozamiz
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        MyClass other = (MyClass)obj;
        return this.Number == other.Number && this.Text == other.Text;
    }

    // GetHashCode metodini qayta yozamiz
    public override int GetHashCode()
    {
        // Oddiy hash kod: son va matnning hash kodlarini kombinatsiya qilish
        int hashNumber = Number.GetHashCode();
        int hashText = Text == null ? 0 : Text.GetHashCode();

        return hashNumber ^ hashText;  // XOR orqali kombinatsiya
    }
}

class Program
{
    static void Main()
    {
        MyClass a = new MyClass(10, "Hello");
        MyClass b = new MyClass(15, "World!");
        MyClass c = new MyClass(10, "Hello");

        Console.WriteLine(a < b);    // True (matn uzunligi 5 < 6)
        Console.WriteLine(a > b);    // False
        Console.WriteLine(a <= b);   // True (10 <= 15)
        Console.WriteLine(a >= b);   // False
        Console.WriteLine(a == c);   // True (son va matn teng)
        Console.WriteLine(a != b);   // True
    }
}
