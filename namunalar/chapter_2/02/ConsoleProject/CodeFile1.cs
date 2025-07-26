using System;
class Tasks2
{
    static void Main()
    {
        string ismfamiliya, yoshtext;
        Console.WriteLine("ismizngizni va familiyangizni kiririting");
        ismfamiliya = Console.ReadLine();
        Console.WriteLine("yoshingizni kirirting");
        yoshtext = Console.ReadLine();
        Console.WriteLine(ismfamiliya + " Sizning ism familiyangiz muvofiqiyatli kiritildi, sizning yoshingiz  " + yoshtext + " da");
    }
}