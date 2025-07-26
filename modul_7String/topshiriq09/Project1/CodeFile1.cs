using System;

class TextSplitter
{
    private string text;  // Matn maydoni
    private char delimiter;  // Ajratuvchi belgi

    // Konstruktor: matn va ajratuvchi belgi beriladi
    public TextSplitter(string text, char delimiter)
    {
        this.text = text;
        this.delimiter = delimiter;
    }

    // Matnni delimiter bo'yicha bo'lib, string massivini qaytaruvchi metod
    public string[] SplitText()
    {
        // Belgiga qarab bo'linadi
        return text.Split(delimiter);
    }

    // ToString metodini qayta aniqlash
    public override string ToString()
    {
        // Bo'lingan substringlarni olish
        string[] parts = SplitText();

        // Matn va delimiterni chiqarish
        string result = $"Matn: \"{text}\"\nDelimiter: '{delimiter}'\nBo'lingan qisimlar:\n";

        // Har bir bo'lakni alohida qatorga yozamiz
        for (int i = 0; i < parts.Length; i++)
        {
            result += $"  [{i + 1}] \"{parts[i]}\"\n";
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        TextSplitter obj = new TextSplitter("Salom, dunyo, qanday, ishlar?", ',');

        Console.WriteLine(obj);
    }
}
