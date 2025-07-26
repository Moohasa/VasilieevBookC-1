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

    // Obyekt "true" yoki "false" ekanligini qaytaruvchi metod
    public bool IsValid()
    {
        int diff = Math.Abs(Number - (int)Symbol);
        return diff <= 10;
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass(80, 'K'); // 'K' = 75, |80 - 75| = 5

        if (obj.IsValid())
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
