using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.label1.Text = "Test3";
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "골든벨";
            label2.Text = "충돌만들자";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGoldenBell fgb = new frmGoldenBell();
            fgb.MdiParent = this;
            fgb.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BtnGoodee bg = new BtnGoodee();
            bg.ShowDialog();
        }
    }
}
