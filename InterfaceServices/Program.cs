using System;
using System.Globalization;

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
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
