using System;
using System.Globalization;

namespace InterfaceServices.Entities
{
    class Installments
    {
        public DateTime Date { get; private set; }
        public double Value { get; private set; }

        public Installments(DateTime date, double value)
        {
            Date = date;
            Value = value;
        }
        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy")
                + " - "
                + Value.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
