﻿namespace currencyService2
{
    public enum CurrencyCode
    {
        AUD, BGN, EUR, SEK, DKK, USD, NOK, CZK
    }

    /// <summary>
    /// Currency class
    /// </summary>
    public class Currency
    {
        public CurrencyCode Code { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }

        public override string ToString()
        {
            return Code + " " + Name + " " + Rate;
        }
    }
}