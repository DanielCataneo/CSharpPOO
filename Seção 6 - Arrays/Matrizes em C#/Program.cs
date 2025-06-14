using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para inicializar uma matriz de N linhas por M colunas
            double[,] mat = new double[2, 3];

            //Para verificar o Tamanho da matriz
            Console.WriteLine(mat.Length);

            //Para verificar a quantidade de linhas contidas na matriz
            Console.WriteLine(mat.Rank);

            //Para verificar a quantidade de linhas contidas em um parâmetro específico
            Console.WriteLine(mat.GetLength(0));

            //Para verificar a quantidade de colunas contidas na matriz
            Console.WriteLine(mat.GetLength(1));
                
            Console.ReadKey();

        }
    }
}
