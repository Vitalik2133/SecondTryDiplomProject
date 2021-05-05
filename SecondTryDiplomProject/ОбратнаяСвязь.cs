using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SecondTryDiplomProject
{
    public partial class ОбратнаяСвязь : Form
    {
        public ОбратнаяСвязь()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using (StreamWriter incdate = File.AppendText(@"D:\incdate.txt"))
            //{
            //    incdate.WriteLine(textBox1.Text, '\n');
            //}
            //this.Close();
        }
    }
}
