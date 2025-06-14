using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeKind_e_padrão_ISO_8601
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para colocar as horas no Fuso Horário Local
            DateTime d1 = new DateTime(2024, 07, 06, 21, 07, 58, DateTimeKind.Local);
            
            // Para colocar as horas no Fuso Horário Universal UTC
            DateTime d2 = new DateTime(2024, 07 , 06, 21 , 07 , 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2024, 07, 06, 21 , 07 , 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 Local Time: " + d1.ToLocalTime());
            Console.WriteLine("d1 UTC: " + d1.ToUniversalTime());
            Console.WriteLine("------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 Local Time: " + d2.ToLocalTime());
            Console.WriteLine("d2 UTC: " + d2.ToUniversalTime());
            Console.WriteLine("------------------");
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 Local Time: " + d3.ToLocalTime());
            Console.WriteLine("d3 UTC: " + d3.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("Padrão ISO 8601");
            
            // Padrão ISO 8601 
            // Formato: yyyy-MM-ddTHH:mm:ssZ 
            // Z indica que está no horário UTC 

            DateTime D1 = DateTime.Parse("2024-06-15 21:22:01");
         
            // Padrão ISO 8601
            DateTime D2 = DateTime.Parse("2024-06-15T21:22:01Z");

            Console.WriteLine("D1: " + D1);
            Console.WriteLine("D1 Kind: " + D1.Kind);
            Console.WriteLine("D1 Local Time: " + D1.ToLocalTime());
            Console.WriteLine("D1 UTC: " + D1.ToUniversalTime());
            Console.WriteLine("------------------");
            Console.WriteLine("D2: " + D2);
            Console.WriteLine("D2 Kind: " + D2.Kind);
            Console.WriteLine("D2 Local Time: " + D2.ToLocalTime());
            Console.WriteLine("D2 UTC: " + D2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(D2.ToString("yyyy-MM-ddTHH:mm:ssz")); //CUIDADO!!
            Console.WriteLine(D2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.ReadKey();
        }
    }
}
