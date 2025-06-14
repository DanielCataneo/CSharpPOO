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
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 } ;
            SortedSet<int> b = new SortedSet<int>() { 5 , 6 , 7, 8, 9, 10 } ;

            // União de conjuntos
            // Elementos que não existem em a mas existem em b serão adicionados
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // Intersecção de conjuntos
            // Elementos que existem nos dois conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // Diferença de conjuntos
            // Elementos de a excluídos os elementos de b
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

            Console.ReadKey();
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T ob in collection)
            {
                Console.Write(ob + " ");
            }
            Console.WriteLine();
            
        }

        
    }
}
