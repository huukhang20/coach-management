using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IPassengerRepository
    {
        IEnumerable<Passenger> GetAll();
        Passenger? GetById(string id);
        void Add(Passenger passenger);
        void Update(Passenger passenger);
        void Remove(string id);
    }
}
