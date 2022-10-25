using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RouteDAO
    {
        private static RouteDAO? instance;
        private static readonly object instanceLock = new object();
        private RouteDAO() { }
        public static RouteDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new RouteDAO();
                    return instance;
                }
            }
        }

        public IEnumerable<Route> GetAll()
        {
            using var context = new CoachManagementContext();
            var list = context.Routes.ToList();
            return list;
        }

        public Route? GetById(int id)
        {
            using var context = new CoachManagementContext();
            var route = context.Routes.SingleOrDefault(c => c.Id == id);
            return route;
        }

        public void Add(Route route)
        {
            Route? oldRoute = GetById(route.Id);
            if (oldRoute == null)
            {
                using var context = new CoachManagementContext();
                context.Routes.Add(route);
                context.SaveChanges();
            }
            else throw new Exception("The id already exists");
        }

        public void Update(Route route)
        {
            Route? oldRoute = GetById(route.Id);
            if (oldRoute != null)
            {
                using var context = new CoachManagementContext();
                context.Routes.Update(route);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }

        public void Remove(int id)
        {
            var route = GetById(id);
            if (route != null)
            {
                using var context = new CoachManagementContext();
                context.Routes.Remove(route);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }
    }
}
