using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorCelsiusFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double tempF = double.Parse(txbTempF.Text);
            double resultado = ((tempF - 32) / 1.8f);
            
            lblResultado.Text = (resultado.ToString("N1") + "°C");

        }

        private void tempC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tempF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
