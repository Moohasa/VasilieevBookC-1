using System;
using System.Runtime.CompilerServices;

// MyClass - bu sinf ichida bitta int maydon (code) mavjud bo‘lib,
// indexator orqali 2 ta string, 2 ta indeks asosida qiymat o‘qiladi yoki yoziladi.
class MyClass
{
    private int code; // Ichki maydon: qiymatlarni hisoblashda ishtirok etadi

    // Konstruktor: code ga boshlang‘ich qiymat beradi
    public MyClass(int n)
    {
        code = n;
    }

    // Obyektni stringga aylantirganda chiqadigan matn (ToString)
    public override string ToString()
    {
        return "code obyekt maydoni:  " + code;
    }

    // Indexator: 4 ta parametr oladi — 2 ta string va ularning indekslari
    public char this[string a, int i, string b, int j]
    {
        get
        {
            // Belgilarni chiqaradi: (a[i] - b[j] + code) → char sifatida qaytariladi
            return (char)(a[i] - b[j] + code);
        }
        set
        {
            // Belgilar asosida code qiymatini yangilaydi
            // value = a[i] - b[j] + code → code = value - (a[i] - b[j])
            code = value - (a[i] - b[j]);
        }
    }
}

// Demo klass - dastur shu yerda boshlanadi
class MultiDimIndexerDemo
{
    static void Main()
    {
        // 'A' belgisi ASCII qiymatida int sifatida uzatiladi (65)
        MyClass obj = new MyClass('A');
        Console.WriteLine(obj); // code = 65

        string a = "Alpha", b = "Bravo";
        int i = 2, j = 4;

        // a[2] = 'p' (ASCII: 112), b[4] = 'o' (ASCII: 111)
        // get: (char)(112 - 111 + 65) = (char)66 = 'B'
        Console.WriteLine("obj [\"{0}\",{1},\"{2}\",{3}] = {4}", a, i, b, j, obj[a, i, b, j]);

        // set: value = 'F' (ASCII: 70), a[i] = 'p' (112), b[j] = 'o' (111)
        // code = 70 - (112 - 111) = 70 - 1 = 69
        obj[a, i, b, j] = 'F';

        Console.WriteLine(obj); // code = 69

        // get: (char)(112 - 111 + 69) = (char)70 = 'F'
        Console.WriteLine("obj [\"{0}\",{1},\"{2}\",{3}] = {4}", a, i, b, j, obj[a, i, b, j]);

        // Yangi qiymatlar bilan chaqirilmoqda:
        a = "Charlie"; // a[1] = 'h' (104), b[2] = 'a' (97)
        i = 1;
        j = 2;
        // get: (char)(104 - 97 + 69) = (char)(76) = 'L'
        Console.WriteLine("obj [\"{0}\",{1},\"{2}\",{3}] = {4}", a, i, b, j, obj[a, i, b, j]);
    }
}
