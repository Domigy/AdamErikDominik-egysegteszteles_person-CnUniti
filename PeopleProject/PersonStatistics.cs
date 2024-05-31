using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class PersonStatistics
    {
        public List<Person> persons;

        public PersonStatistics(List<Person> persons)
        {
            this.persons = persons;
            Persons = persons ?? throw new ArgumentNullException(nameof(persons));
        }
   

        internal List<Person> Persons { get => persons; private set => persons = value; }
        public double GetAverageAge()
        {
            return Persons.Average(p => p.Age);
        }

        public int GetNumberOfStudents()
        {
            return Persons.Count(p => p.IsStudent);
        }

        public Person GetPersonWithHighestScore()
        {
            return Persons.OrderByDescending(p => p.Score).FirstOrDefault();
        }

        public double GetAverageScoreOfStudents()
        {
            var students = Persons.Where(p => p.IsStudent);
            return students.Any() ? students.Average(p => p.Score) : 0;
        }

        public Person GetOldestStudent()
        {
            return Persons.Where(p => p.IsStudent).OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public bool IsAnyoneFailing()
        {
            return Persons.Any(p => p.Score < 40);
        }
    }
}
