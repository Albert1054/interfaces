using System;
using System.Collections.Generic;
using System.Text;
using InterfaceServices.Entities;

namespace InterfaceServices.Services
{
    class ContractService
    {
        public int Number { get; private set; }
        public ContractService(int number)
        {
            Number = number;
        }
        public void ProcessContract(Contract contract)
        {

        }
    }
}
