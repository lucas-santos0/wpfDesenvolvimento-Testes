using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDesenvolvimento_Testes
{
    internal class Operacoes
    {
        //União entre dois conjuntos
        public int[] Uniao(int[] a, int[] b)
        {
            
            HashSet<int> resultado = new HashSet<int>();

            // Adiciona todos os elementos de A
            foreach (int item in a)
            {
                resultado.Add(item);
            }

            // Adiciona todos os elementos de B
            foreach (int item in b)
            {
                resultado.Add(item);
            }

            // Converte o HashSet em array e retorna
            return resultado.OrderBy(x => x).ToArray();
        }

        //Interseção entre dois conjuntos
        public int[] Interseccao(int[] a, int[] b)
        {
            //declaração da lista resultado
            List<int> resultadoList = new List<int>();

            //verifica cada item do conjunto A
            foreach (int item in a)
            {
                //se B contém o item de A, adiciona na lista de resultado
                if (b.Contains(item))
                {
                    resultadoList.Add(item);
                }
            }

            //retorna o resultado em forma de array
            return resultadoList.ToArray();
        }

        //Diferença entre dois conjuntos (A - B ou B - A)
        public int[] Diferenca(int[] a, int[] b)
        {
            //declaração da lista resultado
            List<int> resultadoList = new List<int>();

            //adiciona todos os itens de A na lista
            foreach (int item in a)
            {
                resultadoList.Add(item);
            }

            //remove da lista todos os itens que estão em B
            foreach (int item in b)
            {
                resultadoList.Remove(item);
            }

            //retorna o resultado em forma de array
            return resultadoList.ToArray();
        }

        //Verifica se B é subconjunto de A
        public int Subconjunto(int[] a, int[] b)
        {
            //inicializa a variável resultado
            int resultado = 0;

            //contador de elementos encontrados
            int i = 0;

            //percorre todos os itens de B
            foreach (int item in b)
            {
                //verifica se A contém todos os itens de B
                if (a.Contains(item))
                {
                    i++;
                }
            }

            //se todos os itens de B estão em A, então B é subconjunto de A
            if (i == b.Length)
            {
                resultado = 1;
            }

            //retorna 1 se for subconjunto ou 0 se não for
            return resultado;
        }
    }
}
