using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public enum Days
    {
      Monday=0, Tuesday=1, Wednesday=2,Thursday=3, Friday=4,Saturday=5,Sunday=6
    }
    public partial class Gunler : Form
    {
        public Gunler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == Days.Monday.ToString()) {
                MessageBox.Show("Bugün Pazartesi");
            } else if(comboBox1.Text == Days.Tuesday.ToString())
            {
                MessageBox.Show("Bugün Salı");
            }
            else if (comboBox1.Text == Days.Wednesday.ToString())
            {
                MessageBox.Show("Bugün Çarşamba");
            }
            else if (comboBox1.Text == Days.Thursday.ToString())
            {
                MessageBox.Show("Bugün Perşembe");
            }
            else if (comboBox1.Text == Days.Friday.ToString())
            {
                MessageBox.Show("Bugün Cuma");

            }
            else if (comboBox1.Text == Days.Saturday.ToString())
            {
                MessageBox.Show("Bugün Cumartesi");

            }
            else if (comboBox1.Text == Days.Sunday.ToString())
            {
                MessageBox.Show("Bugün Pazar");

            }

        }





        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
