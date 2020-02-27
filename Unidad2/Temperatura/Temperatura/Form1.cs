using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    
    public partial class Form1 : Form
    {
        classTemperatura objTemp = new classTemperatura
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objTemp.Tipo = cmbtipo.Text.ToString();
            objTemp.geados = int.Parse(txtgrados.Text.ToString());
            objTemp.ConvCelsiusyConvFahrenheit();
            lblgrados.Text = objTemp.ResultadoC.tostring();


        }
    }
}
