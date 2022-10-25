using BusinessObject;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;

namespace Test
{
    public class CoachTest
    {
        private ICoachRepository repository = new CoachRepository();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAll()
        {
            Assert.DoesNotThrow(() => repository.GetAll());
        }

        [Test, Order(1)]
        public void Add_Success()
        {
            string numberPlate = "TestNumberPlate";
            Coach coach = new Coach(numberPlate, 20, true, null, null);
            repository.Add(coach);
            Assert.That(repository.GetByNumberPlate(numberPlate)?.NumberPlate, Is.EqualTo(numberPlate));
        }

        [Test, Order(2)]
        public void Add_Duplicate()
        {
            string numberPlate = "TestNumberPlate";
            Coach coach = new Coach(numberPlate, 10, true, null, null);
            Assert.Throws<Exception>(() => repository.Add(coach));
        }

        [TestCase("FalseNumberPlate", null), Order(2)]
        [TestCase("TestNumberPlate", "TestNumberPlate")]
        public void GetByNumberPlate(string numberPlate, string expected)
        {
            Assert.That(repository.GetByNumberPlate(numberPlate)?.NumberPlate, Is.EqualTo(expected));
        }

        [Test, Order(2)]
        public void Update()
        {
            string numberPlate = "TestNumberPlate";
            Coach coach = repository.GetByNumberPlate(numberPlate)!;
            coach.Seats = 50;
            repository.Update(coach);
            Assert.That(repository.GetByNumberPlate(numberPlate)?.Seats, Is.EqualTo(50));
        }

        [Test, Order(3)]
        public void Remove()
        {
            string numberPlate = "TestNumberPlate";
            repository.Remove(numberPlate);
            Assert.Null(repository.GetByNumberPlate(numberPlate));
        }
    }
}