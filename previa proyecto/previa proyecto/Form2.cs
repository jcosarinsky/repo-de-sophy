﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace previa_proyecto
{
    public partial class Form2 : Form
    {
        public Form2(string Mensaje)
        {
            InitializeComponent();
            label1.Text = Mensaje;
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                string Mensaje = textBox1.Text;
                Form3 F3 = new Form3(Mensaje);
                this.Hide();
                F3.Show();
            }
        }
    }
}
