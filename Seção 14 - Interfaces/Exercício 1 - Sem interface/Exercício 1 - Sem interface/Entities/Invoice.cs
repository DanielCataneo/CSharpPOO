using System;
using System.Globalization;
namespace Exercício_1___Sem_interface.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }

        public double Tax { get; set; }


        public Invoice() { }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double Payment()
        {
            return BasicPayment + Tax;
        }

        public override string ToString()
        {
            return "Basic payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) +
            "\nTax: " + Tax.ToString("f2", CultureInfo.InvariantCulture) +
            "\nTotal Payment: " + Payment().ToString("f2", CultureInfo.InvariantCulture);

        }
    }
}
    
