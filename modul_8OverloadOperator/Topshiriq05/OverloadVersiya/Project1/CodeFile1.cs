using System;

class MyClass
{
    public int Number;
    public char Symbol;

    public MyClass(int number, char symbol)
    {
        Number = number;
        Symbol = symbol;
    }

    // Operator true: |Number - Symbol| <= 10 bo‘lsa — true
    public static bool operator true(MyClass obj)
    {
        return Math.Abs(obj.Number - (int)obj.Symbol) <= 10;
    }

    // Operator false: aks holda — false
    public static bool operator false(MyClass obj)
    {
        return Math.Abs(obj.Number - (int)obj.Symbol) > 10;
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass(80, 'K'); // 80 - 75 = 5

        if (obj) // bu yerda true/false operatorlari ishlatiladi
        {
            for (char c = 'A'; c <= 'Z'; c++)
                Console.Write(c + " "); // A B C ... Z
        }
        else
        {
            Console.WriteLine("Obyekt noto‘g‘ri.");
        }
    }
}
