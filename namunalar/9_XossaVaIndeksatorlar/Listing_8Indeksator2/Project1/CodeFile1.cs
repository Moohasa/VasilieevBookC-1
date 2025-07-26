using System;

class MyClass
{
    private int code; // 🔸 Harfni ASCII kodi sifatida saqlaydi

    public MyClass(char s)
    {
        code = s; // 🔸 Belgining butun (ASCII) kodi olinadi va saqlanadi
    }

    // 🔸 Indexator: obj[k] tarzida foydalanish imkonini beradi
    public char this[int k]
    {
        get
        {
            // 🔸 code (masalan 'A'=65) ustiga k qo‘shiladi va yangi belgi olinadi
            return (char)(code + k); // Masalan: code = 65; k=3 → (char)(68) → 'D'
        }
        set
        {
            // 🔸 Orqaga hisoblash: berilgan belgi va indeks asosida asl code'ni tiklaydi
            // Masalan: value = 'Q' (81), k=5 → code = 81 - 5 = 76 → 'L'
            code = value - k;
        }
    }
}
class MoreIndexerDemo
{
    static void Main()
    {
        MyClass obj = new MyClass('A'); // 🔸 code = 65 ('A')

        // 🔸 obj[0] = 'A', obj[1] = 'B', obj[2] = 'C', ...
        for (int i = 0; i < 10; i++)
        {
            Console.Write(obj[i] + "  ");
        }
        Console.WriteLine();
        obj[5] = 'Q';
        for (int i = 0; i < 10; i++)
        {
            Console.Write(obj[i] + "  ");
        }
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            Console.Write(obj[-i] + "  ");
        }
        Console.WriteLine();
    }
}