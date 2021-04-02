using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrarlamaq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eded1, eded2, cem;
            eded1 = Convert.ToInt32(textBox1.Text);
            eded2 = Convert.ToInt32(textBox2.Text);
            cem = eded1 + eded2;
            label1.Text = cem.ToString();

        }
    }
}
