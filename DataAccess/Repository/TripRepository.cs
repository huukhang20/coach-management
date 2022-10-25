using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TripRepository : ITripRepository
    {
        public void Add(Trip trip) => TripDAO.Instance.Add(trip);

        public IEnumerable<Trip> GetAll() => TripDAO.Instance.GetAll();

        public Trip? GetById(long id) => TripDAO.Instance.GetById(id);

        public void Remove(long id) => TripDAO.Instance.Remove(id);

        public void Update(Trip trip) => TripDAO.Instance.Update(trip);
    }
}
