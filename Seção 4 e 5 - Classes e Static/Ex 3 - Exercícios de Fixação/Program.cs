using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_3___Exercícios_de_Fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new  Aluno();

            Console.Write("Digite o nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a Nota 1 do Aluno: ");
            aluno.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a Nota 2 do Aluno: ");
            aluno.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a Nota 3 do Aluno: ");
            aluno.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A sua nota final é: " + aluno.MediaNota().ToString("f2", CultureInfo.InvariantCulture));

            if (aluno.MediaNota() >= 60.00)
                Console.WriteLine("APROVADO");

            else 
            {
            
                Console.WriteLine("REPROVADO");
                double NotaParaPassar = (60.00 - aluno.MediaNota());

                     

                Console.WriteLine($"\nVocê precisa de: {NotaParaPassar.ToString("F2" , CultureInfo.InvariantCulture)} Pontos" );
        
            }

            Console.ReadKey();

        }
    }
}
