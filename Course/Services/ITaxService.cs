namespace Course.Services
{
    interface ITaxService
    {
        double IcmsValue(double amount, int icmsAliquot);
        double IpiValue(double amount, int ipiAliquot);
    }
}
