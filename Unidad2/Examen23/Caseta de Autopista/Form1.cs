using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caseta_de_Autopista
{
    public partial class Form1 : Form
    {
        ClassVehivulo objCar = new ClassVehivulo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            objCar.tipo = (objCar.tipo.ToString());
            objCar.CantidadCosto();
            lblCobro.Text = "$" + objCar.Cobro.ToString();
        }    
    }
}