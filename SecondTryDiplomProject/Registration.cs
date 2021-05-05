using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecondTryDiplomProject
{
    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Главная главная = new Главная();
            главная.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "")
            {
                MessageBox.Show("Error!", "Имя пользователя не найдено", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
              if (Email.Text == "")
            {
                MessageBox.Show("Error!", "Emai не найден", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
           if (textBox3.Text == "")
            {
                MessageBox.Show("Error!", "Name not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
               if (textBox4.Text == "")
            {
                MessageBox.Show("Error!", "Name not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Error!", "Passwords don't match!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
            if (textBox3.TextLength <= 3)
            {
                MessageBox.Show("Пароль слишком короткий.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox5.Text == "")
            {
                {
                    MessageBox.Show("Телефон не найден", "Name not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }

            else
                MessageBox.Show("Registration complete!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
