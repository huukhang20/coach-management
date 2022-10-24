using CoachManagement;

namespace DataAccess
{
    public class CoachDAO
    {
        private static CoachDAO? instance;
        private static readonly object instanceLock = new object();
        private CoachDAO() { }
        public static CoachDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new CoachDAO();
                    return instance;
                }
            }
        }

        public IEnumerable<Coach> GetAll()
        {
            using var context = new CoachManagementContext();
            var coaches = context.Coaches.ToList();
            return coaches;
        }

        public Coach? GetByNumberPlate(string numberPlate)
        {
            using var context = new CoachManagementContext();
            var coach = context.Coaches.SingleOrDefault(c => c.NumberPlate.Equals(numberPlate));
            return coach;
        }

        public void Add(Coach coach)
        {
            Coach? oldCoach = GetByNumberPlate(coach.NumberPlate);
            if (oldCoach == null)
            {
                using var context = new CoachManagementContext();
                context.Coaches.Add(coach);
                context.SaveChanges();
            }
            else throw new Exception("The number plate already exists");
        }

        public void Update(Coach coach)
        {
            Coach? oldCoach = GetByNumberPlate(coach.NumberPlate);
            if (oldCoach != null)
            {
                using var context = new CoachManagementContext();
                context.Coaches.Update(coach);
                context.SaveChanges();
            }
            else throw new Exception("The number plate does not exist");
        }

        public void Remove(string numberPlate)
        {
            var coach = GetByNumberPlate(numberPlate);
            if (coach != null)
            {
                using var context = new CoachManagementContext();
                context.Coaches.Remove(coach);
                context.SaveChanges();
            }
            else throw new Exception("The number plate does not exist");
        }
    }
}