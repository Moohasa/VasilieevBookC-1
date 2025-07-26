using System;

class MyClass
{
    public char ch1;  // Birinchi belgini saqlovchi maydon
    public char ch2;  // Ikkinchi belgini saqlovchi maydon

    // Hech narsa qaytarmaydigan, argumentsiz metod
    public void ShowCharsInRange()
    {
        // Belgilarning ASCII kodlarini olish
        int start = Math.Min(ch1, ch2);
        int end = Math.Max(ch1, ch2);

        // Belgilar orasidagi belgilarni chiqarish (start va end ham qo'shiladi)
        for (int i = start; i <= end; i++)
        {
            Console.Write((char)i + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();

        obj.ch1 = 'A';
        obj.ch2 = 'W';

        obj.ShowCharsInRange();  // Natija: A B C D 
    }
}
