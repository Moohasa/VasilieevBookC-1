using System;
using System.Threading;
class A
{
    public int num;
    public  void setElement(int n)
    {
        num = n;
    }
    public A (int n)
    {
        num = n;
    }
    public override string ToString()
    {
        string txt = "A klassi  "+num;
        return txt;
    }

}
class B : A
{
    public char symb;
    public void  setElement(int n, char c)
    {
        num = n;
        symb = c;
      
    }
    public B (int n, char c):base(n)
    {
         symb = c;
    }
    public override string ToString()
    {
        string txt = "B klassi \n son = "+ num+" \n belgi "+symb;
        return txt;
    }
}
class C : B
{
    string matn;
    public C(int n, char c, string t) : base(n, c)
    {
        matn = t;
    }
    public void setElement(int n, char c, string t)
    {
        num = n;
        symb = c;
        matn = t;
    }
    public override string ToString()
    {
        string txt = "C klassi \n" +
            "son = " + num
            + "\nbelgi = " + symb
            + "\nmant =" + matn;
            
        return txt;
    }

}
class Program
{
    static void Main()
    {
        A A1 = new A(1);
        Console.WriteLine(A1);

        Console.WriteLine();

        B B1 = new B(1, 'b');
        Console.WriteLine(B1);

        Console.WriteLine() ;

        C C1 = new C(1, 'c', "C#");
        Console.WriteLine(C1);


    }
}