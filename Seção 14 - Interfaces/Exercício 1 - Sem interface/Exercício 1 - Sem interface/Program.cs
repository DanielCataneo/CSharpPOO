using System;
using System.Globalization;
using Exercício_1___Sem_interface.Entities;
using Exercício_1___Sem_interface.Services;

namespace Exercício_1___Sem_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("PickUp (dd/MM/yyyy hh:mm ): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine() , "dd/MM/yyyy HH:mm" , CultureInfo.InvariantCulture);

            Console.Write("Finish (dd/MM/yyyy hh:mm ): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start , finish, new Vehicle(model));

            Console.Write("Value per Hour: ");
            double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Value per Day: ");
            double valueDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalservice = new RentalService(valueHour, valueDay);

            rentalservice.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);

            Console.ReadKey();


        }
    }
}
