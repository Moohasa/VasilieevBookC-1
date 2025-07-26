using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Program
{
    [STAThread]
    static void Main()
    {
        string aStr = Interaction.InputBox("Birinchi sonni kiriting:", "Son A");
        string bStr = Interaction.InputBox("Ikkinchi sonni kiriting:", "Son B");

        if (double.TryParse(aStr, out double a) && double.TryParse(bStr, out double b))
        {
            double summa = a + b;
            double ayirma = a - b;

            string natija = $"Yig‘indi: {summa}\nAyirma: {ayirma}";
            MessageBox.Show(natija, "Hisoblash natijasi");
        }
        else
        {
            MessageBox.Show("Iltimos, to‘g‘ri sonlar kiriting.", "Xato");
        }
    }
}
