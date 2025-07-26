
using System;
class YoshAniqlash
{
    static void Main()
    {
        string yoshText;
        int yil = 2024, yosh, tugilganYil;
        Console.WriteLine(" tug'ilgan yilingizni kiriting");
        yoshText = Console.ReadLine(); 
        tugilganYil = Int32.Parse(yoshText);
        yosh = yil - tugilganYil;
        Console.WriteLine("sizning yoshingiz  " + yosh + " da");




    }
}