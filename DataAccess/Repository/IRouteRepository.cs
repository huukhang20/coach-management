using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IRouteRepository
    {
        IEnumerable<Route> GetAll();
        Route? GetById(int id);
        void Add(Route route);
        void Update(Route route);
        void Remove(int id);
    }
}
