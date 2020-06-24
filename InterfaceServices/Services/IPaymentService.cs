using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceServices.Services
{
    interface IPaymentService
    {
        double Tax(double amount, int n);
    }
}
