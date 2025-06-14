using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;


namespace Problema_Ex_2___Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Qual a quantiade de produtos: ");
            N = int.Parse(Console.ReadLine());

            Produto[] p = new Produto[N];

            for ( int i = 0; i < N; i++ )
            {
                Console.WriteLine("Digite o Nome do Produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o Preço do Produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                p[i] = new Produto { Nome = nome , Preco = preco};
   
            }

            double soma = 0.0;

            for ( int i = 0; i < N;i++ )
            {
                soma += p[i].Preco;    
            }

            Console.WriteLine(p);
            
            Console.WriteLine("A média do valor dos produtos é: " + (soma / N).ToString("f2" , CultureInfo.InvariantCulture));    
        
            Console.ReadKey();
        }

        

    }
}
