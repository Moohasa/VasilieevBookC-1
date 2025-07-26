using System;

class MyClass
{
    private int[] data;     // Ichki massiv
    private int lower;      // Pastki indeks

    // Indeksator
    public int this[int index]
    {
        get
        {
            // Agar noto‘g‘ri indeks bo‘lsa, -1 qaytariladi
            if (index < lower || index >= lower + data.Length)
                return -1;

            return data[index - lower];
        }
        set
        {
            // Agar noto‘g‘ri indeks bo‘lsa, hech nima qilinmaydi
            if (index < lower || index >= lower + data.Length)
                return;

            data[index - lower] = value;
        }
    }

    // Konstruktor
    public MyClass(int lower, int upper)
    {
        data = new int[upper - lower + 1];
        this.lower = lower;
    }
}
class MainDemo
{
    static void Main()
    {
        MyClass obj = new MyClass(5, 9);
        obj[4] = 40;
        obj[5] = 50;
        obj[6] = 60;
        obj[9] = 90;

        Console.WriteLine(obj[4]); //-1
        Console.WriteLine(obj[5]); // 50
        Console.WriteLine(obj[6]); // 60
        Console.WriteLine(obj[9]); // 90
        Console.WriteLine(obj[10]); // -1 (xatolik emas, noto‘g‘ri indeks)
    }
}
