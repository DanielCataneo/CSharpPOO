using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Date_Time___Representando_Data_e_Hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostra o Dia/Mês/Ano e As Horas no Fuso-Horário Local 
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            // Mostra as datas e horas com construtotes
            DateTime d2 = new DateTime(2024 , 07 , 06 ) ;
            DateTime d3 = new DateTime(2024, 07, 06, 15, 17, 38);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            // Mostra o dia atual as 00:00 horas
            DateTime d4 = DateTime.Today;
            Console.WriteLine(d4);

            // Mostra o dia atual com o horário do Meridiano de GreenWich 
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d5);

            // Converte uma data String para DateTime
            DateTime d6 = DateTime.Parse("2024-07-06");
            Console.WriteLine(d6);
           
            // Com Horas também
            DateTime d7 = DateTime.Parse("2024-07-06 15:31:08");
            Console.WriteLine(d7);

            // Com modelo de data brasileiro
            DateTime d8 = DateTime.Parse("06/07/2024");
            Console.WriteLine(d8);
           
            // Com horas também 
            DateTime d9 = DateTime.Parse("06/07/2024 15:33:08 " );
            Console.WriteLine(d9);


            // Parse.Exact: Usa o modelo do país para o formato das Datas
            DateTime d10 = DateTime.ParseExact("2024-07-06", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);
            
            // Com horas
            DateTime d11 = DateTime.ParseExact("2024-07-06 15:47:31", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
            
            
            Console.ReadKey();
        }
    }
}
