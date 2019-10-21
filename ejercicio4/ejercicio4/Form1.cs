using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int precio = 0;
            if (radioButton1.Checked)
            {
                precio = 6;
            }
            if (radioButton2.Checked)
            {
                precio = 10;
            }
            if (radioButton3.Checked)
            {
                precio = 12;
            }
            if (checkBox1.Checked)
            {
                precio = precio + 1;
            }
            if (checkBox2.Checked)
            {
                precio = precio + 3;
            }
            if (checkBox3.Checked)
            {
                precio = precio + 65;
            }
            label4.Text = precio.ToString();
        }
    }
}
