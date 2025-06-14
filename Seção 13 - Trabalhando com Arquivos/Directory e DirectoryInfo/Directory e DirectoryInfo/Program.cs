using System;
using System.Collections.Generic;
using System.IO;

namespace Directory_e_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\Daniel\Folder";

            try 
            {
               var folders = Directory.EnumerateDirectories(path, "*.*" , SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(var folder in folders)
                {
                    Console.WriteLine(folder);
                }
                
                Console.WriteLine();
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\new folder");
            }
            
            
            
            catch (IOException e) {
                Console.WriteLine("An error Ocurred!! ");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
