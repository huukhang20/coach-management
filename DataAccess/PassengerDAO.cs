using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PassengerDAO
    {
        private static PassengerDAO? instance;
        private static readonly object instanceLock = new object();
        private PassengerDAO() { }
        public static PassengerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new PassengerDAO();
                    return instance;
                }
            }
        }

        public IEnumerable<Passenger> GetAll()
        {
            using var context = new CoachManagementContext();
            var list = context.Passengers.ToList();
            return list;
        }

        public Passenger? GetById(string id)
        {
            using var context = new CoachManagementContext();
            var passenger = context.Passengers.SingleOrDefault(c => c.Id.Equals(id));
            return passenger;
        }

        public void Add(Passenger passenger)
        {
            Passenger? oldPassenger = GetById(passenger.Id);
            if (oldPassenger == null)
            {
                using var context = new CoachManagementContext();
                context.Passengers.Add(passenger);
                context.SaveChanges();
            }
            else throw new Exception("The id already exists");
        }

        public void Update(Passenger passenger)
        {
            Passenger? oldPassenger = GetById(passenger.Id);
            if (oldPassenger != null)
            {
                using var context = new CoachManagementContext();
                context.Passengers.Update(passenger);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }

        public void Remove(string id)
        {
            var passenger = GetById(id);
            if (passenger != null)
            {
                using var context = new CoachManagementContext();
                context.Passengers.Remove(passenger);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }
    }
}
