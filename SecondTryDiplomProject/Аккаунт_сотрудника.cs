using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecondTryDiplomProject
{
    public partial class Аккаунт_сотрудника : Form
    {
        public Аккаунт_сотрудника()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Error", "not all fields are filled in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Error", "not all fields are filled in", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Error", "not all fields are filled in", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Error", "not all fields are filled in", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Error", "not all fields are filled in", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (textBox4.Text == textBox5.Text)
            {
                MessageBox.Show("Ok!", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Fail!", "Copy password is fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
