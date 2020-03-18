using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculo
{
    public partial class Form1 : Form
    {
        Aereo objAereo = new Aereo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnarrancar_Click(object sender, EventArgs e)
        {
           MessageBox.Show(objAereo.arrancarMotor(txtSonido.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuaradar_Click(object sender, EventArgs e)
        {
            objAereo.numAlas = int.Parse(txt6.Text);
            objAereo.numTurbinas = int.Parse(txt7.Text);
            objAereo.numHelices = int.Parse(txt8.Text);
            objAereo.tipoAereo = (cmb1.Text);
            objAereo.tipoCombustible = (txt1.Text);
            objAereo.color = (txt2.Text);
            objAereo.numLlantas = int.Parse(txt3.Text);
            objAereo.numPuertas = int.Parse(txt4.Text);
            objAereo.numVentanas = int.Parse(txt5.Text);
            MessageBox.Show("La informacon del objeto " + cmb1.Text + "Se guardo correctamente");
        }

        private void btnparar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objAereo.pararMotor(txtsonidoparar.Text));
        }

        private void btnVolar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objAereo.enVuelo(btnVolar.Text));
        }
    }
}
