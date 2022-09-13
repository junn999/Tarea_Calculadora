using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;

        public Form1()
        {
            InitializeComponent();
        }
        private void comboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string optionSelected = comboOpciones.Text;

            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            double resultado = 0;

            switch (optionSelected)
            {
                case "SUMA":
                    resultado = num1 + num2;
                    break;
                case "RESTA":
                    resultado = num1 - num2;
                    break;
                case "MULTIPLICACION":
                    resultado = num1 * num2;
                    break;
                case "DIVISION":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre CERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNum1.Clear();
                        txtNum2.Clear();
                    }
                    break;
            }
            MessageBox.Show(resultado.ToString());
        }
    }
}