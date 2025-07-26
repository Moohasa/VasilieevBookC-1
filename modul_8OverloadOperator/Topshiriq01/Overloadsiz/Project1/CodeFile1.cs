using System;

class CharBox
{
    public char Symbol;

    public CharBox(char symbol)
    {
        Symbol = symbol;
    }

    // 1. Inkremеnt – navbatdagi belgiga o‘tadi
    public void Increment()
    {
        Symbol = (char)(Symbol + 1);
    }

    // 2. Dekrement – oldingi belgiga o‘tadi
    public void Decrement()
    {
        Symbol = (char)(Symbol - 1);
    }

    // 3. Yig‘ish – int bilan
    public CharBox Add(int number)
    {
        return new CharBox((char)(Symbol + number));
    }

    // 4. Ayirish – boshqa CharBox bilan
    public int Subtract(CharBox other)
    {
        return this.Symbol - other.Symbol;
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
        Console.WriteLine("Boshlang'ich: " + ch1); // A

        ch1.Increment();
        Console.WriteLine("Increment: " + ch1); // B

        ch1.Decrement();
        Console.WriteLine("Decrement: " + ch1); // A

        CharBox ch2 = ch1.Add(3);
        Console.WriteLine("Add 3: " + ch2); // D

        int diff = ch2.Subtract(ch1);
        Console.WriteLine("Difference: " + diff); // D - A = 3
    }
}
