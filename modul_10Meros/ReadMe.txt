📌 1. Meros nima?
Meros — bu bir klass boshqa klassning xususiyatlari va metodlarini meros qilib olishi deganidir.

➕ Foydasi:
Kodni qayta ishlatish (reusability)

Loyihani modulga bo‘lish

OOP prinsiplariga moslash
 2. base va derived klasslar
// Bosh klass (base/super class)
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Hayvon ovqat yemoqda.");
    }
}

// Hosila klass (derived/sub class)
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("It vovullamoqda.");
    }
}
Foydalanish
Dog myDog = new Dog();
myDog.Eat();  // base klassdan meros olingan
myDog.Bark(); // o‘z metodlari

3. protected kalit so‘zi
private → faqat shu klassda

protected → shu klass va undan meros olgan klasslar

public class Person
{
    protected string name;

    public void SetName(string n)
    {
        name = n;
    }
}

public class Student : Person
{
    public void PrintName()
    {
        Console.WriteLine($"Ismi: {name}");
    }
}
 4. Konstruktorlar merosda


public class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent konstruktori");
    }
}

public class Child : Parent
{
    public Child()
    {
        Console.WriteLine("Child konstruktori");
    }
}

 5. sealed va override
sealed → bu klassdan boshqa klasslar meros ola olmaydi

override → bazaviy klass metodini o‘zgartirish

virtual → bazaviy metodni override qilishga tayyor qilish

public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Hayvon tovush chiqarmoqda.");
    }
}

public class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Miyov!");
    }
}


meros olishda siz bir nechta o‘xshash klasslar yaratayotganda, ularning umumiy xatti-harakatlarini (metodlar, o‘zgaruvchilar) bazaviy klassga joylashtirib, undan boshqa klasslar meros oladi. Natijada:

Kod kamroq yoziladi

Xatolik ehtimoli kamayadi

Qo‘llab-quvvatlash osonlashadi


public class Animal {
    public void Eat() {
        Console.WriteLine("Ovqat yeyapti...");
    }
}

public class Dog : Animal {
    // Eat() ni qayta yozish shart emas
}


 Agar siz bir nechta klasslarda bir xil kodni “copy-paste” qilib yozgan bo‘lsangiz, kelajakda o‘sha kodni o‘zgartirish kerak bo‘lsa, har bir klassni alohida o‘zgartirishingiz kerak bo‘ladi.

Ammo agar siz bazaviy klassda metodni o‘zgartirsangiz, barcha hosila klasslar avtomatik yangilanadi, chunki ular o‘sha kodni meros qilib olgan.

🧠 Bu tamoyil "DRY" deb ataladi — Don't Repeat Yourself (O‘zingni takrorlama).

Bu yerda “copy-paste” texnologiyasining salbiy tomoni ko‘rsatilmoqda. Ya'ni, bir xil kodni har yerga nusxalab qo‘yish:

Katta loyiha bo‘lsa, xatoliklarni kuzatish qiyinlashadi

Yagona o‘zgarishni 10 joyga kiritishga to‘g‘ri keladi

Har safar unutib qoldirish xavfi bor



Bu eng muhim nuqta:

O‘zgarishlar bir marta amalga oshiriladi

Hosila klasslar avtomatik yangilangan funksionalga ega bo‘ladi

Bu dastur ko‘lamini boshqarishni yengillashtiradi

Kitob hozircha asosiy afzallik — kodni takrorlamaslik haqida gapirdi. Kelgusida quyidagilar ham muhokama qilinadi:

override, virtual yordamida polymorfizm

abstract klasslar va interfeyslar bilan meros

sealed, base kalit so‘zlari bilan murakkab meros munosabatlari

🧠 Xulosa:
Meros olish — bu:

Kodni takrorlamaslik (effektivlik)

Loyihani modulga ajratish (tuzilish)

Xatolikni kamaytirish (ishonchlilik)

Kelajakdagi o‘zgarishlarni boshqarish (qo‘llab-quvvatlash osonligi)


protectded

	protected — bu qo‘riqlangan (himoyalangan) a’zo demakdir. U:

O‘sha klass ichida ishlatiladi

Shuningdek, undan meros olgan (derived) klasslarda ham foydalaniladi

class Parent
{
    protected string name = "Ismi: Dasturchi";
}

class Child : Parent
{
    public void ShowName()
    {
        Console.WriteLine(name);  // MUMKIN
    }
}

private → faqat ota klassning o‘zida ishlatiladi, avlodlar hatto ko‘ra olmaydi.

protected → avlod (derived) klasslarga ham ko‘rinadi, lekin tashqi klasslarga emas.

Agar siz avlod klassda o‘sha o‘zgaruvchidan yoki metoddan foydalanmoqchi bo‘lsangiz, protected ishlatish kerak.




class A
{
    private int x = 10;
    protected int y = 20;
    public int z = 30;

    public void Show()
    {
        Console.WriteLine($"x = {x}, y = {y}, z = {z}");
    }
}

class B : A
{
    public void ShowDerived()
    {
        // Console.WriteLine($"x = {x}");  ❌ Error
        Console.WriteLine($"y = {y}");    // ✅ OK
        Console.WriteLine($"z = {z}");    // ✅ OK
    }
}
avlod klass bazaviy klassdagi metod yoki xususiyatni qayta yozmasa ham bo‘ladi, lekin xohlasa — qayta yozishi mumkin.

Bu ikki holatga olib keladi:
shunchki erkitib uborish  - new kalit so‘zi bilan
override qilish bilan  -    override kalit so‘zi bilan


class A
{
    public void Show()
    {
        Console.WriteLine("A.Show()");
    }
}

class B : A
{
    public new void Show()  // yangi metod, aslini yashiradi
    {
        Console.WriteLine("B.Show()");
    }
}
new bilan berkitish 
class A
{
    public void Show()
    {
        Console.WriteLine("A.Show()");
    }
}

class B : A
{
    public new void Show()  // yangi metod, aslini yashiradi
    {
        Console.WriteLine("B.Show()");
    }
}
override yoki virtual bilan
class A
{
    public virtual void Show()
    {
        Console.WriteLine("A.Show()");
    }
}

class B : A
{
    public override void Show()
    {
        Console.WriteLine("B.Show()");
    }
}
C# tilida ko‘p martalik meros (multiple inheritance) — ruxsat etilmagan.

class A { }
class B { }
class C : A, B  // ❌ Error — C# da mumkin emas
 Buning o‘rniga C# quyidagilarga ruxsat beradi:

1 ta klassdan meros olish

Ko‘p interfeyslarni implementatsiya qilish


interface IOne { }
interface ITwo { }

class MyClass : IOne, ITwo  // ✅ bu mumkin
{
}



ko‘p bosqichli meros (inheritance chain) deganidir. Ya’ni:

Klass A dan B meros oladi

B dan esa C meros oladi
class A
{
    public void ShowA() => Console.WriteLine("A");
}

class B : A
{
    public void ShowB() => Console.WriteLine("B");
}

class C : B
{
    public void ShowC() => Console.WriteLine("C");
}

Bu esa bir klassdan bir nechta boshqa klasslar meros olishi mumkinl


class Animal
{
    public void Eat() => Console.WriteLine("Eating...");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Woof!");
}

class Cat : Animal
{
    public void Meow() => Console.WriteLine("Meow!");
}

xulosa shuki
Avlod klass bazaviy metodni o‘zgartirish (override) yoki berkitib qo‘yish (new) huquqiga ega.

C# da faqat 1 ta bazaviy klass bo‘lishi mumkin.

Klasslar zanjir tarzida meros ola oladi.

Bir bazaviy klassdan bir nechta avlod klasslar hosil qilish mumkin.




