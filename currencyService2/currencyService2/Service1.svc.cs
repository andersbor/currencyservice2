using System.Collections.Generic;

namespace currencyService2
{
    public class CurrencyService : ICurrencyService
    {
        private static readonly Currencies currencies = new Currencies();

        public double GetRate(CurrencyCode codeFrom, CurrencyCode codeTo)
        {
            return currencies.Rate(codeFrom, codeTo);
        }

        public ICollection<Currency> GetAllCurrencyInfos()
        {
            return currencies.GetCurrencies();
        }
    }
}
