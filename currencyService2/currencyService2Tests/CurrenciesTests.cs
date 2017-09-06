using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace currencyService2.Tests
{
    [TestClass]
    public class CurrenciesTests
    {
        [TestMethod]
        public void CurrenciesTest()
        {
            Currencies cur = new Currencies();
            double rate = cur.Rate(CurrencyCode.DKK, CurrencyCode.DKK);
            Assert.AreEqual(1.0, rate, 0.001);
            rate = cur.Rate(CurrencyCode.USD, CurrencyCode.DKK);
            Assert.AreEqual(6.6304, rate, 0.01);
            rate = cur.Rate(CurrencyCode.DKK, CurrencyCode.USD);
            Assert.AreEqual(0.1508, rate, 0.01);
            rate = cur.Rate(CurrencyCode.EUR, CurrencyCode.USD);
            Assert.AreEqual(1.126, rate, 0.01);
            rate = cur.Rate(CurrencyCode.SEK, CurrencyCode.EUR);
            Assert.AreEqual(0.104, rate, 0.01);
        }
    }
}