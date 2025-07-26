using System;
using System.Runtime.CompilerServices;

// Klass: matnli massiv (string[]) bilan ishlaydi
class MyClass
{
    private string[] txt; // Matnli massiv

    // Konstruktor: massiv hajmini oladi
    public MyClass(int size)
    {
        txt = new string[size]; // Massiv ajratiladi
    }

    // Bir o‘lchamli indeksator:
    // obj[i] ko‘rinishida matnni olish yoki o‘zgartirish imkonini beradi
    public string this[int i]
    {
        get
        {
            // Ciklik indeks: i massiv chegarasidan oshsa, aylantiradi
            return txt[i % txt.Length];
        }
        set
        {
            // Yangi qiymatni massivga yozish (cyclic)
            txt[i % txt.Length] = (string)value;
        }
    }

    // Ikki o‘lchamli indeksator:
    // obj[i, j] — i-chi satrdan j-chi belgini olish
    public char this[int i, int j]
    {
        get
        {
            // Har ikki indeksni aylantirib, element va belgi olinadi
            return txt[i % txt.Length][j % txt[i].Length];
        }
    }
}

class Program
{
    static void Main()
    {
        // MyClass obyektini 2 ta satrli qilib yaratamiz
        MyClass obj = new MyClass(2);

        // 0-chi va 1-chi elementlarga matn beriladi
        obj[0] = "Salom";
        obj[1] = "Dunyo";

        // To‘liq matnlarni chiqarish
        Console.WriteLine(obj[0] + " " + obj[1]);

        // Belgilar bo‘yicha chiqarish:
        // "" bosh string yordamida char'lar string sifatida birikadi
        Console.WriteLine("" + obj[0, 0] + obj[0, 1] + obj[0, 2] + obj[0, 3] + obj[0, 4] +
            "  " + obj[1, 0] + obj[1, 1] + obj[1, 2] + obj[1, 3] + obj[1, 4]);
    }
}
