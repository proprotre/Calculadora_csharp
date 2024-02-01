using System.DirectoryServices;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Nenhuma,
            Somar,
            Dividir,
            Subtrair,
            Multiplicar
        }
        public Form1()
        {
            InitializeComponent();
            OperacaoSelecionada = Operacao.Nenhuma;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lbOperacao.Text = "";
            OperacaoSelecionada = Operacao.Nenhuma;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if(OperacaoSelecionada == Operacao.Nenhuma)
            {
                OperacaoSelecionada = Operacao.Subtrair;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lbOperacao.Text = "-";
            }
            else
            {
                OperacaoSelecionada = Operacao.Subtrair;
                txtResultado.Text = "";
                lbOperacao.Text = "-";
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (OperacaoSelecionada == Operacao.Nenhuma)
            {
                OperacaoSelecionada = Operacao.Somar;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lbOperacao.Text = "+";
            }
            else
            {
                OperacaoSelecionada = Operacao.Somar;
                txtResultado.Text = "";
                lbOperacao.Text = "+";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (OperacaoSelecionada == Operacao.Nenhuma)
            {
                OperacaoSelecionada = Operacao.Multiplicar;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lbOperacao.Text = "x";
            }
            else
            {
                OperacaoSelecionada = Operacao.Multiplicar;
                txtResultado.Text = "";
                lbOperacao.Text = "x";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (OperacaoSelecionada == Operacao.Nenhuma)
            {
                OperacaoSelecionada = Operacao.Dividir;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lbOperacao.Text = "/";
            }
            else
            {
                OperacaoSelecionada = Operacao.Dividir;
                txtResultado.Text = "";
                lbOperacao.Text = "/";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (OperacaoSelecionada)
                {
                    case Operacao.Somar:
                        Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                        break;
                    case Operacao.Subtrair:
                        Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                        break;
                    case Operacao.Multiplicar:
                        Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                        break;
                    case Operacao.Dividir:
                        Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                        break;
                }
                txtResultado.Text = Convert.ToString(Resultado);
                lbOperacao.Text = "=";
                OperacaoSelecionada = Operacao.Nenhuma;
            }
            catch (System.FormatException)
            {

            }
        }
    }
}