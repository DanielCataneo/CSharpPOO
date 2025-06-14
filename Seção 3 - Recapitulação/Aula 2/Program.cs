using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int nquarto;
            double preco;
            string dados;

            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            nquarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu ultimo nome, idade e altura na mesma linha: ");
            dados = (Console.ReadLine());

            string[] vet = dados.Split(' ');
            string ultnome = vet[0];
            string idade = vet[1];
            string altura = vet[2];

            Console.WriteLine(nome);
            Console.WriteLine(nquarto);
            Console.WriteLine($"{preco:F2}");
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);

            Console.ReadLine();




        }
    }
}
