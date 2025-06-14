using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try {

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
           
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error , division by 0 is not allowed!! " );
            }
            
            catch( FormatException f)
            {
                Console.WriteLine("Format error " + f.Message);
            }

            Console.ReadKey();
        }
    }
}
