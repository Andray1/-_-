using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 1";
            textBox1.ForeColor = System.Drawing.Color.Red;
            button1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 2";
            textBox1.ForeColor = System.Drawing.Color.Blue;
            button2.ForeColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 3";
            textBox1.ForeColor = System.Drawing.Color.Green;
            button3.ForeColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 4";
            textBox1.ForeColor = System.Drawing.Color.Magenta;
            button4.ForeColor = Color.Magenta;
        }
    }
}
