using System;
using Course.Entities;

namespace Course.Services
{
    internal class ContractService 
    {
        private IOnlinePaymentServices _onlinePaymentServices;

        public ContractService(IOnlinePaymentServices onlinePaymentServices)
        {
            _onlinePaymentServices = onlinePaymentServices;
        }

        public void ProcessContract(Contract contract , int months)
        {
            double BasicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double UptatedQuota = BasicQuota + _onlinePaymentServices.Interest(BasicQuota, i);
                double Total = UptatedQuota + _onlinePaymentServices.PaymentFee(UptatedQuota);
                contract.AddInstallemnt(new Installment(date, Total));
            }



        }
    }
}
