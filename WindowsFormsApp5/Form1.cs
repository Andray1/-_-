using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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
            int y = int.Parse(textBox2.Text);
            int z = int.Parse(textBox3.Text);
            if (x<z && x<y)
                MessageBox.Show("Ниф-Ниф набрал меньше всех", "Результат");
            else if (z<x && z<y)
                MessageBox.Show("Нуф-Нуф набрал меньше всех", "Результат");
            else if (y<z && y<x)
                MessageBox.Show("Наф-Наф набрал меньше всех", "Результат");



        }
    }
}
