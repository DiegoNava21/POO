using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesEjercicio1
{
    public partial class Form1 : Form
    {
        Accion objacc = new Accion();
        Deportes objdep = new Deportes();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprecioaccion_Click(object sender, EventArgs e)
        {
            objacc.Nombre = Convert.ToString(txtnombrea.Text);
            objacc.AñoEs = int.Parse(txtañoa.Text);
            objacc.PrecioA = int.Parse(txtprecioa.Text);
            objacc.SacarPrecio();
            MessageBox.Show(objacc.Nombre + ", El precio de este juego es: " + objacc.PrecioA);
        }

        private void btnPreciodeporte_Click(object sender, EventArgs e)
        {
            objdep.Nombre = Convert.ToString(txtnombred.Text);
            objdep.AñoEs = int.Parse(txtañod.Text);
            objdep.PrecioD = int.Parse(txtprecioa.Text);
            objdep.SacarPrecio();
            MessageBox.Show(objdep.Nombre + ", El precio de este juego es: " + objdep.PrecioD);
        }
    }
}
