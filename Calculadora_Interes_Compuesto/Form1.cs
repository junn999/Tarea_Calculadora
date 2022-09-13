using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Interes_Compuesto
{
    public partial class Form1 : Form
    {
        private double capital;
        private double tasa_interes;
        private double time;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboTiempo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string optionSelected = comboTiempo.Text;

            capital = double.Parse(txtCapital.Text);
            tasa_interes = double.Parse(txtInteres.Text);
            time = double.Parse(txtTime.Text);

            double I = 0;

            switch (optionSelected)
            {
                case "ANUAL":
                    I = capital * tasa_interes * time;
                    break;
                case "MENSUAL":
                    I = capital * tasa_interes * (time / 12);
                    break;
                case "DIARIO":
                    I = capital * tasa_interes * (time / 360);
                    break;
            }
            MessageBox.Show(I.ToString());
        }
    }
}
