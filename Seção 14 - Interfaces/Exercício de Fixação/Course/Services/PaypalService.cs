using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    internal class PaypalService : IOnlinePaymentServices
    {
        private double MonthlyInterest = 0.01;
        private double Paymentfee = 0.02;

        public double Interest(double amount , int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * Paymentfee;
        }

    }
}
