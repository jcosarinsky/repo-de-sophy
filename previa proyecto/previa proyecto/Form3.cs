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
    public partial class Form3 : Form
    {
        public Form3(string Mensaje)
        {
            InitializeComponent();
            label1.Text = Mensaje;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
