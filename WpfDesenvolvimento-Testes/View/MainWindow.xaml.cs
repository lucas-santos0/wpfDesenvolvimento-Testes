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
using static System.Net.Mime.MediaTypeNames;

namespace WpfDesenvolvimento_Testes
{

    public partial class MainWindow : Window
    {
        //Declarando os conjuntos
        int[] ConjuntoA = new int[20];
        int[] ConjuntoB = new int[20];
        
        

        public MainWindow()
        {
            InitializeComponent();
        }

        //Adicionar no CONJUNTO A
        private void btnAddConjuntoA_Click(object sender, RoutedEventArgs e)
        {
                //declaração da variavel da classe conjuntos
                Conjuntos conjunto = new Conjuntos();

                //declarando o conjuntoB com o Método da Classe conjuntos
                ConjuntoA = conjunto.AddConjunto(txtVisor, lblConjuntoA, ConjuntoA);

        }

        //Adicionar no CONJUNTO B
        private void btnAddConjuntoB_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Conjuntos conjunto = new Conjuntos();

            //declarando o conjuntoB com o Método da Classe conjuntos
            ConjuntoB = conjunto.AddConjunto(txtVisor, lblConjuntoB, ConjuntoB);
        }

        private void btnUniao_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Conjuntos conjunto = new Conjuntos();

            //declaração da variavel da classe operaçoes
            Operacoes operacoes = new Operacoes();

            //declaração da variavel resultado com o Método da Classe Operacoes
            int[] resultado = operacoes.Uniao(ConjuntoA, ConjuntoB);

            lblresultado.Content = string.Join(", ", resultado);
        }

        //Mostrar INTERSECAO
        private void btnIntersecao_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Operacoes operacoes = new Operacoes();

            //declaração da variavel resultado com o Método da Classe Operacoes
            int[] resultado = operacoes.Interseccao(ConjuntoA, ConjuntoB);

            //Exibindo o Resultado 
            lblresultado.Content = string.Join(", ", resultado);
        }

        //Mostrar DIFERENÇA
        private void btnDiferencaAB_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Operacoes operacoes = new Operacoes();

            //declaração da variavel resultado com o Método da Classe Operacoes
            int[] resultado = operacoes.Diferenca(ConjuntoA, ConjuntoB);

            //Exibindo o Resultado 
            lblresultado.Content = string.Join(", ", resultado);

        }

        private void btnDiferencaBA_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Operacoes operacoes = new Operacoes();

            //declaração da variavel resultado com o Método da Classe Operacoes
            int[] resultado = operacoes.Diferenca(ConjuntoB, ConjuntoA);

            //Exibindo o Resultado 
            lblresultado.Content = string.Join(", ", resultado); ;

        }

        // Verificar SUBCONJUNTO
        private void btnVerificarSub_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel da classe conjuntos
            Operacoes operacoes = new Operacoes();

            //declaração das 2 variaveis com o Método da Classe Operacoes
            int resultado1 = operacoes.Subconjunto(ConjuntoA, ConjuntoB);
            int resultado2 = operacoes.Subconjunto(ConjuntoB, ConjuntoA);

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
            Array.Clear(ConjuntoA, 0, ConjuntoA.Length);
            //Limpa o ConjuntoB
            Array.Clear(ConjuntoB, 0, ConjuntoB.Length);
            txtVisor.Clear();


        }

        //Remove Valores do Array
        private void btnRemoverConjuntoA_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel 
            Conjuntos conjuntos = new Conjuntos();

            //chama o Método da Classe conjuntos para remover o valor
            ConjuntoA = conjuntos.RemoverConjunto(txtVisor, ConjuntoA);

            //atualiza o conteúdo do label com os novos valores
            lblConjuntoA.Content = string.Join("; ", ConjuntoA) + "; ";

            //limpa o campo de texto
            txtVisor.Clear();
        }

        private void btnRemoverConjuntoB_Click(object sender, RoutedEventArgs e)
        {
            //declaração da variavel 
            Conjuntos conjuntos = new Conjuntos();

            //chama o Método da Classe conjuntos para remover o valor
            ConjuntoB = conjuntos.RemoverConjunto(txtVisor, ConjuntoB);

            //atualiza o conteúdo do label com os novos valores
            lblConjuntoB.Content = string.Join("; ", ConjuntoB) + "; ";

            //limpa o campo de texto
            txtVisor.Clear();
        }

        //Gerar Conjuntos Aleatórios
        private void btnConjuntoAleatorio_Click(object sender, RoutedEventArgs e)
        {
           

            //declaração da variavel da classe conjuntos
            Conjuntos conjuntos = new Conjuntos();

            //chama o Método que gera os dois conjuntos aleatórios
            (ConjuntoA, ConjuntoB) = conjuntos.AleatorioConjunto(txtAleatorios);

            //atualiza o conteúdo dos labels com os novos conjuntos
            lblConjuntoA.Content = string.Join("; ", ConjuntoA) + "; ";
            lblConjuntoB.Content = string.Join("; ", ConjuntoB) + "; ";

            //limpa o campo de entrada
            txtAleatorios.Clear();
        }
        
        private void pressionarBotao(object sender, KeyEventArgs e)
        {
            Teste teste = new Teste();

            if (e.Key == Key.Enter)
            {
                    int resultado = teste.ValidarModoDeTeste(txtVisor);

                if (resultado == 1)
                {
                    WindowTeste janelaTeste = new WindowTeste(); 
                    janelaTeste.Show();
                    this.Close(); 

                    MessageBox.Show("Modo de teste Ativado!");
                }
                }
                
            }
        }
    }

