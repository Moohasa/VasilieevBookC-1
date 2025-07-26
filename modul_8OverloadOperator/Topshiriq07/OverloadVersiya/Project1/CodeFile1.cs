using System;

class TextBox
{
    public string Text;

    public TextBox(string text)
    {
        Text = text;
    }

    // Obyektdan int ga o‘zgartirish — matn uzunligi
    public static explicit operator int(TextBox box)
    {
        return box.Text.Length;
    }

    // Obyektdan char ga o‘zgartirish — birinchi belgi
    public static explicit operator char(TextBox box)
    {
        return string.IsNullOrEmpty(box.Text) ? '?' : box.Text[0];
    }

    // int dan TextBox ga o‘zgartirish — "AAA..." string
    public static explicit operator TextBox(int count)
    {
        
        return new TextBox(new string('A', count));
    }
}

class Program
{
    static void Main()
    {
        TextBox box = new TextBox("Ibora");

        // Obyektdan int ga — explicit operator
        int length = (int)box;
        Console.WriteLine("Uzunlik: " + length);  // 5

        // Obyektdan char ga
        char ch = (char)box;
        Console.WriteLine("Birinchi belgi: " + ch);  // S

        // Int dan obyektga
        TextBox box2 = (TextBox)4;
        Console.WriteLine("box2.Text: " + box2.Text);  // AAAA
    }
}
