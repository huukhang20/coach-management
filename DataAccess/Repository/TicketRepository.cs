using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TicketRepository : ITicketRepository
    {
        public void Add(Ticket ticket) => TicketDAO.Instance.Add(ticket);

        public IEnumerable<Ticket> GetAll() => TicketDAO.Instance.GetAll();

        public Ticket? GetById(long id) => TicketDAO.Instance.GetById(id);

        public void Remove(long id) => TicketDAO.Instance.Remove(id);

        public void Update(Ticket ticket) => TicketDAO.Instance.Update(ticket);
    }
}
