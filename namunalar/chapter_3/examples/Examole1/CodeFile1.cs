using System.Windows.Forms;
using Microsoft.VisualBasic;

class Example1
{
    static void Main()
    {
        // piktorgramma turi uchun o'zgaruvchi
        MessageBoxIcon icon;
        // habar matni uchun o'zgaruvchi, oyna sarlovhasi va foydalanuvchi nomi
        string msg, tittle, name;

        name = Interaction.InputBox("ismingiz nima",
                                    "ismingizni kirirting");
        
        //foydalanuvchi ismini kiritganini tekshiramiz

        if (name =="")
        {
            //xato piktogrmmasi
            icon = MessageBoxIcon.Error;
            msg = "siz hech nima kiritmadingiz";
            tittle = "ism kiritilmadi";

        }
        // hammasi OK bo'lsa'/,
        else
        {
            icon = MessageBoxIcon.Information;
            msg = "ismingiz muvofiqiyatli kiritildi";
            tittle = "Muvofiqiyatli";
        }

        // Habar ko'rsatilishi (argumentlar matni)
        MessageBox.Show(msg, tittle, MessageBoxButtons.OK, icon);

    }
}