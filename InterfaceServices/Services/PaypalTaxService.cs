namespace InterfaceServices.Services
{
    class PaypalTaxService : IPaymentService
    {
        public double Tax(double amount, int n)
        {
            amount += ((amount * 0.01) * n);
            return amount + (amount * 0.02);
            
        }
    }
}
