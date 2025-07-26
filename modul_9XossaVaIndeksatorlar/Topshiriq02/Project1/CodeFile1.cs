using System;
class MyClass
{
    private int[] _nums;
    private int currentIndex;

    public MyClass(int[] n)
    {
        _nums = n;

    }

    public int Value
    {
        get
        {
            int val = _nums[currentIndex];
            currentIndex = (currentIndex +1)%_nums.Length;
            return val;
               
        }
        set
        {
            _nums[currentIndex] = value;
            currentIndex = (currentIndex +1)%_nums.Length;
        }

    }
}

class Demo
{
    static void Main()
    {
        MyClass obj = new MyClass(new int[] { 10, 20, 30 });

        Console.WriteLine(obj.Value); // 10
        Console.WriteLine(obj.Value); // 20
        obj.Value = 99;               // 30 ni 99 ga o'zgartirdi
        Console.WriteLine(obj.Value); // 10
        Console.WriteLine(obj.Value); // 20
        Console.WriteLine(obj.Value); // 99
    }
}
