using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // D:\Daniel\Curso C#\Programação Orientada a Objetos\Seção 15 - Generics , Set e Dictionary\Exercício Set\in.txt

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                        
                    }
                   
                }
                Console.WriteLine("Total Users: " + set.Count);

                Console.ReadKey();
            }
            catch(IOException e )
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
