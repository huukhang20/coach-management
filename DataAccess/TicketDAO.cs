using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TicketDAO
    {
        private static TicketDAO? instance;
        private static readonly object instanceLock = new object();
        private TicketDAO() { }
        public static TicketDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new TicketDAO();
                    return instance;
                }
            }
        }

        public IEnumerable<Ticket> GetAll()
        {
            using var context = new CoachManagementContext();
            var list = context.Tickets
                .Include(t => t.Trip)
                .Include(t => t.Passenger)
                .ToList();
            return list;
        }

        public Ticket? GetById(long id)
        {
            using var context = new CoachManagementContext();
            var ticket = context.Tickets
                .Include(t => t.Passenger)
                .Include(t => t.Trip)
                .SingleOrDefault(c => c.Id == id);
            return ticket;
        }

        public void Add(Ticket ticket)
        {
            Ticket? oldTicket = GetById(ticket.Id);
            if (oldTicket == null)
            {
                if (TripDAO.Instance.GetById(ticket.TripId)!.Status != 0)
                    throw new Exception("The trip has departed or been canceled");

                using var context = new CoachManagementContext();
                context.Tickets.Add(ticket);
                context.SaveChanges();
            }
            else throw new Exception("The id already exists");
        }

        public void Update(Ticket ticket)
        {
            Ticket? oldTicket = GetById(ticket.Id);
            if (oldTicket != null)
            {
                using var context = new CoachManagementContext();
                context.Tickets.Update(ticket);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }

        public void Remove(long id)
        {
            var ticket = GetById(id);
            if (ticket != null)
            {
                using var context = new CoachManagementContext();
                context.Tickets.Remove(ticket);
                context.SaveChanges();
            }
            else throw new Exception("The id does not exist");
        }
    }
}
