using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecondTryDiplomProject
{
    public partial class Профиль_сотрудника : Form
    {
        public Профиль_сотрудника()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Аккаунт_сотрудника аккаунт_Сотрудника = new Аккаунт_сотрудника();
            аккаунт_Сотрудника.Show();
        }
    }
}
