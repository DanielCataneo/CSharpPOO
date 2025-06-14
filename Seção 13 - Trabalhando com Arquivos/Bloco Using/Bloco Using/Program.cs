using System;
using System.Collections.Generic;
using System.IO;

namespace Bloco_Using
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"d:\Daniel\file1.txt";
            List<string> list = new List<string>();
            

            try {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(',');
                        string nome = lines[0];
                        int idade = int.Parse(lines[1]);
                        list.Add("Nome: " + nome + " " + "Idade: " + idade);
                        list.Sort();
                    }
                }
                foreach (string line in list)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex) 
            {
                Console.WriteLine("An error ocurred!! ");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
