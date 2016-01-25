using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//abrir plantilla
            openFileDialog1.ShowDialog();
            string rp = openFileDialog1.FileName;
            textBox1.Text = rp;


        }

        private void button2_Click(object sender, EventArgs e)
        {//abrir tests
            openFileDialog1.ShowDialog();
            string rt = openFileDialog1.FileName;
            textBox2.Text = rt;


        }
    }
}
