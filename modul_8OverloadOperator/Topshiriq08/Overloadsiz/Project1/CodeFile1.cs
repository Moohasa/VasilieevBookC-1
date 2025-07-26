using System;

class IntArrayBox
{
    private int[] data;

    public IntArrayBox(int size)
    {
        data = new int[size]; // avtomatik nollar bilan to‘ladi
    }

    public string ToText()
    {
        return string.Join(", ", data);
    }

    public int Sum()
    {
        int sum = 0;
        foreach (int x in data)
            sum += x;
        return sum;
    }

    public static IntArrayBox FromInt(int size)
    {
        return new IntArrayBox(size);
    }

    public void Set(int index, int value)
    {
        if (index >= 0 && index < data.Length)
            data[index] = value;
    }

    public void Print()
    {
        Console.WriteLine("[" + string.Join(", ", data) + "]");
    }
}

class Program
{
    static void Main()
    {
        // 1. int → obyekt (massiv o‘lchami 5)
        IntArrayBox box = IntArrayBox.FromInt(5);  // [0, 0, 0, 0, 0]

        // 2. Elementlarga qiymat beramiz
        box.Set(0, 10);
        box.Set(1, 20);
        box.Set(2, 30);

        // 3. Massivni stringga aylantirish
        string asText = box.ToText();
        Console.WriteLine("Matn: " + asText);  // "10, 20, 30, 0, 0"

        // 4. Massiv yig'indisi
        int total = box.Sum();
        Console.WriteLine("Yig'indi: " + total);  // 60

        // 5. Ekranga chiqarish
        box.Print();  // [10, 20, 30, 0, 0]
    }
}
