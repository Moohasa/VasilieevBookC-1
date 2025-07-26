using System.Windows.Forms;
using Microsoft.VisualBasic;

class tasks1
{
    static void Main()
    {
        string hafta, kun, oy;

        hafta = Interaction.InputBox(
            "bugungi hafta kunini kiriting",
            "hafta kuni");
        kun = Interaction.InputBox(
            "bugungi kunni kiriting",
            "kun");
        oy = Interaction.InputBox(
            "hozir qaysi oy",
            "oy");
        MessageBox.Show("bugun " + hafta + " " + kun +"-"+oy+" ", "Bugun");
    }
}