using System;

class MyClass
{
    public char ch;   // Simvol maydoni
    public int num;   // Butun son maydoni

    // Konstruktor: ikki argument (int va char)
    public MyClass(int n, char c)
    {
        num = n;
        ch = c;
        Console.WriteLine($"Konstruktor (int, char): num = {num}, ch = '{ch}'");
    }

    // Konstruktor: bitta argument (double)
    public MyClass(double d)
    {
        // Butun qism - simvol kodi
        int intPart = (int)d;

        // Kasr qismni olish, faqat o'nlik va yuzlik (ikki raqam)
        double fracPart = d - intPart;
        int fracTwoDigits = (int)(fracPart * 100); // o'nlik va yuzlik raqamlar

        ch = (char)intPart;  // Simvolni koddan olish
        num = fracTwoDigits;

        Console.WriteLine($"Konstruktor (double): ch = '{ch}' (kod {intPart}), num = {num}");
    }
}
/*
 int intPart = (int)d;

Bu yerda d — haqiqiy son (masalan, 65.1267).

(int)d — d ning butun qismini oladi, ya'ni sonning vergul oldidagi qismi.

Misol uchun, agar d = 65.1267 bo'lsa, intPart 65 ga teng bo'ladi.

Bu butun qism keyin simvolning ASCII kodi sifatida ishlatiladi.

double fracPart = d - intPart;

Bu yerda haqiqiy sonning faqat kasr qismi olinadi.

Masalan, 65.1267 - 65 = 0.1267.

fracPart endi faqat kasr qismi (verguldan keyingi qism) ni ifodalaydi.

int fracTwoDigits = (int)(fracPart * 100);

Kasr qismni o'nlik va yuzlik raqamlar sifatida olish uchun kasr qismi 100 ga ko'paytiriladi.

0.1267 * 100 = 12.67.

(int) bilan butun qismga aylantiriladi, ya'ni 12.

Demak, kasr qismning faqat o'nlik va yuzlik raqamlari olinadi, uchinchi raqam (0.0067) e'tiborga olinmaydi.

ch = (char)intPart;

Butun qism — simvol kodi sifatida qabul qilinadi.

(char)intPart orqali butun son ASCII kodiga aylantiriladi va ch maydoniga beriladi.

Masalan, 65 kodi 'A' harfiga to'g'ri keladi.

num = fracTwoDigits;

Kasr qismdan olingan ikki raqamli son num maydoniga beriladi.

Misol uchun, num = 12.

Console.WriteLine(...)

Ob’ekt yaratishda ma’lumotlar konsolga chiqariladi:

ch simvoli, uning kodi va

num butun son qiymati.

Qisqasi
double argumentdagi sonning butun qismi simvol kodi uchun,

kasr qismning faqat o'nlik va yuzlik raqamlari butun son maydon uchun olinadi.

this konstruktor parametrlari asosida ch va num maydonlarini to‘ldiradi.


 */

class Program
{
    static void Main()
    {
        // Ikkita argumentli konstruktor
        MyClass obj1 = new MyClass(12, 'A');

        // Bitta double argumentli konstruktor
        MyClass obj2 = new MyClass(65.1267);
    }
}
/*
 Birinchi konstruktor MyClass(int n, char c) — oddiy, 2 ta parametr oladi va maydonlarga qiymat beradi.

Ikkinchi konstruktor MyClass(double d) — bitta double argument oladi, undan:

Butun qismini intPart ga ajratadi, bu simvol kodi sifatida ishlatiladi.

Kasr qismini ajratib olib, faqat o‘nlik va yuzlik raqamlarini hisobga oladi (fracTwoDigits).

intPart dan simvol qiymatini yaratadi ((char)intPart).

Kasr qismini num maydoniga joylaydi.
 */