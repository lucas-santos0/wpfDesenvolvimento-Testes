using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfDesenvolvimento_Testes
{
    internal class Teste
    {
        public int ValidarModoDeTeste(TextBox Visor)
        {
            string texto = Visor.Text;
            int modo = 0;

            if (texto == "/tpOn")
            {
                modo = 1;
                return modo;
            }
            else if (texto == "/tpOff")
            {
                modo = 2;
                return modo;
            }
            else
            {
                return modo;
            }
        }
        public bool ModoDeTeste(TextBox Visor)
        {
            Teste teste = new Teste();
            string verificar = Visor.Text;
            bool resultado;
            
            try
            {
                switch (verificar)
                {
                    case "/tCriacao":

                        resultado = teste.TesteCriacaoDeConjuntos();
                        if (resultado)
                        {
                            MessageBox.Show(" Teste de Criação APROVADO!");
                        }
                        else
                        {
                            MessageBox.Show(" Teste de Criação FALHOU.");
                        }
                        return resultado;

                    case "/tRemocao":
                        resultado = teste.TesteRemocaoDeConjuntos();
                        if (resultado)
                        {
                            MessageBox.Show(" Teste de Remoção APROVADO!");
                        }
                        else
                        {
                            MessageBox.Show(" Teste de Remoção FALHOU.");
                        }
                        return resultado;

                    case "/tUniao":
                        resultado = teste.TesteUniaoDeConjuntos();
                        if (resultado)
                        {
                            MessageBox.Show(" Teste de União APROVADO!");
                        }
                        else
                        {
                            MessageBox.Show(" Teste de União FALHOU.");
                        }
                        return resultado;
                        

                    case "/tInterseccao":
                        resultado = teste.TesteInterseccaoDeConjuntos();
                        if (resultado)
                        {
                            MessageBox.Show(" Teste de Intersecção APROVADO!");
                        }
                        else
                        {
                            MessageBox.Show(" Teste de Interesecção FALHOU.");
                        }
                        return resultado;
                        

                    case "/tDiferenca":
                        resultado = teste.TesteDiferencaDeConjuntos();
                        if (resultado)
                        {
                            MessageBox.Show(" Teste de Diferença APROVADO!");
                        }
                        else
                        {
                            MessageBox.Show(" Teste de Diferença FALHOU.");
                        }
                        return resultado;
                       

                    case "/tSubconjunto":
                        resultado = teste.TesteSubconjuntoDeConjuntos();
                        if (resultado)
                        {
                            MessageBox.Show(" Teste de Subconjunto APROVADO!");
                        }
                        else
                        {
                            MessageBox.Show(" Teste de Subconjunto FALHOU.");
                        }
                        return resultado;
                        

                    case "/tFullTest":
                             resultado = teste.TesteCriacaoDeConjuntos();
                        bool resultado2 = teste.TesteRemocaoDeConjuntos();
                        bool resultado3 = teste.TesteUniaoDeConjuntos();
                        bool resultado4 = teste.TesteInterseccaoDeConjuntos();
                        bool resultado5 = teste.TesteDiferencaDeConjuntos();
                        bool resultado6 = teste.TesteSubconjuntoDeConjuntos();

                        if (resultado && resultado2 && resultado3 && resultado4 && resultado5 && resultado6)
                        {
                            MessageBox.Show(" TODOS OS TESTES FORAM APROVADOS!");
                        }
                        else
                        {
                            MessageBox.Show(" ALGUM DOS TESTES FALHOU.");
                        }
                        return resultado;


                }

                return false;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public bool TesteCriacaoDeConjuntos()
        {
            try
            {
                TextBox Visor = new TextBox();
                Visor.Text = "1,2,3,4,5";

                Label lblConjunto = new Label();
                lblConjunto.Content = null;

                int[] Conjunto = new int[20];

                Conjuntos conjuntos = new Conjuntos();

                conjuntos.AddConjunto(Visor, lblConjunto, Conjunto);


                return true;
            }
            catch (Exception) 
            
            { 
                return false; 
            }


        }
        public bool TesteRemocaoDeConjuntos()
        {
            try
            {
                TextBox Visor = new TextBox();
                Visor.Text = "1,2,3,4,5";

                int[] Conjunto = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Conjuntos conjuntos = new Conjuntos();

                conjuntos.RemoverConjunto(Visor, Conjunto);

                return true;
            }
            catch (Exception)

            {
                return false;
            }

        }

        public bool TesteUniaoDeConjuntos()
        {
            try
            {
                int[] conjunto1 = new int[] { 1, 2, 3, 4, 5 };
                int[] conjunto2 = new int[] { 6, 7, 8, 9, 10 };

                Operacoes operacao = new Operacoes();

                operacao.Uniao(conjunto1, conjunto2);


                return true;

            }
            catch (Exception)

            {
                return false;
            }

        }
        public bool TesteInterseccaoDeConjuntos()
        {
            try
            {
                int[] conjunto1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                int[] conjunto2 = new int[] { 3, 4, 5, 6, 7, 8, 9, 10 };

                Operacoes operacao = new Operacoes();

                operacao.Interseccao(conjunto1, conjunto2);

                return true;

            }
            catch (Exception)

            {
                return false;
            }


            }
        public bool TesteDiferencaDeConjuntos()
        {
            try
            {
                int[] conjunto1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                int[] conjunto2 = new int[] { 3, 4, 5, 6, 7, 8, 9, 10 };

                Operacoes operacao = new Operacoes();

                operacao.Diferenca(conjunto1, conjunto2);

                return true;

            }
            catch (Exception)

            {
                return false;
            }
        }
        public bool TesteSubconjuntoDeConjuntos()
        {
            try
            {
                int[] conjunto1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] conjunto2 = new int[] { 1, 2, 3, 4, 5 };

                Operacoes operacao = new Operacoes();

                operacao.Subconjunto(conjunto1, conjunto2);

                return true;
            }
            
            catch (Exception)

            {
                return false;
            }
        }

    }
    }
