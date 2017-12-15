using System;
using System.Collections.Generic;
using System.Text;

namespace Osbc.WebHost.Services.Brokers.Read
{
    public class BrokerServiceReadResponse
    {
        public BrokerServiceReadResponseItem[] Brokers { get; private set; }

        public BrokerServiceReadResponse(BrokerServiceReadResponseItem[] brokers)
        {
            Brokers = brokers;
        }
    }
}
