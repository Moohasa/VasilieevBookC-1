using System;

class MyClass
{
    public int Value;

    public MyClass(int value)
    {
        Value = value;
    }

    // Operator true: faqat 2, 3, 5, 7 bo‘lsa
    public static bool operator true(MyClass obj)
    {
        return obj.Value == 2 || obj.Value == 3 || obj.Value == 5 || obj.Value == 7;
    }

    // Operator false: agar qiymat 1 dan kichik yoki 10 dan katta bo‘lsa
    public static bool operator false(MyClass obj)
    {
        return obj.Value < 1 || obj.Value > 10;
    }

    // Operator &: && ishlashi uchun zarur
    public static MyClass operator &(MyClass a, MyClass b)
    {
        return new MyClass(a.Value + b.Value); // Farqi yo‘q, bu & operatori chaqirilishiga sabab bo‘ladi
    }

    // Operator |: || ishlashi uchun zarur
    public static MyClass operator |(MyClass a, MyClass b)
    {
        return new MyClass(a.Value + b.Value);
    }
}

class Program
{
    static void Main()
    {
        MyClass a = new MyClass(3);  // tub va 1–10 oralig‘ida → true
        MyClass b = new MyClass(5);  // tub → true
        MyClass c = new MyClass(11); // > 10 → false

        if (a && b)
        {
            Console.WriteLine("a && b => Ikkalasi ham tub va mos oraliqda.");
        }
        else
        {
            Console.WriteLine("a && b => Shart bajarilmadi.");
        }

        if (a || c)
        {
            Console.WriteLine("a || c => Kamida bittasi tub va oraliqda.");
        }
        else
        {
            Console.WriteLine("a || c => Shart bajarilmadi.");
        }

        if (c)
        {
            Console.WriteLine("c => tub va oraliqda");
        }
        else
        {
            Console.WriteLine("c => noto‘g‘ri obyekt (true emas)");
        }
    }
}
