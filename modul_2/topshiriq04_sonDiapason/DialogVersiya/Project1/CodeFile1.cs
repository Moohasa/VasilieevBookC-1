using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Microsoft.VisualBasic.Interaction.InputBox("Son kiriting (5 dan 10 gacha):", "Tekshiruv");

        if (int.TryParse(input, out int number))
        {
            if (number >= 5 && number <= 10)
            {
                MessageBox.Show("Son diapazon ichida.", "Natija");
            }
            else
            {
                MessageBox.Show("Son diapazon tashqarisida.", "Natija");
            }
        }
        else
        {
            MessageBox.Show("Iltimos, to'g'ri son kiriting.", "Xato");
        }
    }
}
