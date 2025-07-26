using System; // Konsolga chiqarish va umumiy funksiyalar uchun kutubxona
class Alpha
{
    // Alpha klassining konstruktori
    // Obyekt yaratilganda avtomatik ishga tushadi
    public Alpha()
    {
        Console.WriteLine("Alpha klassi konstruktori: ");
    }

    // Destruktor — obyekt xotiradan o‘chirilganda chaqiriladi (GC tomonidan)
    ~Alpha()
    {
        Console.WriteLine("Alpha klassi destrukti");
    }
}
class Bravo : Alpha
{
    // Bravo konstruktori — Alpha konstruktoridan keyin chaqiriladi
    public Bravo() : base() // optional yozilgan, bo‘lmasa ham chaqiriladi
    {
        Console.WriteLine("Bravo klassi Konstruktori");
    }

    // Bravo klassining destruktori — Charlie'dan oldin, Alpha'dan keyin
    ~Bravo()
    {
        Console.WriteLine("Bravo klassi destruktori");
    }
}
class Charlie : Bravo
{
    // Charlie konstruktori — Bravo konstruktoridan keyin ishlaydi
    public Charlie() : base() // base() ixtiyoriy yozilgan
    {
        Console.WriteLine("Charlie klassi konstrutoei");
    }

    // Charlie klassining destruktori — eng birinchi bo‘lib chaqiriladi (agar GC bo‘lsa)
    ~Charlie()
    {
        Console.WriteLine("Charlie klassi destruktori");
    }
}
class InheritConstructDestructDemo
{
    static void Main()
    {
        new Charlie(); // Charlie obyektini yaratamiz (unga nom bermaymiz)
    }
}
