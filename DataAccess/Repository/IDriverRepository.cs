using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IDriverRepository
    {
        IEnumerable<Driver> GetAll();
        Driver? GetById(string id);
        void Add(Driver driver);
        void Update(Driver driver);
        void Remove(string id);
    }
}
