namespace Course.Services
{
    internal class Invoice
    {
        private double baseIpi;
        private double icmsValue;
        private double ipiValue;

        public Invoice(double baseIpi, double icmsValue, double ipiValue)
        {
            this.baseIpi = baseIpi;
            this.icmsValue = icmsValue;
            this.ipiValue = ipiValue;
        }
    }
}