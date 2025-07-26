using System;

class MyClass
{
    Random rnd = new Random(); // Tasodifiy sonlar yaratish uchun
    public int[,] nums;        // Ikki o‘lchamli butun sonli massiv

    // Konstruktor: bo‘sh massiv yaratadi
    public MyClass(int rows, int cols)
    {
        nums = new int[rows, cols];
    }

    // Konstruktor: mavjud massivni qabul qiladi
    public MyClass(int[,] n)
    {
        nums = n;
    }
    public int this[int rows, int cols]
    {
        get { return nums[rows, cols]; }     // aniq indeksdagi elementni o‘qish
        set { nums[rows, cols] = value; }    // aniq indeksdagi elementga qiymat yozish
    }
    public int this[int rows]
    {
        get
        {
            // Qatorning eng katta qiymatini qaytarish
            int max = nums[rows, 0];
            for (int i = 1; i < nums.GetLength(1); i++)
            {
                if (nums[rows, i] > max)
                    max = nums[rows, i];
            }
            return max;
        }

        set
        {
            // Qatorning eng katta elementini value bilan almashtirish
            int max = nums[rows, 0];
            int maxIndex = 0;

            for (int i = 1; i < nums.GetLength(1); i++)
            {
                if (nums[rows, i] > max)
                {
                    max = nums[rows, i];
                    maxIndex = i;
                }
            }

            nums[rows, maxIndex] = value;
        }
    }
    public int[,] Nums(int rows, int cols)
    {
        nums = new int[rows, cols];

        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = rnd.Next(0, 9); // 0 dan 8 gacha sonlar
            }
        }

        return nums;
    }
    public void PrintNums()
    {
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write(nums[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Foydalanuvchidan qator va ustun o‘lchamlarini olish
        Console.WriteLine("Massiv o‘lchamlarini kiriting, qatorini va ustunini");
        int qator = Convert.ToInt32(Console.ReadLine());
        int ustun = Convert.ToInt32(Console.ReadLine());

        // Ob'ekt yaratish va massivni to‘ldirish
        MyClass obj = new MyClass(qator, ustun);
        obj.Nums(qator, ustun);
        obj.PrintNums();

        // Har bir qatorning maksimal qiymatini chiqarish
        for (int i = 0; i < obj.nums.GetLength(0); i++)
        {
            Console.WriteLine("Qator {0} max:  {1}", i, obj[i]);
        }

        // 0-qatordagi eng katta qiymatni 10 bilan almashtirish
        obj[0] = 10;
        obj.PrintNums();

        Console.WriteLine("Row 0 max (after set): " + obj[0]);
        Console.WriteLine("Row 0, 1 element (after set): " + obj[0, 1]); // Bu aniq 10 emas, chunki 10 qaysi ustunga yozilganini bilmaymiz.
    }
}
