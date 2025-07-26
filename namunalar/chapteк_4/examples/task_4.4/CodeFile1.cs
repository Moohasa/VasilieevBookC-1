using System;
class Task4_3
{
    static void Main()
    {
        int a = 10;
        char c = 'A';
        char[] b = new char[a];
        for (int i = 0; i < b.Length; i++)
        {
            b[i] = c;
            if (b[i] == 'A' || b[i] == 'E' || b[i] == 'O' || b[i] == 'U' || b[i] == 'I' || b[i] == 'Y')
            {
                b[i]++;
                c++;
            }
            c++;
            Console.Write(b[i] + "  ");
        }
    }
}