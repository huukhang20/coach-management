using CoachManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CoachRepository : ICoachRepository
    {
        public void Add(Coach coach) => CoachDAO.Instance.Add(coach);

        public IEnumerable<Coach> GetAll() => CoachDAO.Instance.GetAll();

        public Coach? GetByNumberPlate(string numberPlate) => CoachDAO.Instance.GetByNumberPlate(numberPlate);

        public void Remove(string numberPlate) => CoachDAO.Instance.Remove(numberPlate);

        public void Update(Coach coach) => CoachDAO.Instance.Update(coach);
    }
}
