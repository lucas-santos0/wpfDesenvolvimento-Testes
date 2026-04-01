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
using System.Windows.Shapes;

namespace WpfDesenvolvimento_Testes
{
    /// <summary>
    /// Lógica interna para WindowTeste.xaml
    /// </summary>
    public partial class WindowTeste : Window
    {
        int[] TConjuntoA = new int[20];
        int[] TConjuntoB = new int[20];

        public WindowTeste()
        {
            InitializeComponent();
        }

        //Adicionar no CONJUNTO A
        private void btnAddConjuntoA_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Conjuntos conjunto = new Conjuntos();

            //declarando o conjuntoB com o Método da Classe conjuntos
            TConjuntoA = conjunto.AddConjunto(txtVisor, lblConjuntoA, TConjuntoA);

        }

        //Adicionar no CONJUNTO B
        private void btnAddConjuntoB_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Conjuntos conjunto = new Conjuntos();

            //declarando o conjuntoB com o Método da Classe conjuntos
            TConjuntoB = conjunto.AddConjunto(txtVisor, lblConjuntoB, TConjuntoB);
        }

        private void btnUniao_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Conjuntos conjunto = new Conjuntos();

            //declaração da variavel da classe operaçoes
            Operacoes operacoes = new Operacoes();

            //declaração da variavel resultado com o Método da Classe Operacoes
            int[] resultado = operacoes.Uniao(TConjuntoA, TConjuntoB);

            lblresultado.Content = string.Join(", ", resultado);
        }

        //Mostrar INTERSECAO
        private void btnIntersecao_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Operacoes operacoes = new Operacoes();

            //declaração da variavel resultado com o Método da Classe Operacoes
            int[] resultado = operacoes.Interseccao(TConjuntoA, TConjuntoB);

            //Exibindo o Resultado 
            lblresultado.Content = string.Join(", ", resultado);
        }

        //Mostrar DIFERENÇA
        private void btnDiferencaAB_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Operacoes operacoes = new Operacoes();

            //declaração da variavel resultado com o Método da Classe Operacoes
            int[] resultado = operacoes.Diferenca(TConjuntoA, TConjuntoB);

            //Exibindo o Resultado 
            lblresultado.Content = string.Join(", ", resultado);

        }

        private void btnDiferencaBA_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Operacoes operacoes = new Operacoes();

            //declaração da variavel resultado com o Método da Classe Operacoes
            int[] resultado = operacoes.Diferenca(TConjuntoB, TConjuntoA);

            //Exibindo o Resultado 
            lblresultado.Content = string.Join(", ", resultado); ;

        }

        // Verificar SUBCONJUNTO
        private void btnVerificarSub_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Operacoes operacoes = new Operacoes();

            //declaração das 2 variaveis com o Método da Classe Operacoes
            int resultado1 = operacoes.Subconjunto(TConjuntoA, TConjuntoB);
            int resultado2 = operacoes.Subconjunto(TConjuntoB, TConjuntoA);

            if (resultado1 == resultado2)
            {
                //exibe o resultado para o usuario
                lblresultado.Content = ("Não há Subconjuntos");
            }

            else
            {
                if (resultado1 == 1)
                {
                    //exibe o resultado para o usuario
                    lblresultado.Content = ("B é Subconjunto de A");
                }
                else
                {
                    if (resultado2 == 1)
                    {
                        //exibe o resultado para o usuario
                        lblresultado.Content = ("A é Subconjunto de B");
                    }
                }
            }

        }

        //Limpa TUDO
        private void btnLimparTudo_Click(object sender, RoutedEventArgs e)
        {
            //Limpa o campo de resultado
            lblresultado.Content = null;
            //Limpa o campo do ConjuntoA
            lblConjuntoA.Content = null;
            //Limpa o campo do ConjuntoB
            lblConjuntoB.Content = null;
            //Limpa o ConjuntoA
            Array.Clear(TConjuntoA, 0, TConjuntoA.Length);
            //Limpa o ConjuntoB
            Array.Clear(TConjuntoB, 0, TConjuntoB.Length);

            txtVisor.Clear();

        }

        //Remove Valores do Array
        private void btnRemoverConjuntoA_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel 
            Conjuntos conjuntos = new Conjuntos();

            //chama o Método da Classe conjuntos para remover o valor
            TConjuntoA = conjuntos.RemoverConjunto(txtVisor, TConjuntoA);

            //atualiza o conteúdo do label com os novos valores
            lblConjuntoA.Content = string.Join("; ", TConjuntoA) + "; ";

            //limpa o campo de texto
            txtVisor.Clear();
        }

        private void btnRemoverConjuntoB_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel 
            Conjuntos conjuntos = new Conjuntos();

            //chama o Método da Classe conjuntos para remover o valor
            TConjuntoB = conjuntos.RemoverConjunto(txtVisor, TConjuntoB);

            //atualiza o conteúdo do label com os novos valores
            lblConjuntoB.Content = string.Join("; ", TConjuntoB) + "; ";

            //limpa o campo de texto
            txtVisor.Clear();
        }

        //Gerar Conjuntos Aleatórios
        private void btnConjuntoAleatorio_Click(object sender, RoutedEventArgs e)
        {


            //declaração da variavel da classe conjuntos
            Conjuntos conjuntos = new Conjuntos();

            //chama o Método que gera os dois conjuntos aleatórios
            (TConjuntoA, TConjuntoB) = conjuntos.AleatorioConjunto(txtAleatorios);

            //atualiza o conteúdo dos labels com os novos conjuntos
            lblConjuntoA.Content = string.Join("; ", TConjuntoA) + "; ";
            lblConjuntoB.Content = string.Join("; ", TConjuntoB) + "; ";

            //limpa o campo de entrada
            txtAleatorios.Clear();
        }

        private void pressionarBotao(object sender, KeyEventArgs e)
        {
            Teste teste = new Teste();

            if (e.Key == Key.Enter)
            {
                int validar;

                validar = teste.ValidarModoDeTeste(txtVisor);

                if (validar == 2)
                {
                    MainWindow janelaTeste = new MainWindow();
                    janelaTeste.Show();
                    this.Close();

                    MessageBox.Show("Modo de teste Desativado!");
                }
                else
                {
                    bool resultado = teste.ModoDeTeste(txtVisor);

                    
                }
            }
        }
    }
}
