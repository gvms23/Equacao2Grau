using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equacao2Grau
{
    public partial class frmEquacao2Grau : Form
    {
        public frmEquacao2Grau()
        {
            InitializeComponent();
        }

        public void LimparResiduos()
        {
            lblFormula1.Visible = false;
            lblFormula2.Visible = false;
            lblFormula3.Visible = false;

            lblExplicacao.Visible = false;
            lblExplicacao2.Visible = false;
            lblExplicacao3.Visible = false;
            lblExplicacao4.Visible = false;
            lblExplicacao5.Visible = false;
            lblExplicacao6.Visible = false;
            lblExplicacao7.Visible = false;
            lblExplicacao8.Visible = false;
            lblExplicacao6.Visible = false;
            lblExplicacao7.Visible = false;
            lblExplicacao8.Visible = false;
            lblExplicacao9.Visible = false;
            lblExplicacao10.Visible = false;
            lblExplicacao11.Visible = false;
            lblExplicacao12.Visible = false;
            lblExplicacao13.Visible = false;
            lblExplicacao14.Visible = false;
            lblExplicacao15.Visible = false;
            lblExplicacao16.Visible = false;
            lblExplicacao17.Visible = false;
            lblExplicacao18.Visible = false;
            lblExplicacao19.Visible = false;
            lblExplicacao20.Visible = false;
            lblExplicacao21.Visible = false;
            lblExplicacao22.Visible = false;
            lblX1.Visible = false;
            lblX2.Visible = false;
        }

        //botão enter
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.F5)
            {
                btnEfetuarCalc.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public decimal TruncateDecimal(decimal valor, int precisao)
        {
            decimal step = (decimal)Math.Pow(10, precisao);
            int tmp = (int)Math.Truncate(step * valor);
            return tmp / step;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //valores iniciais

            txtA.Text = "1";
            txtB.Text = "3";
            txtC.Text = "-10";

        }

        private void btnEfetuarCalc_Click(object sender, EventArgs e)
        {
            
            //limpando resíduos
            LimparResiduos();

            //declaro variaveis
            //que serão recebidas dos textboxes.
            double a, b, c; 
            
            //utilizo no calculo
            double delta, x, xa, xb;


            //valido os textbox se for = 0
            if (txtA.Text == "0" || txtB.Text == "0" || txtC.Text == "0")
            {
                MessageBox.Show("A, B e C têm de ser diferentes de zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtA.Text.Contains(".") || txtB.Text.Contains(".") || txtC.Text.Contains("."))
            {
                MessageBox.Show("Retire os pontos e substitua-os por vírgula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtA.Text == string.Empty || txtB.Text == string.Empty || txtC.Text == string.Empty)
            {
                MessageBox.Show("A, B e C não podem estar vazios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //se não forem = 0
            else
            {

                //recebo e converto os dados dos textboxes
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);

                //usado para fazer a validação do "+" e do "2x" e "1x" = x
                string coefA, coefB, coefC;

                //recebe os valores para validação
                coefA = a.ToString();
                coefB = b.ToString();
                coefC = c.ToString();

                if (a == 1)
                {
                    coefA = "";
                }
                if (b > 0)
                {
                    coefB = coefB.Insert(0, "+");
                }
                if (c > 0)
                {
                    coefC = coefC.Insert(0, "+");
                }

                lblSintaxe.Text = coefA + "x² " + coefB + "x " + coefC + " = 0" ;

                lblSintaxe.Visible = true;

                //calculo do delta
                delta = (b * b) - ((4 * a) * c);

                double deltaConvert = Math.Sqrt(delta);

                //calculo do X
                //Math.Sqrt() faz a raiz quadrada
                x = (-b + -Math.Sqrt(delta)) / (2 * a);

                //usado para a explicação
                double expressao = (-4 * a * c);

                //validação abaixo é feita, pois se o resultado for negativo, ele
                //mostra o sinal "-" mas se for positivo não mostra o sinal "+"
                //então se expressao for > zero, obrigo ele a mostrar o "+"

                double delta2 = Convert.ToDouble(TruncateDecimal(Convert.ToDecimal(delta), 2));
                if (expressao > 0)
                {
                    //-------------PASSO 1------------------//
                    lblExplicacao.Text = Convert.ToString("Passo 1 - Delta: \n\nΔ = b² –4 . a . c \nΔ = " + b + "² –4 . " + a + " . " + c + " \nΔ = " + (b * b) + " + " + (-4 * a * c) + "\nΔ = " + delta2);
                }

                if (expressao < 0)
                {
                    //-------------PASSO 1------------------//
                    lblExplicacao.Text = Convert.ToString("Passo 1 - Delta: \n\nΔ = b² –4 . a . c \nΔ = " + b + "² –4 . " + a + " . " + c + " \nΔ = " + (b * b) + " " + (-4 * a * c) + "\nΔ = " + delta);
                }

                lblExplicacao.Visible = true;
                

                //se delta for negativo
                if (delta < 0)
                {
                    lblExplicacao.Text += ("\n\nΔ < 0, não há raizes reais.");
                    return;
                }

                else
                {
                    lblExplicacao2.Visible = true;
                    //-------------PASSO 2------------------//
                    //parte 1
                    lblFormula1.Visible = true;
                    lblFormula2.Visible = true;
                    lblFormula3.Visible = true;

                    //parte 2
                   
                    //lblExplicacao3 = (-b +- √Δ)
                    lblExplicacao3.Text = (-b + " +-" + " √" + delta2);

                    //lblExplicacao5 = 2 . a
                    lblExplicacao5.Text = "2 . " + a;

                    lblExplicacao3.Visible = true;
                    lblExplicacao4.Visible = true;
                    lblExplicacao5.Visible = true;

                    //parte 3

                    //Bhaskara1(a, b, c);
                    deltaConvert = Convert.ToDouble(TruncateDecimal(Convert.ToDecimal(deltaConvert), 2));

                     lblExplicacao6.Text = (-b + " +- " + deltaConvert);
                   // lblExplicacao6.Text = (-b + " +- " + deltaConvert);
                    lblExplicacao8.Text = (Convert.ToString(2 * a));

                    lblExplicacao6.Visible = true;
                    lblExplicacao7.Visible = true;
                    lblExplicacao8.Visible = true;

                    //------------- FIM PASSO 2------------------//

                    //------------- PASSO 3------------------//
                    //parte 4
                    lblExplicacao10.Text = (-b + " + " + deltaConvert);
                    lblExplicacao12.Text = lblExplicacao8.Text;

                    //parte 5
                    lblExplicacao13.Text = (Convert.ToString(-b + deltaConvert));
                    lblExplicacao15.Text = lblExplicacao8.Text;

                    //resposta x1
                    
                    xa = (-b + (Math.Sqrt(delta))) / (2 * a);
                    xa = Convert.ToDouble(TruncateDecimal(Convert.ToDecimal(xa), 2));

                    //deltaConvert = Convert.ToDouble(TruncateDecimal(Convert.ToDecimal(deltaConvert), 2));
                    lblX1.Text = ("= " + Convert.ToString(xa));
                   

                    lblExplicacao9.Visible = true;
                    lblExplicacao10.Visible = true;
                    lblExplicacao11.Visible = true;
                    lblExplicacao12.Visible = true;
                    lblExplicacao13.Visible = true;
                    lblExplicacao14.Visible = true;
                    lblExplicacao15.Visible = true;
                    lblX1.Visible = true;

                    //------------- FIM PASSO 3------------------//

                    //------------- PASSO 4------------------//
                    //parte 6ToDouble
                    lblExplicacao17.Text = (-b + " - " + deltaConvert);
                    lblExplicacao19.Text = lblExplicacao8.Text;

                    //parte 7
                    lblExplicacao20.Text = (Convert.ToString(-b - deltaConvert));
                    lblExplicacao22.Text = lblExplicacao8.Text;

                    //resposta x2
                    xb = ((-b - deltaConvert)) / (2 * a);
                    xb = Convert.ToDouble(TruncateDecimal(Convert.ToDecimal(xb), 2));

                    lblX2.Text = ("= " + Convert.ToString(xb));

                    lblExplicacao16.Visible = true;
                    lblExplicacao17.Visible = true;
                    lblExplicacao18.Visible = true;
                    lblExplicacao19.Visible = true;
                    lblExplicacao20.Visible = true;
                    lblExplicacao21.Visible = true;
                    lblExplicacao22.Visible = true;
                    lblX2.Visible = true;
                }
                //------------- FIM PASSO 4------------------//

                //x1 = (-3 + 7    ) / 2    = 4/2  = 2

                //x2 = (-3 - 7    ) / 2    = -10/2 = -5

                //x = ( -b +- √Δ  ) / 2

                /*"Δ = b² –4 . a . c"
                   Δ = 3² – 4 * 1 * (–10)
                     Δ = 9 + 40
                     Δ = 49*/


                /*
                     Exemplo
                     Dada a equação x² +3x – 10 = 0, determine suas raízes, se existirem.
                     a = 1, b = 3 e c = –10
                     Δ  = b² – 4ac
                     Δ = 3² – 4 * 1 * (–10)
                     Δ = 9 + 40
                     Δ = 49
                      x = ( -b +- √Δ  ) / 2
                      x = ( -3 +- √49 ) / (2*1)
                      x = ( -3 +- 7   ) / 2
                      x1 = (-3 + 7    ) / 2    = 4/2  = 2
                      x2 = (-3 - 7    ) / 2    = -10/2 = -5
                */



            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {

            //não permitir augumas coisas 
            if (char.IsLetter(e.KeyChar) || //Letras

                char.IsSymbol(e.KeyChar) || //Símbolos

                char.IsWhiteSpace(e.KeyChar)) //Espaço

                e.Handled = true; //Não permitir

            //só permitir digitar uma vez o traço
            if (e.KeyChar == '-'
                && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //não permitir augumas coisas 
            if (char.IsLetter(e.KeyChar) || //Letras

                char.IsSymbol(e.KeyChar) || //Símbolos

                char.IsWhiteSpace(e.KeyChar)) //Espaço

                e.Handled = true; //Não permitir

            //só permitir digitar uma vez o traço
            if (e.KeyChar == '-'
                && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //não permitir augumas coisas 
            if (char.IsLetter(e.KeyChar) || //Letras

                char.IsSymbol(e.KeyChar) || //Símbolos

                char.IsWhiteSpace(e.KeyChar)) //Espaço

                e.Handled = true; //Não permitir

            //só permitir digitar uma vez o traço
            if (e.KeyChar == '-'
                && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        private void pcbLinkedin_Click(object sender, EventArgs e)
        {
            string msg = ("Quer visualizar meu perfil no Linkedin? \n\nClique em \"Sim\" para visitar a seguinte URL:\nhttps://www.linkedin.com/in/gvms23/");

            if (MessageBox.Show(msg, "Ajuda", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/gvms23");
            }
        }
    }
}
