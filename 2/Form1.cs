using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Пока!";
            label1.ForeColor = Color.Red;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Привет!";
        }
    }
}
