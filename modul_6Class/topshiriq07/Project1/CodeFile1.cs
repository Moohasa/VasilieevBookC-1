using System;
using System.Runtime.Remoting.Channels;

class MyClass
{
    private char ch;       // Simvol maydoni (private)
    private string text;   // Matn maydoni (private)

    // Simvol qiymatini o'rnatuvchi metod
    public void SetValue(char c)
    {
        ch = c;
    }

    // Matn qiymatini o'rnatuvchi metod
    public void SetValue(string s)
    {
        text = s;
    }

    // Simvol massivini o'rnatuvchi metod
    public void SetValue(char[] arr)
    {
        if (arr.Length == 1)
        {
            // Agar massivda faqat bitta element bo'lsa, simvol maydoniga o'rnatamiz
            ch = arr[0];
        }
        else
        {
            // Agar elementlar ko'p bo'lsa, massivni satrga aylantirib, text maydoniga o'rnatamiz
            text = new string(arr);
        }
    }

    // Maydonlarni konsolga chiqarish uchun yordamchi metod
    public void Display()
    {
        // char uchun standart qiymat '\0' bo'lsa, qiymat berilgan deb hisoblaymiz
        bool chIsDefault = (ch == '\0');
        // string uchun null yoki bo'sh emasligini tekshiramiz

        bool textIsNullOrEmpty = string.IsNullOrEmpty(text);
        if (!chIsDefault && !textIsNullOrEmpty)
        {
            Console.WriteLine($"Simvol: '{ch}', Matn: \"{text}\"");
        }
        else if (!chIsDefault)
        {
            Console.WriteLine($"Simvol : {ch}");
        }
        else
        {
             Console.WriteLine($"Matn  : {text}");
        }
        Console.WriteLine();
      //  Console.WriteLine($"Simvol: '{ch}', Matn: \"{text}\"");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();

        obj.SetValue('X');
        obj.Display();  // Simvol: 'X', Matn: ""

        obj.SetValue("Salom");
        obj.Display();  // Simvol: 'X', Matn: "Salom"

        obj.SetValue(new char[] { 'A' });
        obj.Display();  // Simvol: 'A', Matn: "Salom"

        obj.SetValue(new char[] { 'H', 'e', 'l', 'l', 'o' });
        obj.Display();  // Simvol: 'A', Matn: "Hello"
    }
}
