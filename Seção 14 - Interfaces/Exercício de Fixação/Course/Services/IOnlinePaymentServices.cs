using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    interface IOnlinePaymentServices
    {
       

        double Interest(double amount , int mounths);

        double PaymentFee(double amount);

    }
}
