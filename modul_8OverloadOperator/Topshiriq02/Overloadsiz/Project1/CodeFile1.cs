using System;

class IntArrayBox
{
    private int[] data;

    public IntArrayBox(int size)
    {
        data = new int[size];
        // Elementlar avtomatik tarzda 0 ga teng bo‘ladi (int default qiymat)
    }

    // 1. Massivni stringga aylantirish
    public string ToText()
    {
        return string.Join(", ", data);
    }

    // 2. Oxiriga 0 qo‘shish (++ o‘rnida)
    public void AddZero()
    {
        int[] newData = new int[data.Length + 1];
        for (int i = 0; i < data.Length; i++)
            newData[i] = data[i];
        newData[newData.Length - 1] = 0; // oxiriga 0 qo‘shamiz
        data = newData;
    }

    // 3. Oxirgi elementni olib tashlash (-- o‘rnida)
    public void RemoveLast()
    {
        if (data.Length == 0) return;
        int[] newData = new int[data.Length - 1];
        for (int i = 0; i < newData.Length; i++)
            newData[i] = data[i];
        data = newData;
    }

    // 4. Ikki obyektni birlashtirish (a + b)
    public static IntArrayBox Merge(IntArrayBox a, IntArrayBox b)
    {
        IntArrayBox result = new IntArrayBox(0);
        result.data = new int[a.data.Length + b.data.Length];
        for (int i = 0; i < a.data.Length; i++)
            result.data[i] = a.data[i];
        for (int i = 0; i < b.data.Length; i++)
            result.data[a.data.Length + i] = b.data[i];
        return result;
    }

    // 5. Oxiriga int qiymat qo‘shish
    public static IntArrayBox AddToEnd(IntArrayBox box, int value)
    {
        IntArrayBox result = new IntArrayBox(box.data.Length + 1);
        for (int i = 0; i < box.data.Length; i++)
            result.data[i] = box.data[i];
        result.data[box.data.Length] = value;
        return result;
    }

    // 6. Boshiga int qiymat qo‘shish
    public static IntArrayBox AddToStart(int value, IntArrayBox box)
    {
        IntArrayBox result = new IntArrayBox(box.data.Length + 1);
        result.data[0] = value;
        for (int i = 0; i < box.data.Length; i++)
            result.data[i + 1] = box.data[i];
        return result;
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
        IntArrayBox box1 = new IntArrayBox(3);
        box1.Print(); // [0, 0, 0]

        box1.AddZero();
        box1.Print(); // [0, 0, 0, 0]

        box1.RemoveLast();
        box1.Print(); // [0, 0, 0]

        IntArrayBox box2 = new IntArrayBox(2); // [0, 0]

        IntArrayBox merged = IntArrayBox.Merge(box1, box2);
        merged.Print(); // [0, 0, 0, 0, 0]

        IntArrayBox endAdded = IntArrayBox.AddToEnd(box1, 9);
        endAdded.Print(); // [0, 0, 0, 9]

        IntArrayBox startAdded = IntArrayBox.AddToStart(7, box1);
        startAdded.Print(); // [7, 0, 0, 0]
    }
}
