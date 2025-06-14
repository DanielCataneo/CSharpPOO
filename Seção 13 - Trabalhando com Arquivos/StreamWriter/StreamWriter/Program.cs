using System;
using System.IO;
using System.Xml;

namespace Stream_Writer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"d:\Daniel\file1.txt";
            string targetPath = @"d:\Daniel\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                    using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }catch (Exception ex) {
                Console.WriteLine("An error ocurred!! ");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
                    
        }
              
    }
}
