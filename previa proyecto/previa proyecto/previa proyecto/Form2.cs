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
    public partial class Form2 : Form
    {
        Form3 F3;
        public Form2(string Mensaje, Form F1)
        {
            InitializeComponent();

            label1.Text = Mensaje;

            F3 = new Form3(Mensaje);
            if (F3 == null)
            {
                F1.Show(); 
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                string Mensaje = textBox1.Text;
                
                this.Hide();
                F3.Show();
            }
        }
    }
}
