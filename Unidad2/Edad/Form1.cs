using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorDeEdad
{
    public partial class Form1 : Form
    {
        ClassPersona objMayor = new ClassPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            objMayor.anioA = int.Parse(DateTime.Today.Year.ToString());
            objMayor.mesA = int.Parse(DateTime.Today.Month.ToString());
            objMayor.diaA = int.Parse(DateTime.Today.Day.ToString());
            objMayor.anioN = int.Parse(dtpNacimiento.Value.Year.ToString());
            objMayor.mesN = int.Parse(dtpNacimiento.Value.Month.ToString());
            objMayor.diaN = int.Parse(dtpNacimiento.Value.Day.ToString());
            objMayor.MayorDeEdad();
            lblMayor.Text = "Persona: " + objMayor.mayorEdad;
            objMayor.mayorEdad = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblMayor.Text = "Persona: ";
        }
    }
}
