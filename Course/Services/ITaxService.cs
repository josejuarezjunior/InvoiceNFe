namespace Course.Services
{
    interface ITaxService
    {
        double IcmsValue(double amount, double icmsAliquot);
        double IpiValue(double amount, double ipiAliquot);
    }
}
