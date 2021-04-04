using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    class BrazilTaxService : ITaxService
    {
        public double IcmsValue(double amount, int icmsAliquot)
        {
            return (amount / ((100-icmsAliquot)/100)) * (icmsAliquot/100);
        }
        public double IpiValue(double amount, int ipiAliquot)
        {
            return amount * (ipiAliquot/100);
        }

        /*
         * Example:
         * 
         * Value without ICMS:   80.00
         * ICMS aliquot:         12% = 12/100 = 0.12
         * ICMS base:            80.00 / (100-12) = 80.00 / 0.88 = 90.91
         * ICMS value:           90.91 * 0.12 = 10.91
         * 
         * IPI base:             90.91
         * IPI aliquot:          18% = 18/100 = 0.18
         * IPI value:            90.91 * 0.18 = 16.36
         * 
         * Invoice Total:        90.91 + 16.36 = 107,27 (IPI base + IPI value)
         */
    }
}
