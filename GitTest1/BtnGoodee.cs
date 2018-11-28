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
    public partial class BtnGoodee : Form
    {
        public BtnGoodee()
        {
            InitializeComponent();
        }

        private void BtnGoodee_Load(object sender, EventArgs e)
        {
            MessageBox.Show("그의 이름은 ");
        }
    }
}
