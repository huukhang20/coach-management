using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PassengerRepository : IPassengerRepository
    {
        public void Add(Passenger passenger) => PassengerDAO.Instance.Add(passenger);

        public IEnumerable<Passenger> GetAll() => PassengerDAO.Instance.GetAll();

        public Passenger? GetById(string id) => PassengerDAO.Instance.GetById(id);

        public void Remove(string id) => PassengerDAO.Instance.Remove(id);

        public void Update(Passenger passenger) => PassengerDAO.Instance.Update(passenger);
    }
}
