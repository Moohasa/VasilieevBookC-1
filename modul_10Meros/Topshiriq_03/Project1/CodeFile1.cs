using System;

// === Asosiy klass ===
class Alpha
{
    // Ochiq int massivga havola
    public int[] nums;

    public Alpha(int[] n)
    {
        // Massivdan nusxa olish
        nums = new int[n.Length];
        for (int i = 0; i < n.Length; i++)
        {
            nums[i] = n[i];
        }
    }

    // ToString() – int[] qiymatlarini matnga aylantirish
    public override string ToString()
    {
        string txt = "Alpha klassidagi sonlar: ";
        for (int i = 0; i < nums.Length; i++)
        {
            txt += nums[i] + " ";
        }
        return txt;
    }
}

// === Hosila klass ===
class Bravo : Alpha
{
    // Qo‘shimcha char massiv
    public char[] symbs;

    public Bravo(int[] n, char[] s) : base(n)
    {
        // Char massivdan nusxa olish
        symbs = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            symbs[i] = s[i];
        }
    }

    // ToString() – ikkala massiv qiymatini chiqarish
    public override string ToString()
    {
        string txt = "Bravo klassidagi sonlar: ";
        for (int i = 0; i < nums.Length; i++)
        {
            txt += nums[i] + " ";
        }

        txt += "\nBravo klassidagi belgilar: ";
        for (int i = 0; i < symbs.Length; i++)
        {
            txt += symbs[i] + " ";
        }

        return txt;
    }
}

// === Test qilish uchun Main metodi ===
class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30, 40, 50 };
        char[] b = { 'a', 'b', 'c', 'd', 'e' };

        Alpha A = new Alpha(a);
        Console.WriteLine(A); // Alpha klassidagi sonlar: 10 20 30 40 50

        Bravo B = new Bravo(a, b);
        Console.WriteLine(B); // Bravo klassidagi sonlar: 10 20 30 40 50
                              // Bravo klassidagi belgilar: a b c d e
    }
}
