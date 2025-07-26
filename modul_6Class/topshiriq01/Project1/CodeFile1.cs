using System;

class MyClass
{
    private char symbol;  // yopiq maydon

    // 1. Qiymat berish uchun metod
    public void SetSymbol(char ch)
    {
        symbol = ch;
    }

    // 2. Kodni qaytaruvchi metod
    public int GetSymbolCode()
    {
        return (int)symbol;  // char ni int ga o‘zgartiramiz
    }

    // 3. Symbol va uning kodini konsolga chiqaruvchi metod
    public void PrintSymbolAndCode()
    {
        Console.WriteLine($"Simvol: '{symbol}', kodi: {GetSymbolCode()}");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();

        obj.SetSymbol('A');  // maydonga 'A' ni qo'yamiz

        Console.WriteLine("Simvol kodi: " + obj.GetSymbolCode());

        obj.PrintSymbolAndCode();
    }
}
