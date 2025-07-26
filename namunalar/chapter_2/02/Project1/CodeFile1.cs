using System.Windows.Forms;
using Microsoft.VisualBasic;

class tasks1
{
    static void Main()
    {
        string ismfamiliya, yoshtext;
        //int yosh;

        ismfamiliya = Interaction.InputBox(
            "ism va familiyanginizni kiriting",
            "ismi va familiya");
        yoshtext = Interaction.InputBox(
            "yoshingizni kiriting",
            "yosh");
        MessageBox.Show("salom  " + ismfamiliya + " " + "ism va familiya muvaffiqiyatli kiritildi sizninig yoshingiz  "+ yoshtext + " da");
    }
}