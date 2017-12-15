using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqKit;
using Osbc.Entities;
using Osbc.EntityFramework;
using Osbc.WebHost.Services.Brokers.Read;

namespace Osbc.WebHost.Services.Brokers
{
    public class BrokerService : IBrokerService
    {
        IOsbcDbContext _osbDbContext;

        public BrokerService(IOsbcDbContext dbContext)
        {
            _osbDbContext = dbContext;
        }

        public BrokerServiceReadResponse Read(BrokerServiceReadRequest request)
        {
            IQueryable<Broker> items = _osbDbContext.Brokers;

            if (request.Where == null || request.Where.Length == 0)
                return new BrokerServiceReadResponse(
                    Map(items).ToArray());

            var predicate = PredicateBuilder.New<Broker>(true);
            foreach (var criteron in request.Where)
            {
                predicate = predicate.Or(x => x.Name == criteron.Name);
            }
            return new BrokerServiceReadResponse(
                Map(items.Where(predicate)).ToArray());
        }

        public static IEnumerable<BrokerServiceReadResponseItem> Map(IEnumerable<Broker> brokers)
        {
            foreach (var broker in brokers)
                yield return new BrokerServiceReadResponseItem(
                    broker.Name,
                    broker.Url);
        }
    }
}
