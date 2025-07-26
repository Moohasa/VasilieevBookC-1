using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nechta mos son topilsin (n): ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            int i = 1;

            Console.WriteLine("Mos keluvchi sonlar:");

            do
            {
                if (i % 5 == 2 || i % 3 == 1)
                {
                    Console.Write(i + " ");
                    sum += i;
                    count++;
                }
                i++;
            } while (count < n);

            Console.WriteLine($"\nYig'indisi: {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Xato: butun son kiriting.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Xatolik: " + ex.Message);
        }
    }
}
/*i % 5 == 2 → bu sonni 5 ga bo‘lganda qoldiq 2 bo‘lishini bildiradi.

i % 3 == 1 → bu sonni 3 ga bo‘lganda qoldiq 1 bo‘lishini bildiradi.

Har bir mos keluvchi son:

chiqariladi

sum ga qo‘shiladi

count ortadi, toki count == n bo‘lguncha*/

