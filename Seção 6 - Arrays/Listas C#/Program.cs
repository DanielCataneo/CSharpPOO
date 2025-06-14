using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Listas_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string > list  = new List<string>();

            // Adiciona elementos na Lista de maneira continua
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
           
            // Adiciona elementos na lista em uma determinada posição
            list.Insert(2, "Marco");

            // Mostra na tela a Lista
            foreach (string item in list)
            {
                Console.WriteLine(item);

            }
            
            // Conta a quantidade de elementos dentro de uma lista
            Console.WriteLine("List count:" + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            // Acha a PRIMEIRA ocorrência
            Console.WriteLine("First A: " + s1);
           
            string s2 = list.FindLast(x => x[0] == 'A');
            // Acha a ÚLTIMA ocorrência
            Console.WriteLine("Last A: " + s2);

            
            int pos1 = list.FindIndex(x => x[0] == 'A');
            // Acha a PRIMEIRA ocorrência e devolve o número da posição 
            Console.WriteLine("Index found on position: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            // Acha a ÚLTIMA ocorrência e devolve o número da posição
            Console.WriteLine("Index found on position: " + pos2);

            // Para filtrar Resultados em uma nova lista

            List <string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------");

            foreach ( string item2 in list2)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("--------------------------");

            // Para remover algum item determinado da lista 
            list.RemoveAt(1);
            foreach( string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");
            
            // Para remover TODOS os itens da lista baseado em algum parâmetro
            list.RemoveAll(x => x[0] == 'M');
            
            foreach ( string item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("------------------------------");
            // Para remover um elemento baseado por sua posição
            list.RemoveAt(0);
            foreach ( string item in list)
            {
                Console.WriteLine(item);
            }

            // Para remover elementos em algum intervalo
            list.RemoveRange(0, 1);
            foreach ( string item in list)
            {
                Console.WriteLine(item);
            }













            Console.ReadKey();

        }

    }
}
