using System;
class HarHiObjectlchamliMassiv
{
    static void Main(string[] args)
    {
        //o'zgaruvchi massivdan simvolli massiv
        char[][] symbs = new char[5][];
        //o'zgaruvchi massivdan butun sonli massiv
        int[][] nums = { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 } };
        //simvolli o'zgaruvchi
        char s = 'А';
        //simvolli massivni to'ldirish
        for (int i = 0; i < symbs.Length; i++)
        {
            // ichkinmassivni yaratish
            symbs[i] = new char[i + 3];
            // ichki massivni elementlarini ko'paytirish
            for (int j = 0; j < symbs[i].Length; j++)
            {
                //ichki massiv elementlari
                symbs[i][j] = s;
                //keyingi elementni qiymatini o'zgartiramiz
                s++;
            }

        }
        Console.WriteLine("butunsonli qiymat");
        //butunsonli massivni chop etish
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                //massive elementini chop etish
                Console.Write("{0, 3}", nums[i][j]);

            }
            Console.WriteLine();

        }
        Console.WriteLine("simvolli massiv");
        //foreach yordamida simvolli massivni chop etish
        foreach (char[] q in symbs)
        {
            foreach (char p in q)
            {
                Console.Write("{0,2}", p);
            }
            Console.WriteLine();
        }
    }
}