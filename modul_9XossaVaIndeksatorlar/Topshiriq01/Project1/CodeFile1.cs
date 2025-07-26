using System;

class MyClass
{
    private char _symbol; // Haqiqiy saqlanuvchi o‘zgaruvchi

    public char Symbol  // Public xususiyat (property)
    {
        get { return _symbol;  }
        set
        {
            if (value >= 'A' && value <= 'Z')
            {
                _symbol = value; // ✅ Bu to‘g‘ri: real o‘zgaruvchiga yozayapti
                
            }
            else
            {
                Console.WriteLine("Xatolik: Belgilar mos emas. Iltimos, A dan Z gacha bo‘lgan belgi kiriting.");
            }
        }
    }

    public MyClass(char s)
    {
        Symbol = s; // ✅ Property orqali set ishlayapti
        Show();
    }

    public void Show()
    {
        Console.WriteLine($"Tanlangan belgi: {_symbol}");
    }
}

class MainDemo
{
    static void Main()
    {
        Console.WriteLine("Belgini kiriting");
        MyClass obj=new MyClass(Convert.ToChar(Console.ReadLine()));
    }
}