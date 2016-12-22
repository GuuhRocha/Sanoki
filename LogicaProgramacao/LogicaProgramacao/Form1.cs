using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaProgramacao
{
    public partial class btnLimpar : Form
    {
        public btnLimpar()
        {
            InitializeComponent();
        }

        public bool fazAniversarioEsteAno()
        {
            return true;
        }

        private void brnGravar_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txtIdade.Text) >= 18) || (int.Parse(txtIdade.Text) == 17) && (fazAniversarioEsteAno()))
            {
                //Efetua-se o cadastro
            }
            else
            {
                MessageBox.Show("Cadastro Recusado devido a idade");
            }

        }

        private void btnCalcularIMc_Click(object sender, EventArgs e)
        {
            double imc;
            double peso;
            double altura;
            string situacao = "";

            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                situacao = "Abaixo do Peso ideal";
            }

            else if (imc > 18.5 && imc <= 24.9)
            {
                situacao = "Peso Normal";
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                situacao = "Acima do Peso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                situacao = "Obesidade grau I";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                situacao = "Obesidade grau II";
            }
            else
            {
                situacao = "Obesidade grau III";
            }

            MessageBox.Show(situacao);

        }

        private void btnGravarCliente_Click(object sender, EventArgs e)
        {
            double limite = 1000;

            switch (cboTipoCliente.Text)
            {
                case "Intermediário":
                    limite = limite + ((10 * limite) / 100); break;

                case "VIP":
                    limite = limite + ((50 * limite) / 100); break;
            }

            if (cboTipoCliente.Text == "Normal")
            {
  
            }
            else if (cboTipoCliente.Text == "Intermediário")
            {
                limite = limite + ((10 * limite) / 100);
            }
            else if (cboTipoCliente.Text == "VIP")
            {
                limite = limite + ((50 * limite) / 100);
            }


        }

        private void btnCalcularFatorial_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int resultado = 1;

            for (int i = 1; i<= n; i++)
            {
                resultado = resultado * i;
            }

            MessageBox.Show(resultado.ToString());
        }

        private void btnExtrairPares_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtPares.Text);
            string resultado = "";

            for(int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    resultado = resultado + i + ",";
                }
            }
            MessageBox.Show(resultado);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();

            foreach(Control control in this.Controls)
            {
                if (control.GetType().Equals(txt.GetType()))
                {
                    control.Text = "";
                }
            }
        }

        private void btnGravarRegistros_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();

            bool validaCampo = true;

            foreach (Control control in this.Controls)
            {
                if (control.GetType().Equals(txt.GetType()))
                {
                    if (control.Text == "")
                    {
                        control.BackColor = Color.Red;
                        validaCampo = false;
                        break;
                    }
                }
            }

            if (validaCampo == false)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
        }

        private void btnTestWhile_Click(object sender, EventArgs e)
        {
            int numero = 101;
            Random rnd = new Random();

            while (numero < 100)
            {
                numero = numero + rnd.Next(100);
            }
            MessageBox.Show(numero.ToString());

            do
            {
                numero = numero + rnd.Next(100);

            }
            while (numero < 100);

            MessageBox.Show(numero.ToString());
            
        }
    }
}
