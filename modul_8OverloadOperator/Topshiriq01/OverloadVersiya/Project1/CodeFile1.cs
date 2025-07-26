using System;

class CharBox
{
    public char Symbol;

    public CharBox(char symbol)
    {
        Symbol = symbol;
    }

    // ++ operatori: navbatdagi belgiga o‘tadi
    public static CharBox operator ++(CharBox c)
    {
        c.Symbol = (char)(c.Symbol + 1); // Keyingi koddagi belgini olamiz
        return c; // Ob'ektning o'zini qaytaramiz (referens)
    }

    // -- operatori: oldingi belgiga o‘tadi
    public static CharBox operator --(CharBox c)
    {
        c.Symbol = (char)(c.Symbol - 1);
        return c;
    }

    // + operatori: CharBox + int
    public static CharBox operator +(CharBox c, int n)
    {
        return new CharBox((char)(c.Symbol + n));
    }

    // + operatori: int + CharBox (o‘rnatilgan simmetriklik)
    public static CharBox operator +(int n, CharBox c)
    {
        return new CharBox((char)(c.Symbol + n));
    }

    // - operatori: CharBox - CharBox
    public static int operator -(CharBox a, CharBox b)
    {
        return a.Symbol - b.Symbol; // Kodlar orasidagi farq (int)
    }

    public override string ToString()
    {
        return Symbol.ToString();
    }
}

class Program
{
    static void Main()
    {
        CharBox ch1 = new CharBox('A');
        Console.WriteLine("Boshlanish: " + ch1); // A

        ++ch1; // Inkremеnt
        Console.WriteLine("++ch1: " + ch1); // B

        --ch1; // Dekrement
        Console.WriteLine("--ch1: " + ch1); // A

        CharBox ch2 = ch1 + 2; // A + 2 → C
        Console.WriteLine("ch1 + 2: " + ch2); // C

        CharBox ch3 = 3 + ch1; // 3 + A → D
        Console.WriteLine("3 + ch1: " + ch3); // D

        int diff = ch3 - ch1; // D - A → 3
        Console.WriteLine("ch3 - ch1: " + diff); // 3
    }
}
