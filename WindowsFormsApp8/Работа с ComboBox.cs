using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Зима.jpg");
                    label1.Text = "Зима";
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Зима.jpg");
                    label1.Text = "Зима";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Весна.jpg");
                    label1.Text = "Весна";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Весна.jpg");
                    label1.Text = "Весна";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Весна.jpg");
                    label1.Text = "Весна";
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Лето.jpg");
                    label1.Text = "Лето";
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Лето.jpg");
                    label1.Text = "Лето";
                    break;
                case 7:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Лето.jpg");
                    label1.Text = "Лето";
                    break;
                case 8:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Осень.jpg");
                    label1.Text = "Осень";
                    break;
                case 9:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Осень.jpg");
                    label1.Text = "Осень";
                    break;
                case 10:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Осень.jpg");
                    label1.Text = "Осень";
                    break;
                case 11:
                    pictureBox1.Image = Image.FromFile(@"R:\СЕРКОВА\ПМ03\Картинки\Зима.jpg");
                    label1.Text = "Зима";
                    break;

            }
        }
    }
}
