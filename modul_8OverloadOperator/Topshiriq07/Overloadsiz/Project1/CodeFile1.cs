using System;

class TextBox
{
    public string Text;

    public TextBox(string text)
    {
        Text = text;
    }

    public int ToLength()
    {
        return Text.Length;
    }

    public char FirstChar()
    {
        return string.IsNullOrEmpty(Text) ? '?' : Text[0];
    }

    public static TextBox FromInt(int count)
    {
        return new TextBox(new string('A', count));
    }
}

class Program
{
    static void Main()
    {
        TextBox box = new TextBox("Hello");

        int length = box.ToLength();     // 5
        char ch = box.FirstChar();       // 'H'

        TextBox box2 = TextBox.FromInt(4);  // "AAAA"

        Console.WriteLine(length); // 5
        Console.WriteLine(ch);     // H
        Console.WriteLine(box2.Text); // AAAA
    }
}
