using System;
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
    public partial class Form1 : Form
    {
        public Form1(string Mensaje)
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                string Mensaje = textBox1.Text;
                Form2 F2 = new Form2(Mensaje, this);
                this.Hide();    
                F2.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
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
