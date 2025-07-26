using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
class TryCatchDemo
{
    static void Main()
    {
        MessageBox.Show("Dastur o'z ishini boshladi", "kirish");
        try
        {
            Double.Parse(Interaction.InputBox("Haqiqiy sonni kiriting", "sonni kiritish"));
            MessageBox.Show("Ha bu haqiqiy raqam", "natija");

        }
        catch  {
            MessageBox.Show("Siz haqiqiy raqm kiritmadinigiz", "Xato!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }
        MessageBox.Show("Dastur yakunlandi", "Tugatish");

    }
}