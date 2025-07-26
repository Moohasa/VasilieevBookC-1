using System;
class Alpha
{
    public int num;
    public Alpha(int n)
    {
        num = n;
    }
    public virtual int this[int index]
    {
      get
        {
           string s = num.ToString();
            return int.Parse(s[index].ToString());
        }
    }
}
class MyClass:Alpha
{
    public int extra;
    public MyClass(int n, int m) : base(n)
    {
        extra = m;
    } 
    public  int this[int field, int digit]
    {
        get
        {
            int value = 0;

            if (field == 0) value = num;    
            else if (field == 1) value = extra; 

            string s = value.ToString();             
            return int.Parse(s[digit].ToString()); 
        }

    }
    public override int this[int index]
    {
        get
        {
            int sum = num + extra;
            string s = sum.ToString();

            if (index >= 0 && index < s.Length)
                return int.Parse(s[index].ToString());
            else
                return -1;
        }
    }
}
class Program
{
    static void Main()
    {
        // Alpha klass obyektini yaratamiz
        Alpha a = new Alpha(1234);
        Console.WriteLine("Alpha klassidagi raqamlar:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}"); // 1, 2, 3, 4 bo'lishi kerak
        }

        Console.WriteLine();

        // MyClass obyektini yaratamiz
        MyClass b = new MyClass(5678, 90);

        Console.WriteLine("MyClass (ikki indeksli) indeksatori:");
        Console.WriteLine($"b[0, 1] = {b[0, 1]}"); // num: 5678 → 2-raqam: 6
        Console.WriteLine($"b[1, 0] = {b[1, 0]}"); // extra: 90 → 1-raqam: 9

        Console.WriteLine();

        Console.WriteLine("MyClass (override qilingan b[i]) → num + extra asosida:");
        int sum = b.num + b.extra; // 5678 + 90 = 5768
        for (int i = 0; i < sum.ToString().Length; i++)
        {
            Console.WriteLine($"b[{i}] = {b[i]}"); // 5, 7, 6, 8 bo'lishi kerak
        }
    }
}
  