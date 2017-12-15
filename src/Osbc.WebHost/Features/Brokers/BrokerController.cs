using Microsoft.AspNetCore.Mvc;
using Osbc.WebHost.Services.Brokers;
using Osbc.WebHost.Services.Brokers.Read;

namespace Osbc.WebHost.Features.Brokers
{
    public class BrokerController : Controller
    {
        public IBrokerService BrokerService { get; private set; }

        public BrokerController(IBrokerService brokerService)
        {
            BrokerService = brokerService;
        }

        public IActionResult Detail(string name)
        {
            var response = BrokerService.Read(
                new BrokerServiceReadRequest(
                    new[] 
                    {
                        new BrokerServiceReadCriterion(name)
                    }));
            if (response == null 
                || response.Brokers == null 
                || response.Brokers.Length == 0)
                return NotFound();

            return View(response.Brokers);
        }

        public IActionResult Index()
        {
            var response = BrokerService.Read(
                new BrokerServiceReadRequest(
                    new[]
                    {
                        new BrokerServiceReadCriterion()
                    }));

            return View(response.Brokers);
        }
    }
}