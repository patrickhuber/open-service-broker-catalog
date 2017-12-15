using System;
using System.Collections.Generic;
using System.Text;

namespace Osbc.WebHost.Services.Brokers.Read
{
    public class BrokerServiceReadCriterion
    {
        public string Name { get; set; }

        public BrokerServiceReadCriterion() { }
        public BrokerServiceReadCriterion(string name)
        {
            Name = name;
        }
    }
}
