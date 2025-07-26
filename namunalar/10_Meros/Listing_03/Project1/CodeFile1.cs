using System;

// Bazaviy klass
class Alpha
{
    public int code;

    // Parametrli konstruktor
    public Alpha(int n)
    {
        code = n;
        Console.WriteLine("Alpha (bir argumentli): {0}", code);
    }

    // Default konstruktor (argumentsiz)
    public Alpha()
    {
        code = 123;
        Console.WriteLine("Alpha (argumentsiz qiymat berilgani): {0}", code);
    }
}
// Alpha'dan meros olgan klass: Bravo
class Bravo : Alpha
{
    public char symb;

    // Bravo(int, char): ikkita argument oladi va Alpha(int) konstruktorini chaqiradi
    public Bravo(int n, char s) : base(n)
    {
        symb = s;
        Console.WriteLine("Bravo (Ikki argumentli): {0} va '{1}'", code, symb);
    }

    // Bravo(int): bitta argument, Alpha(int) konstruktoriga uzatiladi
    public Bravo(int n) : base(n)
    {
        symb = 'A'; // default harf
        Console.WriteLine("Bravo (int argument bilan): {0} va '{1}'", code, symb);
    }

    // Bravo(char): bitta char argument, Alpha(321) chaqiriladi
    public Bravo(char s) : base(321)
    {
        symb = s;
        Console.WriteLine("Bravo (char argumentli): {0} va '{1}'", code, symb);
    }

    // Bravo(): default konstruktor, Alpha() chaqiriladi
    public Bravo() : base()
    {
        symb = 'O';
        Console.WriteLine("Bravo (argumentsiz): {0} va '{1}'", code, symb);
    }
}
// Dastur bajarilishi shu yerda boshlanadi
class InheritAndConstructDemo
{
    static void Main()
    {
        // Alpha klassining argumentsiz konstruktori chaqiriladi
        Alpha A1 = new Alpha();
        Console.WriteLine();

        // Alpha klassining parametrli konstruktori (100) chaqiriladi
        Alpha A2 = new Alpha(100);
        Console.WriteLine();

        // Bravo(int, char): base(n) → Alpha(200)
        Bravo B1 = new Bravo(200, 'B');
        Console.WriteLine();

        // Bravo(int): base(n) → Alpha(300), symb = 'A'
        Bravo B2 = new Bravo(300);
        Console.WriteLine();

        // Bravo(char): base(321), symb = 'C'
        Bravo B3 = new Bravo('C');
        Console.WriteLine();

        // Bravo(): base() → Alpha(), symb = 'O'
        Bravo B4 = new Bravo();
    }
}
