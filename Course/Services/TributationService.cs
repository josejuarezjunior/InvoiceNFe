using System;
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

        public void ProcessInvoice(Product product, int icmsAliquot, int ipiAliquot)
        {
            double ValueWithoutTax = product.Value;
            double IcmsValue = _taxService.IcmsValue(ValueWithoutTax, icmsAliquot);
            double BaseIpi = ValueWithoutTax / (100 - icmsAliquot);
            double IpiValue = _taxService.IpiValue(BaseIpi, ipiAliquot);
            Invoice invoice = new Invoice(BaseIpi, IcmsValue, IpiValue);
        }
    }
}
