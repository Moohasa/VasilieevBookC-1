using System;
class Task4_1
{
    static void Main()
    {
        int a, b = 2;
        a = Int32.Parse(Console.ReadLine());
        int[] nums = new int [a];
        Console.WriteLine();

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = b;
            b = b + 5;
        }
        for (int i = 0;i < nums.Length;i++)
        {
            Console.WriteLine((i+1) + " " + nums[i]);
        }
    }
}