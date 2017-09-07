﻿using System.Collections.Generic;
using System.Runtime.Serialization;
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

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
