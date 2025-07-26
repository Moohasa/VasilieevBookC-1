using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Interaction.InputBox("Son kiriting:", "Son kiritish");

        if (int.TryParse(input, out int son))
        {
            string natija = $"{son - 1}, {son}, {son + 1}";
            MessageBox.Show($"Ketma-ketlik: {natija}", "Natija");
        }
        else
        {
            MessageBox.Show("Iltimos, butun son kiriting.", "Xato");
        }
    }
}
