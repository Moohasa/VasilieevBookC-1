using System;

class Alpha
{
    protected string text;

    public Alpha(string t)
    {
        text = t;
    }

    public override string ToString()
    {
        return "Alpha klassi matni:  " + text;
    }

    public virtual string Info
    {
        get { return text; }
        set { text = value; }
    }
}

class Beta : Alpha
{
    protected string text2;

    public Beta(string t, string s) : base(t) // ✅ to'g'ri klass nomi va base()
    {
        text2 = s;
    }

    public override string Info
    {
        get
        {
            return text + " " + text2;
        }
        set
        {
            int i = value.IndexOf(' ');
            if (i != -1)
            {
                text = value.Substring(0, i);
                text2 = value.Substring(i + 1);
            }
            else
            {
                text = value;
                text2 = "";
            }
        }
    }

    public override string ToString()
    {
        return "Beta klassi:\ntext = " + text + "\ntext2 = " + text2;
    }
}
class Program
{
    static void Main()
    {
        Beta b = new Beta("Salom", "Dunyo");
        Console.WriteLine(b.Info); // Salom Dunyo

        b.Info = "YangiMatn";
        Console.WriteLine(b.ToString()); // text = YangiMatn, text2 = ""

        b.Info = "Xayr Dunyo";
        Console.WriteLine(b.ToString()); // text = Xayr, text2 = Dunyo
    }
}
