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
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            //       TKey     TValue
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";

            // Dictionary não aceita repetição de valores , phone será sobreposto
            cookies["phone"] = "99771133";

            Console.WriteLine("Phone Number: " + cookies["phone"]);

            // Verificar se existe algum item dentro do Dictionary
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size : " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");

            // Para fazer a leitura de um Dictionary
            foreach(KeyValuePair<string, string> kvp in cookies)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }

            Console.ReadKey();
        }
    }
}
