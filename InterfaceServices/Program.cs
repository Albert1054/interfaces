using System;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using InterfaceServices.Entities;
using InterfaceServices.Services;

namespace InterfaceServices
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter constract data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Contract value: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int installments = int.Parse(Console.ReadLine());

                Contract contract = new Contract(number,date,value);
                ContractService constractService = new ContractService(installments, new PaypalTaxService());

                constractService.ProcessContract(contract);

                Console.WriteLine("Installments: ");
                foreach(Installments i in contract.Installments)
                {
                    Console.WriteLine(i);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
