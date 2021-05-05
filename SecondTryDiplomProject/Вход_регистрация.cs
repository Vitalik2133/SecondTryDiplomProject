using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecondTryDiplomProject
{
    public partial class Вход_регистрация : Form
    {
        public Вход_регистрация()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Error!", "Name not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
                if (textBox2.Text == "")
            {
                MessageBox.Show("Error!", "Password is failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Authorisation complete!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
