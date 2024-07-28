namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum)
                txtSonuc.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void optHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            label1.Text = label1.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
            }

            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            label1.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            optDurum = true;

            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
            }

            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            if (txtSonuc.Text == "0")

            {
                txtSonuc.Text = "0";

            }
            else if (optDurum == true)
            {
                txtSonuc.Text = "0";
            }
            if(!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text+= ",";
            }
            optDurum = false;
        }
    }
}
