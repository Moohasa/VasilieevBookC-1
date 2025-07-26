using System;

// Bazaviy klass: Alpha
class Alpha
{
    // Himoyalangan butun sonlar massivi
    protected int[] nums;

    // Konstruktor: uzunligi n bo‘lgan butun sonlar massivi yaratadi
    public Alpha(int n)
    {
        nums = new int[n];
    }

    // Virtual property: nums massivining uzunligini qaytaradi
    public virtual int length
    {
        get { return nums.Length; }
    }

    // Indeksator: nums massiviga murojaat qilish (o‘qish/yozish)
    public int this[int i]
    {
        get { return nums[i]; }
        set { nums[i] = value; }
    }
}

// Hosila klass: Beta — Alpha dan meros olgan
class Beta : Alpha
{
    // Himoyalangan belgilar (char) massivi
    protected char[] symbs;

    // Konstruktor: ikkita massiv — biri butun sonlar uchun (nums), biri belgilar uchun (symbs)
    public Beta(int n, int c) : base(n)
    {
        symbs = new char[c]; // to‘g‘ri uzunlikdagi char massivi
    }

    // Yangi property: ikkita o‘lchamli butun sonlar massivi qaytaradi
    // 1-element: nums.Length, 2-element: symbs.Length
    public new int[] Length
    {
        get { return new int[] { nums.Length, symbs.Length }; }
    }

    // Belgili indeksator: char qiymatni indeks sifatida ishlatadi
    // Masalan: 'a' = 0, 'b' = 1, ...
    public char this[char c]
    {
        get
        {
            int index = c - 'a'; // belgining indeksga aylanishi
            return symbs[index];
        }
        set
        {
            int index = c - 'a';
            symbs[index] = value;
        }
    }
}

// Asosiy dastur klassi
class Program
{
    static void Main()
    {
        // Alpha klassidan obyekt yaratamiz va son qo‘yamiz
        Alpha a = new Alpha(5); // 5 ta butun sonli massiv
        a[0] = 10; // 0-indeksga qiymat

        // Beta klassidan obyekt: 3 ta son, 4 ta belgi
        Beta b = new Beta(3, 4);
        b[1] = 99;         // 1-indeksga 99 sonini berish
        b['b'] = 'X';      // 'b' belgisi — indeks 1 → 'X' qo‘yiladi

        // Natijalarni chiqarish
        Console.WriteLine(b['b']);       // 'X'
        Console.WriteLine(b[1]);         // 99
        Console.WriteLine(b.Length[0]);  // nums.Length = 3
        Console.WriteLine(b.Length[1]);  // symbs.Length = 4
    }
}
