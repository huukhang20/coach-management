using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DriverTest
    {
        private IDriverRepository driverRepository = new DriverRepository();
        private ICoachRepository coachRepository = new CoachRepository();

        [Test]
        public void Add()
        {
            Coach coach1 = new Coach("test", 10, true, null, null);
            Coach coach2 = new Coach("test1", 20, true, null ,null);
            coachRepository.Add(coach1);
            coachRepository.Add(coach2);

            Driver driver1 = new Driver("driver1", "a", "HCM", DateTime.Now, "test");
            Assert.DoesNotThrow(() => driverRepository.Add(driver1));
        }

        [Test]
        public void Update_SetNumberPlateStr()
        {
            Driver driver = driverRepository.GetById("driver1")!;
            driver.NumberPlate = "test1";
            Assert.DoesNotThrow(() => driverRepository.Update(driver));
        }

        [Test]
        public void Update_SetNumberPlateObj()
        {
            Coach coach = coachRepository.GetByNumberPlate("test1")!;
            Driver driver = driverRepository.GetById("driver1")!;
            driver.NumberPlateNavigation = coach;
            Assert.DoesNotThrow(() => driverRepository.Update(driver));
        }
    }
}
