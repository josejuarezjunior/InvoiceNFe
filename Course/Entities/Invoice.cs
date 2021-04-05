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

        public Invoice(Product product, double basicValue)
        {
            Product = product;
            BasicValue = basicValue;
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
                +", Base value: "
                +BaseIpi
                +", ICMS value: " +
                +IcmsValue
                +", IPI value: "
                +IpiValue;
        }
    }
}