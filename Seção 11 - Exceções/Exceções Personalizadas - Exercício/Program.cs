using Exceções_Personalizadas___Exercício.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceções_Personalizadas___Exercício.Entities.Exceptions;

namespace Exceções_Personalizadas___Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Room Number: ");
                int room = int.Parse(Console.ReadLine());

                Console.Write("Date of Check-In (dd/mm/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Date of Check-Out (dd/mm/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());



                Reservation reservation = new Reservation(room, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                Console.WriteLine("Enter the uptated reservation: ");
                Console.Write("Date of Check-In (dd/mm/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Date of Check-Out (dd/mm/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UptateDates(checkin, checkout);
            }

            catch(DomainException e)
            {
                Console.WriteLine("Error in reservations: " + e.Message);
            }

            Console.ReadKey();

        }
            
    }
    
}
