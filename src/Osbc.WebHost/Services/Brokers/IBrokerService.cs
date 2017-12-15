using Osbc.WebHost.Services.Brokers.Read;
using System;
using System.Collections.Generic;
using System.Text;

namespace Osbc.WebHost.Services.Brokers
{
    public interface IBrokerService
    {
        BrokerServiceReadResponse Read(BrokerServiceReadRequest request);
    }
}
