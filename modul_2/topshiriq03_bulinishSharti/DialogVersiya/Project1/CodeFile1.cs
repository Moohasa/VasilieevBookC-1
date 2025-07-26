using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Microsoft.VisualBasic.Interaction.InputBox("Son kiriting:", "Tekshiruv");

        if (int.TryParse(input, out int number))
        {
            if (number % 4 == 0 && number >= 10)
            {
                MessageBox.Show("Son 4 ga bo'linadi va 10 dan katta yoki teng.", "Natija");
            }
            else
            {
                MessageBox.Show("Son shartlarga javob bermaydi.", "Natija");
            }
        }
        else
        {
            MessageBox.Show("Iltimos, to'g'ri son kiriting.", "Xato");
        }
    }
}
