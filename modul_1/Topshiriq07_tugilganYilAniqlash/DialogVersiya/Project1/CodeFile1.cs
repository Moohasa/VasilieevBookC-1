using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Program
{
    [STAThread]
    static void Main()
    {
        string yoshStr = Interaction.InputBox("Yoshingizni kiriting:", "Yosh kiritish");

        if (int.TryParse(yoshStr, out int yosh))
        {
            int joriyYil = DateTime.Now.Year;
            int tugilganYil = joriyYil - yosh;

            MessageBox.Show($"Siz taxminan {tugilganYil}-yilda tug‘ilgansiz.", "Natija");
        }
        else
        {
            MessageBox.Show("Iltimos, to‘g‘ri raqam kiriting.", "Xato");
        }
    }
}
