using Microsoft.VisualBasic;
using System.Windows.Forms;
using System;
class Test3boluv
{
    static void Main()
    {
        int nomer, dilda;

        nomer = Int32.Parse(Interaction.InputBox(
            "Raqamni kiriting",
            "Raqamni kiritish"));
        dilda = nomer % 3;

        string tekst = ("siz kiritgan raqam  ");
        tekst += (dilda == 0?"3 ga qoldiqsiz bo'linadi":"3 ga qoldqsiz bo'linmaydi");

        MessageBox.Show(tekst, "natija");
    }
}
