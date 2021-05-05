using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecondTryDiplomProject
{
    public partial class Корзина_товаров : Form
    {
        public Корзина_товаров()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Главная главная = new Главная();
            главная.Show();
            this.Close();
        }
    }
}
