using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculador_do_Cindra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string NumeroEscolha = "";
        double numero1 = 0;
        double numero2 = 0;
        double numeroSalvo = 0;
        string EscolhaCalculo = "";
        int EscolhaEquacao = 0;
        double resultado = 0;
        bool proximoNumero = false;


        private void digitar_0(object sender, RoutedEventArgs e)
        {
            if (text_numero.Text != "0")
            {
                NumeroEscolha += "0";
                text_numero.Text = NumeroEscolha;
            }
            else
            {
                text_numero.Text = "0";
            }
        }

        private void digitar_virgula(object sender, RoutedEventArgs e)
        {
            if (!NumeroEscolha.Contains(","))
            {
                NumeroEscolha += ",";
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_resultado(object sender, RoutedEventArgs e)
        {
            if (EscolhaEquacao == 1)
            {
                if (NumeroEscolha == "")
                {
                    if (text_numero.Text == resultado.ToString())
                    {
                        text_conta.Text = $"{numero1} + {numeroSalvo} =";
                        resultado = numeroSalvo + numero1;
                    }
                    else
                    {
                        resultado = numero1 + numero1;
                        text_conta.Text = $"{numero1} + {numero1} =";
                    }
                }
                else if (text_numero.Text == resultado.ToString())
                {
                    numero2 = double.Parse(NumeroEscolha);
                    resultado = numero1 + numeroSalvo;
                    text_conta.Text = $"{numero1} + {numero2} =";
                }
                else
                {
                    numero2 = double.Parse(NumeroEscolha);
                    resultado = numero1 + numeroSalvo;
                    text_conta.Text = $"{numero1} + {numeroSalvo} =";
                }
            }
        }

        private void digitar_soma(object sender, RoutedEventArgs e)
        {

            if (text_conta.Text.Contains("×") || text_conta.Text.Contains("-") || text_conta.Text.Contains("+"))
            {
                text_conta.Text = numero1.ToString() + "+";
            }
            else if(text_conta.Text.Contains("+") && !text_conta.Text.Contains("="))
            {
                if (numero1 == 0)
                {
                    text_conta.Text = numero1.ToString() + "+";
                    text_numero.Text = numero1.ToString();
                    NumeroEscolha = "";
                }
                else
                {
                    numero1 = numero1 + double.Parse(NumeroEscolha);
                    text_conta.Text = numero1.ToString() + "+";
                    text_conta.Text = numero1.ToString();
                    NumeroEscolha = "";
                }
            }
            else if(text_numero.Text == "0")
            {
                NumeroEscolha = "0";
                numero1 = double.Parse(NumeroEscolha);
                text_conta.Text = numero1.ToString() + "+";
            }
            else
            {
                numero1 = double.Parse(NumeroEscolha);
                text_conta.Text = numero1.ToString() + "+";
                NumeroEscolha = "";

                if (proximoNumero)
                {
                    numero1 = resultado;
                    text_conta.Text = $"{resultado}";
                }
            }

            EscolhaEquacao = 1;

        }

        private void digitar_3(object sender, RoutedEventArgs e)
        {
            if (NumeroEscolha.Contains("0", 0))
            {
                NumeroEscolha = "3";
            }
            else
            {
                NumeroEscolha += "3";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 3;
            }
            else
            {
                numeroSalvo += 3;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_2(object sender, RoutedEventArgs e)
        {
            if (NumeroEscolha.Contains("0", 0))
            {
                NumeroEscolha = "2";
            }
            else
            {
                NumeroEscolha += "2";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 2;
            }
            else
            {
                numeroSalvo += 2;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_1(object sender, RoutedEventArgs e)
        {

            if (NumeroEscolha.Contains("0", 0))
            {
                NumeroEscolha = "1";
            }
            else
            {
                NumeroEscolha += "1";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 1;
            }
            else
            {
                numeroSalvo += 1;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_4(object sender, RoutedEventArgs e)
        {
            if (NumeroEscolha.StartsWith("0"))
            {
                NumeroEscolha = "4";
            }
            else
            {
                NumeroEscolha += "4";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 4;
            }
            else
            {
                numeroSalvo += 4;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_5(object sender, RoutedEventArgs e)
        {
            if (NumeroEscolha.StartsWith("0"))
            {
                NumeroEscolha = "5";
            }
            else
            {
                NumeroEscolha += "5";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 5;
            }
            else
            {
                numeroSalvo += 5;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_6(object sender, RoutedEventArgs e)
        {
            if (NumeroEscolha.StartsWith("0"))
            {
                NumeroEscolha = "6";
            }
            else
            {
                NumeroEscolha += "6";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 6;
            }
            else
            {
                numeroSalvo += 6;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_7(object sender, RoutedEventArgs e)
        {
            if (NumeroEscolha.StartsWith("0"))
            {
                NumeroEscolha = "7";
            }
            else
            {
                NumeroEscolha += "7";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 7;
            }
            else
            {
                numeroSalvo += 7;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_8(object sender, RoutedEventArgs e)
        {
            if (NumeroEscolha.StartsWith("0"))
            {
                NumeroEscolha = "8";
            }
            else
            {
                NumeroEscolha += "8";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 8;
            }
            else
            {
                numeroSalvo += 8;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_9(object sender, RoutedEventArgs e)
        {
            if (NumeroEscolha.StartsWith("0"))
            {
                NumeroEscolha = "9";
            }
            else
            {
                NumeroEscolha += "9";
            }

            if (numeroSalvo == 0)
            {
                numeroSalvo = 9;
            }
            else
            {
                numeroSalvo += 9;
            }

            text_numero.Text = NumeroEscolha;
        }

        private void digitar_subtracao(object sender, RoutedEventArgs e)
        {
            text_conta.Text += text_numero.Text + "-";
            text_numero.Text = "";

            EscolhaEquacao = 2;
        }

        private void digitar_multiplicacao(object sender, RoutedEventArgs e)
        {
            text_conta.Text += text_numero.Text + "x";
            text_numero.Text = "";

            EscolhaEquacao = 3;
        }

        private void digitar_divisao(object sender, RoutedEventArgs e)
        {
            EscolhaEquacao = 4;
        }

        private void digitar_D(object sender, RoutedEventArgs e)
        {
        }

        private void digitar_C(object sender, RoutedEventArgs e)
        {
            EstadoInicial();

        }

        private void digitar_CE(object sender, RoutedEventArgs e)
        {
            text_numero.Text = "";
        }
        private void EstadoInicial()
        {
            text_numero.Text = "";
            text_conta.Text = "";
            numero1 = 0;
            numero2 = 0;
            resultado = 0;
            proximoNumero = false;
        }

        private void PegarNumero()
        { 
            if (proximoNumero == false) 
            {
                numero1 = int.Parse(text_numero.Text);

            }
            else
            {
                numero2 = int.Parse(text_numero.Text);
            
            
            }
        
        }

        
    }
}
