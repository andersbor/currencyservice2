using System.Collections.Generic;
using System.ServiceModel;

namespace currencyService2
{
    [ServiceContract]
    public interface ICurrencyService
    {
        [OperationContract]
        double GetRate(CurrencyCode codeFrom, CurrencyCode codeTo);

        [OperationContract]
        ICollection<Currency> GetAllCurrencyInfos();
    }
}
