﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombreDefinido = "Antonio";
            String passwordDefinida = "Granturismo";
            String nombre = textBox1.Text;
            String password = textBox2.Text;

            if (nombre == nombreDefinido && password == passwordDefinida)
            {
                MessageBox.Show("Correcto!");
            }
            else MessageBox.Show("No es correcto");
        }
    }
}
