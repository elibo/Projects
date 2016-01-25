using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1._2
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
            
        }

        public ArrayList num = new ArrayList();


        private void button1_Click(object sender, EventArgs e)
        {
            num.Add(textBox1.Text);
            num.Add("2");
            num.Add("5");
            num.Add("8");
            num.Add("3");
            list1.DataSource = num;
            textBox1.Clear();

        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void asc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (asc.Checked)
            {
                num.Sort();
                list1.DataSource = num;
            }
            else if (desc.Checked)
            {
                num.Reverse();
                list1.DataSource = num;
            }

        }
    }
}
