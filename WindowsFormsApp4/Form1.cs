using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = x % 10;
            int z = x / 10;
            if (y == 2 || z == 2 || y == 7 || z == 7)
                MessageBox.Show("В данном числе присутствуют цифры 2 или 7", "Результат");
            else
                MessageBox.Show("В данном числе отсутствуют цифры 2 или 7", "Результат");
        }
    }
}
