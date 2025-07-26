using System;

class IntArrayBox
{
    private int[] data;

    // Konstruktor — massiv o'lchamini oladi, elementlari avtomatik 0 ga teng bo'ladi
    public IntArrayBox(int size)
    {
        data = new int[size];
    }

    // ToString o'rniga operator ~ overload qilinadi
    // Massiv elementlarini vergul bilan ajratilgan stringga aylantiradi
    public static string operator ~(IntArrayBox box)
    {
        return string.Join(", ", box.data);
    }

    // Operator ++ massivga oxiriga 0 qo‘shadi
    public static IntArrayBox operator ++(IntArrayBox box)
    {
        int[] newData = new int[box.data.Length + 1];
        for (int i = 0; i < box.data.Length; i++)
            newData[i] = box.data[i];
        newData[newData.Length - 1] = 0;
        box.data = newData;
        return box;
    }

    // Operator -- massivdan oxirgi elementni olib tashlaydi
    public static IntArrayBox operator --(IntArrayBox box)
    {
        if (box.data.Length == 0)
            return box;
        int[] newData = new int[box.data.Length - 1];
        for (int i = 0; i < newData.Length; i++)
            newData[i] = box.data[i];
        box.data = newData;
        return box;
    }

    // Operator + (IntArrayBox + IntArrayBox) — ikkita massivni birlashtiradi
    public static IntArrayBox operator +(IntArrayBox a, IntArrayBox b)
    {
        IntArrayBox result = new IntArrayBox(a.data.Length + b.data.Length);
        for (int i = 0; i < a.data.Length; i++)
            result.data[i] = a.data[i];
        for (int i = 0; i < b.data.Length; i++)
            result.data[a.data.Length + i] = b.data[i];
        return result;
    }

    // Operator + (IntArrayBox + int) — massiv oxiriga yangi element qo'shadi
    public static IntArrayBox operator +(IntArrayBox box, int value)
    {
        IntArrayBox result = new IntArrayBox(box.data.Length + 1);
        for (int i = 0; i < box.data.Length; i++)
            result.data[i] = box.data[i];
        result.data[box.data.Length] = value;
        return result;
    }

    // Operator + (int + IntArrayBox) — massiv boshiga yangi element qo'shadi
    public static IntArrayBox operator +(int value, IntArrayBox box)
    {
        IntArrayBox result = new IntArrayBox(box.data.Length + 1);
        result.data[0] = value;
        for (int i = 0; i < box.data.Length; i++)
            result.data[i + 1] = box.data[i];
        return result;
    }

    // Massivni ekranga chiqarish uchun yordamchi metod
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
        Console.WriteLine(~box1);   // "0, 0, 0"

        box1++;     // oxiriga 0 qo'shildi
        box1.Print();  // [0, 0, 0, 0]

        box1--;     // oxirgi element olib tashlandi
        box1.Print();  // [0, 0, 0]

        IntArrayBox box2 = new IntArrayBox(2);
        Console.WriteLine(~box2);   // "0, 0"

        IntArrayBox merged = box1 + box2;  // ikkita massiv birlashtirildi
        merged.Print();  // [0, 0, 0, 0, 0]

        IntArrayBox endAdded = box1 + 99;  // oxiriga 99 qo'shildi
        endAdded.Print();  // [0, 0, 0, 99]

        IntArrayBox startAdded = 42 + box1; // boshiga 42 qo'shildi
        startAdded.Print();  // [42, 0, 0, 0]
    }
}
