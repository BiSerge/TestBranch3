using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBranch3
{
    public partial class Form1 : Form
    {
        string str = "Hello world from Form1";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mForm2 = new Form2();
            mForm2.Show();
        }
    }
}
