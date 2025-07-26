using System;

class IntArrayBox
{
    private int[] data;

    public IntArrayBox(int size)
    {
        data = new int[size]; // avtomatik tarzda 0 bilan to‘ladi
    }

    // Obyektdan string ga — elementlar vergul bilan
    public static explicit operator string(IntArrayBox box)
    {
        return string.Join(", ", box.data);
    }

    // Obyektdan int ga — elementlar yig‘indisi
    public static explicit operator int(IntArrayBox box)
    {
        int sum = 0;
        foreach (int x in box.data)
            sum += x;
        return sum;
    }

    // int dan obyektga — berilgan o‘lchamli, 0-lar bilan to‘lgan massiv
    public static explicit operator IntArrayBox(int size)
    {
        return new IntArrayBox(size);
    }

    // Qo‘shimcha: elementlarni o‘zgartirish (masalan: test uchun)
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
        // int → obyekt
        IntArrayBox box = (IntArrayBox)5;  // 5 ta 0

        box.Set(0, 10);
        box.Set(1, 20);
        box.Set(2, 30);
        box.Set(3, 40);
        box.Print(); // [10, 20, 30, 40 0]

        // Obyekt → string
        string asText = (string)box;
        Console.WriteLine("String holatda: " + asText); // "10, 20, 30, 40, 0"

        // Obyekt → int (yig‘indi)
        int total = (int)box;
        Console.WriteLine("Yig‘indi: " + total); // 100
    }
}
