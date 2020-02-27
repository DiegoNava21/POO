using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrado
{
    public partial class Form1 : Form
    {
        ClassCuadrado objlado = new ClassCuadrado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            objlado.lado = int.Parse(txtlado.Text.ToString());
            objlado.ObtenerArea();
            lblarea.Text = "Area: " + objlado.area.ToString();
        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            objlado.lado = int.Parse(txtlado.Text.ToString());
            objlado.ObtenerPerimetro();
            lblperimetro.Text = "Perimetro: " + objlado.Perimetro.ToString();
        }
    }
}
