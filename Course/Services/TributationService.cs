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

        public void ProcessInvoice(Invoice invoice ,double icmsAliquot, double ipiAliquot)
        {
            double price = invoice.Product.Price;
            double IcmsValue = _taxService.IcmsValue(price, icmsAliquot);
            double BaseWithIcms = price + IcmsValue;
            double IpiValue = _taxService.IpiValue(BaseWithIcms, ipiAliquot);
            invoice.IcmsValue = IcmsValue;
            invoice.BaseIpi = BaseWithIcms;
            invoice.IpiValue = IpiValue;
        }
    }
}
