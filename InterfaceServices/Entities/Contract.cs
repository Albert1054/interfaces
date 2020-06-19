using System;
using System.Collections.Generic;

namespace InterfaceServices.Entities
{
    class Contract
    {
        public int NumberContract { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installments> installments { get; set; } = new List<Installments>();
        public Contract() { }

        public Contract(int number, DateTime date, double totalValue)
        {
            NumberContract = number;
            Date = date;
            TotalValue = totalValue;
        }
        
    }
}
