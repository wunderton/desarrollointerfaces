using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 1; i < numericUpDown1.Value; i++)
            {
                sum = sum + i;
                if (checkBox1.Checked)
                {
                    listBox1.Items.Add("Sumando: " + i + " Suma parcial: " + sum);
                }
            }
            listBox1.Items.Add("Total: " + sum);
        }
    }
}
