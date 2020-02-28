using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2y3
{
    public partial class Form1 : Form
    {
        ClassVehiculo objpagar = new ClassVehiculo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            objpagar.tipo = cmbTipo.Text.ToString();
            objpagar.cantidadcosto();
            txtc.Text = "$" + objpagar.precio.ToString();
        }
    }
}
