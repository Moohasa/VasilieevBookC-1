using System;

// Bazaviy klass — Alpha
class Alpha
{
    private int num;       // ❌ Faqat Alpha klassida ko‘rinadi
    protected char symb;   // ✅ Alpha va undan meros olgan klasslar (masalan, Bravo) ko‘ra oladi

    // num uchun public getter (o‘qish) metod
    public int getNum()
    {
        return num;
    }

    // symb uchun public getter
    public char getSymb()
    {
        return symb;
    }

    // num uchun public setter (qiymat berish)
    public void setNum(int n)
    {
        num = n;
    }

    // symb uchun public setter
    public void setSymb(char c)
    {
        symb = c;
    }
}
// Alpha'dan meros olgan Bravo klassi
class Bravo : Alpha
{
    // symb ni encapsulation orqali ishlash uchun property
    // sababi: symb — protected, shuning uchun bevosita foydalanish mumkin
    public char symbol
    {
        get
        {
            return symb;  // ✅ symb bu klassda ko‘rinadi (protected bo‘lgani uchun)
        }
        set
        {
            symb = value;
        }
    }

    // num ni encapsulation orqali ishlash uchun property
    // num esa private, shuning uchun bevosita kira olmaymiz
    // faqat getter/setter metodlar orqali kirishimiz mumkin
    public int number
    {
        get
        {
            return getNum();  // ✅ num ni o‘qish faqat metod orqali mumkin
        }
        set
        {
            setNum(value);   // ✅ num ni o‘zgartirish ham metod orqali
        }
    }
}
// Dastur bajarilishi shu yerda boshlanadi
class PrivateAndProtectedDemo
{
    static void Main()
    {
        Alpha A = new Alpha();

        // num va symb private/protected bo‘lgani uchun, ularga to‘g‘ridan-to‘g‘ri kira olmaymiz
        // shuning uchun public metodlar orqali qiymat berilmoqda
        A.setNum(100);
        A.setSymb('A');

        Console.WriteLine("A obyekti: {0} va {1}", A.getNum(), A.getSymb());

        // Bravo klassidan obyekt yaratamiz
        Bravo B = new Bravo();

        // Bravo Alpha'dan meros olgan, shuning uchun setNum(), setSymb() metodlariga ega
        B.setNum(200);     // private num faqat metod orqali ishlatiladi
        B.setSymb('C');    // protected symb ham metod orqali o‘zgaradi

        Console.WriteLine("B obyekti:  {0}  va  {1}", B.getNum(), B.getSymb());

        // Bu yerda esa property orqali qiymat berilmoqda
        B.number = 300;     // number → setNum(300) ni chaqiradi
        B.symbol = 'C';     // symbol → symb ga to‘g‘ridan-to‘g‘ri qiymat beradi (protected bo‘lgani uchun)

        Console.WriteLine("B obyekti:  {0}  va  {1}", B.number, B.symbol);
    }
}
