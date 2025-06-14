using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* HASH-SET
             * Ordem não Importa
             * Inserção, Remoção e Busca extremamente Rápida
             *  Armazenamento em Tabela Hash
             */



            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("TV"));

            // Não pode usar for em conjunto 

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();

        }
    }
}
