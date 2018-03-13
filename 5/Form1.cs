using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int ch = x / 100;
            int ost = x % 100;
            MessageBox.Show("Растояние равно " + Convert.ToString(ch) + " метров " + Convert.ToString(ost) + " сантиметров", "Результат перевода", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
