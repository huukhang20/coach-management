using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DriverDAO
    {
        private static DriverDAO? instance;
        private static readonly object instanceLock = new object();
        private DriverDAO() { }
        public static DriverDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new DriverDAO();
                    return instance;
                }
            }
        }

        public IEnumerable<Driver> GetAll()
        {
            using var context = new CoachManagementContext();
            var list = context.Drivers.Include(d => d.NumberPlateNavigation).ToList();
            return list;
        }

        public Driver? GetById(string id)
        {
            using var context = new CoachManagementContext();
            var driver = context.Drivers.Include(d => d.NumberPlateNavigation).SingleOrDefault(c => c.Id.Equals(id));
            return driver;
        }

        public void Add(Driver driver)
        {
            Driver? oldDriver = GetById(driver.Id);
            if (oldDriver == null)
            {
                using var context = new CoachManagementContext();
                context.Drivers.Add(driver);
                context.SaveChanges();
            }
            else throw new Exception("The id already exists");
        }

        public void Update(Driver driver)
        {
            Driver? oldDriver = GetById(driver.Id);
            if (oldDriver != null)
            {
                using var context = new CoachManagementContext();
                context.Drivers.Update(driver);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }

        public void Remove(string id)
        {
            var driver = GetById(id);
            if (driver != null)
            {
                using var context = new CoachManagementContext();
                context.Drivers.Remove(driver);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }
    }
}
