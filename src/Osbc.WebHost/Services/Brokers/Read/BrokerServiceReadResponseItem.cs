using System;
using System.Collections.Generic;
using System.Text;

namespace Osbc.WebHost.Services.Brokers.Read
{
    public class BrokerServiceReadResponseItem
    {
        public string Name { get; set; }
        public Uri Url { get; set; }

        public BrokerServiceReadResponseItem() { }

        public BrokerServiceReadResponseItem(string name, Uri url)
        {
            Name = name;
            Url = url;
        }
    }
}
