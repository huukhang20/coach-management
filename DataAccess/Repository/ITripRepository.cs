using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ITripRepository
    {
        IEnumerable<Trip> GetAll();
        Trip? GetById(long id);
        void Add(Trip trip);
        void Update(Trip trip);
        void Remove(long id);
    }
}
