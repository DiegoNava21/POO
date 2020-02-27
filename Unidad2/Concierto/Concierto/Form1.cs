using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concierto
{
    public partial class Form1 : Form
    {
        ClassAsistente objentrada = new ClassAsistente();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblcat_Click(object sender, EventArgs e)
        {

        }

        private void btnco_Click(object sender, EventArgs e)
        {
            objentrada.persona = cmbper.Text.ToString();
            objentrada.num1 = int.Parse(cmbnum.Text.ToString());
            objentrada.num2 = int.Parse(cmbnum.Text.ToString());
            objentrada.num3 = int.Parse(cmbnum.Text.ToString());
            objentrada.num4 = int.Parse(cmbnum.Text.ToString());
            objentrada.Registrar();
            cmbnum.Text = "";
            cmbper.Text = "";
            MessageBox.Show("Bien");
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            objentrada.persona = cmbper.Text.ToString();
            objentrada.num1 = int.Parse(cmbnum.Text.ToString());
            objentrada.num2 = int.Parse(cmbnum.Text.ToString());
            objentrada.num3 = int.Parse(cmbnum.Text.ToString());
            objentrada.num4 = int.Parse(cmbnum.Text.ToString());
            objentrada.Registrar();
            cmbnum.Text = "";
            cmbper.Text = "";
            
        }
    }
}
