using System;

class Program
{
    // Statik metod, params yordamida ixtiyoriy sonli char argumentlar qabul qiladi
    public static string AppendChars(string text, params char[] chars)
    {
        // Boshlang'ich matndan StringBuilder yoki string operatsiyalar bilan yangi string hosil qilamiz
        string result = text;

        // Har bir char elementni natijaga qo'shamiz
        foreach (char c in chars)
        {
            result += c;  // Har bir belgi oxiriga qo'shiladi
        }

        return result; // Yangi hosil bo'lgan string qaytariladi
    }

    static void Main()
    {
        Console.Write("Matn kiriting: ");
        string inputText = Console.ReadLine();

        // Masalan, qo'shiladigan belgilar '!', '?', '*'
        string newText = AppendChars(inputText, '!', '?', '*');

        Console.WriteLine("Natija: " + newText);
    }
}
