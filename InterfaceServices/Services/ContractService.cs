using System;
using InterfaceServices.Entities;

namespace InterfaceServices.Services
{
    class ContractService
    {
        public int Number { get; private set; }

        private IPaymentService _paymentService;
        public ContractService(int number, IPaymentService paymentService)
        {
            Number = number;
            _paymentService = paymentService;
        }
        public void ProcessContract(Contract contract)
        {
            double valueInstallment = contract.TotalValue / Number;
            for(int i = 1; i <= Number; i++)
            {
                DateTime newDate = contract.Date.AddMonths(i);
                double v = _paymentService.Tax(valueInstallment, i);
                Installments installment = new Installments(newDate, v);
                contract.AddInstallments(installment);
            }
        }
    }
}
