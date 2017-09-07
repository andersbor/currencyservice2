using System.Collections.Generic;

namespace currencyService2
{
    public class Currencies
    {
        private readonly IDictionary<CurrencyCode, Currency> _currencies = new Dictionary<CurrencyCode, Currency>();

        public Currencies()
        {
            Currency aus = new Currency { Code = CurrencyCode.AUD, Name = "Australian Dollar", Rate = 4.7096 };
            Add(aus);
            Currency dkk = new Currency { Code = CurrencyCode.DKK, Name = "Danish Kroner", Rate = 1.0 };
            Add(dkk);
            Currency eur = new Currency { Code = CurrencyCode.EUR, Name = "Euro", Rate = 7.4638 };
            Add(eur);
            Currency usd = new Currency { Code = CurrencyCode.USD, Name = "US dollars", Rate = 6.6304 };
            Add(usd);
            Currency bgn = new Currency { Code = CurrencyCode.BGN, Name = "Bulgarian Leva", Rate = 3.8162 };
            Add(bgn);
            Currency sek = new Currency { Code = CurrencyCode.SEK, Name = "Swedish Kroner", Rate = 0.7817 };
            Add(sek);
            Currency nok = new Currency { Code = CurrencyCode.NOK, Name = "Norwegian Krone", Rate = 0.875 };
            Add(nok);
        }

        public bool Add(Currency currency)
        {
            CurrencyCode code = currency.Code;
            if (_currencies.ContainsKey(code))
            {
                return false;
            }
            _currencies[code] = currency;
            return true;
        }

        public Currency Get(CurrencyCode code)
        {
            if (_currencies.ContainsKey(code))
            {
                return _currencies[code];
            }
            return null;
        }

        public double Rate(CurrencyCode fromCode, CurrencyCode toCode)
        {
            Currency fromCurrency = Get(fromCode);
            Currency toCurrency = Get(toCode);
            if (fromCurrency == null || toCurrency == null) return -1.0;
            return fromCurrency.Rate / toCurrency.Rate;
        }
    }
}