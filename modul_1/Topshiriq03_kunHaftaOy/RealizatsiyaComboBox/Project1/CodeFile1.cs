using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Windows.Extensions;
class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new SanaFormasi());
    }
}

public class SanaFormasi : Form
{
    private ComboBox cbHafta;
    private ComboBox cbOy;
    private TextBox txtSana;
    private Button btnKorsatish;

    public SanaFormasi()
    {
        this.Text = "Sana kiritish";
        this.Width = 300;
        this.Height = 250;

        Label lblHafta = new Label() { Text = "Hafta kuni:", Left = 10, Top = 20, Width = 100 };
        cbHafta = new ComboBox() { Left = 120, Top = 20, Width = 140 };
        cbHafta.Items.AddRange(new string[] {
            "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba"
        });

        Label lblOy = new Label() { Text = "Oy:", Left = 10, Top = 60, Width = 100 };
        cbOy = new ComboBox() { Left = 120, Top = 60, Width = 140 };
        cbOy.Items.AddRange(new string[] {
            "Yanvar", "Fevral", "Mart", "Aprel", "May", "Iyun",
            "Iyul", "Avgust", "Sentabr", "Oktabr", "Noyabr", "Dekabr"
        });

        Label lblSana = new Label() { Text = "Sana (raqam):", Left = 10, Top = 100, Width = 100 };
        txtSana = new TextBox() { Left = 120, Top = 100, Width = 140 };

        btnKorsatish = new Button() { Text = "Ko‘rsatish", Left = 90, Top = 150, Width = 100 };
        btnKorsatish.Click += BtnKorsatish_Click;

        this.Controls.Add(lblHafta);
        this.Controls.Add(cbHafta);
        this.Controls.Add(lblOy);
        this.Controls.Add(cbOy);
        this.Controls.Add(lblSana);
        this.Controls.Add(txtSana);
        this.Controls.Add(btnKorsatish);
    }

    private void BtnKorsatish_Click(object sender, EventArgs e)
    {
        string hafta = cbHafta.Text;
        string oy = cbOy.Text;
        string sana = txtSana.Text;

        if (string.IsNullOrWhiteSpace(hafta) || string.IsNullOrWhiteSpace(oy) || string.IsNullOrWhiteSpace(sana))
        {
            MessageBox.Show("Iltimos, barcha maydonlarni to‘ldiring!", "Xatolik");
            return;
        }

        MessageBox.Show($"Bugungi sana: {hafta}, {sana} {oy}", "Natija");
    }
}
