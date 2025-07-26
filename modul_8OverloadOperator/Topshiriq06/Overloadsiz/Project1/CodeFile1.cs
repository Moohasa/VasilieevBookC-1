using System;

class MyClass
{
    public int Value;

    public MyClass(int value)
    {
        Value = value;
    }

    public bool IsPrime()
    {
        return Value == 2 || Value == 3 || Value == 5 || Value == 7;
    }

    public bool IsOutOfRange()
    {
        return Value < 1 || Value > 10;
    }
}

class Program
{
    static void Main()
    {
        MyClass a = new MyClass(3);
        MyClass b = new MyClass(5);

        if (!a.IsOutOfRange() && !b.IsOutOfRange() && (a.IsPrime() && b.IsPrime()))
        {
            Console.WriteLine("Ikkala obyekt ham tub va 1–10 oralig‘ida.");
        }
        else
        {
            Console.WriteLine("Shart bajarilmadi.");
        }
    }
}
