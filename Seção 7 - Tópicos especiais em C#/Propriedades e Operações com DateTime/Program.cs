using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Propriedades_e_Operações_com_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2024 , 07, 06, 18, 44, 38, 275);

            Console.WriteLine(d1);

            // Mostra a data
            Console.WriteLine("1) Date: " + d1.Date);

            // Mostra só o dia
            Console.WriteLine("2) Day: " + d1.Day);

            // Mostra o dia da semana
            Console.WriteLine("3) Day of the Week: " + d1.DayOfWeek);

            // Mostra o dia do ano
            Console.WriteLine("4) Day of the Year: " + d1.DayOfYear);

            // Mostra a hora
            Console.WriteLine("5) Hour: " + d1.Hour);

            // Mostra o fuso horário
            Console.WriteLine("6) Kind: " + d1.Kind);

            // Mostra os milisegundos
            Console.WriteLine("7) Milliseconds: " + d1.Millisecond);

            // Mostra os minutos
            Console.WriteLine("8) Minute: " + d1.Minute);

            // Mostra o mês
            Console.WriteLine("9) Month: " + d1.Month);

            // Mostra os segundos
            Console.WriteLine("10) Seconds: " + d1.Second);

            // Mostra a hora do dia
            Console.WriteLine("11) TimeOfDay: " + d1.TimeOfDay);

            // Mostra o ano 
            Console.WriteLine("13) Year: " + d1.Year);

            // Escreve a data de maneira extensa
            string s1 = d1.ToLongDateString();
            Console.WriteLine("14) ToLongDateString: " + s1);

            // Escreve as horas de maneira extensa
            string s2 = d1.ToLongTimeString();
            Console.WriteLine("15) ToLongTimeString: " + s2);

            // Escreve a data de maneira enxuta
            string s3  = d1.ToShortDateString();
            Console.WriteLine("16) ToShortDateString: " + s3);

            // Escreve as horas de maneira enxuta
            string s4 = d1.ToShortTimeString();
            Console.WriteLine("17) ToShortTimeString: " + s4);

            // Para informar uma máscara de formatação
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(s6);
            



            Console.ReadKey();
        }
    }
}
