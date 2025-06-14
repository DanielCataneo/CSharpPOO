using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Funções_Interessantes_para_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abc DEFGH ABC abc DEF   ";

            // Para transformar todos os caracteres de uma String em Maiúsulos
            string s1 = original.ToUpper();

            // Para transformar todos os caracteres de uma String em Minúsculos
            string s2 = original.ToLower();

            // Para retirar os espaços em branco antes e após a string
            string s3 = original.Trim();

            // Para achar a primeira incidência de algum parâmetro
            int n1 = original.IndexOf("bc");

            // Para achar a última incidência de algum parâmetro
            int n2 = original.LastIndexOf("bc");

            // Para dividir a string em outra string 
            string s4 = original.Substring(3);

            // Para dividir a string em outra dando início e ponto de parada
            string s5 = original.Substring(3, 5);

            // Para substituir uma letra dentro da string
            string s6 = original.Replace('a', 'x');

            // Para substituir uma string dentro da string
            string s7 = original.Replace("abc", "bec");

            // Para testar se a String é vazia ou nula
            bool b1 = String.IsNullOrEmpty(original);

            // Para testar se a String só têm espaços vazios 
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original:" + original);
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf (' bc '): " + n1);
            Console.WriteLine("LastIndexOf ('bc'): " + n2);
            Console.WriteLine("SubString(3): " + s4);
            Console.WriteLine("SubString(3, 5): " + s5);
            Console.WriteLine("Replace('a' , 'x'): " + s6);
            Console.WriteLine("Replace('abc' , 'bec'): " + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1 );
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);











            Console.ReadKey ();
        }
    }
}
