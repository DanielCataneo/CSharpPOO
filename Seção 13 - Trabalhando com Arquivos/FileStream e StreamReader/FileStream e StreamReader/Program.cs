using System;
using System.IO;

namespace FileStream_e_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\Daniel\file1.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
               
                // Lê todas as linhas de um arquivo
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            
            
            catch(IOException E)
            {
                Console.WriteLine("An error ocurred!! ");
                Console.WriteLine(E.Message);
            }
            
            // Fecha o arquivo obrigatoriamente
            finally
            {
                if(sr != null) sr.Close();
            }

            Console.ReadKey();

        }
    }
}
