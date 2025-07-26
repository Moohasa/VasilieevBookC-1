MyClass klassida ToString() metodi qayta aniqlangan (override qilingan). Bu metod natijada first va last maydonlari qiymatlarini o‘z ichiga olgan matnli satrni qaytaradi.
Shuni ham eslatib o‘tamiz: string identifikatori — bu System.String tipining psevdonimi (ya'ni soddalashtirilgan nomi) hisoblanadi.

Dasturda MyClass nomli klass mavjud bo‘lib, u ikki dona yopiq (private) butun sonli maydon — first va lastni o‘z ichiga oladi. Unda ikkita argument qabul qiluvchi konstruktor va number deb nomlangan xossa mavjud.
Konstruktor chaqirilganda, unga uzatilgan qiymatlar first va last maydonlariga o‘zlashtiriladi.

number xossasi o‘qish va yozish imkonini beradi — ya'ni get va set qismi bor. Ammo bu xossani o‘qish va yozishdagi amal ketma-ketligi oddiy emas, balki o‘ziga xos.

Aynan shunday: agar biz number xossasining qiymatini o‘qsak, natijada last maydonining joriy qiymati qaytariladi, lekin bir vaqtning o‘zida first va last joyini almashtiradi.
Agar biz number xossasiga qiymat bersak (set ishlasa), berilgan yangi qiymat first ga yoziladi, oldingi first qiymati esa last ga o‘zlashtiriladi.
Dasturdagi Main metodida MyClass obj = new MyClass(1, 9); qatori orqali yangi obyekt yaratiladi va first = 1, last = 9 bo‘ladi.

Console.WriteLine(obj) orqali obyekt chiqarilib, first va last qiymatlari tasdiqlanadi.

Console.WriteLine(obj) orqali obyekt chiqarilib, first va last qiymatlari tasdiqlanadi.
Agar obj.number orqali number xossasini o‘qsak, 9 qiymati (ya'ni oldingi last) qaytariladi, va shu bilan birga first va last joyini almashtiradi. Natijada: first = 9, last = 1.
Agar obj.number = 5 deb yozsak, first = 5 bo‘ladi, va last = 9 bo‘ladi (ya’ni, eski first saqlanadi).
Agar yana obj.number deb o‘qsak, 9 qaytariladi (last), va first bilan last joyini yana almashtiradi → first = 9, last = 5.


Yana obj.number o‘qilsa, 5 qaytariladi va qiymatlar yana almashtiriladi → first = 5, last = 9.
Keyin obj.number = 3 bajariladi → first = 3, last = 5 bo‘ladi (first eski qiymati lastga yoziladi).

