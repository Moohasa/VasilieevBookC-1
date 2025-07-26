using System;

class MyTextClass
{
    private string text; // Matn saqlanadigan maydon

    // Konstruktor, obyek yaratishda matn qabul qiladi va maydonga saqlaydi
    public MyTextClass(string initialText)
    {
        text = initialText;
    }

    // Matnga substring qo'shish metodi
    // insertText - qo'shiladigan substring
    // index - qaysi indeksdan boshlab qo'shiladi
    public void InsertSubstring(string insertText, int index)
    {
        // Indeks chegaralarini tekshirish
        if (index < 0)
            index = 0;
        if (index > text.Length)
            index = text.Length;

        // Matnni ikkiga bo'lib, o'rtasiga insertText qo'shamiz
        text = text.Substring(0, index) + insertText + text.Substring(index);
    }

    // ToString metodini qayta aniqlash
    public override string ToString()
    {
        return text;
    }
}

class Program
{
    static void Main()
    {
        MyTextClass obj = new MyTextClass("Salom dunyo");

        Console.WriteLine("Asl matn: " + obj);

        obj.InsertSubstring(", aziz", 5);

        Console.WriteLine("Qo'shilgandan keyin: " + obj);
    }
}
