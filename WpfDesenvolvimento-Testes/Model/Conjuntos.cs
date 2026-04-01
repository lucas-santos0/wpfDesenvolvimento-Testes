using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace WpfDesenvolvimento_Testes
{
    internal class Conjuntos
    {
        //Adicionar
        public int[] AddConjunto(TextBox Visor, Label lblConjunto, int[] Conjunto = null)
        {
            try
            {
                List<int> listaconjunto = new List<int>();
                
                listaconjunto.AddRange(Visor.Text.ToString().Split(',', ' ', ';')
                            .Select(s => s.Trim())
                            .Where(s => int.TryParse(s, out _))
                            .Select(int.Parse));

                listaconjunto.AddRange(lblConjunto.ToString().Split(',', ' ', ';')
                            .Select(s => s.Trim())
                            .Where(s => int.TryParse(s, out _))
                            .Select(int.Parse));



                Conjunto = listaconjunto.Distinct().OrderBy(x => x).ToArray();
                lblConjunto.Content = null;
                lblConjunto.Content += string.Join("; ", Conjunto);


                Visor.Clear();

                return Conjunto;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }
        }

        //Remover
        public int[] RemoverConjunto(TextBox txtVisor, int[] Conjunto)
        {
            try
            {
                //Cria uma lista para armazenar o resultado final
                List<int> resultadoList = new List<int>();

                //Lê os valores a serem removidos do campo txtVisor
                int[] remover = txtVisor.Text.Split(',')
                                .Select(s => s.Trim())
                                .Where(s => int.TryParse(s, out _))
                                .Select(int.Parse)
                                .ToArray();

                //Adiciona todos os valores do array original na lista
                foreach (int item in Conjunto)
                {
                    resultadoList.Add(item);
                }

                //Remove da lista os elementos informados pelo usuário
                foreach (int item in remover)
                {
                    resultadoList.Remove(item);
                }

                //Retorna o novo array após remoções
                return resultadoList.ToArray();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }

        }

        //Geração Aleatória
        public (int[], int[]) AleatorioConjunto(TextBox aleatorios)
        {
            int quant;

            try
            {
                // Tenta converter o texto em número; se vazio, usa 20
                quant = string.IsNullOrEmpty(aleatorios.Text) ? 20 : int.Parse(aleatorios.Text);

                // Validação: número deve estar entre 1 e 20
                if (quant <= 0 || quant > 20)
                {
                    MessageBox.Show("Erro: Valor fora de Escala\nCriando conjunto aleatório de 20 elementos.");
                    quant = 20;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ ex.Message + "\nCriando conjunto aleatório de 20 elementos.");
                quant = 20;
            }

            // Geração dos conjuntos (feito só uma vez)
            Random Aleatorio = new Random();

            HashSet<int> conjunto1 = new HashSet<int>();

            while (conjunto1.Count < quant)
            {
                conjunto1.Add(Aleatorio.Next(1, 100));
            }

            HashSet<int> conjunto2 = new HashSet<int>();

            while (conjunto2.Count < quant)
            {
                conjunto2.Add(Aleatorio.Next(1, 100));
            }

            int[] resultado1 = conjunto1.OrderBy(x => x).ToArray();
            int[] resultado2 = conjunto2.OrderBy(x => x).ToArray();

            return (resultado1, resultado2);
        }

    }
}
