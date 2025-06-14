using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teste_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            string sourcePath = @"d:\Daniel\file1.txt";
            string targetPtah = @"d:\Daniel\file2.txt";

            try
            {

                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPtah);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }


            catch (IOException ex) {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
