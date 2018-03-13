using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double F = 0;
            if (x <= -3)
                F = 9;
            else if (x > -3)
                F = 1 / (x * x + 1);
            label2.Text = "F(x)=" + Convert.ToString(F);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
