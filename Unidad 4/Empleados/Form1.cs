using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        Mesero objmesero = new Mesero();
        Cajero objcajero = new Cajero();
        Repartidor objrepartidor = new Repartidor();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsueldomesero_Click(object sender, EventArgs e)
        {
            objmesero.Nombre = Convert.ToString(txtnombremesero.Text);
            DateTime FechaNac = dtpmesero.Value;
            objmesero.Diastra = int.Parse(cmbdiasmesero.Text);
            objmesero.Sueldo = Convert.ToDouble(txtsueldomesero.Text);
            objmesero.PropinaSemanal = int.Parse(txtpropinamesero.Text);
            objmesero.SacarSueldo();
            MessageBox.Show(objmesero.Nombre + ", Su sueldo es de: " + objmesero.SueldoM);
        }

        private void btnsueldorepartidor_Click(object sender, EventArgs e)
        {
            objmesero.Nombre = Convert.ToString(txtnombremesero.Text);
            DateTime FechaNac = dtprepartidor.Value;
            objrepartidor.Diastra = int.Parse(cmbdiasrepartidor.Text);
            objrepartidor.SueldoRe = Convert.ToDouble(txtsueldorepartidor.Text);
            objrepartidor.PropinaRe = int.Parse(txtpropinarepartidor.Text);
            objrepartidor.Abonos = int.Parse(txtabono.Text);
            objrepartidor.ZonaRe = Convert.ToString(cmbzonareparto);
            objrepartidor.SacarSueldo();
            MessageBox.Show(objrepartidor.Nombre + ", Su sueldo es: " + objrepartidor.SueldoRe);
        }

        private void btnsueldocajero_Click(object sender, EventArgs e)
        {
            objcajero.Nombre = Convert.ToString(txtnombrecajero.Text);
            DateTime FechaNac = dtpcajero.Value;
            objcajero.Diastra = int.Parse(cmbdiascaja.Text);
            objcajero.SueldoCa = Convert.ToDouble(txtsueldocajero.Text);
            objcajero.Caja = Convert.ToString(cmbcaja.Text);
            objcajero.SacarSueldo();
            MessageBox.Show(objcajero.Nombre + ", Su  sueldo es: " + objcajero.SueldoCa);
        }
    }
}
