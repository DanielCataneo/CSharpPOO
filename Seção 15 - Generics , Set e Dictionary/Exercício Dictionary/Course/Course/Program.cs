using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // D:\Daniel\Curso C#\Programação Orientada a Objetos\Seção 15 - Generics , Set e Dictionary\Exercício Dictionary\in.txt

            Console.Write("Enter the fill full path: ");
            string path = Console.ReadLine();

            Dictionary<string , int> valores = new Dictionary<string , int>();

            

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');

                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        

                        // if Para evitar que seja feita a soma dos votos de todos os canditados
                        if(valores.ContainsKey(name))
                        {
                            valores[name] += votes;
                        }
                        else
                        {
                            valores[name] = votes;
                        }
                      
                    }
                    foreach(var item in valores)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }

                }

                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }


        }
    }
}
