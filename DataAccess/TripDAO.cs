using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TripDAO
    {
        private static TripDAO? instance;
        private static readonly object instanceLock = new object();
        private TripDAO() { }
        public static TripDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new TripDAO();
                    return instance;
                }
            }
        }

        public IEnumerable<Trip> GetAll()
        {
            using var context = new CoachManagementContext();
            var list = context.Trips.Include(t => t.NumberPlateNavigation).ToList();
            return list;
        }

        public Trip? GetById(long id)
        {
            using var context = new CoachManagementContext();
            var trip = context.Trips.Include(t => t.NumberPlateNavigation).SingleOrDefault(c => c.Id == id);
            return trip;
        }

        public void Add(Trip trip)
        {
            Trip? oldTrip = GetById(trip.Id);
            if (oldTrip == null)
            {
                if (!(CoachDAO.Instance.GetByNumberPlate(trip.NumberPlate)?.Active ?? true))
                    throw new Exception("The coach is inactive");
                using var context = new CoachManagementContext();
                context.Trips.Add(trip);
                context.SaveChanges();
            }
            else throw new Exception("The id already exists");
        }

        public void Update(Trip trip)
        {
            Trip? oldTrip = GetById(trip.Id);
            if (oldTrip != null)
            {
                if (!(CoachDAO.Instance.GetByNumberPlate(trip.NumberPlate)?.Active ?? true))
                    throw new Exception("The coach is inactive");
                using var context = new CoachManagementContext();
                context.Trips.Update(trip);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }

        public void Remove(long id)
        {
            var trip = GetById(id);
            if (trip != null)
            {
                using var context = new CoachManagementContext();
                context.Trips.Remove(trip);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }
    }
}
