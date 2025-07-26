using System;

// Klass: MyClass - berilgan butun sonning bitlari bilan ishlaydi
class MyClass
{
    private int number; // Ichki butun son

    // Konstruktor - obyekt yaratilganda sonni qabul qiladi
    public MyClass(int n)
    {
        number = n;
    }

    // Indeksator - faqat get (o‘qish)
    // number ning binary (ikkilik) ko‘rinishidagi 'index'-bit qiymatini qaytaradi
    public int this[int index]
    {
        get
        {
            return (number >> index) & 1;
            // Masalan, index = 2 bo‘lsa:
            // number >> 2 → bitlarni 2 ta o‘ngga siljitadi
            // & 1 → oxirgi (eng o‘ngdagi) bitni ajratadi (0 yoki 1)
        }
    }
}

// Asosiy dastur
class ToBitNum
{
    static void Main()
    {
        // Foydalanuvchidan son qabul qilinadi
        MyClass obj = new MyClass(Convert.ToInt32(Console.ReadLine()));

        // Diqqat: sikl faqat i = 7 uchun ishlaydi, chunki i >= 7 bo‘lishi kerak
        // Bu sikl faqat bitta bitni (7-bit) chiqaradi
        for (int i = 7; i >= 0; i--) // ➤ i >= 0 emas, shuning uchun faqat bir martalik ishlaydi
        {
            Console.Write(obj[i]);
        }

        Console.WriteLine(); // Yangi qatordan chiqish
    }
}
