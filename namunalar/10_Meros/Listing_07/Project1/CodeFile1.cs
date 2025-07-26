using System;

class Alpha
{
    public int alpha;

    // virtual metod — meros orqali override qilinishi mumkin
    public virtual void show()
    {
        Console.WriteLine("Klass Alpha:  {0}", alpha);
    }

    // Konstruktor — qiymat berish
    public Alpha(int n)
    {
        alpha = n;
    }
}

class Bravo : Alpha
{
    public int bravo;

    // override — Alpha klassidagi virtual metodni o‘zgartiryapti
    public override void show()
    {
        Console.WriteLine("Klass Bravo:  {0} va {1}", alpha, bravo);
    }

    public Bravo(int n, int m) : base(n)  // Alpha(n) chaqiriladi
    {
        bravo = m;
    }
}

class Charlie : Bravo
{
    public int charlie;

    // yana override — eng oxirgi avlod klassda
    public override void show()
    {
        Console.WriteLine("Charlie klassi: {0},  {1}, va {2}", alpha, bravo, charlie);
    }

    public Charlie(int n, int m, int p) : base(n, m)
    {
        charlie = p;
    }
}

class OverridingDemo
{
    static void Main()
    {
        // Alpha klassidan obyekt
        Alpha objA = new Alpha(10);
        objA.show();  // Alpha versiyasi
        Console.WriteLine();

        // Bravo klassidan obyekt
        Bravo objB = new Bravo(20, 30);
        objB.show();  // Bravo versiyasi

        // Charlie klassidan obyekt
        Charlie objC = new Charlie(40, 50, 60);
        objC.show();  // Charlie versiyasi

        // Charlie turidagi obyekt Alpha turidagi o‘zgaruvchiga tayinlandi
        objA = objC;
        objC.show();  // baribir Charlie versiyasi, chunki override

        Console.WriteLine();

        // Charlie obyekt Bravo turidagi o‘zgaruvchiga tayinlandi
        objB = objC;
        objC.show();  // yana Charlie versiyasi
    }
}
