using System;
class MinElementDemo
{
    static void Main(string[] args)
    {
        int size, min = int.MaxValue;
        Random r = new Random();

        Console.WriteLine("Введите размер массива");
        size = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[size];

        //Заполнение и отображение массива:
        for (int k = 0; k < nums.Length; k++)
        {
            nums[k] = r.Next(1, 101);
            Console.Write(nums[k] + " ");
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
                min = nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == min)
                Console.WriteLine("Минимальный элемент: {0}, Позиция: {1}", nums[i], i + 1);
        }

    }
}