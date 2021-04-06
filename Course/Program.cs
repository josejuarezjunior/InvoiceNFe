using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invoice ");
            Console.WriteLine();

            Console.Write("Type product name: ");
            string nameProduct = Console.ReadLine();
            Console.Write("Type product value before ICMS: ");
            double valueProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Product product = new Product(nameProduct);
            Invoice myInvoice = new Invoice(new Product(nameProduct,valueProduct));

            Console.Write("Type ICMS aliquot: ");
            double icmsAliquot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Type IPI aliquot: ");
            double ipiAliquot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TributationService tributationService = new TributationService(new BrazilTaxService());
            tributationService.ProcessInvoice(myInvoice, icmsAliquot, ipiAliquot);

            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString("D"));

            Console.WriteLine();
            Console.WriteLine(myInvoice);


        }
    }
}
