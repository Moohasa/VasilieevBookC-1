using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Interaction uchun

class Program
{
    [STAThread] // Dialog oynalar uchun kerak
    static void Main()
    {
        string ism = Interaction.InputBox("Ismingizni kiriting:", "Ism");
        string yilStr = Interaction.InputBox("Tug'ilgan yilingizni kiriting:", "Tug'ilgan yil");

        if (int.TryParse(yilStr, out int tugilganYil))
        {
            int hozirgiYil = DateTime.Now.Year;
            int yosh = hozirgiYil - tugilganYil;

            MessageBox.Show($"Salom, {ism}! Siz {yosh} yoshdasiz.", "Natija");
        }
        else
        {
            MessageBox.Show("Yilni to'g'ri raqam ko'rinishida kiriting!", "Xato");
        }
    }
}
