using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Светофор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Создаем перечисление
        public enum Светофор { Красный, Желтый, Зеленый}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Светофор signal = (Светофор)comboBox1.SelectedIndex;
            //Changin color
            switch (signal)
            {
                case Светофор.Красный:
                    label1.Text = "Стойте!";
                    label1.BackColor = Color.Red;
                    break;
                case Светофор.Желтый:
                    label1.Text = "Ждите!";
                    label1.BackColor = Color.Yellow;
                    break;
                case Светофор.Зеленый:
                    label1.Text = "Идите!";
                    label1.BackColor = Color.Green;
                    break;
            }
        }
    }
}
