using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class RouteTest
    {
        private IRouteRepository routeRepository = new RouteRepository();

        [Test]
        public void Add()
        {
            Route route = new Route(0, "HCM", "HN", 500_000);
            routeRepository.Add(route);
            Assert.That(route.Id, Is.Not.EqualTo(0));
        }
    }
}
