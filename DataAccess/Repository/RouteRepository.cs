using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RouteRepository : IRouteRepository
    {
        public void Add(Route route) => RouteDAO.Instance.Add(route);

        public IEnumerable<Route> GetAll() => RouteDAO.Instance.GetAll();

        public Route? GetById(int id) => RouteDAO.Instance.GetById(id);

        public void Remove(int id) => RouteDAO.Instance.Remove(id);

        public void Update(Route route) => RouteDAO.Instance.Update(route);
    }
}
