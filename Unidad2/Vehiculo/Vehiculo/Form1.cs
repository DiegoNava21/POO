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
        ClassVehiculo objvehiculo = new ClassVehiculo();
    
        public Form1()
        {
            InitializeComponent();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            objvehiculo.tipo = cmbvehiculo.Text.ToString();
            objvehiculo.cantidadpre();
            
            txtcobro.Text = "$" + objvehiculo.costo.ToString();
        }
    }
}
