using System.Windows.Forms;
using Microsoft.VisualBasic;

class tasks1
{
    static void Main()
    {
        string ism, familiya;

        ism = Interaction.InputBox(
            "isminginizni kiriting",
            "ismi");
        familiya = Interaction.InputBox(
            "familiyazni kiriting",
            "familiya");
        MessageBox.Show("salom  "+ ism + " " + familiya,  "ism familiya muvaffiqiyatli kiritildi");
    }
}