using System;
using System.Collections.Generic;
using System.Text;

namespace Osbc.WebHost.Services.Brokers.Read
{
    public class BrokerServiceReadRequest
    {
        public BrokerServiceReadCriterion[] Where { get; }

        public BrokerServiceReadRequest() { }

        public BrokerServiceReadRequest(BrokerServiceReadCriterion[] where)
        {
            Where = where;
        }
    }
}
