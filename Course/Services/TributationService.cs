using Course.Entities;

namespace Course.Services
{
    class TributationService
    {
        private ITaxService _taxService;

        public TributationService(ITaxService taxService)
        {
            _taxService = taxService;
        }

        public void ProcessInvoice(Invoice invoice ,double value, double icmsAliquot, double ipiAliquot)
        {
            double IcmsValue = _taxService.IcmsValue(value, icmsAliquot);
            double BaseWithIcms = value + IcmsValue;
            double IpiValue = _taxService.IpiValue(BaseWithIcms, ipiAliquot);
            invoice.IcmsValue = IcmsValue;
            invoice.BaseIpi = BaseWithIcms;
            invoice.IpiValue = IpiValue;
        }
    }
}
