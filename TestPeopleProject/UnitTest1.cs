using TestPeopleProject;
namespace TestPeopleProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
    [TestFixture]
    public class PersonStatisticsTests
    {
        [Test]
        public void TestGetAverageAge()
        {
            List<Person> people = new List<Person>();
            Person ember1 = new Person(1, "Tamás", 20, true, 12);
            Person ember2 = new Person(2, "Dóra", 30, false, 43);
            Person ember3 = new Person(3, "Panna", 40, true, 76);
            people.Add(ember1);
            people.Add(ember2);
            people.Add(ember3);

            var stats = new PersonStatistics(people);

            Assert.AreEqual(30, stats.GetAverageAge());
        }
        [Test]
        public void TestGetNumberOfStudents()
        {
            List<Person> people = new List<Person>();
            Person ember1 = new Person(1, "Tamás", 20, true, 12);
            Person ember2 = new Person(2, "Dóra", 30, false, 43);
            Person ember3 = new Person(3, "Panna", 40, true, 76);
            people.Add(ember1);
            people.Add(ember2);
            people.Add(ember3);

            var stats = new PersonStatistics(people);

            Assert.AreEqual(2, stats.GetNumberOfStudents());
        }

        [Test]
        public void TestGetPersonWithHighestScore()
        {
            List<Person> people = new List<Person>();
            Person ember1 = new Person(1, "Tamás", 20, true, 12);
            Person ember2 = new Person(2, "Dóra", 30, false, 43);
            Person ember3 = new Person(3, "Panna", 40, true, 76);
            people.Add(ember1);
            people.Add(ember2);
            people.Add(ember3);

            var stats = new PersonStatistics(people);

            Assert.AreEqual(76, stats.GetPersonWithHighestScore().Score);
        }

        [Test]
        public void TestGetAverageScoreOfStudents()
        {
            List<Person> people = new List<Person>();
            Person ember1 = new Person(1, "Tamás", 20, true, 80);
            Person ember2 = new Person(2, "Dóra", 30, false, 90);
            Person ember3 = new Person(3, "Panna", 40, true, 70);
            people.Add(ember1);
            people.Add(ember2);
            people.Add(ember3);

            var stats = new PersonStatistics(people);

            Assert.AreEqual(75, stats.GetAverageScoreOfStudents());
        }

        [Test]
        public void TestGetOldestStudent()
        {
            List<Person> people = new List<Person>();
            Person ember1 = new Person(1, "Tamás", 20, true, 12);
            Person ember2 = new Person(2, "Dóra", 30, false, 43);
            Person ember3 = new Person(3, "Panna", 40, true, 95);
            people.Add(ember1);
            people.Add(ember2);
            people.Add(ember3);

            var stats = new PersonStatistics(people);

            Assert.AreEqual(40, stats.GetOldestStudent().Age);
        }

        [Test]
        public void TestIsAnyoneFailing()
        {
            List<Person> people = new List<Person>();
            Person ember1 = new Person(1, "Tamás", 20, true, 12);
            Person ember2 = new Person(2, "Dóra", 30, false, 43);
            Person ember3 = new Person(3, "Panna", 40, true, 76);
            people.Add(ember1);
            people.Add(ember2);
            people.Add(ember3);

            var stats = new PersonStatistics(people);

            Assert.IsTrue(stats.IsAnyoneFailing());
        }

    }
}