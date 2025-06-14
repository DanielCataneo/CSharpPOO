using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Fixação___Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Hospede[] Quartos = new Hospede[10];

            Console.WriteLine("Quantos quartos serão alugaos: ");
            int N = int.Parse(Console.ReadLine());

            Hospede[] hosp = new Hospede[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite o nome do hóspede: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o email do hospede: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o número do quarto que deseja se hospedar: ");
                int quarto = int.Parse(Console.ReadLine());
                Quartos[quarto] = new Hospede(nome, email);


                
            }

            for (int i = 0; i < 10; i++)
            {
                if (Quartos[i] != null)
                {
                    Console.WriteLine("Quartos Ocupados: ");
                    Console.WriteLine(i + " , : " + Quartos[i] );
                }
                
            }
        
        Console.ReadKey();
        
        
        }
    }
}
