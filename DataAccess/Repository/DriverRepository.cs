using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class DriverRepository : IDriverRepository
    {
        public void Add(Driver driver) => DriverDAO.Instance.Add(driver);

        public IEnumerable<Driver> GetAll() => DriverDAO.Instance.GetAll();

        public Driver? GetById(string id) => DriverDAO.Instance.GetById(id);

        public void Remove(string id) => DriverDAO.Instance.Remove(id);

        public void Update(Driver driver) => DriverDAO.Instance.Update(driver);
    }
}
