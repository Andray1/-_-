using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__3._4_Задание_1
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
            double y;

            if (x < 0) y = x * x + 1;
            else if (x >= 0 && x <= 1) y = 2 * x + 1;
            else y = 4 * x - 1;
            label2.Text = "Y=" + Convert.ToString(y);
        }
    }
}
