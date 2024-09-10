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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int operation = 1;

        public void AltDisplay()
        {
            if (operation == 1)
            {
                lblDisplay.Text = txtNum1.Text + "+" + txtNum2.Text;
            }
            else if (operation == 2)
            {
                lblDisplay.Text = txtNum1.Text + "-" + txtNum2.Text;
            }
            else if (operation == 3)
            {
                lblDisplay.Text = txtNum1.Text + "*" + txtNum2.Text;
            }
            else if (operation == 4)
            {
                lblDisplay.Text = txtNum1.Text + "/" + txtNum2.Text;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            double Num1 = Convert.ToDouble(txtNum1.Text);
            double Num2 = Convert.ToDouble(txtNum2.Text);

            if(operation == 1)
            {
                double Resultado = Num1 + Num2;
                lblResultado.Text = Convert.ToString(Resultado);
            }
            else if(operation == 2)
            {
                double Resultado = Num1 - Num2;
                lblResultado.Text = Convert.ToString(Resultado);
            }
            else if (operation == 3)
            {
                double Resultado = Num1 * Num2;
                lblResultado.Text = Convert.ToString(Resultado);
            }
            else if (operation == 4)
            {
                double Resultado = Num1 / Num2;
                lblResultado.Text = Convert.ToString(Resultado);
            }
            else
            {
                MessageBox.Show("Escolha uma operação a ser usada", "Calculadora",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = 1;
            lblOperation.Text = "Operação selecionada: +";
            AltDisplay();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = 2;
            lblOperation.Text = "Operação selecionada: -";
            AltDisplay();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operation = 3;
            lblOperation.Text = "Operação selecionada: *";
            AltDisplay();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = 4;
            lblOperation.Text = "Operação selecionada: /";
            AltDisplay();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            AltDisplay();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            AltDisplay();
        }
    }
}
