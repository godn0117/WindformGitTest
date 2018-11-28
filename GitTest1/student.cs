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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Student");
        }
    }
}
