using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Program
{
    [STAThread]
    static void Main()
    {
        string son1Str = Interaction.InputBox("Birinchi sonni kiriting:", "Son 1");
        string son2Str = Interaction.InputBox("Ikkinchi sonni kiriting:", "Son 2");

        if (double.TryParse(son1Str, out double son1) && double.TryParse(son2Str, out double son2))
        {
            double summa = son1 + son2;
            MessageBox.Show($"Natija: {son1} + {son2} = {summa}", "Yig‘indi");
        }
        else
        {
            MessageBox.Show("Iltimos, to‘g‘ri sonlar kiriting.", "Xato");
        }
    }
}
