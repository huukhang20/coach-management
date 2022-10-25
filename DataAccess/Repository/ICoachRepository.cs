using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICoachRepository
    {
        IEnumerable<Coach> GetAll();
        Coach? GetByNumberPlate(string numberPlate);
        void Add(Coach coach);
        void Update(Coach coach);
        void Remove(string numberPlate);
    }
}
