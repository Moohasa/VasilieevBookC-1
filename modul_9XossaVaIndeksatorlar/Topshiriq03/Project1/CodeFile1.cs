using System;

class MyClass
{
    private int[] array;

    // Konstruktor: massivni saqlaydi
    public MyClass(int[] arr)
    {
        array = arr;
    }

    // Read-only property: massiv elementlari yig'indisini qaytaradi
    public int Sum
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
            // arraydagi elementlarni yig'indisini hisoblab qaytarish kerak
        }
    }
}
class SumArray
{
    static void Main()
    {
        int []arr = {1,2,3,4,5,6,7,8,9,10}; 
        MyClass obj =new  MyClass(arr);
        Console.WriteLine(obj.Sum);
    }
}
