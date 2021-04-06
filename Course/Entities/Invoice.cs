using System;
using System.Globalization;

namespace Course.Entities
{
    class Invoice
    {
        public double BasicValue;
        public Product Product;
        public double BaseIpi;
        public double IcmsValue;
        public double IpiValue;
        public double TotaInvoice
        {
            get { return BaseIpi + IpiValue; }
        }

        public Invoice(Product product)
        {
            Product = product;
        }

        public Invoice(double baseIpi, double icmsValue, double ipiValue, Product product)
        {
            BaseIpi = baseIpi;
            IcmsValue = icmsValue;
            IpiValue = ipiValue;
            Product = product;
        }

        public override string ToString()
        {
            return "Product: "
                + Product
                + "\nBase value: "
                +BaseIpi.ToString("F2", CultureInfo.InvariantCulture)
                + "\nICMS value: "
                +IcmsValue.ToString("F2", CultureInfo.InvariantCulture)
                + "\nIPI value: "
                +IpiValue.ToString("F2", CultureInfo.InvariantCulture)
                +"\nTotal invoice:"
                +TotaInvoice.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}