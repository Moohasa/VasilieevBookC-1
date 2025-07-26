using System;

// Klass: Myclass
class Myclass
{
    // Ochiq (public) char tipidagi maydon
    public char symb;

    // Konstruktor: obyekt yaratishda simvol qiymatini oladi
    public Myclass(char s)
    {
        symb = s;
    }

    // <= operatorini overload qilish
    // Ikkita Myclass obyektini solishtiradi (char qiymatlari bo‘yicha)
    public static bool operator <=(Myclass a, Myclass b)
    {
        // Agar a.symb kichik yoki teng bo‘lsa b.symb'ga — true
        if (a.symb <= b.symb)
        {
            return true;
        }
        else
            return false;
    }

    // >= operatorini overload qilish
    // Ikkita Myclass obyektini solishtiradi
    public static bool operator >=(Myclass a, Myclass b)
    {
        // Agar a.symb katta yoki teng bo‘lsa b.symb'ga — true
        if (a.symb >= b.symb)
        {
            return true;
        }
        else
            return false;
    }
}


// Klass: Dastur kirish nuqtasi
class OverloadingCompOperatorsDemo
{
    public static void Main()
    {
        // Uchta obyekt yaratilmoqda: 'A', 'B', 'C'
        Myclass A = new Myclass('A');
        Myclass B = new Myclass('B');
        Myclass C = new Myclass('C');

        // Taqqoslash operatorlari ishlatilmoqda va natijalar chiqarilmoqda
        Console.WriteLine("A <= B natijasi: {0}", A <= B); // True ('A' < 'B')
        Console.WriteLine("A >= B natijasi: {0}", A >= B); // False
        Console.WriteLine("A <= C natijasi: {0}", A <= C); // True ('A' < 'C')
        Console.WriteLine("A >= C natijasi: {0}", A >= C); // False
    }
}
