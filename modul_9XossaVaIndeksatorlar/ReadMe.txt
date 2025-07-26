🟦 Original matn (ruscha):
Существуют свойства, доступные только для чтения или только для
записи. То есть свойство может быть таким, что можно узнать его
значение, но нельзя присвоить значение свойству. А может быть
и наоборот: свойству можно присвоить значение, но нельзя узнать
значение свойства.

✅ O‘zbekchasi va tushuntirishi:
🔹 Faqat o‘qish yoki faqat yozish uchun mo‘ljallangan xossalar mavjud.
🔸 Ya’ni xossa shunday bo‘lishi mumkin: uning qiymatini o‘qish mumkin, lekin unga yangi qiymat berib bo‘lmaydi (readonly).
🔸 Yoki aksincha: unga qiymat berish mumkin, lekin uning qiymatini o‘qib bo‘lmaydi (write-only).

🧠 Tushuncha:
C# da xossalar ikki qismdan iborat bo‘ladi — get (o‘qish) va set (yozish).
Siz faqat get yozsangiz — bu faqat o‘qiladigan xossa, faqat set yozsangiz — bu faqat yoziladigan xossa bo‘ladi.

🟦 Davomi:
Свойство может быть и открытым, и закрытым (при описании свойства можно использовать ключевое слово, определяющее уровень доступа), а также свойство может быть статическим.

✅ O‘zbekchasi va tushuntirishi:
🔹 Xossa ochiq (public) ham, yopiq (private yoki protected) ham bo‘lishi mumkin.
🔸 Xossaning kirish darajasini aniqlash uchun kirish operatorlari (access modifiers) ishlatiladi: public, private, protected, internal va hokazo.
🔸 Shuningdek, xossa statik (static) bo‘lishi ham mumkin, ya’ni u klassga bog‘liq bo‘ladi, ob’ektga emas.

🧠 Tushuncha:

csharp
Копировать
Редактировать
public string Name { get; set; }      // ochiq xossa
private int Age { get; set; }         // yopiq xossa
public static string AppName { get; set; }  // statik xossa
🟦 Davomi:
Поскольку свойство не определяет область памяти и не связано
с областью памяти, то свойство нельзя использовать с идентификаторами ref и out.

✅ O‘zbekchasi va tushuntirishi:
🔹 Xossa o‘zining alohida xotira hududiga ega emas va u to‘g‘ridan-to‘g‘ri xotira bilan bog‘liq emas,
🔸 Shuning uchun xossani ref yoki out bilan ishlatib bo‘lmaydi.

🧠 Tushuncha:

ref va out — bu aniq xotira manziliga ishlov beruvchi uslublar.

Xossa esa orqasida funksiya/avtomatik kod bo‘lishi mumkin, u xotira joylashuvi bilan bog‘liq emas.

Shu sababli quyidagi kod xatolik beradi:

csharp
Копировать
Редактировать
public string Name { get; set; }

void Print(ref string name)
{
    // bu xato: xossa ref bilan chaqirib bo‘lmaydi
    Print(ref person.Name);  // ❌ XATOLIK
}
🔚 XULOSA:
Narsa	Tushuntiruv
Faqat o‘qiladigan xossa	get bor, set yo‘q
Faqat yoziladigan xossa	set bor, get yo‘q
Kirish darajalari	public, private, protected, internal
Statik xossa	static kalit so‘z bilan belgilanadi
ref / out ishlatilmasligi	Xossa aniq xotira manzili emas, faqat qiymat beradi

Agar xohlasangiz, bu jihatlarning har biriga kod misollar yozib beraman.
Keyingi bosqichga o‘tamizmi? Yoki readonly va write-only xossalarni real kodda ko‘rsataymi?

Indeksator — bu klassning maxsus a’zosi bo‘lib, uning mavjudligi klass obyektlarini indekslash imkonini beradi.

Agar biz obyektni indekslayapmiz desak, bu shuni anglatadiki: obyekt nomidan keyin kvadrat qavs ichida indeks (yoki indekslar) beriladi — albatta, bunda bunday ifoda mantiqan ma’noga ega bo‘lishi kerak.

Demak, agar siz klassda indeksator e’lon qilsangiz, u holda obyektdan massiv kabi foydalanishingiz mumkin. Bu esa juda qulay va istiqbolli imkoniyatdir.
🔵 Indeksator qanday ishlaydi?
Indeksator bilan ishlashda ikkita holat mavjud:

Qiymatni o‘qish: ya’ni, obj[3] orqali qiymat olish. Bunda get aksessor ishlaydi.

Qiymat tayinlash: ya’ni, obj[3] = 45; orqali qiymat yozish. Bunda set aksessor ishlaydi.

Bu holatlar xossalar (properties) kabi ishlaydi, faqat indeksatorda qo‘shimcha ravishda indeks ham ishtirok etadi.


public tip this[tur indeks]
{
    get
    {
        // indeks bo‘yicha qiymatni qaytarish
    }
    set
    {
        // indeks bo‘yicha yangi qiymatni yozish (value yordamida)
    }
}


Izoh:
tip — indekslashda qaytariladigan yoki yoziladigan qiymat turi (masalan, int, string).

this — bu indeksator faqat shu klassga tegishli ekanini bildiradi.

indeks — massivga o‘xshab, o‘sha indeks orqali ishlash.

value — set aksessorida tashqaridan kelgan qiymat.

🔵 Muhim eslatmalar:
Indeksatorlar ko‘pincha int indeks bilan ishlatiladi, lekin bu shart emas. string yoki boshqa turdagi indekslar ham bo‘lishi mumkin.

Indeksatorlar overload qilinishi mumkin (ya’ni, bir klassda bir nechta indeksator bo‘lishi mumkin — indekslar soni yoki turi bilan farqlanadi).

Indeksatorlar static bo‘la olmaydi.

ref yoki out bilan ishlatilmaydi.

🔵 this kalit so‘zi haqida
this — bu klass ichida obyektning o‘ziga murojaat qilish uchun ishlatiladi.

Indeksatorda this orqali obj[...] usulidagi yozuvlar amalga oshiriladi.

class MyClass
{
    private int[] data = new int[10];

    public int this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
}
__________________________________________
MyClass obj = new MyClass();
obj[0] = 5;         // set ishlaydi
Console.Write(obj[0]);  // get ishlaydi
🔵 Yakuniy xulosa:
Indeksator — bu sizga obyektdan massivdek foydalanish imkonini beradigan vosita.
U xossalar kabi ishlaydi, lekin qo‘shimcha ravishda indeks ishtirok etadi.
Bu kodni sodda, o‘qilishi oson, va qulay qiladi.

Agar xohlasangiz, hozir real kod misoli bilan amaliy ko‘rsatib ham beraman. Yoki shuni o‘zingiz yozib ko‘rishni xohlaysizmi?


