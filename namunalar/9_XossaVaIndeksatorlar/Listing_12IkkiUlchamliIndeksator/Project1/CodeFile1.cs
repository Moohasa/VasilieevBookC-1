using System;

class MyClass
{
    // Ikki o‘lchamli char turidagi yopiq (private) massiv
    private char[,] symbs;

    // Konstruktor: massiv o‘lchamini olib, uni 'O' belgisi bilan to‘ldiradi
    public MyClass(int a, int b)
    {
        symbs = new char[a, b]; // a - qatorlar soni, b - ustunlar soni

        for (int i = 0; i < symbs.GetLength(0); i++)         // 0 - qatorlar soni
        {
            for (int j = 0; j < symbs.GetLength(1); j++)     // 1 - ustunlar soni
            {
                symbs[i, j] = 'O'; // Har bir katakka 'O' belgisini yozamiz
            }
        }
    }

    // Massivdagi barcha qiymatlarni chiroyli chiqarish uchun metod
    public void print()
    {
        Console.WriteLine("Ikki o'lchamli massiv:");
        for (int i = 0; i < symbs.GetLength(0); ++i)         // Har bir qator
        {
            for (int j = 0; j < symbs.GetLength(1); ++j)     // Har bir ustun
            {
                Console.Write(symbs[i, j] + "  "); // Belgilarni chiqarish
            }
            Console.WriteLine(); // Har bir qatordan keyin yangi qator
        }
    }

    // Ikki o‘lchovli indeksator: obj[i, j] shaklida foydalanish imkonini beradi
    public char this[int i, int j]
    {
        get
        {
            return symbs[i, j]; // Massivdan qiymat o‘qish
        }
        set
        {
            symbs[i, j] = value; // Massivga qiymat yozish
        }
    }
}
class TwoDimIndexerDemo
{
    static void Main()
    {
        // 2 qator, 3 ustunli massiv yaratiladi ('O' belgilariga to‘ldirilgan holda)
        MyClass obj = new MyClass(2, 3);

        obj.print(); // Dastlabki holatini chiqaramiz (hammasi 'O')

        obj[0, 0] = 'A'; // 1-qator, 1-ustunga 'A' belgisi qo‘yiladi
        obj[1, 2] = 'Z'; // 2-qator, 3-ustunga 'Z' belgisi qo‘yiladi

        obj.print(); // Yangilangan massivni qayta chiqaramiz

        Console.WriteLine("Tekshiruv");

        // Belgilarning joylashuvini tekshiramiz
        Console.WriteLine("obj[0,0]={0}", obj[0, 0]); // 'A'
        Console.WriteLine("obj[1,1]={0}", obj[1, 1]); // 'O' (o‘zgartirilmagan)
        Console.WriteLine("obj[1,2]={0}", obj[1, 2]); // 'Z'
    }
}
