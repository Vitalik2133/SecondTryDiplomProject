using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTryDiplomProject
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Товар1 товар1 = new Товар1();
            товар1.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Вход_регистрация вход_Регистрация = new Вход_регистрация();
            вход_Регистрация.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Корзина_товаров корзина_Товаров = new Корзина_товаров();
            корзина_Товаров.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ОбратнаяСвязь обратнаяСвязь = new ОбратнаяСвязь();
            обратнаяСвязь.Show();
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Профиль_сотрудника профиль_Сотрудника = new Профиль_сотрудника();
            профиль_Сотрудника.Show();
        }
    }
}
