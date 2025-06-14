using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1___While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            
            
            Console.Write("Digite sua senha: ");
            int senhad = int.Parse(Console.ReadLine());

            while (senhad != senha) 
            {
                Console.WriteLine("Senha inválida!!");
                
                Console.WriteLine("Digite a senha novamente: ");
                senhad = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido!!");

            Console.ReadKey();

        }
    }
}
